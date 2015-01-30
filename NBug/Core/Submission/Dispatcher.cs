// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Dispatcher.cs" company="NBug Project">
//   Copyright (c) 2011 - 2013 Teoman Soygul. Licensed under MIT license.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBug.Core.Submission
{
    using System;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    using NBug.Core.Reporting.Info;
    using NBug.Core.Util.Logging;
    using NBug.Core.Util.Serialization;
    using NBug.Core.Util.Storage;

    public static class Dispatcher
    {
        private static CancellationTokenSource cancellationTokenSource;

        private static CancellationToken cancellationToken;

        private static Task task;

        /// <summary>
        /// Initializes a new instance of the Dispatcher class to send queued reports.
        /// </summary>
        /// <param name="isAsynchronous">
        /// Decides whether to start the dispatching process asynchronously on a background thread.
        /// </param>
        public static void Start()
        {
            // Test if it has NOT been more than x many days since entry assembly was last modified)
            // This is the exact verifier code in the BugReport.cs of CreateReportZip() function
            if (Settings.StopReportingAfter >= 0
                && File.GetLastWriteTime(Settings.EntryAssembly.Location)
                       .AddDays(Settings.StopReportingAfter)
                       .CompareTo(DateTime.Now) <= 0)
            {
                Logger.Info("Dispatcher not needed");
                return;
            }

            if (task != null && 
                (task.Status == TaskStatus.Running 
                || task.Status == TaskStatus.WaitingForActivation
                || task.Status == TaskStatus.WaitingToRun))
            {
                cancellationTokenSource.Cancel();
            }

            cancellationTokenSource = new CancellationTokenSource();
            cancellationToken = cancellationTokenSource.Token;
            task = Task.Factory.StartNew(Dispatch, cancellationToken).ContinueWith(t => Logger.Error("An exception occurred while dispatching bug report. Check the inner exception for details", t.Exception), TaskContinuationOptions.OnlyOnFaulted);
        }

        private static void Dispatch()
        {
            Logger.Info(string.Format("Dispatcher started ThreadId={0}", Thread.CurrentThread.ManagedThreadId));

            // Make sure that we are not interfering with the crucial startup work);
            if (!Settings.RemoveThreadSleep)
            {
                Thread.Sleep(Settings.SleepBeforeSend * 1000);
            }

            // Truncate extra report files and try to send the first one in the queue
            Storer.TruncateReportFiles();

            // Now go through configured destinations and submit to all automatically
            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();

                using (var storer = new Storer())
                using (var stream = storer.GetFirstReportFile())
                {
                    if (stream != null)
                    {   
                        // Extract crash/exception report data from the zip file. Delete the zip file if no data can be retrieved (i.e. corrupt file)
                        ExceptionData exceptionData;
                        try
                        {
                            exceptionData = GetDataFromZip(stream);
                        }
                        catch (Exception exception)
                        {
                            storer.DeleteCurrentReportFile();
                            Logger.Error("An exception occurred while extraction report data from zip file. Check the inner exception for details.", exception);
                            continue;
                        }

                        var message = string.Format(
                            "Dispatcher ThreadId={0} sends {1}",
                            Thread.CurrentThread.ManagedThreadId, 
                            exceptionData.Report.GeneralInfo.UserDescription);
                        Logger.Info(message);

                        // Now submit the report file to all configured bug report submission targets
                        if (EnumerateDestinations(stream, exceptionData))
                        {
                            storer.DeleteCurrentReportFile();
                        }
                    }
                    else
                    {
                        Logger.Info(string.Format("Dispatcher ended ThreadId={0}", Thread.CurrentThread.ManagedThreadId));
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Enumerate all protocols to see if they are properly configured and send using the ones that are configured
        /// as many times as necessary.
        /// </summary>
        /// <param name="reportFile">The file to read the report from.</param>
        /// <returns>Returns <see langword="true"/> if the sending was successful.
        /// Returns <see langword="true"/> if the report was submitted to at least one destination.</returns>
        private static bool EnumerateDestinations(Stream reportFile, ExceptionData exceptionData)
        {
            var sentSuccessfullyAtLeastOnce = false;
            var fileName = Path.GetFileName(((FileStream)reportFile).Name);
            foreach (var destination in Settings.Destinations)
            {
                try
                {
                    Logger.Trace(string.Format("Submitting bug report via {0}.", destination.GetType().Name));
                    if (destination.Send(fileName, reportFile, exceptionData.Report, exceptionData.Exception))
                    {
                        sentSuccessfullyAtLeastOnce = true;
                    }
                }
                catch (Exception exception)
                {
                    Logger.Error(
                        string.Format("An exception occurred while submitting bug report with {0}. Check the inner exception for details.", destination.GetType().Name),
                        exception);
                }
            }

            return sentSuccessfullyAtLeastOnce;
        }

        private static ExceptionData GetDataFromZip(Stream stream)
        {
            var results = new ExceptionData();
            var zipStorer = ZipStorer.Open(stream, FileAccess.Read);
            using (Stream zipItemStream = new MemoryStream())
            {
                var zipDirectory = zipStorer.ReadCentralDir();
                foreach (var entry in zipDirectory)
                {
                    if (Path.GetFileName(entry.FilenameInZip) == StoredItemFile.Exception)
                    {
                        zipItemStream.SetLength(0);
                        zipStorer.ExtractFile(entry, zipItemStream);
                        zipItemStream.Position = 0;
                        var deserializer = new XmlSerializer(typeof(SerializableException));
                        results.Exception = (SerializableException)deserializer.Deserialize(zipItemStream);
                        zipItemStream.Position = 0;
                    }
                    else if (Path.GetFileName(entry.FilenameInZip) == StoredItemFile.Report)
                    {
                        zipItemStream.SetLength(0);
                        zipStorer.ExtractFile(entry, zipItemStream);
                        zipItemStream.Position = 0;
                        var deserializer = new XmlSerializer(typeof(Report));
                        results.Report = (Report)deserializer.Deserialize(zipItemStream);
                        zipItemStream.Position = 0;
                    }
                }
            }

            return results;
        }

        private class ExceptionData
        {
            public SerializableException Exception { get; set; }

            public Report Report { get; set; }
        }

        public static void WaitForExit()
        {
            if (task != null)
            {
                try
                {
                    task.Wait();
                }
                catch
                {
                }
            }    
        }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BugReport.cs" company="NBug Project">
//   Copyright (c) 2011 - 2013 Teoman Soygul. Licensed under MIT license.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBug.Core.Reporting
{
	using System;
	using System.IO;
	using System.Xml.Serialization;

	using NBug.Core.Reporting.Info;
	using NBug.Core.Reporting.MiniDump;
	using NBug.Core.UI;
	using NBug.Core.Util;
	using NBug.Core.Util.Logging;
	using NBug.Core.Util.Serialization;
	using NBug.Core.Util.Storage;

	internal class BugReport
	{
		/// <summary>
		/// First parameters is the serializable exception object that is about to be processed, second parameter is any custom data
		/// object that the user wants to include in the report.
		/// </summary>
		internal static event Action<Exception, Report> ProcessingException;

		internal ExecutionFlow Report(Exception exception, ExceptionThread exceptionThread)
		{
			try
			{
				Logger.Trace("Starting to generate a bug report for the exception.");
				var serializableException = new SerializableException(exception);
				var report = new Report(serializableException);

				var handler = ProcessingException;
				if (handler != null)
				{
					Logger.Trace("Notifying the user before handling the exception.");

					// Allowing user to add any custom information to the report
					handler(exception, report);
				}

				var uiDialogResult = UISelector.DisplayBugReportUI(exceptionThread, serializableException, report);
				if (uiDialogResult.Report == SendReport.Send)
				{
					CreateReportZip(serializableException, report);
				}

				// If NBug is configured not to delay error reporting and user did not select to exit the app immediately,
				// start dispatching the bug report right away
				if (!Settings.DeferredReporting && uiDialogResult.Execution == ExecutionFlow.ContinueExecution)
				{
					new Submission.Dispatcher();
				}

				return uiDialogResult.Execution;
			}
			catch (Exception ex)
			{
				Logger.Error("An exception occurred during bug report generation process. See the inner exception for details.", ex);
				return ExecutionFlow.BreakExecution; // Since an internal exception occured
			}
		}

		private void CreateReportZip(SerializableException serializableException, Report report)
		{
			// Check if the max number of days to send bug reports has not been exceeded
			int maxReportingDays = Settings.StopReportingAfter;
			if (IsMaxReportingDaysExceeded(maxReportingDays))
			{
				HandleMaxReportingDaysExceeded();
				return;
			}

			// Check the report zip files limit
			int currentReportCount = Storer.GetReportCount();
			if (IsMaxQueuedReportCountExceeded(currentReportCount))
			{
				HandleMaxQueuedReportCountExceeded();
				return;
			}

			// Create the zip file
			using (var zipFile = NbugZipFile.Create(ZipReportFileName))
			{
				zipFile.AddException(serializableException);
				zipFile.AddReport(report);
				zipFile.AddMiniDump(MiniDumpFilePath);
				zipFile.AddAdditionalReportFiles(Settings.AdditionalReportFiles);
			}

			Logger.Trace(
				string.Format("Created a new report file. Currently the number of report files queued to be send is: {0}",
				currentReportCount)
		);
	}

		/// <summary>
		/// Test if it has NOT been more than x many days since the entry assembly was last modified
		/// </summary>
		/// <returns></returns>
		private bool IsMaxReportingDaysExceeded(int maxReportingDays)
		{
			var lastWriteTime = File.GetLastWriteTime(Settings.EntryAssembly.Location);
			var maxReportingDate = lastWriteTime.AddDays(maxReportingDays);

			return maxReportingDays >= 0 && DateTime.Now >= maxReportingDate;
		}

		private static void HandleMaxReportingDaysExceeded()
		{
			int stopReportingDays = Settings.StopReportingAfter;

			Logger.Trace(
				string.Format(
				"As per setting 'Settings.StopReportingAfter({0})', bug reporting feature was enabled for a certain amount of time which has now expired: Bug reporting is now disabled.",
				stopReportingDays)
			);

			// Truncate all the bug reports files:
			// ToDo: Completely eliminate this with SettingsOverride.DisableReporting = true; since enumerating filesystem adds overhead);
			if (Storer.GetReportCount() > 0)
			{
				Logger.Trace(
					string.Format(
					"As per setting 'Settings.StopReportingAfter({0})', " +
					"bug reporting feature was enabled for a certain amount of time which has now expired: Truncating all expired bug reports.",
					stopReportingDays)
				);

				Storer.TruncateReportFiles(0);
			}
	}

	/// <summary>
	/// Test if there is already more than enough queued report files
	/// </summary>
	private bool IsMaxQueuedReportCountExceeded(int reportCount)
	{
		int maxQueuedReports = Settings.MaxQueuedReports;

		return maxQueuedReports >= 0 && reportCount >= maxQueuedReports;
	}

	private void HandleMaxQueuedReportCountExceeded()
	{
		Logger.Trace(
			string.Format(
			"Current report count is at its limit as per 'Settings.MaxQueuedReports ({0})' setting: Skipping bug report generation.",
			Settings.MaxQueuedReports)
		);
	}

	private string ZipReportFileName
	{
		get
		{
			return "Exception_" + DateTime.UtcNow.ToFileTime() + ".zip";
		}
	}

	private string MiniDumpFilePath
	{
		get
		{
			var filePath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
			var fileName = "Exception_MiniDump_" + DateTime.UtcNow.ToFileTime() + ".mdmp";
			return Path.Combine(filePath, fileName);
		}
	}

	private void WindowsScreenshot(Stream stream)
		{
			// Full
			/*Rectangle bounds = Screen.GetBounds(Point.Empty);
			using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
			{
				using (Graphics g = Graphics.FromImage(bitmap))
				{
					g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
				}
				bitmap.Save("test.jpg", ImageFormat.Jpeg);
			}*/

			// Window
			/*Rectangle bounds = this.Bounds;
			using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
			{
				using (Graphics g = Graphics.FromImage(bitmap))
				{
					g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
				}
				bitmap.Save("C://test.jpg", ImageFormat.Jpeg);
			}*/
		}
	}
}
namespace NBug.Core.Util.Storage
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Xml.Serialization;
	using Logging;
	using Reporting.Info;
	using Reporting.MiniDump;
	using Serialization;

	/// <summary>
	/// Represents an NBUG zip file. This zip file can contain:
	/// An exception stored as an XML file
	/// A report stored as an XML file
	/// A Minidump file
	/// Additional files
	/// </summary>
	internal class NbugZipFile : IDisposable
	{
		private readonly ZipStorer _zipfile;

		// Use the static Create method to create a new NbugZipFile
		private NbugZipFile(string zipFileName)
		{
			Stream zipFileStream = new Storer().CreateReportFile(zipFileName);
			_zipfile = ZipStorer.Create(zipFileStream, string.Empty);
		}

		/// <summary>
		/// Creates a new ZIP file at the given path (zipFileName)
		/// </summary>
		/// <param name="zipFileName">The path of the zip file to create</param>
		/// <returns>An NbugZipFile object</returns>
		public static NbugZipFile Create(string zipFileName)
		{
			return new NbugZipFile(zipFileName);
		}

		/// <summary>
		/// Store the exception into this zip file as an XML file
		/// </summary>
		public void AddException(SerializableException serializableException)
		{
			using (var stream = new MemoryStream())
			{
				var serializer = new XmlSerializer(typeof(SerializableException));
				serializer.Serialize(stream, serializableException);

				// We need to rewind to the beginning of the stream before adding the stream to the zip file!
				stream.Position = 0;
				_zipfile.AddStream(ZipStorer.Compression.Deflate, StoredItemFile.Exception, stream, DateTime.UtcNow, string.Empty);
			}
		}

		/// <summary>
		/// Store the report into this zip file as an XML file
		/// </summary>
		public void AddReport(Report report)
		{
			using (var stream = new MemoryStream())
			{
				XmlSerializer serializer;

				try
				{
					serializer = report.CustomInfo != null
						? new XmlSerializer(typeof(Report), new[] {report.CustomInfo.GetType()})
						: new XmlSerializer(typeof(Report));

					serializer.Serialize(stream, report);
				}
				catch (Exception exception)
				{
					Logger.Error(
						string.Format(
							"The given custom info of type [{0}] cannot be serialized. Make sure that given type and inner types are XML serializable.",
							report.CustomInfo.GetType()),
						exception);
					report.CustomInfo = null;

					serializer = new XmlSerializer(typeof(Report));
					serializer.Serialize(stream, report);
				}

				// We need to rewind to the beginning of the stream before adding the stream to the zip file!
				stream.Position = 0;
				_zipfile.AddStream(ZipStorer.Compression.Deflate, StoredItemFile.Report, stream, DateTime.UtcNow, string.Empty);
			}
		}

		/// <summary>
		/// Store the minidump file into this zip file
		/// </summary>
		public void AddMiniDump(string minidumpFilePath)
		{
			if (!DumpWriter.CanWrite()) return;

			if (DumpWriter.Write(minidumpFilePath))
			{
				_zipfile.AddFile(ZipStorer.Compression.Deflate, minidumpFilePath, StoredItemFile.MiniDump, string.Empty);
				File.Delete(minidumpFilePath);
			}
		}

		/// <summary>
		/// Add any user supplied files in the report (if any)
		/// </summary>
		public void AddAdditionalReportFiles(List<FileMask> additionalReportFiles)
		{
			if (additionalReportFiles.Count == 0) return;

			// ToDo: PRIORITY TASK! This code needs more testing & condensation
			// ToDo: This needs a lot more work!
			foreach (FileMask additionalFiles in additionalReportFiles)
			{
				additionalFiles.AddToZip(_zipfile);
			}
		}

		public void Dispose()
		{
			_zipfile.Dispose();
		}
	}
}
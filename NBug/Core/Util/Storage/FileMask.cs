using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NBug.Core.Util.Storage
{
    public class FileMask
    {
        /// <summary>
        /// Gets or sets a the file path. The files can use * or ? in the same way as DOS modifiers.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the the kind of access other processes can have access to the file white it's being zipped for the report.
        /// Defaults to FileShare.Read but other files might require FileShare.ReadWrite
        /// (i.e. log4net log files that are constantly open and can only be access with FileShare.ReadWrite).
        /// </summary>
        public FileShare FileShare { get; set; }

        public FileMask(String path)
        {
            this.FilePath = path;
            FileShare = FileShare.Read;
        }

        public static implicit operator String(FileMask o)
        {
            return o == null ? null : o.FilePath;
        }

        public static implicit operator FileMask(String o)
        {
            return o == null ? null : new FileMask(o);
        }

        /// <summary>
        /// Add all additional files represented by this instance to the zip file using the zipStorer
        /// </summary>
        /// <param name="zipStorer"></param>
        internal void AddToZip(ZipStorer zipStorer)
        {
            // Join before spliting because the mask may have some folders inside it
            var fullPath = Path.Combine(Settings.NBugDirectory, FilePath);
            var dir = Path.GetDirectoryName(fullPath);
            var file = Path.GetFileName(fullPath);

            if (!Directory.Exists(dir))
            {
                return;
            }

            if (file.Contains("*") || file.Contains("?"))
            {
                foreach (var item in Directory.GetFiles(dir, file))
                {
                    this.AddToZip(zipStorer, Settings.NBugDirectory, item, FileShare);
                }
            }
            else
            {
                this.AddToZip(zipStorer, Settings.NBugDirectory, fullPath, FileShare);
            }
        }

        // ToDo: PRIORITY TASK! This code needs more testing & condensation
        private void AddToZip(ZipStorer zipStorer, string basePath, string path, FileShare share)
        {
            path = Path.GetFullPath(path);

            // If this is not inside basePath, lets change the basePath so at least some directories are kept
            if (!path.StartsWith(basePath))
            {
                basePath = Path.GetDirectoryName(path);
            }

            if (Directory.Exists(path))
            {
                foreach (var file in Directory.GetFiles(path))
                {
                    this.AddToZip(zipStorer, basePath, file, share);
                }

                foreach (var dir in Directory.GetDirectories(path))
                {
                    this.AddToZip(zipStorer, basePath, dir, share);
                }
            }
            else if (File.Exists(path))
            {
                var nameInZip = path.Substring(basePath.Length);
                if (nameInZip.StartsWith("\\") || nameInZip.StartsWith("/"))
                {
                    nameInZip = nameInZip.Substring(1);
                }

                nameInZip = Path.Combine("files", nameInZip);

                using (Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare))
                {
                    zipStorer.AddStream(ZipStorer.Compression.Deflate, nameInZip, stream, File.GetLastWriteTime(path), string.Empty);
                }
            }
        }
    }
}

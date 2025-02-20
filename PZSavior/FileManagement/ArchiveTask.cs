using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vosiz.Helpers;

namespace PZSavior.FileManagement
{
    public class ArchiveTask
    {
        public string Source { get; private set; }
        public string Destination { get; private set; }
        public int FilesCount { get; private set; }
        public string[] FilesToArchive { get; private set; }

        public ArchiveTask(string src, string dest)
        {

            Source = src;
            Destination = dest;

            if (!Directory.Exists(src))
            {
                throw new ArgumentException($"Source path does not exist ({src})");
            }

            FilesToArchive = Directory.GetFiles(src);
            FilesCount = FilesToArchive.Length;
        }

        public async Task Execute(IProgress<int> progress)
        {
            // todo: progress and async

            var zip = new Vosiz.Utils.Archive.Zip();
            zip.ArchiveFolder(Source, Destination);
        }
    }
}

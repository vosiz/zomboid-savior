using PZSavior.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZSavior.FileManagement
{
    public class CopyTask
    {

        public string Source { get; private set; }
        public string Destination { get; private set; }
        public int FilesCount { get; private set; }
        public string[] FilesToCopy { get; private set; }

        public CopyTask(string src, string dest) {

            Source = src;
            Destination = dest;

            if (!Directory.Exists(src))
            {
                throw new ArgumentException($"Source path does not exist ({src})");
            }

            FilesToCopy = Directory.GetFiles(src);
            FilesCount = FilesToCopy.Length;
        }

        public async Task Execute(IProgress<int> progress) {

            await FileHelper.CopyDirectoryAsync(Source, Destination, progress);
        }
            

        

    }
}

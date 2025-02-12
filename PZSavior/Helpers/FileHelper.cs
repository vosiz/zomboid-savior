using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZSavior.Helpers
{
    public static class FileHelper
    {

        public static async Task CopyDirectoryAsync(string src, string dest, IProgress<int> progress)
        {

            Directory.CreateDirectory(dest);

            string[] files = Directory.GetFiles(src);
            string[] subdirectories = Directory.GetDirectories(src);

            int totalFiles = files.Length;
            int totalSubdirectories = subdirectories.Length;

            int filesCopied = 0;
            int subdirectoriesCopied = 0;

            // Copy all files in the source directory
            foreach (var file in files)
            {
                string destFile = Path.Combine(dest, Path.GetFileName(file));
                File.Copy(file, destFile, overwrite: true);

                // Report progress for files
                filesCopied++;
                int progressPercentage = (int)((float)(filesCopied + subdirectoriesCopied) / (totalFiles + totalSubdirectories) * 100);
                progress.Report(progressPercentage);

                await Task.Delay(10); // Optional: Add a small delay to simulate async work
            }

            // Recursively copy all subdirectories
            foreach (var subdirectory in subdirectories)
            {
                string destSubdirectory = Path.Combine(dest, Path.GetFileName(subdirectory));
                await CopyDirectoryAsync(subdirectory, destSubdirectory, progress); // Recursive call

                // Report progress for subdirectories
                subdirectoriesCopied++;
                int progressPercentage = (int)((float)(filesCopied + subdirectoriesCopied) / (totalFiles + totalSubdirectories) * 100);
                progress.Report(progressPercentage);
            }
        }
    }
}

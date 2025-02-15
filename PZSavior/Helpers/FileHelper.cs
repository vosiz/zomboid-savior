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

                // Check if the file exists and is newer in the source directory
                if (!File.Exists(destFile) || File.GetLastWriteTime(file) > File.GetLastWriteTime(destFile))
                {
                    File.Copy(file, destFile, overwrite: true);

                    // Report progress for files
                    filesCopied++;
                    int progressPercentage = (int)((float)(filesCopied + subdirectoriesCopied) / (totalFiles + totalSubdirectories) * 100);
                    progress.Report(progressPercentage);
                }

                await Task.Delay(1); // To ensure smoothness
            }

            // Copy all subdirectories
            foreach (var subdir in subdirectories)
            {
                string destSubdir = Path.Combine(dest, Path.GetFileName(subdir));

                // Recursively copy subdirectories if they don't exist
                if (!Directory.Exists(destSubdir))
                {
                    Directory.CreateDirectory(destSubdir);
                    await CopyDirectoryAsync(subdir, destSubdir, progress); // Recursive call
                }

                subdirectoriesCopied++;
                int subdirProgress = (int)((float)(filesCopied + subdirectoriesCopied) / (totalFiles + totalSubdirectories) * 100);
                progress.Report(subdirProgress);

                await Task.Delay(1); // To ensure smoothness
            }
        }

    }
}

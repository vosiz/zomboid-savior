using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PZSavior.FileManagement
{
    public class SaveManager
    {

        public CopyTask PrepareToCopy(string origin, string destination) {

            return new CopyTask(origin, destination);
        }

        public ArchiveTask PrepareToArchive(string origin, string destination) {

            return new ArchiveTask(origin, destination);
        }

        
    }
}

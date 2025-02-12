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

        CopyTask CurrentCopy;

        public CopyTask PrepareToCopy(string origin, string destination) {

            CurrentCopy = new CopyTask(origin, destination);

            return CurrentCopy;
        }

        
    }
}

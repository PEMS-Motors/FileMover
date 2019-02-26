using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMover.Modules
{
    class FileName
    {
        public string FullOrderName = System.IO.Path.GetFileName(Constants.FileLocations.Folders.HotFolder);
        public string FullPrimeName = System.IO.Path.GetFileName(Constants.FileLocations.Folders.PrimeFolder);
    }
}

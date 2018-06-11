using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorter.Entities
{
    class FileDetails
    {
        public string FileName { get; private set; }
        public string FullName { get; private set; }
        private string extension;
       
        public FileDetails(FileInfo info)
        {
            FileName = $"{info.Directory.Name}_{info.Name}";
            FullName = info.FullName;
            extension = info.Extension;
        }
    }
}

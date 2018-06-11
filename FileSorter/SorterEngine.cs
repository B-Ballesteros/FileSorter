using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorter
{
    class SorterEngine
    {

        private string folderPath;

        public SorterEngine(string folderPath)
        {
            this.folderPath = folderPath;
        }

        public FileInfo[] GetFiles()
        {
            var directoryInfo = new DirectoryInfo(folderPath);
            var info = directoryInfo.GetFiles("*", SearchOption.AllDirectories);
#if DEBUG
            foreach(var item in info)
            {
                Console.WriteLine(item.FullName);
            }
#endif
            return info;
        }
    }
}

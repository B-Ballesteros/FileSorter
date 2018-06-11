using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSorter.Entities;
namespace FileSorter
{
    class SorterEngine
    {

        private string folderPath;

        public SorterEngine(string folderPath)
        {
            this.folderPath = folderPath;
        }

        public List<FileDetails> GetFiles()
        {
            var directoryInfo = new DirectoryInfo(folderPath);
            var info = directoryInfo.GetFiles("*", SearchOption.AllDirectories);
            var detailsList = new List<FileDetails>();
            foreach(var item in info)
            {
                detailsList.Add(new FileDetails(item));
            }

#if DEBUG
           detailsList.ForEach(item => System.Diagnostics.Debug.WriteLine(item.FileName));
#endif
            return detailsList;
        }
    }
}

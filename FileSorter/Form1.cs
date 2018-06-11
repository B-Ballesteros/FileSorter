using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void SortFiles(string folderPath)
        {
            var engine = new SorterEngine(folderPath);
            var files = engine.GetFiles();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (fbdFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtDirectoryPath.Text = fbdFolderBrowser.SelectedPath;
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            var folderPath = txtDirectoryPath.Text;
            if (!string.IsNullOrEmpty(folderPath))
            {
                SortFiles(folderPath);
            }
            
        }
    }
}

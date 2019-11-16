using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using ClassLibrary;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        Regex fileRegex = new Regex(@"^.+\..+$");

        public Form1()
        {
            InitializeComponent();
        }

        private string GetAllFiles(string[] path)
        {
            string result = null;
            foreach (var file in path)
            {
                if (fileRegex.IsMatch(file))
                {
                    result += file + Environment.NewLine;
                }
                else
                {
                    foreach (FileInfo item in new DirectoryInfo(file).GetFiles("*", SearchOption.AllDirectories))
                    {
                        result += item.FullName + Environment.NewLine;
                    }
                }
            }
            return result;
        }

        private void textBoxListFiles_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            textBoxListFiles.Text = GetAllFiles(files);
        }

        private void textBoxListFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private string[] getFilePath()
        {
            return textBoxListFiles.Text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }

        private void toolStripMenuItemEncrypt_Click(object sender, EventArgs e)
        {
            FileManager fileManager = new FileManager(getFilePath());
            fileManager.EncryptFile();
        }

        private void toolStripMenuItemDecrypt_Click(object sender, EventArgs e)
        {
            FileManager fileManager = new FileManager(getFilePath());
            fileManager.DecryptFile();
        }

        private void toolStripMenuItemArchive_Click(object sender, EventArgs e)
        {
            FileManager fileManager = new FileManager(getFilePath());
            fileManager.CompressFile();
        }

        private void toolStripMenuItemUnarchive_Click(object sender, EventArgs e)
        {
            FileManager fileManager = new FileManager(getFilePath());
            fileManager.DecompressFile();
        }

        private void buttonChooseFiles_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = "c:\\";
                fileDialog.Filter = "txt files (*.txt*)|*.txt|All files (*.*)|*.*";
                fileDialog.FilterIndex = 2;
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxListFiles.Text += fileDialog.FileName + Environment.NewLine;
                }
            }
        }

        private void buttonClearFiles_Click(object sender, EventArgs e)
        {
            textBoxListFiles.Text = null;
        }
    }
}

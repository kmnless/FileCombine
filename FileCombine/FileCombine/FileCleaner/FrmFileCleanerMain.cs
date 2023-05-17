using FileProcessor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCombine.FileCleaner
{

    public partial class FrmFileCleanerMain : Form
    {

        Finder finder = new Finder();
        public string[] dirPatterns =
            {
                ".vs",
                ".DS_Store",
                "Debug",
                "bin",
                "debug",
                "obj",
                "project"
            };

        public string[] filePatterns =
            {
                "*.exe",
                "*.jpg",
                "*.txt",
                "*.wav",
                "*.mp3",
                "*.mp4",
                "*.pdf",
                "*.docx",
                "*.png",
                "*.ram",
                "*.zip",
                "*.xlsx",
                "*.xls",
                "*.wpd",
                "*.rar",
                "*.pptx",
                "*.bmp",
                "*.cs",
                "*.csproj"
            };

        public FrmFileCleanerMain()
        {
            InitializeComponent();
            listView1.CheckBoxes = true;

            //string path = "C:\\Users\\silver\\Desktop\\cleaner_test";



            //Analyzer analyzer = new Analyzer();
            //analyzer.Analyze(path);

            //ObjectContainer container = analyzer.Container;

            //MessageBox.Show("");


        }

        private void btnSetRootDir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                rootTextBox.Text = folderBrowserDialog1.SelectedPath;
                listBox1.Items.AddRange(dirPatterns);
                listBox2.Items.AddRange(filePatterns);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var check = listView1.CheckedItems;

            foreach (ListViewItem item in check)
            {

                FileInfo fileInfo;
                DirectoryInfo directoryInfo;

                fileInfo = new FileInfo(item.Text);
                directoryInfo = new DirectoryInfo(item.Text);

                if (fileInfo.Exists)
                {
                    File.Delete(fileInfo.FullName);
                }
                else
                {
                    Directory.Delete(directoryInfo.FullName, true);
                }

                listView1.Items.Remove(item);
            }
        }


        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            finder.DirMasks = dirPatterns;
            finder.FileMasks = filePatterns;

            finder.FindAll(rootTextBox.Text);

            //ObjectContainer objectContainer;
            //objectContainer = finder.Container;

            finder.Container.Dirs.ForEach(dir => { listView1.Items.Add(dir.FullName); });

            finder.Container.Files.ForEach(file => { listView1.Items.Add(file.FullName); });

            label1.Text = "Count: " + finder.Container.Files.Count.ToString();

            long size = 0;
            foreach (var files in finder.Container.Files)
            {
                size += files.Length;
            }

            label2.Text = "Full size: " + size.ToString() + " bytes";

        }

        private void btnSetDirPatterns_Click_1(object sender, EventArgs e)
        {
            string item = textBox2.Text;
            listBox1.Items.Add(item);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string item = textBox1.Text;
            listBox2.Items.Add(item);
        }
    }
}

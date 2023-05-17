using FileProcessor;
using FileProcessor.Archiver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace FileCombine.FileArchiver
{
    public partial class FrmFileArchiverMain : Form
    {
        ArchiveEngine archiveEngine = new ArchiveEngine(ArchiveEngineMode.Zip);

        public FrmFileArchiverMain()
        {
            InitializeComponent();
        }

        private void btnSetRootDir_Click_1(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                rootLabel.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog2.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    archiveEngine.CompressDirectory(rootLabel.Text, folderBrowserDialog2.SelectedPath);
                }
                catch 
                {
                    MessageBox.Show("Error");
                }

                MessageBox.Show("Success!!");
            }
        }
    }
}

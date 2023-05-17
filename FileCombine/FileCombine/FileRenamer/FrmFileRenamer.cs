using FileProcessor;
using FileProcessor.Renamer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCombine.FileRenamer
{
    public partial class FrmFileRenamer : Form
    {
        Finder finder = new Finder();

        public FrmFileRenamer()
        {
            InitializeComponent();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            RenamerMode mode = new RenamerMode();
            switch (comboBox1.Text)
            {
                case "UUID":
                    mode = RenamerMode.UUID; break;
                case "AUTOINCREMENT":
                    mode = RenamerMode.AUTOINCREMENT; break;
            }

            Renamer renamer = new Renamer(finder.Container.Files, mode);

            renamer.Rename(textBox1.Text);
        }


        private void btnSelectFolder_Click_1(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                label1.Text = folderBrowserDialog1.SelectedPath;

                finder.FindAll(label1.Text);
            }
        }

    }
}

using FileCombine.FileCleaner;
using FileCombine.FileArchiver;
using FileCombine.FileRenamer;

namespace FileCombine
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnFileCleaner_Click(object sender, EventArgs e)
        {
            FrmFileCleanerMain frm = new FrmFileCleanerMain();
            frm.ShowDialog();
        }

        private void btnFileArchiver_Click(object sender, EventArgs e)
        {
            FrmFileArchiverMain frm = new FrmFileArchiverMain();
            frm.ShowDialog();
        }

        private void btnFileRenamer_Click(object sender, EventArgs e)
        {
            FrmFileRenamer frm = new FrmFileRenamer();
            frm.ShowDialog();
        }
    }
}
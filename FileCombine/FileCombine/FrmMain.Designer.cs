namespace FileCombine
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnFileCleaner = new Button();
            btnFileArchiver = new Button();
            btnFileRenamer = new Button();
            SuspendLayout();
            // 
            // btnFileCleaner
            // 
            btnFileCleaner.Location = new Point(20, 21);
            btnFileCleaner.Margin = new Padding(2, 1, 2, 1);
            btnFileCleaner.Name = "btnFileCleaner";
            btnFileCleaner.Size = new Size(202, 22);
            btnFileCleaner.TabIndex = 0;
            btnFileCleaner.Text = "FILE CLEANER";
            btnFileCleaner.UseVisualStyleBackColor = true;
            btnFileCleaner.Click += btnFileCleaner_Click;
            // 
            // btnFileArchiver
            // 
            btnFileArchiver.Location = new Point(20, 54);
            btnFileArchiver.Margin = new Padding(2, 1, 2, 1);
            btnFileArchiver.Name = "btnFileArchiver";
            btnFileArchiver.Size = new Size(202, 22);
            btnFileArchiver.TabIndex = 1;
            btnFileArchiver.Text = "FILE ARCHIVER";
            btnFileArchiver.UseVisualStyleBackColor = true;
            btnFileArchiver.Click += btnFileArchiver_Click;
            // 
            // btnFileRenamer
            // 
            btnFileRenamer.Location = new Point(20, 87);
            btnFileRenamer.Name = "btnFileRenamer";
            btnFileRenamer.Size = new Size(202, 23);
            btnFileRenamer.TabIndex = 2;
            btnFileRenamer.Text = "FILE RENAMER";
            btnFileRenamer.UseVisualStyleBackColor = true;
            btnFileRenamer.Click += btnFileRenamer_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 211);
            Controls.Add(btnFileRenamer);
            Controls.Add(btnFileArchiver);
            Controls.Add(btnFileCleaner);
            Margin = new Padding(2, 1, 2, 1);
            Name = "FrmMain";
            Text = "File";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFileCleaner;
        private Button btnFileArchiver;
        private Button btnFileRenamer;
    }
}
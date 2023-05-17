namespace FileCombine.FileArchiver
{
    partial class FrmFileArchiverMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSetRootDir = new Button();
            btnArchive = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            rootLabel = new Label();
            folderBrowserDialog2 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // btnSetRootDir
            // 
            btnSetRootDir.Location = new Point(11, 10);
            btnSetRootDir.Margin = new Padding(2, 1, 2, 1);
            btnSetRootDir.Name = "btnSetRootDir";
            btnSetRootDir.Size = new Size(113, 22);
            btnSetRootDir.TabIndex = 23;
            btnSetRootDir.Text = "Set Root Dir";
            btnSetRootDir.UseVisualStyleBackColor = true;
            btnSetRootDir.Click += btnSetRootDir_Click_1;
            // 
            // btnArchive
            // 
            btnArchive.Location = new Point(11, 61);
            btnArchive.Margin = new Padding(2, 1, 2, 1);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(113, 22);
            btnArchive.TabIndex = 20;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = true;
            btnArchive.Click += btnArchive_Click;
            // 
            // rootLabel
            // 
            rootLabel.AutoSize = true;
            rootLabel.Location = new Point(12, 33);
            rootLabel.Name = "rootLabel";
            rootLabel.Size = new Size(23, 15);
            rootLabel.TabIndex = 24;
            rootLabel.Text = "C:\\";
            // 
            // FrmFileArchiverMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 143);
            Controls.Add(rootLabel);
            Controls.Add(btnSetRootDir);
            Controls.Add(btnArchive);
            Name = "FrmFileArchiverMain";
            Text = "FrmFileArchiverMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSetRootDir;
        private Button btnArchive;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label rootLabel;
        private FolderBrowserDialog folderBrowserDialog2;
    }
}
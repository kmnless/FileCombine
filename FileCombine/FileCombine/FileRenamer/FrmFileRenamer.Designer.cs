namespace FileCombine.FileRenamer
{
    partial class FrmFileRenamer
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
            btnSelectFolder = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            btnRename = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Location = new Point(67, 12);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(124, 23);
            btnSelectFolder.TabIndex = 1;
            btnSelectFolder.Text = "Select Folder";
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 39);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 2;
            label1.Text = "C:\\";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "UUID", "AUTOINCREMENT" });
            comboBox1.Location = new Point(70, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // btnRename
            // 
            btnRename.Location = new Point(70, 122);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(121, 23);
            btnRename.TabIndex = 4;
            btnRename.Text = "Rename";
            btnRename.UseVisualStyleBackColor = true;
            btnRename.Click += btnRename_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 90);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "prefix";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 5;
            // 
            // FrmFileRenamer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 160);
            Controls.Add(textBox1);
            Controls.Add(btnRename);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(btnSelectFolder);
            Name = "FrmFileRenamer";
            Text = "FrmFileRenamer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSelectFolder;
        private Label label1;
        private ComboBox comboBox1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnRename;
        private TextBox textBox1;
    }
}
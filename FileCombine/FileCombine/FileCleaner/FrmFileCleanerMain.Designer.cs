namespace FileCombine.FileCleaner
{
    partial class FrmFileCleanerMain
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
            components = new System.ComponentModel.Container();
            listView1 = new ListView();
            btnAnalyze = new Button();
            btnSetRootDir = new Button();
            rootTextBox = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog2 = new FolderBrowserDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            btnDelete = new Button();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            textBox2 = new TextBox();
            btnSetDirPatterns = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(10, 11);
            listView1.Margin = new Padding(2, 1, 2, 1);
            listView1.Name = "listView1";
            listView1.Size = new Size(761, 476);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new Point(782, 319);
            btnAnalyze.Margin = new Padding(2, 1, 2, 1);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(255, 22);
            btnAnalyze.TabIndex = 5;
            btnAnalyze.Text = "ANALYZE";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // btnSetRootDir
            // 
            btnSetRootDir.Location = new Point(782, 13);
            btnSetRootDir.Margin = new Padding(2, 1, 2, 1);
            btnSetRootDir.Name = "btnSetRootDir";
            btnSetRootDir.Size = new Size(113, 22);
            btnSetRootDir.TabIndex = 11;
            btnSetRootDir.Text = "Set Root Dir";
            btnSetRootDir.UseVisualStyleBackColor = true;
            btnSetRootDir.Click += btnSetRootDir_Click;
            // 
            // rootTextBox
            // 
            rootTextBox.AutoSize = true;
            rootTextBox.Location = new Point(782, 42);
            rootTextBox.Margin = new Padding(2, 0, 2, 0);
            rootTextBox.Name = "rootTextBox";
            rootTextBox.Size = new Size(0, 15);
            rootTextBox.TabIndex = 12;
            // 
            // folderBrowserDialog1
            // 
            // 
            // folderBrowserDialog2
            // 
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(785, 358);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 7;
            label1.Text = "Count: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(785, 386);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 8;
            label2.Text = "Full size: ";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(785, 464);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(254, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(785, 222);
            listBox2.Margin = new Padding(2, 1, 2, 1);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(256, 79);
            listBox2.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(783, 97);
            listBox1.Margin = new Padding(2, 1, 2, 1);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(256, 79);
            listBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(900, 64);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "input pattern";
            textBox2.Size = new Size(139, 23);
            textBox2.TabIndex = 15;
            // 
            // btnSetDirPatterns
            // 
            btnSetDirPatterns.Location = new Point(782, 65);
            btnSetDirPatterns.Margin = new Padding(2, 1, 2, 1);
            btnSetDirPatterns.Name = "btnSetDirPatterns";
            btnSetDirPatterns.Size = new Size(113, 22);
            btnSetDirPatterns.TabIndex = 1;
            btnSetDirPatterns.Text = "Set Dir patterns";
            btnSetDirPatterns.UseVisualStyleBackColor = true;
            btnSetDirPatterns.Click += btnSetDirPatterns_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(900, 195);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "input pattern";
            textBox1.Size = new Size(139, 23);
            textBox1.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(782, 196);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(113, 22);
            button1.TabIndex = 16;
            button1.Text = "Set File patterns";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // FrmFileCleanerMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 497);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(btnDelete);
            Controls.Add(rootTextBox);
            Controls.Add(btnSetRootDir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAnalyze);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(btnSetDirPatterns);
            Controls.Add(listView1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "FrmFileCleanerMain";
            Text = "FrmFileCleanerMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button btnAnalyze;
        private Button btnSetRootDir;
        private Label rootTextBox;
        private FolderBrowserDialog folderBrowserDialog1;
        private FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private Button btnDelete;
        private ListBox listBox2;
        private ListBox listBox1;
        private TextBox textBox2;
        private Button btnSetDirPatterns;
        private TextBox textBox1;
        private Button button1;
    }
}
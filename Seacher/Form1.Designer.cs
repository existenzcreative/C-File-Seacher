
namespace Seacher
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTerm = new System.Windows.Forms.TextBox();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.lbFileFound = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Directory";
            // 
            // tbSearchDir
            // 
            this.tbSearchDir.Location = new System.Drawing.Point(37, 65);
            this.tbSearchDir.Name = "tbSearchDir";
            this.tbSearchDir.Size = new System.Drawing.Size(852, 39);
            this.tbSearchDir.TabIndex = 1;
            this.tbSearchDir.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Term";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbTerm
            // 
            this.tbTerm.Location = new System.Drawing.Point(37, 188);
            this.tbTerm.Name = "tbTerm";
            this.tbTerm.Size = new System.Drawing.Size(852, 39);
            this.tbTerm.TabIndex = 3;
            this.tbTerm.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(37, 248);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(852, 46);
            this.pbProgress.TabIndex = 4;
            this.pbProgress.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lbFileFound
            // 
            this.lbFileFound.FormattingEnabled = true;
            this.lbFileFound.ItemHeight = 32;
            this.lbFileFound.Location = new System.Drawing.Point(37, 312);
            this.lbFileFound.Name = "lbFileFound";
            this.lbFileFound.Size = new System.Drawing.Size(852, 228);
            this.lbFileFound.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(912, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 46);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 1573);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbFileFound);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.tbTerm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSearchDir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTerm;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.ListBox lbFileFound;
        private System.Windows.Forms.Button btnSearch;
        private System.ComponentModel.BackgroundWorker bgWorker;
    }
}


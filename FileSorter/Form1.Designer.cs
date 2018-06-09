namespace FileSorter
{
    partial class Form1
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
            this.txtDirectoryPath = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.fbdFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // txtDirectoryPath
            // 
            this.txtDirectoryPath.Location = new System.Drawing.Point(12, 12);
            this.txtDirectoryPath.Name = "txtDirectoryPath";
            this.txtDirectoryPath.ReadOnly = true;
            this.txtDirectoryPath.Size = new System.Drawing.Size(438, 22);
            this.txtDirectoryPath.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(456, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // fbdFolderBrowser
            // 
            this.fbdFolderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.fbdFolderBrowser.ShowNewFolderButton = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 256);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDirectoryPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDirectoryPath;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FolderBrowserDialog fbdFolderBrowser;
    }
}


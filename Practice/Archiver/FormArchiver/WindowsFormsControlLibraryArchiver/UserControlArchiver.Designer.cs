namespace WindowsFormsControlLibraryArchiver
{
    partial class UserControlArchiver
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listSelectedFiles = new System.Windows.Forms.ListBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.progresBar = new System.Windows.Forms.ProgressBar();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listSelectedFiles
            // 
            this.listSelectedFiles.FormattingEnabled = true;
            this.listSelectedFiles.Location = new System.Drawing.Point(9, 8);
            this.listSelectedFiles.Name = "listSelectedFiles";
            this.listSelectedFiles.Size = new System.Drawing.Size(400, 160);
            this.listSelectedFiles.TabIndex = 0;
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(309, 174);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(100, 25);
            this.btnFolder.TabIndex = 1;
            this.btnFolder.Text = "Обзор..";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(309, 201);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(100, 25);
            this.btnArchive.TabIndex = 2;
            this.btnArchive.Text = "Архивация";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "From";
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Location = new System.Drawing.Point(53, 177);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(250, 20);
            this.textBoxFolder.TabIndex = 5;
            // 
            // progresBar
            // 
            this.progresBar.Location = new System.Drawing.Point(53, 203);
            this.progresBar.Maximum = 10;
            this.progresBar.Name = "progresBar";
            this.progresBar.Size = new System.Drawing.Size(250, 23);
            this.progresBar.Step = 1;
            this.progresBar.TabIndex = 8;
            // 
            // fbd
            // 
            this.fbd.Description = "Укажите путь:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControlArchiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progresBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFolder);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.listSelectedFiles);
            this.Name = "UserControlArchiver";
            this.Size = new System.Drawing.Size(418, 236);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listSelectedFiles;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.ProgressBar progresBar;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Timer timer1;
    }
}

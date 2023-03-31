namespace ControlArchiver
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
            this.listSelectedFiles = new System.Windows.Forms.ListBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.progresBar = new System.Windows.Forms.ProgressBar();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.btnArchive1 = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkBoxCreateJson = new System.Windows.Forms.CheckBox();
            this.statusStrip.SuspendLayout();
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
            this.btnFolder.Location = new System.Drawing.Point(309, 176);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(100, 25);
            this.btnFolder.TabIndex = 1;
            this.btnFolder.Text = "Обзор..";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
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
            this.textBoxFolder.Location = new System.Drawing.Point(53, 180);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(250, 20);
            this.textBoxFolder.TabIndex = 5;
            // 
            // progresBar
            // 
            this.progresBar.Location = new System.Drawing.Point(53, 208);
            this.progresBar.Maximum = 10;
            this.progresBar.Name = "progresBar";
            this.progresBar.Size = new System.Drawing.Size(250, 22);
            this.progresBar.Step = 1;
            this.progresBar.TabIndex = 8;
            // 
            // fbd
            // 
            this.fbd.Description = "Укажите путь:";
            // 
            // btnArchive1
            // 
            this.btnArchive1.Location = new System.Drawing.Point(309, 208);
            this.btnArchive1.Name = "btnArchive1";
            this.btnArchive1.Size = new System.Drawing.Size(100, 25);
            this.btnArchive1.TabIndex = 9;
            this.btnArchive1.Text = "Архивация";
            this.btnArchive1.UseVisualStyleBackColor = true;
            this.btnArchive1.Click += new System.EventHandler(this.btnArchive1_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(309, 238);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(100, 25);
            this.btnCancle.TabIndex = 10;
            this.btnCancle.Text = "Отмена";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 266);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(419, 22);
            this.statusStrip.TabIndex = 11;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Ready";
            // 
            // checkBoxCreateJson
            // 
            this.checkBoxCreateJson.AutoSize = true;
            this.checkBoxCreateJson.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCreateJson.Location = new System.Drawing.Point(53, 243);
            this.checkBoxCreateJson.Name = "checkBoxCreateJson";
            this.checkBoxCreateJson.Size = new System.Drawing.Size(82, 17);
            this.checkBoxCreateJson.TabIndex = 12;
            this.checkBoxCreateJson.Text = "Create .json";
            this.checkBoxCreateJson.UseVisualStyleBackColor = true;
            this.checkBoxCreateJson.CheckedChanged += new System.EventHandler(this.checkBoxCreateJson_CheckedChanged);
            // 
            // UserControlArchiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxCreateJson);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnArchive1);
            this.Controls.Add(this.progresBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFolder);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.listSelectedFiles);
            this.Name = "UserControlArchiver";
            this.Size = new System.Drawing.Size(419, 288);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listSelectedFiles;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.ProgressBar progresBar;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Button btnArchive1;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.CheckBox checkBoxCreateJson;
    }
}

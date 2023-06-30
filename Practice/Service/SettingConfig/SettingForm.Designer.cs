namespace SettingConfig
{
    partial class SettingForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelFolderPath = new System.Windows.Forms.Label();
            this.labelArchivePath = new System.Windows.Forms.Label();
            this.textBoxFolderPath = new System.Windows.Forms.TextBox();
            this.textBoxArchivePath = new System.Windows.Forms.TextBox();
            this.btnFolderPath = new System.Windows.Forms.Button();
            this.btnArchivePath = new System.Windows.Forms.Button();
            this.labelCron = new System.Windows.Forms.Label();
            this.textBoxCron = new System.Windows.Forms.TextBox();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.comboBoxArchivingType = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(533, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadConfigToolStripMenuItem,
            this.saveConfigToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // loadConfigToolStripMenuItem
            // 
            this.loadConfigToolStripMenuItem.Name = "loadConfigToolStripMenuItem";
            this.loadConfigToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.loadConfigToolStripMenuItem.Text = "Load Config";
            this.loadConfigToolStripMenuItem.Click += new System.EventHandler(this.loadConfigToolStripMenuItem_Click);
            // 
            // saveConfigToolStripMenuItem
            // 
            this.saveConfigToolStripMenuItem.Name = "saveConfigToolStripMenuItem";
            this.saveConfigToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveConfigToolStripMenuItem.Text = "Save Config";
            this.saveConfigToolStripMenuItem.Click += new System.EventHandler(this.saveConfigToolStripMenuItem_Click);
            // 
            // labelFolderPath
            // 
            this.labelFolderPath.AutoSize = true;
            this.labelFolderPath.Location = new System.Drawing.Point(19, 39);
            this.labelFolderPath.Name = "labelFolderPath";
            this.labelFolderPath.Size = new System.Drawing.Size(67, 15);
            this.labelFolderPath.TabIndex = 1;
            this.labelFolderPath.Text = "Folder Path";
            // 
            // labelArchivePath
            // 
            this.labelArchivePath.AutoSize = true;
            this.labelArchivePath.Location = new System.Drawing.Point(12, 68);
            this.labelArchivePath.Name = "labelArchivePath";
            this.labelArchivePath.Size = new System.Drawing.Size(74, 15);
            this.labelArchivePath.TabIndex = 2;
            this.labelArchivePath.Text = "Archive Path";
            // 
            // textBoxFolderPath
            // 
            this.textBoxFolderPath.Location = new System.Drawing.Point(92, 36);
            this.textBoxFolderPath.Name = "textBoxFolderPath";
            this.textBoxFolderPath.ReadOnly = true;
            this.textBoxFolderPath.Size = new System.Drawing.Size(337, 23);
            this.textBoxFolderPath.TabIndex = 3;
            // 
            // textBoxArchivePath
            // 
            this.textBoxArchivePath.Location = new System.Drawing.Point(92, 65);
            this.textBoxArchivePath.Name = "textBoxArchivePath";
            this.textBoxArchivePath.ReadOnly = true;
            this.textBoxArchivePath.Size = new System.Drawing.Size(337, 23);
            this.textBoxArchivePath.TabIndex = 4;
            // 
            // btnFolderPath
            // 
            this.btnFolderPath.Location = new System.Drawing.Point(444, 36);
            this.btnFolderPath.Name = "btnFolderPath";
            this.btnFolderPath.Size = new System.Drawing.Size(75, 23);
            this.btnFolderPath.TabIndex = 5;
            this.btnFolderPath.Text = "Обзор";
            this.btnFolderPath.UseVisualStyleBackColor = true;
            this.btnFolderPath.Click += new System.EventHandler(this.btnFolderPath_Click);
            // 
            // btnArchivePath
            // 
            this.btnArchivePath.Location = new System.Drawing.Point(444, 65);
            this.btnArchivePath.Name = "btnArchivePath";
            this.btnArchivePath.Size = new System.Drawing.Size(75, 23);
            this.btnArchivePath.TabIndex = 6;
            this.btnArchivePath.Text = "Обзор";
            this.btnArchivePath.UseVisualStyleBackColor = true;
            this.btnArchivePath.Click += new System.EventHandler(this.btnArchivePath_Click);
            // 
            // labelCron
            // 
            this.labelCron.AutoSize = true;
            this.labelCron.Location = new System.Drawing.Point(44, 97);
            this.labelCron.Name = "labelCron";
            this.labelCron.Size = new System.Drawing.Size(33, 15);
            this.labelCron.TabIndex = 7;
            this.labelCron.Text = "Cron";
            // 
            // textBoxCron
            // 
            this.textBoxCron.Location = new System.Drawing.Point(92, 94);
            this.textBoxCron.Name = "textBoxCron";
            this.textBoxCron.Size = new System.Drawing.Size(214, 23);
            this.textBoxCron.TabIndex = 8;
            this.textBoxCron.TextChanged += new System.EventHandler(this.textBoxCron_TextChanged);
            // 
            // comboBoxArchivingType
            // 
            this.comboBoxArchivingType.FormattingEnabled = true;
            this.comboBoxArchivingType.Location = new System.Drawing.Point(398, 94);
            this.comboBoxArchivingType.Name = "comboBoxArchivingType";
            this.comboBoxArchivingType.Size = new System.Drawing.Size(121, 23);
            this.comboBoxArchivingType.TabIndex = 9;
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 126);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(533, 22);
            this.statusStrip.TabIndex = 10;
            this.statusStrip.Text = "Ready";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 148);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.comboBoxArchivingType);
            this.Controls.Add(this.textBoxCron);
            this.Controls.Add(this.labelCron);
            this.Controls.Add(this.btnArchivePath);
            this.Controls.Add(this.btnFolderPath);
            this.Controls.Add(this.textBoxArchivePath);
            this.Controls.Add(this.textBoxFolderPath);
            this.Controls.Add(this.labelArchivePath);
            this.Controls.Add(this.labelFolderPath);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "SettingForm";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem loadConfigToolStripMenuItem;
        private ToolStripMenuItem saveConfigToolStripMenuItem;
        private Label labelFolderPath;
        private Label labelArchivePath;
        private TextBox textBoxFolderPath;
        private TextBox textBoxArchivePath;
        private Button btnFolderPath;
        private Button btnArchivePath;
        private Label labelCron;
        private TextBox textBoxCron;
        private FolderBrowserDialog fbd;
        private ComboBox comboBoxArchivingType;
        private StatusStrip statusStrip;
    }
}
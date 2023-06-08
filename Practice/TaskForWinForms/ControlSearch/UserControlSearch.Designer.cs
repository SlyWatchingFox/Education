namespace ControlSearch
{
    partial class UserControlSearch
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
            this.BtnSearch = new System.Windows.Forms.Button();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxRegex = new System.Windows.Forms.TextBox();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.treeViewSearch = new System.Windows.Forms.TreeView();
            this.btnFolder = new System.Windows.Forms.Button();
            this.textBoxAllCount = new System.Windows.Forms.TextBox();
            this.textBoxSearchCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(475, 84);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 0;
            this.BtnSearch.Text = "Поиск";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // fbd
            // 
            this.fbd.Description = "Укажите путь:";
            // 
            // textBoxRegex
            // 
            this.textBoxRegex.Location = new System.Drawing.Point(387, 58);
            this.textBoxRegex.Name = "textBoxRegex";
            this.textBoxRegex.Size = new System.Drawing.Size(163, 20);
            this.textBoxRegex.TabIndex = 1;
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Location = new System.Drawing.Point(387, 3);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(163, 20);
            this.textBoxFolder.TabIndex = 2;
            // 
            // treeViewSearch
            // 
            this.treeViewSearch.Location = new System.Drawing.Point(3, 3);
            this.treeViewSearch.Name = "treeViewSearch";
            this.treeViewSearch.Size = new System.Drawing.Size(378, 444);
            this.treeViewSearch.TabIndex = 3;
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(475, 29);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(75, 23);
            this.btnFolder.TabIndex = 4;
            this.btnFolder.Text = "Обзор...";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // textBoxAllCount
            // 
            this.textBoxAllCount.Location = new System.Drawing.Point(450, 123);
            this.textBoxAllCount.Name = "textBoxAllCount";
            this.textBoxAllCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxAllCount.TabIndex = 7;
            this.textBoxAllCount.Text = "0";
            // 
            // textBoxSearchCount
            // 
            this.textBoxSearchCount.Location = new System.Drawing.Point(450, 149);
            this.textBoxSearchCount.Name = "textBoxSearchCount";
            this.textBoxSearchCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchCount.TabIndex = 8;
            this.textBoxSearchCount.Text = "0";
            // 
            // UserControlSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxSearchCount);
            this.Controls.Add(this.textBoxAllCount);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.treeViewSearch);
            this.Controls.Add(this.textBoxFolder);
            this.Controls.Add(this.textBoxRegex);
            this.Controls.Add(this.BtnSearch);
            this.Name = "UserControlSearch";
            this.Size = new System.Drawing.Size(555, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.TextBox textBoxRegex;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.TreeView treeViewSearch;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.TextBox textBoxAllCount;
        private System.Windows.Forms.TextBox textBoxSearchCount;
    }
}

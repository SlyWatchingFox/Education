namespace WinFormsTask1
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
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalcul1 = new System.Windows.Forms.Button();
            this.btnCalcul2 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.listSize = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.белыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чёрныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.красныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(165, 70);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 23);
            this.txtC.TabIndex = 0;
            this.txtC.Text = "C";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(23, 41);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 23);
            this.txtB.TabIndex = 1;
            this.txtB.Text = "A";
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(299, 41);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 23);
            this.txtA.TabIndex = 2;
            this.txtA.Text = "B";
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(311, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalcul1
            // 
            this.btnCalcul1.Location = new System.Drawing.Point(302, 140);
            this.btnCalcul1.Name = "btnCalcul1";
            this.btnCalcul1.Size = new System.Drawing.Size(100, 26);
            this.btnCalcul1.TabIndex = 5;
            this.btnCalcul1.Text = "S(A,B,C) =";
            this.btnCalcul1.UseVisualStyleBackColor = true;
            this.btnCalcul1.Click += new System.EventHandler(this.btnCalcul1_Click);
            // 
            // btnCalcul2
            // 
            this.btnCalcul2.Location = new System.Drawing.Point(23, 140);
            this.btnCalcul2.Name = "btnCalcul2";
            this.btnCalcul2.Size = new System.Drawing.Size(100, 26);
            this.btnCalcul2.TabIndex = 6;
            this.btnCalcul2.Text = "S(A,B sinC) =";
            this.btnCalcul2.UseVisualStyleBackColor = true;
            this.btnCalcul2.Click += new System.EventHandler(this.btnCalcul2_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(81, 226);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(50, 23);
            this.txtResult.TabIndex = 8;
            this.txtResult.Text = "0";
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // listSize
            // 
            this.listSize.FormattingEnabled = true;
            this.listSize.ItemHeight = 15;
            this.listSize.Items.AddRange(new object[] {
            "Minimal",
            "Middle",
            "Maximum"});
            this.listSize.Location = new System.Drawing.Point(12, 201);
            this.listSize.Name = "listSize";
            this.listSize.Size = new System.Drawing.Size(63, 49);
            this.listSize.TabIndex = 10;
            this.listSize.SelectedIndexChanged += new System.EventHandler(this.listSize_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(414, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.белыйToolStripMenuItem,
            this.чёрныйToolStripMenuItem,
            this.красныйToolStripMenuItem,
            this.синийToolStripMenuItem,
            this.зеленыйToolStripMenuItem});
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.цветToolStripMenuItem.Text = "Цвет";
            // 
            // белыйToolStripMenuItem
            // 
            this.белыйToolStripMenuItem.Name = "белыйToolStripMenuItem";
            this.белыйToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.белыйToolStripMenuItem.Text = "Интересный";
            this.белыйToolStripMenuItem.Click += new System.EventHandler(this.белыйToolStripMenuItem_Click);
            // 
            // чёрныйToolStripMenuItem
            // 
            this.чёрныйToolStripMenuItem.Name = "чёрныйToolStripMenuItem";
            this.чёрныйToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.чёрныйToolStripMenuItem.Text = "Чёрный";
            this.чёрныйToolStripMenuItem.Click += new System.EventHandler(this.чёрныйToolStripMenuItem_Click);
            // 
            // красныйToolStripMenuItem
            // 
            this.красныйToolStripMenuItem.Name = "красныйToolStripMenuItem";
            this.красныйToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.красныйToolStripMenuItem.Text = "Красный";
            this.красныйToolStripMenuItem.Click += new System.EventHandler(this.красныйToolStripMenuItem_Click);
            // 
            // синийToolStripMenuItem
            // 
            this.синийToolStripMenuItem.Name = "синийToolStripMenuItem";
            this.синийToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.синийToolStripMenuItem.Text = "Синий";
            this.синийToolStripMenuItem.Click += new System.EventHandler(this.синийToolStripMenuItem_Click);
            // 
            // зеленыйToolStripMenuItem
            // 
            this.зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            this.зеленыйToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.зеленыйToolStripMenuItem.Text = "Зеленый";
            this.зеленыйToolStripMenuItem.Click += new System.EventHandler(this.зеленыйToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(414, 261);
            this.Controls.Add(this.listSize);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCalcul2);
            this.Controls.Add(this.btnCalcul1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtC;
        private TextBox txtB;
        private TextBox txtA;
        private Button btnExit;
        private Button btnCalcul1;
        private Button btnCalcul2;
        private TextBox txtResult;
        private ListBox listSize;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem цветToolStripMenuItem;
        private ToolStripMenuItem чёрныйToolStripMenuItem;
        private ToolStripMenuItem красныйToolStripMenuItem;
        private ToolStripMenuItem синийToolStripMenuItem;
        private ToolStripMenuItem зеленыйToolStripMenuItem;
        private ToolStripMenuItem белыйToolStripMenuItem;
    }
}
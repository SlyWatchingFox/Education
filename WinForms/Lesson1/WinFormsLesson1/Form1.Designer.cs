namespace WinFormsLesson1
{
    partial class frmSumma
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtSumma = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(112, 112);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 23);
            this.txtA.TabIndex = 1;
            this.txtA.Text = "0";
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(218, 112);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 23);
            this.txtB.TabIndex = 2;
            this.txtB.Text = "0";
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(324, 112);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 23);
            this.txtC.TabIndex = 3;
            this.txtC.Text = "0";
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            // 
            // txtSumma
            // 
            this.txtSumma.Location = new System.Drawing.Point(218, 232);
            this.txtSumma.Name = "txtSumma";
            this.txtSumma.Size = new System.Drawing.Size(100, 23);
            this.txtSumma.TabIndex = 4;
            this.txtSumma.Text = "0";
            this.txtSumma.TextChanged += new System.EventHandler(this.txtSumma_TextChanged);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(218, 171);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(100, 22);
            this.btnCount.TabIndex = 5;
            this.btnCount.Text = "Вычислить";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // frmSumma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(494, 277);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtSumma);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.button1);
            this.Name = "frmSumma";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private TextBox txtSumma;
        private Button btnCount;
    }
}
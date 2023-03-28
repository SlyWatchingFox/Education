namespace WinFormsTabControl
{
    partial class TabControl
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
            this.UserControlRestorane = new System.Windows.Forms.TabPage();
            this.UserControlRGB = new System.Windows.Forms.TabPage();
            this.UserControlCalculator = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserControlRestorane
            // 
            this.UserControlRestorane.Location = new System.Drawing.Point(4, 24);
            this.UserControlRestorane.Name = "UserControlRestorane";
            this.UserControlRestorane.Size = new System.Drawing.Size(697, 526);
            this.UserControlRestorane.TabIndex = 2;
            this.UserControlRestorane.Text = "Ресторан";
            this.UserControlRestorane.UseVisualStyleBackColor = true;
            // 
            // UserControlRGB
            // 
            this.UserControlRGB.Location = new System.Drawing.Point(4, 24);
            this.UserControlRGB.Name = "UserControlRGB";
            this.UserControlRGB.Padding = new System.Windows.Forms.Padding(3);
            this.UserControlRGB.Size = new System.Drawing.Size(697, 526);
            this.UserControlRGB.TabIndex = 1;
            this.UserControlRGB.Text = "RGB";
            this.UserControlRGB.UseVisualStyleBackColor = true;
            // 
            // UserControlCalculator
            // 
            this.UserControlCalculator.Location = new System.Drawing.Point(4, 24);
            this.UserControlCalculator.Name = "UserControlCalculator";
            this.UserControlCalculator.Padding = new System.Windows.Forms.Padding(3);
            this.UserControlCalculator.Size = new System.Drawing.Size(697, 526);
            this.UserControlCalculator.TabIndex = 0;
            this.UserControlCalculator.Text = "Калькулятор";
            this.UserControlCalculator.UseVisualStyleBackColor = true;
            this.UserControlCalculator.Click += new System.EventHandler(this.UserControlCalculator_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.UserControlCalculator);
            this.tabControl1.Controls.Add(this.UserControlRGB);
            this.tabControl1.Controls.Add(this.UserControlRestorane);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(705, 554);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(697, 526);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Архиватор";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 574);
            this.Controls.Add(this.tabControl1);
            this.Name = "TabControl";
            this.Text = "Program";
            this.Load += new System.EventHandler(this.TabControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage UserControlRestorane;
        private TabPage UserControlRGB;
        private TabPage UserControlCalculator;
        private System.Windows.Forms.TabControl tabControl1;
        private TabPage tabPage1;
    }
}
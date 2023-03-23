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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UserControlCalculator = new System.Windows.Forms.TabPage();
            this.UserControlRGB = new System.Windows.Forms.TabPage();
            this.UserControlRestorane = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UserControlCalculator);
            this.tabControl1.Controls.Add(this.UserControlRGB);
            this.tabControl1.Controls.Add(this.UserControlRestorane);
            this.tabControl1.Location = new System.Drawing.Point(267, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(415, 301);
            this.tabControl1.TabIndex = 0;
            // 
            // UserControlCalculator
            // 
            this.UserControlCalculator.Location = new System.Drawing.Point(4, 24);
            this.UserControlCalculator.Name = "UserControlCalculator";
            this.UserControlCalculator.Padding = new System.Windows.Forms.Padding(3);
            this.UserControlCalculator.Size = new System.Drawing.Size(407, 273);
            this.UserControlCalculator.TabIndex = 0;
            this.UserControlCalculator.Text = "Калькулятор";
            this.UserControlCalculator.UseVisualStyleBackColor = true;
            this.UserControlCalculator.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // UserControlRGB
            // 
            this.UserControlRGB.Location = new System.Drawing.Point(4, 24);
            this.UserControlRGB.Name = "UserControlRGB";
            this.UserControlRGB.Padding = new System.Windows.Forms.Padding(3);
            this.UserControlRGB.Size = new System.Drawing.Size(407, 273);
            this.UserControlRGB.TabIndex = 1;
            this.UserControlRGB.Text = "RGB";
            this.UserControlRGB.UseVisualStyleBackColor = true;
            // 
            // UserControlRestorane
            // 
            this.UserControlRestorane.Location = new System.Drawing.Point(4, 24);
            this.UserControlRestorane.Name = "UserControlRestorane";
            this.UserControlRestorane.Size = new System.Drawing.Size(407, 273);
            this.UserControlRestorane.TabIndex = 2;
            this.UserControlRestorane.Text = "Ресторан";
            this.UserControlRestorane.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "TabControl";
            this.Text = "Program";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private TabPage UserControlCalculator;
        private TabPage UserControlRGB;
        private TabPage UserControlRestorane;
    }
}
namespace FormRGB
{
    partial class UserControlRGB
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
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.panelRGB = new System.Windows.Forms.Panel();
            this.textBoxHEXcode = new System.Windows.Forms.TextBox();
            this.labelRGB = new System.Windows.Forms.Label();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.panelRGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBarRed
            // 
            this.trackBarRed.BackColor = System.Drawing.SystemColors.Window;
            this.trackBarRed.Location = new System.Drawing.Point(3, 146);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(255, 45);
            this.trackBarRed.TabIndex = 0;
            this.trackBarRed.TickFrequency = 5;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.BackColor = System.Drawing.SystemColors.Window;
            this.trackBarGreen.Location = new System.Drawing.Point(3, 197);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(255, 45);
            this.trackBarGreen.TabIndex = 1;
            this.trackBarGreen.TickFrequency = 5;
            this.trackBarGreen.Value = 1;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.BackColor = System.Drawing.SystemColors.Window;
            this.trackBarBlue.Location = new System.Drawing.Point(3, 248);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(255, 45);
            this.trackBarBlue.TabIndex = 2;
            this.trackBarBlue.TickFrequency = 5;
            this.trackBarBlue.Value = 1;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // textBoxRed
            // 
            this.textBoxRed.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxRed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRed.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRed.ForeColor = System.Drawing.Color.Red;
            this.textBoxRed.Location = new System.Drawing.Point(264, 146);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(53, 27);
            this.textBoxRed.TabIndex = 3;
            this.textBoxRed.Text = "0";
            // 
            // panelRGB
            // 
            this.panelRGB.BackColor = System.Drawing.SystemColors.Window;
            this.panelRGB.Controls.Add(this.textBoxHEXcode);
            this.panelRGB.Controls.Add(this.labelRGB);
            this.panelRGB.Location = new System.Drawing.Point(3, 3);
            this.panelRGB.Name = "panelRGB";
            this.panelRGB.Size = new System.Drawing.Size(314, 137);
            this.panelRGB.TabIndex = 4;
            // 
            // textBoxHEXcode
            // 
            this.textBoxHEXcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHEXcode.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHEXcode.Location = new System.Drawing.Point(68, 111);
            this.textBoxHEXcode.Name = "textBoxHEXcode";
            this.textBoxHEXcode.Size = new System.Drawing.Size(100, 17);
            this.textBoxHEXcode.TabIndex = 7;
            // 
            // labelRGB
            // 
            this.labelRGB.AutoSize = true;
            this.labelRGB.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRGB.Location = new System.Drawing.Point(3, 111);
            this.labelRGB.Name = "labelRGB";
            this.labelRGB.Size = new System.Drawing.Size(68, 17);
            this.labelRGB.TabIndex = 8;
            this.labelRGB.Text = "Hex Code:";
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxGreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGreen.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F);
            this.textBoxGreen.ForeColor = System.Drawing.Color.Green;
            this.textBoxGreen.Location = new System.Drawing.Point(264, 197);
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(53, 27);
            this.textBoxGreen.TabIndex = 5;
            this.textBoxGreen.Text = "0";
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxBlue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBlue.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F);
            this.textBoxBlue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxBlue.Location = new System.Drawing.Point(264, 248);
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(53, 27);
            this.textBoxBlue.TabIndex = 6;
            this.textBoxBlue.Text = "0";
            // 
            // UserControlRGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxBlue);
            this.Controls.Add(this.textBoxGreen);
            this.Controls.Add(this.panelRGB);
            this.Controls.Add(this.textBoxRed);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Name = "UserControlRGB";
            this.Size = new System.Drawing.Size(320, 293);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.panelRGB.ResumeLayout(false);
            this.panelRGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.Panel panelRGB;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.Label labelRGB;
        private System.Windows.Forms.TextBox textBoxHEXcode;
    }
}

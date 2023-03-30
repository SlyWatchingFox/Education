namespace WinFormsLesson3lab2
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.textMinute = new System.Windows.Forms.TextBox();
            this.timerSeconds = new System.Windows.Forms.Timer(this.components);
            this.textSeconds = new System.Windows.Forms.TextBox();
            this.textMinuteText = new System.Windows.Forms.TextBox();
            this.textSecondsText = new System.Windows.Forms.TextBox();
            this.textMiliSeconds = new System.Windows.Forms.TextBox();
            this.textMilisecondsText = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.textDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(103, 242);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(291, 98);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Старт\\Стоп";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // textMinute
            // 
            this.textMinute.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textMinute.Location = new System.Drawing.Point(12, 88);
            this.textMinute.Name = "textMinute";
            this.textMinute.Size = new System.Drawing.Size(150, 135);
            this.textMinute.TabIndex = 2;
            this.textMinute.Text = "0";
            this.textMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerSeconds
            // 
            this.timerSeconds.Interval = 10;
            this.timerSeconds.Tick += new System.EventHandler(this.timerSeconds_Tick);
            // 
            // textSeconds
            // 
            this.textSeconds.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textSeconds.Location = new System.Drawing.Point(171, 88);
            this.textSeconds.Name = "textSeconds";
            this.textSeconds.Size = new System.Drawing.Size(150, 135);
            this.textSeconds.TabIndex = 3;
            this.textSeconds.Text = "0";
            this.textSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textMinuteText
            // 
            this.textMinuteText.BackColor = System.Drawing.SystemColors.Menu;
            this.textMinuteText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMinuteText.Font = new System.Drawing.Font("MS PGothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textMinuteText.Location = new System.Drawing.Point(32, 55);
            this.textMinuteText.Name = "textMinuteText";
            this.textMinuteText.Size = new System.Drawing.Size(100, 16);
            this.textMinuteText.TabIndex = 4;
            this.textMinuteText.Text = "Минуты";
            // 
            // textSecondsText
            // 
            this.textSecondsText.BackColor = System.Drawing.SystemColors.Menu;
            this.textSecondsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSecondsText.Font = new System.Drawing.Font("MS PGothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textSecondsText.Location = new System.Drawing.Point(200, 55);
            this.textSecondsText.Name = "textSecondsText";
            this.textSecondsText.Size = new System.Drawing.Size(100, 16);
            this.textSecondsText.TabIndex = 5;
            this.textSecondsText.Text = "Секунды";
            // 
            // textMiliSeconds
            // 
            this.textMiliSeconds.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textMiliSeconds.Location = new System.Drawing.Point(327, 88);
            this.textMiliSeconds.Name = "textMiliSeconds";
            this.textMiliSeconds.Size = new System.Drawing.Size(187, 135);
            this.textMiliSeconds.TabIndex = 6;
            this.textMiliSeconds.Text = "0";
            this.textMiliSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textMilisecondsText
            // 
            this.textMilisecondsText.BackColor = System.Drawing.SystemColors.Menu;
            this.textMilisecondsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMilisecondsText.Font = new System.Drawing.Font("MS PGothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textMilisecondsText.Location = new System.Drawing.Point(343, 58);
            this.textMilisecondsText.Name = "textMilisecondsText";
            this.textMilisecondsText.Size = new System.Drawing.Size(159, 13);
            this.textMilisecondsText.TabIndex = 7;
            this.textMilisecondsText.Text = "МилиСекунды";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Black", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(103, 346);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(291, 51);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // textDate
            // 
            this.textDate.AcceptsReturn = true;
            this.textDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textDate.Location = new System.Drawing.Point(71, 415);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(355, 29);
            this.textDate.TabIndex = 9;
            this.textDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDate.TextChanged += new System.EventHandler(this.textDate_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.textMilisecondsText);
            this.Controls.Add(this.textMiliSeconds);
            this.Controls.Add(this.textSecondsText);
            this.Controls.Add(this.textMinuteText);
            this.Controls.Add(this.textSeconds);
            this.Controls.Add(this.textMinute);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStart;
        private TextBox textMinute;
        private System.Windows.Forms.Timer timerSeconds;
        private TextBox textSeconds;
        private TextBox textMinuteText;
        private TextBox textSecondsText;
        private TextBox textMiliSeconds;
        private TextBox textMilisecondsText;
        private Button btnReset;
        private TextBox textDate;
    }
}
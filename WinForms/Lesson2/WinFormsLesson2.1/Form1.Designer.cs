namespace WinFormsLesson2._1
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
            this.listMenu = new System.Windows.Forms.ListBox();
            this.listOrder = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.textAddMenu = new System.Windows.Forms.TextBox();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listMenu
            // 
            this.listMenu.FormattingEnabled = true;
            this.listMenu.ItemHeight = 15;
            this.listMenu.Items.AddRange(new object[] {
            "Гусы отжареный (1000 р.)",
            "Мудилы (100 р.)",
            "ЛГБТ капуста (1120р.)",
            "Расистская капуста (1488 р.)",
            "Камшот (999 р.)",
            "Суши сухари (23 р.)",
            "Вглазунья (550р.)"});
            this.listMenu.Location = new System.Drawing.Point(12, 12);
            this.listMenu.Name = "listMenu";
            this.listMenu.Size = new System.Drawing.Size(169, 199);
            this.listMenu.TabIndex = 0;
            this.listMenu.SelectedIndexChanged += new System.EventHandler(this.listMenu_SelectedIndexChanged);
            // 
            // listOrder
            // 
            this.listOrder.FormattingEnabled = true;
            this.listOrder.ItemHeight = 15;
            this.listOrder.Location = new System.Drawing.Point(268, 12);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(162, 199);
            this.listOrder.TabIndex = 1;
            this.listOrder.SelectedIndexChanged += new System.EventHandler(this.listOrder_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(187, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(187, 86);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(187, 146);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистить всё";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(355, 246);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Заказ";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // textAddMenu
            // 
            this.textAddMenu.ForeColor = System.Drawing.Color.Black;
            this.textAddMenu.Location = new System.Drawing.Point(12, 217);
            this.textAddMenu.Name = "textAddMenu";
            this.textAddMenu.Size = new System.Drawing.Size(127, 23);
            this.textAddMenu.TabIndex = 6;
            this.textAddMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textAddMenu.TextChanged += new System.EventHandler(this.textAddMenu_TextChanged);
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Location = new System.Drawing.Point(12, 246);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(75, 23);
            this.btnAddMenu.TabIndex = 7;
            this.btnAddMenu.Text = "Добавить";
            this.btnAddMenu.UseMnemonic = false;
            this.btnAddMenu.UseVisualStyleBackColor = true;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 278);
            this.Controls.Add(this.btnAddMenu);
            this.Controls.Add(this.textAddMenu);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.listMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listMenu;
        private ListBox listOrder;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnClear;
        private Button btnOk;
        private TextBox textAddMenu;
        private Button btnAddMenu;
    }
}
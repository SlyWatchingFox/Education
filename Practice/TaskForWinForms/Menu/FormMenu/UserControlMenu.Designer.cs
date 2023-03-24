namespace FormMenu
{
    partial class UserControlMenu
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
            this.dataGridMenu = new System.Windows.Forms.DataGridView();
            this.dataGridBasket = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddToMenu = new System.Windows.Forms.Button();
            this.btnDeleteMenu = new System.Windows.Forms.Button();
            this.textBoxAddToMenu = new System.Windows.Forms.TextBox();
            this.textBoxAddToMenuPrice = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBasket)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMenu
            // 
            this.dataGridMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMenu.Location = new System.Drawing.Point(3, 3);
            this.dataGridMenu.Name = "dataGridMenu";
            this.dataGridMenu.RowHeadersVisible = false;
            this.dataGridMenu.Size = new System.Drawing.Size(183, 300);
            this.dataGridMenu.TabIndex = 0;
            this.dataGridMenu.Tag = "";
            // 
            // dataGridBasket
            // 
            this.dataGridBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBasket.Location = new System.Drawing.Point(273, 3);
            this.dataGridBasket.Name = "dataGridBasket";
            this.dataGridBasket.RowHeadersVisible = false;
            this.dataGridBasket.Size = new System.Drawing.Size(183, 300);
            this.dataGridBasket.TabIndex = 1;
            this.dataGridBasket.Tag = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(192, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(192, 89);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(192, 209);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddToMenu
            // 
            this.btnAddToMenu.Location = new System.Drawing.Point(3, 309);
            this.btnAddToMenu.Name = "btnAddToMenu";
            this.btnAddToMenu.Size = new System.Drawing.Size(118, 23);
            this.btnAddToMenu.TabIndex = 6;
            this.btnAddToMenu.Text = "Добавить";
            this.btnAddToMenu.UseVisualStyleBackColor = true;
            this.btnAddToMenu.Click += new System.EventHandler(this.btnAddToMenu_Click);
            // 
            // btnDeleteMenu
            // 
            this.btnDeleteMenu.Location = new System.Drawing.Point(127, 309);
            this.btnDeleteMenu.Name = "btnDeleteMenu";
            this.btnDeleteMenu.Size = new System.Drawing.Size(59, 23);
            this.btnDeleteMenu.TabIndex = 7;
            this.btnDeleteMenu.Text = "Удалить";
            this.btnDeleteMenu.UseVisualStyleBackColor = true;
            this.btnDeleteMenu.Click += new System.EventHandler(this.btnDeleteMenu_Click);
            // 
            // textBoxAddToMenu
            // 
            this.textBoxAddToMenu.Location = new System.Drawing.Point(3, 338);
            this.textBoxAddToMenu.Name = "textBoxAddToMenu";
            this.textBoxAddToMenu.Size = new System.Drawing.Size(118, 20);
            this.textBoxAddToMenu.TabIndex = 8;
            // 
            // textBoxAddToMenuPrice
            // 
            this.textBoxAddToMenuPrice.Location = new System.Drawing.Point(127, 338);
            this.textBoxAddToMenuPrice.Name = "textBoxAddToMenuPrice";
            this.textBoxAddToMenuPrice.Size = new System.Drawing.Size(59, 20);
            this.textBoxAddToMenuPrice.TabIndex = 9;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(381, 335);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Заказать";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // UserControlMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textBoxAddToMenuPrice);
            this.Controls.Add(this.textBoxAddToMenu);
            this.Controls.Add(this.btnDeleteMenu);
            this.Controls.Add(this.btnAddToMenu);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridBasket);
            this.Controls.Add(this.dataGridMenu);
            this.Name = "UserControlMenu";
            this.Size = new System.Drawing.Size(461, 365);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBasket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMenu;
        private System.Windows.Forms.DataGridView dataGridBasket;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddToMenu;
        private System.Windows.Forms.Button btnDeleteMenu;
        private System.Windows.Forms.TextBox textBoxAddToMenu;
        private System.Windows.Forms.TextBox textBoxAddToMenuPrice;
        private System.Windows.Forms.Button btnOk;
    }
}

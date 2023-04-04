using System;
using System.Windows.Forms;

namespace FormMenu
{
    public partial class UserControlMenu : UserControl
    {
       
        public UserControlMenu()
        {
            InitializeComponent();
            dataGridMenu.Columns.Add("MenuPos", "Меню");
            dataGridMenu.Columns.Add("MenuPrice", "Цена");
            dataGridBasket.Columns.Add("MenuPos", "Меню");
            dataGridBasket.Columns.Add("MenuPrice", "Цена");
            dataGridMenu.Rows.Add("Гусы отжареный", "1000");
            dataGridMenu.Rows.Add("Мудилы", "1000");
            dataGridMenu.Rows.Add("ЛГБТ капуста", "1120");
            dataGridMenu.Rows.Add("Расистская капуста", "1488");
            dataGridMenu.Rows.Add("Камшот", "999");
            dataGridMenu.Rows.Add("Суши сухари", "23");
            dataGridMenu.Rows.Add("Вглазунья", "550");
            EditRowsSize();
            Name = "Ресторан";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var menu = dataGridMenu.CurrentCell.Value.ToString();
            var price = dataGridMenu[1, dataGridMenu.CurrentRow.Index].Value.ToString();
            dataGridBasket.Rows.Add(menu, price);
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataGridBasket.Rows.Remove(dataGridBasket.CurrentRow);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridBasket.Rows.Clear();
        }

        private void btnAddToMenu_Click(object sender, EventArgs e)
        {
            if (textBoxAddToMenu.Text != null && textBoxAddToMenuPrice.Text != null)
            {
                int price = 0;
                if (!int.TryParse(textBoxAddToMenuPrice.Text, out price))
                {
                    MessageBox.Show("Введи нормальную цену, говнюк! ");
                }
                else
                {
                    var menu = textBoxAddToMenu.Text;
                    dataGridMenu.Rows.Add(menu, price);
                }
            }
        }


        private void btnDeleteMenu_Click(object sender, EventArgs e)
        {
            dataGridMenu.Rows.Remove(dataGridMenu.CurrentRow);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dataGridBasket.Rows.Count > 0)
            {
                int result = 0;
                for (int i = 0; i < dataGridBasket.Rows.Count; i++)
                {
                    result += Convert.ToInt32(dataGridBasket.Rows[i].Cells[1].Value);
                }
                MessageBox.Show($"Стоимость заказа: {result}. Приятного аппетита!");
            }
        }
        private void EditRowsSize()
        {
            if (dataGridMenu.ColumnCount > 0)
            {
                dataGridMenu.Columns[0].Width = 130;
            }
            if (dataGridMenu.ColumnCount > 1)
            {
                dataGridMenu.Columns[1].Width = 50;
            }
            if (dataGridBasket.ColumnCount > 0)
            {
                dataGridBasket.Columns[0].Width = 130;
            }
            if (dataGridBasket.ColumnCount > 1)
            {
                dataGridBasket.Columns[1].Width = 50;
            }
        }
    }
}

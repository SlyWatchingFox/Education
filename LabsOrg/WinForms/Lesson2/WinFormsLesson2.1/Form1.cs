using System.Text.RegularExpressions;

namespace WinFormsLesson2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listOrder.Items.Add(listMenu.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listOrder.Items.Remove(listOrder.SelectedItem);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listOrder.Items.Clear();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (listOrder.Items.Count > 0)
            {
                Regex regex = new Regex(@"\D");
                int result = 0;
                for (int i = 0; i < listOrder.Items.Count; i++)
                {
                    var item = listOrder.Items[i].ToString();
                    result += Int32.Parse(regex.Replace(item, ""));
                }
                MessageBox.Show($"Стоимость заказа: {result}. Приятного аппетита!");
            }
            this.Close();
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            string add = textAddMenu.Text;
            if (add != null && add.Length > 0)
            {
                listMenu.Items.Add(add);
            }
        }

        private void textAddMenu_TextChanged(object sender, EventArgs e)
        {

        }

        private void listMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listOrder_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
using System;
using System.Windows.Forms;

namespace KR_akimov
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = CurrentUser.FIO;
            label3.Text = CurrentUser.Role;

            buttonGoods.Visible = false;
            buttonSoldItems.Visible = false;
            buttonWorkers.Visible = false;

            if (CurrentUser.Role == "Администратор")
            {
                buttonGoods.Visible = true;
            }
            else if (CurrentUser.Role == "Продавец")
            {
                buttonSoldItems.Visible = true;
            }
            else if (CurrentUser.Role == "Директор")
            {
                buttonWorkers.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrentUser.FIO = "";
            CurrentUser.Role = "";
            Close();
        }

        private void buttonGoods_Click(object sender, EventArgs e)
        {
            GoodsForm form = new GoodsForm();
            Hide();
            form.ShowDialog();
            Show();

            label2.Text = CurrentUser.FIO;
            label3.Text = CurrentUser.Role;
        }

        private void buttonSoldItems_Click(object sender, EventArgs e)
        {
            SoldItemsForm form = new SoldItemsForm();
            Hide();
            form.ShowDialog();
            Show();

            label2.Text = CurrentUser.FIO;
            label3.Text = CurrentUser.Role;
        }

        private void buttonWorkers_Click(object sender, EventArgs e)
        {
            WorkersForm form = new WorkersForm();
            Hide();
            form.ShowDialog();
            Show();

            label2.Text = CurrentUser.FIO;
            label3.Text = CurrentUser.Role;
        }
    }
}

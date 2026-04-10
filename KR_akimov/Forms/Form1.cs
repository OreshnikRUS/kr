using System;
using System.Linq;
using System.Windows.Forms;
using KR_akimov.ModelEF;
using Db = KR_akimov.ModelEF.ModelEF;

namespace KR_akimov
{
    public partial class Form1 : Form
    {
        private Db db = new Db();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (login == "" || password == "")
            {
                MessageBox.Show("Введите логин и пароль.");
                return;
            }

            Workers user = db.Workers.FirstOrDefault(x => x.Login == login && x.Password == password);

            if (user == null)
            {
                MessageBox.Show("Неверный логин или пароль.");
                return;
            }

            CurrentUser.FIO = (user.Second_Name + " " + user.First_Name + " " + user.Middle_Name).Trim();

            if (user.Role == "Administrator")
            {
                CurrentUser.Role = "Администратор";
            }
            else if (user.Role == "Seller")
            {
                CurrentUser.Role = "Продавец";
            }
            else if (user.Role == "Director")
            {
                CurrentUser.Role = "Директор";
            }
            else
            {
                CurrentUser.Role = user.Role;
            }

            Form2 form = new Form2();
            Hide();
            form.ShowDialog();
            Show();

            CurrentUser.FIO = "";
            CurrentUser.Role = "";
            textBox2.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CurrentUser.FIO = "";
            CurrentUser.Role = "";
            textBox2.UseSystemPasswordChar = true;
        }

    }
}

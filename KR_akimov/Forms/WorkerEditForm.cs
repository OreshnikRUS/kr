using System;
using System.Windows.Forms;
using KR_akimov.ModelEF;
using Db = KR_akimov.ModelEF.ModelEF;

namespace KR_akimov
{
    internal partial class WorkerEditForm : Form
    {
        public Db db { get; set; }
        public Workers worker { get; set; }

        public WorkerEditForm()
        {
            InitializeComponent();
        }

        private void WorkerEditForm_Load(object sender, EventArgs e)
        {
            comboBoxRole.Items.Add("Administrator");
            comboBoxRole.Items.Add("Seller");
            comboBoxRole.Items.Add("Director");

            textBoxId.Text = worker.ID.ToString();
            textBoxLogin.Text = worker.Login;
            textBoxPassword.Text = worker.Password;
            textBoxFirstName.Text = worker.First_Name;
            textBoxSecondName.Text = worker.Second_Name;
            textBoxMiddleName.Text = worker.Middle_Name;
            comboBoxRole.Text = worker.Role;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string oldFio = (worker.Second_Name + " " + worker.First_Name + " " + worker.Middle_Name).Trim();

            worker.ID = int.Parse(textBoxId.Text);
            worker.Login = textBoxLogin.Text;
            worker.Password = textBoxPassword.Text;
            worker.First_Name = textBoxFirstName.Text;
            worker.Second_Name = textBoxSecondName.Text;
            worker.Middle_Name = textBoxMiddleName.Text;
            worker.Role = comboBoxRole.Text;

            try
            {
                db.SaveChanges();

                if (oldFio == CurrentUser.FIO)
                {
                    CurrentUser.FIO = (worker.Second_Name + " " + worker.First_Name + " " + worker.Middle_Name).Trim();

                    if (worker.Role == "Administrator")
                    {
                        CurrentUser.Role = "Администратор";
                    }
                    else if (worker.Role == "Seller")
                    {
                        CurrentUser.Role = "Продавец";
                    }
                    else if (worker.Role == "Director")
                    {
                        CurrentUser.Role = "Директор";
                    }
                    else
                    {
                        CurrentUser.Role = worker.Role;
                    }
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null && ex.InnerException.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.InnerException.Message);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Windows.Forms;
using KR_akimov.ModelEF;
using Db = KR_akimov.ModelEF.ModelEF;

namespace KR_akimov
{
    internal partial class WorkerAddForm : Form
    {
        public Db db { get; set; }

        public WorkerAddForm()
        {
            InitializeComponent();
        }

        private void WorkerAddForm_Load(object sender, EventArgs e)
        {
            textBoxId.Text = "Авто";
            comboBoxRole.Items.Add("Administrator");
            comboBoxRole.Items.Add("Seller");
            comboBoxRole.Items.Add("Director");
            comboBoxRole.SelectedIndex = 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" ||
                textBoxPassword.Text == "" ||
                textBoxFirstName.Text == "" ||
                textBoxSecondName.Text == "" ||
                textBoxMiddleName.Text == "" ||
                comboBoxRole.Text == "")
            {
                MessageBox.Show("Нужно ввести все данные");
                return;
            }

            Workers worker = new Workers();
            worker.Login = textBoxLogin.Text;
            worker.Password = textBoxPassword.Text;
            worker.First_Name = textBoxFirstName.Text;
            worker.Second_Name = textBoxSecondName.Text;
            worker.Middle_Name = textBoxMiddleName.Text;
            worker.Role = comboBoxRole.Text;

            db.Workers.Add(worker);

            try
            {
                db.SaveChanges();
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

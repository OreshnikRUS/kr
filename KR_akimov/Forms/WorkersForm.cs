using System;
using System.Linq;
using System.Windows.Forms;
using KR_akimov.ModelEF;
using Db = KR_akimov.ModelEF.ModelEF;

namespace KR_akimov
{
    internal partial class WorkersForm : Form
    {
        public Db db { get; set; }

        public WorkersForm()
        {
            InitializeComponent();
            db = new Db();
        }

        private void StartLoad()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.Workers.ToList();
        }

        private void WorkersForm_Load(object sender, EventArgs e)
        {
            labelUser.Text = CurrentUser.FIO;
            labelRole.Text = CurrentUser.Role;
            StartLoad();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            WorkerAddForm form = new WorkerAddForm();
            form.db = db;
            DialogResult dr = form.ShowDialog();

            if (dr == DialogResult.OK)
            {
                workersBindingSource.DataSource = db.Workers.ToList();
                StartLoad();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Workers worker = dataGridView1.CurrentRow.DataBoundItem as Workers;

            WorkerEditForm form = new WorkerEditForm();
            form.db = db;
            form.worker = worker;

            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                StartLoad();
                labelUser.Text = CurrentUser.FIO;
                labelRole.Text = CurrentUser.Role;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Workers worker = dataGridView1.CurrentRow.DataBoundItem as Workers;
            DialogResult dr = MessageBox.Show(
                "Вы действительно хотите удалить сотрудника - " + worker.Login.ToString(),
                "Удаление сотрудника", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                db.Workers.Remove(worker);
            }

            try
            {
                db.SaveChanges();
                StartLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using KR_akimov.ModelEF;
using Db = KR_akimov.ModelEF.ModelEF;

namespace KR_akimov
{
    internal partial class SoldItemsForm : Form
    {
        private Db db = new Db();

        public SoldItemsForm()
        {
            InitializeComponent();
        }

        private void SoldItemsForm_Load(object sender, EventArgs e)
        {
            labelUser.Text = CurrentUser.FIO;
            labelRole.Text = CurrentUser.Role;
            LoadSoldItems();
        }

        private void LoadSoldItems()
        {
            Workers worker = db.Workers.FirstOrDefault(x => (x.Second_Name + " " + x.First_Name + " " + x.Middle_Name).Trim() == CurrentUser.FIO);
            List<Sold_item> soldItems = new List<Sold_item>();

            if (worker != null)
            {
                soldItems = db.Sold_item
                    .Include(x => x.Goods)
                    .Include(x => x.Outlets)
                    .Where(x => x.ID_Worker == worker.ID)
                    .OrderBy(x => x.ID)
                    .ToList();
            }

            List<SoldItemView> list = new List<SoldItemView>();

            foreach (Sold_item item in soldItems)
            {
                SoldItemView row = new SoldItemView();
                row.ID = item.ID;
                row.Good = item.Goods == null ? "" : item.Goods.Name;
                row.Type = item.Goods == null ? "" : item.Goods.Type;
                row.Date = item.Date_of_sale.HasValue ? item.Date_of_sale.Value.ToString("dd.MM.yyyy HH:mm") : "";
                row.Outlet = item.Outlets == null ? "" : item.Outlets.Town + " " + item.Outlets.Street;
                list.Add(row);
            }

            dataGridView1.DataSource = list;

            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["ID"].HeaderText = "ID";
                dataGridView1.Columns["Good"].HeaderText = "Товар";
                dataGridView1.Columns["Type"].HeaderText = "Тип";
                dataGridView1.Columns["Date"].HeaderText = "Дата продажи";
                dataGridView1.Columns["Outlet"].HeaderText = "Торговая точка";
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private class SoldItemView
        {
            public int ID { get; set; }
            public string Good { get; set; }
            public string Type { get; set; }
            public string Date { get; set; }
            public string Outlet { get; set; }
        }
    }
}

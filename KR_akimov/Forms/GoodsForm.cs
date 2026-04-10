using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using KR_akimov.ModelEF;
using Db = KR_akimov.ModelEF.ModelEF;

namespace KR_akimov
{
    internal partial class GoodsForm : Form
    {
        private Db db = new Db();
        private List<Goods> goods = new List<Goods>();
        private int page = 0;

        public GoodsForm()
        {
            InitializeComponent();
        }

        private void GoodsForm_Load(object sender, EventArgs e)
        {
            labelUser.Text = CurrentUser.FIO;
            labelRole.Text = CurrentUser.Role;
            LoadProducts();
            CreateTile();
        }

        private void LoadProducts()
        {
            goods = db.Goods.OrderBy(x => x.ID).ToList();
            page = 0;
        }

        private void CreateTile()
        {
            flpTile.Controls.Clear();

            int start = page * 6;
            int end = start + 6;

            for (int i = start; i < end && i < goods.Count; i++)
            {
                flpTile.Controls.Add(new GoodsTile(goods[i]));
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (page > 0)
            {
                page--;
                CreateTile();
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if ((page + 1) * 6 < goods.Count)
            {
                page++;
                CreateTile();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

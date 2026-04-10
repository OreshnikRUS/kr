using System.Windows.Forms;
using KR_akimov.ModelEF;

namespace KR_akimov
{
    internal partial class GoodsTile : UserControl
    {
        private Goods good;

        public GoodsTile(Goods good)
        {
            this.good = good;
            InitializeComponent();
            Fill();
        }

        private void Fill()
        {
            pictureBox1.Image = ProductImageHelper.GetProductImage(good.Image);
            labelId.Text = "ID " + good.ID;
            labelName.Text = string.IsNullOrWhiteSpace(good.Name) ? "Без названия" : good.Name;
        }
    }
}

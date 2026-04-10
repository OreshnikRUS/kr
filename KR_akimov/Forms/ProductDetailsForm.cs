using System.Drawing;
using System.Windows.Forms;
using Control_Gorevoy_Finally.ModelEF;

namespace Control_Gorevoy_Finally
{
    internal sealed class ProductDetailsForm : Form
    {
        private readonly Goods _good;

        public ProductDetailsForm(Goods good)
        {
            _good = good;

            BuildInterface();
            Fill();
        }

        private PictureBox pictureBoxProduct;
        private Label labelId;
        private Label labelName;
        private Label labelPrice;
        private Label labelType;
        private TextBox textBoxDescription;
        private Button buttonClose;

        private void BuildInterface()
        {
            Text = "Информация о товаре";
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(760, 460);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            pictureBoxProduct = new PictureBox
            {
                Location = new Point(20, 20),
                Size = new Size(260, 260),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle
            };

            labelId = new Label
            {
                Location = new Point(305, 25),
                Size = new Size(420, 30),
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
            };

            labelName = new Label
            {
                Location = new Point(305, 70),
                Size = new Size(420, 50),
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular)
            };

            labelPrice = new Label
            {
                Location = new Point(305, 135),
                Size = new Size(420, 30),
                Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular)
            };

            labelType = new Label
            {
                Location = new Point(305, 175),
                Size = new Size(420, 30),
                Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular)
            };

            textBoxDescription = new TextBox
            {
                Location = new Point(20, 305),
                Size = new Size(705, 95),
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical
            };

            buttonClose = new Button
            {
                Location = new Point(585, 410),
                Size = new Size(140, 35),
                Text = "Закрыть"
            };
            buttonClose.Click += delegate { Close(); };

            Controls.Add(pictureBoxProduct);
            Controls.Add(labelId);
            Controls.Add(labelName);
            Controls.Add(labelPrice);
            Controls.Add(labelType);
            Controls.Add(textBoxDescription);
            Controls.Add(buttonClose);
        }

        private void Fill()
        {
            pictureBoxProduct.Image = ProductImageHelper.GetProductImage(_good.Image);
            labelId.Text = "ID: " + _good.ID;
            labelName.Text = "Название: " + (string.IsNullOrWhiteSpace(_good.Name) ? "Без названия" : _good.Name);
            labelPrice.Text = _good.Price.HasValue ? "Цена: " + _good.Price.Value + " руб." : "Цена: не указана";
            labelType.Text = "Тип: " + (string.IsNullOrWhiteSpace(_good.Type) ? "не указан" : _good.Type);
            textBoxDescription.Text = string.IsNullOrWhiteSpace(_good.Description) ? "Описание отсутствует." : _good.Description;
        }
    }
}

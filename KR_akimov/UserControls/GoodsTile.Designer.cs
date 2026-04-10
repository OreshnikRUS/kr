using System.Drawing;
using System.Windows.Forms;

namespace KR_akimov
{
    internal partial class GoodsTile
    {
        private Panel panelContent;
        private Panel panelImage;
        private PictureBox pictureBox1;
        private Label labelId;
        private Label labelName;

        private void InitializeComponent()
        {
            this.panelContent = new Panel();
            this.panelImage = new Panel();
            this.pictureBox1 = new PictureBox();
            this.labelId = new Label();
            this.labelName = new Label();
            this.panelContent.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = Color.White;
            this.panelContent.Controls.Add(this.labelName);
            this.panelContent.Controls.Add(this.labelId);
            this.panelContent.Controls.Add(this.panelImage);
            this.panelContent.Location = new Point(2, 2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new Size(246, 236);
            this.panelContent.TabIndex = 0;
            // 
            // panelImage
            // 
            this.panelImage.BackColor = Color.FromArgb(191, 191, 191);
            this.panelImage.Controls.Add(this.pictureBox1);
            this.panelImage.Location = new Point(15, 15);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new Size(220, 140);
            this.panelImage.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = Color.White;
            this.pictureBox1.Location = new Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(216, 136);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelId
            // 
            this.labelId.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            this.labelId.Location = new Point(15, 170);
            this.labelId.Name = "labelId";
            this.labelId.Size = new Size(220, 25);
            this.labelId.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new Point(15, 200);
            this.labelName.Name = "labelName";
            this.labelName.Size = new Size(220, 25);
            this.labelName.TabIndex = 2;
            // 
            // GoodsTile
            // 
            this.BackColor = Color.FromArgb(191, 191, 191);
            this.Controls.Add(this.panelContent);
            this.Margin = new Padding(10);
            this.Name = "GoodsTile";
            this.Size = new Size(250, 240);
            this.panelContent.ResumeLayout(false);
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

using System.Drawing;
using System.Windows.Forms;

namespace KR_akimov
{
    internal partial class SoldItemsForm
    {
        private Panel panelDecor;
        private Panel panelDecorFill;
        private Button buttonBack;
        private Label labelUser;
        private Label labelRole;
        private DataGridView dataGridView1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoldItemsForm));
            this.panelDecor = new System.Windows.Forms.Panel();
            this.panelDecorFill = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelDecor.SuspendLayout();
            this.panelDecorFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDecor
            // 
            this.panelDecor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.panelDecor.Controls.Add(this.panelDecorFill);
            this.panelDecor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDecor.Location = new System.Drawing.Point(0, 0);
            this.panelDecor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDecor.Name = "panelDecor";
            this.panelDecor.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panelDecor.Size = new System.Drawing.Size(690, 92);
            this.panelDecor.TabIndex = 4;
            // 
            // panelDecorFill
            // 
            this.panelDecorFill.BackColor = System.Drawing.Color.Red;
            this.panelDecorFill.Controls.Add(this.pictureBox1);
            this.panelDecorFill.Controls.Add(this.label3);
            this.panelDecorFill.Controls.Add(this.buttonBack);
            this.panelDecorFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDecorFill.Location = new System.Drawing.Point(1, 1);
            this.panelDecorFill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDecorFill.Name = "panelDecorFill";
            this.panelDecorFill.Size = new System.Drawing.Size(688, 90);
            this.panelDecorFill.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KR_akimov.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(610, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(238, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Проданный товар";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.DarkGray;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonBack.FlatAppearance.BorderSize = 2;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(15, 24);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(127, 45);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelUser
            // 
            this.labelUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUser.Location = new System.Drawing.Point(132, 24);
            this.labelUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(375, 24);
            this.labelUser.TabIndex = 1;
            // 
            // labelRole
            // 
            this.labelRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRole.Location = new System.Drawing.Point(480, 24);
            this.labelRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(188, 24);
            this.labelRole.TabIndex = 2;
            this.labelRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 128);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(652, 422);
            this.dataGridView1.TabIndex = 3;
            // 
            // SoldItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 552);
            this.Controls.Add(this.panelDecor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "SoldItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Проданный товар";
            this.Load += new System.EventHandler(this.SoldItemsForm_Load);
            this.panelDecor.ResumeLayout(false);
            this.panelDecorFill.ResumeLayout(false);
            this.panelDecorFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private Label label3;
        private PictureBox pictureBox1;
    }
}

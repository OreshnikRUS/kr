using System;
using System.Drawing;
using System.Windows.Forms;

namespace KR_akimov
{
    internal partial class GoodsForm
    {
        private Panel panelDecor;
        private Panel panelDecorFill;
        private Button buttonBack;
        private Button buttonLeft;
        private Button buttonRight;
        private Label labelUser;
        private Label labelRole;
        private FlowLayoutPanel flpTile;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsForm));
            this.panelDecor = new System.Windows.Forms.Panel();
            this.panelDecorFill = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.flpTile = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDecor.SuspendLayout();
            this.panelDecorFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDecor
            // 
            this.panelDecor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.panelDecor.Controls.Add(this.panelDecorFill);
            this.panelDecor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDecor.Location = new System.Drawing.Point(0, 0);
            this.panelDecor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelDecor.Name = "panelDecor";
            this.panelDecor.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panelDecor.Size = new System.Drawing.Size(909, 92);
            this.panelDecor.TabIndex = 6;
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
            this.panelDecorFill.Size = new System.Drawing.Size(907, 90);
            this.panelDecorFill.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KR_akimov.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(780, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(381, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Товары";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Silver;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonBack.FlatAppearance.BorderSize = 2;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(26, 24);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(141, 43);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonLeft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonLeft.FlatAppearance.BorderSize = 2;
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeft.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLeft.Location = new System.Drawing.Point(26, 437);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(90, 42);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonRight.FlatAppearance.BorderSize = 2;
            this.buttonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRight.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRight.Location = new System.Drawing.Point(804, 437);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(90, 42);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
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
            this.labelRole.Location = new System.Drawing.Point(597, 24);
            this.labelRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(188, 24);
            this.labelRole.TabIndex = 2;
            this.labelRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flpTile
            // 
            this.flpTile.Location = new System.Drawing.Point(132, 130);
            this.flpTile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flpTile.Name = "flpTile";
            this.flpTile.Size = new System.Drawing.Size(652, 633);
            this.flpTile.TabIndex = 3;
            // 
            // GoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 552);
            this.Controls.Add(this.panelDecor);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.flpTile);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "GoodsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.GoodsForm_Load);
            this.panelDecor.ResumeLayout(false);
            this.panelDecorFill.ResumeLayout(false);
            this.panelDecorFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private Label label3;
        private PictureBox pictureBox1;
    }
}

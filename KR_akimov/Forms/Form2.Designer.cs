namespace KR_akimov
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panelDecor = new System.Windows.Forms.Panel();
            this.panelDecorFill = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGoods = new System.Windows.Forms.Button();
            this.buttonSoldItems = new System.Windows.Forms.Button();
            this.buttonWorkers = new System.Windows.Forms.Button();
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
            this.panelDecor.Name = "panelDecor";
            this.panelDecor.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panelDecor.Size = new System.Drawing.Size(800, 92);
            this.panelDecor.TabIndex = 7;
            // 
            // panelDecorFill
            // 
            this.panelDecorFill.BackColor = System.Drawing.Color.Red;
            this.panelDecorFill.Controls.Add(this.pictureBox1);
            this.panelDecorFill.Controls.Add(this.label4);
            this.panelDecorFill.Controls.Add(this.button1);
            this.panelDecorFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDecorFill.Location = new System.Drawing.Point(1, 1);
            this.panelDecorFill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDecorFill.Name = "panelDecorFill";
            this.panelDecorFill.Size = new System.Drawing.Size(798, 90);
            this.panelDecorFill.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KR_akimov.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(644, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(358, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Меню";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(18, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добро пожаловать";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "currentUser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(571, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "currentRole";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonGoods
            // 
            this.buttonGoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.buttonGoods.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonGoods.FlatAppearance.BorderSize = 2;
            this.buttonGoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoods.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoods.Location = new System.Drawing.Point(308, 260);
            this.buttonGoods.Name = "buttonGoods";
            this.buttonGoods.Size = new System.Drawing.Size(189, 126);
            this.buttonGoods.TabIndex = 4;
            this.buttonGoods.Text = "Товары";
            this.buttonGoods.UseVisualStyleBackColor = false;
            this.buttonGoods.Visible = false;
            this.buttonGoods.Click += new System.EventHandler(this.buttonGoods_Click);
            // 
            // buttonSoldItems
            // 
            this.buttonSoldItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.buttonSoldItems.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonSoldItems.FlatAppearance.BorderSize = 2;
            this.buttonSoldItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSoldItems.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSoldItems.Location = new System.Drawing.Point(308, 260);
            this.buttonSoldItems.Name = "buttonSoldItems";
            this.buttonSoldItems.Size = new System.Drawing.Size(189, 126);
            this.buttonSoldItems.TabIndex = 5;
            this.buttonSoldItems.Text = "Проданный товар";
            this.buttonSoldItems.UseVisualStyleBackColor = false;
            this.buttonSoldItems.Visible = false;
            this.buttonSoldItems.Click += new System.EventHandler(this.buttonSoldItems_Click);
            // 
            // buttonWorkers
            // 
            this.buttonWorkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonWorkers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonWorkers.FlatAppearance.BorderSize = 2;
            this.buttonWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorkers.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWorkers.Location = new System.Drawing.Point(308, 260);
            this.buttonWorkers.Name = "buttonWorkers";
            this.buttonWorkers.Size = new System.Drawing.Size(189, 126);
            this.buttonWorkers.TabIndex = 6;
            this.buttonWorkers.Text = "Сотрудники";
            this.buttonWorkers.UseVisualStyleBackColor = false;
            this.buttonWorkers.Visible = false;
            this.buttonWorkers.Click += new System.EventHandler(this.buttonWorkers_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.panelDecor);
            this.Controls.Add(this.buttonWorkers);
            this.Controls.Add(this.buttonSoldItems);
            this.Controls.Add(this.buttonGoods);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelDecor.ResumeLayout(false);
            this.panelDecorFill.ResumeLayout(false);
            this.panelDecorFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGoods;
        private System.Windows.Forms.Button buttonSoldItems;
        private System.Windows.Forms.Button buttonWorkers;
        private System.Windows.Forms.Panel panelDecor;
        private System.Windows.Forms.Panel panelDecorFill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

namespace Day2
{
    partial class Page5_Selling
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page5_Selling));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IDText = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.dataMenuSelling = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.CountUpDown = new System.Windows.Forms.NumericUpDown();
            this.SelectBot = new System.Windows.Forms.Button();
            this.DeletetBot = new System.Windows.Forms.Button();
            this.PayBot = new System.Windows.Forms.Button();
            this.ShowPrice = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.ComboBox();
            this.CountStockText = new System.Windows.Forms.TextBox();
            this.SizeText = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMenuSelling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::Day2.Properties.Resources.VDOSPORTGIFFFFF;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Day2.Properties.Resources.VDOSPORTGIFFFFF;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(73, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // IDText
            // 
            this.IDText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.IDText.BackColor = System.Drawing.SystemColors.Window;
            this.IDText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.IDText.Location = new System.Drawing.Point(73, 106);
            this.IDText.Name = "IDText";
            this.IDText.ReadOnly = true;
            this.IDText.Size = new System.Drawing.Size(398, 23);
            this.IDText.TabIndex = 20;
            this.IDText.TextChanged += new System.EventHandler(this.IDText_TextChanged);
            // 
            // PriceText
            // 
            this.PriceText.BackColor = System.Drawing.SystemColors.Window;
            this.PriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceText.Location = new System.Drawing.Point(79, 553);
            this.PriceText.Name = "PriceText";
            this.PriceText.ReadOnly = true;
            this.PriceText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PriceText.Size = new System.Drawing.Size(398, 23);
            this.PriceText.TabIndex = 19;
            this.PriceText.TextChanged += new System.EventHandler(this.PriceText_TextChanged);
            // 
            // dataMenuSelling
            // 
            this.dataMenuSelling.AllowUserToAddRows = false;
            this.dataMenuSelling.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataMenuSelling.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMenuSelling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataMenuSelling.ColumnHeadersHeight = 32;
            this.dataMenuSelling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.size,
            this.count,
            this.price,
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataMenuSelling.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataMenuSelling.EnableHeadersVisualStyles = false;
            this.dataMenuSelling.GridColor = System.Drawing.SystemColors.Control;
            this.dataMenuSelling.Location = new System.Drawing.Point(522, 91);
            this.dataMenuSelling.Name = "dataMenuSelling";
            this.dataMenuSelling.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMenuSelling.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataMenuSelling.RowHeadersWidth = 51;
            this.dataMenuSelling.RowTemplate.Height = 24;
            this.dataMenuSelling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMenuSelling.Size = new System.Drawing.Size(661, 360);
            this.dataMenuSelling.TabIndex = 21;
            this.dataMenuSelling.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataMenuSelling.Click += new System.EventHandler(this.dataMenuSelling_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 75;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 170;
            // 
            // size
            // 
            this.size.HeaderText = "count";
            this.size.MinimumWidth = 6;
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.Width = 50;
            // 
            // count
            // 
            this.count.HeaderText = "size";
            this.count.MinimumWidth = 6;
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Width = 40;
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "sum";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 57;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1063, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 36);
            this.button3.TabIndex = 22;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CountUpDown
            // 
            this.CountUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.CountUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountUpDown.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CountUpDown.Location = new System.Drawing.Point(73, 484);
            this.CountUpDown.Name = "CountUpDown";
            this.CountUpDown.Size = new System.Drawing.Size(411, 30);
            this.CountUpDown.TabIndex = 23;
            this.CountUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CountUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountUpDown.ValueChanged += new System.EventHandler(this.CountUpDown_ValueChanged);
            // 
            // SelectBot
            // 
            this.SelectBot.BackColor = System.Drawing.Color.Transparent;
            this.SelectBot.FlatAppearance.BorderSize = 0;
            this.SelectBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectBot.ForeColor = System.Drawing.Color.Transparent;
            this.SelectBot.Location = new System.Drawing.Point(568, 481);
            this.SelectBot.Name = "SelectBot";
            this.SelectBot.Size = new System.Drawing.Size(218, 64);
            this.SelectBot.TabIndex = 24;
            this.SelectBot.UseVisualStyleBackColor = false;
            this.SelectBot.Click += new System.EventHandler(this.SelectBot_Click);
            // 
            // DeletetBot
            // 
            this.DeletetBot.BackColor = System.Drawing.Color.Transparent;
            this.DeletetBot.FlatAppearance.BorderSize = 0;
            this.DeletetBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletetBot.ForeColor = System.Drawing.Color.Transparent;
            this.DeletetBot.Location = new System.Drawing.Point(568, 560);
            this.DeletetBot.Name = "DeletetBot";
            this.DeletetBot.Size = new System.Drawing.Size(218, 60);
            this.DeletetBot.TabIndex = 25;
            this.DeletetBot.UseVisualStyleBackColor = false;
            this.DeletetBot.Click += new System.EventHandler(this.DeletetBot_Click);
            // 
            // PayBot
            // 
            this.PayBot.BackColor = System.Drawing.Color.Transparent;
            this.PayBot.FlatAppearance.BorderSize = 0;
            this.PayBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayBot.ForeColor = System.Drawing.Color.Transparent;
            this.PayBot.Location = new System.Drawing.Point(899, 560);
            this.PayBot.Name = "PayBot";
            this.PayBot.Size = new System.Drawing.Size(218, 60);
            this.PayBot.TabIndex = 26;
            this.PayBot.UseVisualStyleBackColor = false;
            this.PayBot.Click += new System.EventHandler(this.PayBot_Click);
            // 
            // ShowPrice
            // 
            this.ShowPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.ShowPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ShowPrice.Location = new System.Drawing.Point(981, 495);
            this.ShowPrice.Name = "ShowPrice";
            this.ShowPrice.ReadOnly = true;
            this.ShowPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowPrice.Size = new System.Drawing.Size(168, 31);
            this.ShowPrice.TabIndex = 27;
            this.ShowPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ShowPrice.TextChanged += new System.EventHandler(this.ShowPrice_TextChanged);
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.NameText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.FormattingEnabled = true;
            this.NameText.Location = new System.Drawing.Point(73, 352);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(411, 33);
            this.NameText.TabIndex = 31;
            this.NameText.SelectedIndexChanged += new System.EventHandler(this.NameText_SelectedIndexChanged);
            // 
            // CountStockText
            // 
            this.CountStockText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.CountStockText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CountStockText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountStockText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.CountStockText.Location = new System.Drawing.Point(359, 592);
            this.CountStockText.Name = "CountStockText";
            this.CountStockText.ReadOnly = true;
            this.CountStockText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CountStockText.Size = new System.Drawing.Size(53, 20);
            this.CountStockText.TabIndex = 32;
            this.CountStockText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CountStockText.TextChanged += new System.EventHandler(this.CountStockText_TextChanged);
            // 
            // SizeText
            // 
            this.SizeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.SizeText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SizeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeText.FormattingEnabled = true;
            this.SizeText.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.SizeText.Location = new System.Drawing.Point(73, 418);
            this.SizeText.Name = "SizeText";
            this.SizeText.Size = new System.Drawing.Size(411, 33);
            this.SizeText.TabIndex = 31;
            this.SizeText.SelectedIndexChanged += new System.EventHandler(this.SizeText_SelectedIndexChanged);
            // 
            // Page5_Selling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Day2.Properties.Resources._66666666666666666666666666666666777;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.CountStockText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.SizeText);
            this.Controls.Add(this.ShowPrice);
            this.Controls.Add(this.PayBot);
            this.Controls.Add(this.DeletetBot);
            this.Controls.Add(this.SelectBot);
            this.Controls.Add(this.CountUpDown);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataMenuSelling);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.IDText);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Page5_Selling";
            this.Text = "SELL";
            this.Load += new System.EventHandler(this.Page5_Selling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMenuSelling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.DataGridView dataMenuSelling;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown CountUpDown;
        private System.Windows.Forms.Button SelectBot;
        private System.Windows.Forms.Button DeletetBot;
        private System.Windows.Forms.Button PayBot;
        private System.Windows.Forms.TextBox ShowPrice;
        private System.Windows.Forms.ComboBox NameText;
        private System.Windows.Forms.TextBox CountStockText;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ComboBox SizeText;
    }
}
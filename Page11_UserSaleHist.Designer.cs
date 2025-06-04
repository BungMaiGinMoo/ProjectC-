namespace Day2
{
    partial class Page11_UserSaleHist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page11_UserSaleHist));
            this.PhoneBox = new System.Windows.Forms.ComboBox();
            this.ShowSum = new System.Windows.Forms.TextBox();
            this.ShowVat = new System.Windows.Forms.TextBox();
            this.ShowPrice = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataUserSelling = new System.Windows.Forms.DataGridView();
            this.namebox = new System.Windows.Forms.TextBox();
            this.ShowDiscount = new System.Windows.Forms.TextBox();
            this.ShowSumPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataUserSelling)).BeginInit();
            this.SuspendLayout();
            // 
            // PhoneBox
            // 
            this.PhoneBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.PhoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneBox.ForeColor = System.Drawing.SystemColors.Info;
            this.PhoneBox.FormattingEnabled = true;
            this.PhoneBox.Location = new System.Drawing.Point(827, 162);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(357, 33);
            this.PhoneBox.TabIndex = 34;
            this.PhoneBox.SelectedIndexChanged += new System.EventHandler(this.PhoneBox_SelectedIndexChanged);
            // 
            // ShowSum
            // 
            this.ShowSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(80)))));
            this.ShowSum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ShowSum.Location = new System.Drawing.Point(1050, 619);
            this.ShowSum.Name = "ShowSum";
            this.ShowSum.ReadOnly = true;
            this.ShowSum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowSum.Size = new System.Drawing.Size(103, 15);
            this.ShowSum.TabIndex = 39;
            this.ShowSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ShowVat
            // 
            this.ShowVat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ShowVat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowVat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.ShowVat.Location = new System.Drawing.Point(351, 619);
            this.ShowVat.Name = "ShowVat";
            this.ShowVat.ReadOnly = true;
            this.ShowVat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowVat.Size = new System.Drawing.Size(128, 15);
            this.ShowVat.TabIndex = 38;
            this.ShowVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ShowVat.TextChanged += new System.EventHandler(this.ShowVat_TextChanged);
            // 
            // ShowPrice
            // 
            this.ShowPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ShowPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.ShowPrice.Location = new System.Drawing.Point(122, 619);
            this.ShowPrice.Name = "ShowPrice";
            this.ShowPrice.ReadOnly = true;
            this.ShowPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowPrice.Size = new System.Drawing.Size(131, 15);
            this.ShowPrice.TabIndex = 37;
            this.ShowPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ShowPrice.TextChanged += new System.EventHandler(this.ShowPrice_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1059, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 37);
            this.button2.TabIndex = 41;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1059, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 37);
            this.button3.TabIndex = 40;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataUserSelling
            // 
            this.dataUserSelling.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.dataUserSelling.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataUserSelling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataUserSelling.ColumnHeadersHeight = 32;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataUserSelling.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataUserSelling.EnableHeadersVisualStyles = false;
            this.dataUserSelling.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.dataUserSelling.Location = new System.Drawing.Point(71, 218);
            this.dataUserSelling.Name = "dataUserSelling";
            this.dataUserSelling.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataUserSelling.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataUserSelling.RowHeadersVisible = false;
            this.dataUserSelling.RowHeadersWidth = 35;
            this.dataUserSelling.RowTemplate.Height = 24;
            this.dataUserSelling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataUserSelling.Size = new System.Drawing.Size(1113, 380);
            this.dataUserSelling.TabIndex = 42;
            this.dataUserSelling.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUserSelling_CellContentClick);
            // 
            // namebox
            // 
            this.namebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.namebox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namebox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.namebox.Location = new System.Drawing.Point(233, 196);
            this.namebox.Name = "namebox";
            this.namebox.ReadOnly = true;
            this.namebox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.namebox.Size = new System.Drawing.Size(291, 20);
            this.namebox.TabIndex = 43;
            this.namebox.TextChanged += new System.EventHandler(this.namebox_TextChanged);
            // 
            // ShowDiscount
            // 
            this.ShowDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ShowDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.ShowDiscount.Location = new System.Drawing.Point(839, 618);
            this.ShowDiscount.Name = "ShowDiscount";
            this.ShowDiscount.ReadOnly = true;
            this.ShowDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowDiscount.Size = new System.Drawing.Size(90, 15);
            this.ShowDiscount.TabIndex = 44;
            this.ShowDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ShowSumPrice
            // 
            this.ShowSumPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ShowSumPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowSumPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowSumPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.ShowSumPrice.Location = new System.Drawing.Point(598, 619);
            this.ShowSumPrice.Name = "ShowSumPrice";
            this.ShowSumPrice.ReadOnly = true;
            this.ShowSumPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowSumPrice.Size = new System.Drawing.Size(106, 15);
            this.ShowSumPrice.TabIndex = 45;
            this.ShowSumPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Page11_UserSaleHist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Day2.Properties.Resources._121212121212;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.ShowSumPrice);
            this.Controls.Add(this.ShowDiscount);
            this.Controls.Add(this.dataUserSelling);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ShowSum);
            this.Controls.Add(this.ShowVat);
            this.Controls.Add(this.ShowPrice);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.namebox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Page11_UserSaleHist";
            this.Text = "HISTORY USER PURCHASE";
            this.Load += new System.EventHandler(this.Page11_UserSaleHist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataUserSelling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PhoneBox;
        private System.Windows.Forms.TextBox ShowSum;
        private System.Windows.Forms.TextBox ShowVat;
        private System.Windows.Forms.TextBox ShowPrice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataUserSelling;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox ShowDiscount;
        private System.Windows.Forms.TextBox ShowSumPrice;
    }
}
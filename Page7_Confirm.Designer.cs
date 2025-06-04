namespace Day2
{
    partial class Page7_Confirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page7_Confirm));
            this.BACK = new System.Windows.Forms.Button();
            this.MEMBER = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.dataMenuSelling = new System.Windows.Forms.DataGridView();
            this.ShowPrice = new System.Windows.Forms.TextBox();
            this.QRcode = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PhoneBox = new System.Windows.Forms.ComboBox();
            this.PhoneAdminBox = new System.Windows.Forms.ComboBox();
            this.ShowVat = new System.Windows.Forms.TextBox();
            this.ShowSum = new System.Windows.Forms.TextBox();
            this.ShowDiscount = new System.Windows.Forms.TextBox();
            this.btnCalculateDiscount = new System.Windows.Forms.Button();
            this.ShowSumPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataMenuSelling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BACK
            // 
            this.BACK.BackColor = System.Drawing.Color.Transparent;
            this.BACK.FlatAppearance.BorderSize = 0;
            this.BACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BACK.Location = new System.Drawing.Point(1073, 48);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(124, 38);
            this.BACK.TabIndex = 19;
            this.BACK.UseVisualStyleBackColor = false;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // MEMBER
            // 
            this.MEMBER.BackColor = System.Drawing.Color.Transparent;
            this.MEMBER.FlatAppearance.BorderSize = 0;
            this.MEMBER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MEMBER.Location = new System.Drawing.Point(921, 48);
            this.MEMBER.Name = "MEMBER";
            this.MEMBER.Size = new System.Drawing.Size(124, 38);
            this.MEMBER.TabIndex = 18;
            this.MEMBER.UseVisualStyleBackColor = false;
            this.MEMBER.Click += new System.EventHandler(this.MEMBER_Click);
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.Color.Transparent;
            this.Confirm.FlatAppearance.BorderSize = 0;
            this.Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm.ForeColor = System.Drawing.Color.Transparent;
            this.Confirm.Location = new System.Drawing.Point(629, 584);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(167, 54);
            this.Confirm.TabIndex = 27;
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // dataMenuSelling
            // 
            this.dataMenuSelling.AllowUserToAddRows = false;
            this.dataMenuSelling.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataMenuSelling.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.dataMenuSelling.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMenuSelling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataMenuSelling.ColumnHeadersHeight = 32;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataMenuSelling.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataMenuSelling.EnableHeadersVisualStyles = false;
            this.dataMenuSelling.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.dataMenuSelling.Location = new System.Drawing.Point(71, 211);
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
            this.dataMenuSelling.RowHeadersVisible = false;
            this.dataMenuSelling.RowHeadersWidth = 51;
            this.dataMenuSelling.RowTemplate.Height = 24;
            this.dataMenuSelling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMenuSelling.Size = new System.Drawing.Size(735, 314);
            this.dataMenuSelling.TabIndex = 28;
            this.dataMenuSelling.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMenuSelling_CellContentClick);
            // 
            // ShowPrice
            // 
            this.ShowPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.ShowPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.ShowPrice.Location = new System.Drawing.Point(168, 547);
            this.ShowPrice.Name = "ShowPrice";
            this.ShowPrice.ReadOnly = true;
            this.ShowPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowPrice.Size = new System.Drawing.Size(206, 31);
            this.ShowPrice.TabIndex = 29;
            this.ShowPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ShowPrice.TextChanged += new System.EventHandler(this.ShowPrice_TextChanged);
            // 
            // QRcode
            // 
            this.QRcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.QRcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QRcode.ErrorImage = null;
            this.QRcode.InitialImage = null;
            this.QRcode.Location = new System.Drawing.Point(823, 211);
            this.QRcode.Name = "QRcode";
            this.QRcode.Size = new System.Drawing.Size(368, 314);
            this.QRcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QRcode.TabIndex = 30;
            this.QRcode.TabStop = false;
            this.QRcode.Click += new System.EventHandler(this.QRcode_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Day2.Properties.Resources.BUNGVDOGIFFFF;
            this.pictureBox1.Image = global::Day2.Properties.Resources.BUNGVDOGIFFFF;
            this.pictureBox1.Location = new System.Drawing.Point(508, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // PhoneBox
            // 
            this.PhoneBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.PhoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneBox.ForeColor = System.Drawing.SystemColors.Info;
            this.PhoneBox.FormattingEnabled = true;
            this.PhoneBox.Location = new System.Drawing.Point(823, 129);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(368, 33);
            this.PhoneBox.TabIndex = 33;
            this.PhoneBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PhoneAdminBox
            // 
            this.PhoneAdminBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.PhoneAdminBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneAdminBox.ForeColor = System.Drawing.SystemColors.Info;
            this.PhoneAdminBox.FormattingEnabled = true;
            this.PhoneAdminBox.Location = new System.Drawing.Point(823, 168);
            this.PhoneAdminBox.Name = "PhoneAdminBox";
            this.PhoneAdminBox.Size = new System.Drawing.Size(368, 33);
            this.PhoneAdminBox.TabIndex = 34;
            // 
            // ShowVat
            // 
            this.ShowVat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.ShowVat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowVat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.ShowVat.Location = new System.Drawing.Point(175, 597);
            this.ShowVat.Name = "ShowVat";
            this.ShowVat.ReadOnly = true;
            this.ShowVat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowVat.Size = new System.Drawing.Size(199, 31);
            this.ShowVat.TabIndex = 35;
            this.ShowVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ShowVat.TextChanged += new System.EventHandler(this.ShowVat_TextChanged);
            // 
            // ShowSum
            // 
            this.ShowSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(80)))));
            this.ShowSum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.ShowSum.Location = new System.Drawing.Point(967, 597);
            this.ShowSum.Name = "ShowSum";
            this.ShowSum.ReadOnly = true;
            this.ShowSum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowSum.Size = new System.Drawing.Size(173, 31);
            this.ShowSum.TabIndex = 36;
            this.ShowSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ShowDiscount
            // 
            this.ShowDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.ShowDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.ShowDiscount.Location = new System.Drawing.Point(988, 547);
            this.ShowDiscount.Name = "ShowDiscount";
            this.ShowDiscount.ReadOnly = true;
            this.ShowDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowDiscount.Size = new System.Drawing.Size(152, 31);
            this.ShowDiscount.TabIndex = 37;
            this.ShowDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculateDiscount
            // 
            this.btnCalculateDiscount.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculateDiscount.FlatAppearance.BorderSize = 0;
            this.btnCalculateDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateDiscount.ForeColor = System.Drawing.Color.Transparent;
            this.btnCalculateDiscount.Location = new System.Drawing.Point(458, 584);
            this.btnCalculateDiscount.Name = "btnCalculateDiscount";
            this.btnCalculateDiscount.Size = new System.Drawing.Size(171, 54);
            this.btnCalculateDiscount.TabIndex = 38;
            this.btnCalculateDiscount.UseVisualStyleBackColor = false;
            this.btnCalculateDiscount.Click += new System.EventHandler(this.btnCalculateDiscount_Click_1);
            // 
            // ShowSumPrice
            // 
            this.ShowSumPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.ShowSumPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowSumPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowSumPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.ShowSumPrice.Location = new System.Drawing.Point(582, 547);
            this.ShowSumPrice.Name = "ShowSumPrice";
            this.ShowSumPrice.ReadOnly = true;
            this.ShowSumPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowSumPrice.Size = new System.Drawing.Size(180, 31);
            this.ShowSumPrice.TabIndex = 39;
            this.ShowSumPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Page7_Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Day2.Properties.Resources._99669966;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.ShowSumPrice);
            this.Controls.Add(this.btnCalculateDiscount);
            this.Controls.Add(this.ShowDiscount);
            this.Controls.Add(this.ShowSum);
            this.Controls.Add(this.ShowVat);
            this.Controls.Add(this.PhoneAdminBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.QRcode);
            this.Controls.Add(this.ShowPrice);
            this.Controls.Add(this.dataMenuSelling);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.MEMBER);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Page7_Confirm";
            this.Text = "CALCULATE PRICE";
            this.Load += new System.EventHandler(this.Page7_Confirm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMenuSelling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.Button MEMBER;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.DataGridView dataMenuSelling;
        private System.Windows.Forms.TextBox ShowPrice;
        private System.Windows.Forms.PictureBox QRcode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox PhoneBox;
        private System.Windows.Forms.ComboBox PhoneAdminBox;
        private System.Windows.Forms.TextBox ShowVat;
        private System.Windows.Forms.TextBox ShowSum;
        private System.Windows.Forms.TextBox ShowDiscount;
        private System.Windows.Forms.Button btnCalculateDiscount;
        private System.Windows.Forms.TextBox ShowSumPrice;
    }
}
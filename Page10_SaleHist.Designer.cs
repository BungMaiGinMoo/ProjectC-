namespace Day2
{
    partial class Page10_SaleHist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page10_SaleHist));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimeDAY = new System.Windows.Forms.DateTimePicker();
            this.ShowDayHist = new System.Windows.Forms.TextBox();
            this.ShowMonthHist = new System.Windows.Forms.TextBox();
            this.dateTimeMonth = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Bestselling = new System.Windows.Forms.TextBox();
            this.ShowCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1059, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 37);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1059, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 37);
            this.button3.TabIndex = 23;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimeDAY
            // 
            this.dateTimeDAY.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.dateTimeDAY.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.dateTimeDAY.CustomFormat = " ddMMMMyyyy";
            this.dateTimeDAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDAY.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDAY.Location = new System.Drawing.Point(725, 240);
            this.dateTimeDAY.Name = "dateTimeDAY";
            this.dateTimeDAY.Size = new System.Drawing.Size(348, 36);
            this.dateTimeDAY.TabIndex = 25;
            this.dateTimeDAY.Value = new System.DateTime(2024, 6, 1, 0, 0, 0, 0);
            this.dateTimeDAY.ValueChanged += new System.EventHandler(this.dateTimeDAY_ValueChanged);
            // 
            // ShowDayHist
            // 
            this.ShowDayHist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.ShowDayHist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowDayHist.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDayHist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ShowDayHist.Location = new System.Drawing.Point(851, 306);
            this.ShowDayHist.Name = "ShowDayHist";
            this.ShowDayHist.ReadOnly = true;
            this.ShowDayHist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowDayHist.Size = new System.Drawing.Size(197, 31);
            this.ShowDayHist.TabIndex = 38;
            this.ShowDayHist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ShowDayHist.TextChanged += new System.EventHandler(this.ShowDayHist_TextChanged);
            // 
            // ShowMonthHist
            // 
            this.ShowMonthHist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.ShowMonthHist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowMonthHist.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowMonthHist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ShowMonthHist.Location = new System.Drawing.Point(851, 584);
            this.ShowMonthHist.Name = "ShowMonthHist";
            this.ShowMonthHist.ReadOnly = true;
            this.ShowMonthHist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowMonthHist.Size = new System.Drawing.Size(197, 31);
            this.ShowMonthHist.TabIndex = 40;
            this.ShowMonthHist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimeMonth
            // 
            this.dateTimeMonth.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.dateTimeMonth.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.dateTimeMonth.CustomFormat = " ddMMMMyyyy";
            this.dateTimeMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeMonth.Location = new System.Drawing.Point(725, 518);
            this.dateTimeMonth.Name = "dateTimeMonth";
            this.dateTimeMonth.Size = new System.Drawing.Size(348, 36);
            this.dateTimeMonth.TabIndex = 39;
            this.dateTimeMonth.Value = new System.DateTime(2024, 6, 1, 10, 4, 51, 0);
            this.dateTimeMonth.ValueChanged += new System.EventHandler(this.dateTimeMonth_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::Day2.Properties.Resources.VDOSPORTGIFFFFF;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Day2.Properties.Resources.VDOSPORTGIFFFFF;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(535, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // Bestselling
            // 
            this.Bestselling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.Bestselling.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Bestselling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bestselling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Bestselling.Location = new System.Drawing.Point(92, 579);
            this.Bestselling.Name = "Bestselling";
            this.Bestselling.ReadOnly = true;
            this.Bestselling.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bestselling.Size = new System.Drawing.Size(281, 17);
            this.Bestselling.TabIndex = 42;
            this.Bestselling.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bestselling.TextChanged += new System.EventHandler(this.Bestselling_TextChanged);
            // 
            // ShowCount
            // 
            this.ShowCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ShowCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.ShowCount.Location = new System.Drawing.Point(229, 537);
            this.ShowCount.Name = "ShowCount";
            this.ShowCount.ReadOnly = true;
            this.ShowCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowCount.Size = new System.Drawing.Size(38, 15);
            this.ShowCount.TabIndex = 46;
            this.ShowCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Page10_SaleHist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Day2.Properties.Resources._131313131313;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.ShowCount);
            this.Controls.Add(this.Bestselling);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ShowMonthHist);
            this.Controls.Add(this.dateTimeMonth);
            this.Controls.Add(this.ShowDayHist);
            this.Controls.Add(this.dateTimeDAY);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Page10_SaleHist";
            this.Text = "SALES HISTORY";
            this.Load += new System.EventHandler(this.Page10_SaleHist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimeDAY;
        private System.Windows.Forms.TextBox ShowDayHist;
        private System.Windows.Forms.TextBox ShowMonthHist;
        private System.Windows.Forms.DateTimePicker dateTimeMonth;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Bestselling;
        private System.Windows.Forms.TextBox ShowCount;
    }
}
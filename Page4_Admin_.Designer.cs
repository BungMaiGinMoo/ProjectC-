namespace Day2
{
    partial class Page4_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page4_Admin));
            this.dataEquipment = new System.Windows.Forms.DataGridView();
            this.NameText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.editBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.PictueSelect = new System.Windows.Forms.Button();
            this.IDText = new System.Windows.Forms.TextBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SizeText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.CountText = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountText)).BeginInit();
            this.SuspendLayout();
            // 
            // dataEquipment
            // 
            this.dataEquipment.AllowUserToAddRows = false;
            this.dataEquipment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataEquipment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataEquipment.ColumnHeadersHeight = 32;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataEquipment.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataEquipment.EnableHeadersVisualStyles = false;
            this.dataEquipment.GridColor = System.Drawing.SystemColors.Control;
            this.dataEquipment.Location = new System.Drawing.Point(741, 333);
            this.dataEquipment.Name = "dataEquipment";
            this.dataEquipment.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataEquipment.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataEquipment.RowHeadersWidth = 35;
            this.dataEquipment.RowTemplate.Height = 24;
            this.dataEquipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEquipment.Size = new System.Drawing.Size(450, 313);
            this.dataEquipment.TabIndex = 0;
            this.dataEquipment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEquipment_CellClick);
            this.dataEquipment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataEquipment.Click += new System.EventHandler(this.dataEquipment_Click);
            // 
            // NameText
            // 
            this.NameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.Location = new System.Drawing.Point(187, 184);
            this.NameText.Multiline = true;
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(354, 30);
            this.NameText.TabIndex = 3;
            this.NameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(28, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 62);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.submitBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.Color.Transparent;
            this.deleteBTN.FlatAppearance.BorderSize = 0;
            this.deleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBTN.Location = new System.Drawing.Point(253, 584);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(219, 62);
            this.deleteBTN.TabIndex = 6;
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // editBTN
            // 
            this.editBTN.BackColor = System.Drawing.Color.Transparent;
            this.editBTN.FlatAppearance.BorderSize = 0;
            this.editBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBTN.Location = new System.Drawing.Point(478, 584);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(216, 62);
            this.editBTN.TabIndex = 7;
            this.editBTN.UseVisualStyleBackColor = false;
            this.editBTN.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.pictureBox1.BackgroundImage = global::Day2.Properties.Resources.VDOSPORTGIFFFFF;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Day2.Properties.Resources.VDOSPORTGIFFFFF;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(741, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PriceText
            // 
            this.PriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceText.Location = new System.Drawing.Point(187, 427);
            this.PriceText.Name = "PriceText";
            this.PriceText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PriceText.Size = new System.Drawing.Size(354, 31);
            this.PriceText.TabIndex = 10;
            this.PriceText.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // PictueSelect
            // 
            this.PictueSelect.BackColor = System.Drawing.Color.Transparent;
            this.PictueSelect.FlatAppearance.BorderSize = 0;
            this.PictueSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PictueSelect.ForeColor = System.Drawing.Color.Transparent;
            this.PictueSelect.Location = new System.Drawing.Point(201, 486);
            this.PictueSelect.Name = "PictueSelect";
            this.PictueSelect.Size = new System.Drawing.Size(319, 90);
            this.PictueSelect.TabIndex = 11;
            this.PictueSelect.UseVisualStyleBackColor = false;
            this.PictueSelect.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // IDText
            // 
            this.IDText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.IDText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.IDText.Location = new System.Drawing.Point(187, 98);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(354, 31);
            this.IDText.TabIndex = 12;
            this.IDText.TextChanged += new System.EventHandler(this.IDText_TextChanged);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(749, 278);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(384, 31);
            this.SearchBox.TabIndex = 13;
            this.SearchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(33, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 37);
            this.button3.TabIndex = 18;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // SizeText
            // 
            this.SizeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SizeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeText.Location = new System.Drawing.Point(187, 263);
            this.SizeText.Name = "SizeText";
            this.SizeText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeText.Size = new System.Drawing.Size(354, 31);
            this.SizeText.TabIndex = 19;
            this.SizeText.TextChanged += new System.EventHandler(this.SizeText_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(33, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 37);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // CountText
            // 
            this.CountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountText.Location = new System.Drawing.Point(187, 342);
            this.CountText.Name = "CountText";
            this.CountText.Size = new System.Drawing.Size(354, 38);
            this.CountText.TabIndex = 24;
            this.CountText.ValueChanged += new System.EventHandler(this.CountText_ValueChanged);
            // 
            // Page4_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::Day2.Properties.Resources._44444444;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.CountText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SizeText);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.IDText);
            this.Controls.Add(this.PictueSelect);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.editBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.dataEquipment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Page4_Admin";
            this.Text = "ADMIN STOCK";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataEquipment;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button editBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.Button PictueSelect;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox SizeText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown CountText;
    }
}


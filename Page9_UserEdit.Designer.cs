namespace Day2
{
    partial class Page9_UserEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page9_UserEdit));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PhoneText = new System.Windows.Forms.TextBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.dataUser = new System.Windows.Forms.DataGridView();
            this.EditBot = new System.Windows.Forms.Button();
            this.idText = new System.Windows.Forms.TextBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.DeleteBot = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1059, 121);
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
            this.button3.Location = new System.Drawing.Point(1059, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 37);
            this.button3.TabIndex = 23;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PhoneText
            // 
            this.PhoneText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PhoneText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PhoneText.Location = new System.Drawing.Point(752, 499);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(342, 31);
            this.PhoneText.TabIndex = 30;
            // 
            // LastNameText
            // 
            this.LastNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LastNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LastNameText.Location = new System.Drawing.Point(752, 401);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(342, 31);
            this.LastNameText.TabIndex = 29;
            // 
            // NameText
            // 
            this.NameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NameText.Location = new System.Drawing.Point(752, 304);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(342, 31);
            this.NameText.TabIndex = 28;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // dataUser
            // 
            this.dataUser.AllowUserToAddRows = false;
            this.dataUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataUser.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataUser.ColumnHeadersHeight = 32;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataUser.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataUser.EnableHeadersVisualStyles = false;
            this.dataUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.dataUser.Location = new System.Drawing.Point(71, 243);
            this.dataUser.Name = "dataUser";
            this.dataUser.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataUser.RowHeadersWidth = 30;
            this.dataUser.RowTemplate.Height = 24;
            this.dataUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataUser.Size = new System.Drawing.Size(534, 220);
            this.dataUser.TabIndex = 31;
            this.dataUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEquipment_CellContentClick);
            this.dataUser.Click += new System.EventHandler(this.dataUser_Click);
            // 
            // EditBot
            // 
            this.EditBot.BackColor = System.Drawing.Color.Transparent;
            this.EditBot.FlatAppearance.BorderSize = 0;
            this.EditBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBot.Location = new System.Drawing.Point(694, 590);
            this.EditBot.Name = "EditBot";
            this.EditBot.Size = new System.Drawing.Size(214, 61);
            this.EditBot.TabIndex = 32;
            this.EditBot.UseVisualStyleBackColor = false;
            this.EditBot.Click += new System.EventHandler(this.EditBot_Click);
            // 
            // idText
            // 
            this.idText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.idText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.idText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.idText.Location = new System.Drawing.Point(71, 243);
            this.idText.Name = "idText";
            this.idText.ReadOnly = true;
            this.idText.Size = new System.Drawing.Size(75, 31);
            this.idText.TabIndex = 33;
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.SearchBox.Location = new System.Drawing.Point(84, 185);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(458, 31);
            this.SearchBox.TabIndex = 34;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // DeleteBot
            // 
            this.DeleteBot.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBot.FlatAppearance.BorderSize = 0;
            this.DeleteBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBot.Location = new System.Drawing.Point(931, 590);
            this.DeleteBot.Name = "DeleteBot";
            this.DeleteBot.Size = new System.Drawing.Size(214, 61);
            this.DeleteBot.TabIndex = 35;
            this.DeleteBot.UseVisualStyleBackColor = false;
            this.DeleteBot.Click += new System.EventHandler(this.DeleteBot_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::Day2.Properties.Resources.VDOSPORTGIFFFFF;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Day2.Properties.Resources.VDOSPORTGIFFFFF;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(152, 482);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // Page9_UserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Day2.Properties.Resources._1212121212121212121212121212;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DeleteBot);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.EditBot);
            this.Controls.Add(this.dataUser);
            this.Controls.Add(this.PhoneText);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.idText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Page9_UserEdit";
            this.Text = "EDIT MEMBERSHIP";
            this.Load += new System.EventHandler(this.Page9_UserEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox PhoneText;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.DataGridView dataUser;
        private System.Windows.Forms.Button EditBot;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button DeleteBot;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
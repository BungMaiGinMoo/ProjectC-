namespace Day2
{
    partial class Page2_SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page2_SignIn));
            this.button2 = new System.Windows.Forms.Button();
            this.NameText = new System.Windows.Forms.TextBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.PhoneText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.UserText = new System.Windows.Forms.TextBox();
            this.CreatBot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1069, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 37);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NameText
            // 
            this.NameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NameText.Location = new System.Drawing.Point(228, 270);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(372, 31);
            this.NameText.TabIndex = 20;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // LastNameText
            // 
            this.LastNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LastNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LastNameText.Location = new System.Drawing.Point(661, 270);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(372, 31);
            this.LastNameText.TabIndex = 21;
            this.LastNameText.TextChanged += new System.EventHandler(this.LastNameBox1_TextChanged);
            // 
            // EmailText
            // 
            this.EmailText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EmailText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.EmailText.Location = new System.Drawing.Point(661, 376);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(372, 31);
            this.EmailText.TabIndex = 23;
            this.EmailText.TextChanged += new System.EventHandler(this.EmailText_TextChanged);
            // 
            // PhoneText
            // 
            this.PhoneText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PhoneText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PhoneText.Location = new System.Drawing.Point(228, 376);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(372, 31);
            this.PhoneText.TabIndex = 22;
            this.PhoneText.TextChanged += new System.EventHandler(this.PhoneText_TextChanged);
            // 
            // PasswordText
            // 
            this.PasswordText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PasswordText.Location = new System.Drawing.Point(661, 481);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(372, 31);
            this.PasswordText.TabIndex = 25;
            this.PasswordText.TextChanged += new System.EventHandler(this.PasswordText_TextChanged);
            // 
            // UserText
            // 
            this.UserText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UserText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UserText.Location = new System.Drawing.Point(228, 481);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(372, 31);
            this.UserText.TabIndex = 24;
            this.UserText.TextChanged += new System.EventHandler(this.UserText_TextChanged);
            // 
            // CreatBot
            // 
            this.CreatBot.BackColor = System.Drawing.Color.Transparent;
            this.CreatBot.FlatAppearance.BorderSize = 0;
            this.CreatBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatBot.Location = new System.Drawing.Point(523, 587);
            this.CreatBot.Name = "CreatBot";
            this.CreatBot.Size = new System.Drawing.Size(214, 71);
            this.CreatBot.TabIndex = 26;
            this.CreatBot.UseVisualStyleBackColor = false;
            this.CreatBot.Click += new System.EventHandler(this.CreatBot_Click);
            // 
            // Page2_SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Day2.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.CreatBot);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UserText);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.PhoneText);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Page2_SignIn";
            this.Text = "ADMIN SIGNIN";
            this.Load += new System.EventHandler(this.Page2_SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox PhoneText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.Button CreatBot;
    }
}
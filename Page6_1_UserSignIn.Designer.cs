namespace Day2
{
    partial class Page6_UserSignIn
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
            this.PhoneText = new System.Windows.Forms.TextBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.CreatBot = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PhoneText
            // 
            this.PhoneText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PhoneText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PhoneText.Location = new System.Drawing.Point(445, 482);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(372, 31);
            this.PhoneText.TabIndex = 27;
            this.PhoneText.TextChanged += new System.EventHandler(this.PhoneText_TextChanged);
            // 
            // LastNameText
            // 
            this.LastNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LastNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LastNameText.Location = new System.Drawing.Point(445, 377);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(372, 31);
            this.LastNameText.TabIndex = 26;
            this.LastNameText.TextChanged += new System.EventHandler(this.LastNameText_TextChanged);
            // 
            // NameText
            // 
            this.NameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NameText.Location = new System.Drawing.Point(445, 271);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(372, 31);
            this.NameText.TabIndex = 25;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // CreatBot
            // 
            this.CreatBot.BackColor = System.Drawing.Color.Transparent;
            this.CreatBot.FlatAppearance.BorderSize = 0;
            this.CreatBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatBot.Location = new System.Drawing.Point(522, 586);
            this.CreatBot.Name = "CreatBot";
            this.CreatBot.Size = new System.Drawing.Size(214, 73);
            this.CreatBot.TabIndex = 30;
            this.CreatBot.UseVisualStyleBackColor = false;
            this.CreatBot.Click += new System.EventHandler(this.CreatBot_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1068, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 37);
            this.button2.TabIndex = 29;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Page6_UserSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Day2.Properties.Resources._888888;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.CreatBot);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PhoneText);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.NameText);
            this.Name = "Page6_UserSignIn";
            this.Text = "MEMBERSHIP";
            this.Load += new System.EventHandler(this.Page6_UserSignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PhoneText;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Button CreatBot;
        private System.Windows.Forms.Button button2;
    }
}
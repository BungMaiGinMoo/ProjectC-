using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day2
{
    public partial class Page1_Main : Form
    {

        public Page1_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //หน้า about
        {
            LastPage pg = new LastPage();
            pg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) //หน้า admin login
        {
            Page3_login pg = new Page3_login();
            pg.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e) //หน้าสั่งสินค้า
        {
            Page5_Selling pg = new Page5_Selling();
            pg.Show();
            this.Hide();
        }

        private void Page1_Main_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e) //หน้า สมัครสมาชิก
        {
            Page6_UserSignIn pg = new Page6_UserSignIn();
            pg.Show();
            this.Hide();
        }
    }
}

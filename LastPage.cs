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
    public partial class LastPage : Form
    {
        public LastPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // ปุ่ม Home 
        {
            Page1_Main pg = new Page1_Main();
            pg.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e) // ปุ่มซื้อสินค้า
        {
            Page5_Selling pg = new Page5_Selling();
            pg.Show();
            this.Hide();
        }

        private void LastPage_Load(object sender, EventArgs e)
        {

        }
    }
}

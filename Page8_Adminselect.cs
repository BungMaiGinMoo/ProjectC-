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
    public partial class Page8_Adminselect : Form
    {
        public Page8_Adminselect()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // ปุ่ม back
        {
            Page3_login pg = new Page3_login();
            pg.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e) // ปุ่ม Home
        {
            Page1_Main pg = new Page1_Main();
            pg.Show();
            this.Hide();
        }

        private void StockBot_Click(object sender, EventArgs e) // ปุ่ม ไปที่หน้า จัดการสินค้าหลังบ้าน
        {
            Page4_Admin pg = new Page4_Admin();
            pg.Show();
            this.Hide();
        }

        private void UserBot_Click(object sender, EventArgs e) // ปุ่มแก้ไขข้อมูลลูกค้า
        {
            Page9_UserEdit pg = new Page9_UserEdit();
            pg.Show();
            this.Hide();
        }
        
        private void HistoryBot_Click(object sender, EventArgs e) // ปุ่มประวัติการซื้อขายรายวันและรายเดือน
        {
            Page10_SaleHist pg = new Page10_SaleHist();
            pg.Show();
            this.Hide();
        }

        private void UserHistoryBot_Click(object sender, EventArgs e) // ปุ่มประวัติการซื้อรายบุคคล user
        {
            Page11_UserSaleHist pg = new Page11_UserSaleHist();
            pg.Show();
            this.Hide();
        }

        private void Page8_Adminselect_Load(object sender, EventArgs e)
        {

        }

        private void AdminHistoryBot_Click(object sender, EventArgs e) //ปุ่มประวัติการขายรายบุคคล และเข้าดูประวัติการซื้อขายเสื้อรายตัว เสื้อ best selling ประจำเดือน
        {
            Page12_AdminSaleHist pg = new Page12_AdminSaleHist();
            pg.Show();
            this.Hide();
        }
    }
}

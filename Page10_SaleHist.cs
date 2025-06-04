using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day2
{
    public partial class Page10_SaleHist : Form
    {
        public Page10_SaleHist()
        {
            InitializeComponent();
            // เมื่อโหลด Form ให้คำนวณยอดรายวันทันที
            CalculateTotalPriceByDay();

            // เมื่อโหลด Form ให้คำนวณยอดรายเดือนทันที
            CalculateTotalPriceByMonth();

            // เมื่อโหลด Form ให้คำนวณหาสินค้าที่ขายดีที่สุดรายเดือน และแสดงรูปภาพทันที
            CalculateTotalPriceByMonthv2();
        }
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=program_bungboom;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        private void Page10_SaleHist_Load(object sender, EventArgs e)
        {
            
        }

        //ฟังก์ชั่นคำนวณรายได้รายวัน
        private void CalculateTotalPriceByDay()
        {
            // รับวันที่ที่ผู้ใช้เลือกจาก dateTimeDAY
            DateTime selectedDate = dateTimeDAY.Value.Date;

            // เชื่อมต่อกับฐานข้อมูล
            using (MySqlConnection conn = databaseConnection())
            {
                conn.Open();

                // สร้างคำสั่ง SQL เพื่อค้นหาข้อมูลในตาราง saleshistory ในวันที่ที่ผู้ใช้เลือก
                string query = $"SELECT price FROM saleshistory WHERE DATE(date) = '{selectedDate.ToString("yyyy-MM-dd")}'";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Execute คำสั่ง SQL เพื่อดึงข้อมูล price
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        double totalPrice = 0;

                        // วนลูปอ่านข้อมูล price และคำนวณราคารวม
                        while (reader.Read())
                        {
                            // ตรวจสอบว่าข้อมูล price ไม่เป็นค่าว่าง
                            if (!reader.IsDBNull(0))
                            {
                                // อ่านข้อมูล price โดยตรง
                                string priceData = reader.GetString(0);

                                // ตรวจสอบว่าราคาเป็นตัวเลขได้
                                if (double.TryParse(priceData, out double currentPrice))
                                {
                                    totalPrice += currentPrice;
                                }
                            }
                        }

                        // แสดงผลลัพธ์ที่ถูกต้อง
                        ShowDayHist.Text = Math.Round(totalPrice, 2).ToString("#,##0.00");
                        
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) // ปุ่ม Home
        {
            Page1_Main pg = new Page1_Main();
            pg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) // ปุ่ม back
        {
            Page8_Adminselect pg = new Page8_Adminselect();
            pg.Show();
            this.Hide();
        }

        private void dateTimeDAY_ValueChanged(object sender, EventArgs e) //datetime pick รายวัน
        {
            // เมื่อมีการเปลี่ยนค่าใน dateTimePicker1 ให้คำนวณยอดรายวันใหม่
            CalculateTotalPriceByDay();
        }

        //ฟังก์ชั่นคำนวณรายได้รายเดือน
        private void CalculateTotalPriceByMonth()
        {
            // รับวันที่ที่ผู้ใช้เลือกจาก dateTimePicker2
            DateTime selectedDate = dateTimeMonth.Value.Date;

            // กำหนดวันที่เริ่มต้นของเดือน
            DateTime startDate = new DateTime( selectedDate.Year, selectedDate.Month,1);

            // กำหนดวันที่สิ้นสุดของเดือน
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);

            // เชื่อมต่อกับฐานข้อมูล
            using (MySqlConnection conn = databaseConnection())
            {
                conn.Open();

                // สร้างคำสั่ง SQL เพื่อค้นหาข้อมูลในตาราง orderhistory ในวันที่ที่ผู้ใช้เลือก
                string query = $"SELECT price FROM saleshistory WHERE DATE(date) BETWEEN '{startDate.ToString("yyyy-MM-dd")}' AND '{endDate.ToString("yyyy-MM-dd")}'";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Execute คำสั่ง SQL เพื่อดึงข้อมูล price
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        double totalPrice = 0;

                        // วนลูปอ่านข้อมูล price และคำนวณราคารวม
                        while (reader.Read())
                        {
                            // ตรวจสอบว่าข้อมูล price ไม่เป็นค่าว่าง
                            if (!reader.IsDBNull(0))
                            {
                                // อ่านข้อมูล price โดยตรง
                                string priceData = reader.GetString(0);

                                // ตรวจสอบว่าราคาเป็นตัวเลขได้
                                if (double.TryParse(priceData, out double currentPrice))
                                {
                                    totalPrice += currentPrice;
                                }
                            }
                        }

                        // แสดงผลลัพธ์ที่ถูกต้อง
                        ShowMonthHist.Text = Math.Round(totalPrice, 2).ToString("#,##0.00");
                    }
                }
            }
        }
        //ฟังก์ชั่นการแสดงยอดขาย best selling และคำนวณผลรวมจำนวณเสื้อ มากที่สุดต่อเดือน
        private void CalculateTotalPriceByMonthv2()
        {
            // รับวันที่ที่ผู้ใช้เลือกจาก dateTimeMonth
            DateTime selectedDate = dateTimeMonth.Value.Date;

            // กำหนดวันที่เริ่มต้นของเดือน
            DateTime startDate = new DateTime(selectedDate.Year, selectedDate.Month, 1);

            // กำหนดวันที่สิ้นสุดของเดือน
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);

            // เชื่อมต่อกับฐานข้อมูล
            using (MySqlConnection conn = databaseConnection())
            {
                conn.Open();

                // สร้างคำสั่ง SQL เพื่อค้นหาข้อมูลในตาราง saleshistory ในวันที่ที่ผู้ใช้เลือก
                string query = $"SELECT name, SUM(CAST(count AS UNSIGNED)) AS totalCount FROM saleshistory WHERE DATE(date) BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}' GROUP BY name ORDER BY totalCount DESC LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Execute คำสั่ง SQL เพื่อดึงข้อมูลสินค้าที่มียอดขายรวมสูงสุด
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // ตรวจสอบว่ามีข้อมูลหรือไม่
                        if (reader.Read())
                        {
                            // แสดงชื่อสินค้าที่ขายดีที่สุด
                            string bestsellingProduct = reader.GetString("name");
                            int totalCount = reader.GetInt32("totalCount");

                            Bestselling.Text = bestsellingProduct;
                            ShowCount.Text = totalCount.ToString();

                            // โชว์รูปภาพจากฐานข้อมูลโดยใช้ชื่อสินค้าที่ขายดีที่สุด
                            ShowProductImage(bestsellingProduct);
                        }
                        else
                        {
                            // ถ้าไม่มีรายการสินค้าในเดือนนี้
                            Bestselling.Text = "There are no items.";
                            ShowCount.Text = "0";

                            // ถ้าไม่มีรูปภาพในฐานข้อมูลให้กำหนดรูปภาพเริ่มต้นที่ตั้งไว้
                            pictureBox1.Image = Properties.Resources.VDOSPORTGIFFFFF;
                        }
                    }
                }
            }
        }

        //โชว์รูปภาพ Best selling และดึงข้อมูลรูปภาพตามชื่อสินค้า best selling
        private void ShowProductImage(string bestsellingProduct)
        {
            // เชื่อมต่อกับฐานข้อมูล
            using (MySqlConnection conn = databaseConnection())
            {
                conn.Open();

                // สร้างคำสั่ง SQL เพื่อค้นหารูปภาพจากชื่อสินค้า
                string query = $"SELECT photo FROM stock WHERE name = '{bestsellingProduct}'";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // อ่านข้อมูลรูปภาพจากฐานข้อมูล
                            byte[] imageData = (byte[])reader["photo"];

                            // แปลงข้อมูลรูปภาพเป็นรูปภาพ
                            MemoryStream ms = new MemoryStream(imageData);
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                }
            }
        }


        private void dateTimeMonth_ValueChanged(object sender, EventArgs e) //datetime pick รายเดือน
        {
            // เมื่อมีการเปลี่ยนค่าใน dateTimePicker2 ให้คำนวณยอดรายเดือนใหม่
            CalculateTotalPriceByMonth();
            CalculateTotalPriceByMonthv2();
        }

        private void ShowDayHist_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bestselling_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

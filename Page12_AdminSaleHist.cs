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
    public partial class Page12_AdminSaleHist : Form
    {
        public Page12_AdminSaleHist()
        {
            InitializeComponent();
        }

        private void Page12_AdminSaleHist_Load(object sender, EventArgs e)
        {
            ShowNameBox();
            ShowAdminBox();
            CalculateTotal();
            CalculateQuantity();
            BestSelling();
        }
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=program_bungboom;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1; port=3306;Initial Catalog = 'program_bungboom'; username=root; password=");

        string connectionString = "datasource=127.0.0.1;port=3306;Initial Catalog = 'program_bungboom'; username=root; password=";

        //คำสั่งโชว์ชื่อเสื้อทั้งหมดใน stock ผ่านการโชว์ใน combobox
        public void ShowNameBox()
        {
            MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1; port=3306;Initial Catalog = 'program_bungboom'; username=root; password=");
            connection.Open();

            string Mysql_Select = "SELECT DISTINCT name FROM stock";
            MySqlCommand command = new MySqlCommand(Mysql_Select, connection);
            command.CommandType = CommandType.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);

            DataRow datarow = data.NewRow();
            datarow["name"] = " - Select Name Shirt - ";
            data.Rows.InsertAt(datarow, 0);
            ShirtBox.DisplayMember = "name";
            ShirtBox.ValueMember = "name";
            ShirtBox.DataSource = data;
            connection.Close();
        }

        //โชว์เบอร์โทรแอดมินใน combobox
        public void ShowAdminBox()
        {
            MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1; port=3306;Initial Catalog = 'program_bungboom'; username=root; password=");
            connection.Open();

            string Mysql_Select = "SELECT phone FROM admin";
            MySqlCommand command = new MySqlCommand(Mysql_Select, connection);
            command.CommandType = CommandType.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);

            DataRow datarow = data.NewRow();
            datarow["phone"] = " - Select Phone Admin - ";
            data.Rows.InsertAt(datarow, 0);
            AdminBox.DisplayMember = "phone";
            AdminBox.ValueMember = "phone";
            AdminBox.DataSource = data;
            connection.Close();
        }

        //คำสั่งค้นหาเบอร์โทรแอดมินใน combobox
        public void FillAdmin(string shirtValueToSearch, string adminValueToSearch)
        {
            MySqlCommand command = new MySqlCommand("SELECT phoneuser, phoneadmin, name, size, count, sum FROM saleshistory WHERE name LIKE @shirtValue AND phoneadmin LIKE @adminValue", connection);
            command.Parameters.AddWithValue("@shirtValue", "%" + shirtValueToSearch + "%");
            command.Parameters.AddWithValue("@adminValue", "%" + adminValueToSearch + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dataUserSelling.RowTemplate.Height = 30;
            dataUserSelling.AllowUserToDeleteRows = false;
            dataUserSelling.DataSource = table;

            // ซ่อนคอลัมน์ทั้งหมดก่อน
            foreach (DataGridViewColumn column in dataUserSelling.Columns)
            {
                column.Visible = false;
            }

            // แสดงเฉพาะคอลัมน์ที่ต้องการและกำหนดความกว้าง
            dataUserSelling.Columns["phoneuser"].Visible = true;
            dataUserSelling.Columns["phoneuser"].Width = 90;

            dataUserSelling.Columns["phoneadmin"].Visible = true;
            dataUserSelling.Columns["phoneadmin"].Width = 90;

            dataUserSelling.Columns["name"].Visible = true;
            dataUserSelling.Columns["name"].Width = 190;

            dataUserSelling.Columns["size"].Visible = true;
            dataUserSelling.Columns["size"].Width = 40;

            dataUserSelling.Columns["count"].Visible = true;
            dataUserSelling.Columns["count"].Width = 40;

            dataUserSelling.Columns["sum"].Visible = true;
            dataUserSelling.Columns["sum"].Width = 78;

            CalculateTotal();
            CalculateQuantity();
            BestSelling();
        }

        //คำนวณราคารวม
        private void CalculateTotal()
        {
            decimal totalSum = 0.00m;

            // Check if there are rows in the dataMenuSelling DataGridView
            if (dataUserSelling.Rows.Count > 0)
            {
                // Loop through each row
                foreach (DataGridViewRow row in dataUserSelling.Rows)
                {
                    // Try parsing the value in the column 5 (assuming it's numeric)
                    if (decimal.TryParse(row.Cells[5].Value?.ToString(), out decimal value))
                    {
                        totalSum += value;
                    }
                }
            }

            // Update the tb_total textbox with the calculated total
            ShowPrice.Text = totalSum.ToString("#,0.00"); // ให้แสดงทศนิยม 2 ตำแหน่งและเติมคอมม่า

        }

        //คำนวณจำนวนชิ้นรวม
        private void CalculateQuantity()
        {
            int totalQuantity = 0;

            // ตรวจสอบว่ามีแถวใน DataGridView ที่ชื่อ dataUserSelling หรือไม่
            if (dataUserSelling.Rows.Count > 0)
            {
                // วนลูปผ่านแต่ละแถว
                foreach (DataGridViewRow แถว in dataUserSelling.Rows)
                {
                    // พยายามแปลงค่าจากคอลัมน์ที่ 5 (สมมติว่าเป็นตัวเลข)
                    if (int.TryParse(แถว.Cells[4].Value?.ToString(), out int quantity))
                    {
                        totalQuantity += quantity;
                    }
                }
            }

            // อัปเดต TextBox ที่ชื่อ tb_quantity ด้วยผลรวมที่คำนวณได้
            Quantity.Text = totalQuantity.ToString("#,0"); // ให้แสดงจำนวนเต็มและเติมคอมม่า
        }


        private void button2_Click_1(object sender, EventArgs e) //ปุ่ม Back
        {
            Page8_Adminselect pg = new Page8_Adminselect();
            pg.Show();
            this.Hide();
        }

        private void Home_Click(object sender, EventArgs e) // ปุ่ม Home
        {
            Page1_Main pg = new Page1_Main();
            pg.Show();
            this.Hide();
        }

        //ใส่คำสั่งตรวจสอบค่าใน combobox เพื่อนำไปแสดงข้อมูลใน datagrid
        private void AdminBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedShirt = ShirtBox.Text;
            string selectedAdmin = AdminBox.Text;

            if (selectedShirt == " - Select Name Shirt - " && selectedAdmin == " - Select Phone Admin - ")
            {
                // เรียกใช้เมธอด FillAdmin() โดยส่งข้อมูลว่างเข้าไป
                FillAdmin("", "");
                namebox.Text = "All Admin history";
            }
            else if (selectedShirt == " - Select Name Shirt - " && selectedAdmin != " - Select Phone Admin - ")
            {
                // เรียกใช้เมธอด FillAdmin() โดยส่งข้อมูลของ AdminBox เข้าไป
                FillAdmin("", selectedAdmin);
            }
            else if (selectedShirt != " - Select Name Shirt - " && selectedAdmin == " - Select Phone Admin - ")
            {
                // เรียกใช้เมธอด FillAdmin() โดยส่งข้อมูลของ shirtbox เข้าไป
                FillAdmin(selectedShirt, "");
            }
            else
            {
                // เรียกใช้เมธอด FillAdmin() โดยส่งข้อมูลของทั้งสอง combobox เข้าไป
                FillAdmin(selectedShirt, selectedAdmin);
            }

            if (selectedAdmin != " - Select Phone Admin - ")
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT name, lastname FROM admin WHERE phone = @phone";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@phone", selectedAdmin);

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string fullName = reader["name"].ToString() + " " + reader["lastname"].ToString();
                        namebox.Text = fullName;
                    }
                    else
                    {
                        // ไม่พบข้อมูล
                        namebox.Text = "No user found";
                    }

                    reader.Close();
                }
            }
        }

        //ใส่คำสั่งตรวจสอบค่าใน combobox เพื่อนำไปแสดงข้อมูลใน datagrid
        private void ShirtBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedShirt = ShirtBox.Text;
            string selectedAdmin = AdminBox.Text;

            if (selectedShirt == " - Select Name Shirt - " && selectedAdmin == " - Select Phone Admin - ")
            {
                // เรียกใช้เมธอด FillAdmin() โดยส่งข้อมูลว่างเข้าไป
                FillAdmin("", "");
                namebox.Text = "All Admin history";
            }
            else if (selectedShirt == " - Select Name Shirt - " && selectedAdmin != " - Select Phone Admin - ")
            {
                // เรียกใช้เมธอด FillAdmin() โดยส่งข้อมูลของ AdminBox เข้าไป
                FillAdmin("", selectedAdmin);
            }
            else if (selectedShirt != " - Select Name Shirt - " && selectedAdmin == " - Select Phone Admin - ")
            {
                // เรียกใช้เมธอด FillAdmin() โดยส่งข้อมูลของ shirtbox เข้าไป
                FillAdmin(selectedShirt, "");
            }
            else
            {
                // เรียกใช้เมธอด FillAdmin() โดยส่งข้อมูลของทั้งสอง combobox เข้าไป
                FillAdmin(selectedShirt, selectedAdmin);
            }

            if (selectedAdmin != " - Select Phone Admin - ")
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT name, lastname FROM admin WHERE phone = @phone";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@phone", selectedAdmin);

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string fullName = reader["name"].ToString() + " " + reader["lastname"].ToString();
                        namebox.Text = fullName;
                    }
                    else
                    {
                        // ไม่พบข้อมูล
                        namebox.Text = "No user found";
                    }

                    reader.Close();
                }
            }
        }

        //คำสั่งค้นหาสินค้าขายดีสำหรับ แอดมินรายบุคคล ถ้าไม่เลือกเบอร์โทรแอดมิน จะไม่แสดงรูปภาพ และข้อมูลสินค้าขายดี
        private void BestSelling()
        {
            // รับชื่อผู้ดูแลจาก AdminBox
            string selectedAdmin = AdminBox.Text;

            // เชื่อมต่อกับฐานข้อมูล
            using (MySqlConnection conn = databaseConnection())
            {
                conn.Open();

                // สร้างคำสั่ง SQL เพื่อค้นหาสินค้า bestselling ในตาราง saleshistory เรียงลำดับจากจำนวนมากที่สุดและนำมาเพียง 1 ชื่อเท่านั้น
                string query = "SELECT name, SUM(CAST(count AS UNSIGNED)) AS totalCount FROM saleshistory WHERE phoneadmin = @phoneAdmin GROUP BY name ORDER BY totalCount DESC LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // เพิ่มพารามิเตอร์ลงในคำสั่ง SQL
                    cmd.Parameters.AddWithValue("@phoneAdmin", selectedAdmin);

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

                            // โชว์รูปภาพจากฐานข้อมูลโดยใช้ชื่อสินค้าที่ขายดีที่สุด
                            ShowProductImage(bestsellingProduct);
                        }
                        else
                        {
                            // ถ้าไม่มีรายการสินค้าในเดือนนี้
                            Bestselling.Text = "There are no items.";

                            // ถ้าไม่มีรูปภาพในฐานข้อมูลให้กำหนดรูปภาพเริ่มต้นที่ตั้งไว้
                            pictureBox1.Image = Properties.Resources.VDOSPORTGIFFFFF;
                        }
                    }
                }
            }
        }

        //คำสั่งดึงข้อมูลรูปภาพสินค้าขายดีจากฐานข้อมูลผ่านการอ่านค่า bestsellingProduct จากการค้นหาใน ฟังก์ชั่น BestSelling
        private void ShowProductImage(string bestsellingProduct)
        {
            // เชื่อมต่อกับฐานข้อมูล
            using (MySqlConnection conn = databaseConnection())
            {
                conn.Open();

                // สร้างคำสั่ง SQL เพื่อค้นหารูปภาพจากชื่อสินค้า
                string query = "SELECT photo FROM stock WHERE name = @name";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // เพิ่มพารามิเตอร์ลงในคำสั่ง SQL
                    cmd.Parameters.AddWithValue("@name", bestsellingProduct);

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

    }
}

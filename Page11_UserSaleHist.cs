using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day2
{
    public partial class Page11_UserSaleHist : Form
    {
        public Page11_UserSaleHist()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1; port=3306;Initial Catalog = 'program_bungboom'; username=root; password=");

        string connectionString = "datasource=127.0.0.1;port=3306;Initial Catalog = 'program_bungboom'; username=root; password=";

        private void Page11_UserSaleHist_Load(object sender, EventArgs e)
        {
            ShowPhoneBox();
        }

        // คำสั่งตรวจสอบ combobox เบอร์โทรลูกค้า เพื่อแสดงและคำนวณข้อมูล ราคาต่างๆ
        private void PhoneBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PhoneBox.Text == " - All purchase history - ")
            {
                // เรียกใช้เมธอด FillUser() โดยส่งข้อมูลว่างเข้าไป
                FillUser("");
                namebox.Text = "All purchase history";

                ShowPrice.Text = "0.00";
                ShowVat.Text = "0.00";
                ShowSumPrice.Text = "0.00";
                ShowDiscount.Text = "0.00";
                ShowSum.Text = "0.00";
            }
            else
            {
                // เรียกใช้เมธอด FillUser() โดยส่งข้อมูลที่เลือกใน ComboBox เข้าไป
                FillUser(PhoneBox.Text);
            }

            if (PhoneBox.Text != " - All purchase history - ")
            {
                string selectedPhone = PhoneBox.Text;

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT name, lastname FROM user WHERE phone = @phone";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@phone", selectedPhone);

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
            if (PhoneBox.Text == "Unknown")
            {
                string selectedPhone = PhoneBox.Text;

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT name FROM user WHERE phone = @phone";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@phone", selectedPhone);

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string UnknownName = reader["name"].ToString();
                        namebox.Text = UnknownName;
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

        //คำสั่งโชว์ข้อมูล ใน Combobox เบอร์โทรลูกค้า
        public void ShowPhoneBox()
        {
            MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1; port=3306;Initial Catalog = 'program_bungboom'; username=root; password=");
            connection.Open();

            string Mysql_Select = "SELECT phone FROM user";
            MySqlCommand command = new MySqlCommand(Mysql_Select, connection);
            command.CommandType = CommandType.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);

            DataRow datarow = data.NewRow();
            datarow["phone"] = " - All purchase history - ";
            data.Rows.InsertAt(datarow, 0);
            PhoneBox.DisplayMember = "phone";
            PhoneBox.ValueMember = "phone";
            PhoneBox.DataSource = data;
            connection.Close();
        }

        private void ShowVat_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // ปุ่ม Home
        {
            Page1_Main pg = new Page1_Main();
            pg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) // ปุ่ม Back
        {
            Page8_Adminselect pg = new Page8_Adminselect();
            pg.Show();
            this.Hide();
        }

        private void dataMenuSelling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //คำสั่งค้นหาข้อมูลผ่านเบอร์โทรศัพท์ ใน combobox ผ่านการใช้ searchbox ในการค้นหา และคำสั่งแสดงข้อมูลประวัติการซื้อขายผ่านการเลือกในรูปแบบต่างๆ
        public void FillUser(string valueToSearch)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM saleshistory WHERE CONCAT(phoneuser) LIKE '%" + valueToSearch + "%'", connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dataUserSelling.RowTemplate.Height = 30;

            dataUserSelling.AllowUserToDeleteRows = false;

            dataUserSelling.DataSource = table;

            // กำหนดความกว้างของแต่ละคอลัมน์
            dataUserSelling.Columns[0].Width = 90; // กำหนดความกว้างของคอลัมน์แรกเป็น 90
            dataUserSelling.Columns[1].Width = 90;
            dataUserSelling.Columns[2].Width = 60;
            dataUserSelling.Columns[3].Width = 190;
            dataUserSelling.Columns[4].Width = 50;
            dataUserSelling.Columns[5].Width = 50;
            dataUserSelling.Columns[6].Width = 50;
            dataUserSelling.Columns[7].Width = 72;
            dataUserSelling.Columns[8].Width = 80;
            dataUserSelling.Columns[9].Width = 80;

            calculateTotal();
            CalculateVAT();
            CalculateDiscount();

        }

        //คำนวณผลรวมราคา
        private void calculateTotal()
        {
            decimal totalSum = 0.00m;

            // Check if there are rows in the dataMenuSelling DataGridView
            if (dataUserSelling.Rows.Count > 0)
            {
                // Loop through each row
                foreach (DataGridViewRow row in dataUserSelling.Rows)
                {
                    // Try parsing the value in the column 5 (assuming it's numeric)
                    if (decimal.TryParse(row.Cells[7].Value?.ToString(), out decimal value))
                    {
                        totalSum += value;
                    }
                }
            }

            // Update the tb_total textbox with the calculated total
            ShowPrice.Text = totalSum.ToString("#,0.00"); // ให้แสดงทศนิยม 2 ตำแหน่งและเติมคอมม่า

        }

        //คำนวณ Vat
        private void CalculateVAT()
        {
            // ตรวจสอบว่า ShowPrice.Text ไม่ว่างหรือเป็นช่องว่าง
            if (!string.IsNullOrWhiteSpace(ShowPrice.Text))
            {
                // ลองแปลงค่าใน ShowPrice.Text (สมมติว่าเป็นตัวเลข)
                if (decimal.TryParse(ShowPrice.Text, out decimal total))
                {
                    decimal vat = total * 0.07m; // คำนวณ VAT 7%
                    ShowVat.Text = vat.ToString("#,0.00"); // เพิ่มคอมม่าให้กับตัวเลข
                    ShowSum.Text = (total + vat).ToString("#,0.00"); // เพิ่มคอมม่าให้กับตัวเลข
                                                                     //ผลรวมราคาส่วนลด 
                    decimal SUMvat = total + vat;
                    ShowSumPrice.Text = SUMvat.ToString("#,0.00");
                }
            }
        }

        //คำนวณส่วนลด
        private void CalculateDiscount()
        {
            // ตรวจสอบว่า PhoneBox.Text ไม่ว่างหรือเป็นช่องว่าง
            if (!string.IsNullOrWhiteSpace(PhoneBox.Text))
            {
                // ตรวจสอบว่าเบอร์โทรศัพท์ไม่ใช่ "Unknown"
                if (PhoneBox.Text != "Unknown")
                {
                    // คำนวณส่วนลด
                    if (decimal.TryParse(ShowPrice.Text, out decimal total))
                    {
                        // คำนวณ VAT
                        decimal vat = total * 0.07m; // คำนวณ VAT 7%
                        ShowVat.Text = vat.ToString("#,0.00"); // เพิ่มคอมม่าให้กับตัวเลข

                        //ผลรวมราคาส่วนลด 
                        decimal SUMvat = total + vat;
                        ShowSumPrice.Text = SUMvat.ToString("#,0.00");

                        decimal discount = SUMvat * 0.05m; // คำนวณส่วนลด 5%
                        ShowDiscount.Text = discount.ToString("#,0.00"); // เพิ่มคอมม่าให้กับตัวเลข

                        // คำนวณผลรวมทั้งหมดหลังจากลดราคา
                        ShowSum.Text = (SUMvat - discount).ToString("#,0.00"); // เพิ่มคอมม่าให้กับตัวเลข
                    }
                }
                else
                {
                    // ล้างค่าของส่วนลดถ้าไม่พบเบอร์โทรศัพท์หรือเบอร์โทรศัพท์คือ "Unknown"
                    ShowDiscount.Text = "0.00";
                    // คำนวณ VAT
                    if (decimal.TryParse(ShowPrice.Text, out decimal total))
                    {
                        decimal vat = total * 0.07m; // คำนวณ VAT 7%
                        ShowVat.Text = vat.ToString("#,0.00"); // เพิ่มคอมม่าให้กับตัวเลข
                        ShowSum.Text = (total + vat).ToString("#,0.00"); // เพิ่มคอมม่าให้กับตัวเลข
                    }
                }
            }
            else
            {
                // ล้างค่าของส่วนลดถ้าเบอร์โทรศัพท์ว่างเปล่า
                ShowDiscount.Text = "0.00";
            }
        }

        private void dataUserSelling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

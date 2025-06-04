using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Day2
{
    public partial class Page5_Selling : Form
    {
        // ประกาศ availableSizes เป็นตัวแปรระดับคลาส เพื่อใช้ในการทำสีในช่อง combobox ถ้าเสื้อนั้นๆไม่มีไชส์ให้ขึ้นสีเทา
        // คำสั่งอยู่ด้านล่างสุด
        private DataTable availableSizes;

        public Page5_Selling()
        {
            InitializeComponent();

            // กำหนด DrawMode ของ SizeText เป็น OwnerDrawFixed เพื่อให้ programer สามารถกำหนดสีต่างๆตามความต้องการของผมเอง
            SizeText.DrawMode = DrawMode.OwnerDrawFixed;
            SizeText.DrawItem += new DrawItemEventHandler(SizeText_DrawItem);

            // เรียก LoadAvailableSizes เมื่อโหลดฟอร์ม
            this.Load += new EventHandler(Page5_Selling_Load);

        }

        private void Page5_Selling_Load(object sender, EventArgs e)
        {
            ClearDTB();
            CheckStock();
            ShownNameInStock();
            LoadAvailableSizes();

            // ตั้งค่าให้ Textbox เป็นคำที่ต้องการ
            CountStockText.Text = "0";
            ShowPrice.Text = "0.00";
            NameText.Text = " - Select Name Shirt - ";
            SizeText.Text = " - Select Size Shirt - ";

        }

        // เชื่อมต่อฐานข้อมูล MySQL v.1
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1; port=3306;Initial Catalog = 'program_bungboom'; username=root; password=");

        // เชื่อมต่อฐานข้อมูล MySQL v.2
        private MySqlConnection DBConnection()
        {
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=program_bungboom;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connection);
            return conn;
        }
        public void ShownNameInStock() //คำสั่งโชว์ชื่อเสื้อที่มีใน Stock
        {
            connection.Open();

            string Mysql_Select = "SELECT DISTINCT name FROM stock"; // เพิ่ม DISTINCT เพื่อให้แสดงเฉพาะชื่อที่ไม่ซ้ำ
            MySqlCommand command = new MySqlCommand(Mysql_Select, connection);
            command.CommandType = CommandType.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);

            NameText.DisplayMember = "name";
            NameText.ValueMember = "name";
            NameText.DataSource = data;

            connection.Close();
        }

        private void CheckStock() //คำสั่งเช็คข้อมูลเสื้อที่มีใน Stock และแสดงข้อมูลใน TextBOX
        {
            string searchText = NameText.Text; // รับข้อมูลที่ป้อน
            string SIZEText = SizeText.Text; // รับข้อมูลที่ป้อน

            // สร้าง DataTable เพื่อทำการค้นหา
            DataTable dataTable = new DataTable();

            using (MySqlConnection conn = DBConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM stock WHERE name = @name AND size = @size", conn);
                cmd.Parameters.AddWithValue("@name", searchText);
                cmd.Parameters.AddWithValue("@size", SIZEText);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }


            DataRow[] foundRows;

            if (!string.IsNullOrEmpty(searchText) && !string.IsNullOrEmpty(SIZEText))
            {
                // ค้นหาด้วย Name และ Size
                foundRows = dataTable.Select("name = '" + searchText + "' AND size = '" + SIZEText + "'");
            }
            else
            {
                // ถ้าไม่ได้ป้อนข้อมูลทั้งคู่ให้หยุดการทำงาน
                return;
            }

            // ตรวจสอบว่าพบข้อมูลหรือไม่ หากพบข้อมูล NAME & SIZE ให้แสดงข้อมูล ID & COUNT & PRICE
            if (foundRows.Length > 0)
            {
                // นำข้อมูลในแถวนั้นไปแสดงใน textbox อื่น ๆ
                IDText.Text = foundRows[0]["id"].ToString();
                CountStockText.Text = foundRows[0]["count"].ToString();
                PriceText.Text = foundRows[0]["price"].ToString();

                // ดึงข้อมูลรูปภาพจาก foundRows
                Byte[] img = (Byte[])foundRows[0]["photo"];

                // แปลง Byte array เป็นรูปภาพ
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }
            else
            {
                // หากไม่พบข้อมูล ให้ล้าง textbox ที่ต้องการให้เป็นค่าว่าง
                IDText.Text = "";
                CountStockText.Text = "";
                PriceText.Text = "";

                // ล้างรูปภาพใน PictureBox
                // ถ้าไม่มีรูปภาพในฐานข้อมูลให้กำหนดรูปภาพเริ่มต้นที่ตั้งไว้
                pictureBox1.Image = Properties.Resources.VDOSPORTGIFFFFF;
            }
        }

        private void ClearDTB() //คำสั่ง clear ข้อมูลในฐานข้อมูล
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("DELETE FROM cart", connection);
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

            finally
            {
                connection.Close();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        } 

        private void calculateTotal()
        {
            decimal totalSum = 0.00m;

            // ตรวจสอบว่ามีแถวใน DataGridView ที่ชื่อ dataMenuSelling หรือไม่
            if (dataMenuSelling.Rows.Count > 0)
            {
                // วนลูปผ่านแต่ละแถวใน dataMenuSelling
                foreach (DataGridViewRow row in dataMenuSelling.Rows)
                {
                    // แปลงค่าที่อยู่ในเซลล์คอลัมน์ที่ 5 เป็นชนิด decimal
                    if (decimal.TryParse(row.Cells[5].Value?.ToString(), out decimal value))
                    {
                        totalSum += value;
                    }
                }
            }

            // อัปเดตค่าใน ShowPrice ด้วยค่าผลรวมที่คำนวณได้ และจัดรูปแบบตัวเลขให้มีคอมม่าและทศนิยมสองตำแหน่ง
            ShowPrice.Text = totalSum.ToString("#,0.00");
        }

        private void IDText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceText_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }           
        
        private void CountUpDown_ValueChanged(object sender, EventArgs e)
        {
            
        }
        private void button3_Click(object sender, EventArgs e) //หน้า Home
        {
            Page1_Main pg = new Page1_Main();
            pg.Show();
            this.Hide();
        }

        //ปุ่มเลือกจำนวนสินค้า และตรวจสอบจำนวนใน stock
        private void SelectBot_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่าค่า CountUpDown ไม่เป็น 0
            if (CountUpDown.Value == 0)
            {
                MessageBox.Show("กรุณากรอกจำนวนสินค้าที่ต้องการ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // แปลงค่าจำนวนสินค้าที่เลือกให้เป็นชนิดข้อมูล Int64
                Int64 selectedCount = Int64.Parse(CountUpDown.Text);

                // กำหนดค่าเริ่มต้นให้จำนวนสินค้าที่มีใน stock เป็น 0
                Int64 CountInStock = 0;

                // เริ่มต้นการเชื่อมต่อกับฐานข้อมูล
                connection.Open();
                try
                {
                    // สร้างคำสั่ง SQL เพื่อดึงข้อมูลสินค้าจากฐานข้อมูล
                    MySqlCommand command = new MySqlCommand("SELECT count FROM stock WHERE id = @id AND name = @name AND size = @size", connection);
                    command.Parameters.AddWithValue("@id", IDText.Text);
                    command.Parameters.AddWithValue("@name", NameText.Text);
                    command.Parameters.AddWithValue("@size", SizeText.Text);

                    // ดึงข้อมูลจากฐานข้อมูล
                    var result = command.ExecuteScalar();

                    // ตรวจสอบว่ามีข้อมูลที่ตรงกับเงื่อนไขหรือไม่ ไม่ได้กรอก และ ไม่มีข้อมูลในฐาน
                    if (result == null || result == DBNull.Value)
                    {
                        // แสดงข้อความแจ้งเตือนเมื่อข้อมูลสินค้าไม่ถูกต้อง
                        MessageBox.Show("ข้อมูลสินค้าไม่ถูกต้อง โปรดตรวจสอบให้ถูกต้อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // ตรวจสอบว่ามีข้อมูลที่ตรงกับเงื่อนไขหรือไม่ มีข้อมูลและข้อมูลตรงกับในฐานข้อมูล
                    if (result != null && result != DBNull.Value)
                    {
                        // แปลงค่าที่ดึงมาเป็น Int64
                        CountInStock = Convert.ToInt64(result);
                    }
                }
                catch (MySqlException ex)
                {
                    // แสดงข้อความแจ้งเตือนเมื่อเกิดข้อผิดพลาดในการดึงข้อมูล
                    MessageBox.Show("เกิดข้อผิดพลาดในการดึงข้อมูล: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    // ปิดการเชื่อมต่อกับฐานข้อมูล
                    connection.Close();
                }

                // ตรวจสอบจำนวนสินค้าที่เลือกว่ามากกว่าจำนวนที่มีในสต็อกหรือไม่
                if (selectedCount > CountInStock)
                {
                    // แสดงข้อความแจ้งเตือนเมื่อจำนวนสินค้าที่เลือกมากกว่าจำนวนที่มีในสต็อก
                    MessageBox.Show("จำนวนสินค้าที่เลือกมากกว่าจำนวนที่มีใน stock", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Int64 totalSelectedAndCountInCart = 0;

                // วนลูปเพื่อหาผลรวมของ count ใน datagridview collumn 2 และ selectedCount
                foreach (DataGridViewRow row in dataMenuSelling.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == IDText.Text)
                    {
                        Int64 countInCart = Int64.Parse(row.Cells[2].Value.ToString());

                        //ตรวจสอบจำนวนในตระกร้า และจำนวนใน countupdown
                        totalSelectedAndCountInCart += countInCart + selectedCount;
                    }
                }

                // เช็คว่าจำนวนสินค้าทั้งหมดที่เลือกและมีใน stock มากกว่าจำนวนที่มีใน stock หรือไม่
                if (totalSelectedAndCountInCart > CountInStock)
                {
                    MessageBox.Show("จำนวนสินค้าใน stock ไม่เพียงพอ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                // เช็คว่า ID ที่เลือกตรงกับข้อมูลใน Column 0 ของ dataMenuSelling หรือไม่
                foreach (DataGridViewRow row in dataMenuSelling.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == IDText.Text)
                    {
                        // นำค่า count ใน Column 2 มาอัพเดตในคำสั่งถัดไป
                        Int64 countInCart = Int64.Parse(row.Cells[2].Value.ToString());
                        countInCart += selectedCount;
                        row.Cells[2].Value = countInCart.ToString();

                        // คำนวณราคารวมใหม่ และอัพเดทใน เซล 5 
                        Int64 price = Int64.Parse(row.Cells[4].Value.ToString());
                        Int64 sum = price * countInCart;
                        row.Cells[5].Value = sum.ToString();

                        // อัพเดตข้อมูลในฐานข้อมูล
                        try
                        {
                            connection.Open();
                            MySqlCommand updateCommand = new MySqlCommand("UPDATE cart SET count = @count, sum = @sum WHERE id = @id", connection);
                            updateCommand.Parameters.AddWithValue("@count", countInCart);
                            updateCommand.Parameters.AddWithValue("@sum", sum);
                            updateCommand.Parameters.AddWithValue("@id", IDText.Text);
                            updateCommand.ExecuteNonQuery();
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("เกิดข้อผิดพลาดในการอัพเดตข้อมูล: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connection.Close();
                        }

                        // ออกจากลูปหลังจากพบ ID ที่เหมือนกัน
                        break;
                    }
                }

                // ถ้าไม่พบ ID ที่เหมือนกันใน dataMenuSelling ให้ทำการเพิ่มรายการสินค้าใหม่
                if (!CheckIdInMenuSelling())
                {
                    // เพิ่มรายการสินค้าใหม่ ในแถวใหม่
                    AddNewProductToData(selectedCount);
                }

                // คำนวณราคารวม
                calculateTotal();
            }
        }

        // เช็คว่า ID ที่เลือกตรงกับข้อมูลใน Column 0 ของ dataMenuSelling หรือไม่
        private bool CheckIdInMenuSelling()
        {
            foreach (DataGridViewRow row in dataMenuSelling.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == IDText.Text)
                {
                    return true;
                }
            }
            return false;
        }

        // เพิ่มรายการสินค้าใหม่ใน dataMenuSelling
        private void AddNewProductToData(Int64 selectedCount)
        {
            // เพิ่มรายการสินค้าใหม่
            int n = dataMenuSelling.Rows.Add();
            dataMenuSelling.Rows[n].Cells[0].Value = IDText.Text;
            dataMenuSelling.Rows[n].Cells[1].Value = NameText.Text;
            dataMenuSelling.Rows[n].Cells[3].Value = SizeText.Text;
            dataMenuSelling.Rows[n].Cells[4].Value = PriceText.Text;
            dataMenuSelling.Rows[n].Cells[2].Value = selectedCount.ToString();

            // คำนวณราคารวมของรายการ
            Int64 price = Int64.Parse(PriceText.Text);
            Int64 sum = price * selectedCount;
            dataMenuSelling.Rows[n].Cells[5].Value = sum;

            // เพิ่มข้อมูลลงในฐานข้อมูล
            try
            {
                connection.Open();
                MySqlCommand insertCommand = new MySqlCommand("INSERT INTO cart (id, name, size, count, price, sum) VALUES (@id, @name, @size, @count, @price, @sum)", connection);
                insertCommand.Parameters.AddWithValue("@id", IDText.Text);
                insertCommand.Parameters.AddWithValue("@name", NameText.Text);
                insertCommand.Parameters.AddWithValue("@size", SizeText.Text);
                insertCommand.Parameters.AddWithValue("@count", selectedCount);
                insertCommand.Parameters.AddWithValue("@price", PriceText.Text);
                insertCommand.Parameters.AddWithValue("@sum", sum);
                insertCommand.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการเพิ่มข้อมูล: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        //คำสั่งลบสินค้าออกจากตระกร้าโดยการคลิกที่แถวใน datagridview
        private void DeletetBot_Click(object sender, EventArgs e)
        {
            if (dataMenuSelling.SelectedRows.Count > 0)
            {
                // ตรวจสอบว่าจำนวนใน CountUpDown มากกว่าจำนวนในคอลัมน์ที่ 2 ของ datagridview ในแถวที่เลือกหรือไม่
                int selectedCount = int.Parse(CountUpDown.Text);
                int countInGrid = int.Parse(dataMenuSelling.SelectedRows[0].Cells[2].Value.ToString());

                //ตรวจสอบถ้าเลือกมากกว่าให้ทำการแจ้งเตือนข้อความ
                if (selectedCount > countInGrid)
                {
                    MessageBox.Show("ท่านได้เลือกจำนวนสินค้ามากกว่าสินค้าที่มีในตระกร้า", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // ไม่ทำการลบข้อมูล
                }

                try
                {
                    // ใช้คำสั่ง update เพื่อลบข้อมูล count ในตารางตามจำนวนที่เลือก จาก combobox
                    connection.Open();
                    MySqlCommand updateCommand = new MySqlCommand("UPDATE cart SET count = count - @count WHERE id = @id", connection);
                    updateCommand.Parameters.AddWithValue("@count", selectedCount);
                    updateCommand.Parameters.AddWithValue("@id", IDText.Text);
                    updateCommand.ExecuteNonQuery();

                    // ลบข้อมูลที่มี Column 2 ถ้า count เท่ากับ 0
                    MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM cart WHERE id = @id AND count <= 0", connection);
                    deleteCommand.Parameters.AddWithValue("@id", IDText.Text);
                    deleteCommand.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                // อัพเดต DataGridView ใหม่หลังจากลบข้อมูล
                UpdateDataGridView();
            }
        }



        // เมธอดสำหรับอัพเดต DataGridView และคำนวณราคารวม
        private void UpdateDataGridView()
        {
            // ล้างข้อมูลใน DataGridView
            dataMenuSelling.Rows.Clear();

            // เรียกเมธอดสำหรับอัพเดตข้อมูลใน DataGridView
            LoadDataToDataGridView();

            // คำนวณราคารวม
            calculateTotal();
        }

        // เมธอดสำหรับโหลดข้อมูลเข้า DataGridView
        private void LoadDataToDataGridView()
        {
            try
            {
                // ดึงข้อมูลจากฐานข้อมูล
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM cart", connection);
                MySqlDataReader reader = command.ExecuteReader();

                // เพิ่มข้อมูลใน DataGridView
                while (reader.Read())
                {
                    // สร้างแถวใหม่
                    int n = dataMenuSelling.Rows.Add();

                    // กำหนดค่าในแต่ละเซลล์ของแถวใหม่
                    dataMenuSelling.Rows[n].Cells[0].Value = reader["id"].ToString();
                    dataMenuSelling.Rows[n].Cells[1].Value = reader["name"].ToString();
                    dataMenuSelling.Rows[n].Cells[3].Value = reader["size"].ToString();
                    dataMenuSelling.Rows[n].Cells[4].Value = reader["price"].ToString();
                    dataMenuSelling.Rows[n].Cells[2].Value = reader["count"].ToString();

                    // คำนวณราคารวมและกำหนดค่าในเซลล์ที่ 5
                    int count = int.Parse(reader["count"].ToString());
                    decimal price = decimal.Parse(reader["price"].ToString());
                    decimal total = count * price;

                    //หลังจากคำนวนราคาให้ทำการบันทึกราคารวมที่ เซลล์ 5
                    dataMenuSelling.Rows[n].Cells[5].Value = total.ToString();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void PayBot_Click(object sender, EventArgs e) //ปุ่มหน้า คิดตังค์
        {
            Page7_Confirm pg = new Page7_Confirm();
            pg.Show();
            this.Hide();
        }


        private void ShowPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataMenuSelling_Click(object sender, EventArgs e) // คำสั่งแสดงข้อมูลที่ textbox เมื่อคลิกที่เซลล์
        {
            if (dataMenuSelling.CurrentRow != null)
            {
                try
                {
                    // ดึงข้อมูลทั้งหมดจากแถวปัจจุบันของ datagridview
                    object[] cellValues = new object[dataMenuSelling.CurrentRow.Cells.Count];
                    for (int i = 0; i < dataMenuSelling.CurrentRow.Cells.Count; i++)
                    {
                        cellValues[i] = dataMenuSelling.CurrentRow.Cells[i].Value;
                    }

                    // แสดงข้อมูลใน TextBox
                    IDText.Text = cellValues[0]?.ToString();
                    NameText.Text = cellValues[1]?.ToString();
                    //CountStockText.Text = cellValues[2]?.ToString();
                    SizeText.Text = cellValues[3]?.ToString();
                    PriceText.Text = cellValues[4]?.ToString();

                    using (MySqlConnection conn = DBConnection())
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("SELECT count,photo FROM stock WHERE id = @id", conn);
                        cmd.Parameters.AddWithValue("@id", IDText.Text);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // แสดงค่า count ใน TextBox
                                CountStockText.Text = reader["count"].ToString();

                                // ดึงข้อมูลรูปภาพ (photo) จากฐานข้อมูล
                                byte[] imgData = (byte[])reader["photo"]; // ดึงข้อมูลรูปภาพในรูปแบบ byte array
                                if (imgData != null)
                                {
                                    // แปลงข้อมูลรูปภาพให้เป็น Image
                                    using (MemoryStream ms = new MemoryStream(imgData))
                                    {
                                        pictureBox1.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    // ถ้าไม่มีรูปภาพในฐานข้อมูลให้กำหนดรูปภาพเริ่มต้นที่ตั้งไว้
                                    pictureBox1.Image = Properties.Resources.VDOSPORTGIFFFFF;
                                }
                            }
                            else
                            {
                                // ถ้าไม่พบข้อมูลในฐานข้อมูล ให้แสดงข้อความว่าไม่พบข้อมูล
                                MessageBox.Show("ไม่พบข้อมูลในฐานข้อมูล");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void SizeText_SelectedIndexChanged(object sender, EventArgs e)
        {
            // เรียก LoadAvailableSizes ทุกครั้งที่มีการเปลี่ยนแปลงใน SizeText
            LoadAvailableSizes();

            // รีเฟรช ComboBox เพื่อให้ DrawItem ทำงาน
            SizeText.Invalidate();

            CheckStock();
        }

        // การวาดรายการ ในสีที่แตกต่างกัน ถ้าไม่มีสินค้า
        private void SizeText_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // ดึงข้อความจากรายการ ComboBox
            string text = SizeText.Items[e.Index].ToString();

            // ตรวจสอบว่า size นั้นมีอยู่ใน availableSizes หรือไม่
            bool sizeExists = availableSizes != null && availableSizes.Select($"size = '{text}'").Length > 0;

            // สร้างสีจากค่า RGBA ที่กำหนด
            Color customBlueColor = Color.FromArgb(255, 0, 120, 215);

            // ตั้งค่าสีตัวอักษรและพื้นหลัง
            Color textColor = sizeExists ? Color.Black : Color.Gray;
            Color backgroundColor = e.State.HasFlag(DrawItemState.Selected) ? customBlueColor : e.BackColor;

            // ตั้งค่าสีตัวอักษรเป็นสีขาวเมื่อเมาส์ผ่าน
            if (e.State.HasFlag(DrawItemState.Selected))
            {
                textColor = Color.White;
            }

            // วาดพื้นหลัง
            e.Graphics.FillRectangle(new SolidBrush(backgroundColor), e.Bounds);

            // วาดข้อความ
            e.Graphics.DrawString(text, e.Font, new SolidBrush(textColor), e.Bounds);

            // ถ้าต้องการเส้นขอบ
            e.DrawFocusRectangle();
        }



        private void LoadAvailableSizes()
        {
            string searchText = NameText.Text; // รับข้อมูลที่ป้อน

            // สร้าง DataTable เพื่อทำการค้นหา
            availableSizes = new DataTable();

            using (MySqlConnection conn = DBConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT size FROM stock WHERE name = @name", conn);
                cmd.Parameters.AddWithValue("@name", searchText);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(availableSizes);
            }
        }
        private void NameText_SelectedIndexChanged(object sender, EventArgs e)
        {
            // เรียก LoadAvailableSizes ทุกครั้งที่มีการเปลี่ยนแปลงใน SizeText
            LoadAvailableSizes();

            // รีเฟรช ComboBox เพื่อให้ DrawItem ทำงาน
            SizeText.Invalidate();
            CheckStock();
        }

        private void CountStockText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml.Linq;
using System.Runtime.Remoting.Contexts;


namespace Day2
{
    public partial class Page4_Admin : Form
    {
        
        public Page4_Admin()
        {
            InitializeComponent();
        }

        //การเชื่อมต่อกับฐานข้อมูล MySQL
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1; port=3306;Initial Catalog = 'program_bungboom'; username=root; password=");
        private void Form1_Load(object sender, EventArgs e)
        {
            showShirt(); //โชว์ข้อมูลเสื้อทั้งหมด
        }

        private void showShirt() //ฟังก์ชั่นโชว์ข้อมูลเสื้อทั้งหมด
        {
            FillDataGridView("");
        }
        public void FillDataGridView( string valueToSearch) //คำสั่งการค้นหา คำสั่งโชว์ข้อมูลเสื้อ คำสั่งกำหนดขนาดตารางข้อมูล และแสดงรูปภาพในตาราง
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM stock WHERE CONCAT(id, name, size, count, price, photo) LIKE '%" + valueToSearch +"%'", connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dataEquipment.RowTemplate.Height = 30;

            dataEquipment.AllowUserToDeleteRows = false;

            dataEquipment.DataSource = table;


            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataEquipment.Columns[5];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataEquipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void button2_Click_1(object sender, EventArgs e) //คำสั่งเปิดโฟล์เดอร์เพื่อเลือกรูปภาพในการ เพิ่ม ลบ แก้ไขข้อมูล
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK) //โชว์รูปภาพที่ pictureBox1
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        
        //นำข้อมูลเข้าใน DATABASE และเพิ่มจำนวนสินค้าด้วยการ select count where id
        private void submitBTN_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1; port=3306;Initial Catalog = 'program_bungboom'; username=root; password="))
            {
                connection.Open(); // เปิดการเชื่อมต่อกับฐานข้อมูล

                //แปลงภาพจาก PictureBox ไปเป็นอาร์เรย์ของไบต์ (byte[]) เพื่อบันทึกลงฐานข้อมูล
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();

                // เช็คว่า ID ซ้ำหรือไม่
                MySqlCommand checkCommand = new MySqlCommand("SELECT COUNT(*) FROM stock WHERE id = @id", connection);
                checkCommand.Parameters.Add("@id", MySqlDbType.VarChar).Value = IDText.Text;

                int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar()); // ใช้ Convert.ToInt32 เพื่อแปลงค่าที่ได้จาก ExecuteScalar เป็น integer

                if (existingCount > 0) //ตรวจสอบว่าถ้าidว้ำให้ทำการถามคำถาม
                {
                    DialogResult result = MessageBox.Show("ID ซ้ำ คุณต้องการเพิ่มจำนวนสินค้าใช่หรือไม่?", "คำถาม", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes) // ถ้า ID ซ้ำ และตอบ Yes ให้ทำการเพิ่มจำนวน count
                    {
                        MySqlCommand updateCommand = new MySqlCommand("UPDATE stock SET count = count + @count WHERE id = @id", connection);
                        updateCommand.Parameters.Add("@id", MySqlDbType.VarChar).Value = IDText.Text;
                        updateCommand.Parameters.Add("@count", MySqlDbType.Int32).Value = Convert.ToInt32(CountText.Text);
                        updateCommand.ExecuteNonQuery(); // เรียกใช้ ExecuteNonQuery เนื่องจากไม่ได้ต้องการผลลัพธ์กลับมา
                        showShirt();
                    }
                    else if (result == DialogResult.No) // ถ้า ID ซ้ำ แต่ตอบ No ให้ทำการแสดงข้อความ
                    {
                        MessageBox.Show("ท่านได้ทำการยกเลิกการเพิ่มจำนวนสินค้าเรียบร้อยแล้ว");
                    }
                }
                else
                {
                    // ถ้าไม่มี ID ซ้ำ ให้ทำการเพิ่มรายการใหม่
                    MySqlCommand insertCommand = new MySqlCommand("INSERT INTO stock(id, name, size, count, price, photo) VALUES (@id, @name, @size, @count, @price, @photo)", connection);
                    insertCommand.Parameters.Add("@id", MySqlDbType.VarChar).Value = IDText.Text;
                    insertCommand.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameText.Text;
                    insertCommand.Parameters.Add("@size", MySqlDbType.VarChar).Value = SizeText.Text;
                    insertCommand.Parameters.Add("@count", MySqlDbType.Int32).Value = Convert.ToInt32(CountText.Text);
                    insertCommand.Parameters.Add("@price", MySqlDbType.VarChar).Value = PriceText.Text;
                    insertCommand.Parameters.Add("@photo", MySqlDbType.Blob).Value = img;
                    insertCommand.ExecuteNonQuery(); // เรียกใช้ ExecuteNonQuery เนื่องจากไม่ได้ต้องการผลลัพธ์กลับมา

                    showShirt();
                    MessageBox.Show("เพิ่มรายการเสร็จเรียบร้อย");
                }

                connection.Close(); // ปิดการเชื่อมต่อกับฐานข้อมูล
            }
        }

        private void button2_Click(object sender, EventArgs e) //คำสั่งลบข้อมูลจากฐานข้อมูล
        {
            // นำรูปภาพไปเก็บเป็น byte array
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            // สร้างคำสั่ง SQL เพื่อเลือกจำนวน count จากฐานข้อมูล stock โดยใช้ ID
            MySqlCommand selectCommand = new MySqlCommand("SELECT count FROM stock WHERE id = @id", connection);
            selectCommand.Parameters.AddWithValue("@id", IDText.Text);

            // เปิดการเชื่อมต่อกับฐานข้อมูลเพื่อทำการสอบถาม
            connection.Open();

            // อ่านค่าจำนวน count จากฐานข้อมูล
            Int64 countInStock = 0;
            try
            {
                var queryResult = selectCommand.ExecuteScalar();
                if (queryResult != null && queryResult != DBNull.Value)
                {
                    countInStock = Convert.ToInt64(queryResult);
                }
                else
                {
                    // ถ้าไม่พบ ID ในฐานข้อมูล แสดง MessageBox ว่า "ไม่พบ ID ที่ต้องการลบ"
                    MessageBox.Show("ไม่พบ ID ที่ต้องการลบ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการอ่านข้อมูลจำนวนสินค้า: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                return;
            }

            // ปิดการเชื่อมต่อกับฐานข้อมูล
            connection.Close();

            // แปลงจำนวนสินค้าที่เลือกจาก CountText เป็น Int64
            Int64 selectedCount = Int64.Parse(CountText.Text);

            // ตรวจสอบว่าจำนวนสินค้าที่เลือกมากกว่าจำนวนใน stock หรือไม่
            if (selectedCount > countInStock)
            {
                // แสดง MessageBox ว่าจำนวนสินค้าที่เลือกมากกว่าจำนวนที่มีใน stock และไม่ให้ทำการลบสินค้า เนื่องจากสินค้าจะมีการติดลบ
                MessageBox.Show("จำนวนสินค้าที่เลือกมากกว่าจำนวนที่มีอยู่ใน stock", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ตรวจสอบว่าจำนวนสินค้าที่เลือกน้อยกว่าจำนวนใน stock
            if (selectedCount < countInStock)
            {
                // สร้างคำสั่ง SQL เพื่ออัปเดตจำนวนสินค้าใน stock ด้วยการลบจำนวนที่เลือกออกจากจำนวนที่มีในฐานข้อมูล
                MySqlCommand updateCommand = new MySqlCommand("UPDATE stock SET count = @count WHERE id = @id", connection);
                updateCommand.Parameters.AddWithValue("@count", countInStock - selectedCount);
                updateCommand.Parameters.AddWithValue("@id", IDText.Text);

                try
                {
                    // เปิดการเชื่อมต่อกับฐานข้อมูล
                    connection.Open();
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("ลบรายการเสร็จเรียบร้อย");
                    showShirt();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการอัปเดตข้อมูลสินค้าใน stock: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    // ปิดการเชื่อมต่อกับฐานข้อมูล
                    connection.Close();
                }
            }
            // เช็คว่าจำนวนสินค้าที่เลือกเท่ากับจำนวนใน stock หรือไม่
            else if (selectedCount == countInStock)
            {
                // แสดง MessageBox ถามผู้ใช้ว่าต้องการลบรายการหรือไม่
                DialogResult result = MessageBox.Show("จำนวนสินค้าที่คุณต้องการลบเท่ากับจำนวนสินค้าที่มีใน stock ต้องการลบรายการนี้หรือไม่?", "คำถาม", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // ถ้าผู้ใช้เลือก Yes ให้ทำการลบรายการ
                if (result == DialogResult.Yes)
                {
                    // สร้างคำสั่ง SQL เพื่อลบรายการที่มี ID ตรงกับที่เลือกออกจาก stock
                    MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM stock WHERE id = @id", connection);
                    deleteCommand.Parameters.AddWithValue("@id", IDText.Text);

                    // นำไปยังเมธอด ExecMyQuery เพื่อทำการลบ
                    ExecMyQuery(deleteCommand, "ลบรายการเสร็จเรียบร้อย");
                    showShirt();
                }
                // ถ้าผู้ใช้เลือก No จะไม่ทำการลบรายการ
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("ท่านได้ทำการยกเลิกการลบสินค้าเรียบร้อยแล้ว");
                }
            }
        }

        //แก้ไขข้อมูลเข้าใน DATABASE
        private void button3_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("UPDATE stock SET name=@name, count=@count, price=@price, photo=@photo WHERE id = @id AND size = @size", connection);

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = IDText.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameText.Text;
            command.Parameters.Add("@size", MySqlDbType.VarChar).Value = SizeText.Text;
            command.Parameters.Add("@count", MySqlDbType.VarChar).Value = CountText.Text;
            command.Parameters.Add("@price", MySqlDbType.VarChar).Value = PriceText.Text;
            command.Parameters.Add("@photo", MySqlDbType.Blob).Value = img;

            //นำไปที่ ExecMyQuery เพื่อตรวจสอบความถูกต้อง
            ExecMyQuery(command, "อัพเดทรายการเสร็จเรียบร้อย");
        }

        public void ExecMyQuery(MySqlCommand mcomd, String myMsg)
        {
            connection.Open();

            if (mcomd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show(myMsg);
            }
            else
            {
                MessageBox.Show("ไม่สามารถดำเนินการได้เนื่องจากท่านแก้ไข ID กรุณาไม่แก้ไข ID \n'คำแนะนำ' \nหากท่านต้องการแก้ไข ID หรือ SIZE \nกรุณาลบรายการนี้และทำการเพิ่มข้อมูลใหม่", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            connection.Close();

            FillDataGridView("");
        }

        private void dataEquipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataEquipment_Click(object sender, EventArgs e) //datagrid click สำหรับคลิก และ โชว์ข้อมูลไปที่ textbox
        {
            try
            { 
            Byte[] img = (Byte[])dataEquipment.CurrentRow.Cells[5].Value;

            MemoryStream ms = new MemoryStream(img);

            pictureBox1.Image = Image.FromStream(ms);

            IDText.Text = dataEquipment.CurrentRow.Cells[0].Value.ToString();
            NameText.Text = dataEquipment.CurrentRow.Cells[1].Value.ToString();
            SizeText.Text = dataEquipment.CurrentRow.Cells[2].Value.ToString();
            CountText.Text = dataEquipment.CurrentRow.Cells[3].Value.ToString();
            PriceText.Text = dataEquipment.CurrentRow.Cells[4].Value.ToString();
            }
            catch { }
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e) //textbox การค้นหาข้อมูล
        {
            FillDataGridView(SearchBox.Text);
        }

        private void button3_Click_1(object sender, EventArgs e) //ปุ่ม Home
        {
            Page1_Main pg = new Page1_Main();
            pg.Show();
            this.Hide();
        }
        private void button2_Click_2(object sender, EventArgs e) //ปุ่ม Back
        {
            Page8_Adminselect pg = new Page8_Adminselect();
            pg.Show();
            this.Hide();
        }

        private void IDText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SizeText_TextChanged(object sender, EventArgs e)
        {

        }

        private void CountText_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

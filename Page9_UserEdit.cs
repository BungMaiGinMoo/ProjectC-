using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day2
{
    public partial class Page9_UserEdit : Form
    {
        public Page9_UserEdit()
        {
            InitializeComponent();
        }
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1; port=3306; username=root; password=; database = program_bungboom;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }

        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1; port=3306;Initial Catalog = 'program_bungboom'; username=root; password=");

        private void Page9_UserEdit_Load(object sender, EventArgs e)
        {
            showdataUser();
        }

        //โชว์ข้อมูล user ใน datagrid
        private void showdataUser()
        {
            FilldataUser("");
        }
        private void button2_Click(object sender, EventArgs e) //ปุ่ม back
        {
            Page8_Adminselect pg = new Page8_Adminselect();
            pg.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e) //ปุ่ม Home
        {
            Page1_Main pg = new Page1_Main();
            pg.Show();
            this.Hide();
        }

        // คำสั่งแสดงข้อมูล user และคำสั่งค้นหา ข้อมูลลูกค้า ผ่าน text searchbox
        public void FilldataUser(string valueToSearch)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM user WHERE CONCAT(name, lastname, phone) LIKE '%" + valueToSearch + "%'", connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dataUser.RowTemplate.Height = 30;

            dataUser.AllowUserToDeleteRows = false;

            dataUser.DataSource = table;


            // กำหนดความกว้างของแต่ละคอลัมน์
            dataUser.Columns[0].Width = 53;  // กำหนดความกว้างของคอลัมน์แรกเป็น 50
            dataUser.Columns[1].Width = 100; 
            dataUser.Columns[2].Width = 100;
            dataUser.Columns[3].Width = 100;
        }

        // คำสั่ง คลิกข้อมูลใน datagrid มาแสดงที่ textbox
        private void dataUser_Click(object sender, EventArgs e)
        {
            try
            {
                idText.Text = dataUser.CurrentRow.Cells[0].Value.ToString();
                NameText.Text = dataUser.CurrentRow.Cells[1].Value.ToString();
                LastNameText.Text = dataUser.CurrentRow.Cells[2].Value.ToString();
                PhoneText.Text = dataUser.CurrentRow.Cells[3].Value.ToString();
            }
            catch { }
        }

        // ปุ่มแก้ไขข้อมูล และคำสั่งตรวจสอบข้อมูลก่อนทำการแก้ไขข้อมูล คำสั่งตรวจสอบเดียวกันกับหน้า สมัครสมาชิก
        private void EditBot_Click(object sender, EventArgs e)
        {
            string name = NameText.Text;
            string lastname = LastNameText.Text;
            string phone = PhoneText.Text;

            // ตรวจสอบ NameText ไม่ให้เป็นค่าว่าง
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("กรุณากรอกชื่อของคุณ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ตรวจสอบว่า NameText เป็นตัวหนังสือภาษาอังกฤษหรือไม่
            Regex checkname = new Regex(@"^[a-zA-Z]+$");
            if (!checkname.IsMatch(name))
            {
                MessageBox.Show("กรุณากรอกชื่อเป็นภาษาอังกฤษเท่านั้น", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ตรวจสอบว่า NameText มีตัวอักษรพิมพ์ใหญ่ตัวแรกหรือไม่
            if (!char.IsUpper(name[0]))
            {
                MessageBox.Show("ชื่อควรเริ่มต้นด้วยตัวอักษรพิมพ์ใหญ่", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ตรวจสอบว่า NameText มีตัวอักษรพิมพ์เล็กทั้งหมดหรือไม่
            if (!name.Substring(1).All(char.IsLower))
            {
                MessageBox.Show("ชื่อควรประกอบด้วยตัวอักษรพิมพ์เล็กเท่านั้นหลังจากตัวอักษรแรก", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ตรวจสอบ LastNameText ไม่ให้เป็นค่าว่าง
            if (string.IsNullOrWhiteSpace(lastname))
            {
                MessageBox.Show("กรุณากรอกนามสกุลของคุณ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ตรวจสอบว่า LastNameText เป็นตัวหนังสือภาษาอังกฤษหรือไม่
            Regex checklastname = new Regex(@"^[a-zA-Z]+$");
            if (!checklastname.IsMatch(lastname))
            {
                MessageBox.Show("กรุณากรอกนามสกุลเป็นภาษาอังกฤษเท่านั้น", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ตรวจสอบว่า LastNameText มีตัวหนังสือพิมพ์ใหญ่ตัวแรกหรือไม่
            if (!char.IsUpper(lastname[0]))
            {
                MessageBox.Show("นามสกุลควรเริ่มต้นด้วยตัวหนังสือพิมพ์ใหญ่", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ตรวจสอบว่า LastNameText มีตัวหนังสือพิมพ์เล็กทั้งหมดหรือไม่
            if (!lastname.Substring(1).All(char.IsLower))
            {
                MessageBox.Show("นามสกุลควรประกอบด้วยตัวหนังสือพิมพ์เล็กเท่านั้นหลังจากตัวอักษรแรก", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ตรวจสอบ PhoneText ให้เป็นตัวเลขไม่เกิน 10 ตัว
            if (phone.Length != 10)
            {
                MessageBox.Show("กรุณากรอกเบอร์โทรศัพท์ที่ถูกต้อง (จำนวน 10 ตัว)", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ตรวจสอบ PhoneText ให้เป็นตัวเลขทุกตัว
            if (!phone.All(char.IsDigit))
            {
                MessageBox.Show("กรุณากรอกเบอร์โทรศัพท์ที่ถูกต้อง (ตรวจสอบเบอร์โทรว่ามีตัวหนังสือหรือไม่)", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // ตรวจสอบว่ามีการแก้ไขข้อมูลและข้อมูลซ้ำกับข้อมูลเดิมหรือไม่
            if (IsDuplicateWithExistingData(idText.Text, name, lastname, phone))
            {
                MessageBox.Show("ข้อมูลที่คุณกรอกซ้ำกับข้อมูลเดิมของคุณ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ตรวจสอบว่าเบอร์โทรศัพท์ถูกใช้สมัครสมาชิกไปแล้วหรือไม่
            if (IsPhoneNumberRegistered(phone))
            {
                DialogResult result = MessageBox.Show("มีการใช้เบอร์โทรศัพท์นี้สมัครสมาชิกไปแล้ว คุณต้องการอัพเดทข้อมูลนี้หรือไม่?", "ยืนยันการอัพเดท", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            
            MySqlCommand command = new MySqlCommand("UPDATE user SET name=@name, lastname=@lastname, phone=@phone WHERE id = @id", connection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = idText.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameText.Text;
            command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = LastNameText.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = PhoneText.Text;

            //นำไปที่ ExecMyQuery เพื่อตรวจสอบความถูกต้อง
            ExecMyQuery(command, "อัพเดทรายการเสร็จเรียบร้อย");
        }

        //คำสั่งตรวจสอบเบอร์โทรในฐานข้อมูล เพื่อใช้ในการตรวจสอบเบอร์โทรศัพท์
        private bool IsPhoneNumberRegistered(string phoneNumber)
        {
            MySqlConnection conn = databaseConnection();
            try
            {
                conn.Open();

                // สร้างคำสั่ง SQL สำหรับตรวจสอบเบอร์โทรศัพท์
                string query = "SELECT * FROM User WHERE phone = @phone";

                // สร้าง MySqlCommand
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // เพิ่มพารามิเตอร์เบอร์โทรศัพท์
                cmd.Parameters.AddWithValue("@phone", phoneNumber);

                // ดำเนินการคิวรีและตรวจสอบผลลัพธ์
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการตรวจสอบเบอร์โทรศัพท์: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        // ฟังก์ชันใช้เพื่อตรวจสอบข้อมูลซ้ำ ถ้าข้อมูลทุกช่องตรงกันกับฐานข้อมูลจะไม่ให้ทำการบันทึกข้อมูล
        private bool IsDuplicateWithExistingData(string id, string name, string lastname, string phone)
        {
            string query = "SELECT COUNT(*) FROM user WHERE id = @id AND name = @name AND lastname = @lastname AND phone = @phone";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@phone", phone);
            connection.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            return count > 0;
        }

        // คำสั่งการรันคำสั่ง SQL และแสดงข้อความตามผลลัพธ์
        public void ExecMyQuery(MySqlCommand mcomd, String myMsg)
        {
            connection.Open();

            if (mcomd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show(myMsg);
            }
            else
            {
                MessageBox.Show("ไม่สามารถดำเนินการ");
            }
            connection.Close();

            FilldataUser("");
        }

        private void SearchBox_TextChanged(object sender, EventArgs e) //กล่องข้อความ SearchBox
        {
            FilldataUser(SearchBox.Text);
        }
        private void dataEquipment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteBot_Click(object sender, EventArgs e) // ปุ่มลบรายชื่อลูกค้า
        {
            MySqlCommand selectCommand = new MySqlCommand("SELECT * FROM user WHERE id = @id", connection);
            selectCommand.Parameters.AddWithValue("@id", idText.Text);

            // ถ้าผู้ใช้เลือก Yes ให้ทำการลบรายการ
            try
            {
                // สร้างคำสั่ง SQL เพื่อลบรายการที่มี ID ตรงกับที่เลือกออกจาก stock
                MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM user WHERE id = @id", connection);
                deleteCommand.Parameters.AddWithValue("@id", idText.Text);

                // นำไปยังเมธอด ExecMyQuery เพื่อทำการลบ
                ExecMyQuery(deleteCommand, "ลบรายการเสร็จเรียบร้อย");
                //showdataUser();
            }
            catch
            {

            }
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

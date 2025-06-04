using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day2
{
    public partial class Page6_2_UserSignIn : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1; port=3306; username=root; password=; database = program_bungboom;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
        public Page6_2_UserSignIn()
        {
            InitializeComponent();
        }

        private void Page6_2_UserSignIn_Load(object sender, EventArgs e)
        {

        }

        // ตรวจสอบเบอร์โทร ถ้ามีเบอร์โทรอยู่แล้วจะไม่ให้ทำการสมัครสมาชิก
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

        // ปุ่มสมัครสมาชิก คำสั่งตรวจสอบเบอร์โทร ชื่อจริง สกุล
        private void CreatBot_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();

            try
            {
                conn.Open();

                string name = NameText.Text;
                string lastname = LastNameText.Text;
                string phone = PhoneText.Text;

                // ตรวจสอบ NameText ไม่ให้เป็นค่าว่าง
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("กรุณากรอกชื่อของคุณ");
                    return;
                }

                // ตรวจสอบว่า NameText เป็นตัวหนังสือภาษาอังกฤษหรือไม่
                Regex checkname = new Regex(@"^[a-zA-Z]+$");
                if (!checkname.IsMatch(name))
                {
                    MessageBox.Show("กรุณากรอกชื่อเป็นภาษาอังกฤษเท่านั้น");
                    return;
                }

                // ตรวจสอบว่า NameText มีตัวอักษรพิมพ์ใหญ่ตัวแรกหรือไม่
                if (!char.IsUpper(name[0]))
                {
                    MessageBox.Show("ชื่อควรเริ่มต้นด้วยตัวอักษรพิมพ์ใหญ่");
                    return;
                }

                // ตรวจสอบว่า NameText มีตัวอักษรพิมพ์เล็กทั้งหมดหรือไม่
                if (!name.Substring(1).All(char.IsLower))
                {
                    MessageBox.Show("ชื่อควรประกอบด้วยตัวอักษรพิมพ์เล็กเท่านั้นหลังจากตัวอักษรแรก");
                    return;
                }

                // ตรวจสอบ LastNameText ไม่ให้เป็นค่าว่าง
                if (string.IsNullOrWhiteSpace(lastname))
                {
                    MessageBox.Show("กรุณากรอกนามสกุลของคุณ");
                    return;
                }

                // ตรวจสอบว่า LastNameText เป็นตัวหนังสือภาษาอังกฤษหรือไม่
                Regex checklastname = new Regex(@"^[a-zA-Z]+$");
                if (!checklastname.IsMatch(lastname))
                {
                    MessageBox.Show("กรุณากรอกนามสกุลเป็นภาษาอังกฤษเท่านั้น");
                    return;
                }

                // ตรวจสอบว่า LastNameText มีตัวหนังสือพิมพ์ใหญ่ตัวแรกหรือไม่
                if (!char.IsUpper(lastname[0]))
                {
                    MessageBox.Show("นามสกุลควรเริ่มต้นด้วยตัวหนังสือพิมพ์ใหญ่");
                    return;
                }

                // ตรวจสอบว่า LastNameText มีตัวหนังสือพิมพ์เล็กทั้งหมดหรือไม่
                if (lastname.Substring(1).ToLower() != lastname.Substring(1))
                {
                    MessageBox.Show("นามสกุลควรประกอบด้วยตัวหนังสือพิมพ์เล็กเท่านั้นหลังจากตัวอักษรแรก");
                    return;
                }

                // ตรวจสอบ PhoneText ให้เป็นตัวเลขไม่เกิน 10 ตัว
                if (phone.Length != 10)
                {
                    MessageBox.Show("กรุณากรอกเบอร์โทรศัพท์ที่ถูกต้อง (จำนวน 10 ตัว)");
                    return;
                }
                // ตรวจสอบ PhoneText ให้เป็นตัวเลขทุกตัว
                if (!phone.All(char.IsDigit))
                {
                    MessageBox.Show("กรุณากรอกเบอร์โทรศัพท์ที่ถูกต้อง (ตรวจสอบเบอร์โทรว่ามีตัวหนังสือหรือไม่)");
                    return;
                }

                // ตรวจสอบว่าเบอร์โทรศัพท์ถูกใช้สมัครสมาชิกไปแล้วหรือไม่
                if (IsPhoneNumberRegistered(phone))
                {
                    MessageBox.Show("มีการใช้เบอร์โทรศัพท์นี้สมัครสมาชิกไปแล้ว");
                    return;
                }

                // ถ้าผ่านเงื่อนไขทั้งหมด ก็เพิ่มข้อมูลลงในฐานข้อมูล
                MySqlCommand cmd1 = new MySqlCommand("INSERT INTO user (name, lastname, phone) VALUES (@name, @lastname, @phone)", conn);
                cmd1.Parameters.AddWithValue("@name", name);
                cmd1.Parameters.AddWithValue("@lastname", lastname);
                cmd1.Parameters.AddWithValue("@phone", phone);
                cmd1.ExecuteNonQuery();

                MessageBox.Show("สมัครสมาชิกสำเร็จ");

                Page7_Confirm menu = new Page7_Confirm();
                menu.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Page7_Confirm pg = new Page7_Confirm();
            pg.Show();
            this.Hide();
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

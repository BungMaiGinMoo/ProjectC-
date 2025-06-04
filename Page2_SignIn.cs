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
    public partial class Page2_SignIn : Form
    {
        private MySqlConnection databaseConnection() //การเชื่อมต่อกับฐานข้อมูล MySQL
        {
            string connectionString = "datasource=127.0.0.1; port=3306; username=root; password=; database = program_bungboom;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
        public Page2_SignIn()
        {
            InitializeComponent();
        }

        private void Page2_SignIn_Load(object sender, EventArgs e)
        {

        }

        private void CreatBot_Click(object sender, EventArgs e) //การตรวจสอบข้อมูลต่างๆในปุ่ม CreatBot 
        {
            MySqlConnection conn = databaseConnection();

            try
            {
                conn.Open();

                //การกำหนด string ต่างๆ โดยกำหนดค่าต่างๆผ่านการรับเข้าผ่านกล่องข้อความ
                string name = NameText.Text;
                string lastname = LastNameText.Text;
                string phone = PhoneText.Text;
                string email = EmailText.Text;
                string username = UserText.Text;
                string password = PasswordText.Text;

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

                // ตรวจสอบ EmailText ให้มีรูปแบบอีเมลที่ถูกต้อง
                Regex checkEmail = new Regex("(@gmail.com|@hotmail.com|@[A-Za-z]{2,}.ac.th|@kkumail.com)$");
                if (!checkEmail.IsMatch(email))
                {
                    MessageBox.Show("กรุณากรอกอีเมลที่ถูกต้อง (ต้องเป็น @gmail.com, @hotmail, @kkumail.com หรือ .ac.th)");
                    return;
                }

                //Regex checkEmail = new Regex("(@gmail.com|@hotmail.com|@[A-Za-z]{2,}.ac.th)$");
                //if (!checkEmail.IsMatch(email))
                //{
                //    MessageBox.Show("กรุณากรอกอีเมลที่ถูกต้อง (ต้องเป็น @gmail.com, @hotmail, หรือ .ac.th)");
                //    return;
                //}


                // ตรวจสอบ UserText ให้ไม่ซ้ำกับข้อมูลที่มีอยู่ในฐานข้อมูล
                string query = "SELECT COUNT(*) FROM admin WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Username ของคุณซ้ำ");
                    return;
                }

                // ตรวจสอบ PasswordText ให้มีค่าตัวหนังสือและตัวเลข
                if (!Regex.IsMatch(username, @"^(?=.*[a-zA-Z])(?=.*\d)[A-Za-z\d]+$"))
                {
                    MessageBox.Show("รหัสผ่านต้องประกอบด้วย ตัวอักษร และตัวเลข");
                    return;
                }

                // ถ้าผ่านเงื่อนไขทั้งหมด ก็จะทำการเพิ่มข้อมูลลงในฐานข้อมูล
                MySqlCommand cmd1 = new MySqlCommand("INSERT INTO admin (name, lastname, phone, email, username, password) VALUES (@name, @lastname, @phone, @email, @username, @password)", conn);
                cmd1.Parameters.AddWithValue("@name", name);
                cmd1.Parameters.AddWithValue("@lastname", lastname);
                cmd1.Parameters.AddWithValue("@phone", phone);
                cmd1.Parameters.AddWithValue("@email", email);
                cmd1.Parameters.AddWithValue("@username", username);
                cmd1.Parameters.AddWithValue("@password", password);
                cmd1.ExecuteNonQuery();

                MessageBox.Show("สมัครสมาชิกสำเร็จ");

                Page3_login menu = new Page3_login(); //หลังจากเพิ่มข้อมูลลงฐานข้อมูลเรียบร้อยแล้วก็จะย้ายจากหน้า signin ไปที่หน้า login
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

        private bool IsPhoneNumberRegistered(string phoneNumber) //ฟังก์ชั่นตวรจสอบเบอร์โทรในฐานข้อมูล
        {
            MySqlConnection conn = databaseConnection();
            try
            {
                conn.Open();

                // สร้างคำสั่ง SQL สำหรับตรวจสอบเบอร์โทรศัพท์
                string query = "SELECT * FROM admin WHERE phone = @phone";

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

        private void button2_Click(object sender, EventArgs e) //ปุ่ม back
        {
            Page3_login pg = new Page3_login();
            pg.Show();
            this.Hide();
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastNameBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneText_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailText_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

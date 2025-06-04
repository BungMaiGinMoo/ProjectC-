using MySql.Data.MySqlClient;
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
    public partial class Page3_login : Form
    {
        private MySqlConnection databaseConnection() //การเชื่อมต่อกับฐานข้อมูล MySQL
        {
            string connectionString = "datasource=127.0.0.1; port=3306; username=root; password=; database = program_bungboom;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
        public Page3_login()
        {
            InitializeComponent();
        }

        private void Page3_login_Load(object sender, EventArgs e)
        {

        }
        private void IDText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //ปุ่ม Home
        {
            Page1_Main pg = new Page1_Main();
            pg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) //ปุ่มสมัครสมาชิก
        {
            Page2_SignIn pg = new Page2_SignIn();
            pg.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e) //การตรวจสอบข้อมูล username และ password
        {
            MySqlConnection conn = databaseConnection();
            try
            {
                string Check = "";
                if (NameText.Text != Check && PasswordText.Text != Check) //การตรวจสอบค่าว่างในกล่องข้อความ
                {
                    conn.Open();

                    //การกำหนด string ต่างๆ โดยกำหนดค่าต่างๆ ผ่านการรับเข้าผ่านกล่องข้อความ
                    string username = NameText.Text;
                    string password = PasswordText.Text;

                    //การกำหนดคำสั่ง SQL ในตัวแปร query ซึ่งจะนับจำนวนแถวในตาราง admin ที่ตรงกับชื่อผู้ใช้ (username) และรหัสผ่าน (password) ที่ระบุ
                    string query = "SELECT COUNT(*) FROM admin WHERE username = @username AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar()); //แปลงค่าผลลัพธ์ cmd ให้เป็นจำนวนเต็ม (int) และเก็บค่าในตัวแปร count

                    if (count > 0)
                    {
                        MessageBox.Show("เข้าสู่ระบบเสร็จเรียบร้อย", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Page8_Adminselect sl = new Page8_Adminselect();
                        sl.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username หรือ Password ผิดพลาด", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดเกี่ยวกับระบบ: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //คำสั่งตรวจสอบ checkbox เพื่อแสดง และ ซ่อนรหัสผ่าน
        {
            // เมื่อ checkbox ถูกเลือก
            if (checkBox1.Checked)
            {
                // แสดง password
                PasswordText.UseSystemPasswordChar = false;
            }
            else
            {
                // ซ่อน password
                PasswordText.UseSystemPasswordChar = true;
            }
        }
    }
    
}

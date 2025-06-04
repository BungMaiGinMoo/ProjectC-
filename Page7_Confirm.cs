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
using QRCoder;
using Guna.UI2.WinForms;
using System.IO;
using System.Drawing.Printing;
using System.Windows.Documents;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Saladpuk.PromptPay.Facades;
using Saladpuk.PromptPay.Contracts;

namespace Day2
{
    public partial class Page7_Confirm : Form
    {
        public Page7_Confirm()
        {
            InitializeComponent();
        }
        private void Page7_Confirm_Load(object sender, EventArgs e)
        {
            showdataMenuSelling();
            calculateTotal();
            ShowPhoneBox();
            ShowAdminBox();
            CalculateVAT();

            // ตั้งค่าให้ Textbox เป็นคำที่ต้องการ
            ShowDiscount.Text = "0.00";
            PhoneBox.Text = " - Select Phone User - ";
            PhoneAdminBox.Text = " - Select Phone Admin - ";

            double qr_price = Convert.ToDouble(ShowSum.Text);
            IPromptPayBuilder builder = PPay.DynamicQR;

            string qr = PPay.DynamicQR.MobileNumber("0638631802").Amount(qr_price).CreateCreditTransferQrCode();
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qr, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(10);

            // แสดงรูปภาพใน PictureBox 
            QRcode.Image = qrCodeImage;

        }

        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1; port=3306;Initial Catalog = 'program_bungboom'; username=root; password=");

        //เชื่อมต่อฐานข้อมูล
        private MySqlConnection DBConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=program_bungboom;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        private void MEMBER_Click(object sender, EventArgs e) //ปุ่ม signin member
        {
            Page6_2_UserSignIn pg = new Page6_2_UserSignIn();
            pg.Show();
            this.Hide();
        }

        private void BACK_Click(object sender, EventArgs e) //ปุ่ม Back
        {
            Page5_Selling pg = new Page5_Selling();
            pg.Show();
            this.Hide();
        }

        private void UpdateQRCode() //คำสั่งสร้างและรีเฟรช qr code
        {
            double qr_price = Convert.ToDouble(ShowSum.Text);
            IPromptPayBuilder builder = PPay.DynamicQR;

            string qr = PPay.DynamicQR.MobileNumber("0638631802").Amount(qr_price).CreateCreditTransferQrCode();
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qr, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(10);

            // แสดงรูปภาพใน PictureBox 
            QRcode.Image = qrCodeImage;
        }

        private void Confirm_Click(object sender, EventArgs e) // ปุ่มจ่ายเงิน และสร้างสลิป
        {
            bool phoneUserExists = CheckPhoneUser();
            bool phoneAdminExists = CheckPhoneBox();

            if (phoneUserExists && phoneAdminExists)
            {
                CreatePDF();
            }

        }

        // คำสั่ง check เบอร์โทรลูกค้า ถ้าข้อมูลที่กรอกและเลือกตรงกับฐานข้อมูล ให้ทำการสร้างสลิป
        private bool CheckPhoneUser()
        {
            string userInput = PhoneBox.Text; // รับค่าที่ผู้ใช้กรอกใน ComboBox

            // เชื่อมต่อฐานข้อมูล
            using (MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;Initial Catalog='program_bungboom';username=root;password="))
            {
                connection.Open();

                // สร้างคำสั่ง SQL เพื่อค้นหาข้อมูลจากฐานข้อมูล
                string query = "SELECT COUNT(*) FROM user WHERE phone = @phone";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@phone", userInput);

                // ดำเนินการค้นหาข้อมูล
                int count = Convert.ToInt32(command.ExecuteScalar());

                // ตรวจสอบผลลัพธ์
                if (count > 0)
                {
                    // ข้อมูลตรงกับที่มีในฐานข้อมูล
                    return true;
                }
                else
                {
                    // ไม่พบข้อมูลตรงกับที่มีในฐานข้อมูล
                    MessageBox.Show("ไม่พบหมายเลขโทรศัพท์นี้ในระบบ โปรดตรวจสอบหมายเลขของคุณ", "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        // คำสั่ง check เบอร์โทรแอดมิน ถ้าข้อมูลที่กรอกและเลือกตรงกับฐานข้อมูล ให้ทำการสร้างสลิป
        private bool CheckPhoneBox()
        {
            //ตรวจสอบเบอร์แอดมิน
            if (!string.IsNullOrEmpty(PhoneAdminBox.Text))
            {
                string phone = PhoneAdminBox.Text; // เบอร์โทรที่ถูกเลือกใน ComboBox

                // ทำการค้นหาเบอร์โทรในฐานข้อมูล และตรวจสอบว่าตรงหรือไม่
                if (PhoneExistsInDatabase(phone))
                {
                    return true;
                }
                else
                {
                    // เบอร์โทรไม่พบในฐานข้อมูล
                    MessageBox.Show("ไม่พบเบอร์โทรแอดมินในระบบ กรุณาตรวจสอบหมายเลขของคุณ", "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                // แสดงข้อความเตือนเมื่อไม่มีเบอร์โทรถูกเลือก
                MessageBox.Show("กรุณากรอกเบอร์โทร Admin ก่อนทำรายการ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // เมธอตค้นหาเบอร์โทรแอดมิน ใช้ร่วมกับคำสั่งตรวจสอบเบอร์โทร
        private bool PhoneExistsInDatabase(string phone)
        {
            // ทำการค้นหาเบอร์โทรในฐานข้อมูล
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM admin WHERE phone = @phone", connection);
            command.Parameters.AddWithValue("@phone", phone);
            int count = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return count > 0;
        }

        // คำสั่งเคลียร์ตระกร้าสินค้า
        private void ClearDTB()
        {
            try
            {
                // ตรวจสอบว่าการเชื่อมต่อกับฐานข้อมูลมีการเปิดอยู่หรือไม่
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

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

        //คำนวณราคารวมของสินค้า ไม่รวม Vat และ discount
        private void calculateTotal()
        {
            decimal totalSum = 0.00m;

            // ตรวจสอบว่ามีแถวใน dataMenuSelling DataGridView หรือไม่
            if (dataMenuSelling.Rows.Count > 0)
            {
                // วนลูปผ่านแต่ละแถว
                foreach (DataGridViewRow row in dataMenuSelling.Rows)
                {
                    // ลองแปลงค่าในคอลัมน์ที่ 5 (สมมติว่าเป็นตัวเลข)
                    if (decimal.TryParse(row.Cells[5].Value?.ToString(), out decimal value))
                    {
                        totalSum += value;
                    }
                }
            }

            // อัปเดต tb_total textbox ด้วยยอดรวมที่คำนวณได้
            ShowPrice.Text = totalSum.ToString("#,0.00"); // เพิ่มคอมม่าให้กับตัวเลข

            // เพิ่มรายการสินค้าเข้าไปในตะกร้าและบันทึกข้อมูลลงในฐานข้อมูล
        }

        //คำนวณราคา vat 
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

        //คำนวณส่วนลด Discount
        private void CalculateDiscount()
        { 

            // ตรวจสอบว่า PhoneBox.Text ไม่ว่างหรือเป็นช่องว่าง
            if (!string.IsNullOrWhiteSpace(PhoneBox.Text))
            {
                // ตรวจสอบว่าเบอร์โทรศัพท์ไม่ใช่ "Unknown"
                if (PhoneBox.Text != "Unknown" && CheckPhoneUser())
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

        //โชว์รายการสินค้าในตระกร้าสินค้า
        private void showdataMenuSelling()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM cart", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataMenuSelling.RowTemplate.Height = 30;

            dataMenuSelling.AllowUserToDeleteRows = false;

            dataMenuSelling.DataSource = table;


            // กำหนดความกว้างของแต่ละคอลัมน์
            dataMenuSelling.Columns[0].Width = 80; // กำหนดความกว้างของคอลัมน์แรกเป็น 80
            dataMenuSelling.Columns[1].Width = 230; 
            dataMenuSelling.Columns[2].Width = 50; 
            dataMenuSelling.Columns[3].Width = 50; 
            dataMenuSelling.Columns[4].Width = 60; 
            dataMenuSelling.Columns[5].Width = 78; 
        }
          
        //โชว์เบอร์โทรใน combobox
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

            PhoneBox.DisplayMember = "phone";
            PhoneBox.ValueMember = "phone";
            PhoneBox.DataSource = data;
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

            PhoneAdminBox.DisplayMember = "phone";
            PhoneAdminBox.ValueMember = "phone";
            PhoneAdminBox.DataSource = data;
            connection.Close();
        }

        //คำสั่งสร้าง PDF 
        private void CreatePDF()
        {
            MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1; port=3306;Initial Catalog = 'program_bungboom'; username=root; password=");
            connection.Open();

            // เรียกใช้ SqlCommand ในการเลือกข้อมูลจากตาราง order
            string selectOrderQuery = "SELECT id,name,size,count,price FROM cart";
            MySqlCommand selectOrderCmd = new MySqlCommand(selectOrderQuery, connection);

            // เรียกใช้ SqlCommand ในการเลือกข้อมูลจากตาราง order
            string selectUserQuery = "SELECT name,lastname,phone FROM user WHERE phone = @phoneUser";
            MySqlCommand selectUserCmd = new MySqlCommand(selectUserQuery, connection);
            selectUserCmd.Parameters.AddWithValue("@phoneUser", PhoneBox.Text);

            // เรียกใช้ SqlCommand ในการเลือกข้อมูลจากตาราง order
            string selectAdminQuery = "SELECT name,lastname,phone FROM admin WHERE phone = @phoneAdmin";
            MySqlCommand selectAdminCmd = new MySqlCommand(selectAdminQuery, connection);
            selectAdminCmd.Parameters.AddWithValue("@phoneAdmin", PhoneAdminBox.Text);

            // เรียกใช้ SqlDataReader เพื่ออ่านข้อมูลจากการดึงข้อมูล
            using (MySqlDataReader AdminReader = selectAdminCmd.ExecuteReader())
            {

                // ตรวจสอบว่ามีข้อมูลในตารางหรือไม่
                if (AdminReader.HasRows)
                {
                    // อ่านข้อมูล
                    AdminReader.Read();

                    // ดึงข้อมูล name และ lastname จาก DataReader
                    string nameadmin = AdminReader.GetString("name");
                    string lastnameadmin = AdminReader.GetString("lastname");

                    // สร้างข้อความเพื่อใส่ใน userParagraph
                    string adminText = "          Admin name  : " + nameadmin + " " + lastnameadmin + " ";
                    AdminReader.Close();

                    // เรียกใช้ SqlDataReader เพื่ออ่านข้อมูลจากการดึงข้อมูล
                    using (MySqlDataReader userReader = selectUserCmd.ExecuteReader())
                    {

                        // ตรวจสอบว่ามีข้อมูลในตารางหรือไม่
                        if (userReader.HasRows)
                        {
                            // อ่านข้อมูลเฉพาะรายการแรก (สมมติว่ามีรายการเดียวเท่านั้น)
                            userReader.Read();

                            // ดึงข้อมูล name และ lastname จาก DataReader
                            string nameuser = userReader.GetString("name");
                            string lastnameuser = userReader.GetString("lastname");

                            // สร้างข้อความเพื่อใส่ใน userParagraph
                            string userText = "          User name   : " + nameuser + " " + lastnameuser + " ";
                            userReader.Close();

                            using (MySqlDataReader orderReader = selectOrderCmd.ExecuteReader())
                            {
                                // ตรวจสอบว่ามีข้อมูลในตารางหรือไม่
                                if (orderReader.HasRows)
                                {
                                    // สร้างไฟล์ PDF
                                    string pdfPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ใบเสร็จสินค้า ร้านบังฟุตบอลเชิ้ต.pdf");

                                    // เริ่มการสร้างไฟล์ PDF
                                    using (FileStream fs = new FileStream(pdfPath, FileMode.Create))
                                    {
                                        Document doc = new Document(PageSize.A4);
                                        PdfWriter.GetInstance(doc, fs);
                                        doc.Open();

                                        // ระบุที่อยู่และชื่อของไฟล์ฟอนต์ที่ถูกต้อง
                                        string fontPath = @"D:\00_C# PROJECT\th k2d july8.ttf";

                                        // สร้างฟอนต์ BaseFont สำหรับภาษาไทย
                                        BaseFont thaiFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

                                        // สร้าง Font สำหรับภาษาไทยโดยใช้ฟอนต์ BaseFont ที่สร้างขึ้น
                                        iTextSharp.text.Font font = new iTextSharp.text.Font(thaiFont, 14); // ใช้ขนาดฟอนต์เล็กลงจาก 20 เป็น 14

                                        // โหลดรูปภาพ logo จากไฟล์
                                        string logoPath = @"D:\00_C# PROJECT\BG FILE\NEWBG\LOGO.png"; // ระบุเส้นทางไปยังไฟล์รูปภาพ logo ของคุณที่นี่
                                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                                        logo.Alignment = Element.ALIGN_CENTER;
                                        logo.ScalePercent(15); // ปรับขนาดรูปภาพ logo ตามที่คุณต้องการ
                                        doc.Add(logo);

                                        // เพิ่มหัวเรื่องใน PDF
                                        iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph("BUNG FOOTBALL SHIRT\n-------------------------------------------------------------------------------------------------\n\n", font);
                                        title.Alignment = Element.ALIGN_CENTER;
                                        doc.Add(title);

                                        // เพิ่มวันที่และเวลาที่กดปุ่มใน PDF
                                        iTextSharp.text.Paragraph dateTime = new iTextSharp.text.Paragraph("Date and Time: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss\n\n"), font);
                                        dateTime.Alignment = Element.ALIGN_CENTER;
                                        doc.Add(dateTime);


                                        // สร้าง PdfPTable โดยระบุขนาดความกว้างของแต่ละคอลัมน์
                                        PdfPTable table = new PdfPTable(new float[] { 1f, 2f, 1.5f, 1f, 1f }); // 5 คอลัมน์

                                        // เพิ่มหัวข้อใน PDF
                                        PdfPCell cell;

                                        // สร้าง PdfPCell สำหรับแต่ละหัวข้อ
                                        cell = new PdfPCell(new Phrase("id", font));
                                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                        table.AddCell(cell);

                                        cell = new PdfPCell(new Phrase("name", font));
                                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                        table.AddCell(cell);

                                        cell = new PdfPCell(new Phrase("size", font));
                                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                        table.AddCell(cell);

                                        cell = new PdfPCell(new Phrase("count", font));
                                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                        table.AddCell(cell);

                                        cell = new PdfPCell(new Phrase("price", font));
                                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                        table.AddCell(cell);

                                        // อ่านข้อมูลจากตาราง order และเพิ่มลงใน PDF
                                        while (orderReader.Read())
                                        {
                                            string id = orderReader.GetString("id");
                                            string name = orderReader.GetString("name");
                                            string size = orderReader.GetString("size");
                                            int count = orderReader.GetInt32("count");
                                            int price = orderReader.GetInt32("price");

                                            table.AddCell(new PdfPCell(new Phrase(id, font)));
                                            table.AddCell(new PdfPCell(new Phrase(name, font)));
                                            table.AddCell(new PdfPCell(new Phrase(size, font)));
                                            table.AddCell(new PdfPCell(new Phrase(count.ToString(), font)));
                                            table.AddCell(new PdfPCell(new Phrase(price.ToString(), font)));
                                        }

                                        // กำหนดความกว้างของแต่ละคอลัมน์
                                        table.SetWidthPercentage(new float[] { 80, 230, 50, 50, 60 }, PageSize.A4); // ให้ความกว้างรวมเป็น 100% ของขนาดกระดาษ A4

                                        doc.Add(table);

                                        // เพิ่มราคารวมจาก textBox1 ลงใน PDF
                                        iTextSharp.text.Paragraph totalPriceParagraph = new iTextSharp.text.Paragraph("\n          Total Price  : " + ShowPrice.Text + " ฿", font);
                                        totalPriceParagraph.Alignment = Element.ALIGN_LEFT;
                                        doc.Add(totalPriceParagraph);

                                        // เพิ่มราคารวมจาก textBox1 ลงใน PDF 
                                        iTextSharp.text.Paragraph totalVatParagraph = new iTextSharp.text.Paragraph("          Vat 7%     : " + ShowVat.Text + " ฿", font);
                                        totalVatParagraph.Alignment = Element.ALIGN_LEFT;
                                        doc.Add(totalVatParagraph);

                                        // เพิ่มราคารวมจาก textBox1 ลงใน PDF
                                        iTextSharp.text.Paragraph SumPriceParagraph = new iTextSharp.text.Paragraph("          Sum Price   : " + ShowSumPrice.Text + " ฿", font);
                                        SumPriceParagraph.Alignment = Element.ALIGN_LEFT;
                                        doc.Add(SumPriceParagraph);

                                        // เพิ่มราคารวมจาก textBox1 ลงใน PDF
                                        iTextSharp.text.Paragraph totalDiscountParagraph = new iTextSharp.text.Paragraph("          Discount 5% : " + ShowDiscount.Text + " ฿", font);
                                        totalDiscountParagraph.Alignment = Element.ALIGN_LEFT;
                                        doc.Add(totalDiscountParagraph);

                                        // เพิ่มราคารวมจาก textBox1 ลงใน PDF
                                        iTextSharp.text.Paragraph totalSumParagraph = new iTextSharp.text.Paragraph("          Total Sum   : " + ShowSum.Text + " ฿", font);
                                        totalSumParagraph.Alignment = Element.ALIGN_LEFT;
                                        doc.Add(totalSumParagraph);

                                        // สร้าง userParagraph โดยใช้ข้อความที่สร้างขึ้น
                                        iTextSharp.text.Paragraph userParagraph = new iTextSharp.text.Paragraph(userText, font);
                                        userParagraph.Alignment = Element.ALIGN_LEFT;
                                        // เพิ่ม userParagraph ลงในเอกสาร PDF
                                        doc.Add(userParagraph);

                                        // สร้าง userParagraph โดยใช้ข้อความที่สร้างขึ้น
                                        iTextSharp.text.Paragraph adminParagraph = new iTextSharp.text.Paragraph(adminText, font);
                                        adminParagraph.Alignment = Element.ALIGN_LEFT;
                                        // เพิ่ม userParagraph ลงในเอกสาร PDF
                                        doc.Add(adminParagraph);

                                        // ปิดเอกสาร PDF
                                        doc.Close();
                                        
                                        InsertToHistory();
                                        updatestock();
                                        
                                        MessageBox.Show("PDF ได้รับการสร้างและบันทึกไว้ที่โฟลเดอร์ Desktop โดยชื่อไฟล์คือ 'ใบเสร็จสินค้า ร้านบังฟุตบอลเชิ้ต.pdf'", "สร้าง PDF เรียบร้อย", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        showdataMenuSelling();
                                        //this.Hide();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("ไม่มีข้อมูลในตาราง 'cart' ที่จะสร้าง PDF", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                }
            }
            connection.Close();
        }

        //คำสั่ง update ข้อมูลสินค้าในฐานข้อมูล
        private void updatestock()
        {
            if (dataMenuSelling != null && dataMenuSelling.Rows.Count > 0)
            {
                try
                {
                    MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1; port=3306;Initial Catalog = 'program_bungboom'; username=root; password=");
                    connection.Open();

                    // วนลูปผ่านแถวใน DataGridView
                    foreach (DataGridViewRow row in dataMenuSelling.Rows)
                    {
                        // ตรวจสอบว่าแถวไม่ใช่แถวใหม่และมีข้อมูล
                        if (!row.IsNewRow && row.Cells[0].Value != null)
                        {
                            // ดึงค่า ID และ count จากแถวใน DataGridView
                            string id = row.Cells[0].Value.ToString();
                            Int64 count = Convert.ToInt64(row.Cells[3].Value);

                            // สร้างคำสั่ง SQL สำหรับลบ count ออกจาก Table stock
                            MySqlCommand deleteCommand = new MySqlCommand("UPDATE stock SET count = count - @count WHERE id = @id", connection);
                            deleteCommand.Parameters.AddWithValue("@count", count);
                            deleteCommand.Parameters.AddWithValue("@id", id);
                            deleteCommand.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("ทำรายการเสร็จเรียบร้อย", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการเชื่อมต่อกับฐานข้อมูล: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // ปิดการเชื่อมต่อกับฐานข้อมูล
                    connection.Close();
                }
                ClearDTB();
            }
            else
            {
                MessageBox.Show("ไม่มีข้อมูลสินค้าในตารางสินค้า", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //เมธอตการอ่านข้อมูลจากตระกร้าสินค้า เพื่อใช้ในฟังก์ชั่นการบันทึกข้อมูลลงใน History
        private DataTable GetCartData()
        {
            DataTable cartData = new DataTable();

            // เชื่อมต่อฐานข้อมูล
            using (MySqlConnection connection = DBConnection())
            {
                connection.Open();

                // สร้างคำสั่ง SQL เพื่อดึงข้อมูลจากตาราง cart
                string query = "SELECT id, name, size, count, price, sum FROM `cart`";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // สร้าง DataAdapter เพื่อเตรียมการอ่านข้อมูล
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        // เตรียมการอ่านข้อมูลและเติมใส่ DataTable
                        adapter.Fill(cartData);
                    }
                }
            }

            return cartData;
        }

        private void InsertToHistory()
        {
            string PhoneUser = ""; // เก็บค่า Phone User ที่จะใช้ในการ insert
            string PhoneAdmin = ""; // เก็บค่า Phone Admin ที่จะใช้ในการ insert

            // ตรวจสอบว่า ComboBox ของ PhoneUser มีการเลือกแบบใด
            if (PhoneBox.DropDownStyle == ComboBoxStyle.DropDownList)
            {
                // กรณี ComboBox มีการเลือกแบบ Dropdown
                if (PhoneBox.SelectedIndex != -1) // ตรวจสอบว่ามีการเลือกข้อมูล
                {
                    PhoneUser = PhoneBox.SelectedValue.ToString();
                }
                else
                {
                    return; // หยุดการทำงานของฟังก์ชัน
                }
            }

            else if (PhoneBox.DropDownStyle == ComboBoxStyle.DropDown)
            {
                // กรณี ComboBox มีการเลือกแบบ TextBox
                if (!string.IsNullOrWhiteSpace(PhoneBox.Text))
                {
                    PhoneUser = PhoneBox.Text;
                }
                else
                {
                    return; // หยุดการทำงานของฟังก์ชัน
                }
            }

            // ตรวจสอบว่า ComboBox ของ PhoneAdmin มีการเลือกแบบใด
            if (PhoneAdminBox.DropDownStyle == ComboBoxStyle.DropDownList)
            {
                // กรณี ComboBox มีการเลือกแบบ Dropdown
                if (PhoneAdminBox.SelectedIndex != -1) // ตรวจสอบว่ามีการเลือกข้อมูล
                {
                    PhoneAdmin = PhoneAdminBox.SelectedValue.ToString();
                }
                else
                {
                    return; // หยุดการทำงานของฟังก์ชัน
                }
            }

            else if (PhoneAdminBox.DropDownStyle == ComboBoxStyle.DropDown)
            {
                // กรณี ComboBox มีการเลือกแบบ TextBox
                if (!string.IsNullOrWhiteSpace(PhoneAdminBox.Text))
                {
                    PhoneAdmin = PhoneAdminBox.Text;
                }
                else
                {
                    return; // หยุดการทำงานของฟังก์ชัน
                }
            }

            // รายละเอียดสินค้าจากตาราง cart
            DataTable cartData = GetCartData();

            // เตรียมวันที่และเวลาปัจจุบัน
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            string currentTime = DateTime.Now.ToString("HH:mm:ss");

            // เพิ่มการเชื่อมต่อกับฐานข้อมูล
            using (MySqlConnection conn = DBConnection())
            {
                conn.Open();

                foreach (DataRow row in cartData.Rows)
                {
                    // สร้างคำสั่ง SQL เพื่อบันทึกข้อมูลแต่ละรายการในตาราง history
                    string insertQuery = "INSERT INTO saleshistory (phoneuser, phoneadmin, id, name, size, count, price, sum, date, time) " +
                                         "VALUES (@PhoneUser, @PhoneAdmin, @Id, @Name, @Size, @Count, @Price, @Sum, @Date, @Time)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        // กำหนดค่าของพารามิเตอร์
                        cmd.Parameters.AddWithValue("@PhoneUser", PhoneUser);
                        cmd.Parameters.AddWithValue("@PhoneAdmin", PhoneAdmin);
                        cmd.Parameters.AddWithValue("@Id", row["id"]);
                        cmd.Parameters.AddWithValue("@Name", row["name"]);
                        cmd.Parameters.AddWithValue("@Size", row["size"]);
                        cmd.Parameters.AddWithValue("@Count", row["count"]);
                        cmd.Parameters.AddWithValue("@Price", row["price"]);
                        cmd.Parameters.AddWithValue("@Sum", row["sum"]);
                        cmd.Parameters.AddWithValue("@Date", currentDate);
                        cmd.Parameters.AddWithValue("@Time", currentTime);

                        // execute query
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void ShowVat_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ShowPrice_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataMenuSelling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QRcode_Click(object sender, EventArgs e)
        {

        }

        //ปุ่มคำนวณส่วนลด และสร้างราคาใน qr code ใหม่
        private void btnCalculateDiscount_Click_1(object sender, EventArgs e)
        {
            CalculateDiscount();
            UpdateQRCode();
        }

    }

}

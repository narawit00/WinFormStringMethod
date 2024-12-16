namespace WinFormStringMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // เพิ่มรายการคำนำหน้าชื่อใน domainUpDown1
            domainUpDown1.Items.Add("ผศ.ดร.");
            domainUpDown1.Items.Add("เด็กชาย");
            domainUpDown1.Items.Add("เด็กหญิง ");
            domainUpDown1.Items.Add("นางสาว ");
            domainUpDown1.Items.Add("ด.ช.");
            domainUpDown1.Items.Add("ด.ญ.");
            domainUpDown1.Items.Add("น.ส.");
            domainUpDown1.Items.Add("ร.ต.ต.");
            domainUpDown1.Items.Add("ด.ต.");
            domainUpDown1.Items.Add("มรว.");
            domainUpDown1.Items.Add("ผศ.");
            domainUpDown1.Items.Add("ดร.");
            domainUpDown1.Items.Add("นาง");
            domainUpDown1.Items.Add("นาย");

            
            domainUpDown1.SelectedIndex = 0;
        }

        private void btnSplitName_Click(object sender, EventArgs e)
        {
            string fullname = "", firstname = "", lastname = "", title = "";
            int x = 0;

            // ลบช่องว่างนำหน้าและต่อท้าย
            fullname = txtFullname.Text.Trim();

            // ตรวจสอบคำนำหน้าที่มีหลายคำเช่น ผศ.ดร.
            if (fullname.StartsWith("ผศ.ดร."))
            {
                x = 7; // ความยาวของ "ผศ.ดร."
                title = fullname.Substring(0, x);
            }
            // ตรวจสอบคำนำหน้าชื่อเรื่องและแยกชื่อเรื่องออกมา
            else if (fullname.StartsWith("เด็กชาย"))
            {
                x = 7;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("เด็กหญิง"))
            {
                x = 8;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("นางสาว"))
            {
                x = 6;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("ด.ช."))
            {
                x = 4;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("ด.ญ."))
            {
                x = 4;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("น.ส."))
            {
                x = 4;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("ร.ต.ต."))
            {
                x = 6;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("ด.ต."))
            {
                x = 4;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("มรว."))
            {
                x = 4;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("ผศ."))
            {
                x = 3;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("ดร."))
            {
                x = 3;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("นาง") || fullname.StartsWith("นาย"))
            {
                x = 3;
                title = fullname.Substring(0, x);
            }

            // ลบคำนำหน้าออกจากชื่อเต็ม
            fullname = fullname.Substring(x).Trim();

            // หาตำแหน่งช่องว่างแรกเพื่อแยกชื่อและนามสกุล
            int spaceIndex = fullname.IndexOf(' ');

            // ตรวจสอบว่ามีช่องว่างในสตริงที่เหลือหรือไม่
            if (spaceIndex >= 0)
            {
                // แยกชื่อและนามสกุลตามตำแหน่งช่องว่าง
                firstname = fullname.Substring(0, spaceIndex).Trim();
                lastname = fullname.Substring(spaceIndex + 1).Trim(); // +1 to skip the space
            }
            else
            {
                // หากไม่พบช่องว่าง ให้พิจารณาสตริงที่เหลือทั้งหมดเป็นชื่อจริง
                firstname = fullname;
                lastname = ""; // No last name available
            }

            // แสดงผลในกล่องข้อความ
            txtTitle.Text = title;
            txtFirstName.Text = firstname;
            txtLastName.Text = lastname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFullname.Text = "เด็กชาย นราวิชญ์ โนนอาสา ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFullname.Text = "เด็กหญิง นราวิชญ์ โนนอาสา";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtFullname.Text = "ผศ.ดร.";
        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            // ดึงคำนำหน้าที่เลือกจาก domainUpDown1
            string selectedTitle = domainUpDown1.SelectedItem.ToString();

            // ตรวจสอบว่ามีข้อมูลชื่อจริงและนามสกุลที่กรอกไปแล้วหรือไม่
            string firstname = txtFirstName.Text.Trim();
            string lastname = txtLastName.Text.Trim();

            // อัปเดตชื่อเต็มใน txtFullname โดยรวมคำนำหน้า ชื่อ และนามสกุล
            txtFullname.Text = $"{selectedTitle} {firstname} {lastname}".Trim();


        }
    }
}


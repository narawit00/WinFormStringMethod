namespace WinFormStringMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // ������¡�äӹ�˹�Ҫ���� domainUpDown1
            domainUpDown1.Items.Add("��.��.");
            domainUpDown1.Items.Add("�硪��");
            domainUpDown1.Items.Add("��˭ԧ ");
            domainUpDown1.Items.Add("�ҧ��� ");
            domainUpDown1.Items.Add("�.�.");
            domainUpDown1.Items.Add("�.�.");
            domainUpDown1.Items.Add("�.�.");
            domainUpDown1.Items.Add("�.�.�.");
            domainUpDown1.Items.Add("�.�.");
            domainUpDown1.Items.Add("���.");
            domainUpDown1.Items.Add("��.");
            domainUpDown1.Items.Add("��.");
            domainUpDown1.Items.Add("�ҧ");
            domainUpDown1.Items.Add("���");

            
            domainUpDown1.SelectedIndex = 0;
        }

        private void btnSplitName_Click(object sender, EventArgs e)
        {
            string fullname = "", firstname = "", lastname = "", title = "";
            int x = 0;

            // ź��ͧ��ҧ��˹����е�ͷ���
            fullname = txtFullname.Text.Trim();

            // ��Ǩ�ͺ�ӹ�˹�ҷ�������¤��� ��.��.
            if (fullname.StartsWith("��.��."))
            {
                x = 7; // ������Ǣͧ "��.��."
                title = fullname.Substring(0, x);
            }
            // ��Ǩ�ͺ�ӹ�˹�Ҫ�������ͧ����¡��������ͧ�͡��
            else if (fullname.StartsWith("�硪��"))
            {
                x = 7;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("��˭ԧ"))
            {
                x = 8;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("�ҧ���"))
            {
                x = 6;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("�.�."))
            {
                x = 4;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("�.�."))
            {
                x = 4;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("�.�."))
            {
                x = 4;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("�.�.�."))
            {
                x = 6;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("�.�."))
            {
                x = 4;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("���."))
            {
                x = 4;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("��."))
            {
                x = 3;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("��."))
            {
                x = 3;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("�ҧ") || fullname.StartsWith("���"))
            {
                x = 3;
                title = fullname.Substring(0, x);
            }

            // ź�ӹ�˹���͡�ҡ�������
            fullname = fullname.Substring(x).Trim();

            // �ҵ��˹觪�ͧ��ҧ�á�����¡������й��ʡ��
            int spaceIndex = fullname.IndexOf(' ');

            // ��Ǩ�ͺ����ժ�ͧ��ҧ�ʵ�ԧ���������������
            if (spaceIndex >= 0)
            {
                // �¡������й��ʡ�ŵ�����˹觪�ͧ��ҧ
                firstname = fullname.Substring(0, spaceIndex).Trim();
                lastname = fullname.Substring(spaceIndex + 1).Trim(); // +1 to skip the space
            }
            else
            {
                // �ҡ��辺��ͧ��ҧ ���Ԩ�ó�ʵ�ԧ�������ͷ������繪��ͨ�ԧ
                firstname = fullname;
                lastname = ""; // No last name available
            }

            // �ʴ���㹡��ͧ��ͤ���
            txtTitle.Text = title;
            txtFirstName.Text = firstname;
            txtLastName.Text = lastname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFullname.Text = "�硪�� ����Ԫ�� ⹹���� ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFullname.Text = "��˭ԧ ����Ԫ�� ⹹����";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtFullname.Text = "��.��.";
        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            // �֧�ӹ�˹�ҷ�����͡�ҡ domainUpDown1
            string selectedTitle = domainUpDown1.SelectedItem.ToString();

            // ��Ǩ�ͺ����բ����Ū��ͨ�ԧ��й��ʡ�ŷ���͡������������
            string firstname = txtFirstName.Text.Trim();
            string lastname = txtLastName.Text.Trim();

            // �ѻവ�������� txtFullname ������ӹ�˹�� ���� ��й��ʡ��
            txtFullname.Text = $"{selectedTitle} {firstname} {lastname}".Trim();


        }
    }
}


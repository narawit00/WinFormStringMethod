namespace WinFormStringMethod
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFullname = new TextBox();
            txtTitle = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSplitName = new Button();
            domainUpDown1 = new DomainUpDown();
            button4 = new Button();
            SuspendLayout();
            // 
            // txtFullname
            // 
            txtFullname.BackColor = Color.Turquoise;
            txtFullname.Location = new Point(144, 93);
            txtFullname.Multiline = true;
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(494, 34);
            txtFullname.TabIndex = 0;
            txtFullname.Text = "นาย นราวิชญ์ โนนอาสา";
            txtFullname.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.Turquoise;
            txtTitle.Location = new Point(144, 149);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(494, 34);
            txtTitle.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.MediumTurquoise;
            txtFirstName.Location = new Point(144, 217);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(494, 34);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.MediumTurquoise;
            txtLastName.Location = new Point(144, 280);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(494, 34);
            txtLastName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Turquoise;
            label1.Location = new Point(23, 96);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 4;
            label1.Text = "ชื่อ-นามสกุล";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Turquoise;
            label2.Location = new Point(38, 163);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 5;
            label2.Text = "คำนำหน้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumTurquoise;
            label3.Location = new Point(78, 231);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 6;
            label3.Text = "ชื่อ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MediumTurquoise;
            label4.Location = new Point(46, 280);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 7;
            label4.Text = "นามสกุล";
            // 
            // btnSplitName
            // 
            btnSplitName.BackColor = Color.Turquoise;
            btnSplitName.Location = new Point(317, 395);
            btnSplitName.Name = "btnSplitName";
            btnSplitName.Size = new Size(145, 47);
            btnSplitName.TabIndex = 8;
            btnSplitName.Text = "เเยกชื่อสกุล";
            btnSplitName.UseVisualStyleBackColor = false;
            btnSplitName.Click += btnSplitName_Click;
            // 
            // domainUpDown1
            // 
            domainUpDown1.BackColor = Color.Turquoise;
            domainUpDown1.Location = new Point(142, 350);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(502, 27);
            domainUpDown1.TabIndex = 12;
            domainUpDown1.Text = "LIST";
            domainUpDown1.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.LightCyan;
            button4.Location = new Point(144, 448);
            button4.Name = "button4";
            button4.Size = new Size(494, 29);
            button4.TabIndex = 13;
            button4.Text = "Close";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(795, 535);
            Controls.Add(button4);
            Controls.Add(domainUpDown1);
            Controls.Add(btnSplitName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtTitle);
            Controls.Add(txtFullname);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullname;
        private TextBox txtTitle;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSplitName;
        private DomainUpDown domainUpDown1;
        private Button button4;
    }
}

namespace CIS3374_Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.phoneNumberTxt = new System.Windows.Forms.TextBox();
            this.tuIDTxt = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.birthMonthBox = new System.Windows.Forms.ComboBox();
            this.birthDayBox = new System.Windows.Forms.ComboBox();
            this.birthYearBox = new System.Windows.Forms.ComboBox();
            this.gradMonthBox = new System.Windows.Forms.ComboBox();
            this.gradYearBox = new System.Windows.Forms.ComboBox();
            this.majorBox = new System.Windows.Forms.ComboBox();
            this.isUndergraduateBox = new System.Windows.Forms.ComboBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.emailExtensionBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.middleNameTxt = new System.Windows.Forms.TextBox();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNameError = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelDOBError = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "D.O.B. (MM/DD/YYYY)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Expected Grad Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "TUID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Major";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Undergraduate?";
            // 
            // phoneNumberTxt
            // 
            this.phoneNumberTxt.Location = new System.Drawing.Point(174, 277);
            this.phoneNumberTxt.Name = "phoneNumberTxt";
            this.phoneNumberTxt.Size = new System.Drawing.Size(144, 20);
            this.phoneNumberTxt.TabIndex = 6;
            // 
            // tuIDTxt
            // 
            this.tuIDTxt.Location = new System.Drawing.Point(174, 330);
            this.tuIDTxt.Name = "tuIDTxt";
            this.tuIDTxt.Size = new System.Drawing.Size(144, 20);
            this.tuIDTxt.TabIndex = 9;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(174, 356);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(84, 20);
            this.emailText.TabIndex = 10;
            // 
            // birthMonthBox
            // 
            this.birthMonthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.birthMonthBox.FormattingEnabled = true;
            this.birthMonthBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.birthMonthBox.Location = new System.Drawing.Point(152, 19);
            this.birthMonthBox.Name = "birthMonthBox";
            this.birthMonthBox.Size = new System.Drawing.Size(54, 21);
            this.birthMonthBox.TabIndex = 3;
            // 
            // birthDayBox
            // 
            this.birthDayBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.birthDayBox.FormattingEnabled = true;
            this.birthDayBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.birthDayBox.Location = new System.Drawing.Point(212, 19);
            this.birthDayBox.Name = "birthDayBox";
            this.birthDayBox.Size = new System.Drawing.Size(44, 21);
            this.birthDayBox.TabIndex = 4;
            // 
            // birthYearBox
            // 
            this.birthYearBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.birthYearBox.FormattingEnabled = true;
            this.birthYearBox.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010"});
            this.birthYearBox.Location = new System.Drawing.Point(262, 19);
            this.birthYearBox.Name = "birthYearBox";
            this.birthYearBox.Size = new System.Drawing.Size(50, 21);
            this.birthYearBox.TabIndex = 5;
            // 
            // gradMonthBox
            // 
            this.gradMonthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradMonthBox.FormattingEnabled = true;
            this.gradMonthBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.gradMonthBox.Location = new System.Drawing.Point(174, 304);
            this.gradMonthBox.Name = "gradMonthBox";
            this.gradMonthBox.Size = new System.Drawing.Size(54, 21);
            this.gradMonthBox.TabIndex = 7;
            // 
            // gradYearBox
            // 
            this.gradYearBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradYearBox.FormattingEnabled = true;
            this.gradYearBox.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.gradYearBox.Location = new System.Drawing.Point(236, 303);
            this.gradYearBox.Name = "gradYearBox";
            this.gradYearBox.Size = new System.Drawing.Size(82, 21);
            this.gradYearBox.TabIndex = 8;
            // 
            // majorBox
            // 
            this.majorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.majorBox.FormattingEnabled = true;
            this.majorBox.Items.AddRange(new object[] {
            "Applied Mathematics",
            "Biochemistry",
            "Biology",
            "Biophysics",
            "Chemistry",
            "Computer Science",
            "Environmental Science",
            "Geology",
            "Information Science and Technology",
            "Mathematical Economics",
            "Mathematics",
            "Mathematics and Computer Science",
            "Mathematics and Physics",
            "Natural Science",
            "Neuroscience-Cellular and Molecular",
            "Physics",
            "Undecided",
            "Other"});
            this.majorBox.Location = new System.Drawing.Point(174, 382);
            this.majorBox.Name = "majorBox";
            this.majorBox.Size = new System.Drawing.Size(203, 21);
            this.majorBox.TabIndex = 12;
            // 
            // isUndergraduateBox
            // 
            this.isUndergraduateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isUndergraduateBox.FormattingEnabled = true;
            this.isUndergraduateBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.isUndergraduateBox.Location = new System.Drawing.Point(174, 409);
            this.isUndergraduateBox.Name = "isUndergraduateBox";
            this.isUndergraduateBox.Size = new System.Drawing.Size(54, 21);
            this.isUndergraduateBox.TabIndex = 13;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(305, 445);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 14;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(224, 445);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 26;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // emailExtensionBox
            // 
            this.emailExtensionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emailExtensionBox.FormattingEnabled = true;
            this.emailExtensionBox.Items.AddRange(new object[] {
            "temple.edu",
            "gmail.com",
            "live.com",
            "hotmail.com",
            "verizon.net",
            "comcast.net",
            "aol.com",
            "att.net",
            "me.com",
            "mail.com",
            "msn.com",
            "yahoo.com"});
            this.emailExtensionBox.Location = new System.Drawing.Point(288, 355);
            this.emailExtensionBox.Name = "emailExtensionBox";
            this.emailExtensionBox.Size = new System.Drawing.Size(89, 21);
            this.emailExtensionBox.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(264, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "@";
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(152, 81);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(193, 20);
            this.lastNameTxt.TabIndex = 2;
            // 
            // middleNameTxt
            // 
            this.middleNameTxt.Location = new System.Drawing.Point(152, 55);
            this.middleNameTxt.Name = "middleNameTxt";
            this.middleNameTxt.Size = new System.Drawing.Size(193, 20);
            this.middleNameTxt.TabIndex = 1;
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(152, 29);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(193, 20);
            this.firstNameTxt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Middle Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNameError);
            this.groupBox1.Controls.Add(this.firstNameTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lastNameTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.middleNameTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(22, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 113);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelNameError
            // 
            this.labelNameError.AutoSize = true;
            this.labelNameError.Location = new System.Drawing.Point(83, 109);
            this.labelNameError.Name = "labelNameError";
            this.labelNameError.Size = new System.Drawing.Size(0, 13);
            this.labelNameError.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelDOBError);
            this.groupBox2.Controls.Add(this.birthYearBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.birthMonthBox);
            this.groupBox2.Controls.Add(this.birthDayBox);
            this.groupBox2.Location = new System.Drawing.Point(22, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 68);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "D.O.B.";
            // 
            // labelDOBError
            // 
            this.labelDOBError.AutoSize = true;
            this.labelDOBError.Location = new System.Drawing.Point(83, 52);
            this.labelDOBError.Name = "labelDOBError";
            this.labelDOBError.Size = new System.Drawing.Size(0, 13);
            this.labelDOBError.TabIndex = 21;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(40, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 66);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.submitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(439, 490);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.emailExtensionBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.isUndergraduateBox);
            this.Controls.Add(this.majorBox);
            this.Controls.Add(this.gradYearBox);
            this.Controls.Add(this.gradMonthBox);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.tuIDTxt);
            this.Controls.Add(this.phoneNumberTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Student Profile Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox phoneNumberTxt;
        private System.Windows.Forms.TextBox tuIDTxt;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.ComboBox birthMonthBox;
        private System.Windows.Forms.ComboBox birthDayBox;
        private System.Windows.Forms.ComboBox birthYearBox;
        private System.Windows.Forms.ComboBox gradMonthBox;
        private System.Windows.Forms.ComboBox gradYearBox;
        private System.Windows.Forms.ComboBox majorBox;
        private System.Windows.Forms.ComboBox isUndergraduateBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ComboBox emailExtensionBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.TextBox middleNameTxt;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNameError;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelDOBError;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


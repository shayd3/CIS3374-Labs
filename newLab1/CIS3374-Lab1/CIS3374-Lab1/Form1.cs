using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS3374_Lab1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //DO VALIDATIONS BEFORE DEALING WITH VARIABLES AND STUFF
        {

            //Validation for all fields
            bool isFirstNameValid = (firstNameTxt.Text).All(Char.IsLetter) && (firstNameTxt.Text != "");
            bool isMiddleNameValid = (middleNameTxt.Text).All(Char.IsLetter); //Optional?
            bool isLastNameValid = (lastNameTxt.Text).All(Char.IsLetter) && (lastNameTxt.Text != "");

            bool isBirthMonthValid = (birthMonthBox.SelectedIndex != -1);
            bool isBirthDayValid = (birthDayBox.SelectedIndex != -1);
            bool isBirthYearValid = (birthYearBox.SelectedIndex != -1);

            bool isPhoneNumberValid = (phoneNumberTxt.Text != "") && validPhoneNumber(phoneNumberTxt.Text);

            bool isGradMonthValid = (gradMonthBox.SelectedIndex != -1);
            bool isGradYearValid = (gradYearBox.SelectedIndex != -1);

            bool isTUIDValid = (tuIDTxt.Text).All(Char.IsDigit) && (tuIDTxt.Text != "") && tuIDTxt.TextLength == 9;
            bool isEmailValid = (emailText.Text != "");
            bool isEmailExtensionValid = (emailExtensionBox.SelectedIndex != -1);
            bool isMajorValid = (majorBox.SelectedIndex != -1);
            bool isUndergraduateValid = (isUndergraduateBox.SelectedIndex != -1);

            if (isFirstNameValid && isMiddleNameValid && isLastNameValid && isBirthMonthValid && isBirthDayValid && isBirthYearValid && isPhoneNumberValid && isPhoneNumberValid && isGradMonthValid && isGradYearValid && isTUIDValid && isEmailValid && isEmailExtensionValid && isMajorValid && isUndergraduateValid)
            {
                //Will write to CIS3374-lab1/bin/Debug/StudentEntries.txt. Also will append rather than overwrite
                StreamWriter SW = new StreamWriter(@"StudentEntries.txt", true);

                int birthDay = int.Parse(birthDayBox.SelectedItem.ToString());
                int birthMonth = int.Parse(birthMonthBox.SelectedItem.ToString());
                int birthYear = int.Parse(birthYearBox.SelectedItem.ToString());

                int now = int.Parse(DateTime.Now.Year.ToString());
                int age = now - birthYear;

                SW.WriteLine("Full Name: " + firstNameTxt.Text + " " + middleNameTxt.Text + " " + lastNameTxt.Text);
                SW.WriteLine("Date of Birth: " + birthMonthBox.Text + "/" + birthDayBox.Text + "/" + birthYearBox.Text);
                SW.WriteLine("Age: " + age);
                SW.WriteLine("TUID: " + tuIDTxt.Text);
                SW.WriteLine("Email: " + emailText.Text + "@" + emailExtensionBox.Text);
                SW.WriteLine("Phone Number: " + phoneNumberTxt.Text);
                SW.WriteLine("Major: " + majorBox.Text);
                SW.WriteLine("Expected Graduation Date: " + gradMonthBox.Text + "/" + gradYearBox.Text);
                SW.WriteLine("Undergraduate? : " + isUndergraduateBox.Text);
                SW.WriteLine("===========================");

                SW.WriteLine("");
                SW.Close(); //This will save entries after hitting submit rather than wait until program is closed out.

                clearAllFields();
                errorProvider1.Clear();
                firstNameTxt.Focus();
            }
            else
            {
                errorProvider1.Clear();
                if (!isFirstNameValid)
                    errorProvider1.SetError(firstNameTxt, "Enter valid name");
                if (!isMiddleNameValid)
                    errorProvider1.SetError(middleNameTxt, "Enter valid name");
                if (!isLastNameValid)
                    errorProvider1.SetError(lastNameTxt, "Enter valid name");
                if (!isBirthMonthValid)
                    errorProvider1.SetError(birthMonthBox, "Select valid month");
                if (!isBirthDayValid)
                    errorProvider1.SetError(birthDayBox, "Select valid day");
                if (!isBirthYearValid)
                    errorProvider1.SetError(birthYearBox, "Select valid year");
                if (!isTUIDValid)
                    errorProvider1.SetError(tuIDTxt, "Enter digits only and 9 digits");
                if (!isEmailValid)
                    errorProvider1.SetError(emailText, "Enter valid email");
                if (!isEmailExtensionValid)
                    errorProvider1.SetError(emailExtensionBox, "Select valid extension");
                if (!isPhoneNumberValid)
                    errorProvider1.SetError(phoneNumberTxt, "Enter valid phone number");
                if (!isMajorValid)
                    errorProvider1.SetError(majorBox, "Select valid major");
                if (!isGradMonthValid)
                    errorProvider1.SetError(gradMonthBox, "Select valid month");
                if (!isGradYearValid)
                    errorProvider1.SetError(gradYearBox, "Select valid year");
                if (!isUndergraduateValid)
                    errorProvider1.SetError(isUndergraduateBox, "Select either yes or no");
            }
        }

        

        private bool validPhoneNumber(string phoneNumber)
        {
            var count = phoneNumber.Count(x => Char.IsDigit(x)); ///Checks to see if there is 10 digits in the phone number. 
            bool correctCount = false;
            if (count == 10) correctCount = true;
            return Regex.Match(phoneNumber, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}").Success && correctCount;
            
        }

        private void clearAllFields()
        {
            // resets all the fields!
            firstNameTxt.Text = "";
            lastNameTxt.Text = "";
            middleNameTxt.Text = "";
            birthMonthBox.SelectedIndex = -1;
            birthDayBox.SelectedIndex = -1;
            birthYearBox.SelectedIndex = -1;
            phoneNumberTxt.Text = "";
            gradMonthBox.SelectedIndex = -1;
            gradYearBox.SelectedIndex = -1;
            tuIDTxt.Text = "";
            emailText.Text = "";
            emailExtensionBox.SelectedIndex = -1;
            majorBox.SelectedIndex = -1;
            isUndergraduateBox.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = firstNameTxt;
        }
        
        

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

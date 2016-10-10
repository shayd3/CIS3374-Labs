using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        List<String[]> students = new List<String[]>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["students"] != null)
            {
                students = (List<String[]>)Session["students"];
            }
            populateYearField();
            divSucess.Visible = false;
            divError.Visible = false;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            String[] studentInfo = new String[8];

            int errors = 0;

            studentInfo[0] = getFullName(txtFirstName.Text, txtMiddleName.Text, txtLastName.Text);
            studentInfo[1] = calculateAge(ddlDOBMonth.SelectedValue.ToString(), ddlDOBDay.SelectedValue.ToString(), ddlDOBYear.SelectedValue.ToString()).ToString();

            if (validateTUID(txtTUid.Text))
            {
                studentInfo[2] = txtTUid.Text;
            }
            else
            {
                lblErrorMessage.Text = lblErrorMessage.Text + "There seems to be a problem with your TUid" + "<br>";
                errors++;
            }

            if (validatePhoneNumber(txtPhoneNum1.Text))
            {
                studentInfo[3] = txtPhoneNum1.Text;
            }

            else
            {
                lblErrorMessage.Text = lblErrorMessage.Text + "There seems to be a problem with your phone number" + "<br>";
                errors++;
            }

            if (validateEmail(txtEmail.Text))
            {
                studentInfo[4] = txtEmail.Text;
            }
            else
            {
                lblErrorMessage.Text = lblErrorMessage.Text + "There seems to be a problem with your email";
                errors++;
            }

            studentInfo[5] = ddlMajor.SelectedValue.ToString();
            studentInfo[6] = ddlExpectedGradSem.SelectedValue.ToString() + " " + ddlExpectedGradYear.SelectedValue.ToString();
            studentInfo[7] = radUndergrad.SelectedValue.ToString();

            if (errors == 0)
            {
                students.Add(studentInfo);
                Session["students"] = students;
                divSucess.Visible = true;
                lblSucess.Text = "The student has been successfully added!";
                clearFields();
            }
            else
            {
                divError.Visible = true;
                lblErrorMessage.Text = "<b>Student could not be added</b><br>" + lblErrorMessage.Text;
            }
        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            String[] studentInfo = new String[8];
            if (students.Count == 0)
            {
                divError.Visible = true;
                lblErrorMessage.Text = "There are no students to report!";
            }
            else if (students.Count == 1)
            {
                System.IO.File.WriteAllLines(@"E:\Dropbox\Dropbox\School\CIS3374 - Quality Assurance and Testing\Labs\Lab 2\WebApplication1_Simek\WebApplication1\Students.txt", students[0]);
                divSucess.Visible = true;
                lblSucess.Text = "Your file has successfully downloaded! Please check C: > Users > Public > Downloads to view your file.";
            }
            else
            {
                System.IO.File.WriteAllLines(@"E:\Dropbox\Dropbox\School\CIS3374 - Quality Assurance and Testing\Labs\Lab 2\WebApplication1_Simek\WebApplication1\Students.txt", students[0]);

                for (int i = 1; i < students.Count; i++)
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"E:\Dropbox\Dropbox\School\CIS3374 - Quality Assurance and Testing\Labs\Lab 2\WebApplication1_Simek\WebApplication1\Students.txt", true))
                    {
                        studentInfo = students[i];
                        int j = 0;
                        while (j <= 7)
                        {
                            file.WriteLine(studentInfo[j]);
                            j++;
                        }
                    }
                }
                divSucess.Visible = true;
                lblSucess.Text = "Your file has successfully downloaded! Please check C: > Users > Public > Downloads to view your file.";
                Session["students"] = null;
            }
        }

        public String getFullName(String firstName, String middleName, String lastName)
        {
            return firstName + " " + middleName + " " + lastName + " ";
        }

        public int calculateAge(String inputMonth, String inputDay, String inputYear)
        {
            DateTime dateOfBirth = Convert.ToDateTime(inputMonth + "/" + inputDay + "/" + inputYear);

            int inputYearInt = Int16.Parse(inputYear);
            int currentYearInt = Convert.ToInt16(DateTime.Now.Year.ToString());

            int inputMonthInt = Int16.Parse(inputMonth);
            int currentMonthInt = Convert.ToInt16(DateTime.Now.Month.ToString());


            if (inputYearInt == currentYearInt)
            {
                int inputDayInt = Int16.Parse(inputDay);
                int currentDayhInt = Convert.ToInt16(DateTime.Now.Day.ToString());
                
                if (inputMonthInt == currentMonthInt)
                {
                    if (inputDayInt < currentDayhInt)
                    {
                        return (currentYearInt - 1) - inputYearInt;
                    }
                    else
                    {
                        return currentYearInt - inputYearInt;
                    }
                }
                else if (inputMonthInt < currentMonthInt)
                {
                    return (currentYearInt - 1) - inputYearInt;
                }
                else
                {
                    return currentYearInt - inputYearInt;
                }
            }

            else if (inputMonthInt > currentMonthInt)
            {
                return (currentYearInt - 1) - inputYearInt;
            }

            else
            {
                return currentYearInt - inputYearInt;
            }

        }

        public void populateYearField()
        {
            int currentYearInt = Convert.ToInt16(DateTime.Now.Year.ToString());
            int i = currentYearInt - 100;

            while (currentYearInt > i)
            {
                ddlDOBYear.Items.Add(currentYearInt.ToString());
                currentYearInt--;
            }
        }

        public Boolean validateTUID(String inputTUID)
        {
            Regex regexTUID = new Regex(@"^\d{9}$");
            return (regexTUID.IsMatch(inputTUID));
        }

        public Boolean validatePhoneNumber(String inputPhoneNumber)
        {
            Regex regexPhoneNumber = new Regex(@"^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$");
            return (regexPhoneNumber.IsMatch(inputPhoneNumber));
        }

        public Boolean validateEmail(string inputEmail)
        {
            Regex regexEmail = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            return (regexEmail.IsMatch(inputEmail));
        }

        public void clearFields()
        {
            txtEmail.Text = null;
            txtFirstName.Text = null;
            txtLastName.Text = null;
            txtMiddleName.Text = null;
            txtPhoneNum1.Text = null;
            txtTUid.Text = null;
            ddlDOBDay.SelectedIndex = 0;
            ddlDOBMonth.SelectedIndex = 0;
            ddlDOBYear.SelectedIndex = 0;
            ddlDOBYear.SelectedIndex = 0;
            ddlExpectedGradSem.SelectedIndex = 0;
            ddlExpectedGradYear.SelectedIndex = 0;
            ddlMajor.SelectedIndex = 0;
            radUndergrad.ClearSelection();
        }
    }
}
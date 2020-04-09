using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace InsuranceSystem
{
    public partial class EmployeeLoginPage : UserControl
    {
        public EmployeeLoginPage()
        {
            InitializeComponent();
            employeeMainPage1.Hide();
        }

        public void clearFields()
        {
            employeeUsernameInput.Text = "";
            employeePasswordInput.Text = "";
        }

        private void employeeBackButton_Click(object sender, EventArgs e)
        {
            MainForm form = (MainForm)this.FindForm();
            form.setOfficeDropdownValues();
            form.clearFields();
            this.Hide();
            clearFields();
        }

        private void employeeLoginButton_Click(object sender, EventArgs e)
        {
            using (insuranceEntities ie = new insuranceEntities())
            {
                if (employeeUsernameInput.Text != string.Empty || employeePasswordInput.Text != string.Empty)
                {
                    if (employeeUsernameInput.Text.Any(Char.IsWhiteSpace) || employeePasswordInput.Text.Any(Char.IsWhiteSpace))
                    {
                        MessageBox.Show("No spaces allowed in username or password fields!");
                    }
                    else
                    {
                        var user = ie.Offices.Where(a => a.Username.Equals(employeeUsernameInput.Text)).FirstOrDefault();
                        if (user != null)
                        {
                            if (user.Password.Equals(employeePasswordInput.Text))
                            {
                                employeeMainPage1.loggedInId = user.Id;
                                employeeMainPage1.Show();
                                employeeMainPage1.fixEmptyDatabaseFields();
                                employeeMainPage1.populateFields();
                                employeeMainPage1.setCustomerDropdownValues();
                                employeeMainPage1.BringToFront();
                                clearFields();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect password!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please input username and password!");
                }
            }
        }
    }
}

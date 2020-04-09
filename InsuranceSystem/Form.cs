using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InsuranceSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void setOfficeDropdownValues()
        {
            using (insuranceEntities ie = new insuranceEntities())
            {
                List<Office> offices = ie.Offices.ToList();
                officeListDropdown.DataSource = offices;
                officeListDropdown.ValueMember = "Id";
                officeListDropdown.DisplayMember = "DisplayName";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            setOfficeDropdownValues();
            employeeLoginPage1.Hide();
            customerViewPage1.Hide();
        }

        private void employeeLoginPageButton_Click(object sender, EventArgs e)
        {
            employeeLoginPage1.Show();
            employeeLoginPage1.BringToFront();
        }

        private void setAppointmentButton_Click(object sender, EventArgs e)
        {
            if (RemoveWhitespace(licencePlateSetInput.Text) != string.Empty && customerNameInput.Text != string.Empty && customerPhoneSetInput.Text != string.Empty)
            {
                using (insuranceEntities ie = new insuranceEntities())
                {
                    List<Customer> customers = ie.Customers.ToList();
                    bool found = false;
                    foreach (var item in customers)
                    {
                        if (item.LicencePlate.Equals(RemoveWhitespace(licencePlateSetInput.Text), StringComparison.InvariantCultureIgnoreCase) && item.OfficeId == Int32.Parse(officeListDropdown.SelectedValue.ToString()))
                        {
                            found = true;
                            break;
                        }
                    }
                    if (found == true)
                    {
                        MessageBox.Show("This licence plate is already registered in an insurance office!");
                    }
                    else
                    {
                        bool isInputOK = true;
                        if (RemoveWhitespace(licencePlateSetInput.Text).Length != 8)
                        {
                            MessageBox.Show("The licence plate consists of 8 symbols!");
                            isInputOK = false;
                        }
                        else
                        {
                            string start = RemoveWhitespace(licencePlateSetInput.Text).Substring(0, 2);
                            string middle = RemoveWhitespace(licencePlateSetInput.Text).Substring(2, 4);
                            string end = RemoveWhitespace(licencePlateSetInput.Text).Substring(6, 2);
                            bool startRegex = Regex.IsMatch(start, @"^[a-zA-Z]+$");
                            bool middleRegex = Regex.IsMatch(middle, @"^[0-9]+$");
                            bool endRegex = Regex.IsMatch(end, @"^[a-zA-Z]+$");
                            if (!startRegex)
                            {
                                MessageBox.Show("First 2 licence plate symbols must be latin letters!");
                                isInputOK = false;
                            }
                            if (!middleRegex)
                            {
                                MessageBox.Show("Middle 4 licence plate symbols must be positive digits!");
                                isInputOK = false;
                            }
                            if (!endRegex)
                            {
                                MessageBox.Show("Last 2 licence plate symbols must be latin letters!");
                                isInputOK = false;
                            }
                        }
                        if (RemoveWhitespace(customerPhoneSetInput.Text).Length != 10)
                        {
                            MessageBox.Show("A valid mobile phone number consists of 10 digits!");
                            isInputOK = false;
                        }
                        if (isInputOK == true)
                        {
                            Customer customer = new Customer();
                            customer.LicencePlate = RemoveWhitespace(licencePlateSetInput.Text).ToUpper();
                            customer.Name = customerNameInput.Text;
                            customer.Phone = RemoveWhitespace(customerPhoneSetInput.Text);
                            customer.OfficeId = Int32.Parse(officeListDropdown.SelectedValue.ToString());
                            customer.Status = "Booked";
                            string hours = timePicker.Value.ToString().Substring(14, 5).Split(':')[0];
                            if (hours.Length == 1)
                            {
                                hours = "0" + hours;
                            }
                            string mins = timePicker.Value.ToString().Substring(14, 5).Split(':')[1];
                            if (mins.Length == 1)
                            {
                                mins = "0" + mins;
                            }
                            string time = hours + ":" + mins;
                            bool canSaveAppointment = true;
                            List<Customer> selectedOfficeCustomers = ie.Customers.Where(a => a.OfficeId == customer.OfficeId).ToList();
                            foreach (var item in selectedOfficeCustomers)
                            {
                                if (item.Date == datePicker.Value.ToString().Substring(0, 10) && item.Time == time)
                                {
                                    canSaveAppointment = false;
                                    break;
                                }
                            }
                            customer.Date = datePicker.Value.ToString().Substring(0, 10);
                            customer.Time = time;
                            if (canSaveAppointment == true)
                            {
                                ie.Customers.Add(customer);
                                ie.SaveChanges();
                                MessageBox.Show("Appointment successfully booked!");
                                clearFields();
                            }
                            else
                            {
                                MessageBox.Show("Selected date and time combination is taken in selected office!");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please input all fields!");
            }
        }

        public string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray().Where(c => !Char.IsWhiteSpace(c)).ToArray());
        }

        private void viewAppointmentButton_Click(object sender, EventArgs e)
        {
            if (RemoveWhitespace(licencePlateViewInput.Text) != string.Empty && RemoveWhitespace(customerPhoneViewInput.Text) != string.Empty)
            {
                bool isInputOK = true;
                if (RemoveWhitespace(licencePlateViewInput.Text).Length != 8)
                {
                    MessageBox.Show("The licence plate consists of 8 symbols!");
                    isInputOK = false;
                }
                else
                {
                    string start = RemoveWhitespace(licencePlateViewInput.Text).Substring(0, 2);
                    string middle = RemoveWhitespace(licencePlateViewInput.Text).Substring(2, 4);
                    string end = RemoveWhitespace(licencePlateViewInput.Text).Substring(6, 2);
                    bool startRegex = Regex.IsMatch(start, @"^[a-zA-Z]+$");
                    bool middleRegex = Regex.IsMatch(middle, @"^[0-9]+$");
                    bool endRegex = Regex.IsMatch(end, @"^[a-zA-Z]+$");
                    if (!startRegex)
                    {
                        MessageBox.Show("First 2 licence plate symbols must be latin letters!");
                        isInputOK = false;
                    }
                    if (!middleRegex)
                    {
                        MessageBox.Show("Middle 4 licence plate symbols must be positive digits!");
                        isInputOK = false;
                    }
                    if (!endRegex)
                    {
                        MessageBox.Show("Last 2 licence plate symbols must be latin letters!");
                        isInputOK = false;
                    }
                }
                if (RemoveWhitespace(customerPhoneViewInput.Text).Length != 10)
                {
                    MessageBox.Show("A valid mobile phone number consists of 10 digits!");
                    isInputOK = false;
                }
                if (isInputOK == true)
                {
                    string licencePlate = RemoveWhitespace(licencePlateViewInput.Text).ToUpper();
                    string phoneNumber = RemoveWhitespace(customerPhoneViewInput.Text);
                    using (insuranceEntities ie = new insuranceEntities())
                    {
                        Customer customer = ie.Customers.Where(a => a.LicencePlate.Equals(licencePlate, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();
                        if (customer != null)
                        {
                            if (customer.Phone.Equals(phoneNumber))
                            {
                                customerViewPage1.loggedInId = customer.Id;
                                customerViewPage1.Show();
                                customerViewPage1.populateFields();
                                customerViewPage1.BringToFront();
                                clearFields();
                            }
                            else
                            {
                                MessageBox.Show("Wrong phone number!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No appointment found!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please input both fields!");
            }
        }

        public void clearFields()
        {
            licencePlateSetInput.Text = "";
            customerNameInput.Text = "";
            customerPhoneSetInput.Text = "";
            setOfficeDropdownValues();
            datePicker.Value = DateTime.Now;
            timePicker.Value = DateTime.Now;
            licencePlateViewInput.Text = "";
            customerPhoneViewInput.Text = "";
        }
    }
}

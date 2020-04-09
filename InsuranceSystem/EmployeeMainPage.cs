using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace InsuranceSystem
{
    public partial class EmployeeMainPage : UserControl
    {
        public int loggedInId { get; set; }

        public EmployeeMainPage()
        {
            InitializeComponent();
        }

        public void setCustomerDropdownValues()
        {
            using (insuranceEntities ie = new insuranceEntities())
            {
                List<Customer> customers = ie.Customers.Where(a => a.OfficeId == loggedInId).ToList();
                customerListDropdown.DataSource = customers;
                customerListDropdown.ValueMember = "Id";
                customerListDropdown.DisplayMember = "DisplayName";
                setCustomerStatus();
            }
        }

        public void setCustomerStatus()
        {
            using (insuranceEntities ie = new insuranceEntities())
            {
                int selectedCustomerId;
                if (customerListDropdown.Items.Count > 0)
                {
                    Int32.TryParse(customerListDropdown.SelectedValue.ToString(), out selectedCustomerId);
                    if (selectedCustomerId != 0)
                    {
                        Customer selectedCustomer = ie.Customers.Where(a => a.Id == selectedCustomerId).FirstOrDefault();
                        if (selectedCustomer != null)
                        {
                            customerStatusDropdown.SelectedItem = selectedCustomer.Status;
                        }
                    }
                }
                else
                {
                    customerStatusDropdown.SelectedItem = null;
                }
            }
        }

        public void populateFields()
        {
            using (insuranceEntities ie = new insuranceEntities())
            {
                var office = ie.Offices.Where(a => a.Id == this.loggedInId).FirstOrDefault();
                if (office != null)
                {
                    if (office.Name != null)
                    {
                        officeNameInput.Text = office.Name;
                    }
                    else
                    {
                        officeNameInput.Text = "";
                    }

                    if (office.Location != null)
                    {
                        officeLocationInput.Text = office.Location;
                    }
                    else
                    {
                        officeLocationInput.Text = "";
                    }

                    if (office.Director != null)
                    {
                        officeDirectorInput.Text = office.Director;
                    }
                    else
                    {
                        officeDirectorInput.Text = "";
                    }
                }
                customerStatusDropdown.SelectedItem = null;
            }
        }

        private void employeeLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void updateOfficeInfoButton_Click(object sender, EventArgs e)
        {
            using (insuranceEntities ie = new insuranceEntities())
            {
                var office = ie.Offices.Where(a => a.Id == this.loggedInId).FirstOrDefault();
                if (office != null)
                {
                    bool somethingUpdated = false;
                    if (office.Name != officeNameInput.Text)
                    {
                        office.Name = officeNameInput.Text;
                        somethingUpdated = true;
                    }
                    if (office.Location != officeLocationInput.Text)
                    {
                        office.Location = officeLocationInput.Text;
                        somethingUpdated = true;
                    }
                    if (office.Director != officeDirectorInput.Text)
                    {
                        office.Director = officeDirectorInput.Text;
                        somethingUpdated = true;
                    }
                    if (somethingUpdated == true)
                    {
                        ie.SaveChanges();
                        MessageBox.Show("Office information updated successfully!");
                    }
                }
            }
        }

        private void customerListDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCustomerStatus();
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            if (customerListDropdown.Items.Count > 0)
            {
                using (insuranceEntities ie = new insuranceEntities())
                {
                    int selectedCustomerId = Int32.Parse(customerListDropdown.SelectedValue.ToString());
                    Customer selectedCustomer = ie.Customers.Where(a => a.Id == selectedCustomerId).FirstOrDefault();
                    if (selectedCustomer != null)
                    {
                        bool somethingUpdated = false;
                        if (selectedCustomer.Status != customerStatusDropdown.SelectedItem.ToString())
                        {
                            selectedCustomer.Status = customerStatusDropdown.SelectedItem.ToString();
                            somethingUpdated = true;
                        }
                        if (somethingUpdated == true)
                        {
                            ie.SaveChanges();
                            MessageBox.Show("Customer information updated successfully!");
                        }
                    }
                }
            }
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            if (customerListDropdown.Items.Count > 0)
            {
                using (insuranceEntities ie = new insuranceEntities())
                {
                    int selectedCustomerId = Int32.Parse(customerListDropdown.SelectedValue.ToString());
                    Customer selectedCustomer = ie.Customers.Where(a => a.Id == selectedCustomerId).FirstOrDefault();
                    if (selectedCustomer != null)
                    {
                        if (MessageBox.Show("Are you sure you want to remove the selected customer?", "Remove Customer", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            ie.Customers.Remove(selectedCustomer);
                            ie.SaveChanges();
                            MessageBox.Show("Customer removed successfully!");
                            setCustomerDropdownValues();
                        }
                    }
                }
            }
        }

        public void fixEmptyDatabaseFields()
        {
            using (insuranceEntities ie = new insuranceEntities())
            {
                var office = ie.Offices.Where(a => a.Id == this.loggedInId).FirstOrDefault();
                if (office.Name == null)
                {
                    office.Name = "";
                }
                if (office.Location == null)
                {
                    office.Location = "";
                }
                if (office.Director == null)
                {
                    office.Director = "";
                }
                ie.SaveChanges();
            }
        }
    }
}

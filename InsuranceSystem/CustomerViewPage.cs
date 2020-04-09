using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace InsuranceSystem
{
    public partial class CustomerViewPage : UserControl
    {
        public int loggedInId { get; set; }

        public CustomerViewPage()
        {
            InitializeComponent();
        }

        public void populateFields()
        {
            using (insuranceEntities ie = new insuranceEntities())
            {
                Customer customer = ie.Customers.Where(a => a.Id == loggedInId).FirstOrDefault();
                if (customer != null)
                {
                    customerLicencePlateValue.Text = customer.LicencePlate;
                    customerNameValue.Text = customer.Name;
                    customerPhoneValue.Text = customer.Phone;
                    List<Office> offices = ie.Offices.ToList();
                    officeListDropdown.DataSource = offices;
                    officeListDropdown.ValueMember = "Id";
                    officeListDropdown.DisplayMember = "DisplayName";
                    officeListDropdown.SelectedValue = customer.OfficeId;
                    customerStatusValue.Text = customer.Status;
                    datePicker.Value = DateTime.Parse(customer.Date);
                    timePicker.Value = DateTime.Parse(customer.Time);
                }
            }
        }

        private void updateCustomerInfoButton_Click(object sender, EventArgs e)
        {
            using (insuranceEntities ie = new insuranceEntities())
            {
                Customer customer = ie.Customers.Where(a => a.Id == loggedInId).FirstOrDefault();
                if (customer != null)
                {
                    bool somethingUpdated = false;
                    if (customer.OfficeId != Int32.Parse(officeListDropdown.SelectedValue.ToString()))
                    {
                        customer.OfficeId = Int32.Parse(officeListDropdown.SelectedValue.ToString());
                        somethingUpdated = true;
                    }
                    if (customer.Date != datePicker.Value.ToString().Substring(0, 10))
                    {
                        customer.Date = datePicker.Value.ToString().Substring(0, 10);
                        somethingUpdated = true;
                    }
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
                    bool canUpdateAppointment = true;
                    int selectedOfficeId = Int32.Parse(officeListDropdown.SelectedValue.ToString());
                    List<Customer> selectedOfficeCustomers = ie.Customers.Where(a => a.OfficeId == selectedOfficeId).ToList();
                    foreach (var item in selectedOfficeCustomers)
                    {
                        if (item.Id != loggedInId)
                        {
                            if (item.Date == datePicker.Value.ToString().Substring(0, 10) && item.Time == time)
                            {
                                canUpdateAppointment = false;
                                break;
                            }
                        }
                    }
                    if (customer.Time != time)
                    {
                        customer.Time = time;
                        somethingUpdated = true;
                    }
                    if (canUpdateAppointment == true)
                    {
                        if (somethingUpdated == true)
                        {
                            ie.SaveChanges();
                            MessageBox.Show("Appointment successfully updated!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selected date and time combination is taken in selected office!");
                    }
                }
            }
        }

        private void deleteAppointmentButton_Click(object sender, EventArgs e)
        {
            using (insuranceEntities ie = new insuranceEntities())
            {
                Customer customer = ie.Customers.Where(a => a.Id == loggedInId).FirstOrDefault();
                if (customer != null)
                {
                    if (MessageBox.Show("Are you sure you want to delete your appointment?", "Delete Appointment", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ie.Customers.Remove(customer);
                        ie.SaveChanges();
                        MessageBox.Show("Appointment successfully deleted!");
                        this.Hide();
                    }
                }
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

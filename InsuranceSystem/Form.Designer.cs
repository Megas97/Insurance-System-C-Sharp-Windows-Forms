using System;
using System.Drawing;
using System.Windows.Forms;

namespace InsuranceSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.employeeLoginPageButton = new System.Windows.Forms.Button();
            this.manageAppointmentsPageLabel = new System.Windows.Forms.Label();
            this.licencePlateSetLabel = new System.Windows.Forms.Label();
            this.licencePlateSetInput = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameInput = new System.Windows.Forms.TextBox();
            this.customerPhoneSetLabel = new System.Windows.Forms.Label();
            this.customerPhoneSetInput = new System.Windows.Forms.TextBox();
            this.chooseOfficeLabel = new System.Windows.Forms.Label();
            this.officeListDropdown = new System.Windows.Forms.ComboBox();
            this.setAppointmentButton = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.chooseDateLabel = new System.Windows.Forms.Label();
            this.chooseTimeLabel = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.licencePlateViewLabel = new System.Windows.Forms.Label();
            this.licencePlateViewInput = new System.Windows.Forms.TextBox();
            this.customerPhoneViewLabel = new System.Windows.Forms.Label();
            this.customerPhoneViewInput = new System.Windows.Forms.TextBox();
            this.viewAppointmentButton = new System.Windows.Forms.Button();
            this.employeePagePicture = new System.Windows.Forms.PictureBox();
            this.customerViewPage1 = new InsuranceSystem.CustomerViewPage();
            this.employeeLoginPage1 = new InsuranceSystem.EmployeeLoginPage();
            ((System.ComponentModel.ISupportInitialize)(this.employeePagePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeLoginPageButton
            // 
            this.employeeLoginPageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeLoginPageButton.Location = new System.Drawing.Point(392, 395);
            this.employeeLoginPageButton.Name = "employeeLoginPageButton";
            this.employeeLoginPageButton.Size = new System.Drawing.Size(114, 29);
            this.employeeLoginPageButton.TabIndex = 2;
            this.employeeLoginPageButton.Text = "Employee Login";
            this.employeeLoginPageButton.UseVisualStyleBackColor = true;
            this.employeeLoginPageButton.Click += new System.EventHandler(this.employeeLoginPageButton_Click);
            // 
            // manageAppointmentsPageLabel
            // 
            this.manageAppointmentsPageLabel.AutoSize = true;
            this.manageAppointmentsPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manageAppointmentsPageLabel.Location = new System.Drawing.Point(188, 2);
            this.manageAppointmentsPageLabel.Name = "manageAppointmentsPageLabel";
            this.manageAppointmentsPageLabel.Size = new System.Drawing.Size(284, 31);
            this.manageAppointmentsPageLabel.TabIndex = 4;
            this.manageAppointmentsPageLabel.Text = "Manage Appointments";
            // 
            // licencePlateSetLabel
            // 
            this.licencePlateSetLabel.AutoSize = true;
            this.licencePlateSetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.licencePlateSetLabel.Location = new System.Drawing.Point(318, 96);
            this.licencePlateSetLabel.Name = "licencePlateSetLabel";
            this.licencePlateSetLabel.Size = new System.Drawing.Size(95, 16);
            this.licencePlateSetLabel.TabIndex = 5;
            this.licencePlateSetLabel.Text = "Licence Plate: ";
            // 
            // licencePlateSetInput
            // 
            this.licencePlateSetInput.Location = new System.Drawing.Point(424, 95);
            this.licencePlateSetInput.Name = "licencePlateSetInput";
            this.licencePlateSetInput.Size = new System.Drawing.Size(155, 20);
            this.licencePlateSetInput.TabIndex = 6;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerNameLabel.Location = new System.Drawing.Point(318, 122);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(111, 16);
            this.customerNameLabel.TabIndex = 7;
            this.customerNameLabel.Text = "Customer Name: ";
            // 
            // customerNameInput
            // 
            this.customerNameInput.Location = new System.Drawing.Point(424, 121);
            this.customerNameInput.Name = "customerNameInput";
            this.customerNameInput.Size = new System.Drawing.Size(155, 20);
            this.customerNameInput.TabIndex = 8;
            // 
            // customerPhoneSetLabel
            // 
            this.customerPhoneSetLabel.AutoSize = true;
            this.customerPhoneSetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerPhoneSetLabel.Location = new System.Drawing.Point(318, 148);
            this.customerPhoneSetLabel.Name = "customerPhoneSetLabel";
            this.customerPhoneSetLabel.Size = new System.Drawing.Size(104, 16);
            this.customerPhoneSetLabel.TabIndex = 9;
            this.customerPhoneSetLabel.Text = "Phone Number: ";
            // 
            // customerPhoneSetInput
            // 
            this.customerPhoneSetInput.Location = new System.Drawing.Point(424, 147);
            this.customerPhoneSetInput.Name = "customerPhoneSetInput";
            this.customerPhoneSetInput.Size = new System.Drawing.Size(155, 20);
            this.customerPhoneSetInput.TabIndex = 10;
            // 
            // chooseOfficeLabel
            // 
            this.chooseOfficeLabel.AutoSize = true;
            this.chooseOfficeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseOfficeLabel.Location = new System.Drawing.Point(318, 174);
            this.chooseOfficeLabel.Name = "chooseOfficeLabel";
            this.chooseOfficeLabel.Size = new System.Drawing.Size(98, 16);
            this.chooseOfficeLabel.TabIndex = 11;
            this.chooseOfficeLabel.Text = "Choose Office: ";
            // 
            // officeListDropdown
            // 
            this.officeListDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.officeListDropdown.FormattingEnabled = true;
            this.officeListDropdown.Location = new System.Drawing.Point(424, 173);
            this.officeListDropdown.Name = "officeListDropdown";
            this.officeListDropdown.Size = new System.Drawing.Size(155, 21);
            this.officeListDropdown.TabIndex = 12;
            // 
            // setAppointmentButton
            // 
            this.setAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setAppointmentButton.Location = new System.Drawing.Point(382, 251);
            this.setAppointmentButton.Name = "setAppointmentButton";
            this.setAppointmentButton.Size = new System.Drawing.Size(136, 23);
            this.setAppointmentButton.TabIndex = 13;
            this.setAppointmentButton.Text = "Set Appointment";
            this.setAppointmentButton.UseVisualStyleBackColor = true;
            this.setAppointmentButton.Click += new System.EventHandler(this.setAppointmentButton_Click);
            // 
            // datePicker
            // 
            this.datePicker.Checked = false;
            this.datePicker.CustomFormat = "dd.MM.yyyy";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(424, 199);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(155, 20);
            this.datePicker.TabIndex = 15;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // chooseDateLabel
            // 
            this.chooseDateLabel.AutoSize = true;
            this.chooseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseDateLabel.Location = new System.Drawing.Point(318, 200);
            this.chooseDateLabel.Name = "chooseDateLabel";
            this.chooseDateLabel.Size = new System.Drawing.Size(93, 16);
            this.chooseDateLabel.TabIndex = 16;
            this.chooseDateLabel.Text = "Choose Date: ";
            // 
            // chooseTimeLabel
            // 
            this.chooseTimeLabel.AutoSize = true;
            this.chooseTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseTimeLabel.Location = new System.Drawing.Point(318, 226);
            this.chooseTimeLabel.Name = "chooseTimeLabel";
            this.chooseTimeLabel.Size = new System.Drawing.Size(95, 16);
            this.chooseTimeLabel.TabIndex = 17;
            this.chooseTimeLabel.Text = "Choose Time: ";
            // 
            // timePicker
            // 
            this.timePicker.Checked = false;
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(424, 225);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(155, 20);
            this.timePicker.TabIndex = 18;
            // 
            // licencePlateViewLabel
            // 
            this.licencePlateViewLabel.AutoSize = true;
            this.licencePlateViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.licencePlateViewLabel.Location = new System.Drawing.Point(318, 301);
            this.licencePlateViewLabel.Name = "licencePlateViewLabel";
            this.licencePlateViewLabel.Size = new System.Drawing.Size(95, 16);
            this.licencePlateViewLabel.TabIndex = 21;
            this.licencePlateViewLabel.Text = "Licence Plate: ";
            // 
            // licencePlateViewInput
            // 
            this.licencePlateViewInput.Location = new System.Drawing.Point(424, 300);
            this.licencePlateViewInput.Name = "licencePlateViewInput";
            this.licencePlateViewInput.Size = new System.Drawing.Size(155, 20);
            this.licencePlateViewInput.TabIndex = 22;
            // 
            // customerPhoneViewLabel
            // 
            this.customerPhoneViewLabel.AutoSize = true;
            this.customerPhoneViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerPhoneViewLabel.Location = new System.Drawing.Point(318, 327);
            this.customerPhoneViewLabel.Name = "customerPhoneViewLabel";
            this.customerPhoneViewLabel.Size = new System.Drawing.Size(104, 16);
            this.customerPhoneViewLabel.TabIndex = 23;
            this.customerPhoneViewLabel.Text = "Phone Number: ";
            // 
            // customerPhoneViewInput
            // 
            this.customerPhoneViewInput.Location = new System.Drawing.Point(424, 326);
            this.customerPhoneViewInput.Name = "customerPhoneViewInput";
            this.customerPhoneViewInput.Size = new System.Drawing.Size(155, 20);
            this.customerPhoneViewInput.TabIndex = 24;
            // 
            // viewAppointmentButton
            // 
            this.viewAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewAppointmentButton.Location = new System.Drawing.Point(382, 352);
            this.viewAppointmentButton.Name = "viewAppointmentButton";
            this.viewAppointmentButton.Size = new System.Drawing.Size(136, 23);
            this.viewAppointmentButton.TabIndex = 25;
            this.viewAppointmentButton.Text = "View Appointment";
            this.viewAppointmentButton.UseVisualStyleBackColor = true;
            this.viewAppointmentButton.Click += new System.EventHandler(this.viewAppointmentButton_Click);
            // 
            // employeePagePicture
            // 
            this.employeePagePicture.Image = ((System.Drawing.Image)(resources.GetObject("employeePagePicture.Image")));
            this.employeePagePicture.Location = new System.Drawing.Point(50, 107);
            this.employeePagePicture.Name = "employeePagePicture";
            this.employeePagePicture.Size = new System.Drawing.Size(256, 256);
            this.employeePagePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.employeePagePicture.TabIndex = 28;
            this.employeePagePicture.TabStop = false;
            // 
            // customerViewPage1
            // 
            this.customerViewPage1.Location = new System.Drawing.Point(-7, -30);
            this.customerViewPage1.loggedInId = 0;
            this.customerViewPage1.Name = "customerViewPage1";
            this.customerViewPage1.Size = new System.Drawing.Size(672, 481);
            this.customerViewPage1.TabIndex = 30;
            // 
            // employeeLoginPage1
            // 
            this.employeeLoginPage1.Location = new System.Drawing.Point(-7, -30);
            this.employeeLoginPage1.Name = "employeeLoginPage1";
            this.employeeLoginPage1.Size = new System.Drawing.Size(672, 481);
            this.employeeLoginPage1.TabIndex = 29;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 442);
            this.Controls.Add(this.customerViewPage1);
            this.Controls.Add(this.employeeLoginPage1);
            this.Controls.Add(this.employeePagePicture);
            this.Controls.Add(this.viewAppointmentButton);
            this.Controls.Add(this.customerPhoneViewInput);
            this.Controls.Add(this.customerPhoneViewLabel);
            this.Controls.Add(this.licencePlateViewInput);
            this.Controls.Add(this.licencePlateViewLabel);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.chooseTimeLabel);
            this.Controls.Add(this.chooseDateLabel);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.setAppointmentButton);
            this.Controls.Add(this.officeListDropdown);
            this.Controls.Add(this.chooseOfficeLabel);
            this.Controls.Add(this.customerPhoneSetInput);
            this.Controls.Add(this.customerPhoneSetLabel);
            this.Controls.Add(this.customerNameInput);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.licencePlateSetInput);
            this.Controls.Add(this.licencePlateSetLabel);
            this.Controls.Add(this.manageAppointmentsPageLabel);
            this.Controls.Add(this.employeeLoginPageButton);
            this.Icon = global::InsuranceSystem.Properties.Resources.app_icon;
            this.Name = "MainForm";
            this.Text = "Insurance System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeePagePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button employeeLoginPageButton;
        private System.Windows.Forms.Label manageAppointmentsPageLabel;
        private System.Windows.Forms.Label licencePlateSetLabel;
        private System.Windows.Forms.TextBox licencePlateSetInput;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameInput;
        private System.Windows.Forms.Label customerPhoneSetLabel;
        private System.Windows.Forms.TextBox customerPhoneSetInput;
        private System.Windows.Forms.Label chooseOfficeLabel;
        private System.Windows.Forms.ComboBox officeListDropdown;
        private System.Windows.Forms.Button setAppointmentButton;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label chooseDateLabel;
        private System.Windows.Forms.Label chooseTimeLabel;
        private System.Windows.Forms.DateTimePicker timePicker;
        private Label licencePlateViewLabel;
        private TextBox licencePlateViewInput;
        private Label customerPhoneViewLabel;
        private TextBox customerPhoneViewInput;
        private Button viewAppointmentButton;
        private PictureBox employeePagePicture;
        private EmployeeLoginPage employeeLoginPage1;
        private CustomerViewPage customerViewPage1;
    }
}


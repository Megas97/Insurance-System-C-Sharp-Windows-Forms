using System;

namespace InsuranceSystem
{
    partial class CustomerViewPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerViewPage));
            this.customerPageLabel = new System.Windows.Forms.Label();
            this.customerLicencePlateLabel = new System.Windows.Forms.Label();
            this.customerLicencePlateValue = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameValue = new System.Windows.Forms.Label();
            this.customerPhoneLabel = new System.Windows.Forms.Label();
            this.customerPhoneValue = new System.Windows.Forms.Label();
            this.officeLabel = new System.Windows.Forms.Label();
            this.officeListDropdown = new System.Windows.Forms.ComboBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.datePicker.MinDate = DateTime.Now;
            this.timeLabel = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.updateCustomerInfoButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.deleteAppointmentButton = new System.Windows.Forms.Button();
            this.customerStatusLabel = new System.Windows.Forms.Label();
            this.customerStatusValue = new System.Windows.Forms.Label();
            this.employeePagePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeePagePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // customerPageLabel
            // 
            this.customerPageLabel.AutoSize = true;
            this.customerPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerPageLabel.Location = new System.Drawing.Point(237, 32);
            this.customerPageLabel.Name = "customerPageLabel";
            this.customerPageLabel.Size = new System.Drawing.Size(202, 31);
            this.customerPageLabel.TabIndex = 2;
            this.customerPageLabel.Text = "Customer Page";
            // 
            // customerLicencePlateLabel
            // 
            this.customerLicencePlateLabel.AutoSize = true;
            this.customerLicencePlateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerLicencePlateLabel.Location = new System.Drawing.Point(332, 118);
            this.customerLicencePlateLabel.Name = "customerLicencePlateLabel";
            this.customerLicencePlateLabel.Size = new System.Drawing.Size(95, 16);
            this.customerLicencePlateLabel.TabIndex = 6;
            this.customerLicencePlateLabel.Text = "Licence Plate: ";
            // 
            // customerLicencePlateValue
            // 
            this.customerLicencePlateValue.AutoSize = true;
            this.customerLicencePlateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerLicencePlateValue.Location = new System.Drawing.Point(436, 118);
            this.customerLicencePlateValue.Name = "customerLicencePlateValue";
            this.customerLicencePlateValue.Size = new System.Drawing.Size(0, 16);
            this.customerLicencePlateValue.TabIndex = 7;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerNameLabel.Location = new System.Drawing.Point(332, 144);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(111, 16);
            this.customerNameLabel.TabIndex = 8;
            this.customerNameLabel.Text = "Customer Name: ";
            // 
            // customerNameValue
            // 
            this.customerNameValue.AutoSize = true;
            this.customerNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerNameValue.Location = new System.Drawing.Point(436, 144);
            this.customerNameValue.Name = "customerNameValue";
            this.customerNameValue.Size = new System.Drawing.Size(0, 16);
            this.customerNameValue.TabIndex = 9;
            // 
            // customerPhoneLabel
            // 
            this.customerPhoneLabel.AutoSize = true;
            this.customerPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerPhoneLabel.Location = new System.Drawing.Point(332, 170);
            this.customerPhoneLabel.Name = "customerPhoneLabel";
            this.customerPhoneLabel.Size = new System.Drawing.Size(104, 16);
            this.customerPhoneLabel.TabIndex = 10;
            this.customerPhoneLabel.Text = "Phone Number: ";
            // 
            // customerPhoneValue
            // 
            this.customerPhoneValue.AutoSize = true;
            this.customerPhoneValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerPhoneValue.Location = new System.Drawing.Point(439, 170);
            this.customerPhoneValue.Name = "customerPhoneValue";
            this.customerPhoneValue.Size = new System.Drawing.Size(0, 16);
            this.customerPhoneValue.TabIndex = 11;
            // 
            // officeLabel
            // 
            this.officeLabel.AutoSize = true;
            this.officeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.officeLabel.Location = new System.Drawing.Point(333, 196);
            this.officeLabel.Name = "officeLabel";
            this.officeLabel.Size = new System.Drawing.Size(48, 16);
            this.officeLabel.TabIndex = 12;
            this.officeLabel.Text = "Office: ";
            // 
            // officeListDropdown
            // 
            this.officeListDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.officeListDropdown.FormattingEnabled = true;
            this.officeListDropdown.Location = new System.Drawing.Point(439, 195);
            this.officeListDropdown.Name = "officeListDropdown";
            this.officeListDropdown.Size = new System.Drawing.Size(155, 21);
            this.officeListDropdown.TabIndex = 13;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(333, 248);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(43, 16);
            this.dateLabel.TabIndex = 17;
            this.dateLabel.Text = "Date: ";
            // 
            // datePicker
            // 
            this.datePicker.Checked = false;
            this.datePicker.CustomFormat = "dd.MM.yyyy";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(439, 247);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(155, 20);
            this.datePicker.TabIndex = 18;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(333, 274);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(45, 16);
            this.timeLabel.TabIndex = 19;
            this.timeLabel.Text = "Time: ";
            // 
            // timePicker
            // 
            this.timePicker.Checked = false;
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(439, 273);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(155, 20);
            this.timePicker.TabIndex = 20;
            // 
            // updateCustomerInfoButton
            // 
            this.updateCustomerInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateCustomerInfoButton.Location = new System.Drawing.Point(396, 300);
            this.updateCustomerInfoButton.Name = "updateCustomerInfoButton";
            this.updateCustomerInfoButton.Size = new System.Drawing.Size(136, 23);
            this.updateCustomerInfoButton.TabIndex = 21;
            this.updateCustomerInfoButton.Text = "Update Information";
            this.updateCustomerInfoButton.UseVisualStyleBackColor = true;
            this.updateCustomerInfoButton.Click += new System.EventHandler(this.updateCustomerInfoButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBackButton.Location = new System.Drawing.Point(427, 389);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 34);
            this.goBackButton.TabIndex = 22;
            this.goBackButton.Text = "Back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // deleteAppointmentButton
            // 
            this.deleteAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteAppointmentButton.Location = new System.Drawing.Point(396, 326);
            this.deleteAppointmentButton.Name = "deleteAppointmentButton";
            this.deleteAppointmentButton.Size = new System.Drawing.Size(136, 23);
            this.deleteAppointmentButton.TabIndex = 23;
            this.deleteAppointmentButton.Text = "Delete Appointment";
            this.deleteAppointmentButton.UseVisualStyleBackColor = true;
            this.deleteAppointmentButton.Click += new System.EventHandler(this.deleteAppointmentButton_Click);
            // 
            // customerStatusLabel
            // 
            this.customerStatusLabel.AutoSize = true;
            this.customerStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerStatusLabel.Location = new System.Drawing.Point(333, 222);
            this.customerStatusLabel.Name = "customerStatusLabel";
            this.customerStatusLabel.Size = new System.Drawing.Size(51, 16);
            this.customerStatusLabel.TabIndex = 24;
            this.customerStatusLabel.Text = "Status: ";
            // 
            // customerStatusValue
            // 
            this.customerStatusValue.AutoSize = true;
            this.customerStatusValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerStatusValue.Location = new System.Drawing.Point(439, 222);
            this.customerStatusValue.Name = "customerStatusValue";
            this.customerStatusValue.Size = new System.Drawing.Size(0, 16);
            this.customerStatusValue.TabIndex = 25;
            // 
            // employeePagePicture
            // 
            this.employeePagePicture.Image = ((System.Drawing.Image)(resources.GetObject("employeePagePicture.Image")));
            this.employeePagePicture.Location = new System.Drawing.Point(50, 107);
            this.employeePagePicture.Name = "employeePagePicture";
            this.employeePagePicture.Size = new System.Drawing.Size(256, 256);
            this.employeePagePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.employeePagePicture.TabIndex = 26;
            this.employeePagePicture.TabStop = false;
            // 
            // CustomerViewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.employeePagePicture);
            this.Controls.Add(this.customerStatusValue);
            this.Controls.Add(this.customerStatusLabel);
            this.Controls.Add(this.deleteAppointmentButton);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.updateCustomerInfoButton);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.officeListDropdown);
            this.Controls.Add(this.officeLabel);
            this.Controls.Add(this.customerPhoneValue);
            this.Controls.Add(this.customerPhoneLabel);
            this.Controls.Add(this.customerNameValue);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.customerLicencePlateValue);
            this.Controls.Add(this.customerLicencePlateLabel);
            this.Controls.Add(this.customerPageLabel);
            this.Name = "CustomerViewPage";
            this.Size = new System.Drawing.Size(672, 481);
            ((System.ComponentModel.ISupportInitialize)(this.employeePagePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerPageLabel;
        private System.Windows.Forms.Label customerLicencePlateLabel;
        private System.Windows.Forms.Label customerLicencePlateValue;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label customerNameValue;
        private System.Windows.Forms.Label customerPhoneLabel;
        private System.Windows.Forms.Label customerPhoneValue;
        private System.Windows.Forms.Label officeLabel;
        private System.Windows.Forms.ComboBox officeListDropdown;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Button updateCustomerInfoButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button deleteAppointmentButton;
        private System.Windows.Forms.Label customerStatusLabel;
        private System.Windows.Forms.Label customerStatusValue;
        private System.Windows.Forms.PictureBox employeePagePicture;
    }
}

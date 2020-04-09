using System.Windows.Forms;

namespace InsuranceSystem
{
    partial class EmployeeMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeMainPage));
            this.employeeLogout = new System.Windows.Forms.Button();
            this.employeePageLabel = new System.Windows.Forms.Label();
            this.officeNameLabel = new System.Windows.Forms.Label();
            this.officeNameInput = new System.Windows.Forms.TextBox();
            this.officeLocationInput = new System.Windows.Forms.TextBox();
            this.officeLocationLabel = new System.Windows.Forms.Label();
            this.officeDirectorInput = new System.Windows.Forms.TextBox();
            this.officeDirectorLabel = new System.Windows.Forms.Label();
            this.updateOfficeInfoButton = new System.Windows.Forms.Button();
            this.customerListLabel = new System.Windows.Forms.Label();
            this.customerListDropdown = new System.Windows.Forms.ComboBox();
            this.customerStatusLabel = new System.Windows.Forms.Label();
            this.customerStatusDropdown = new System.Windows.Forms.ComboBox();
            this.updateCustomerButton = new System.Windows.Forms.Button();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.employeePagePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeePagePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeLogout
            // 
            this.employeeLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeLogout.Location = new System.Drawing.Point(432, 389);
            this.employeeLogout.Name = "employeeLogout";
            this.employeeLogout.Size = new System.Drawing.Size(76, 34);
            this.employeeLogout.TabIndex = 0;
            this.employeeLogout.Text = "Logout";
            this.employeeLogout.UseVisualStyleBackColor = true;
            this.employeeLogout.Click += new System.EventHandler(this.employeeLogout_Click);
            // 
            // employeePageLabel
            // 
            this.employeePageLabel.AutoSize = true;
            this.employeePageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeePageLabel.Location = new System.Drawing.Point(234, 32);
            this.employeePageLabel.Name = "employeePageLabel";
            this.employeePageLabel.Size = new System.Drawing.Size(204, 31);
            this.employeePageLabel.TabIndex = 1;
            this.employeePageLabel.Text = "Employee Page";
            // 
            // officeNameLabel
            // 
            this.officeNameLabel.AutoSize = true;
            this.officeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.officeNameLabel.Location = new System.Drawing.Point(341, 120);
            this.officeNameLabel.Name = "officeNameLabel";
            this.officeNameLabel.Size = new System.Drawing.Size(88, 16);
            this.officeNameLabel.TabIndex = 2;
            this.officeNameLabel.Text = "Office Name: ";
            // 
            // officeNameInput
            // 
            this.officeNameInput.Location = new System.Drawing.Point(439, 119);
            this.officeNameInput.Name = "officeNameInput";
            this.officeNameInput.Size = new System.Drawing.Size(155, 20);
            this.officeNameInput.TabIndex = 3;
            // 
            // officeLocationInput
            // 
            this.officeLocationInput.Location = new System.Drawing.Point(439, 145);
            this.officeLocationInput.Name = "officeLocationInput";
            this.officeLocationInput.Size = new System.Drawing.Size(155, 20);
            this.officeLocationInput.TabIndex = 5;
            // 
            // officeLocationLabel
            // 
            this.officeLocationLabel.AutoSize = true;
            this.officeLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.officeLocationLabel.Location = new System.Drawing.Point(341, 146);
            this.officeLocationLabel.Name = "officeLocationLabel";
            this.officeLocationLabel.Size = new System.Drawing.Size(102, 16);
            this.officeLocationLabel.TabIndex = 4;
            this.officeLocationLabel.Text = "Office Location: ";
            // 
            // officeDirectorInput
            // 
            this.officeDirectorInput.Location = new System.Drawing.Point(439, 171);
            this.officeDirectorInput.Name = "officeDirectorInput";
            this.officeDirectorInput.Size = new System.Drawing.Size(155, 20);
            this.officeDirectorInput.TabIndex = 7;
            // 
            // officeDirectorLabel
            // 
            this.officeDirectorLabel.AutoSize = true;
            this.officeDirectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.officeDirectorLabel.Location = new System.Drawing.Point(341, 172);
            this.officeDirectorLabel.Name = "officeDirectorLabel";
            this.officeDirectorLabel.Size = new System.Drawing.Size(98, 16);
            this.officeDirectorLabel.TabIndex = 6;
            this.officeDirectorLabel.Text = "Office Director: ";
            // 
            // updateOfficeInfoButton
            // 
            this.updateOfficeInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateOfficeInfoButton.Location = new System.Drawing.Point(409, 197);
            this.updateOfficeInfoButton.Name = "updateOfficeInfoButton";
            this.updateOfficeInfoButton.Size = new System.Drawing.Size(136, 23);
            this.updateOfficeInfoButton.TabIndex = 8;
            this.updateOfficeInfoButton.Text = "Update Information";
            this.updateOfficeInfoButton.UseVisualStyleBackColor = true;
            this.updateOfficeInfoButton.Click += new System.EventHandler(this.updateOfficeInfoButton_Click);
            // 
            // customerListLabel
            // 
            this.customerListLabel.AutoSize = true;
            this.customerListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerListLabel.Location = new System.Drawing.Point(341, 246);
            this.customerListLabel.Name = "customerListLabel";
            this.customerListLabel.Size = new System.Drawing.Size(71, 16);
            this.customerListLabel.TabIndex = 9;
            this.customerListLabel.Text = "Customer: ";
            // 
            // customerListDropdown
            // 
            this.customerListDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerListDropdown.FormattingEnabled = true;
            this.customerListDropdown.Location = new System.Drawing.Point(439, 244);
            this.customerListDropdown.Name = "customerListDropdown";
            this.customerListDropdown.Size = new System.Drawing.Size(155, 21);
            this.customerListDropdown.TabIndex = 10;
            this.customerListDropdown.SelectedIndexChanged += new System.EventHandler(this.customerListDropdown_SelectedIndexChanged);
            // 
            // customerStatusLabel
            // 
            this.customerStatusLabel.AutoSize = true;
            this.customerStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerStatusLabel.Location = new System.Drawing.Point(341, 274);
            this.customerStatusLabel.Name = "customerStatusLabel";
            this.customerStatusLabel.Size = new System.Drawing.Size(51, 16);
            this.customerStatusLabel.TabIndex = 11;
            this.customerStatusLabel.Text = "Status: ";
            // 
            // customerStatusDropdown
            // 
            this.customerStatusDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerStatusDropdown.FormattingEnabled = true;
            this.customerStatusDropdown.Items.AddRange(new object[] {
            "Booked",
            "Waiting",
            "Processing",
            "Finished"});
            this.customerStatusDropdown.Location = new System.Drawing.Point(439, 271);
            this.customerStatusDropdown.Name = "customerStatusDropdown";
            this.customerStatusDropdown.Size = new System.Drawing.Size(155, 21);
            this.customerStatusDropdown.TabIndex = 12;
            // 
            // updateCustomerButton
            // 
            this.updateCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateCustomerButton.Location = new System.Drawing.Point(401, 298);
            this.updateCustomerButton.Name = "updateCustomerButton";
            this.updateCustomerButton.Size = new System.Drawing.Size(136, 23);
            this.updateCustomerButton.TabIndex = 13;
            this.updateCustomerButton.Text = "Update Customer";
            this.updateCustomerButton.UseVisualStyleBackColor = true;
            this.updateCustomerButton.Click += new System.EventHandler(this.updateCustomerButton_Click);
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteCustomerButton.Location = new System.Drawing.Point(401, 327);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(136, 23);
            this.deleteCustomerButton.TabIndex = 14;
            this.deleteCustomerButton.Text = "Delete Customer";
            this.deleteCustomerButton.UseVisualStyleBackColor = true;
            this.deleteCustomerButton.Click += new System.EventHandler(this.deleteCustomerButton_Click);
            // 
            // employeePagePicture
            // 
            this.employeePagePicture.Image = ((System.Drawing.Image)(resources.GetObject("employeePagePicture.Image")));
            this.employeePagePicture.Location = new System.Drawing.Point(50, 107);
            this.employeePagePicture.Name = "employeePagePicture";
            this.employeePagePicture.Size = new System.Drawing.Size(256, 256);
            this.employeePagePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.employeePagePicture.TabIndex = 15;
            this.employeePagePicture.TabStop = false;
            // 
            // EmployeeMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.employeePagePicture);
            this.Controls.Add(this.deleteCustomerButton);
            this.Controls.Add(this.updateCustomerButton);
            this.Controls.Add(this.customerStatusDropdown);
            this.Controls.Add(this.customerStatusLabel);
            this.Controls.Add(this.customerListDropdown);
            this.Controls.Add(this.customerListLabel);
            this.Controls.Add(this.updateOfficeInfoButton);
            this.Controls.Add(this.officeDirectorInput);
            this.Controls.Add(this.officeDirectorLabel);
            this.Controls.Add(this.officeLocationInput);
            this.Controls.Add(this.officeLocationLabel);
            this.Controls.Add(this.officeNameInput);
            this.Controls.Add(this.officeNameLabel);
            this.Controls.Add(this.employeePageLabel);
            this.Controls.Add(this.employeeLogout);
            this.Name = "EmployeeMainPage";
            this.Size = new System.Drawing.Size(672, 481);
            ((System.ComponentModel.ISupportInitialize)(this.employeePagePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button employeeLogout;
        private System.Windows.Forms.Label employeePageLabel;
        private System.Windows.Forms.Label officeNameLabel;
        private System.Windows.Forms.TextBox officeNameInput;
        private System.Windows.Forms.TextBox officeLocationInput;
        private System.Windows.Forms.Label officeLocationLabel;
        private System.Windows.Forms.TextBox officeDirectorInput;
        private System.Windows.Forms.Label officeDirectorLabel;
        private System.Windows.Forms.Button updateOfficeInfoButton;
        private System.Windows.Forms.Label customerListLabel;
        private System.Windows.Forms.ComboBox customerListDropdown;
        private System.Windows.Forms.Label customerStatusLabel;
        private System.Windows.Forms.ComboBox customerStatusDropdown;
        private System.Windows.Forms.Button updateCustomerButton;
        private System.Windows.Forms.Button deleteCustomerButton;
        private PictureBox employeePagePicture;
    }
}

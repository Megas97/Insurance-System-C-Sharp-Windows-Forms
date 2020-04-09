namespace InsuranceSystem
{
    partial class EmployeeLoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeLoginPage));
            this.employeeLoginLabel = new System.Windows.Forms.Label();
            this.employeeBackButton = new System.Windows.Forms.Button();
            this.employeeUsernameLabel = new System.Windows.Forms.Label();
            this.employeeUsernameInput = new System.Windows.Forms.TextBox();
            this.employeePasswordInput = new System.Windows.Forms.TextBox();
            this.employeePasswordLabel = new System.Windows.Forms.Label();
            this.employeeLoginButton = new System.Windows.Forms.Button();
            this.employeeLoginPicture = new System.Windows.Forms.PictureBox();
            this.employeeMainPage1 = new InsuranceSystem.EmployeeMainPage();
            ((System.ComponentModel.ISupportInitialize)(this.employeeLoginPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeLoginLabel
            // 
            this.employeeLoginLabel.AutoSize = true;
            this.employeeLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeLoginLabel.Location = new System.Drawing.Point(234, 32);
            this.employeeLoginLabel.Name = "employeeLoginLabel";
            this.employeeLoginLabel.Size = new System.Drawing.Size(207, 31);
            this.employeeLoginLabel.TabIndex = 0;
            this.employeeLoginLabel.Text = "Employee Login";
            // 
            // employeeBackButton
            // 
            this.employeeBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeBackButton.Location = new System.Drawing.Point(372, 258);
            this.employeeBackButton.Name = "employeeBackButton";
            this.employeeBackButton.Size = new System.Drawing.Size(75, 34);
            this.employeeBackButton.TabIndex = 1;
            this.employeeBackButton.Text = "Back";
            this.employeeBackButton.UseVisualStyleBackColor = true;
            this.employeeBackButton.Click += new System.EventHandler(this.employeeBackButton_Click);
            // 
            // employeeUsernameLabel
            // 
            this.employeeUsernameLabel.AutoSize = true;
            this.employeeUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeUsernameLabel.Location = new System.Drawing.Point(368, 163);
            this.employeeUsernameLabel.Name = "employeeUsernameLabel";
            this.employeeUsernameLabel.Size = new System.Drawing.Size(107, 24);
            this.employeeUsernameLabel.TabIndex = 2;
            this.employeeUsernameLabel.Text = "Username: ";
            // 
            // employeeUsernameInput
            // 
            this.employeeUsernameInput.Location = new System.Drawing.Point(473, 166);
            this.employeeUsernameInput.Name = "employeeUsernameInput";
            this.employeeUsernameInput.Size = new System.Drawing.Size(127, 20);
            this.employeeUsernameInput.TabIndex = 3;
            // 
            // employeePasswordInput
            // 
            this.employeePasswordInput.Location = new System.Drawing.Point(473, 206);
            this.employeePasswordInput.Name = "employeePasswordInput";
            this.employeePasswordInput.PasswordChar = '*';
            this.employeePasswordInput.Size = new System.Drawing.Size(127, 20);
            this.employeePasswordInput.TabIndex = 5;
            // 
            // employeePasswordLabel
            // 
            this.employeePasswordLabel.AutoSize = true;
            this.employeePasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeePasswordLabel.Location = new System.Drawing.Point(368, 203);
            this.employeePasswordLabel.Name = "employeePasswordLabel";
            this.employeePasswordLabel.Size = new System.Drawing.Size(102, 24);
            this.employeePasswordLabel.TabIndex = 4;
            this.employeePasswordLabel.Text = "Password: ";
            // 
            // employeeLoginButton
            // 
            this.employeeLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeLoginButton.Location = new System.Drawing.Point(525, 258);
            this.employeeLoginButton.Name = "employeeLoginButton";
            this.employeeLoginButton.Size = new System.Drawing.Size(75, 34);
            this.employeeLoginButton.TabIndex = 6;
            this.employeeLoginButton.Text = "Login";
            this.employeeLoginButton.UseVisualStyleBackColor = true;
            this.employeeLoginButton.Click += new System.EventHandler(this.employeeLoginButton_Click);
            // 
            // employeeLoginPicture
            // 
            this.employeeLoginPicture.Image = ((System.Drawing.Image)(resources.GetObject("employeeLoginPicture.Image")));
            this.employeeLoginPicture.Location = new System.Drawing.Point(50, 107);
            this.employeeLoginPicture.Name = "employeeLoginPicture";
            this.employeeLoginPicture.Size = new System.Drawing.Size(256, 256);
            this.employeeLoginPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.employeeLoginPicture.TabIndex = 7;
            this.employeeLoginPicture.TabStop = false;
            // 
            // employeeMainPage1
            // 
            this.employeeMainPage1.Location = new System.Drawing.Point(0, 0);
            this.employeeMainPage1.loggedInId = 0;
            this.employeeMainPage1.Name = "employeeMainPage1";
            this.employeeMainPage1.Size = new System.Drawing.Size(672, 481);
            this.employeeMainPage1.TabIndex = 8;
            // 
            // EmployeeLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.employeeMainPage1);
            this.Controls.Add(this.employeeLoginPicture);
            this.Controls.Add(this.employeeLoginButton);
            this.Controls.Add(this.employeePasswordInput);
            this.Controls.Add(this.employeePasswordLabel);
            this.Controls.Add(this.employeeUsernameInput);
            this.Controls.Add(this.employeeUsernameLabel);
            this.Controls.Add(this.employeeBackButton);
            this.Controls.Add(this.employeeLoginLabel);
            this.Name = "EmployeeLoginPage";
            this.Size = new System.Drawing.Size(672, 481);
            ((System.ComponentModel.ISupportInitialize)(this.employeeLoginPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeLoginLabel;
        private System.Windows.Forms.Button employeeBackButton;
        private System.Windows.Forms.Label employeeUsernameLabel;
        private System.Windows.Forms.TextBox employeeUsernameInput;
        private System.Windows.Forms.TextBox employeePasswordInput;
        private System.Windows.Forms.Label employeePasswordLabel;
        private System.Windows.Forms.Button employeeLoginButton;
        private System.Windows.Forms.PictureBox employeeLoginPicture;
        private EmployeeMainPage employeeMainPage1;
    }
}

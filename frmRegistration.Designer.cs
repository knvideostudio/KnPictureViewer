namespace KnPictureViewer
{
    partial class frmRegistration
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
            this.components = new System.ComponentModel.Container();
            this.grpRegBox = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.errValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtEncrypt = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.grpRegBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errValidator)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRegBox
            // 
            this.grpRegBox.Controls.Add(this.btnClose);
            this.grpRegBox.Controls.Add(this.txtPhone);
            this.grpRegBox.Controls.Add(this.label10);
            this.grpRegBox.Controls.Add(this.txtCountry);
            this.grpRegBox.Controls.Add(this.label9);
            this.grpRegBox.Controls.Add(this.txtState);
            this.grpRegBox.Controls.Add(this.label8);
            this.grpRegBox.Controls.Add(this.txtZipCode);
            this.grpRegBox.Controls.Add(this.txtCity);
            this.grpRegBox.Controls.Add(this.label7);
            this.grpRegBox.Controls.Add(this.txtAddress2);
            this.grpRegBox.Controls.Add(this.label6);
            this.grpRegBox.Controls.Add(this.txtAddress1);
            this.grpRegBox.Controls.Add(this.txtEmail);
            this.grpRegBox.Controls.Add(this.lblEmail);
            this.grpRegBox.Controls.Add(this.label4);
            this.grpRegBox.Controls.Add(this.txtCompany);
            this.grpRegBox.Controls.Add(this.txtLastName);
            this.grpRegBox.Controls.Add(this.label3);
            this.grpRegBox.Controls.Add(this.lblLastName);
            this.grpRegBox.Controls.Add(this.txtFirstName);
            this.grpRegBox.Controls.Add(this.lblFirstName);
            this.grpRegBox.Controls.Add(this.btnRegister);
            this.grpRegBox.Location = new System.Drawing.Point(12, 12);
            this.grpRegBox.Name = "grpRegBox";
            this.grpRegBox.Size = new System.Drawing.Size(409, 370);
            this.grpRegBox.TabIndex = 0;
            this.grpRegBox.TabStop = false;
            this.grpRegBox.Text = "Activation";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(193, 330);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 27);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(127, 292);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(140, 22);
            this.txtPhone.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Phone:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(127, 264);
            this.txtCountry.MaxLength = 255;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(239, 22);
            this.txtCountry.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Country:";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(127, 236);
            this.txtState.MaxLength = 255;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(239, 22);
            this.txtState.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "State:";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(273, 208);
            this.txtZipCode.MaxLength = 15;
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(93, 22);
            this.txtZipCode.TabIndex = 15;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(127, 208);
            this.txtCity.MaxLength = 120;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(140, 22);
            this.txtCity.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "City / Zip:";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(127, 180);
            this.txtAddress2.MaxLength = 255;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(239, 22);
            this.txtAddress2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Address Cont:";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(127, 152);
            this.txtAddress1.MaxLength = 255;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(239, 22);
            this.txtAddress1.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(127, 91);
            this.txtEmail.MaxLength = 255;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(239, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(31, 94);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 17);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address:";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(127, 119);
            this.txtCompany.MaxLength = 255;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(239, 22);
            this.txtCompany.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(127, 61);
            this.txtLastName.MaxLength = 35;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(140, 22);
            this.txtLastName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Company:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(31, 66);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 17);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(127, 34);
            this.txtFirstName.MaxLength = 35;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(140, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(31, 37);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 17);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(262, 330);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(104, 27);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // errValidator
            // 
            this.errValidator.ContainerControl = this;
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Location = new System.Drawing.Point(12, 397);
            this.txtEncrypt.MaxLength = 1000;
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.Size = new System.Drawing.Size(473, 22);
            this.txtEncrypt.TabIndex = 20;

            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(12, 425);
            this.txtText.MaxLength = 1000;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(473, 22);
            this.txtText.TabIndex = 21;

            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 481);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.txtEncrypt);
            this.Controls.Add(this.grpRegBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistration";
            this.Text = "KnPictureViewer Registration Form";

            this.grpRegBox.ResumeLayout(false);
            this.grpRegBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errValidator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRegBox;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ErrorProvider errValidator;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtEncrypt;
        private System.Windows.Forms.TextBox txtText;
    }
}
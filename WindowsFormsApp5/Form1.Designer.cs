
namespace WindowsFormsApp5
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameFirst = new System.Windows.Forms.Label();
            this.lblNameLast = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.txtboxNameFirst = new System.Windows.Forms.TextBox();
            this.txtboxNameLast = new System.Windows.Forms.TextBox();
            this.txtboxMail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRedStar1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtonFemaleGender = new System.Windows.Forms.RadioButton();
            this.RadioButtonMaleGender = new System.Windows.Forms.RadioButton();
            this.checkboxShowPassword = new System.Windows.Forms.CheckBox();
            this.btnJsonClick = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxJsonUsername = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(405, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 24);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblNameFirst
            // 
            this.lblNameFirst.AutoSize = true;
            this.lblNameFirst.BackColor = System.Drawing.Color.Transparent;
            this.lblNameFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFirst.Location = new System.Drawing.Point(411, 100);
            this.lblNameFirst.Name = "lblNameFirst";
            this.lblNameFirst.Size = new System.Drawing.Size(33, 16);
            this.lblNameFirst.TabIndex = 3;
            this.lblNameFirst.Text = "First";
            // 
            // lblNameLast
            // 
            this.lblNameLast.AutoSize = true;
            this.lblNameLast.BackColor = System.Drawing.Color.Transparent;
            this.lblNameLast.Location = new System.Drawing.Point(543, 100);
            this.lblNameLast.Name = "lblNameLast";
            this.lblNameLast.Size = new System.Drawing.Size(27, 13);
            this.lblNameLast.TabIndex = 5;
            this.lblNameLast.Text = "Last";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(405, 117);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(105, 24);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username";
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUsername.Location = new System.Drawing.Point(414, 144);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(228, 29);
            this.txtboxUsername.TabIndex = 2;
            this.txtboxUsername.TextChanged += new System.EventHandler(this.txtboxUsername_TextChanged);
            // 
            // txtboxNameFirst
            // 
            this.txtboxNameFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNameFirst.Location = new System.Drawing.Point(414, 71);
            this.txtboxNameFirst.Name = "txtboxNameFirst";
            this.txtboxNameFirst.Size = new System.Drawing.Size(96, 26);
            this.txtboxNameFirst.TabIndex = 0;
            this.txtboxNameFirst.TextChanged += new System.EventHandler(this.txtboxNameFirst_TextChanged);
            // 
            // txtboxNameLast
            // 
            this.txtboxNameLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNameLast.Location = new System.Drawing.Point(546, 71);
            this.txtboxNameLast.Name = "txtboxNameLast";
            this.txtboxNameLast.Size = new System.Drawing.Size(96, 26);
            this.txtboxNameLast.TabIndex = 1;
            this.txtboxNameLast.TextChanged += new System.EventHandler(this.txtboxNameFirst_TextChanged);
            // 
            // txtboxMail
            // 
            this.txtboxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxMail.Location = new System.Drawing.Point(419, 216);
            this.txtboxMail.Name = "txtboxMail";
            this.txtboxMail.Size = new System.Drawing.Size(228, 29);
            this.txtboxMail.TabIndex = 3;
            this.txtboxMail.TextChanged += new System.EventHandler(this.txtboxMail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(410, 189);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 24);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "E-Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 33);
            this.label2.TabIndex = 14;
            this.label2.Text = "Register";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Blue;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Red;
            this.btnRegister.Location = new System.Drawing.Point(409, 441);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(238, 42);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Sumbit";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            this.btnRegister.MouseLeave += new System.EventHandler(this.btnRegister_MouseLeave);
            this.btnRegister.MouseHover += new System.EventHandler(this.btnRegister_MouseHover);
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPassword.Location = new System.Drawing.Point(419, 288);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '*';
            this.txtboxPassword.Size = new System.Drawing.Size(228, 29);
            this.txtboxPassword.TabIndex = 4;
            this.txtboxPassword.TextChanged += new System.EventHandler(this.txtboxPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(410, 261);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 24);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password";
            // 
            // lblRedStar1
            // 
            this.lblRedStar1.AutoSize = true;
            this.lblRedStar1.BackColor = System.Drawing.Color.Transparent;
            this.lblRedStar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedStar1.ForeColor = System.Drawing.Color.Red;
            this.lblRedStar1.Location = new System.Drawing.Point(464, 42);
            this.lblRedStar1.Name = "lblRedStar1";
            this.lblRedStar1.Size = new System.Drawing.Size(15, 20);
            this.lblRedStar1.TabIndex = 17;
            this.lblRedStar1.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(506, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(476, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(506, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "*";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(415, 350);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(80, 24);
            this.lblGender.TabIndex = 21;
            this.lblGender.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(491, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "*";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.RadioButtonFemaleGender);
            this.groupBox1.Controls.Add(this.RadioButtonMaleGender);
            this.groupBox1.Location = new System.Drawing.Point(424, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 42);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // RadioButtonFemaleGender
            // 
            this.RadioButtonFemaleGender.AutoSize = true;
            this.RadioButtonFemaleGender.BackColor = System.Drawing.Color.Transparent;
            this.RadioButtonFemaleGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonFemaleGender.Location = new System.Drawing.Point(127, 14);
            this.RadioButtonFemaleGender.Name = "RadioButtonFemaleGender";
            this.RadioButtonFemaleGender.Size = new System.Drawing.Size(81, 22);
            this.RadioButtonFemaleGender.TabIndex = 7;
            this.RadioButtonFemaleGender.TabStop = true;
            this.RadioButtonFemaleGender.Text = "Female";
            this.RadioButtonFemaleGender.UseVisualStyleBackColor = false;
            this.RadioButtonFemaleGender.CheckedChanged += new System.EventHandler(this.RadioButtonMaleGender_CheckedChanged);
            // 
            // RadioButtonMaleGender
            // 
            this.RadioButtonMaleGender.AutoSize = true;
            this.RadioButtonMaleGender.BackColor = System.Drawing.Color.Transparent;
            this.RadioButtonMaleGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonMaleGender.Location = new System.Drawing.Point(29, 14);
            this.RadioButtonMaleGender.Name = "RadioButtonMaleGender";
            this.RadioButtonMaleGender.Size = new System.Drawing.Size(62, 22);
            this.RadioButtonMaleGender.TabIndex = 6;
            this.RadioButtonMaleGender.TabStop = true;
            this.RadioButtonMaleGender.Text = "Male";
            this.RadioButtonMaleGender.UseVisualStyleBackColor = false;
            this.RadioButtonMaleGender.CheckedChanged += new System.EventHandler(this.RadioButtonMaleGender_CheckedChanged);
            // 
            // checkboxShowPassword
            // 
            this.checkboxShowPassword.AutoSize = true;
            this.checkboxShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.checkboxShowPassword.Location = new System.Drawing.Point(419, 324);
            this.checkboxShowPassword.Name = "checkboxShowPassword";
            this.checkboxShowPassword.Size = new System.Drawing.Size(102, 17);
            this.checkboxShowPassword.TabIndex = 5;
            this.checkboxShowPassword.Text = "Show Password";
            this.checkboxShowPassword.UseVisualStyleBackColor = false;
            this.checkboxShowPassword.CheckedChanged += new System.EventHandler(this.checkboxShowPassword_CheckedChanged);
            // 
            // btnJsonClick
            // 
            this.btnJsonClick.BackColor = System.Drawing.Color.Blue;
            this.btnJsonClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJsonClick.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnJsonClick.FlatAppearance.BorderSize = 0;
            this.btnJsonClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJsonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJsonClick.ForeColor = System.Drawing.Color.Red;
            this.btnJsonClick.Location = new System.Drawing.Point(409, 561);
            this.btnJsonClick.Name = "btnJsonClick";
            this.btnJsonClick.Size = new System.Drawing.Size(238, 42);
            this.btnJsonClick.TabIndex = 10;
            this.btnJsonClick.Text = "Load Json File";
            this.btnJsonClick.UseVisualStyleBackColor = false;
            this.btnJsonClick.Click += new System.EventHandler(this.btnJsonClick_Click);
            this.btnJsonClick.MouseLeave += new System.EventHandler(this.btnRegister_MouseLeave);
            this.btnJsonClick.MouseHover += new System.EventHandler(this.btnRegister_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(405, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Enter FileName";
            // 
            // txtboxJsonUsername
            // 
            this.txtboxJsonUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxJsonUsername.Location = new System.Drawing.Point(424, 526);
            this.txtboxJsonUsername.Name = "txtboxJsonUsername";
            this.txtboxJsonUsername.Size = new System.Drawing.Size(301, 29);
            this.txtboxJsonUsername.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.photo_1515787366009_7cbdd2dc587b;
            this.ClientSize = new System.Drawing.Size(1005, 620);
            this.Controls.Add(this.txtboxJsonUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnJsonClick);
            this.Controls.Add(this.checkboxShowPassword);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRedStar1);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtboxMail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtboxNameLast);
            this.Controls.Add(this.txtboxNameFirst);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblNameLast);
            this.Controls.Add(this.lblNameFirst);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameFirst;
        private System.Windows.Forms.Label lblNameLast;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.TextBox txtboxNameFirst;
        private System.Windows.Forms.TextBox txtboxNameLast;
        private System.Windows.Forms.TextBox txtboxMail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRedStar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioButtonMaleGender;
        private System.Windows.Forms.RadioButton RadioButtonFemaleGender;
        private System.Windows.Forms.CheckBox checkboxShowPassword;
        private System.Windows.Forms.Button btnJsonClick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxJsonUsername;
    }
}


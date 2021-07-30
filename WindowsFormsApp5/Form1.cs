using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_MouseHover(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.FlatAppearance.BorderSize = 1;
                btn.BackColor = Color.MediumAquamarine;
            }
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.Blue;
            }
        }
        class User
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Username { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public bool Gender { get; set; }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (MailAddress(txtboxMail.Text))
            {
                if (!label1.Visible &&
                    !label3.Visible &&
                    !label4.Visible &&
                    !label6.Visible &&
                    !lblRedStar1.Visible
                    )
                {
                    User user = new User
                    {
                        FirstName = txtboxNameFirst.Text,
                        LastName = txtboxNameLast.Text,
                        Username = txtboxUsername.Text,
                        Email = txtboxMail.Text,
                        Password = txtboxPassword.Text
                    };

                    txtboxNameFirst.Text = "";
                    txtboxNameLast.Text = "";
                    txtboxUsername.Text = "";
                    txtboxMail.Text = "";
                    txtboxPassword.Text = "";
                    RadioButtonFemaleGender.Checked = false;
                    RadioButtonMaleGender.Checked = false;

                    if (RadioButtonMaleGender.Checked) user.Gender = true;
                    else user.Gender = false;
                    var TextJson = JsonSerializer.Serialize(user, new JsonSerializerOptions() { WriteIndented = true });
                    if (TestUsername(user.Username))
                    {
                        using (FileStream fs = new FileStream($"{user.Username}.json", FileMode.Create))
                        {
                            using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                            {
                                sw.WriteLine(TextJson);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username Is Unique");
                    }
                }
            }
            else
            {
                MessageBox.Show("Your Entered email is not correct");
            }
        }

        private bool TestUsername(in string Username)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(".");
            foreach (var item in directoryInfo.GetFiles())
            {
                if (item.Name == $"{Username}.json")
                {
                    return false;
                }
            }
            return true;
        }

        bool MailAddress(string mail)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(mail);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void txtboxUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtboxUsername.Text != "") label1.Visible = false;
            else label1.Visible = true;
        }

        private void txtboxMail_TextChanged(object sender, EventArgs e)
        {
            if (txtboxMail.Text != "") label3.Visible = false;

        }
        private void txtboxPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtboxPassword.Text != "") label4.Visible = false;
            else label4.Visible = true;
        }

        private void RadioButtonMaleGender_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void txtboxNameFirst_TextChanged(object sender, EventArgs e)
        {
            if (txtboxNameFirst.Text != "" && txtboxNameLast.Text != "") lblRedStar1.Visible = false;
            else lblRedStar1.Visible = true;

        }

        private void checkboxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowPassword.Checked)
                txtboxPassword.PasswordChar = '\0';
            else
                txtboxPassword.PasswordChar = '*';
        }

        private void btnJsonClick_Click(object sender, EventArgs e)
        {
            try
            {
                var text = File.ReadAllText($"{txtboxJsonUsername.Text}.json");
                User JsonUser = JsonSerializer.Deserialize<User>(text);
                txtboxNameFirst.Text = JsonUser.FirstName;
                txtboxNameLast.Text = JsonUser.LastName;
                txtboxUsername.Text = JsonUser.Username;
                txtboxMail.Text = JsonUser.Email;
                txtboxPassword.Text = JsonUser.Password;
                if (JsonUser.Gender) RadioButtonMaleGender.Checked = true;
                else RadioButtonFemaleGender.Checked = true;
            }
            catch (FileNotFoundException)
            {
                txtboxJsonUsername.Text = "File Not Found";
            }
        }
    }
}

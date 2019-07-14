using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (username == "Resad" && password == "12345")
            {
                Form1 form = new Form1(this);
                form.Show();
            }
            else if (username.Trim() == "" || password.Trim() == "")
            {
                MessageBox.Show("Xanani doldurun", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (username != "Resad" && password != "12345")
            {
                MessageBox.Show("Adiniz ve sifrenizi duzgun daxil edin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (username != "Resad")
            {
                MessageBox.Show("Adinizi duzgun daxil edin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password != "12345")
            {
                MessageBox.Show("Sifrenizi duzgun daxil edin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

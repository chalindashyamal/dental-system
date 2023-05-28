using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__sample_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Reception" && txtPassword.Text == "123")
            {
                new Home().Show();
                this.Hide();
            }

            else if (txtUserName.Text == "Doctor" && txtPassword.Text == "543")
            {
                new Doctor_Login().Show();
                this.Hide();
            }
            else if (txtUserName.Text == "Admin" && txtPassword.Text == "134")
            {
                new Admin_Login().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("The user name or password you entered is incrrect,try again");
                txtPassword.Clear();
                txtUserName.Clear();
                txtUserName.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

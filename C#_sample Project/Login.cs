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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Chalinda Shyamal" && txtPassword.Text == "12345")
            {
                new Home().Show();
                this.Hide();
            }

            else if (txtUserName.Text =="Tulina Guna"&& txtPassword.Text=="54321")
            {
                new Doctor_Login().Show();
                this.Hide();
            }
            else if (txtUserName.Text == "Dulran" && txtPassword.Text == "11223")
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
            txtPassword.Clear();
            txtUserName.Clear();
            txtUserName.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace C__sample_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string Username;
        public string password;


        private void button3_Click(object sender, EventArgs e)

        {
            Username = txtUserName.Text;
            password = txtPassword.Text;

            //string connectionString = "server=your_server_name;user id=your_username;password=your_password;database=pms_db;sslmode=none;";

            if (Username != "" && password != "")
            {
                DB_conection functions = new DB_conection();

                string selectQuery = "SELECT COUNT(*) FROM usertable WHERE UserName = @username AND Password = @password";

                using (MySqlConnection connection = new MySqlConnection(functions.connectionString))
                {
                    try
                    {
                        connection.Open();

                        using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@username", Username);
                            command.Parameters.AddWithValue("@password", password);

                            int result = Convert.ToInt32(command.ExecuteScalar());

                            if (result > 0)
                            {
                                // Login successful
                                if (Username == "Receptionist")
                                {
                                    new Home().Show();
                                    this.Hide();
                                }
                                else if(Username == "Doctor")
                                {
                                    new Doctor_Login().Show();
                                    this.Hide();

                                }

                                else
                                {
                                    new Admin_Login().Show();
                                    this.Hide();

                                }

                              
                            }
                            else
                            {
                                // Invalid credentials
                                MessageBox.Show("The user name or password you entered is incorrect,try again!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter all required information!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowPassWordLogin.Checked==true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

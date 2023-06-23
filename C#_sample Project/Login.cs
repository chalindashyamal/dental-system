using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

            DB_conection function = new DB_conection();

            if (Username != "" && password != "")
            {
                string selectQuery = "SELECT COUNT(*) FROM usertable WHERE username = @username AND password = @password";

                using (SqlConnection connection = new SqlConnection(function.connectionString))
                {
                    try
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@username", Username);
                            command.Parameters.AddWithValue("@password", password);

                            int result = Convert.ToInt32(command.ExecuteScalar());

                            if (result > 0)
                            {
                                selectQuery = "SELECT role FROM usertable WHERE username = @username";
                                
                                SqlCommand command2 = new SqlCommand(selectQuery, connection);
                                command2.Parameters.AddWithValue("@username", Username);
                                string result2 = Convert.ToString(command2.ExecuteScalar());
                                // Login successful
                                if (result2 == "receptionist")
                                {
                                    new Home().Show();
                                    this.Hide();
                                }
                                else if (result2 == "doctor")
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
                                MessageBox.Show("The user name or password you entered is incorrect, try again!");
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
            if (ShowPassWordLogin.Checked == true)
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
            // Additional button click logic
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace C__sample_Project
{
    public partial class Edit_Profile : Form
    {
        public Edit_Profile()
        {
            InitializeComponent();
        }

        DB_conection functions = new DB_conection();

        public string Apassword1;
        public string Apassword2;
        public string Dpassword1;
        public string Dpassword2;
        public string Rpassword1;
        public string Rpassword2;







        private void button1_Click(object sender, EventArgs e)
        {
            Apassword1 = txtApassword1.Text;
            Apassword2 = txtApassword2.Text;
            

            if (Apassword1 == Apassword2)
            {
                using (MySqlConnection connection = new MySqlConnection(functions.connectionString))
                {
                    using (MySqlCommand command = connection.CreateCommand())
                    {
                        try
                        {
                            // Open the connection
                            connection.Open();

                            // Set the command text and parameters
                            command.CommandText = "UPDATE usertable SET Password = @password WHERE UserName = 'Admin'";
                            command.Parameters.AddWithValue("@password", Apassword1);
                            

                            // Execute the command
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Data successfully updated
                                MessageBox.Show("Profile updated successfully!");
                            }
                            else
                            {
                                // No rows affected
                                MessageBox.Show("Profile update failed!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error updating profile: " + ex.Message);
                        }
                        finally
                        {
                            // Close the connection
                            connection.Close();
                            txtApassword1.Text="";
                            txtApassword2.Text="";
                           

                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Passwords do not match");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dpassword1 = txtDpassword1.Text;
            Dpassword2 = txtDpassword2.Text;


            if (Dpassword1 == Dpassword2)
            {
                using (MySqlConnection connection = new MySqlConnection(functions.connectionString))
                {
                    using (MySqlCommand command = connection.CreateCommand())
                    {
                        try
                        {
                            // Open the connection
                            connection.Open();

                            // Set the command text and parameters
                            command.CommandText = "UPDATE usertable SET Password = @password WHERE UserName = 'Doctor'";
                            command.Parameters.AddWithValue("@password", Dpassword1);


                            // Execute the command
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Data successfully updated
                                MessageBox.Show("Profile updated successfully!");
                            }
                            else
                            {
                                // No rows affected
                                MessageBox.Show("Profile update failed!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error updating profile: " + ex.Message);
                        }
                        finally
                        {
                            // Close the connection
                            connection.Close();
                            txtDpassword1.Text = "";
                            txtDpassword2.Text = "";


                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Passwords do not match");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Rpassword1 = txtRpassword1.Text;
            Rpassword2 = txtRpassword2.Text;


            if (Rpassword1 == Rpassword2)
            {
                using (MySqlConnection connection = new MySqlConnection(functions.connectionString))
                {
                    using (MySqlCommand command = connection.CreateCommand())
                    {
                        try
                        {
                            // Open the connection
                            connection.Open();

                            // Set the command text and parameters
                            command.CommandText = "UPDATE usertable SET Password = @password WHERE UserName = 'Receptionist'";
                            command.Parameters.AddWithValue("@password", Rpassword1);


                            // Execute the command
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Data successfully updated
                                MessageBox.Show("Profile updated successfully!");
                            }
                            else
                            {
                                // No rows affected
                                MessageBox.Show("Profile update failed!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error updating profile: " + ex.Message);
                        }
                        finally
                        {
                            // Close the connection
                            connection.Close();
                            txtRpassword1.Text = "";
                            txtRpassword2.Text = "";


                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Passwords do not match");
            }
        }
    }
}

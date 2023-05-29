using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace C__sample_Project
{
    public partial class Add_Patient : Form
    {
        public Add_Patient()
        {
            InitializeComponent();
        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Login admin_Login = new Admin_Login();
            admin_Login.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
             string pname = txtPname.Text;
             string address = txtAddress.Text;
             string email = txtEmail.Text;

             //numeric
             string stringContact = txtContact.Text;
             string stringEmergency = txtEmergencyCP.Text;
             

             //radio input
             string gender = "";

             if (radiobtnMale.Checked)
             {
                 gender = "Male";
             }
             else if (radiobtnFemale.Checked)
             {
                gender = "Female";
             }

             //DOB
            DateTime selectedDate = dateTimePicker1.Value;
            string date = selectedDate.ToString("yyyy-MM-dd");

           


            DB_conection Objfunction = new DB_conection();
            if(pname == ""|| address=="" || email=="" || stringContact=="" || stringEmergency=="" || gender=="" || selectedDate == new DateTime(2023, 5, 29))
            {
                MessageBox.Show("All fields must be entered");
            }

            else if (!Objfunction.IsNumeric(stringContact) || !Objfunction.IsNumeric(stringEmergency))
            {
                MessageBox.Show("Contact and Emergency contact should be numeric values");
            }

            else
            {
                //numeric contact and Econtact

                int Contact = int.Parse(stringContact);
                int Econtact = int.Parse(stringEmergency);


                using (MySqlConnection connection = new MySqlConnection(Objfunction.connectionString))
                {
                    using (MySqlCommand command = connection.CreateCommand())
                    {
                        try
                        {
                            // Open the connection
                            connection.Open();

                            // Set the command text and parameters
                            command.CommandText = "INSERT INTO patienttable (Patient_Name, DOB, Gender, Email, Contact_Number, Address, Emergency_Contact) VALUES (@pname, @DOB, @gender, @Email, @ContactNumber, @Address, @Econtact)";
                            command.Parameters.AddWithValue("@pname", pname);
                            command.Parameters.AddWithValue("@DOB", date);
                            command.Parameters.AddWithValue("@gender", gender);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@ContactNumber", Contact);
                            command.Parameters.AddWithValue("@Address", address);
                            command.Parameters.AddWithValue("@Econtact", Econtact);
                            

                            // Execute the command
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Data successfully inserted
                                MessageBox.Show("Patient registered successfully!");
                            }
                            else
                            {
                                // No rows affected
                                MessageBox.Show("Patient added Failed!");
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error registering account: " + ex.Message);
                        }
                        finally
                        {
                            txtPname.Text = "";
                            txtAddress.Text = "";
                            txtEmail.Text = "";
                            radiobtnMale.Checked = false;
                            radiobtnFemale.Checked = false;
                            txtContact.Text = "";
                            txtEmergencyCP.Text = "";
                            
                            

                        }
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace C__sample_Project
{
    public partial class New_Receptionist : Form
    {
        public New_Receptionist()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Login admin = new Admin_Login();
            this.Hide();
            admin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Rname = txtRname.Text;
            string address = txtRAddress.Text;
            string email = txtREmail.Text;

            //numeric
            string stringContact = txtRContact.Text;
            string stringEmergency = txtREmergencyCP.Text;


            //radio input
            string gender = "";

            if (radiobtnRMale.Checked)
            {
                gender = "Male";
            }
            else if (radiobtnRFemale.Checked)
            {
                gender = "Female";
            }

            //DOB
            DateTime selectedDate = dateTimePicker1.Value;
            string date = selectedDate.ToString("yyyy-MM-dd");

            DB_conection Objfunction = new DB_conection();

            if (Rname == "" || address == "" || email == "" || stringContact == "" || stringEmergency == "" || gender == "" || selectedDate == new DateTime(2023, 5, 29))
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
                int emergency_contact_person = int.Parse(stringEmergency);

                using (SqlConnection connection = new SqlConnection(Objfunction.GetConnectionString()))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        try
                        {
                            // Open the connection
                            connection.Open();

                            // Set the command text and parameters
                            command.CommandText = "INSERT INTO receptionist (receptionist_name, dob, gender, email, contact_number, emergency_contact, address) VALUES (@Recename, @DOB, @gender, @Email, @ContactNumber, @Emcontact, @Address)";
                            command.Parameters.AddWithValue("@Recename", Rname);
                            command.Parameters.AddWithValue("@DOB", date);
                            command.Parameters.AddWithValue("@gender", gender);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@ContactNumber", Contact);
                            command.Parameters.AddWithValue("@Address", address);
                            command.Parameters.AddWithValue("@Emcontact", emergency_contact_person);

                            // Execute the command
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Data successfully inserted
                                MessageBox.Show("receptionist registered successfully!");
                            }
                            else
                            {
                                // No rows affected
                                MessageBox.Show("receptionist added Failed!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error registering account: " + ex.Message);
                        }
                        finally
                        {
                            txtRname.Text = "";
                            txtRAddress.Text = "";
                            txtREmail.Text = "";
                            radiobtnRMale.Checked = false;
                            radiobtnRFemale.Checked = false;
                            txtRContact.Text = "";
                            txtREmergencyCP.Text = "";
                        }
                    }
                }
            }
        }
    }
}

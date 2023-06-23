using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            // Additional button click logic
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

            // Numeric
            string stringContact = txtContact.Text;
            string stringEmergency = txtEmergencyCP.Text;

            // Radio input
            string gender = "";

            if (radiobtnMale.Checked)
            {
                gender = "Male";
            }
            else if (radiobtnFemale.Checked)
            {
                gender = "Female";
            }

            // DOB
            DateTime selectedDate = dateTimePicker1.Value;
            string date = selectedDate.ToString("yyyy-MM-dd");

            DB_conection Objfunction = new DB_conection();

            if (pname == "" || address == "" || email == "" || stringContact == "" || stringEmergency == "" || gender == "" || selectedDate == new DateTime(2023, 5, 29))
            {
                MessageBox.Show("All fields must be entered");
            }
            else if (!Objfunction.IsNumeric(stringContact) || !Objfunction.IsNumeric(stringEmergency))
            {
                MessageBox.Show("Contact and Emergency contact should be numeric values");
            }
            else
            {
                // Numeric contact and Econtact
                int Contact = int.Parse(stringContact);
                int Econtact = int.Parse(stringEmergency);


                using (SqlConnection connection = new SqlConnection(Objfunction.connectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        try
                        {
                            // Open the connection
                            connection.Open();

                            // Set the command text and parameters
                            command.CommandText = "INSERT INTO patienttable (patient_name, dob, gender, email, contact_number, emergency_contact, address) VALUES (@pname, @DOB, @gender, @Email, @ContactNumber, @Econtact, @Address)";
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
                                MessageBox.Show("Patient added failed!");
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
            // Additional text box changed logic
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Additional radio button changed logic
        }
    }
}

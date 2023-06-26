using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C__sample_Project
{
    public partial class Appointment_status : Form
    {
        private DB_conection function = new DB_conection();

        public Appointment_status()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateStatus("accepted");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Delete()
        {
            if (int.TryParse(textBox1.Text, out int appointmentId))
            {
                DB_conection functions = new DB_conection();

                string connectionString = functions.GetConnectionString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "DELETE FROM appointments WHERE appointment_id = @appointmentId";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@appointmentId", appointmentId);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Appointment deleted successfully.");
                                textBox1.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Appointment ID not found.");
                                textBox1.Text = "";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any potential exceptions here
                        MessageBox.Show("There's a payment already done for this appointment. Cannot be deleted.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid appointment ID. Please enter a valid numeric ID.");
            }
        }


        private void UpdateStatus(string status)
        {
            int appointmentId;
            if (int.TryParse(textBox1.Text, out appointmentId))
            {
                using (SqlConnection connection = new SqlConnection(function.GetConnectionString()))
                {
                    connection.Open();

                    string query = "UPDATE appointments SET status = @status WHERE appointment_id  = @appointmentId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@status", status);
                        command.Parameters.AddWithValue("@appointmentId", appointmentId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Status updated successfully.");
                            textBox1.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Appointment ID not found.");
                            textBox1.Text = "";
                        }
                    }

                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid appointment ID. Please enter a valid numeric ID.");
            }
        }
    }
}

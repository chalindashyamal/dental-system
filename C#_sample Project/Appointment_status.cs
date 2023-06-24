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
            UpdateStatus("rejected");
        }

        private void UpdateStatus(string status)
        {
            int appointmentId;
            if (int.TryParse(textBox1.Text, out appointmentId))
            {
                using (SqlConnection connection = new SqlConnection(function.connectionString))
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
                        }
                        else
                        {
                            MessageBox.Show("Appointment ID not found.");
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

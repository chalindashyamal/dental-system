using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace C__sample_Project
{
    public partial class Appointment_List : Form

    {
        private DataTable dt = new DataTable();

        private DB_conection functions = new DB_conection();

        public Appointment_List()
        {
            InitializeComponent();
        }

        private void Appointment_List_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Clear existing data in DataTable
            dt.Clear();

            string query = "SELECT * FROM appointments ";

            using (SqlConnection connection = new SqlConnection(functions.GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }




        private void ApplyFilter(string filter)
        {
            DataView view = dt.DefaultView;
            view.RowFilter = filter;
            dataGridView1.DataSource = view;
        }

       

        private void UpdateDatabase()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(functions.GetConnectionString()))
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM appointments", connection))
                using (SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter))
                {
                    adapter.Update(dt);
                    MessageBox.Show("Changes saved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating database: " + ex.Message);
            }
        }

        

        private void button8_Click_1(object sender, EventArgs e)
        {
            try
            {
                string filter = "patient_id= " + textBox1.Text;
                ApplyFilter(filter);
                textBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Not found, try again!");
            }

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                string filter = "appointment_id = " + textBox2.Text;
                ApplyFilter(filter);
                textBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Not found, try again!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Save changes in the database
            UpdateDatabase();

            // Reset the dataGridView1 filters
            dt.DefaultView.RowFilter = "";

            // Clear the text boxes
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            // Reset the dataGridView1 filters
            dt.DefaultView.RowFilter = "";

            // Clear the text boxes
            textBox1.Text = "";
            textBox2.Text = "";


            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateStatus("accepted");
        }
        private DB_conection function = new DB_conection();
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

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateStatus("rejected");
        }
    }
}

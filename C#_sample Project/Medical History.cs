using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace C__sample_Project
{
    public partial class Medical_History : Form
    {
        private DataTable dt = new DataTable();

        private DB_conection functions = new DB_conection();

        public Medical_History()
        {
            InitializeComponent();
        }

        private void Medical_History_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Clear existing data in DataTable
            dt.Clear();

            string query = "SELECT prescription_id, appointment_id, description FROM prescriptions ";

            using (SqlConnection connection = new SqlConnection(functions.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void searchData(string appId)
        {
            // Clear existing data in DataTable
            dt.Clear();

            string query = "SELECT prescription_id, appointment_id, description FROM prescriptions WHERE appointment_id IN ( SELECT appointment_id FROM appointments WHERE patient_id = " + GetPatientIdFromAppointments(appId) + ")";

            using (SqlConnection connection = new SqlConnection(functions.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        public string GetPatientIdFromAppointments( string appointmentId)
        {
            string patientId = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(functions.connectionString))
                {
                    connection.Open();

                    string query = "SELECT patient_id FROM appointments WHERE appointment_id = @AppointmentId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AppointmentId", appointmentId);

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            patientId = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the query execution
                Console.WriteLine("Error: " + ex.Message);
            }

            return patientId;
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
                using (SqlConnection connection = new SqlConnection(functions.connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT prescription_id, appointment_id, description FROM prescriptions", connection))
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


        private void button8_Click(object sender, EventArgs e)
        {
            try
            {

                string appId = textBox1.Text;
                searchData(appId);
            }
            catch {
                MessageBox.Show("Not found");
                  }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            // Save changes in the database
            UpdateDatabase();

            // Reset the dataGridView1 filters
            dt.DefaultView.RowFilter = "";

            // Clear the text boxes
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Reset the dataGridView1 filters
            dt.DefaultView.RowFilter = "";

            // Clear the text boxes
            textBox1.Text = "";


            LoadData();
        }
    }
}

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

namespace C__sample_Project
{
    public partial class New_Appointment : Form
    {

        DataTable dt = new DataTable();
        public New_Appointment()
        {
            InitializeComponent();
            LoadDataToDataGridView();
        }

        private void LoadDataToDataGridView()
        {
            DB_conection functions = new DB_conection();

            string query = "SELECT * FROM appointments";

            dt.Clear();

            using (SqlConnection connection = new SqlConnection(functions.GetConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string App_Patient_ID = txtAppId.Text;
                string App_time = textBox2.Text;

                // set date and time
                DateTime selectedDate = txtAppdate_time2.Value;
                string AppAppointment_Date_And_Time = selectedDate.ToString("yyyy-MM-dd");



                DB_conection Objfunction = new DB_conection();

                if (App_Patient_ID == "")
                {
                    MessageBox.Show("All fields must be entered");
                }

                else
                {
       


                    using (SqlConnection connection = new SqlConnection(Objfunction.GetConnectionString()))
                    {
                        using (SqlCommand command = connection.CreateCommand())
                        {
                            try
                            {
                                // Open the connection
                                connection.Open();

                                // Set the command text and parameters
                                command.CommandText = "INSERT INTO appointments (patient_id, appointment_date, appointment_time,status) VALUES (@patient_id, @appointment_date, @appointment_time, 'pending')";
                                command.Parameters.AddWithValue("@patient_id", App_Patient_ID);
                                command.Parameters.AddWithValue("@appointment_date", AppAppointment_Date_And_Time);
                                command.Parameters.AddWithValue("@appointment_time", App_time);

                                // Execute the command
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    // Data successfully inserted
                                    MessageBox.Show("New appointment added successfully!");
                                }
                                else
                                {
                                    // No rows affected
                                    MessageBox.Show("appointment added failed!");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error registering account: " + ex.Message);
                            }
                            finally
                            {
                                txtAppId.Text = "";
                                txtAppdate_time2.Text = "";
                                textBox2.Text = "";


                            }
                        }
                    }
                }
            }

            LoadDataToDataGridView();
        }

        private void New_Appointment_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string filter = "date_and_time like '%" + textBox1.Text + "%'";
                ApplyFilter(filter);
                textBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Not found, try again!");
            }

        }

        private void ApplyFilter(string filter)
        {
            DataView view = dt.DefaultView;
            view.RowFilter = filter;
            dataGridView1.DataSource = view;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Reset the dataGridView1 filters
            dt.DefaultView.RowFilter = "";
            LoadDataToDataGridView();
        }
    }
}

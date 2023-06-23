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

namespace C__sample_Project
{
    public partial class New_Appointment : Form
    {
        public New_Appointment()
        {
            InitializeComponent();
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
       


                    using (SqlConnection connection = new SqlConnection(Objfunction.connectionString))
                    {
                        using (SqlCommand command = connection.CreateCommand())
                        {
                            try
                            {
                                // Open the connection
                                connection.Open();

                                // Set the command text and parameters
                                command.CommandText = "INSERT INTO appointments (patient_id, date_and_time, status) VALUES (@patient_id, @date_and_time, 'pending')";
                                command.Parameters.AddWithValue("@patient_id", App_Patient_ID);
                                command.Parameters.AddWithValue("@date_and_time", AppAppointment_Date_And_Time);
                               
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
                                
                            }
                        }
                    }
                }
            }
        }

        private void New_Appointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dental_DBDataSet5.appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter3.Fill(this.dental_DBDataSet5.appointments);
            // TODO: This line of code loads data into the 'dental_DBDataSet1.appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter2.Fill(this.dental_DBDataSet1.appointments);
            // TODO: This line of code loads data into the 'dental_DBDataSet.appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter1.Fill(this.dental_DBDataSet.appointments);
            // TODO: This line of code loads data into the 'appointmentDataSet.appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.appointmentDataSet.appointments);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

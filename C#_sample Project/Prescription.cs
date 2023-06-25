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
    public partial class Prescription : Form
    {
        public Prescription()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Doctor_Login doctor_Login = new Doctor_Login();
            doctor_Login.Show();
            this.Hide();

        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            Medical_History medical_History = new Medical_History();
            medical_History.Show();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                string Presc_appointment_id = txtPresc_appointment_id.Text;
                string presc_des = txtpresc_des.Text;
                string presc_pen_amount= txtpresc_pen_amount.Text;






                DB_conection Objfunction = new DB_conection();

                if (Presc_appointment_id == ""|| presc_des=="" || presc_pen_amount=="")
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
                                command.CommandText = "INSERT INTO prescriptions (appointment_id, description, pending_amount) VALUES (@appointment_id, @description, @pending_amount)";
                                command.Parameters.AddWithValue("@appointment_id", Presc_appointment_id);
                                command.Parameters.AddWithValue("@description", presc_des);
                                command.Parameters.AddWithValue("@pending_amount", presc_pen_amount);

                                // Execute the command
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    // Data successfully inserted
                                    MessageBox.Show("Prescription created successfully!");
                                }
                                else
                                {
                                    // No rows affected
                                    MessageBox.Show("Prescription create failed!");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error registering account: " + ex.Message);
                            }
                            finally
                            {
                                txtPresc_appointment_id.Text = "";
                                txtpresc_des.Text = "";
                                txtpresc_pen_amount.Text = "";

                            }
                        }
                    }
                }
            }
        }

        private void Prescription_Load(object sender, EventArgs e)
        {

        }
    }
}

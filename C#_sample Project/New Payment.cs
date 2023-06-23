using Google.Protobuf.WellKnownTypes;
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
    public partial class New_Payment : Form
    {
        public New_Payment()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string pay_Appointment_Id = txtpay_AppointmentId.Text;
            string pay_Payment_Method = txtpay_Payment_Method.Text;
            string pay_Pendding_Amount = txtpay_Pendding_Amount.Text;
            string pay_amount = txtpay_amount.Text;
           



            DB_conection Objfunction = new DB_conection();

            if (pay_Appointment_Id == "" || pay_Payment_Method=="" || pay_Pendding_Amount==""|| pay_amount=="")
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
                            command.CommandText = "INSERT INTO payments (appointment_id, payment_method, amount) VALUES (@appointment_id, @payment_method,@amount)";
                            command.Parameters.AddWithValue("@appointment_id", pay_Appointment_Id);
                            command.Parameters.AddWithValue("@payment_method", pay_Payment_Method);
                            command.Parameters.AddWithValue("@amount", pay_amount);



                            // Execute the command
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Data successfully inserted
                                MessageBox.Show("Payment completed!");
                            }
                            else
                            {
                                // No rows affected
                                MessageBox.Show("Payment not completed!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error registering account: " + ex.Message);
                        }
                        finally
                        {
                            txtpay_AppointmentId.Text = "";
                            txtpay_Payment_Method.Text = "";
                            txtpay_Pendding_Amount.Text = "";
                            txtpay_amount.Text = "";

                        }
                    }
                }
            }
        }
    }
    
}

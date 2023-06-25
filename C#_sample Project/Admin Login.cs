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
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
            GetPatientTableCount();
            GetAppointmentCount();
            GetReceptionistCount();
            GetPaymentSum();
        }

        DB_conection functions = new DB_conection();

        //get patient count
        public void GetPatientTableCount()
        {
            int count = 0;

            string connectionString = functions.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM patienttable";
                    SqlCommand command = new SqlCommand(query, connection);
                    count = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    // Handle any potential exceptions here
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            label5.Text = count.ToString();
        }

        //get appintment count
        public void GetAppointmentCount()
        {
            int count = 0;

            string connectionString = functions.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM appointment";
                    SqlCommand command = new SqlCommand(query, connection);
                    count = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    // Handle any potential exceptions here
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            label6.Text = count.ToString();
        }

        //Get Receptionist Count
        public void GetReceptionistCount()
        {
            int count = 0;

            string connectionString = functions.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM receptionist";
                    SqlCommand command = new SqlCommand(query, connection);
                    count = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    // Handle any potential exceptions here
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            label7.Text = count.ToString();
        }

        //Get Payment Sum
        public void GetPaymentSum()
        {
            decimal sum = 0;

            string connectionString = functions.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT SUM(amount) FROM payments";
                    SqlCommand command = new SqlCommand(query, connection);
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        sum = Convert.ToDecimal(result);
                    }
                }
                catch (Exception ex)
                {
                    // Handle any potential exceptions here
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            label8.Text = sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            New_Receptionist new_Receptionist = new New_Receptionist();
            new_Receptionist.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login ObjLogin = new Login();
                this.Hide();
                ObjLogin.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Add_Patient add_Patient = new Add_Patient();
            add_Patient.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment_List payment_List = new Payment_List();
            payment_List.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Appointment_List appointment_List = new Appointment_List();
            appointment_List.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Medical_History medical_History = new Medical_History();
            medical_History.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Receptonist_List receptonist_list = new Receptonist_List();
            receptonist_list.Show();
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Patient_List patient_List = new Patient_List();
            patient_List.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Edit_profile edit_Profile = new Edit_profile();
            edit_Profile.Show();
        }
    }
}

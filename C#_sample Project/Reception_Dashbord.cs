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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            GetPatientTableCount();
            GetAppointmentCount();
            GetReceptionistCount();
            GetPaymentSum();
        }

        DB_conection functions = new DB_conection();

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


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            Add_Patient add_Patient = new Add_Patient();    
            add_Patient.Show();
                    
        }

        private void button7_Click(object sender, EventArgs e)
        {

            New_Appointment new_Appointment = new New_Appointment();
            new_Appointment.Show();
            

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?","Exit message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Login ObjLogin = new Login();
                this.Hide();
                ObjLogin.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            New_Payment new_Payment = new New_Payment();    
            new_Payment.Show();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Patient_List patient_List = new Patient_List();
            patient_List.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Appointment_List appointment_List = new Appointment_List();
            appointment_List.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Payment_List payment_List = new Payment_List();
            payment_List.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Appointment_status appointment_Status = new Appointment_status();
            appointment_Status.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

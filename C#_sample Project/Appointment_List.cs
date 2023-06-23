using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__sample_Project
{
    public partial class Appointment_List : Form
    {
        public Appointment_List()
        {
            InitializeComponent();
        }

        private DataTable dt;
        public void loadData()
        {
            DB_conection functions = new DB_conection();

            using (MySqlConnection connection = new MySqlConnection(functions.connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM appointments";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = command;
                    dt = new DataTable(); // Assign the DataTable to the class-level variable
                    adapter.Fill(dt);

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dt;

                    dataGridView1.DataSource = bindingSource;
                    connection.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Login admin = new Admin_Login();
            admin.Show();
            this.Hide();
        }

        private void lable1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Appointment_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dental_DBDataSet2.appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.dental_DBDataSet2.appointments);

        }
    }
}

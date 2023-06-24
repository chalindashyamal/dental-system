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
    public partial class Payment_List : Form
    {
        private DataTable dt = new DataTable();
        private DB_conection functions = new DB_conection();

        public Payment_List()
        {
            InitializeComponent();
            LoadDataToDataGridView();
        }

        private void LoadDataToDataGridView()
        {
            DB_conection functions = new DB_conection();


            string query = "SELECT * FROM payments";

            using (SqlConnection connection = new SqlConnection(functions.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Payment_List payment_List = new Payment_List();
            payment_List.Show();
        }

        private void Payment_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dental_DBDataSet6.payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.dental_DBDataSet6.payments);
            // TODO: This line of code loads data into the 'dataSet1.payments' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'patientDataSet.patienttable' table. You can move, or remove it, as needed.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            // Save changes in the database
            UpdateDatabase();

            // Reset the dataGridView1 filters
            dt.DefaultView.RowFilter = "";

            // Clear the text boxes
            textBox1.Text = "";
            textBox2.Text = "";

        }
        private void ApplyFilter(string filter)
        {
            DataView view = dt.DefaultView;
            view.RowFilter = filter;
            dataGridView1.DataSource = view;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string filter = "payment_id = " + textBox1.Text;
                ApplyFilter(filter);
                textBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Not found, try again!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            // Reset the dataGridView1 filters
            dt.DefaultView.RowFilter = "";

            // Clear the text boxes
            textBox1.Text = "";
            textBox2.Text = "";


            LoadData();

        }
        private void LoadData()
        {
            // Clear existing data in DataTable
            dt.Clear();

            string query = "SELECT * FROM patienttable";

            using (SqlConnection connection = new SqlConnection(functions.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void UpdateDatabase()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(functions.connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM patienttable", connection))
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
    }

    }

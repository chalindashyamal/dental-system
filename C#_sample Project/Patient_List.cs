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
    public partial class Patient_List : Form
    {
        public Patient_List()
        {
            InitializeComponent();
        }

        private DataTable dt; // Declare a class-level DataTable variable
        public void loadData()
        {
            DB_conection functions = new DB_conection();

            using (SqlConnection connection = new SqlConnection(functions.connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM patienttable";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Additional cell content click logic
        }

        private void Patient_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dental_DBDataSet3.patienttable' table. You can move, or remove it, as needed.
            this.patienttableTableAdapter.Fill(this.dental_DBDataSet3.patienttable);
            // TODO: This line of code loads data into the 'dataSet2.patienttable' table. You can move, or remove it, as needed.
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Additional button click logic
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                // Add filter to dataGridView1 to show entries matching the ID
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                bs.Filter = "patient_id = " + textBox1.Text;
                dataGridView1.DataSource = bs;

                // Clear the text box
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
                // Add filter to dataGridView1 to show entries matching the First name or the Last name
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                bs.Filter = "Patient_Name LIKE '%" + textBox2.Text + "%'";
                dataGridView1.DataSource = bs;

                // Clear the text box
                textBox2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not found, try again!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // Add filter to dataGridView1 to show entries matching the phone_number
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                bs.Filter = "Contact_Number like '%" + textBox3.Text + "%'";
                dataGridView1.DataSource = bs;

                // Clear the text box
                textBox3.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not found, try again!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Save changes in dataGridView1 to the database

            // Show a message box to confirm the changes
            MessageBox.Show("Changes saved");

            // Reset the dataGridView1 filters
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "";
            dataGridView1.DataSource = bs;

            // Clear the text boxes
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Reset the dataGridView1 filters
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "";
            dataGridView1.DataSource = bs;

            // Clear the text boxes
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Additional cell content click logic
        }
    }
}


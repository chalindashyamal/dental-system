using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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

            using (MySqlConnection connection = new MySqlConnection(functions.connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM patienttable";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Patient_List_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                // Add filter to dataGridView1 to show entries match the ID
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                bs.Filter = "patient_id = " + textBox1.Text;
                dataGridView1.DataSource = bs;

                // Clear the text box
                textBox1.Text = "";
            }
            catch 
            {
                MessageBox.Show("Not found try again!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                // Add filter to dataGridView1 to show entries match the First name or the Last name
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                bs.Filter = "Patient_Name LIKE '%" + textBox2.Text + "%'";
                dataGridView1.DataSource = bs;

                // Clear the text box
                textBox2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not found try again!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try 
            {
                // Add filter to dataGridView1 to show entries match the phone_number
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                bs.Filter = "Contact_Number like '%" + textBox3.Text + "%'";
                dataGridView1.DataSource = bs;

                // Clear the text box
                textBox3.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not found try again!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            // Save changes in dataGridView1 to the database



            // Show a message box to confirm the changes
            MessageBox.Show("Changes Saved");

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

        }
    }
}

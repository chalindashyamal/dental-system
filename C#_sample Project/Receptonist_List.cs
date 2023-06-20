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
    public partial class Receptonist_List : Form
    {
        public Receptonist_List()
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

                string query = "SELECT * FROM receptionist";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = command;
                    dt = new DataTable(); // Assign the DataTable to the class-level variable
                    adapter.Fill(dt);

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dt;

                    dataGridView2.DataSource = bindingSource;
                    connection.Close();
                }
            }
        }
       

        private void button5_Click(object sender, EventArgs e)
        {
            Admin_Login admin_Login = new Admin_Login();
            this.Hide();
            admin_Login.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Receptonist_List_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                // Add filter to dataGridView1 to show entries match the ID
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView2.DataSource;
                bs.Filter = "receptionist_id = " + textBox1.Text;
                dataGridView2.DataSource = bs;

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
                bs.DataSource = dataGridView2.DataSource;
                bs.Filter = "receptionist_name LIKE '%" + textBox2.Text + "%'";
                dataGridView2.DataSource = bs;

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
                bs.DataSource = dataGridView2.DataSource;
                bs.Filter = "contact_no like '%" + textBox3.Text + "%'";
                dataGridView2.DataSource = bs;

                // Clear the text box
                textBox3.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not found try again!");
            }
        }
    }
}

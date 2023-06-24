using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace C__sample_Project
{
    public partial class Receptonist_List : Form
    {
        private DataTable dt = new DataTable();

        private DB_conection functions = new DB_conection();

        public Receptonist_List()
        {
            InitializeComponent();
        }

        private void Receptonist_List_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Clear existing data in DataTable
            dt.Clear();

            string query = "SELECT * FROM receptionist";

            using (SqlConnection connection = new SqlConnection(functions.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string filter = "receptionist_id  = " + textBox1.Text;
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
                string filter = "receptionist_name LIKE '%" + textBox2.Text + "%'";
                ApplyFilter(filter);
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
                string filter = "contact_number like '%" + textBox3.Text + "%'";
                ApplyFilter(filter);
                textBox3.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not found, try again!");
            }
        }

        private void ApplyFilter(string filter)
        {
            DataView view = dt.DefaultView;
            view.RowFilter = filter;
            dataGridView2.DataSource = view;
        }
        private void UpdateDatabase()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(functions.connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM receptionist", connection))
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            // Save changes in the database
            UpdateDatabase();

            // Reset the dataGridView1 filters
            dt.DefaultView.RowFilter = "";

            // Clear the text boxes
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            // Reset the dataGridView1 filters
            dt.DefaultView.RowFilter = "";

            // Clear the text boxes
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            LoadData();
        }
    }
}

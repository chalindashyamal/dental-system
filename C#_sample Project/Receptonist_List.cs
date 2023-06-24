using System;
using System.Data;
using System.Data.SqlClient;
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


        DB_conection function = new DB_conection();
        public void loadData()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\YourDatabase.mdf;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(function.connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM receptionist";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
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
            // TODO: This line of code loads data into the 'dental_DBDataSet4.receptionist' table. You can move, or remove it, as needed.
            this.receptionistTableAdapter.Fill(this.dental_DBDataSet4.receptionist);
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
                MessageBox.Show("Not found, try again!");
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
                MessageBox.Show("Not found, try again!");
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
                MessageBox.Show("Not found, try again!");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }
    }
}

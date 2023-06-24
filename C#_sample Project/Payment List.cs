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
    public partial class Payment_List : Form
    {
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

        }
    }
}

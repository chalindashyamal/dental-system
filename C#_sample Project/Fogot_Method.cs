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
    public partial class Fogot_Method : Form
    {
        public Fogot_Method()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             Verify_email_city fm3 = new Verify_email_city();
             fm3.Show();
             this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Send_code send_Code = new Send_code();
            send_Code.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();

        }
    }
}

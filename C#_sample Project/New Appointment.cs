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
    public partial class New_Appointment : Form
    {
        public New_Appointment()
        {
            InitializeComponent();
        }

       
        private void button3_Click_1(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void New_Appointment_Load(object sender, EventArgs e)
        {

        }
    }
}

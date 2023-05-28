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
    public partial class Medical_History : Form
    {
        public Medical_History()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Prescription prescription = new Prescription();
            prescription.Show();
            this.Hide();
        }

        private void Medical_History_Load(object sender, EventArgs e)
        {

        }
    }
}

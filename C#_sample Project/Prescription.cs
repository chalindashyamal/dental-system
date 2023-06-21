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
    public partial class Prescription : Form
    {
        public Prescription()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Doctor_Login doctor_Login = new Doctor_Login();
            doctor_Login.Show();
            this.Hide();

        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            Medical_History medical_History = new Medical_History();
            medical_History.Show();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

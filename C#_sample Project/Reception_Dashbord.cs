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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            Add_Patient add_Patient = new Add_Patient();    
            add_Patient.Show();
                    
        }

        private void button7_Click(object sender, EventArgs e)
        {

            New_Appointment new_Appointment = new New_Appointment();
            new_Appointment.Show();
            

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?","Exit message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            New_Payment new_Payment = new New_Payment();    
            new_Payment.Show();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Patient_List patient_List = new Patient_List();
            patient_List.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Appointment_List appointment_List = new Appointment_List();
            appointment_List.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Payment_List payment_List = new Payment_List();
            payment_List.Show();
        }
    }
}

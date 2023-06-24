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
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            New_Receptionist new_Receptionist = new New_Receptionist();
            new_Receptionist.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Add_Patient add_Patient = new Add_Patient();
            add_Patient.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment_List payment_List = new Payment_List();
            payment_List.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Appointment_List appointment_List = new Appointment_List();
            appointment_List.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Medical_History medical_History = new Medical_History();
            medical_History.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Receptonist_List receptonist_list = new Receptonist_List();
            receptonist_list.Show();
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Patient_List patient_List = new Patient_List();
            patient_List.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Edit_profile edit_Profile = new Edit_profile();
            edit_Profile.Show();
        }
    }
}

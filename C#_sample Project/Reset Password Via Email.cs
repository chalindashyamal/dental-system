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
    public partial class Reset_Password_Via_Email : Form
    {
        public Reset_Password_Via_Email()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fogot_Method fogot_Method= new Fogot_Method();
            this.Hide();
            fogot_Method.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

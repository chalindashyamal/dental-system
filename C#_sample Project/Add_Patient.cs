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
    public partial class Add_Patient : Form
    {
        public Add_Patient()
        {
            InitializeComponent();
        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}

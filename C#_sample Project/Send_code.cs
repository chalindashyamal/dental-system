using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__sample_Project
{
    public partial class Send_code : Form
    {
        string randomcode;
        public static string to;
        public Send_code()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
           Fogot_Method fogot_Method = new Fogot_Method();
            fogot_Method.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string from, pass, messagebody;
            Random rand = new Random(); 
            randomcode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtReaetEmail.Text).ToString();
            from= "tulinaguna@icloud.com";
            pass = "123321";
            messagebody = $"Your Reset Code is{randomcode}";
            message.To.Add(to);
            message.From=new MailAddress(from);
            message.Body=messagebody;
            message.Subject = "Password Reset Code";
            SmtpClient smtp=new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl=true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials=new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Code Send Successfully");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtResetpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(randomcode==(txtEnterCode.Text).ToString())
            {
                to = txtReaetEmail.Text;
                Reset_Password_Via_Email rp=new Reset_Password_Via_Email();
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Code")
            }
        }
    }
}

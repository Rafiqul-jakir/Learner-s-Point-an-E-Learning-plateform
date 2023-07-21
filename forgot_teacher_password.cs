using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Mail;

namespace Learner_s_Point
{
    public partial class forgot_teacher_password : Form
    {
        static public string randomcode, to, teacher_email;

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public forgot_teacher_password()
        {
            InitializeComponent();
        }

        private void search_button_Click(object sender, EventArgs e)
        {

            teacher_email = email_search_box.Text;
            MySqlConnection con = new MySqlConnection(Database_Connect.connect_database());
            con.Open();
            MySqlCommand command;
            MySqlDataReader mdr;
            string selectQuery = "SELECT Email FROM teacher WHERE Email = '" + email_search_box.Text + "'";
            command = new MySqlCommand(selectQuery, con);
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {

                string from, pass, messagebody;
                Random rand = new Random();
                randomcode = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                to = (email_search_box.Text).ToString();
                from = "farukmd4761@gmail.com";
                pass = "01300464761";
                messagebody = "Your Password reset code is: " + randomcode;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messagebody;
                message.Subject = "OPT From Leraner's Point";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("ex.message");
                }

                con.Close();
                this.Close();
                Teacher_email_verification obj = new Teacher_email_verification();
                obj.ShowDialog();

            }
            else
            {
                MessageBox.Show("Email Not Found !!");
            }
            con.Close();
        }
    }
}

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

namespace Learner_s_Point
{
    public partial class A_D_students_details : UserControl
    {
        public A_D_students_details()
        {
            InitializeComponent();
        }

        private void A_D_students_details_Load(object sender, EventArgs e)
        {

        }

        private void search_email_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection con1 = new MySqlConnection(Database_Connect.connect_database());
            con1.Open();

            MySqlCommand command;
            command = con1.CreateCommand();
            command.CommandText = "SELECT `Student_ID`,`Name`, `Email`, `Phone` FROM `student` WHERE Email = '" + email_serach_box.Text + "'";
            MySqlDataReader sdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            sdr.Close();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                student_ID.Text = dr["Student_ID"].ToString();
                student_name.Text = dr["Name"].ToString();
                student_email.Text = dr["Email"].ToString();
                student_phone.Text = dr["Phone"].ToString();
                /*
                 byte[] img = (byte[])dt.Rows[0][5];

                 MemoryStream ms = new MemoryStream(img);
                 pictureBox1.Image = Image.FromStream(ms);
                */

                da.Dispose();
            }

            MySqlCommand command1;
            command1 = con1.CreateCommand();
            command1.CommandText = "SELECT `Subject_Name` FROM `subjects` WHERE Email = '" + email_serach_box.Text + "'";
            MySqlDataReader sdr1 = command1.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(sdr1);
            
            student_details_gride.DataSource = dt1;
            sdr1.Close();

            MySqlCommand command2;
            command2 = con1.CreateCommand();
            command2.CommandText = "SELECT  `Phone_Number`, `TRANSACTION_ID`, `Payment_Method`, `Taka` FROM `payment_details` WHERE Email = '" + email_serach_box.Text + "'";
            MySqlDataReader sdr2 = command2.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(sdr2);
            sdr2.Close();
            dataGridView1.DataSource = dt2;
            con1.Close();

        }
    }
}

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
using System.IO;

namespace Learner_s_Point
{
    public partial class A_D_profile : UserControl
    {
        public string img;
        public A_D_profile()
        {
            InitializeComponent();

        }

        private void A_D_profile_Load(object sender, EventArgs e)
        {
            MySqlConnection con1 = new MySqlConnection(Database_Connect.connect_database());
            con1.Open();

            MySqlCommand command;
            command = con1.CreateCommand();
            command.CommandText = "SELECT `Admin_ID`, `Name`, `Email`, `Phone`, `Password`, `imag` FROM `admin` WHERE Email = @admin_email";
            command.Parameters.AddWithValue("@admin_email", Teacher_Login_page.Admin_ifo);
            MySqlDataReader sdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            sdr.Close();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                admin_id.Text = dr["Admin_ID"].ToString();
                admin_name.Text = dr["Name"].ToString();
                admin_email.Text = dr["Email"].ToString();
                admin_phone.Text = dr["Phone"].ToString();
                admin_pass.Text = dr["Password"].ToString();

                /*
                 byte[] img = (byte[])dt.Rows[0][5];
                 MemoryStream ms = new MemoryStream(img);
                 pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                
                byte[] bits = new byte[0];
                bits = (byte[])dt.Rows[0][5];
                MemoryStream ms = new MemoryStream(bits);
                pictureBox1.Image = Image.FromStream(ms);
                */

                da.Dispose();
            }
            con1.Close();
        }


        private void Update_btn_Click(object sender, EventArgs e)
        {
           Admin_update_profile obj = new Admin_update_profile();
            obj.Show();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Admin_Dashboard obj = new Admin_Dashboard(Teacher_Login_page.Admin_ifo);
            obj.Load_admin_name();

            MySqlConnection con1 = new MySqlConnection(Database_Connect.connect_database());
            con1.Open();

            MySqlCommand command1;
            command1 = con1.CreateCommand();
            command1.CommandText = "SELECT `Admin_ID`, `Name`, `Email`, `Phone`, `Password`, `imag` FROM `admin` WHERE Email = @admin_email";
            command1.Parameters.AddWithValue("@admin_email", Teacher_Login_page.Admin_ifo);
            MySqlDataReader sdr = command1.ExecuteReader();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(command1);
            sdr.Close();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                admin_id.Text = dr["Admin_ID"].ToString();
                admin_name.Text = dr["Name"].ToString();
                admin_email.Text = dr["Email"].ToString();
                admin_phone.Text = dr["Phone"].ToString();
                admin_pass.Text = dr["Password"].ToString();
                /*
                 byte[] img = (byte[])dt.Rows[0][5];

                 MemoryStream ms = new MemoryStream(img);
                 pictureBox1.Image = Image.FromStream(ms);
                */

                da.Dispose();
            }
            con1.Close();
        }

        private void admin_phone_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class S_D_Profile : UserControl
    {
        public static string name, email, phone, pass;
        public S_D_Profile()
        {
            InitializeComponent();
        }

        private void S_D_Profile_Load(object sender, EventArgs e)
        {
            Std_profile_load();
        }
        public void Std_profile_load()
        {
            MySqlConnection con1 = new MySqlConnection(Database_Connect.connect_database());
            con1.Open();

            MySqlCommand command;
            command = con1.CreateCommand();
            command.CommandText = "SELECT `Student_ID`, `Name`, `Email`, `Phone`, `Password`, `image` FROM `student` WHERE Email = @student_email";
            command.Parameters.AddWithValue("@student_email", Student_Login_Page.student_email);
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
                student_pass.Text = dr["Password"].ToString();

                name = dr["Name"].ToString();
                email = dr["Email"].ToString();
                phone = dr["Phone"].ToString();
                pass = dr["Password"].ToString();

                /*
                byte[] img = (byte[])dt.Rows[0][5];

                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                */

                da.Dispose();
            }
            con1.Close();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Std_profile_load();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            Student_update_profile obj = new Student_update_profile();
            obj.ShowDialog();
        }
    }
}

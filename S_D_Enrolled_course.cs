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
    public partial class S_D_Enrolled_course : UserControl
    {
        public static string physics = "0", chemistry = "0", ict = "0", biology = "0";
        public static int payable_taka = 0;
        public S_D_Enrolled_course()
        {
            InitializeComponent();
        }

        private void checkBox_ict_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ict.Checked)
            {
                payable_taka += 500;
                lbl_payment_taka.Text = payable_taka.ToString();
            }
            else
            {
                payable_taka -= 500;
                lbl_payment_taka.Text = payable_taka.ToString();
            }
        }

        private void checkBox_physics_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_physics.Checked)
            {
                payable_taka += 700;
                lbl_payment_taka.Text = payable_taka.ToString();
            }
            else
            {
                payable_taka -= 700;
                lbl_payment_taka.Text = payable_taka.ToString();
            }
        }

        private void checkBox_chemistry_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_chemistry.Checked)
            {
                payable_taka += 700;
                lbl_payment_taka.Text = payable_taka.ToString();
            }
            else
            {
                payable_taka -= 700;
                lbl_payment_taka.Text = payable_taka.ToString();
            }
        }

        private void checkBox_biology_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_biology.Checked)
            {
                payable_taka += 600;
                lbl_payment_taka.Text = payable_taka.ToString();
            }
            else
            {
                payable_taka -= 600;
                lbl_payment_taka.Text = payable_taka.ToString();
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Enrolled_course_Load();
        }

        private void lbl_payment_taka_Click(object sender, EventArgs e)
        {

        }

        private void S_D_Enrolled_course_Load(object sender, EventArgs e)
        {
            Enrolled_course_Load();
        }
        public void Enrolled_course_Load()
        {
            MySqlConnection con = new MySqlConnection(Database_Connect.connect_database());
            con.Open();
            MySqlCommand command;
            command = con.CreateCommand();
            command.CommandText = "SELECT `Subject_Name` FROM `subjects` WHERE Email = @email";
            command.Parameters.AddWithValue("@email", Student_Login_Page.student_email);
            MySqlDataReader sdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            Home_gride.DataSource = dt;
        }

        private void make_payment_btn_Click(object sender, EventArgs e)
        {
            if (checkBox_ict.Checked || checkBox_physics.Checked || checkBox_chemistry.Checked || checkBox_biology.Checked)
            {
                if (checkBox_ict.Checked)
                {
                    ict = "ICT";
                }

                if (checkBox_physics.Checked)
                {
                    physics = "Physics";
                }

                if (checkBox_chemistry.Checked)
                {
                    chemistry = "Chemistry";
                }
                if (checkBox_biology.Checked)
                {
                    biology = "Biology";
                }
                S_D_make_payment obj = new S_D_make_payment();
                obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Must Select at list One Subject !");
            }
        }
    }
}

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
    public partial class S_D_make_payment : Form
    {
        public S_D_make_payment()
        {
            InitializeComponent();
        }
        String subjects = "";
        private void btn_bkash_pay_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Database_Connect.connect_database());
            con.Open();
            
            if(bkash_ph_number.Text == "" || bkash_ts_id.Text =="")
            {
                MessageBox.Show("Please insert All Field!!");
            }
            else
            {

                if (S_D_Enrolled_course.ict == "ICT")
                {


                    MySqlCommand cmd7;
                    cmd7 = con.CreateCommand();
                    cmd7.CommandText = "INSERT INTO `new_anrolled_coures`(`Subject_Name`, `Email`, `Phone_Number`, `Payment_method`, `Transaction_ID`, `TK`) VALUES(@subject_Name,@Student_Email,@phone,@payment_method,@ts_id,@tk)";
                    cmd7.Parameters.AddWithValue("@subject_Name", "ICT");
                    cmd7.Parameters.AddWithValue("@Student_Email", Student_Login_Page.student_email);
                    cmd7.Parameters.AddWithValue("@phone", bkash_ph_number.Text);
                    cmd7.Parameters.AddWithValue("@ts_id", bkash_ts_id.Text);
                    cmd7.Parameters.AddWithValue("@payment_method", "Bkash");
                    cmd7.Parameters.AddWithValue("@tk", "500");
                    cmd7.ExecuteNonQuery();
                }

                if (S_D_Enrolled_course.physics == "Physics")
                {
                    MySqlCommand cmd7;
                    cmd7 = con.CreateCommand();
                    cmd7.CommandText = "INSERT INTO `new_anrolled_coures`(`Subject_Name`, `Email`, `Phone_Number`, `Payment_method`, `Transaction_ID`, `TK`) VALUES(@subject_Name,@Student_Email,@phone,@payment_method,@ts_id,@tk)";
                    cmd7.Parameters.AddWithValue("@subject_Name", "Physics");
                    cmd7.Parameters.AddWithValue("@Student_Email", Student_Login_Page.student_email);
                    cmd7.Parameters.AddWithValue("@phone", bkash_ph_number.Text);
                    cmd7.Parameters.AddWithValue("@ts_id", bkash_ts_id.Text);
                    cmd7.Parameters.AddWithValue("@payment_method", "Bkash");
                    cmd7.Parameters.AddWithValue("@tk","700");
                    cmd7.ExecuteNonQuery();
                }

                if (S_D_Enrolled_course.chemistry == "Chemistry")
                {
                    MySqlCommand cmd7;
                    cmd7 = con.CreateCommand();
                    cmd7.CommandText = "INSERT INTO `new_anrolled_coures`(`Subject_Name`, `Email`, `Phone_Number`, `Payment_method`, `Transaction_ID`, `TK`) VALUES(@subject_Name,@Student_Email,@phone,@payment_method,@ts_id,@tk)";
                    cmd7.Parameters.AddWithValue("@subject_Name", "Chemistry");
                    cmd7.Parameters.AddWithValue("@Student_Email", Student_Login_Page.student_email);
                    cmd7.Parameters.AddWithValue("@phone", bkash_ph_number.Text);
                    cmd7.Parameters.AddWithValue("@ts_id", bkash_ts_id.Text);
                    cmd7.Parameters.AddWithValue("@payment_method", "Bkash");
                    cmd7.Parameters.AddWithValue("@tk", "700");
                    cmd7.ExecuteNonQuery();
                }
                if (S_D_Enrolled_course.biology == "Biology")
                {
                    MySqlCommand cmd7;
                    cmd7 = con.CreateCommand();
                    cmd7.CommandText = "INSERT INTO `new_anrolled_coures`(`Subject_Name`, `Email`, `Phone_Number`, `Payment_method`, `Transaction_ID`, `TK`) VALUES(@subject_Name,@Student_Email,@phone,@payment_method,@ts_id,@tk)";
                    cmd7.Parameters.AddWithValue("@subject_Name", "Biology");
                    cmd7.Parameters.AddWithValue("@Student_Email", Student_Login_Page.student_email);
                    cmd7.Parameters.AddWithValue("@phone", bkash_ph_number.Text);
                    cmd7.Parameters.AddWithValue("@ts_id", bkash_ts_id.Text);
                    cmd7.Parameters.AddWithValue("@payment_method", "Bkash");
                    cmd7.Parameters.AddWithValue("@tk", "600");
                    cmd7.ExecuteNonQuery();
                }

                MessageBox.Show("Payment Successfull !!");
                this.Close();
            }
            
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void S_D_make_payment_Load(object sender, EventArgs e)
        {

        }
    }
}

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
using System.Threading;

namespace Learner_s_Point
{
    public partial class Admin_Dashboard : Form
    {
        Thread th;
        String Admin_email;
        int total_student_count = 0, student_details_count = 0,approve_count = 0;
        int add_teacher_count = 0, teacher_details_count = 0, all_course_count = 0;
        int post_count = 0,profile_count = 0;
        public Admin_Dashboard(string admin_email_form_login_form)
        {
            InitializeComponent();
            Admin_email = admin_email_form_login_form;

            /*
            MySqlConnection con = new MySqlConnection(Database_Connect.connect_database());
            con.Open();
            MySqlCommand command;
            command = con.CreateCommand();
            command.CommandText = "SELECT Name FROM `admin` WHERE Email = @admin_Name";
            command.Parameters.AddWithValue("@admin_Name", Admin_email);
            MySqlDataReader sdr = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(sdr);
            con.Close();
            */
            admin_name_lbl.Text = "Admin Name";



        }
        public void open_Home_Page(object obj)
        {
            Application.Run(new Home_Page());
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            a_D_Total_students1.Hide();
            a_D_students_details1.Hide();
            a_D_Approve_Students1.Hide();
            a_D_Add_Teacher1.Hide();
            a_D_Teacher_Details1.Hide();
            a_D_Course_datails1.Hide();
            a_D_post1.Hide();
            a_D_profile1.Hide();

            Load_admin_name();


        }
        public  void Load_admin_name()
        {
            MySqlConnection con1 = new MySqlConnection(Database_Connect.connect_database());
            con1.Open();

            MySqlCommand command;
            command = con1.CreateCommand();
            command.CommandText = "SELECT  `Name` FROM `admin` WHERE Email = @admin_email";
            command.Parameters.AddWithValue("@admin_email", Teacher_Login_page.Admin_ifo);
            MySqlDataReader sdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            sdr.Close();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                admin_name_lbl.Text = dr["Name"].ToString();
                /*
                 byte[] img = (byte[])dt.Rows[0][5];

                 MemoryStream ms = new MemoryStream(img);
                 pictureBox1.Image = Image.FromStream(ms);
                */

                da.Dispose();
            }
            con1.Close();

        }
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void student_details_btn_Click(object sender, EventArgs e)
        {
            profile_count = 0;
            total_student_count = 0;
            approve_count = 0;
            add_teacher_count = 0;
            teacher_details_count = 0;
            all_course_count = 0;
            post_count = 0;
            if (student_details_count % 2 == 0)
            {
                a_D_students_details1.Show();
                a_D_students_details1.BringToFront();
                a_D_Total_students1.Hide();
                a_D_Approve_Students1.Hide();
                a_D_Add_Teacher1.Hide();
                a_D_Teacher_Details1.Hide();
                a_D_Course_datails1.Hide();
                a_D_post1.Hide();
                a_D_profile1.Hide();

                student_details_count++;
            }
            else
            {
                a_D_students_details1.Hide();
                student_details_count++;
            }


        }



        private void total_student_btn_Click(object sender, EventArgs e)
        {
            profile_count = 0;
            student_details_count = 0;
            approve_count = 0;
            add_teacher_count = 0;
            teacher_details_count = 0;
            all_course_count = 0;
            post_count = 0;
            if (total_student_count % 2 == 0)
            {
                a_D_Total_students1.Show();
                a_D_Total_students1.BringToFront();
                a_D_students_details1.Hide();
                a_D_Approve_Students1.Hide();
                a_D_Add_Teacher1.Hide();
                a_D_Teacher_Details1.Hide();
                a_D_Course_datails1.Hide();
                a_D_post1.Hide();
                a_D_profile1.Hide();

                total_student_count++;
            }
            else
            {
                a_D_Total_students1.Hide();
                total_student_count++;
            }
        }



        private void add_techer_btn_Click(object sender, EventArgs e)
        {
            profile_count = 0;
            student_details_count = 0;
            total_student_count = 0;
            approve_count = 0;
            teacher_details_count = 0;
            all_course_count = 0;
            post_count = 0;
            if (add_teacher_count % 2 == 0)
            {
                a_D_Add_Teacher1.Show();
                a_D_Add_Teacher1.BringToFront();
                a_D_Total_students1.Hide();
                a_D_students_details1.Hide();
                a_D_Approve_Students1.Hide();
                a_D_Teacher_Details1.Hide();
                a_D_Course_datails1.Hide();
                a_D_post1.Hide();
                a_D_profile1.Hide();

                add_teacher_count++;
            }
            else
            {
                a_D_Add_Teacher1.Hide();
                add_teacher_count++;
            }

        }

        private void approve_request_btn_Click(object sender, EventArgs e)
        {
            profile_count = 0;
            student_details_count = 0;
            total_student_count = 0;
            add_teacher_count = 0;
            teacher_details_count = 0;
            all_course_count = 0;
            post_count = 0;
            if (approve_count % 2 == 0)
            {
                a_D_Approve_Students1.Show();
                a_D_Approve_Students1.BringToFront();
                a_D_Total_students1.Hide();
                a_D_students_details1.Hide();
                a_D_Add_Teacher1.Hide();
                a_D_Teacher_Details1.Hide();
                a_D_Course_datails1.Hide();
                a_D_post1.Hide();
                a_D_profile1.Hide();

                approve_count++;
            }
            else
            {
                a_D_Approve_Students1.Hide();
                approve_count++;
            }

        }



        private void teacher_details_btn_Click(object sender, EventArgs e)
        {
            profile_count = 0;
            student_details_count = 0;
            total_student_count = 0;
            add_teacher_count = 0;
            approve_count = 0;
            all_course_count = 0;
            post_count = 0;
            if (teacher_details_count % 2 == 0)
            {
                a_D_Teacher_Details1.Show();
                a_D_Teacher_Details1.BringToFront();
                a_D_Total_students1.Hide();
                a_D_students_details1.Hide();
                a_D_Approve_Students1.Hide();
                a_D_Add_Teacher1.Hide();
                a_D_Course_datails1.Hide();
                a_D_post1.Hide();
                a_D_profile1.Hide();

                teacher_details_count++;
            }
            else
            {
                a_D_Teacher_Details1.Hide();
                teacher_details_count++;
            }
        }



        private void all_course_btn_Click(object sender, EventArgs e)
        {
            profile_count = 0;
            student_details_count = 0;
            total_student_count = 0;
            add_teacher_count = 0;
            approve_count = 0;
            teacher_details_count = 0;
            post_count = 0;
            if (all_course_count % 2 == 0)
            {
                a_D_Course_datails1.Show();
                a_D_Course_datails1.BringToFront();
                a_D_Total_students1.Hide();
                a_D_students_details1.Hide();
                a_D_Approve_Students1.Hide();
                a_D_Add_Teacher1.Hide();
                a_D_Teacher_Details1.Hide();
                a_D_post1.Hide();
                a_D_profile1.Hide();

                all_course_count++;
            }
            else
            {
                a_D_Course_datails1.Hide();
                all_course_count++;
            }
            
        }
        private void post_btn_Click(object sender, EventArgs e)
        {

            student_details_count = 0;
            total_student_count = 0;
            add_teacher_count = 0;
            approve_count = 0;
            teacher_details_count = 0;
            all_course_count = 0;
            if (post_count % 2 == 0)
            {
                profile_count = 0;
                a_D_post1.Show();
                a_D_post1.BringToFront();
                a_D_Total_students1.Hide();
                a_D_students_details1.Hide();
                a_D_Approve_Students1.Hide();
                a_D_Add_Teacher1.Hide();
                a_D_Course_datails1.Hide();
                a_D_Teacher_Details1.Hide();
                a_D_profile1.Hide();

                post_count++;
            }
            else
            {
                a_D_post1.Hide();
                post_count++;
            }
            
        }
        private void profile_btn_Click(object sender, EventArgs e)
        {
            
            student_details_count = 0;
            total_student_count = 0;
            add_teacher_count = 0;
            approve_count = 0;
            teacher_details_count = 0;
            all_course_count = 0;
            post_count = 0;
            if (profile_count % 2 == 0)
            {
                a_D_profile1.Show();
                a_D_profile1.BringToFront();
                a_D_Total_students1.Hide();
                a_D_students_details1.Hide();
                a_D_Approve_Students1.Hide();
                a_D_Add_Teacher1.Hide();
                a_D_Teacher_Details1.Hide();
                a_D_Course_datails1.Hide();
                a_D_post1.Hide();

                profile_count++;
            }
            else
            {
                a_D_profile1.Hide();
                profile_count++;
            }
            Load_admin_name();
        }
        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
                th = new Thread(open_Home_Page);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

            }
            else
            {

            }

        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

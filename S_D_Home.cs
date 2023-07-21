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
    public partial class S_D_Home : UserControl
    {
        public static string title, date, description,role_as, Subject_Name, Teacher_Name, Video_Link,teacher_email;
        public S_D_Home()
        {
            InitializeComponent();
        }

        private void S_D_Home_Load(object sender, EventArgs e)
        {
            Post_load();
        }
        public void Post_load()
        {
            MySqlConnection con = new MySqlConnection(Database_Connect.connect_database());
            con.Open();
            MySqlCommand command;
            command = con.CreateCommand();
            command.CommandText = "SELECT `Subject_Name`,`Teacher_Name`, `Video_Link`,`Teacher_Email` FROM `course_details` WHERE Subject_Name IN(SELECT Subject_Name FROM `subjects` WHERE Email = '" + Student_Login_Page.student_email+"')";
            MySqlDataReader sdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            Home_gride.DataSource = dt;

            MySqlCommand command1;
            command1 = con.CreateCommand();
            command1.CommandText = "SELECT `Title`, `Date`, `Description`,`Role_As` FROM `post`;";
            MySqlDataReader sdr1 = command1.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(sdr1);
            con.Close();
            post_dataGrid.DataSource = dt1;
        }

        private void Home_gride_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Subject_Name = Home_gride.SelectedRows[0].Cells[0].Value.ToString();
            Teacher_Name = Home_gride.SelectedRows[0].Cells[1].Value.ToString();
            Video_Link = Home_gride.SelectedRows[0].Cells[2].Value.ToString();
            teacher_email = Home_gride.SelectedRows[0].Cells[3].Value.ToString();
            S_D_Enrolled_course_details obj = new S_D_Enrolled_course_details();
            obj.ShowDialog();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Post_load();
        }

        private void post_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            title = post_dataGrid.SelectedRows[0].Cells[0].Value.ToString();
            date = post_dataGrid.SelectedRows[0].Cells[1].Value.ToString();
            description = post_dataGrid.SelectedRows[0].Cells[2].Value.ToString();
            role_as = post_dataGrid.SelectedRows[0].Cells[3].Value.ToString();
            S_D_Show_post_details obj = new S_D_Show_post_details();
            obj.ShowDialog();
        }
    }
}

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
    public partial class A_D_Total_students : UserControl
    {
        public static string name, email, phone,title,date,description,role_as;

        private void refresh_Click(object sender, EventArgs e)
        {
            data_load();
        }

        public A_D_Total_students()
        {
            InitializeComponent();
        }

        private void A_D_Total_students_Load(object sender, EventArgs e)
        {
            data_load();
        }
        void data_load() {
            MySqlConnection con = new MySqlConnection(Database_Connect.connect_database());
            con.Open();
            MySqlCommand command1;
            command1 = con.CreateCommand();
            command1.CommandText = "SELECT `Name`, `Email`, `Phone` FROM `student`";
            MySqlDataReader sdr1 = command1.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(sdr1);

            total_student_gride.DataSource = dt1;



            MySqlCommand command2;
            command2 = con.CreateCommand();
            command2.CommandText = "SELECT `Title`, `Date`, `Description`,`Role_As` FROM `post`;";
            MySqlDataReader sdr2 = command2.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(sdr2);
            con.Close();
            dataGridView1.DataSource = dt2;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            title = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            date = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            description = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            role_as = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            A_D_Show_post_detailscs obj = new A_D_Show_post_detailscs();
            obj.ShowDialog();

        }

        private void total_student_gride_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            name = total_student_gride.SelectedRows[0].Cells[0].Value.ToString();
            email = total_student_gride.SelectedRows[0].Cells[1].Value.ToString();
            phone = total_student_gride.SelectedRows[0].Cells[2].Value.ToString();

            A_D_Show_all_student obj = new A_D_Show_all_student();
            obj.ShowDialog();
        }
    }
}

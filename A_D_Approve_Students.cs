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
    public partial class A_D_Approve_Students : UserControl
    {
        string abc;
        public A_D_Approve_Students()
        {
            InitializeComponent();
        }
        void dataLoad()
        {
            MySqlConnection con = new MySqlConnection(Database_Connect.connect_database());
            con.Open();
            MySqlCommand command;
            command = con.CreateCommand();
            command.CommandText = "SELECT `Email`, `Phone_Number`, `TRANSACTION_ID`, `Payment_Method`, `Taka` FROM `approve_student`";
            MySqlDataReader sdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            sdr.Close();
            student_details_gride.DataSource = dt;

            MySqlCommand command1;
            command1 = con.CreateCommand();
            command1.CommandText = "SELECT `Subject_Name`, `Email`, `Phone_Number`, `Payment_method`, `Transaction_ID`, `TK` FROM `new_anrolled_coures`";
            MySqlDataReader sdr1 = command1.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(sdr1);
            sdr1.Close();
            con.Close();
            dataGridView1.DataSource = dt1;

        }
        private void A_D_Approve_Students_Load(object sender, EventArgs e)
        {
            dataLoad();
        }
        String temp1, temp2,subject_name,stu_email;
        private void approve_btn_Click(object sender, EventArgs e)
        {
            if (email_serach_box.Text == "") {
                MessageBox.Show("Please Click in a Row");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(Database_Connect.connect_database());
                con.Open();
                if (temp1 == email_serach_box.Text)
                {

                    MySqlCommand command;
                    command = con.CreateCommand();
                    command.CommandText = "DELETE FROM `approve_student` WHERE Email = '" + email_serach_box.Text + "'";
                    command.ExecuteNonQuery();
                    con.Close();
                    dataLoad();
                    email_serach_box.Clear();
                }
                else if (email_serach_box.Text == temp2)
                {


                    MySqlCommand cmd2;
                    cmd2 = con.CreateCommand();
                    cmd2.CommandText = "INSERT INTO `subjects`(`Subject_Name`, `Email`) VALUES(@sub_name,@Email)";
                    cmd2.Parameters.AddWithValue("@sub_name", subject_name);
                    cmd2.Parameters.AddWithValue("@Email", stu_email);
                    cmd2.ExecuteNonQuery();

                    MySqlCommand command;
                    command = con.CreateCommand();
                    command.CommandText = "DELETE FROM `new_anrolled_coures` WHERE Email = '" + email_serach_box.Text + "' AND Subject_Name = '" + subject_name + "'";
                    command.ExecuteNonQuery();
                    con.Close();
                    dataLoad();
                    email_serach_box.Clear();
                }
                else
                {
                    MessageBox.Show("Something Wrong");
                }
                con.Close();
            }

        }

        private void student_details_gride_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            temp1 = student_details_gride.SelectedRows[0].Cells[0].Value.ToString();
            email_serach_box.Text = student_details_gride.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            temp2 = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            email_serach_box.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            subject_name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            stu_email = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}

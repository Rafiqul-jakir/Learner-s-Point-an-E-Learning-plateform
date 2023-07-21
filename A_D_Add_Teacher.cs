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
    public partial class A_D_Add_Teacher : UserControl
    {
        Image techer_pic;
        public A_D_Add_Teacher()
        {
            InitializeComponent();
            techer_pic = teacher_pic.Image;

        }

        private void Add_Teacher_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Database_Connect.connect_database());
            con.Open();
            if (teacher_name.Text == "" || teacher_email.Text == "" || teacher_phone.Text == "" || teacher_pass.Text == "")
            {
                MessageBox.Show("Please Insert All Fields !");
            }
            else
            {
                MySqlCommand cmd1;
                cmd1 = con.CreateCommand();
                cmd1.CommandText = "INSERT INTO `teacher`(`Name`, `Email`, `Phone`, `Password`, `image`) VALUES(@Teacher_Name,@teacher_email,@Teacher_Phone,@Teacher_Pass,@image);";
                cmd1.Parameters.AddWithValue("@Teacher_Name", teacher_name.Text);
                cmd1.Parameters.AddWithValue("@teacher_email", teacher_email.Text);
                cmd1.Parameters.AddWithValue("@Teacher_Phone", teacher_phone.Text);
                cmd1.Parameters.AddWithValue("@Teacher_Pass", teacher_pass.Text);
                cmd1.Parameters.AddWithValue("@image", teacher_pic);
                cmd1.ExecuteNonQuery();
                con.Close();
                ResetFormData();
                MessageBox.Show("Teacher Added Successfully !");

            }
        }
        public void ResetFormData()
        {
            teacher_name.Clear();
            teacher_email.Clear();
            teacher_phone.Clear();
            teacher_pass.Clear();
            teacher_pic.Image = techer_pic;
        }

        private void chose_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                teacher_pic.Image = Image.FromFile(opf.FileName);
            }
        }

        private void A_D_Add_Teacher_Load(object sender, EventArgs e)
        {

        }
    }
}

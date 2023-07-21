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
    public partial class A_D_post : UserControl
    {
        public A_D_post()
        {
            InitializeComponent();
        }

        private void post_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Database_Connect.connect_database());
            con.Open();
            if (title_lbl.Text == "" || date_lbl.Text == "" || description_lbl.Text == "" || role_as_txt.Text == "")
            {
                MessageBox.Show("Please Insert All Fields !");
            }
            else
            {
                MySqlCommand cmd1;
                cmd1 = con.CreateCommand();
                cmd1.CommandText = "INSERT INTO post(`Title`, `Date`, `Description`, `Role_As`) VALUES(@title,@date,@description, @role_as)";
                cmd1.Parameters.AddWithValue("@title", title_lbl.Text);
                cmd1.Parameters.AddWithValue("@date", date_lbl.Text);
                cmd1.Parameters.AddWithValue("@description", description_lbl.Text);
                cmd1.Parameters.AddWithValue("@role_as", "Admin");
                cmd1.ExecuteNonQuery();
                con.Close();
                ResetFormData();
                MessageBox.Show("Post Uploaded !!");

            }
        }
        public void ResetFormData()
        {
            title_lbl.Clear();
            date_lbl.Clear();
            description_lbl.Clear();
            role_as_txt.Clear();
        }

        private void role_as_Click(object sender, EventArgs e)
        {

        }

        private void role_as_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void description_Click(object sender, EventArgs e)
        {

        }

        private void description_lbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void date_lbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void title_lbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void A_D_post_Load(object sender, EventArgs e)
        {

        }
    }
}

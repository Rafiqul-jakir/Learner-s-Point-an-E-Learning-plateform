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
    public partial class Admin_update_profile : Form
    {
        Image img;

        public Admin_update_profile()
        {
            InitializeComponent();
            img = update_pic.Image;
        }

        private void Admin_update_profile_Load(object sender, EventArgs e)
        {

        }

        private void choose_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                update_pic.Image = Image.FromFile(opf.FileName);

                MemoryStream ms = new MemoryStream();
                update_pic.Image.Save(ms, update_pic.Image.RawFormat);
                byte[] userImg = ms.ToArray();
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (update_name.Text == "" || update_email.Text == "" || Update_phone.Text == "" || update_pass.Text == "" || update_pic.Image == null)
            {
                MessageBox.Show("Please Insert Actual Value !");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(Database_Connect.connect_database());
                con.Open();

                MySqlCommand cmd6;
                cmd6 = con.CreateCommand();
                cmd6.CommandText = "UPDATE `admin` SET `Name`=@name,`Email`=@email,`Phone`=@phone,`Password`=@pass,`imag`=@img WHERE Email = @email1;";
                cmd6.Parameters.AddWithValue("@name", update_name.Text);
                cmd6.Parameters.AddWithValue("@email", update_email.Text);
                cmd6.Parameters.AddWithValue("@phone", Update_phone.Text);
                cmd6.Parameters.AddWithValue("@pass", update_pass.Text);

                MemoryStream ms = new MemoryStream();
                update_pic.Image.Save(ms, update_pic.Image.RawFormat);
                byte[] img = ms.ToArray();
                cmd6.Parameters.Add("@img", MySqlDbType.Blob);
                cmd6.Parameters["@img"].Value = img;

                cmd6.Parameters.AddWithValue("@email1", Teacher_Login_page.Admin_ifo);
                cmd6.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updated Successfully !!!");

                Teacher_Login_page.Admin_ifo = update_email.Text;
                reset();
                this.Close();
            }
        }
        void reset()
        {
            update_name.Clear();
            update_email.Clear();
            Update_phone.Clear();
            update_pass.Clear();
            update_pic.Image = img;

        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

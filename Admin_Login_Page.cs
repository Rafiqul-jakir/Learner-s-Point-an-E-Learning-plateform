using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;

namespace Learner_s_Point
{
    public partial class Teacher_Login_page : Form
    {
        Thread th;
        public static String Admin_email;
        public static string Admin_ifo;
        public Teacher_Login_page()
        {
            InitializeComponent();
        }
        public void open_Home_Page(object obj)
        {
            Application.Run(new Home_Page());
        }

        public void open_admin_dashboard(object obj)
        {
            Application.Run(new Admin_Dashboard(Admin_email));

        }
        private void txt_admin_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_admin_login_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Database_Connect.connect_database());
            con.Open();
            if (txt_admin_email.Text == "" || txt_admin_pass.Text == "")
            {
                MessageBox.Show("Please Insert Email and Password !");

            }

            else
            {

                MySqlCommand command;
                MySqlDataReader mdr;
                string selectQuery = "SELECT Email,Password FROM admin WHERE Email = '" + txt_admin_email.Text + "' AND Password = '" + txt_admin_pass.Text + "'";
                command = new MySqlCommand(selectQuery, con);
                mdr = command.ExecuteReader();

                if (mdr.Read())
                {

                    Admin_email = txt_admin_email.Text;
                    Admin_ifo = Admin_email;
                    this.Close();
                    th = new Thread(open_admin_dashboard);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();

                }
                else
                {
                    MessageBox.Show("Email or Password Incorrect !!");
                }


            }
            con.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            th= new Thread(open_Home_Page);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void Teacher_Login_page_Load(object sender, EventArgs e)
        {

        }

        private void password_show_ckb_CheckedChanged(object sender, EventArgs e)
        {
            if (password_show_ckb.Checked)
            {
                txt_admin_pass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_admin_pass.UseSystemPasswordChar = true;
                
            }
        }

        private void forgot_password_Click(object sender, EventArgs e)
        {
            forgot_admin_password obj = new forgot_admin_password();
            obj.ShowDialog();
        }
    }
}

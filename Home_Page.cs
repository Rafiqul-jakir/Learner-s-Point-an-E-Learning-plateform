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

namespace Learner_s_Point
{
    public partial class Home_Page : Form
    {
        Thread th;
        public Home_Page()
        {
            InitializeComponent();
        }
        public void open_Admin_Login(object obj)
        {
            Application.Run(new Teacher_Login_page());
        }
        public void open_Teacher_Login(object obj)
        {
            Application.Run(new Teachers_Login_Page());
        }
        public void open_Student_Login(object obj)
        {
            Application.Run(new Student_Login_Page());
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void admin_btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open_Admin_Login);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void teacher_btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open_Teacher_Login);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void student_btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open_Student_Login);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learner_s_Point
{
    public partial class admin_email_verification : Form
    {
        public admin_email_verification()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void admin_email_verification_Load(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void veryfy_btn_Click(object sender, EventArgs e)
        {
            if(forgot_admin_password.randomcode == verification_code_txt.Text)
            {
                this.Close();
                admin_reset_pass obj = new admin_reset_pass();
                obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verification Code Note Matched !");
            }

        }
    }
}

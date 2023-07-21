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
    public partial class S_D_Enrolled_course_details : Form
    {
        public S_D_Enrolled_course_details()
        {
            InitializeComponent();
        }

        private void S_D_Enrolled_course_details_Load(object sender, EventArgs e)
        {
            sub_name.Text = S_D_Home.Subject_Name;
            teacher_name.Text = S_D_Home.Teacher_Name;
            video_link.Text = S_D_Home.Video_Link;
            t_email.Text = S_D_Home.teacher_email;
        }
    }
}

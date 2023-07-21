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
    public partial class A_D_Show_all_student : Form
    {
        public A_D_Show_all_student()
        {
            InitializeComponent();
        }

        private void A_D_Show_all_student_Load(object sender, EventArgs e)
        {
            student_name.Text = A_D_Total_students.name;
            student_email.Text = A_D_Total_students.email;
            student_phone.Text = A_D_Total_students.phone;
        }
    }
}

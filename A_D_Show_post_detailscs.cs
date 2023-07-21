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
    public partial class A_D_Show_post_detailscs : Form
    {
        public A_D_Show_post_detailscs()
        {
            InitializeComponent();
        }

        private void A_D_Show_post_detailscs_Load(object sender, EventArgs e)
        {
            title.Text = A_D_Total_students.title;
            date.Text = A_D_Total_students.date;
            description.Text = A_D_Total_students.description;
            role_as.Text = A_D_Total_students.role_as;
        }
    }
}

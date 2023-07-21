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
    public partial class A_D_Teacher_Details : UserControl
    {
        public A_D_Teacher_Details()
        {
            InitializeComponent();
        }

        private void A_D_Teacher_Details_Load(object sender, EventArgs e)
        {
            dataLoad();
        }
        void dataLoad() {
            MySqlConnection con = new MySqlConnection(Database_Connect.connect_database());
            con.Open();
            MySqlCommand command1;
            command1 = con.CreateCommand();
            command1.CommandText = "SELECT `Teacher_ID`, `Name`, `Email`, `Phone` FROM `teacher`;";
            MySqlDataReader sdr1 = command1.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(sdr1);
            con.Close();
            all_teacher_gride.DataSource = dt1;
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            dataLoad();
        }
    }
}

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
using System.IO;

namespace Learner_s_Point
{

    public partial class payment_System : Form
    {
        Thread th;
        public payment_System()
        {
            InitializeComponent();
        }
        public void open_Student_Login(object obj)
        {
            Application.Run(new Student_Login_Page());
        }

        private void payment_System_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        int payable_taka = 0;
        private void checkBox_ict_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ict.Checked)
            {
                payable_taka += 500;
                lbl_payment_taka.Text = payable_taka.ToString();
            }
            else
            {
                payable_taka -= 500;
                lbl_payment_taka.Text = payable_taka.ToString();
            }
        }

        private void checkBox_physics_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_physics.Checked)
            {
                payable_taka += 700;
                lbl_payment_taka.Text = payable_taka.ToString();
            }
            else
            {
                payable_taka -= 700;
                lbl_payment_taka.Text = payable_taka.ToString();
            }

        }

        private void checkBox_chemistry_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_chemistry.Checked)
            {
                payable_taka += 700;
                lbl_payment_taka.Text = payable_taka.ToString();
            }
            else
            {
                payable_taka -= 700;
                lbl_payment_taka.Text = payable_taka.ToString();
            }
        }

        private void checkBox_biology_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_biology.Checked)
            {
                payable_taka += 600;
                lbl_payment_taka.Text = payable_taka.ToString();
            }
            else
            {
                payable_taka -= 600;
                lbl_payment_taka.Text = payable_taka.ToString();
            }

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_bkash_pay_Click(object sender, EventArgs e)
        {
            if(checkBox_ict.Checked || checkBox_physics.Checked || checkBox_chemistry.Checked || checkBox_biology.Checked)
            {

                if (bkash_ph_number.Text == "" || bkash_ts_id.Text == "")
                {
                    MessageBox.Show("Please Insert Actual Value !");
                }
                else
                {
                    MySqlConnection con = new MySqlConnection(Database_Connect.connect_database());
                    con.Open();
                    if(checkBox_ict.Checked)
                    {
                        MySqlCommand cmd7;
                        cmd7 = con.CreateCommand();
                        cmd7.CommandText = "INSERT INTO `subjects`(`Subject_Name`, `Email`) VALUES(@subject_Name,@Student_Email)";
                        cmd7.Parameters.AddWithValue("@subject_Name","ICT");
                        cmd7.Parameters.AddWithValue("@Student_Email", student_reg.student_email);
                        cmd7.ExecuteNonQuery();
                    }

                    if(checkBox_physics.Checked)
                    {
                        MySqlCommand cmd3;
                        cmd3 = con.CreateCommand();
                        cmd3.CommandText = "INSERT INTO `subjects`(`Subject_Name`, `Email`) VALUES(@subject_Name,@Student_Email)";
                        cmd3.Parameters.AddWithValue("@subject_Name", "Physics");
                        cmd3.Parameters.AddWithValue("@Student_Email", student_reg.student_email);
                        cmd3.ExecuteNonQuery();
                    }

                    if (checkBox_chemistry.Checked)
                    {
                        MySqlCommand cmd4;
                        cmd4 = con.CreateCommand();
                        cmd4.CommandText = "INSERT INTO `subjects`(`Subject_Name`, `Email`) VALUES(@subject_Name,@Student_Email)";
                        cmd4.Parameters.AddWithValue("@subject_Name", "Chemistry");
                        cmd4.Parameters.AddWithValue("@Student_Email", student_reg.student_email);
                        cmd4.ExecuteNonQuery();
                    }
                    if (checkBox_biology.Checked)
                    {
                        MySqlCommand cmd5;
                        cmd5 = con.CreateCommand();
                        cmd5.CommandText = "INSERT INTO `subjects`(`Subject_Name`, `Email`) VALUES(@subject_Name,@Student_Email)";
                        cmd5.Parameters.AddWithValue("@subject_Name", "Biology");
                        cmd5.Parameters.AddWithValue("@Student_Email", student_reg.student_email);
                        cmd5.ExecuteNonQuery();
                    }



                    MySqlCommand cmd6;
                    cmd6 = con.CreateCommand();
                    cmd6.CommandText = "INSERT INTO student(Name,Email,Phone,Password,image) VALUES(@Student_Name,@Student_Email,@Student_Phone, @Student_Password,@image)";
                    cmd6.Parameters.AddWithValue("@Student_Name", student_reg.student_name);
                    cmd6.Parameters.AddWithValue("@Student_Email", student_reg.student_email);
                    cmd6.Parameters.AddWithValue("@Student_Phone", student_reg.student_phone);
                    cmd6.Parameters.AddWithValue("@Student_Password", student_reg.student_pass);
                    cmd6.Parameters.AddWithValue("@image", student_reg.student_image);
                    cmd6.ExecuteNonQuery();


                    MySqlCommand cmd1;
                    cmd1 = con.CreateCommand();
                    cmd1.CommandText = "INSERT INTO `approve_student`(`Name`, `Email`, `Phone_Number`, `TRANSACTION_ID`, `Payment_Method`, `Password`,`Taka`) VALUES(@Student_Name,@Student_Email,@Student_Phone,@TRANSACTION_ID,@Payment_Method, @Student_Password,@taka)";
                    cmd1.Parameters.AddWithValue("@Student_Name", student_reg.student_name);
                    cmd1.Parameters.AddWithValue("@Student_Email", student_reg.student_email);
                    cmd1.Parameters.AddWithValue("@Student_Phone", bkash_ph_number.Text);
                    cmd1.Parameters.AddWithValue("@@TRANSACTION_ID", bkash_ts_id.Text);
                    cmd1.Parameters.AddWithValue("@Payment_Method", "Bkash");
                    cmd1.Parameters.AddWithValue("@Student_Password", student_reg.student_pass);
                    cmd1.Parameters.AddWithValue("@taka", payable_taka);
                    cmd1.ExecuteNonQuery();


                    MySqlCommand cmd2;
                    cmd2 = con.CreateCommand();
                    cmd2.CommandText = "INSERT INTO `payment_details`(`Email`, `Phone_Number`, `TRANSACTION_ID`, `Payment_Method`, `Taka`) VALUES (@Student_Email,@Student_Phone,@TRANSACTION_ID,@Payment_Method,@taka)";
                    cmd2.Parameters.AddWithValue("@Student_Email", student_reg.student_email);
                    cmd2.Parameters.AddWithValue("@Student_Phone", bkash_ph_number.Text);
                    cmd2.Parameters.AddWithValue("@@TRANSACTION_ID", bkash_ts_id.Text);
                    cmd2.Parameters.AddWithValue("@Payment_Method", "Bkash");
                    cmd2.Parameters.AddWithValue("@taka", payable_taka);
                    cmd2.ExecuteNonQuery();

                    con.Close();

                    reset_bkash_value();
                    MessageBox.Show("Registration Completed Successfully!");
                    this.Close();
                    th = new Thread(open_Student_Login);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
            }
            else
            {
                MessageBox.Show("You Must Select at list One Subject !");
            }

             
        }

        private void reset_bkash_value()
        {
            bkash_ph_number.Clear();
            bkash_ts_id.Clear();
        }

        private void btn_nogod_pay_Click(object sender, EventArgs e)
        {
            if (checkBox_ict.Checked || checkBox_physics.Checked || checkBox_chemistry.Checked || checkBox_biology.Checked)
            {
                if (nogod_ph_number.Text == "" || nogod_ts_id.Text == "")
                {
                    MessageBox.Show("Please Insert Actual Value !");
                }
                else
                {
                    MySqlConnection con = new MySqlConnection(Database_Connect.connect_database());
                    con.Open();
                    if (checkBox_ict.Checked)
                    {
                        MySqlCommand cmd7;
                        cmd7 = con.CreateCommand();
                        cmd7.CommandText = "INSERT INTO `subjects`(`Subject_Name`, `Email`) VALUES(@subject_Name,@Student_Email)";
                        cmd7.Parameters.AddWithValue("@subject_Name", "ICT");
                        cmd7.Parameters.AddWithValue("@Student_Email", student_reg.student_email);
                        cmd7.ExecuteNonQuery();
                    }

                    if (checkBox_physics.Checked)
                    {
                        MySqlCommand cmd3;
                        cmd3 = con.CreateCommand();
                        cmd3.CommandText = "INSERT INTO `subjects`(`Subject_Name`, `Email`) VALUES(@subject_Name,@Student_Email)";
                        cmd3.Parameters.AddWithValue("@subject_Name", "Physics");
                        cmd3.Parameters.AddWithValue("@Student_Email", student_reg.student_email);
                        cmd3.ExecuteNonQuery();
                    }

                    if (checkBox_chemistry.Checked)
                    {
                        MySqlCommand cmd4;
                        cmd4 = con.CreateCommand();
                        cmd4.CommandText = "INSERT INTO `subjects`(`Subject_Name`, `Email`) VALUES(@subject_Name,@Student_Email)";
                        cmd4.Parameters.AddWithValue("@subject_Name", "Chemistry");
                        cmd4.Parameters.AddWithValue("@Student_Email", student_reg.student_email);
                        cmd4.ExecuteNonQuery();
                    }
                    if (checkBox_biology.Checked)
                    {
                        MySqlCommand cmd5;
                        cmd5 = con.CreateCommand();
                        cmd5.CommandText = "INSERT INTO `subjects`(`Subject_Name`, `Email`) VALUES(@subject_Name,@Student_Email)";
                        cmd5.Parameters.AddWithValue("@subject_Name", "Biology");
                        cmd5.Parameters.AddWithValue("@Student_Email", student_reg.student_email);
                        cmd5.ExecuteNonQuery();
                    }

                    MySqlCommand cmd6;
                    cmd6 = con.CreateCommand();
                    cmd6.CommandText = "INSERT INTO student(Name,Email,Phone,Password,image) VALUES(@Student_Name,@Student_Email,@Student_Phone, @Student_Password,@image)";
                    cmd6.Parameters.AddWithValue("@Student_Name", student_reg.student_name);
                    cmd6.Parameters.AddWithValue("@Student_Email", student_reg.student_email);
                    cmd6.Parameters.AddWithValue("@Student_Phone", student_reg.student_phone);
                    cmd6.Parameters.AddWithValue("@Student_Password", student_reg.student_pass);
                    cmd6.Parameters.AddWithValue("@image", student_reg.student_image);
                    cmd6.ExecuteNonQuery();

                    MySqlCommand cmd2;
                    cmd2 = con.CreateCommand();
                    cmd2.CommandText = "INSERT INTO `payment_details`(`Email`, `Phone_Number`, `TRANSACTION_ID`, `Payment_Method`, `Taka`) VALUES (@Student_Email,@Student_Phone,@TRANSACTION_ID,@Payment_Method,@taka)";
                    cmd2.Parameters.AddWithValue("@Student_Email", student_reg.student_email);
                    cmd2.Parameters.AddWithValue("@Student_Phone", nogod_ph_number.Text);
                    cmd2.Parameters.AddWithValue("@@TRANSACTION_ID", nogod_ts_id.Text);
                    cmd2.Parameters.AddWithValue("@Payment_Method", "Nogod");
                    cmd2.Parameters.AddWithValue("@taka", payable_taka);
                    cmd2.ExecuteNonQuery();


                    MySqlCommand cmd1;
                    cmd1 = con.CreateCommand();
                    cmd1.CommandText = "INSERT INTO `approve_student`(`Name`, `Email`, `Phone_Number`, `TRANSACTION_ID`, `Payment_Method`, `Password`, `Taka`) VALUES(@Student_Name,@Student_Email,@Student_Phone,@TRANSACTION_ID,@Payment_Method, @Student_Password,@taka)";
                    cmd1.Parameters.AddWithValue("@Student_Name", student_reg.student_name);
                    cmd1.Parameters.AddWithValue("@Student_Email", student_reg.student_email);
                    cmd1.Parameters.AddWithValue("@Student_Phone", nogod_ph_number.Text);
                    cmd1.Parameters.AddWithValue("@@TRANSACTION_ID", nogod_ts_id.Text);
                    cmd1.Parameters.AddWithValue("@Payment_Method", "Nogod");
                    cmd1.Parameters.AddWithValue("@Student_Password", student_reg.student_pass);
                    cmd1.Parameters.AddWithValue("@taka", payable_taka);
                    cmd1.ExecuteNonQuery();
                    con.Close();

                    reset_nogod_value();
                    MessageBox.Show("Payment Successfull !!");
                    this.Close();
                    th = new Thread(open_Student_Login);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
            }
            else
            {
                MessageBox.Show("You must Select at list One Subject !");
            }

        }
        private void reset_nogod_value()
        {
            nogod_ph_number.Clear();
            nogod_ts_id.Clear();
        }
        private void btn_rocket_pay_Click(object sender, EventArgs e)
        {
            if (checkBox_ict.Checked || checkBox_physics.Checked || checkBox_chemistry.Checked || checkBox_biology.Checked)
            {
                if (rocket_ph_number.Text == "" || rocket_ts_id.Text == "")
                {
                    MessageBox.Show("Please Insert Actual Value !");
                }
                else
                {
                    MySqlConnection con = new MySqlConnection(Database_Connect.connect_database());
                    con.Open();
                    if (checkBox_ict.Checked)
                    {
                        MySqlCommand cmd7;
                        cmd7 = con.CreateCommand();
                        cmd7.CommandText = "INSERT INTO `subjects`(`Subject_Name`, `Email`) VALUES(@subject_Name,@Student_Email)";
                        cmd7.Parameters.AddWithValue("@subject_Name", "ICT");
                        cmd7.Parameters.AddWithValue("@Student_Email", student_reg.student_email);
                        cmd7.ExecuteNonQuery();
                    }

                    if (checkBox_physics.Checked)
                    {
                        MySqlCommand cmd3;
                        cmd3 = con.CreateCommand();
                        cmd3.CommandText = "INSERT INTO `subjects`(`Subject_Name`, `Email`) VALUES(@subject_Name,@Student_Email)";
                        cmd3.Parameters.AddWithValue("@subject_Name", "Physics");
                        cmd3.Parameters.AddWithValue("@Student_Email", student_reg.student_email);
                        cmd3.ExecuteNonQuery();
                    }

                    if (checkBox_chemistry.Checked)
                    {
                        MySqlCommand cmd4;
                        cmd4 = con.CreateCommand();
                        cmd4.CommandText = "INSERT INTO `subjects`(`Subject_Name`, `Email`) VALUES(@subject_Name,@Student_Email)";
                        cmd4.Parameters.AddWithValue("@subject_Name", "Chemistry");
                        cmd4.Parameters.AddWithValue("@Student_Email", student_reg.student_email);
                        cmd4.ExecuteNonQuery();
                    }
                    if (checkBox_biology.Checked)
                    {
                        MySqlCommand cmd5;
                        cmd5 = con.CreateCommand();
                        cmd5.CommandText = "INSERT INTO `subjects`(`Subject_Name`, `Email`) VALUES(@subject_Name,@Student_Email)";
                        cmd5.Parameters.AddWithValue("@subject_Name", "Biology");
                        cmd5.Parameters.AddWithValue("@Student_Email", student_reg.student_email);
                        cmd5.ExecuteNonQuery();
                    }

                    MySqlCommand cmd6;
                    cmd6 = con.CreateCommand();
                    cmd6.CommandText = "INSERT INTO student(Name,Email,Phone,Password,image) VALUES(@Student_Name,@Student_Email,@Student_Phone, @Student_Password,image)";
                    cmd6.Parameters.AddWithValue("@Student_Name", student_reg.student_name);
                    cmd6.Parameters.AddWithValue("@Student_Email", student_reg.student_email);
                    cmd6.Parameters.AddWithValue("@Student_Phone", student_reg.student_phone);
                    cmd6.Parameters.AddWithValue("@Student_Password", student_reg.student_pass);
                    cmd6.Parameters.AddWithValue("@image", student_reg.student_image);
                    cmd6.ExecuteNonQuery();

                    MySqlCommand cmd9;
                    cmd9 = con.CreateCommand();
                    cmd9.CommandText = "INSERT INTO `payment_details`(`Email`, `Phone_Number`, `TRANSACTION_ID`, `Payment_Method`, `Taka`) VALUES (@Student_Email,@Student_Phone,@TRANSACTION_ID,@Payment_Method,@taka)";
                    cmd9.Parameters.AddWithValue("@Student_Email", student_reg.student_email);
                    cmd9.Parameters.AddWithValue("@Student_Phone", rocket_ph_number.Text);
                    cmd9.Parameters.AddWithValue("@@TRANSACTION_ID", rocket_ts_id.Text);
                    cmd9.Parameters.AddWithValue("@Payment_Method", "Rocket");
                    cmd9.Parameters.AddWithValue("@taka", payable_taka);
                    cmd9.ExecuteNonQuery();

                    MySqlCommand cmd1;
                    cmd1 = con.CreateCommand();
                    cmd1.CommandText = "INSERT INTO `approve_student`(`Name`, `Email`, `Phone_Number`, `TRANSACTION_ID`, `Payment_Method`, `Password`, `Taka`) VALUES(@Student_Name,@Student_Email,@Student_Phone,@TRANSACTION_ID,@Payment_Method, @Student_Password,@taka)";
                    cmd1.Parameters.AddWithValue("@Student_Name", student_reg.student_name);
                    cmd1.Parameters.AddWithValue("@Student_Email", student_reg.student_email);
                    cmd1.Parameters.AddWithValue("@Student_Phone", rocket_ph_number.Text);
                    cmd1.Parameters.AddWithValue("@@TRANSACTION_ID", rocket_ts_id.Text);
                    cmd1.Parameters.AddWithValue("@Payment_Method", "Rocket");
                    cmd1.Parameters.AddWithValue("@Student_Password", student_reg.student_pass);
                    cmd1.Parameters.AddWithValue("@taka", payable_taka);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                     
                    reset_rocket_value();
                    MessageBox.Show("Payment Successfull !!");
                    this.Close();
                    th = new Thread(open_Student_Login);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
            }
            else
            {
                MessageBox.Show("You must Select at list One Subject !");
            }

        }
        private void reset_rocket_value()
        {
            rocket_ph_number.Clear();
            rocket_ts_id.Clear();
        }
    }
}

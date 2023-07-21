namespace Learner_s_Point
{
    partial class Admin_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Dashboard));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.logout_btn = new System.Windows.Forms.Button();
            this.all_course_btn = new System.Windows.Forms.Button();
            this.profile_btn = new System.Windows.Forms.Button();
            this.teacher_details_btn = new System.Windows.Forms.Button();
            this.add_techer_btn = new System.Windows.Forms.Button();
            this.approve_request_btn = new System.Windows.Forms.Button();
            this.post_btn = new System.Windows.Forms.Button();
            this.student_details_btn = new System.Windows.Forms.Button();
            this.total_student_btn = new System.Windows.Forms.Button();
            this.admin_name_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.a_D_profile1 = new Learner_s_Point.A_D_profile();
            this.a_D_post1 = new Learner_s_Point.A_D_post();
            this.a_D_Course_datails1 = new Learner_s_Point.A_D_Course_datails();
            this.a_D_Teacher_Details1 = new Learner_s_Point.A_D_Teacher_Details();
            this.a_D_Add_Teacher1 = new Learner_s_Point.A_D_Add_Teacher();
            this.a_D_Approve_Students1 = new Learner_s_Point.A_D_Approve_Students();
            this.a_D_students_details1 = new Learner_s_Point.A_D_students_details();
            this.a_D_Total_students1 = new Learner_s_Point.A_D_Total_students();
            this.exit_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.logout_btn);
            this.splitContainer1.Panel1.Controls.Add(this.all_course_btn);
            this.splitContainer1.Panel1.Controls.Add(this.profile_btn);
            this.splitContainer1.Panel1.Controls.Add(this.teacher_details_btn);
            this.splitContainer1.Panel1.Controls.Add(this.add_techer_btn);
            this.splitContainer1.Panel1.Controls.Add(this.approve_request_btn);
            this.splitContainer1.Panel1.Controls.Add(this.post_btn);
            this.splitContainer1.Panel1.Controls.Add(this.student_details_btn);
            this.splitContainer1.Panel1.Controls.Add(this.total_student_btn);
            this.splitContainer1.Panel1.Controls.Add(this.admin_name_lbl);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.a_D_profile1);
            this.splitContainer1.Panel2.Controls.Add(this.a_D_post1);
            this.splitContainer1.Panel2.Controls.Add(this.a_D_Course_datails1);
            this.splitContainer1.Panel2.Controls.Add(this.a_D_Teacher_Details1);
            this.splitContainer1.Panel2.Controls.Add(this.a_D_Add_Teacher1);
            this.splitContainer1.Panel2.Controls.Add(this.a_D_Approve_Students1);
            this.splitContainer1.Panel2.Controls.Add(this.a_D_students_details1);
            this.splitContainer1.Panel2.Controls.Add(this.a_D_Total_students1);
            this.splitContainer1.Panel2.Controls.Add(this.exit_btn);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(820, 587);
            this.splitContainer1.SplitterDistance = 223;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.logout_btn.FlatAppearance.BorderSize = 10;
            this.logout_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(8, 540);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(206, 40);
            this.logout_btn.TabIndex = 10;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // all_course_btn
            // 
            this.all_course_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.all_course_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.all_course_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.all_course_btn.FlatAppearance.BorderSize = 10;
            this.all_course_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_course_btn.ForeColor = System.Drawing.Color.White;
            this.all_course_btn.Location = new System.Drawing.Point(8, 404);
            this.all_course_btn.Name = "all_course_btn";
            this.all_course_btn.Size = new System.Drawing.Size(206, 40);
            this.all_course_btn.TabIndex = 9;
            this.all_course_btn.Text = "All Course Details";
            this.all_course_btn.UseVisualStyleBackColor = false;
            this.all_course_btn.Click += new System.EventHandler(this.all_course_btn_Click);
            // 
            // profile_btn
            // 
            this.profile_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.profile_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.profile_btn.FlatAppearance.BorderSize = 10;
            this.profile_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_btn.ForeColor = System.Drawing.Color.White;
            this.profile_btn.Location = new System.Drawing.Point(8, 496);
            this.profile_btn.Name = "profile_btn";
            this.profile_btn.Size = new System.Drawing.Size(206, 40);
            this.profile_btn.TabIndex = 8;
            this.profile_btn.Text = "Profile";
            this.profile_btn.UseVisualStyleBackColor = false;
            this.profile_btn.Click += new System.EventHandler(this.profile_btn_Click);
            // 
            // teacher_details_btn
            // 
            this.teacher_details_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.teacher_details_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teacher_details_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.teacher_details_btn.FlatAppearance.BorderSize = 10;
            this.teacher_details_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_details_btn.ForeColor = System.Drawing.Color.White;
            this.teacher_details_btn.Location = new System.Drawing.Point(8, 358);
            this.teacher_details_btn.Name = "teacher_details_btn";
            this.teacher_details_btn.Size = new System.Drawing.Size(206, 40);
            this.teacher_details_btn.TabIndex = 7;
            this.teacher_details_btn.Text = "Teachers Details";
            this.teacher_details_btn.UseVisualStyleBackColor = false;
            this.teacher_details_btn.Click += new System.EventHandler(this.teacher_details_btn_Click);
            // 
            // add_techer_btn
            // 
            this.add_techer_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.add_techer_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_techer_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.add_techer_btn.FlatAppearance.BorderSize = 10;
            this.add_techer_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_techer_btn.ForeColor = System.Drawing.Color.White;
            this.add_techer_btn.Location = new System.Drawing.Point(8, 312);
            this.add_techer_btn.Name = "add_techer_btn";
            this.add_techer_btn.Size = new System.Drawing.Size(206, 40);
            this.add_techer_btn.TabIndex = 6;
            this.add_techer_btn.Text = "Add Teacher";
            this.add_techer_btn.UseVisualStyleBackColor = false;
            this.add_techer_btn.Click += new System.EventHandler(this.add_techer_btn_Click);
            // 
            // approve_request_btn
            // 
            this.approve_request_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.approve_request_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.approve_request_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.approve_request_btn.FlatAppearance.BorderSize = 10;
            this.approve_request_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approve_request_btn.ForeColor = System.Drawing.Color.White;
            this.approve_request_btn.Location = new System.Drawing.Point(8, 266);
            this.approve_request_btn.Name = "approve_request_btn";
            this.approve_request_btn.Size = new System.Drawing.Size(206, 40);
            this.approve_request_btn.TabIndex = 5;
            this.approve_request_btn.Text = "Approve Request";
            this.approve_request_btn.UseVisualStyleBackColor = false;
            this.approve_request_btn.Click += new System.EventHandler(this.approve_request_btn_Click);
            // 
            // post_btn
            // 
            this.post_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.post_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.post_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.post_btn.FlatAppearance.BorderSize = 10;
            this.post_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post_btn.ForeColor = System.Drawing.Color.White;
            this.post_btn.Location = new System.Drawing.Point(8, 450);
            this.post_btn.Name = "post_btn";
            this.post_btn.Size = new System.Drawing.Size(206, 40);
            this.post_btn.TabIndex = 4;
            this.post_btn.Text = "Post";
            this.post_btn.UseVisualStyleBackColor = false;
            this.post_btn.Click += new System.EventHandler(this.post_btn_Click);
            // 
            // student_details_btn
            // 
            this.student_details_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.student_details_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student_details_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.student_details_btn.FlatAppearance.BorderSize = 10;
            this.student_details_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_details_btn.ForeColor = System.Drawing.Color.White;
            this.student_details_btn.Location = new System.Drawing.Point(8, 220);
            this.student_details_btn.Name = "student_details_btn";
            this.student_details_btn.Size = new System.Drawing.Size(206, 40);
            this.student_details_btn.TabIndex = 3;
            this.student_details_btn.Text = "Student Details";
            this.student_details_btn.UseVisualStyleBackColor = false;
            this.student_details_btn.Click += new System.EventHandler(this.student_details_btn_Click);
            // 
            // total_student_btn
            // 
            this.total_student_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.total_student_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.total_student_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.total_student_btn.FlatAppearance.BorderSize = 10;
            this.total_student_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_student_btn.ForeColor = System.Drawing.Color.White;
            this.total_student_btn.Location = new System.Drawing.Point(8, 174);
            this.total_student_btn.Name = "total_student_btn";
            this.total_student_btn.Size = new System.Drawing.Size(206, 40);
            this.total_student_btn.TabIndex = 2;
            this.total_student_btn.Text = "Total Student";
            this.total_student_btn.UseVisualStyleBackColor = false;
            this.total_student_btn.Click += new System.EventHandler(this.total_student_btn_Click);
            // 
            // admin_name_lbl
            // 
            this.admin_name_lbl.AutoSize = true;
            this.admin_name_lbl.BackColor = System.Drawing.Color.Transparent;
            this.admin_name_lbl.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_name_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.admin_name_lbl.Location = new System.Drawing.Point(43, 138);
            this.admin_name_lbl.Name = "admin_name_lbl";
            this.admin_name_lbl.Size = new System.Drawing.Size(124, 24);
            this.admin_name_lbl.TabIndex = 1;
            this.admin_name_lbl.Text = "Rafiqu Xakir";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // a_D_profile1
            // 
            this.a_D_profile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.a_D_profile1.Location = new System.Drawing.Point(0, -2);
            this.a_D_profile1.Name = "a_D_profile1";
            this.a_D_profile1.Size = new System.Drawing.Size(586, 582);
            this.a_D_profile1.TabIndex = 12;
            // 
            // a_D_post1
            // 
            this.a_D_post1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.a_D_post1.Location = new System.Drawing.Point(0, -2);
            this.a_D_post1.Name = "a_D_post1";
            this.a_D_post1.Size = new System.Drawing.Size(586, 582);
            this.a_D_post1.TabIndex = 11;
            // 
            // a_D_Course_datails1
            // 
            this.a_D_Course_datails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.a_D_Course_datails1.Location = new System.Drawing.Point(0, -2);
            this.a_D_Course_datails1.Name = "a_D_Course_datails1";
            this.a_D_Course_datails1.Size = new System.Drawing.Size(591, 582);
            this.a_D_Course_datails1.TabIndex = 10;
            // 
            // a_D_Teacher_Details1
            // 
            this.a_D_Teacher_Details1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.a_D_Teacher_Details1.Location = new System.Drawing.Point(0, -2);
            this.a_D_Teacher_Details1.Name = "a_D_Teacher_Details1";
            this.a_D_Teacher_Details1.Size = new System.Drawing.Size(591, 582);
            this.a_D_Teacher_Details1.TabIndex = 9;
            // 
            // a_D_Add_Teacher1
            // 
            this.a_D_Add_Teacher1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.a_D_Add_Teacher1.Location = new System.Drawing.Point(0, -2);
            this.a_D_Add_Teacher1.Name = "a_D_Add_Teacher1";
            this.a_D_Add_Teacher1.Size = new System.Drawing.Size(591, 582);
            this.a_D_Add_Teacher1.TabIndex = 8;
            // 
            // a_D_Approve_Students1
            // 
            this.a_D_Approve_Students1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.a_D_Approve_Students1.Location = new System.Drawing.Point(0, 0);
            this.a_D_Approve_Students1.Name = "a_D_Approve_Students1";
            this.a_D_Approve_Students1.Size = new System.Drawing.Size(591, 585);
            this.a_D_Approve_Students1.TabIndex = 7;
            // 
            // a_D_students_details1
            // 
            this.a_D_students_details1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.a_D_students_details1.Location = new System.Drawing.Point(0, -2);
            this.a_D_students_details1.Name = "a_D_students_details1";
            this.a_D_students_details1.Size = new System.Drawing.Size(591, 587);
            this.a_D_students_details1.TabIndex = 6;
            // 
            // a_D_Total_students1
            // 
            this.a_D_Total_students1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.a_D_Total_students1.Location = new System.Drawing.Point(0, 0);
            this.a_D_Total_students1.Name = "a_D_Total_students1";
            this.a_D_Total_students1.Size = new System.Drawing.Size(591, 585);
            this.a_D_Total_students1.TabIndex = 5;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_btn.BackgroundImage")));
            this.exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Location = new System.Drawing.Point(563, 8);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(14, 14);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(190, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(196, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hello Admin";
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(820, 587);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Admin_Dashboard_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label admin_name_lbl;
        private System.Windows.Forms.Button total_student_btn;
        private System.Windows.Forms.Button teacher_details_btn;
        private System.Windows.Forms.Button add_techer_btn;
        private System.Windows.Forms.Button approve_request_btn;
        private System.Windows.Forms.Button post_btn;
        private System.Windows.Forms.Button student_details_btn;
        private System.Windows.Forms.Button profile_btn;
        private System.Windows.Forms.Button all_course_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit_btn;
        private A_D_Total_students a_D_Total_students1;
        private A_D_students_details a_D_students_details1;

        private A_D_Approve_Students a_D_Approve_Students1;
        private System.Windows.Forms.Button logout_btn;
        private A_D_Add_Teacher a_D_Add_Teacher1;
        private A_D_Teacher_Details a_D_Teacher_Details1;
        private A_D_Course_datails a_D_Course_datails1;
        private A_D_post a_D_post1;
        private A_D_profile a_D_profile1;
    }
}
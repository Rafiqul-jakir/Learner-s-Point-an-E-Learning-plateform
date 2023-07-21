namespace Learner_s_Point
{
    partial class Home_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Page));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.admin_btn = new System.Windows.Forms.Button();
            this.teacher_btn = new System.Windows.Forms.Button();
            this.student_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(259, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(21)))), ((int)(((byte)(254)))));
            this.label1.Location = new System.Drawing.Point(113, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome to Learner\'s Point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "An E-Learning plateform";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(264, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Login As";
            // 
            // admin_btn
            // 
            this.admin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(21)))), ((int)(((byte)(254)))));
            this.admin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_btn.FlatAppearance.BorderSize = 0;
            this.admin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_btn.Font = new System.Drawing.Font("Arial", 15.75F);
            this.admin_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.admin_btn.Location = new System.Drawing.Point(127, 249);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(105, 40);
            this.admin_btn.TabIndex = 13;
            this.admin_btn.Text = "Admin";
            this.admin_btn.UseVisualStyleBackColor = false;
            this.admin_btn.Click += new System.EventHandler(this.admin_btn_Click_1);
            // 
            // teacher_btn
            // 
            this.teacher_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(21)))), ((int)(((byte)(254)))));
            this.teacher_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teacher_btn.FlatAppearance.BorderSize = 0;
            this.teacher_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacher_btn.Font = new System.Drawing.Font("Arial", 15.75F);
            this.teacher_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.teacher_btn.Location = new System.Drawing.Point(257, 249);
            this.teacher_btn.Name = "teacher_btn";
            this.teacher_btn.Size = new System.Drawing.Size(105, 40);
            this.teacher_btn.TabIndex = 14;
            this.teacher_btn.Text = "Teacher";
            this.teacher_btn.UseVisualStyleBackColor = false;
            this.teacher_btn.Click += new System.EventHandler(this.teacher_btn_Click_1);
            // 
            // student_btn
            // 
            this.student_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(21)))), ((int)(((byte)(254)))));
            this.student_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student_btn.FlatAppearance.BorderSize = 0;
            this.student_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_btn.Font = new System.Drawing.Font("Arial", 15.75F);
            this.student_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.student_btn.Location = new System.Drawing.Point(387, 249);
            this.student_btn.Name = "student_btn";
            this.student_btn.Size = new System.Drawing.Size(105, 40);
            this.student_btn.TabIndex = 15;
            this.student_btn.Text = "Student";
            this.student_btn.UseVisualStyleBackColor = false;
            this.student_btn.Click += new System.EventHandler(this.student_btn_Click_1);
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(606, 340);
            this.Controls.Add(this.student_btn);
            this.Controls.Add(this.teacher_btn);
            this.Controls.Add(this.admin_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Home_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button admin_btn;
        private System.Windows.Forms.Button teacher_btn;
        private System.Windows.Forms.Button student_btn;
    }
}


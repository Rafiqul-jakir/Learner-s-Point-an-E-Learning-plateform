namespace Learner_s_Point
{
    partial class Teacher_Login_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher_Login_page));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_admin_email = new System.Windows.Forms.TextBox();
            this.txt_admin_pass = new System.Windows.Forms.TextBox();
            this.btn_admin_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.password_show_ckb = new System.Windows.Forms.CheckBox();
            this.forgot_password = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // txt_admin_email
            // 
            this.txt_admin_email.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_admin_email.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_admin_email.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_admin_email.Location = new System.Drawing.Point(351, 128);
            this.txt_admin_email.Name = "txt_admin_email";
            this.txt_admin_email.Size = new System.Drawing.Size(165, 29);
            this.txt_admin_email.TabIndex = 2;
            // 
            // txt_admin_pass
            // 
            this.txt_admin_pass.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_admin_pass.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_admin_pass.Location = new System.Drawing.Point(351, 169);
            this.txt_admin_pass.Name = "txt_admin_pass";
            this.txt_admin_pass.Size = new System.Drawing.Size(165, 29);
            this.txt_admin_pass.TabIndex = 3;
            this.txt_admin_pass.UseSystemPasswordChar = true;
            this.txt_admin_pass.TextChanged += new System.EventHandler(this.txt_admin_pass_TextChanged);
            // 
            // btn_admin_login
            // 
            this.btn_admin_login.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_admin_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_admin_login.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_admin_login.Location = new System.Drawing.Point(351, 236);
            this.btn_admin_login.Name = "btn_admin_login";
            this.btn_admin_login.Size = new System.Drawing.Size(72, 32);
            this.btn_admin_login.TabIndex = 4;
            this.btn_admin_login.Text = "Login";
            this.btn_admin_login.UseVisualStyleBackColor = false;
            this.btn_admin_login.Click += new System.EventHandler(this.btn_admin_login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hello Admin !";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_back.Location = new System.Drawing.Point(444, 236);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(72, 32);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // password_show_ckb
            // 
            this.password_show_ckb.AutoSize = true;
            this.password_show_ckb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_show_ckb.Location = new System.Drawing.Point(380, 204);
            this.password_show_ckb.Name = "password_show_ckb";
            this.password_show_ckb.Size = new System.Drawing.Size(136, 22);
            this.password_show_ckb.TabIndex = 9;
            this.password_show_ckb.Text = "Show Password";
            this.password_show_ckb.UseVisualStyleBackColor = true;
            this.password_show_ckb.CheckedChanged += new System.EventHandler(this.password_show_ckb_CheckedChanged);
            // 
            // forgot_password
            // 
            this.forgot_password.AutoSize = true;
            this.forgot_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgot_password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_password.ForeColor = System.Drawing.Color.Black;
            this.forgot_password.Location = new System.Drawing.Point(376, 282);
            this.forgot_password.Name = "forgot_password";
            this.forgot_password.Size = new System.Drawing.Size(132, 19);
            this.forgot_password.TabIndex = 11;
            this.forgot_password.Text = "forgot password ?";
            this.forgot_password.Click += new System.EventHandler(this.forgot_password_Click);
            // 
            // Teacher_Login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(606, 340);
            this.Controls.Add(this.forgot_password);
            this.Controls.Add(this.password_show_ckb);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_admin_login);
            this.Controls.Add(this.txt_admin_pass);
            this.Controls.Add(this.txt_admin_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Teacher_Login_page";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Teacher_Login_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_admin_email;
        private System.Windows.Forms.TextBox txt_admin_pass;
        private System.Windows.Forms.Button btn_admin_login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.CheckBox password_show_ckb;
        private System.Windows.Forms.Label forgot_password;
    }
}
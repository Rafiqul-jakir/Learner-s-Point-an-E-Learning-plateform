namespace Learner_s_Point
{
    partial class A_D_Show_all_student
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
            this.label1 = new System.Windows.Forms.Label();
            this.student_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.student_email = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.student_phone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // student_name
            // 
            this.student_name.AutoSize = true;
            this.student_name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_name.Location = new System.Drawing.Point(118, 37);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(141, 24);
            this.student_name.TabIndex = 1;
            this.student_name.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email: ";
            // 
            // student_email
            // 
            this.student_email.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_email.Location = new System.Drawing.Point(118, 84);
            this.student_email.Name = "student_email";
            this.student_email.Size = new System.Drawing.Size(204, 50);
            this.student_email.TabIndex = 3;
            this.student_email.Text = "Student Email ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone:";
            // 
            // student_phone
            // 
            this.student_phone.AutoSize = true;
            this.student_phone.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_phone.Location = new System.Drawing.Point(118, 137);
            this.student_phone.Name = "student_phone";
            this.student_phone.Size = new System.Drawing.Size(147, 24);
            this.student_phone.TabIndex = 5;
            this.student_phone.Text = "Student Phone";
            // 
            // A_D_Show_all_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 275);
            this.Controls.Add(this.student_phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.student_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.student_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "A_D_Show_all_student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.A_D_Show_all_student_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label student_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label student_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label student_phone;
    }
}
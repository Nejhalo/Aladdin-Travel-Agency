namespace Aladdin_Travel_Agency
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmb_sub_type_employee = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_submit_users = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_wman = new System.Windows.Forms.RadioButton();
            this.rd_man = new System.Windows.Forms.RadioButton();
            this.txt_sub_name = new System.Windows.Forms.TextBox();
            this.txt_sub_password = new System.Windows.Forms.TextBox();
            this.txt_sub_username = new System.Windows.Forms.TextBox();
            this.txt_sub_lastname = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.but_edit_pass = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_new_password = new System.Windows.Forms.TextBox();
            this.txt_past_password = new System.Windows.Forms.TextBox();
            this.txt_re_past_password = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(605, 306);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.tabPage1.Controls.Add(this.cmb_sub_type_employee);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_submit_users);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txt_sub_name);
            this.tabPage1.Controls.Add(this.txt_sub_password);
            this.tabPage1.Controls.Add(this.txt_sub_username);
            this.tabPage1.Controls.Add(this.txt_sub_lastname);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(597, 280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ایجاد کاربر";
            // 
            // cmb_sub_type_employee
            // 
            this.cmb_sub_type_employee.FormattingEnabled = true;
            this.cmb_sub_type_employee.Items.AddRange(new object[] {
            "مدیر",
            "مسئول پذیرش"});
            this.cmb_sub_type_employee.Location = new System.Drawing.Point(376, 90);
            this.cmb_sub_type_employee.Name = "cmb_sub_type_employee";
            this.cmb_sub_type_employee.Size = new System.Drawing.Size(100, 21);
            this.cmb_sub_type_employee.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "نام";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "نام خانوادگی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "نوع کاربر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "کلمه عبور";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "نام کاربری";
            // 
            // btn_submit_users
            // 
            this.btn_submit_users.Location = new System.Drawing.Point(256, 230);
            this.btn_submit_users.Name = "btn_submit_users";
            this.btn_submit_users.Size = new System.Drawing.Size(75, 23);
            this.btn_submit_users.TabIndex = 1;
            this.btn_submit_users.Text = "ثبت";
            this.btn_submit_users.UseVisualStyleBackColor = true;
            this.btn_submit_users.Click += new System.EventHandler(this.btn_submit_users_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_wman);
            this.groupBox1.Controls.Add(this.rd_man);
            this.groupBox1.Location = new System.Drawing.Point(37, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(218, 46);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جنسیت";
            // 
            // rd_wman
            // 
            this.rd_wman.AutoSize = true;
            this.rd_wman.Location = new System.Drawing.Point(120, 19);
            this.rd_wman.Name = "rd_wman";
            this.rd_wman.Size = new System.Drawing.Size(37, 17);
            this.rd_wman.TabIndex = 6;
            this.rd_wman.TabStop = true;
            this.rd_wman.Text = "زن";
            this.rd_wman.UseVisualStyleBackColor = true;
            // 
            // rd_man
            // 
            this.rd_man.AutoSize = true;
            this.rd_man.Location = new System.Drawing.Point(46, 19);
            this.rd_man.Name = "rd_man";
            this.rd_man.Size = new System.Drawing.Size(40, 17);
            this.rd_man.TabIndex = 5;
            this.rd_man.TabStop = true;
            this.rd_man.Text = "مرد";
            this.rd_man.UseVisualStyleBackColor = true;
            // 
            // txt_sub_name
            // 
            this.txt_sub_name.Location = new System.Drawing.Point(37, 18);
            this.txt_sub_name.Name = "txt_sub_name";
            this.txt_sub_name.Size = new System.Drawing.Size(100, 20);
            this.txt_sub_name.TabIndex = 4;
            // 
            // txt_sub_password
            // 
            this.txt_sub_password.Location = new System.Drawing.Point(376, 54);
            this.txt_sub_password.Name = "txt_sub_password";
            this.txt_sub_password.Size = new System.Drawing.Size(100, 20);
            this.txt_sub_password.TabIndex = 3;
            // 
            // txt_sub_username
            // 
            this.txt_sub_username.Location = new System.Drawing.Point(376, 21);
            this.txt_sub_username.Name = "txt_sub_username";
            this.txt_sub_username.Size = new System.Drawing.Size(100, 20);
            this.txt_sub_username.TabIndex = 1;
            // 
            // txt_sub_lastname
            // 
            this.txt_sub_lastname.Location = new System.Drawing.Point(37, 58);
            this.txt_sub_lastname.Name = "txt_sub_lastname";
            this.txt_sub_lastname.Size = new System.Drawing.Size(100, 20);
            this.txt_sub_lastname.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(597, 280);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "مدیریت پرواز";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.but_edit_pass);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txt_new_password);
            this.tabPage3.Controls.Add(this.txt_past_password);
            this.tabPage3.Controls.Add(this.txt_re_past_password);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(597, 280);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "تغییر پسورد";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(401, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "تکرار رمزجدید";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "رمزجدید";
            // 
            // but_edit_pass
            // 
            this.but_edit_pass.Location = new System.Drawing.Point(146, 229);
            this.but_edit_pass.Name = "but_edit_pass";
            this.but_edit_pass.Size = new System.Drawing.Size(75, 23);
            this.but_edit_pass.TabIndex = 6;
            this.but_edit_pass.Text = "ویرایش";
            this.but_edit_pass.UseVisualStyleBackColor = true;
            this.but_edit_pass.Click += new System.EventHandler(this.but_edit_pass_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "رمزقبلی";
            // 
            // txt_new_password
            // 
            this.txt_new_password.Location = new System.Drawing.Point(223, 97);
            this.txt_new_password.Name = "txt_new_password";
            this.txt_new_password.Size = new System.Drawing.Size(100, 20);
            this.txt_new_password.TabIndex = 2;
            // 
            // txt_past_password
            // 
            this.txt_past_password.Location = new System.Drawing.Point(223, 48);
            this.txt_past_password.Name = "txt_past_password";
            this.txt_past_password.Size = new System.Drawing.Size(100, 20);
            this.txt_past_password.TabIndex = 1;
            // 
            // txt_re_past_password
            // 
            this.txt_re_past_password.Location = new System.Drawing.Point(223, 150);
            this.txt_re_past_password.Name = "txt_re_past_password";
            this.txt_re_past_password.Size = new System.Drawing.Size(100, 20);
            this.txt_re_past_password.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(597, 280);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "مدیریت کاربران";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(649, 347);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "فرم مدیر";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_submit_users;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_wman;
        private System.Windows.Forms.RadioButton rd_man;
        private System.Windows.Forms.TextBox txt_sub_name;
        private System.Windows.Forms.TextBox txt_sub_password;
        private System.Windows.Forms.TextBox txt_sub_username;
        private System.Windows.Forms.TextBox txt_sub_lastname;
        private System.Windows.Forms.ComboBox cmb_sub_type_employee;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button but_edit_pass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_new_password;
        private System.Windows.Forms.TextBox txt_past_password;
        private System.Windows.Forms.TextBox txt_re_past_password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}
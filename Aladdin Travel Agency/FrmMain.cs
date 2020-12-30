using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aladdin_Travel_Agency
{
    public partial class FrmMain : Form
    {
        string usernamepublic = "";
        public FrmMain()
        {
            InitializeComponent();
        }
        public FrmMain(string getusername)
        {
            InitializeComponent();
            usernamepublic = getusername;
        }

        private void btn_submit_users_Click(object sender, EventArgs e)
        {
            Cls_subUsers f = new Cls_subUsers();
         
            f.name_sg =txt_sub_name.Text;
            f.lastname_sg=txt_sub_lastname.Text;
            f.password_sg=txt_sub_password.Text;
            f.name_sg = txt_sub_name.Text;
            f.type_employee_sg = cmb_sub_type_employee.Text;
            f.username_sg = txt_sub_username.Text;      

            if (rd_man.Checked == true)
                f.sex_sg ="مرد";

            else if (rd_wman.Checked == true)
                f.sex_sg = "زن";

            f.insert();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Cls_subUsers h = new Cls_subUsers();
            h.username_sg = usernamepublic;
            DataTable dt = h.search_by_username();


            if (dt.Rows[0]["sex"].ToString() == "زن") {
                this.Text = "خانم " + dt.Rows[0]["name"].ToString()+" "+ dt.Rows[0]["lastname"].ToString()+" خوش آمدید ";

            }

            else if (dt.Rows[0]["sex"].ToString() == "مرد")
            {
                this.Text = "آقا " + dt.Rows[0]["name"].ToString() + " " + dt.Rows[0]["lastname"].ToString() + " خوش آمدید ";

            }
        }

        private void but_edit_pass_Click(object sender, EventArgs e)
        {
            Cls_subUsers p = new Cls_subUsers();

            p.password_sg = txt_past_password.Text;
            DataTable dt = p.search_by_pass();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("رمز فعلی موجود نیست");
            }

              else if (txt_new_password.Text == txt_re_past_password.Text)
            {
                p.username_sg = usernamepublic;
                p.password_sg = txt_new_password.Text;
                p.edit_pass();

            }

        }






            }
          
        }
    
    


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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            Cls_subUsers n = new Cls_subUsers();
            n.username_sg = txt_username.Text;
            n.password_sg = txt_pass.Text;
            DataTable dt = n.login();

            if (dt.Rows.Count == 0)
            {

                MessageBox.Show("رمز عبور یا نام کاربری اشتباه است ");

            }
            else if(dt.Rows[0]["type_employee"].ToString()=="مسئول پذیرش")
            {
                frmmasool v = new frmmasool(txt_username.Text);
                v.Show();

            }
            else if(dt.Rows[0]["type_employee"].ToString() == "مدیر")
            {
                FrmMain v = new FrmMain(txt_username.Text);
                v.Show();

            }




        }
    }
}

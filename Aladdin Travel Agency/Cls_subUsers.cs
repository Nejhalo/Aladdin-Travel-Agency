using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aladdin_Travel_Agency
{
    class Cls_subUsers
    {
        string username = "", password = "", lastname = "", name = "", sex = "", type_employee = "";

        public string name_sg
        {
            set { name = value; }
            get { return name; }


        }
        public string type_employee_sg
        {
            set { type_employee = value; }
            get { return type_employee; }


        }
        public string sex_sg
        {
            set { sex = value; }
            get { return sex; }


        }

        public string lastname_sg
        {
            set { lastname = value; }
            get { return lastname; }


        }
        public string password_sg
        {
            set { password = value; }
            get { return password; }


        }

        public string username_sg
        {
            set { username = value; }
            get { return username; }


        }

        //
        public void insert()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_agency.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("sub_Users", con);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@sex", sex);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@type_employee", type_employee);
            cmd.Parameters.AddWithValue("@password", password);
            try
            {

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("اطلاعات با موفقیت دریافت شد");

            }

            catch (SqlException err)
            {

                MessageBox.Show(err.Message);

            }
        }

        public DataTable login()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_agency.mdf;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("login", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@username", username);
            da.SelectCommand.Parameters.AddWithValue("@password", password);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable search_by_username()
        {

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_agency.mdf;Integrated Security=True");
            //sqladaptor=search
            SqlDataAdapter da = new SqlDataAdapter("search_user_by_username", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@username", username);


            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }

        public DataTable search_by_pass()
        {

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_agency.mdf;Integrated Security=True");
            //sqladaptor=search
            SqlDataAdapter da = new SqlDataAdapter("search_by_pass", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@password", password);


            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }
        public void edit_pass()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_agency.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("edit_pass", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            

            try
            {

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("اطلاعات با موفقیت ویرایش شد");

            }

            catch (SqlException err)
            {

                MessageBox.Show(err.Message);

            }
        }




          








    }
    } 


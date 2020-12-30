using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aladdin_Travel_Agency
{
    class cls_personal_info
    {

        string birthday = "", maritalstatus = "", sex = "", travel = "", languages = "", country = "", nationalcode = "", nationality = "", phonenumber = "", lastname = "", name = "", email = "";
       

        public string name_sg
        {
            set { name = value; }
            get { return name; }


        }


        public string birthday_sg
        {
            set { birthday = value; }
            get { return birthday; }


        }
        public string maritalstatus_sg
        {
            set { maritalstatus = value; }
            get { return maritalstatus; }


        }
        public string sex_sg
        {
            set { sex = value; }
            get { return sex; }


        }
        public string travel_sg
        {
            set { travel = value; }
            get { return travel; }


        }
        public string languages_sg
        {
            set { languages = value; }
            get { return languages; }


        }
        public string country_sg
        {
            set { country = value; }
            get { return country; }


        }
        public string nationalcode_sg
        {
            set { nationalcode = value; }
            get { return nationalcode; }


        }
        public string nationality_sg
        {
            set { nationality = value; }
            get { return nationality; }


        }
        public string phonenumber_sg
        {
            set { phonenumber = value; }
            get { return phonenumber; }


        }
        public string lastname_sg
        {
            set { lastname = value; }
            get { return lastname; }


        }

        public string email_sg
        {
            set { email = value; }
            get { return email; }


        }



        //search

        public DataTable search_code()
        {

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_agency.mdf;Integrated Security=True");
            //sqladaptor=search
            SqlDataAdapter da = new SqlDataAdapter("search_nationalcode", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@nationalcode", nationalcode);


            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }




        //insert

        public void insert()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_agency.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert_info", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@birthday", birthday);
            cmd.Parameters.AddWithValue("@maritalstatus", maritalstatus);
            cmd.Parameters.AddWithValue("@sex", sex);
            cmd.Parameters.AddWithValue("@travel", travel);
            cmd.Parameters.AddWithValue("@country", country);
            cmd.Parameters.AddWithValue("@languages", languages);
            cmd.Parameters.AddWithValue("@nationalcode", nationalcode);
            cmd.Parameters.AddWithValue("@nationality", nationality);
            cmd.Parameters.AddWithValue("@phonenumber", phonenumber);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);



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


        //edit

        public void edit()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_agency.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("edit_person", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@birthday", birthday);
            cmd.Parameters.AddWithValue("@languages", languages);
            cmd.Parameters.AddWithValue("@country", country);
            cmd.Parameters.AddWithValue("@nationality", nationality);
            cmd.Parameters.AddWithValue("@nationalcode", nationalcode);
            cmd.Parameters.AddWithValue("@phonenumber", phonenumber);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@maritalstatus", maritalstatus);
            cmd.Parameters.AddWithValue("@sex", sex);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@travel", travel);

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


        public void delete()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_agency.mdf;Integrated Security=True");
            //sqlcommand =insert
            SqlCommand cmd = new SqlCommand("delete_pearson", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nationalcode", nationalcode);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("اطلاعات با موفقیت حذف شد");



            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);

            }




        }

        //
        public DataSet search_nameFamily()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_agency.mdf;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("search_person_by_name_AND_lastname", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@lastname", lastname);
            da.SelectCommand.Parameters.AddWithValue("@name", name);

            //data grideview=data set
            DataSet ds = new DataSet();
            //data set=data tableمجوعه از جدول یا
            da.Fill(ds, "tbt_person_vakeshi");
            return ds;
        }

    }
}
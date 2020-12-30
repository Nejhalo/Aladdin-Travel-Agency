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
    class cls_bilit
    {

        string FlightCode = "", Number = "", nationalcode = "";







        public string FlightCode_sg
        {
            set { FlightCode = value; }
            get { return FlightCode; }


        }


        public string Number_sg
        {
            set { Number = value; }
            get { return Number; }


        }


        public string nationalcode_sg
        {
            set { nationalcode = value; }
            get { return nationalcode; }


        }

        public void insert()
        {


            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_agency.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("buyTickets", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Number", Number);
            cmd.Parameters.AddWithValue("@FlightCode", FlightCode);
            cmd.Parameters.AddWithValue("@nationalcode", nationalcode);

            try
            {

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("اطلاعات با موفقیت دریافت شد");//بلیت خریداری شد

            }

            catch (SqlException err)
            {

                MessageBox.Show(err.Message);

            }

        }


        public DataTable search_ticket()
        {

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_agency.mdf;Integrated Security=True");
            //sqladaptor=search
            SqlDataAdapter da = new SqlDataAdapter("search_vojod_ticket", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@FlightCode", FlightCode);
            da.SelectCommand.Parameters.AddWithValue("@nationalcode", nationalcode);
            



            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;



        }




        public void edit()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_agency.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("edit_ticket", con);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@nationalcode", nationalcode);
            cmd.Parameters.AddWithValue("@Number", Number);
            cmd.Parameters.AddWithValue("@FlightCode", FlightCode);

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


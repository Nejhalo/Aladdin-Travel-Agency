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
    class cls_flight_info
    {

        string FlightCode = "", Origin = "",
                   Destination = "",
                   FlightTime = "",
                   FlightDate = "",
                   capacity = "",
                   NumberOfpassengers = "",
                   Numberofyoungchildren = "";




        public string FlightCode_sg
        {
            set { FlightCode = value; }
            get { return FlightCode; }


        }


        public string Origin_sg
        {
            set { Origin = value; }
            get { return Origin; }


        }


        public string Destination_sg
        {
            set { Destination = value; }
            get { return Destination; }


        }

        public string FlightTime_sg
        {
            set { FlightTime = value; }
            get { return FlightTime; }


        }



        public string FlightDate_sg
        {
            set { FlightDate = value; }
            get { return FlightDate; }


        }




        public string capacity_sg
        {
            set { capacity = value; }
            get { return capacity; }


        }


        public string NumberOfpassengers_sg
        {
            set { NumberOfpassengers = value; }
            get { return NumberOfpassengers; }


        }


        public string Numberofyoungchildren_sg
        {
            set { Numberofyoungchildren = value; }
            get { return Numberofyoungchildren; }


        }



        //insert

        public void insert()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_agency.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert_flight_info", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@FlightCode", FlightCode);
            cmd.Parameters.AddWithValue("@Origin", Origin);
            cmd.Parameters.AddWithValue("@Destination", Destination);
            cmd.Parameters.AddWithValue("@FlightDate", FlightDate);
            cmd.Parameters.AddWithValue("@FlightTime", FlightTime);
            cmd.Parameters.AddWithValue("@capacity", capacity);
            cmd.Parameters.AddWithValue("@NumberOfpassengers", NumberOfpassengers);
            cmd.Parameters.AddWithValue("@Numberofyoungchildren", Numberofyoungchildren);


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





        //search

        public DataTable search_code()
        {

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_agency.mdf;Integrated Security=True");
            //sqladaptor=search
            SqlDataAdapter da = new SqlDataAdapter("search_flight_info", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@FlightCode", FlightCode);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }


        public void edit() {
             SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_agency.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Edit_Flight", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Origin", Origin);
            cmd.Parameters.AddWithValue("@Destination", Destination);
            cmd.Parameters.AddWithValue("@FlightTime", FlightTime);
            cmd.Parameters.AddWithValue("@FlightDate", FlightDate);
            cmd.Parameters.AddWithValue("@NumberOfpassengers", NumberOfpassengers);
            cmd.Parameters.AddWithValue("@Numberofyoungchildren", Numberofyoungchildren);
            cmd.Parameters.AddWithValue("@capacity", capacity);
            cmd.Parameters.AddWithValue("@FlightCode", FlightCode);
            
            try {

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










        //delete

        public void delete()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_agency.mdf;Integrated Security=True");
            //sqlcommand =insert
            SqlCommand cmd = new SqlCommand("delete_flight", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@FlightCode", FlightCode);

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



        public void edit_Capacity()
        {


            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_agency.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("edit_capacity", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@capacity", capacity);
            cmd.Parameters.AddWithValue("@FlightCode", FlightCode);
           

            try
            {

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


            }

            catch (SqlException err)
            {

                MessageBox.Show(err.Message);

            }

        }









    }
}
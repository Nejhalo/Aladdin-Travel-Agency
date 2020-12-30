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
    public partial class frmmasool : System.Windows.Forms.Form
    {

        string usernamepublic = "";
        public frmmasool(string getusername)
        {
            InitializeComponent();
            usernamepublic = getusername;
        }
        public frmmasool()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cls_subUsers h = new Cls_subUsers();
            h.username_sg = usernamepublic;
            DataTable dt = h.search_by_username();


            //if (dt.Rows[0]["sex"].ToString() == "زن")
            //{
            //    this.Text = "خانم " + dt.Rows[0]["name"].ToString() + " " + dt.Rows[0]["lastname"].ToString() + " خوش آمدید ";

            //}

            //else if (dt.Rows[0]["sex"].ToString() == "مرد")
            //{
            //    this.Text = "آقا " + dt.Rows[0]["name"].ToString() + " " + dt.Rows[0]["lastname"].ToString() + " خوش آمدید ";
            //}

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btn_darj_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            cls_personal_info f = new cls_personal_info();
            f.country_sg = txt_country.Text;
            f.email_sg = txt_email.Text;
            f.languages_sg = txt_languages.Text;
            f.lastname_sg = txt_lastname.Text;
            f.name_sg = txt_name.Text;
            f.nationalcode_sg = txt_nationalcode.Text;
            f.nationality_sg = txt_nationality.Text;
            f.phonenumber_sg = txt_phonenumber.Text;
            f.travel_sg = cmb_travel.Text;

            if (rd_female.Checked == true)
                f.sex_sg = "زن";

            else if (rd_male.Checked == true)
                f.sex_sg = "مرد";



            if (rd_single.Checked == true)
                f.maritalstatus_sg = "مجرد";

            else if (rd_married.Checked == true)
                f.maritalstatus_sg = "متاهل";


            f.birthday_sg = txt_year.Text + "/" + txt_month.Text + "/" + txt_day.Text;


            DataTable dt = f.search_code();
            if (dt.Rows.Count == 0)
            {
                f.insert();
            }

            else
            {
                MessageBox.Show("این کد ملی قبلا درج شده!!!!1");
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            cls_personal_info f = new cls_personal_info();
            f.nationalcode_sg = t2txt_nationalcode.Text;
            DataTable dt = f.search_code();

            if (dt.Rows.Count == 0)
                MessageBox.Show("کد ملی ثبت نشده است");
            else

            {

                t2txt_name.Text = dt.Rows[0]["name"].ToString();
                t2txt_lastname.Text = dt.Rows[0]["lastname"].ToString();//row az 0shoro mishe
                t2txt_phonenumber.Text = dt.Rows[0]["phonenumber"].ToString();
                t2txt_languages.Text = dt.Rows[0]["languages"].ToString();
                t2txt_nationality.Text = dt.Rows[0]["nationality"].ToString();
                t2txt_email.Text = dt.Rows[0]["email"].ToString();
                t2txt_country.Text = dt.Rows[0]["country"].ToString();
                t2cmb_travel.Text = dt.Rows[0]["travel"].ToString();




                if (dt.Rows[0]["sex"].ToString() == "زن")
                    t2rd_female.Checked = true;

                else if (dt.Rows[0]["sex"].ToString() == "مرد")
                    t2rd_male.Checked = true;


                if (dt.Rows[0]["maritalstatus"].ToString() == "مجرد")
                    t2rd_single.Checked = true;

                else if (dt.Rows[0]["maritalstatus"].ToString() == "متاهل")
                    t2rd_married.Checked = true;


                string[] bd = dt.Rows[0]["birthday"].ToString().Split('/'); //bd==birthday

                t2txt_year.Text = bd[0];
                t2txt_month.Text = bd[1];
                t2txt_day.Text = bd[2];
            }
            panel1.Enabled = true;



        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            cls_personal_info f = new cls_personal_info();

            f.lastname_sg = t2txt_lastname.Text;
            f.name_sg = t2txt_name.Text;
            f.nationalcode_sg = t2txt_nationalcode.Text;
            f.phonenumber_sg = t2txt_phonenumber.Text;
            f.languages_sg = t2txt_languages.Text;
            f.nationality_sg = t2txt_nationality.Text;
            f.email_sg = t2txt_email.Text;
            f.country_sg = t2txt_country.Text;
            f.travel_sg = t2cmb_travel.Text;

            if (t2rd_female.Checked == true)
                f.sex_sg = "زن";

            else if (t2rd_male.Checked == true)
                f.sex_sg = "مرد";

            if (t2rd_single.Checked == true)
                f.maritalstatus_sg = "مجرد";

            else if (t2rd_married.Checked == true)
                f.maritalstatus_sg = "متاهل";

            f.birthday_sg = t2txt_year.Text + "/" + t2txt_month.Text + "/" + t2txt_day.Text;
            f.edit();
            panel1.Enabled = false;
            //redio butten texbox خالی کردن



        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmb_travel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            cls_personal_info f = new cls_personal_info();


            f.nationalcode_sg = t2txt_nationalcode.Text;

            f.delete();
            panel1.Enabled = false;
            //redio butten texbox خالی کردن
            t2cmb_travel.Text = "";
            t2rd_female.Checked = false;
            t2rd_male.Checked = false;
            t2rd_married.Checked = false;
            t2rd_single.Checked = false;
            t2txt_day.Text = "";
            t2txt_month.Text = "";
            t2txt_year.Text = "";
            t2txt_name.Text = "";
            t2txt_lastname.Text = "";
            t2txt_phonenumber.Text = "";
            t2txt_languages.Text = "";
            t2txt_nationality.Text = "";
            t2txt_email.Text = "";
            t2txt_country.Text = "";
        }

        private void tabPage3_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_search_by_lastname_Click(object sender, EventArgs e)
        {
            cls_personal_info f = new cls_personal_info();
            f.name_sg = t3txt_name.Text;
            f.languages_sg = t3txt_lastname.Text;
            DataSet ds = f.search_nameFamily();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ds.Tables["tbt_person_vakeshi"];

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = dataGridView1.CurrentRow.Index;

            t3txt_nationalcode.Text = dataGridView1.Rows[i].Cells["nationalcode"].Value.ToString();
            t3cmb_travel.Text = dataGridView1.Rows[i].Cells["travel"].Value.ToString();
            t3txt_country.Text = dataGridView1.Rows[i].Cells["country"].Value.ToString();
            t3txt_email.Text = dataGridView1.Rows[i].Cells["email"].Value.ToString();
            t3txt_languages.Text = dataGridView1.Rows[i].Cells["languages"].Value.ToString();
            t3txt_nationality.Text = dataGridView1.Rows[i].Cells["nationalcode"].Value.ToString();
            t3txt_phonenumber.Text = dataGridView1.Rows[i].Cells["nationalcode"].Value.ToString();
            t3txt_birthday.Text = dataGridView1.Rows[i].Cells["birthday"].Value.ToString();

            string birthdays = t3txt_birthday.Text;

            string[] Split = birthdays.Split('/');


            foreach (string date in Split)
            {

                t3txt_day.Text = Split[2];
                t3txt_month.Text = Split[1];
                t3txt_year.Text = Split[0];



            }


            if (dataGridView1.Rows[i].Cells["maritalstatus"].Value.ToString() == "مجرد")
                t3rd_single.Checked = true;
            else if (dataGridView1.Rows[i].Cells["maritalstatus"].Value.ToString() == "متاهل")
                t3rd_married.Checked = true;

            if (dataGridView1.Rows[i].Cells["sex"].Value.ToString() == "زن")
                t3rd_female.Checked = true;

            else if (dataGridView1.Rows[i].Cells["sex"].Value.ToString() == "مرد")
                t3rd_male.Checked = true;




        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void btn_insertFlight_Click(object sender, EventArgs e)
        {
            cls_flight_info s = new cls_flight_info();
            s.FlightCode_sg = txt_FlightCode.Text;
            s.capacity_sg = txt_capacity.Text;
            s.Destination_sg = txt_Destination.Text;
            s.Origin_sg = txt_Origin.Text;
            s.NumberOfpassengers_sg = txt_NumberOfpassengers.Text;
            s.Numberofyoungchildren_sg = txt_Numberofyoungchildren.Text;

            s.FlightDate_sg = txt_yearFlight.Text + "/" + txt_monthFlight.Text + "/" + txt_dayFlight.Text;

            s.FlightTime_sg = cmb_hourFlight.Text + ":" + cmb_minutesFlight.Text;

            s.insert();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_flight_Click(object sender, EventArgs e)
        {
            cls_flight_info s = new cls_flight_info();
            s.FlightCode_sg = t2txt_Flightcode.Text;
            DataTable dt = s.search_code();

            if (dt.Rows.Count == 0)
                MessageBox.Show("کد ثبت نشده است");
            else
            {
                t2txt_Origin.Text = dt.Rows[0]["Origin"].ToString();
                t2txt_Destination.Text = dt.Rows[0]["Destination"].ToString();//row az 0shoro mishe
                t2txt_capacity.Text = dt.Rows[0]["capacity"].ToString();
                t2txt_NumberOfpassengers.Text = dt.Rows[0]["NumberOfpassengers"].ToString();
                t2txt_Numberofyoungchildren.Text = dt.Rows[0]["Numberofyoungchildren"].ToString();
                string[] tm = dt.Rows[0]["FlightTime"].ToString().Split(':'); //tm=time
                t2cmb_hourFlight.Text = tm[0];
                t2cmb_minutesFlight.Text = tm[1];
                string[] bd = dt.Rows[0]["FlightDate"].ToString().Split('/'); //bd==birthday

                t2txt_yearFlight.Text = bd[0];
                t2txt_monthFlight.Text = bd[1];
                t2txt_dayFlight.Text = bd[2];
            }
            panelflight.Enabled = true;
        }





        private void btn_del_flight_Click(object sender, EventArgs e)
        {
            cls_flight_info s = new cls_flight_info();


            s.FlightCode_sg = t2txt_Flightcode.Text;

            s.delete();
            panelflight.Enabled = false;
            //redio butten texbox خالی کردن

            t2cmb_minutesFlight.Text = "";
            t2cmb_hourFlight.Text = "";
            t2txt_Origin.Text = "";
            t2txt_Destination.Text = "";
            t2txt_yearFlight.Text = "";
            t2txt_monthFlight.Text = "";
            t2txt_dayFlight.Text = "";
            t2txt_capacity.Text = "";
            t2txt_NumberOfpassengers.Text = "";
            t2txt_Numberofyoungchildren.Text = "";


        }

        private void t2txt_Numberofyoungchildren_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_edit_flight_Click(object sender, EventArgs e)
        {
            cls_flight_info s = new cls_flight_info();
            s.capacity_sg = t2txt_capacity.Text;
            s.Destination_sg = t2txt_Destination.Text;
            s.Origin_sg = t2txt_Origin.Text;
            s.NumberOfpassengers_sg = t2txt_NumberOfpassengers.Text;
            s.Numberofyoungchildren_sg = t2txt_Numberofyoungchildren.Text;
            s.FlightCode_sg = t2txt_Flightcode.Text;


            s.FlightDate_sg = t2txt_yearFlight.Text + "/" + t2txt_monthFlight.Text + "/" + t2txt_dayFlight.Text;

            s.FlightTime_sg = t2cmb_hourFlight.Text + ":" + t2cmb_minutesFlight.Text;
            s.edit();
            panelflight.Enabled = false;



        }

        private void btn_buy_Click(object sender, EventArgs e)

        {

            int Zarfiyat = 0, num = 0;

            ////////////////
            cls_personal_info f = new cls_personal_info();
            f.nationalcode_sg = txt_buy_nationalcode.Text;
            DataTable dt = f.search_code();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("کدملی وجود ندارد!!!ابتداثبت نام کنید");
                txt_buy_nationalcode.Text = "";
                txt_buy_FlightCode.Text = "";
                txt_buy_num.Text = "";
            }




            cls_flight_info s = new cls_flight_info();
            s.FlightCode_sg = txt_buy_FlightCode.Text;
            DataTable dt2 = s.search_code();


            if (dt2.Rows.Count == 0)
            {
                MessageBox.Show("کد پرواز وجود ندارد!!ابتدا ثبت نام کنید");
                txt_buy_nationalcode.Text = "";
                txt_buy_FlightCode.Text = "";
                txt_buy_num.Text = "";
            }


            /////////////////////////



            Zarfiyat = Convert.ToInt32(dt2.Rows[0]["capacity"].ToString());
            num = Convert.ToInt32(txt_buy_num.Text.ToString());

            if (Zarfiyat >= num)
            {


                int resultzarfiyat = Zarfiyat - num;
                s.capacity_sg = resultzarfiyat.ToString();
                s.edit_Capacity();
                cls_bilit d = new cls_bilit();

                d.Number_sg = txt_buy_num.Text;
                d.nationalcode_sg = txt_buy_nationalcode.Text;
                d.FlightCode_sg = txt_buy_FlightCode.Text;
                d.insert();



            }


            else
            {
                MessageBox.Show("ظرفیت موجود نیست");
                txt_buy_nationalcode.Text = "";
                txt_buy_FlightCode.Text = "";
                txt_buy_num.Text = "";

            }


            cls_flight_info sw = new cls_flight_info();
            sw.FlightCode_sg = txt_buy_FlightCode.Text;
            DataTable dt3 = sw.search_code();


            if (dt3.Rows.Count == 0)
            {
                MessageBox.Show("کد پرواز وجود ندارد!!");
                txt_buy_nationalcode.Text = "";
                txt_buy_FlightCode.Text = "";
                txt_buy_num.Text = "";
            }






        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_buy_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btn_cansele_Click(object sender, EventArgs e)

        {
            int nubC = 0, numb=5  , Zarfiyat1;

            cls_personal_info g = new cls_personal_info();
            g.nationalcode_sg = txt_cansel_nationalcode.Text;
            DataTable dt1 = g.search_code();

            if (dt1.Rows.Count == 0)
            {
                MessageBox.Show("!!کدملی وجود ندارد");

            }

            
            cls_flight_info s = new cls_flight_info();
            s.FlightCode_sg = txt_cansel_flightcode.Text;
            DataTable dt3 = s.search_code();
            Zarfiyat1 = Convert.ToInt32(dt3.Rows[0]["capacity"].ToString());

            if (dt3.Rows.Count == 0)
            {
                MessageBox.Show("کد پرواز وجود ندارد");
                txt_buy_nationalcode.Text = "";
                txt_buy_FlightCode.Text = "";
                txt_buy_num.Text = "";
            }


            /////////


            Zarfiyat1 = Convert.ToInt32(dt3.Rows[0]["capacity"].ToString());

            cls_bilit t = new cls_bilit();
            t.Number_sg = txt_cansel_num.Text;
            DataTable dt4 =t.search_ticket();

            //numb = Convert.ToInt32(dt4.Rows[0]["Number"].ToString());
           //nubC = Convert.ToInt32(txt_cansel_num.Text.ToString());

            if (dt4.Rows.Count == 0)
            {
                MessageBox.Show("!!بلیت خریداری نشده");

            }

            else if (Convert.ToInt32(dt4.Rows[0]["Number"].ToString()) > Convert.ToInt32(txt_cansel_num.Text.ToString()))
            {
                MessageBox.Show("!!تعداد بلیت کنسل شده بیشتر از خریداری شده است");


            }
            else
            {
                MessageBox.Show("!! بليط ها با موفقيت كنسل شدند ");


                int resultzarfiyat = Zarfiyat1 + nubC;
                s.capacity_sg = resultzarfiyat.ToString();
                s.edit_Capacity();


                int resultbilit = numb - nubC;
                t.Number_sg = resultbilit.ToString();
                t.edit();


            }

        }
    }
}







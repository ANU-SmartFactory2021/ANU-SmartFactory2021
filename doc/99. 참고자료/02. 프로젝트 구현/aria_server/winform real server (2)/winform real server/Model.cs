using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_real_server
{

    class Model // 모델 클래스
    {
        Form1 Fm;



        public int mode_id;
        public float mode_temp;
        public float mode_humidity;
        public string anam;

        public string f_mode_id;
        public string f_mode_temp;
        public string f_mode_humidity;
        public static string All_se;

        public Model(Form1 mF)
        {
            Fm = mF;
        }
        public Model()
        {

        }

        public void m_d(int model_id) // 모델 delete
        {
            MySqlConnection conn;
            string strconn = "Server=192.168.111.226;Database=Aria;Uid=root;Pwd=1234;";
            conn = new MySqlConnection(strconn);
            conn.Open();
            string SQL = "delete from TBL_MODEL where model_id = " + model_id + ";";
            MySqlCommand cmd = new MySqlCommand(SQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void m_i(int model_id, float model_temp, float model_humidity, string aname) // 모델 insert
        {
            
        }

        public void Model_select() // 모델 select
        {
            MySqlConnection conn;
            string strconn = "Server=192.168.111.226;Database=Aria;Uid=root;Pwd=1234;";
            conn = new MySqlConnection(strconn);
            conn.Open();
            string strSelect = "SELECT * FROM TBL_MODEL;";//본인의 DB이름 
            MySqlCommand cmd = new MySqlCommand(strSelect, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            All_se = "";
            ArrayList model_all = new ArrayList();
            while (rdr.Read())
            {
                Model dbmo = new Model();
                dbmo.f_mode_id = rdr["model_id"].ToString();
                dbmo.f_mode_temp = rdr["model_temp"].ToString();
                dbmo.f_mode_humidity = rdr["model_humidity"].ToString();
                dbmo.anam = rdr["aname"].ToString();
                model_all.Add(dbmo);
            }
            IEnumerator users_all = model_all.GetEnumerator();
            while (users_all.MoveNext())
            {
                Object obj = users_all.Current;
                Model dbmo = (Model)obj;
                All_se = All_se + dbmo.f_mode_id + "," + dbmo.f_mode_temp + "," + dbmo.f_mode_humidity + "," + dbmo.anam + ",";
            }
        }

        public void m_s2() // 모델 select (특정 검색)
        {
            MySqlConnection conn;
            string strconn = "Server=192.168.111.226;Database=Aria;Uid=root;Pwd=1234;";
            conn = new MySqlConnection(strconn);
            conn.Open();
            string strSelect = "SELECT * FROM TBL_MODEL;";//본인의 DB이름 
            MySqlCommand cmd = new MySqlCommand(strSelect, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            All_se = "";
            ArrayList model_all = new ArrayList();
            while (rdr.Read())
            {
                Model dbmo = new Model();
                dbmo.f_mode_id = rdr["model_id"].ToString();
                dbmo.f_mode_temp = rdr["model_temp"].ToString();
                dbmo.f_mode_humidity = rdr["model_humidity"].ToString();
                dbmo.anam = rdr["aname"].ToString();
                model_all.Add(dbmo);
            }
            IEnumerator users_all = model_all.GetEnumerator();
            while (users_all.MoveNext())
            {
                Object obj = users_all.Current;
                Model dbmo = (Model)obj;
                All_se = All_se + dbmo.f_mode_id + ",";
            }


        }


        public void m_u(int chang_model_id, int model_id, float model_temp, float model_humidity, string aname) // 모델 update
        {
            MySqlConnection conn;
            string strconn = "Server=192.168.111.226;Database=Aria;Uid=root;Pwd=1234;";
            conn = new MySqlConnection(strconn);
            conn.Open();
            string SQL = "update TBL_MODEL set model_id = " + model_id + ", model_temp = " + model_temp + ", model_humidity = " + model_humidity + ", aname = '" + aname + "' where user_id = " + chang_model_id + ";";
            MySqlCommand cmd = new MySqlCommand(SQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }


}

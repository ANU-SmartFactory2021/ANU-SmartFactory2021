using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_real_server
{
    class DB_MGR
    {
        public static string strconn = "Server=192.168.111.226;Database=Aria;Uid=root;Pwd=1234;"; // mysql 연동 변수
        public static MySqlConnection conn = new MySqlConnection(strconn); // mysql 연결 함수 conn 정의
        public DB_MGR()
        {

        }
        public static void Line1_Insert(ref DB_TBL_LINE1 Line1) // Model Insert 메소드
        {
            conn.Open(); // Mysql Open
            string Line1_Insert_Sql = "INSERT INTO TBL_LINE (_id, aname, state, working_lot, line_temp, line_humidity) VALUES('" + Line1._Id + "','" + Line1.Name + "','" + Line1.State + "','" + Line1.Working_Lot + "','" + Line1.Line_Temp + "','" + Line1.Line_Humidity + "');"; // Insert 쿼리문
            MySqlCommand Command_Line1_Insert = new MySqlCommand(Line1_Insert_Sql, conn); // Insert Command문
            Command_Line1_Insert.ExecuteNonQuery(); // Insert 실행
            conn.Close(); // mysql Close
        }
        public static void Line1_Name_Update(string aname, string change_name) // Model Update 메소드
        {
            conn.Open();
            string Line1_Name_Update_Sql = "update TBL_LINE set aname = '" + change_name + "' where aname = '" + aname + "';";
            MySqlCommand Command_Line1_Name_Update = new MySqlCommand(Line1_Name_Update_Sql, conn);
            Command_Line1_Name_Update.ExecuteNonQuery();
            conn.Close();
        }
        public static void Line1_State_Update(string _id, string working) // Line1 State 작업중 메소드
        {
            conn.Open();
            string Line1_State_Update_Sql0 = "update TBL_LINE set state = '" + working + "' where _id = '" + _id + "';";
            MySqlCommand Command_Line1_State_Update0 = new MySqlCommand(Line1_State_Update_Sql0, conn);
            Command_Line1_State_Update0.ExecuteNonQuery();
            conn.Close();
        }
        public static void Line1_Delete(string _id) // Model Delete 메소드
        {
            conn.Open();
            string Line1_Delete_Sql = "delete from TBL_LINE where _id = " + _id + ";";
            MySqlCommand Command_Line1_Delete = new MySqlCommand(Line1_Delete_Sql, conn);
            Command_Line1_Delete.ExecuteNonQuery();
            conn.Close();
        }

        public static void Line1_Select(ref List<string> Line)
        {
            conn.Open();
            string Line1_All_Select_Sql = "SELECT * FROM TBL_LINE;";
            MySqlCommand Command_Line1_All_Select = new MySqlCommand(Line1_All_Select_Sql, conn);
            MySqlDataReader Reader_Line1_All_Select = Command_Line1_All_Select.ExecuteReader();

            while (Reader_Line1_All_Select.Read())
            {
                Line.Add(Reader_Line1_All_Select["_id"].ToString() + " " + Reader_Line1_All_Select["aname"].ToString() + " " + Reader_Line1_All_Select["state"].ToString() + " " + Reader_Line1_All_Select["working_lot"].ToString() + " " + Reader_Line1_All_Select["line_temp"].ToString() + " " + Reader_Line1_All_Select["line_humidity"].ToString() + " " + Reader_Line1_All_Select["lot_reserve"].ToString());
            }
            conn.Close();
        }
        ////
        public static void Lot_Insert(ref DB_TBL_LOT lot) // Lot 기본정보 Insert 메서드
        {
            conn.Open(); // Mysql Open
            string Lot_Insert_Sql = "INSERT INTO TBL_LOT (lot_id, model_id, line_id, total_product_count, product_speed_warn, product_fail_rate_warn, product_color, " +
                "temp_margin, humid_margin, oper_id, working_state, lot_created_time) VALUES('" + lot.Lot_Id + "'," + lot.Model_Id + ",'" + lot.Line_Id + "'," + lot.Total_Product_Count + "," + lot.Product_Speed_Warn + "," + lot.Product_Fail_Rate_Warn + ", " +
                "'" + lot.Product_Color + "'," + lot.Temp_Margin + "," + lot.Humid_Margin + ",'" + lot.Oper_Id + "'," + lot.Working_State + ",now());"; // Insert 쿼리문
            MySqlCommand Command_Lot_Insert = new MySqlCommand(Lot_Insert_Sql, conn); // Insert Command문
            Command_Lot_Insert.ExecuteNonQuery(); // Insert 실행
            conn.Close(); // mysql Close
        }
        public static void Lot_Delete(string lot_id) // Lot Delete 메서드
        {
            conn.Open(); // Mysql Open
            string Lot_Delete_Sql = "delete from TBL_LOT where lot_id = " + lot_id + ";"; // 
            MySqlCommand Command_Lot_Delete = new MySqlCommand(Lot_Delete_Sql, conn); // 
            Command_Lot_Delete.ExecuteNonQuery(); // 
            conn.Close(); // mysql Close
        }
        public static void Lot_Working_State_Update(string lot_id, string working_state) // Lot Working_State 상태 0 메서드
        {
            conn.Open();
            string Lot_Working_State_Update_Sql_0 = "update TBL_LOT set working_state = " + working_state + " where lot_id = '" + lot_id + "';";
            MySqlCommand Command_Lot_Working_State_Update_0 = new MySqlCommand(Lot_Working_State_Update_Sql_0, conn);
            Command_Lot_Working_State_Update_0.ExecuteNonQuery();
            conn.Close();
        }
        public static void Lot_Start_Time_Update(string lot_id) // Lot Start Time Update 메서드
        {
            conn.Open();
            string Lot_Start_Time_Update_Sql = "update TBL_LOT set lot_start_time = now() where lot_id = '" + lot_id + "';";
            MySqlCommand Command_Lot_Start_Time_Update = new MySqlCommand(Lot_Start_Time_Update_Sql, conn);
            Command_Lot_Start_Time_Update.ExecuteNonQuery();
            conn.Close();
        }
        public static void Lot_End_Time_Update(string lot_id) // Lot End Time Update 메서드
        {
            conn.Open();
            string Lot_End_Time_Update_Sql = "update TBL_LOT set lot_end_time = now() where lot_id = '" + lot_id + "';";
            MySqlCommand Command_Lot_End_Time_Update = new MySqlCommand(Lot_End_Time_Update_Sql, conn);
            Command_Lot_End_Time_Update.ExecuteNonQuery();
            conn.Close();
        }
        public static void Lot_Select(ref List<DB_TBL_LOT> Lot)
        {
            conn.Open();
            string Lot_All_Select_Sql = "SELECT * FROM TBL_LOT;";//본인의 DB이름 
            MySqlCommand Command_Lot_All_Select = new MySqlCommand(Lot_All_Select_Sql, conn);
            MySqlDataReader Reader_Lot_All_Select = Command_Lot_All_Select.ExecuteReader(); // Sql문 Reader하는 Class

            while (Reader_Lot_All_Select.Read()) // TBL_MODEL의 컬럼 내용 모두 읽을 때 까지 반복
            {
                DB_TBL_LOT Lott = new DB_TBL_LOT();
                Lott.Lot_Id = Reader_Lot_All_Select["lot_id"].ToString();
                Lott.Model_Id = Reader_Lot_All_Select["model_id"].ToString();
                Lott.Line_Id = Reader_Lot_All_Select["line_id"].ToString();
                Lott.Total_Product_Count = Reader_Lot_All_Select["total_product_count"].ToString();
                Lott.Product_Speed_Warn = Reader_Lot_All_Select["product_speed_warn"].ToString();
                Lott.Product_Fail_Rate_Warn = Reader_Lot_All_Select["product_fail_rate_warn"].ToString();
                Lott.Product_Color = Reader_Lot_All_Select["product_color"].ToString();
                Lott.Temp_Margin = Reader_Lot_All_Select["temp_margin"].ToString();
                Lott.Humid_Margin = Reader_Lot_All_Select["humid_margin"].ToString();
                Lott.Oper_Id = Reader_Lot_All_Select["oper_id"].ToString();
                Lott.Working_State = Reader_Lot_All_Select["working_state"].ToString();
                Lott.Lot_Created_Time = Reader_Lot_All_Select["lot_created_time"].ToString();
                Lott.Lot_Start_Time = Reader_Lot_All_Select["lot_start_time"].ToString();
                Lott.Lot_End_Time = Reader_Lot_All_Select["lot_end_time"].ToString();

                Lot.Add(Lott);

                //Lot.Add(Reader_Lot_All_Select["lot_id"].ToString() + " " + Reader_Lot_All_Select["model_id"].ToString() + " " + Reader_Lot_All_Select["line_id"].ToString() + " " + Reader_Lot_All_Select["total_product_count"].ToString() + " " + Reader_Lot_All_Select["product_speed_warn"].ToString() +
                //     Reader_Lot_All_Select["product_fail_rate_warn"].ToString() + " " + Reader_Lot_All_Select["product_color"].ToString() + " " + Reader_Lot_All_Select["temp_margin"].ToString() + " " + Reader_Lot_All_Select["humid_margin"].ToString() + " " + Reader_Lot_All_Select["oper_id"].ToString() +
                //      Reader_Lot_All_Select["working_state"].ToString() + " " + Reader_Lot_All_Select["lot_created_time"].ToString() + " " + Reader_Lot_All_Select["lot_start_time"].ToString() + " " + Reader_Lot_All_Select["lot_end_time"].ToString()); // 모든 정보 ArrayList 담기
            }
        }
        /////////////////
        public static void Products_Insert(ref DB_TBL_PRODUCTS Products) // Products Insert 메소드
        {
            conn.Open(); // Mysql Open
            string Products_Insert_Sql = "INSERT INTO TBL_PRODUCTS (_id, model, line_id, lot_id, working_state, insp_time) VALUES(" + Products._Id + ",'" + Products.Model + "','" + Products.Line_Id + "','" + Products.Lot_Id + "',0,now());"; // Insert 쿼리문
            MySqlCommand Command_Products_Insert = new MySqlCommand(Products_Insert_Sql, conn); // Insert Command문
            Command_Products_Insert.ExecuteNonQuery(); // Insert 실행
            conn.Close(); // mysql Close
        }
        public static void Products_Update(ref DB_TBL_PRODUCTS Products) // Model Update 메소드
        {
            conn.Open();
            string Products_Update_Sql = "update TBL_PRODUCTS set model_temp = " + Products.Model_Temp + ", model_humidity = " + Products.Model_Humidity + ", insp_result = '" + Products.Insp_Result + "', fail_reason = '" + Products.Fail_Reason + "'," +
                "insp_time = now() where _id = " + Products._Id + ";";
            MySqlCommand Command_Products_Update = new MySqlCommand(Products_Update_Sql, conn);
            Command_Products_Update.ExecuteNonQuery();
            conn.Close();
        }
        public static void Products_Working_State_Update1(string _id) // Model Update 메소드
        {
            conn.Open();
            string Products_Working_State_Update1_Sql = "update TBL_PRODUCTS set model_temp = 1 where _id = " + _id + ";";
            MySqlCommand Command_Products_Working_State_Update1 = new MySqlCommand(Products_Working_State_Update1_Sql, conn);
            Command_Products_Working_State_Update1.ExecuteNonQuery();
            conn.Close();
        }
        public static void Products_Delete(string _id) // Products Delete 메소드
        {
            conn.Open();
            string Products_Delete_Sql = "delete from TBL_PRODUCTS where _id = " + _id + ";";
            MySqlCommand Command_Products_Delete = new MySqlCommand(Products_Delete_Sql, conn);
            Command_Products_Delete.ExecuteNonQuery();
            conn.Close();
        }
        public static void Products_Select(ref List<DB_TBL_PRODUCTS> Products) // Model 모두 검색 메소드
        {
            conn.Open();
            string Products_All_Select_Sql = "SELECT * FROM TBL_PRODUCTS;";//본인의 DB이름 
            MySqlCommand Command_Products_All_Select = new MySqlCommand(Products_All_Select_Sql, conn);
            MySqlDataReader Reader_Products_All_Select = Command_Products_All_Select.ExecuteReader(); // Sql문 Reader하는 Class

            while (Reader_Products_All_Select.Read()) // TBL_MODEL의 컬럼 내용 모두 읽을 때 까지 반복
            {
                DB_TBL_PRODUCTS Productss = new DB_TBL_PRODUCTS();

                Productss._Id = Reader_Products_All_Select["_id"].ToString();
                Productss.Model = Reader_Products_All_Select["model"].ToString();
                Productss.Line_Id = Reader_Products_All_Select["line_id"].ToString();
                Productss.Lot_Id = Reader_Products_All_Select["lot_id"].ToString();
                Productss.Model_Temp = Reader_Products_All_Select["model_temp"].ToString();
                Productss.Model_Humidity = Reader_Products_All_Select["model_humidity"].ToString();
                Productss.Working_State = Reader_Products_All_Select["working_state"].ToString();
                Productss.Insp_Result = Reader_Products_All_Select["insp_result"].ToString();
                Productss.Fail_Reason = Reader_Products_All_Select["fail_reason"].ToString();
                Productss.Insp_Time = Reader_Products_All_Select["insp_time"].ToString();


                ;
                Products.Add(Productss);

                //Products.Add(Reader_Products_All_Select["_id"].ToString() + " " + Reader_Products_All_Select["model"].ToString() + " " + Reader_Products_All_Select["line_id"].ToString() + " " + Reader_Products_All_Select["lot_id"].ToString()
                //     + " " + Reader_Products_All_Select["model_temp"].ToString() + " " + Reader_Products_All_Select["model_humidity"].ToString() + " " + Reader_Products_All_Select["working_state"].ToString() + " " + Reader_Products_All_Select["insp_result"].ToString()
                //      + " " + Reader_Products_All_Select["fail_reason"].ToString() + " " + Reader_Products_All_Select["insp_time"].ToString()); // 모든 정보 ArrayList 담기

            }

            conn.Close();
        }
        /// <summary>
        /// /
        /// </summary>
        /// <param name="model_id"></param>
        /// <param name="model_temp"></param>
        /// <param name="model_humidity"></param>
        /// <param name="aname"></param>
        public static void Model_Insert(ref DB_TBL_MODEL Model) // Model Insert 메소드
        {
            conn.Open(); // Mysql Open
            string Model_Insert_Sql = "INSERT INTO TBL_MODEL VALUES(" + Model.Model_Id + "," + Model.Model_Temp + "," + Model.Model_Humidity + ",'" + Model.Model_Aname + "');"; // Insert 쿼리문
            MySqlCommand SQL_INSERT = new MySqlCommand(Model_Insert_Sql, conn); // Insert Command문
            SQL_INSERT.ExecuteNonQuery(); // Insert 실행
            conn.Close(); // mysql Close
        }
        public static void Model_Update(ref DB_TBL_MODEL Model) // Model Update 메소드
        {
            conn.Open();
            string Model_Update_Sql = "update TBL_MODEL set model_id = " + Model.Model_Id + ", model_temp = " + Model.Model_Temp + ", model_humidity = "
                        + Model.Model_Humidity + ", aname = '" + Model.Model_Aname + "' where model_id = " + Model.Model_Id + ";"; // update sql문을 담을 string 변수
            MySqlCommand SQL_Update = new MySqlCommand(Model_Update_Sql, conn);
            SQL_Update.ExecuteNonQuery();
            conn.Close();
        }
        public static void Model_Delete(string model_id) // Model Delete 메소드
        {
            conn.Open();
            string Model_Delete_Sql = "delete from TBL_MODEL where model_id = " + model_id + ";";
            MySqlCommand SQL_Delete = new MySqlCommand(Model_Delete_Sql, conn);
            SQL_Delete.ExecuteNonQuery();
            conn.Close();
        }
        public static void Model_Select(ref List<DB_TBL_MODEL> Model)
        {
            conn.Open();
            string Model_All_Select_Sql = "SELECT * FROM TBL_MODEL;";//본인의 DB이름 
            MySqlCommand Command_Model_All_Select = new MySqlCommand(Model_All_Select_Sql, conn);
            MySqlDataReader Reader_Model_All_Select = Command_Model_All_Select.ExecuteReader(); // Sql문 Reader하는 Class

            while (Reader_Model_All_Select.Read()) // TBL_MODEL의 컬럼 내용 모두 읽을 때 까지 반복
            {
                DB_TBL_MODEL Model_Select = new DB_TBL_MODEL(); // TBL_MODEL 테이블 객체 생성
                Model_Select.Model_Id = Reader_Model_All_Select["model_id"].ToString(); // TBL_MODEL 테이블의 model_id 컬럼 불러오기
                Model_Select.Model_Temp = Reader_Model_All_Select["model_temp"].ToString(); // TBL_MODEL 테이블의 model_temp 컬럼 불러오기
                Model_Select.Model_Humidity = Reader_Model_All_Select["model_humidity"].ToString(); // TBL_MODEL 테이블의 model_humidity 컬럼 불러오기
                Model_Select.Model_Aname = Reader_Model_All_Select["aname"].ToString(); // TBL_MODEL 테이블의 aname 컬럼 불러오기

                Model.Add(Model_Select); // 모든 정보 ArrayList 담기
            }
            conn.Close();
        }
        ///
        public static void Users_Insert(ref DB_USERS Users) // Model Insert 메소드
        {
            conn.Open(); // Mysql Open
            string Users_Insert_Sql = "INSERT INTO users VALUES('" + Users.User_Id + "','" + Users.Pass_Word + "'," + Users.Level + ",'" + Users.E_Mail + "','" + Users.First_Name + "','" + Users.Last_Name + "');"; // Insert 쿼리문
            MySqlCommand Command_Users_Insert = new MySqlCommand(Users_Insert_Sql, conn); // Insert Command문
            Command_Users_Insert.ExecuteNonQuery(); // Insert 실행
            conn.Close(); // mysql Close
        }
        public static void Users_Update(ref DB_USERS Users) // Model Update 메소드
        {
            conn.Open();
            string Users_Update_Sql = "update users set pass_word = '" + Users.Pass_Word + "', Level = "
                        + Users.Level + ", e_mail = '" + Users.E_Mail + "', first_name = '" + Users.First_Name + "', last_name = '" + Users.Last_Name + "' where user_id = '" + Users.User_Id + "';"; // update sql문을 담을 string 변수
            MySqlCommand Command_Users_Update = new MySqlCommand(Users_Update_Sql, conn);
            Command_Users_Update.ExecuteNonQuery();
            conn.Close();
        }
        public static void Users_Delete(ref DB_USERS Users) // Model Delete 메소드
        {
            conn.Open();
            string Users_Delete_Sql = "delete from users where user_id = '" + Users.User_Id + "';";
            MySqlCommand Command_Users_Delete = new MySqlCommand(Users_Delete_Sql, conn);
            Command_Users_Delete.ExecuteNonQuery();
            conn.Close();
        }
        public static void Users_Select(ref List<DB_USERS> Users)
        {
            conn.Open();
            string Users_Select_Sql = "SELECT * FROM users;";//본인의 DB이름 
            MySqlCommand Command_Users_Select = new MySqlCommand(Users_Select_Sql, conn);
            MySqlDataReader Reader_Users_Select = Command_Users_Select.ExecuteReader(); // Sql문 Reader하는 Class

            while (Reader_Users_Select.Read()) // TBL_MODEL의 컬럼 내용 모두 읽을 때 까지 반복
            {
                DB_USERS users = new DB_USERS();

                users.User_Id = Reader_Users_Select["user_id"].ToString();
                users.Pass_Word = Reader_Users_Select["pass_word"].ToString();
                users.Level = Reader_Users_Select["level"].ToString();
                users.E_Mail = Reader_Users_Select["e_mail"].ToString();
                users.First_Name = Reader_Users_Select["first_name"].ToString();
                users.Last_Name = Reader_Users_Select["last_name"].ToString();

                Users.Add(users); // 모든 정보 ArrayList 담기
            }
            conn.Close();
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Class
{
    class DB_TBL_PRODUCTS
    {
        public string _Id { set; get; } // Model Id가 저장되는 문자열 변수
        public string Model { set; get; } // Model Temp가 저장되는 문자열 변수
        public string Line_Id; // Model Humidity가 저장되는 문자열 변수
        public string Lot_Id; // Model Aname이 저장되는 문자열 변수
        public string Model_Temp; // 모든  Model 정보가 저장되는 문자열 변수
        public string Model_Humidity;
        public string Working_State;
        public string Insp_Result;
        public string Fail_Reason;
        public string Insp_Time;
        public static string Product_All_Info;

        public static List<string> List_Id = new List<string>(); // _Id가 저장된 list
        public static List<string> List_Model = new List<string>(); // model temp가 저장된 list
        public static List<string> List_Line_Id = new List<string>(); // model humidity가 저장된 list
        public static List<string> List_Lot_Id = new List<string>(); // model aname이 저장된 list
        public static List<string> List_Model_Temp = new List<string>(); // model 모든 컬럼 정보가 저장된 list
        public static List<string> List_Model_Humidity = new List<string>(); // model 모든 컬럼 정보가 저장된 list
        public static List<string> List_Working_State = new List<string>(); // model 모든 컬럼 정보가 저장된 list
        public static List<string> List_Insp_Result = new List<string>(); // model 모든 컬럼 정보가 저장된 list
        public static List<string> List_Fail_Reason = new List<string>(); // model 모든 컬럼 정보가 저장된 list
        public static List<string> List_Insp_Time = new List<string>(); // model 모든 컬럼 정보가 저장된 list
        public static List<string> List_Products_All = new List<string>(); // model 모든 컬럼 정보가 저장된 list
        public static string strconn = "Server=192.168.111.226;Database=Aria;Uid=root;Pwd=1234;"; // mysql 연동 변수
        public static MySqlConnection conn = new MySqlConnection(DB_TBL_MODEL.strconn); // mysql 연결 함수 conn 정의

        public static void Products_Insert(string _id, string model, string line_id, string lot_id) // Products Insert 메소드
        {
            conn.Open(); // Mysql Open
            string Products_Insert_Sql = "INSERT INTO TBL_PRODUCTS (_id, model, line_id, lot_id, working_state, insp_time) VALUES(" + _id + ",'" + model + "','" + line_id + "','" + lot_id + "',0,now());"; // Insert 쿼리문
            MySqlCommand Command_Products_Insert = new MySqlCommand(Products_Insert_Sql, conn); // Insert Command문
            Command_Products_Insert.ExecuteNonQuery(); // Insert 실행
            conn.Close(); // mysql Close
        }
        public static void Products_Update(string model_temp, string model_humidity, string insp_result, string fail_reason, string _id) // Model Update 메소드
        {
            conn.Open();
            string Products_Update_Sql = "update TBL_PRODUCTS set model_temp = " + model_temp + ", model_humidity = " + model_humidity + ", insp_result = '" + insp_result + "', fail_reason = '" + fail_reason + "'," +
                "insp_time = now() where _id = " + _id + ";";
            MySqlCommand Command_Products_Update = new MySqlCommand(Products_Update_Sql, conn);
            Command_Products_Update.ExecuteNonQuery();
            conn.Close();
        }
        public static void Products_Working_State_Update1(string _id) // Model Update 메소드
        {
            conn.Open();
            string Products_Working_State_Update1_Sql = "update TBL_PRODUCTS set model_temp = 1 where _id = "+_id+";";
            MySqlCommand Command_Products_Working_State_Update1 = new MySqlCommand(Products_Working_State_Update1_Sql, conn);
            Command_Products_Working_State_Update1.ExecuteNonQuery();
            conn.Close();
        }
        public static void Products_Working_State_Update2(string _id) // Model Update 메소드
        {
            conn.Open();
            string Products_Working_State_Update2_Sql = "update TBL_PRODUCTS set model_temp = 2 where _id = " + _id + ";";
            MySqlCommand Command_Products_Working_State_Update2 = new MySqlCommand(Products_Working_State_Update2_Sql, conn);
            Command_Products_Working_State_Update2.ExecuteNonQuery();
            conn.Close();
        }
        public static void Products_Working_State_Update3(string _id) // Model Update 메소드
        {
            conn.Open();
            string Products_Working_State_Update1_Sq3 = "update TBL_PRODUCTS set model_temp = 3 where _id = " + _id + ";";
            MySqlCommand Command_Products_Working_State_Update3 = new MySqlCommand(Products_Working_State_Update1_Sq3, conn);
            Command_Products_Working_State_Update3.ExecuteNonQuery();
            conn.Close();
        }
        public static void Products_Working_State_Update4(string _id) // Model Update 메소드
        {
            conn.Open();
            string Products_Working_State_Update4_Sql = "update TBL_PRODUCTS set model_temp = 4 where _id = " + _id + ";";
            MySqlCommand Command_Products_Working_State_Update4 = new MySqlCommand(Products_Working_State_Update4_Sql, conn);
            Command_Products_Working_State_Update4.ExecuteNonQuery();
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
        public static void Products_All_Select() // Model 모두 검색 메소드
        {
            Product_All_Info = "";
            List_Id.RemoveRange(0, List_Id.Count);
            List_Model.RemoveRange(0, List_Model.Count);
            List_Line_Id.RemoveRange(0, List_Line_Id.Count);
            List_Lot_Id.RemoveRange(0, List_Lot_Id.Count);
            List_Model_Temp.RemoveRange(0, List_Model_Temp.Count);
            List_Model_Humidity.RemoveRange(0, List_Model_Humidity.Count);
            List_Working_State.RemoveRange(0, List_Working_State.Count);
            List_Insp_Result.RemoveRange(0, List_Insp_Result.Count);
            List_Fail_Reason.RemoveRange(0, List_Fail_Reason.Count);
            List_Insp_Time.RemoveRange(0, List_Insp_Time.Count);

            conn.Open();
            string Products_All_Select_Sql = "SELECT * FROM TBL_PRODUCTS;";//본인의 DB이름 
            MySqlCommand Command_Products_All_Select = new MySqlCommand(Products_All_Select_Sql, conn);
            MySqlDataReader Reader_Products_All_Select = Command_Products_All_Select.ExecuteReader(); // Sql문 Reader하는 Class
            ArrayList Arraylist_Products_All_Select = new ArrayList(); // ArrayList 선언

            while (Reader_Products_All_Select.Read()) // TBL_MODEL의 컬럼 내용 모두 읽을 때 까지 반복
            {
                DB_TBL_PRODUCTS Product_Select = new DB_TBL_PRODUCTS(); // TBL_MODEL 테이블 객체 생성

                Product_Select._Id = Reader_Products_All_Select["_id"].ToString(); // TBL_MODEL 테이블의 model_id 컬럼 불러오기
                Product_Select.Model = Reader_Products_All_Select["model"].ToString(); // TBL_MODEL 테이블의 model_temp 컬럼 불러오기
                Product_Select.Line_Id = Reader_Products_All_Select["line_id"].ToString(); // TBL_MODEL 테이블의 model_humidity 컬럼 불러오기
                Product_Select.Lot_Id = Reader_Products_All_Select["lot_id"].ToString(); // TBL_MODEL 테이블의 aname 컬럼 불러오기
                Product_Select.Model_Temp = Reader_Products_All_Select["model_temp"].ToString(); // TBL_MODEL 테이블의 model_id 컬럼 불러오기
                Product_Select.Model_Humidity = Reader_Products_All_Select["model_humidity"].ToString(); // TBL_MODEL 테이블의 model_temp 컬럼 불러오기
                Product_Select.Working_State = Reader_Products_All_Select["working_state"].ToString(); // TBL_MODEL 테이블의 model_humidity 컬럼 불러오기
                Product_Select.Insp_Result = Reader_Products_All_Select["insp_result"].ToString(); // TBL_MODEL 테이블의 aname 컬럼 불러오기
                Product_Select.Fail_Reason = Reader_Products_All_Select["fail_reason"].ToString(); // TBL_MODEL 테이블의 model_id 컬럼 불러오기
                Product_Select.Insp_Time = Reader_Products_All_Select["insp_time"].ToString(); // TBL_MODEL 테이블의 model_temp 컬럼 불러오기

                List_Id.Add(Product_Select._Id); // 불러온 model_id 리스트에 담기
                List_Model.Add(Product_Select.Model); // 불러온 model_temp 리스트에 담기
                List_Line_Id.Add(Product_Select.Line_Id); // 불러온 model_humidity 리스트에 댐기
                List_Lot_Id.Add(Product_Select.Lot_Id); // 불러온 aname 리스트에 담기
                List_Model_Temp.Add(Product_Select.Model_Temp); // 불러온 model_id 리스트에 담기
                List_Model_Humidity.Add(Product_Select.Model_Humidity); // 불러온 model_temp 리스트에 담기
                List_Working_State.Add(Product_Select.Working_State); // 불러온 model_humidity 리스트에 댐기
                List_Insp_Result.Add(Product_Select.Insp_Result); // 불러온 aname 리스트에 담기
                List_Fail_Reason.Add(Product_Select.Fail_Reason); // 불러온 model_id 리스트에 담기
                List_Insp_Time.Add(Product_Select.Insp_Time); // 불러온 model_temp 리스트에 담기

                Arraylist_Products_All_Select.Add(Product_Select); // 모든 정보 ArrayList 담기
            }
            int IndexA = 0;
            IEnumerator Product_Array = Arraylist_Products_All_Select.GetEnumerator(); // ArrayList를 반복 할 수 있도록 함.
            while (Product_Array.MoveNext())
            {
                Object obj = Product_Array.Current;
                DB_TBL_PRODUCTS Product_Select = (DB_TBL_PRODUCTS)obj;
                if (IndexA == Arraylist_Products_All_Select.Count)
                {
                    Product_All_Info = Product_All_Info + Product_Select._Id + "\t" + Product_Select.Model + "\t" + Product_Select.Line_Id + "\t" + Product_Select.Lot_Id + "\t" + Product_Select.Model_Temp + "\t" + Product_Select.Model_Humidity + "\t" + Product_Select.Working_State + "\t" + Product_Select.Insp_Result + "\t" + Product_Select.Fail_Reason + "\t" + Product_Select.Insp_Time;
                }
                else
                {
                    Product_All_Info = Product_All_Info + Product_Select._Id + "\t" + Product_Select.Model + "\t" + Product_Select.Line_Id + "\t" + Product_Select.Lot_Id + "\t" + Product_Select.Model_Temp + "\t" + Product_Select.Model_Humidity + "\t" + Product_Select.Working_State + "\t" + Product_Select.Insp_Result + "\t" + Product_Select.Fail_Reason + "\t" + Product_Select.Insp_Time + "\n";
                }
            }
            conn.Close();
        }
        public static void Products_Select(string _id)
        {
            string[] String_List_Product_All = Product_All_Info.Split(new char[] { '\n' }); // List_Model_All_Info 문자열을 , 기준으로 나누어서 배열에 적재

            int Index_i = 0; // foreach에서 증가값 변수
            int Index_e = 0; // 선택한 문자가 리스트의 몇번째인지 찾는 변수
            foreach (string number in List_Id) // Model_Id_Info 리스트 반복
            {
                if (number == _id) // 선택값과 User_id가 같은지 판단
                {
                    Index_e = Index_i; // 같을 시 Index_e에 Index_i값 저장
                }
                Index_i++; // Index_i 증가
            }
            Console.WriteLine(String_List_Product_All[Index_e]); // 찾은 Index_e번째 리스트 불러오기
        }
    }
}
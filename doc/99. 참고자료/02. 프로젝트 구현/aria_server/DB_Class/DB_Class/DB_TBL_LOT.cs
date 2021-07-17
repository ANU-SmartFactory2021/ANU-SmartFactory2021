using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Class
{
    class DB_TBL_LOT
    {
        public string Lot_Id { get; set; }
        public string Model_Id { get; set; }
        public string Line_Id { get; set; }
        public string Total_Product_Count {get;set;}
        public string Product_Speed_Warn { get; set; }
        public string Product_Fail_Rate_Warn { get; set; }
        public string Product_Color { get; set; }
        public string Temp_Margin { get; set; }
        public string Humid_Margin { get; set; }
        public string Oper_Id { get; set; }
        public string Working_State { get; set; }
        public string Lot_Created_Time { get; set; }
        public string Lot_Start_Time { get; set; }
        public string Lot_End_Time { get; set; }

        public static string Lot_All_Info { get; set; }


        public static List<string> List_Lot_Id = new List<string>(); // _Id가 저장된 list
        public static List<string> List_Model_Id = new List<string>(); // model temp가 저장된 list
        public static List<string> List_Line_Id = new List<string>(); // model humidity가 저장된 list
        public static List<string> List_Total_Product_Count = new List<string>(); // model aname이 저장된 list
        public static List<string> List_Product_Speed_Warn = new List<string>(); // model 모든 컬럼 정보가 저장된 list
        public static List<string> List_Product_Fail_Rate_Warn = new List<string>(); // model 모든 컬럼 정보가 저장된 list
        public static List<string> List_Product_Color = new List<string>(); // model 모든 컬럼 정보가 저장된 list
        public static List<string> List_Temp_Margin = new List<string>(); // model 모든 컬럼 정보가 저장된 list
        public static List<string> List_Humid_Margin = new List<string>(); // model 모든 컬럼 정보가 저장된 list
        public static List<string> List_Oper_Id = new List<string>(); // model 모든 컬럼 정보가 저장된 list
        public static List<string> List_Working_State = new List<string>();
        public static List<string> List_Lot_Created_Time = new List<string>();
        public static List<string> List_Lot_Start_Time = new List<string>();
        public static List<string> List_Lot_End_Time = new List<string>();

        public static string strconn = "Server=192.168.111.226;Database=Aria;Uid=root;Pwd=1234;"; // mysql 연동 변수
        public static MySqlConnection conn = new MySqlConnection(DB_TBL_MODEL.strconn); // mysql 연결 함수 conn 정의

        public static void Lot_Insert(string lot_id, string model_id, string line_id, string total_product_count, string product_speed_warn, string product_fail_rate_warn, 
            string product_color, string temp_margin, string humid_margin, string oper_id, string working_state) // Lot 기본정보 Insert 메서드
        {
            conn.Open(); // Mysql Open
            string Lot_Insert_Sql = "INSERT INTO TBL_LOT (lot_id, model_id, line_id, total_product_count, product_speed_warn, product_fail_rate_warn, product_color, " +
                "temp_margin, humid_margin, oper_id, working_state, lot_created_time) VALUES('" + lot_id + "'," + model_id + ",'" + line_id + "'," + total_product_count + "," + product_speed_warn + ","+product_fail_rate_warn+", " +
                "'"+product_color+"',"+temp_margin+","+humid_margin+",'"+oper_id+"',"+working_state+",now());"; // Insert 쿼리문
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
        public static void Lot_Working_State_Update_0(string lot_id) // Lot Working_State 상태 0 메서드
        {
            conn.Open();
            string Lot_Working_State_Update_Sql_0 = "update TBL_LOT set working_state = 0 where lot_id = '" + lot_id + "';";
            MySqlCommand Command_Lot_Working_State_Update_0 = new MySqlCommand(Lot_Working_State_Update_Sql_0, conn);
            Command_Lot_Working_State_Update_0.ExecuteNonQuery();
            conn.Close();
        }
        public static void Lot_Working_State_Update_1(string lot_id) // Lot Working_State 상태 1 메서드
        {
            conn.Open();
            string Lot_Working_State_Update_Sql_1 = "update TBL_LOT set working_state = 1 where lot_id = '" + lot_id + "';";
            MySqlCommand Command_Lot_Working_State_Update_1 = new MySqlCommand(Lot_Working_State_Update_Sql_1, conn);
            Command_Lot_Working_State_Update_1.ExecuteNonQuery();
            conn.Close();
        }
        public static void Lot_Working_State_Update_2(string lot_id) // Lot Working_State 상태 2 메서드
        {
            conn.Open();
            string Lot_Working_State_Update_Sql_2 = "update TBL_LOT set working_state = 2 where lot_id = '" + lot_id + "';";
            MySqlCommand Command_Lot_Working_State_Update_2 = new MySqlCommand(Lot_Working_State_Update_Sql_2, conn);
            Command_Lot_Working_State_Update_2.ExecuteNonQuery();
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
        public static void Lot_Select_All()
        {
            Lot_All_Info = "";
            List_Lot_Id.RemoveRange(0, List_Lot_Id.Count);
            List_Model_Id.RemoveRange(0, List_Model_Id.Count);
            List_Line_Id.RemoveRange(0, List_Line_Id.Count);
            List_Total_Product_Count.RemoveRange(0, List_Total_Product_Count.Count);
            List_Product_Speed_Warn.RemoveRange(0, List_Product_Speed_Warn.Count);
            List_Product_Fail_Rate_Warn.RemoveRange(0, List_Product_Fail_Rate_Warn.Count);
            List_Product_Color.RemoveRange(0, List_Product_Color.Count);
            List_Temp_Margin.RemoveRange(0, List_Temp_Margin.Count);
            List_Humid_Margin.RemoveRange(0, List_Humid_Margin.Count);
            List_Oper_Id.RemoveRange(0, List_Oper_Id.Count);
            List_Working_State.RemoveRange(0, List_Working_State.Count);
            List_Lot_Created_Time.RemoveRange(0, List_Lot_Created_Time.Count);
            List_Lot_Start_Time.RemoveRange(0, List_Lot_Start_Time.Count);
            List_Lot_End_Time.RemoveRange(0, List_Lot_End_Time.Count);

            conn.Open();
            string Lot_All_Select_Sql = "SELECT * FROM TBL_LOT;";//본인의 DB이름 
            MySqlCommand Command_Lot_All_Select = new MySqlCommand(Lot_All_Select_Sql, conn);
            MySqlDataReader Reader_Lot_All_Select = Command_Lot_All_Select.ExecuteReader(); // Sql문 Reader하는 Class
            ArrayList Arraylist_Lot_All_Select = new ArrayList(); // ArrayList 선언

            while (Reader_Lot_All_Select.Read()) // TBL_MODEL의 컬럼 내용 모두 읽을 때 까지 반복
            {
                DB_TBL_LOT Lot_Select = new DB_TBL_LOT(); // TBL_MODEL 테이블 객체 생성

                Lot_Select.Lot_Id =                 Reader_Lot_All_Select["lot_id"].ToString(); // TBL_MODEL 테이블의 model_id 컬럼 불러오기
                Lot_Select.Model_Id =               Reader_Lot_All_Select["model_id"].ToString(); // TBL_MODEL 테이블의 model_temp 컬럼 불러오기
                Lot_Select.Line_Id =                Reader_Lot_All_Select["line_id"].ToString(); // TBL_MODEL 테이블의 model_humidity 컬럼 불러오기
                Lot_Select.Total_Product_Count =    Reader_Lot_All_Select["total_product_count"].ToString(); // TBL_MODEL 테이블의 aname 컬럼 불러오기
                Lot_Select.Product_Speed_Warn =     Reader_Lot_All_Select["product_speed_warn"].ToString(); // TBL_MODEL 테이블의 model_id 컬럼 불러오기
                Lot_Select.Product_Fail_Rate_Warn = Reader_Lot_All_Select["product_fail_rate_warn"].ToString(); // TBL_MODEL 테이블의 model_temp 컬럼 불러오기
                Lot_Select.Product_Color =          Reader_Lot_All_Select["product_color"].ToString(); // TBL_MODEL 테이블의 model_humidity 컬럼 불러오기
                Lot_Select.Temp_Margin =            Reader_Lot_All_Select["temp_margin"].ToString(); // TBL_MODEL 테이블의 aname 컬럼 불러오기
                Lot_Select.Humid_Margin =           Reader_Lot_All_Select["humid_margin"].ToString(); // TBL_MODEL 테이블의 model_id 컬럼 불러오기
                Lot_Select.Oper_Id =                Reader_Lot_All_Select["oper_id"].ToString();
                Lot_Select.Working_State =          Reader_Lot_All_Select["working_state"].ToString();
                Lot_Select.Lot_Created_Time =       Reader_Lot_All_Select["lot_created_time"].ToString();
                Lot_Select.Lot_Start_Time =         Reader_Lot_All_Select["lot_start_time"].ToString();
                Lot_Select.Lot_End_Time =           Reader_Lot_All_Select["lot_end_time"].ToString();

                List_Lot_Id.Add(Lot_Select.Lot_Id); // 불러온 model_id 리스트에 담기
                List_Model_Id.Add(Lot_Select.Model_Id); // 불러온 model_temp 리스트에 담기
                List_Line_Id.Add(Lot_Select.Line_Id); // 불러온 model_humidity 리스트에 댐기
                List_Total_Product_Count.Add(Lot_Select.Total_Product_Count); // 불러온 aname 리스트에 담기
                List_Product_Speed_Warn.Add(Lot_Select.Product_Speed_Warn); // 불러온 model_id 리스트에 담기
                List_Product_Fail_Rate_Warn.Add(Lot_Select.Product_Fail_Rate_Warn); // 불러온 model_temp 리스트에 담기
                List_Product_Color.Add(Lot_Select.Product_Color); // 불러온 aname 리스트에 담기
                List_Temp_Margin.Add(Lot_Select.Temp_Margin); // 불러온 model_id 리스트에 담기
                List_Humid_Margin.Add(Lot_Select.Humid_Margin);
                List_Oper_Id.Add(Lot_Select.Oper_Id);
                List_Working_State.Add(Lot_Select.Working_State);
                List_Lot_Created_Time.Add(Lot_Select.Lot_Created_Time);
                List_Lot_Start_Time.Add(Lot_Select.Lot_Start_Time);
                List_Lot_End_Time.Add(Lot_Select.Lot_End_Time);

                Arraylist_Lot_All_Select.Add(Lot_Select); // 모든 정보 ArrayList 담기
            }
            int IndexA = 0;
            IEnumerator Lot_Array = Arraylist_Lot_All_Select.GetEnumerator(); // ArrayList를 반복 할 수 있도록 함.
            while (Lot_Array.MoveNext())
            {
                Object obj = Lot_Array.Current;
                DB_TBL_LOT Lot_Select = (DB_TBL_LOT)obj;
                if (IndexA == Arraylist_Lot_All_Select.Count)
                {
                    Lot_All_Info = Lot_All_Info + Lot_Select.Lot_Id + "\t" + Lot_Select.Model_Id + "\t" + Lot_Select.Line_Id + "\t" + Lot_Select.Total_Product_Count + "\t" + Lot_Select.Product_Speed_Warn + "\t" + Lot_Select.Product_Fail_Rate_Warn + "\t" + Lot_Select.Product_Color + "\t" + Lot_Select.Temp_Margin + "\t" + Lot_Select.Humid_Margin + "\t" + Lot_Select.Oper_Id + "\t" + Lot_Select.Working_State + "\t" + Lot_Select.Lot_Created_Time + "\t" + Lot_Select.Lot_Start_Time + "\t" + Lot_Select.Lot_End_Time;
                }
                else
                {
                    Lot_All_Info = Lot_All_Info + Lot_Select.Lot_Id + "\t" + Lot_Select.Model_Id + "\t" + Lot_Select.Line_Id + "\t" + Lot_Select.Total_Product_Count + "\t" + Lot_Select.Product_Speed_Warn + "\t" + Lot_Select.Product_Fail_Rate_Warn + "\t" + Lot_Select.Product_Color + "\t" + Lot_Select.Temp_Margin + "\t" + Lot_Select.Humid_Margin + "\t" + Lot_Select.Oper_Id + "\t" + Lot_Select.Working_State + "\t" + Lot_Select.Lot_Created_Time + "\t" + Lot_Select.Lot_Start_Time + "\t" + Lot_Select.Lot_End_Time + "\n";
                }
            }
        }
        public static void Lot_Select(string lot_id)
        {
            string[] String_List_Lot_All = Lot_All_Info.Split(new char[] { '\n' }); // List_Model_All_Info 문자열을 , 기준으로 나누어서 배열에 적재

            int Index_i = 0; // foreach에서 증가값 변수
            int Index_e = 0; // 선택한 문자가 리스트의 몇번째인지 찾는 변수
            foreach (string number in List_Lot_Id) // Model_Id_Info 리스트 반복
            {
                if (number == lot_id) // 선택값과 User_id가 같은지 판단
                {
                    Index_e = Index_i; // 같을 시 Index_e에 Index_i값 저장
                }
                Index_i++; // Index_i 증가
            }
            Console.WriteLine(String_List_Lot_All[Index_e]); // 찾은 Index_e번째 리스트 불러오기
        }
    }
}

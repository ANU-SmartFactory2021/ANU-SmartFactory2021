using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Class
{
    class DB_TBL_MODEL
    {
        public string Model_Id; // 모델 id를 담을 변수
        public string Model_Temp; // 모델 temp를 담을 변수
        public string Model_Humidity; // 모델 humidity를 담을 변수
        public string Model_Aname; // 모델 name을 담을 변수

        public static string Model_All_Info; // TBL_MODEL 테이블 내용을 전부 담을 string 변수

        public static List<string> List_Model_Id = new List<string>(); // 모델 id를 담을 list
        public static List<string> List_Model_Temp = new List<string>(); // 모델 temp를 담을 list
        public static List<string> List_Model_Humidity = new List<string>(); // 모델 humidity를 담을 list
        public static List<string> List_Aname = new List<string>(); // 모델 name을 담을 list

        public static string strconn = "Server=192.168.111.226;Database=Aria;Uid=root;Pwd=1234;"; // mysql 연동 변수
        public static MySqlConnection conn = new MySqlConnection(DB_TBL_MODEL.strconn); // mysql 연결 함수 conn 정의

        public static void Model_Insert(string model_id, string model_temp, string model_humidity, string aname) // Model Insert 메소드
        {
            conn.Open(); // Mysql Open
            string Model_Insert_Sql = "INSERT INTO TBL_MODEL VALUES(" + model_id + "," + model_temp + "," + model_humidity + ",'" + aname + "');"; // Insert 쿼리문
            MySqlCommand SQL_INSERT = new MySqlCommand(Model_Insert_Sql, conn); // Insert Command문
            SQL_INSERT.ExecuteNonQuery(); // Insert 실행
            conn.Close(); // mysql Close
        }
        public static void Model_Update(string model_id, string model_temp, string model_humidity, string aname) // Model Update 메소드
        {
            conn.Open();
            string Model_Update_Sql = "update TBL_MODEL set model_id = " + model_id + ", model_temp = " + model_temp + ", model_humidity = "
                        + model_humidity + ", aname = '" + aname + "' where model_id = " + model_id + ";"; // update sql문을 담을 string 변수
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
        public static void Model_All_Select()
        {
            DB_TBL_MODEL.Model_All_Info = ""; // 메소드 호출 시 Model_All_Info 정보 초기화
            List_Model_Id.RemoveRange(0, List_Model_Id.Count); // 메소드 호출 시 list 내용들 모두 초기화
            List_Model_Temp.RemoveRange(0, List_Model_Temp.Count);
            List_Model_Humidity.RemoveRange(0, List_Model_Humidity.Count);
            List_Aname.RemoveRange(0, List_Aname.Count);
            conn.Open();
            string Model_All_Select_Sql = "SELECT * FROM TBL_MODEL;";//본인의 DB이름 
            MySqlCommand Command_Model_All_Select = new MySqlCommand(Model_All_Select_Sql, conn);
            MySqlDataReader Reader_Model_All_Select = Command_Model_All_Select.ExecuteReader(); // Sql문 Reader하는 Class
            ArrayList Arraylist_Model_Select = new ArrayList(); // ArrayList 선언

            while (Reader_Model_All_Select.Read()) // TBL_MODEL의 컬럼 내용 모두 읽을 때 까지 반복
            {
                DB_TBL_MODEL Model_Select = new DB_TBL_MODEL(); // TBL_MODEL 테이블 객체 생성
                Model_Select.Model_Id = Reader_Model_All_Select["model_id"].ToString(); // TBL_MODEL 테이블의 model_id 컬럼 불러오기
                Model_Select.Model_Temp = Reader_Model_All_Select["model_temp"].ToString(); // TBL_MODEL 테이블의 model_temp 컬럼 불러오기
                Model_Select.Model_Humidity = Reader_Model_All_Select["model_humidity"].ToString(); // TBL_MODEL 테이블의 model_humidity 컬럼 불러오기
                Model_Select.Model_Aname = Reader_Model_All_Select["aname"].ToString(); // TBL_MODEL 테이블의 aname 컬럼 불러오기

                List_Model_Id.Add(Model_Select.Model_Id); // 불러온 model_id 리스트에 담기
                List_Model_Temp.Add(Model_Select.Model_Temp); // 불러온 model_temp 리스트에 담기
                List_Model_Humidity.Add(Model_Select.Model_Humidity); // 불러온 model_humidity 리스트에 댐기
                List_Aname.Add(Model_Select.Model_Aname); // 불러온 aname 리스트에 담기

                Arraylist_Model_Select.Add(Model_Select); // 모든 정보 ArrayList 담기
            }
            int IndexA = 0; // Model_All_Info의 맨 마지막줄 공백을 없애기 위한 조건문의 index 값
            IEnumerator MODEL_ALL = Arraylist_Model_Select.GetEnumerator(); // ArrayList를 반복 할 수 있도록 함.
            while (MODEL_ALL.MoveNext()) // ArrayList 내용 끝 까지 반복
            {
                IndexA++; // index값 증가
                Object obj = MODEL_ALL.Current; //
                DB_TBL_MODEL Model_Select = (DB_TBL_MODEL)obj;
                if (IndexA == Arraylist_Model_Select.Count) // Model_All_Info 안에 \n를 안 담기위한 조건문
                {
                    Model_All_Info = Model_All_Info + Model_Select.Model_Id + "\t" + Model_Select.Model_Temp + "\t" + Model_Select.Model_Humidity + "\t" + Model_Select.Model_Aname;
                }
                else
                {
                    Model_All_Info = Model_All_Info + Model_Select.Model_Id + "\t" + Model_Select.Model_Temp + "\t" + Model_Select.Model_Humidity + "\t" + Model_Select.Model_Aname + "\n"; // List_Model_All_Info 문자열 변수안에 TBL_MODEL 내용 전부 삽입
                }
                // Console.Write(Model_Select.Model_Id + "\t" + Model_Select.Model_Temp + "\t" + Model_Select.Model_Humidity + "\t" + Model_Select.Model_Aname + "\n"); // TBL_MODEL 값 전부 출력 
            }
            conn.Close();

        }
        public static void Model_Select(String User_id) // Model 선택 검색 메소드
        {
            string[] String_List_Model_All = Model_All_Info.Split(new char[] { '\n' }); // List_Model_All_Info 문자열을 {,} 기준으로 나누어서 배열에 적재

            int Index_i = 0; // foreach에서 증가값 변수
            int Index_e = 0; // 선택한 문자가 리스트의 몇번째인지 찾는 변수

            foreach (string number in List_Model_Id) // Model_Id_Info 리스트 반복
            {
                if (number == User_id) // 선택값과 User_id가 같은지 판단
                {
                    Index_e = Index_i; // 같을 시 Index_e에 Index_i값 저장
                }
                Index_i++; // Index_i 증가
            }
            Console.WriteLine(String_List_Model_All[Index_e]); // 찾은 Index_e번째 리스트 불러오기
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_real_server
{

    class UserDAO
    {
        // MySQL 연결 객체
        MySqlConnection conn;
        string strconn = "Server=192.168.111.226;Database=Aria;Uid=root;Pwd=1234;";

        // DB 연동
        public MySqlConnection getConnection()
        {
            conn = new MySqlConnection(strconn);
            conn.Open();
            return conn;
        }

        /// <summary>
        /// 검색
        /// </summary>
        public void Selection()
        {
            
        }


        /// <summary>
        /// 삽입
        /// </summary>
        /// <param name="dto">DTO 클래스의 객체</param>
        public void Insert(UserDto userDto)
        {
            try
            {
                conn = this.getConnection();

                // 쿼리문 - INSERT 삽입
                string SQL = $"INSERT INTO users VALUES(" +
                    $"'{userDto.user_id}', '{userDto.pass_word}', '{userDto.level}', '{userDto.e_mail}', '{userDto.first_name}', '{userDto.last_name}')";

                // 데이터베이스 명령 수행
                MySqlCommand cmd = new MySqlCommand(SQL, conn);

                // ExecuteReader = SQL와 연결을 유지한 상태에서 한번에 한 레코드씩(Row) 데이터를 가져오는데 사용
                // ExecuteNonQuery = 데이터 삽입/삭제 시 사용
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
            conn.Close();   // DB 종료
        }

        /// <summary>
        /// 수정(이름 기준)
        /// </summary>
        /// <param name="before_user_id">수정하기 전 이름</param>
        /// <param name="after_user_id">수정한 후 이름</param>
        public void Update(string before_user_id, string after_user_id)
        {
            conn = this.getConnection();

            // 쿼리문 - UPDATE 수정
            string SQL = $"UPDATE users SET user_id = '{after_user_id}' WHERE user_id = '{before_user_id}'";

            // 데이터베이스 명령 수행
            MySqlCommand cmd = new MySqlCommand(SQL, conn);

            // ExecuteReader = SQL와 연결을 유지한 상태에서 한번에 한 레코드씩(Row) 데이터를 가져오는데 사용
            // ExecuteNonQuery = 데이터 삽입/삭제 시 사용
            cmd.ExecuteNonQuery();
            conn.Close();   // DB 종료

        }

        /// <summary>
        /// 삭제(이름 기준)
        /// </summary>
        /// <param name="user_id">이름</param>
        public void Delete(string user_id)
        {
            conn = this.getConnection();

            // 쿼리문 - DELETE 삭제
            string SQL = $"DELETE FROM users WHERE user_id = '{user_id}'";
            // 데이터베이스 명령 수행
            MySqlCommand cmd = new MySqlCommand(SQL, conn);

            // ExecuteReader = SQL와 연결을 유지한 상태에서 한번에 한 레코드씩(Row) 데이터를 가져오는데 사용
            // ExecuteNonQuery = 데이터 삽입/삭제 시 사용
            cmd.ExecuteNonQuery();
            conn.Close();   // DB 종료
        }


    }
}

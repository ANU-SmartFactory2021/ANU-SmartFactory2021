using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_real_server
{
    /* DTO(Data Transfer Object)
     * - 데이터를 하나의 객체로 관리할 목적으로 만들어둔 클래스의 객체
     * - DTO들은 setter(), getter()를 가지고 직렬화 구현(Java 기준)
     * - C# = Property(프로퍼티 구현)
     */
    class UserDto
    {
        // 속성
        public string user_id { get; set; }
        public string pass_word { get; set; }
        public string e_mail { get; set; }
        public string level { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }

        // 디폴트 생성자
        public UserDto() { }

        // 생성자
        public UserDto(string user_id, string pass_word, string e_mail, string level, string first_name, string last_name)
        {
            this.user_id = user_id;
            this.pass_word = pass_word;
            this.e_mail = e_mail;
            this.level = level;
            this.first_name = first_name;
            this.last_name = last_name;
        }


    }
}

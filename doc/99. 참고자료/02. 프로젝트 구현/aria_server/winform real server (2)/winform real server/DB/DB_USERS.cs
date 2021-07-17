using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_real_server
{
    class DB_USERS
    {
        public string User_Id { set; get; }
        public string Pass_Word { set; get; }
        public string Level { set; get; }
        public string E_Mail { set; get; }
        public string First_Name { set; get; }
        public string Last_Name { set; get; }

        public DB_USERS(string user_id, string pass_word, string level, string e_mail, string first_name, string last_name)
        {
            User_Id = user_id;
            Pass_Word = pass_word;
            Level = level;
            E_Mail = e_mail;
            First_Name = first_name;
            Last_Name = last_name;
        }
        public DB_USERS()
        {

        }
    }
}

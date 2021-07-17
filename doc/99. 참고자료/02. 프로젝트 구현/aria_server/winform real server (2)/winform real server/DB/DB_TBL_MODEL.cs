using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_real_server
{
    class DB_TBL_MODEL
    {
        public string Model_Id { get; set; } // 모델 id를 담을 변수
        public string Model_Temp { get; set; } // 모델 temp를 담을 변수
        public string Model_Humidity { get; set; } // 모델 humidity를 담을 변수
        public string Model_Aname { get; set; } // 모델 name을 담을 변수

        public DB_TBL_MODEL(string model_id, string model_temp, string model_humidity, string model_aname)
        {
            Model_Id = model_id;
            Model_Temp = model_temp;
            Model_Humidity = model_humidity;
            Model_Aname = model_aname;
        }

        public DB_TBL_MODEL()
        {

        }
    }
}

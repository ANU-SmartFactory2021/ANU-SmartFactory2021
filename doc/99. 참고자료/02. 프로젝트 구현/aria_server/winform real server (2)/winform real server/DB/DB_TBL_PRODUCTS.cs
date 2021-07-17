using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_real_server
{
    class DB_TBL_PRODUCTS
    {
        public string _Id { set; get; } // Model Id가 저장되는 문자열 변수
        public string Model { set; get; } // Model Temp가 저장되는 문자열 변수
        public string Line_Id { set; get; }// Model Humidity가 저장되는 문자열 변수
        public string Lot_Id { set; get; }// Model Aname이 저장되는 문자열 변수
        public string Model_Temp { set; get; }// 모든  Model 정보가 저장되는 문자열 변수
        public string Model_Humidity { set; get; }
        public string Working_State { set; get; }
        public string Insp_Result { set; get; }
        public string Fail_Reason { set; get; }
        public string Insp_Time { set; get; }

        public DB_TBL_PRODUCTS(string _id, string model, string line_id, string lot_id, string model_temp, string model_humidity, string working_state, string insp_result, string fail_reason)
        {
            _Id = _id;
            Model = model;
            Line_Id = line_id;
            Lot_Id = lot_id;
            Model_Temp = model_temp;
            Model_Humidity = model_humidity;
            Working_State = working_state;
            Insp_Result = insp_result;
            Fail_Reason = fail_reason;
        }
        public DB_TBL_PRODUCTS()
        {

        }
    }
}

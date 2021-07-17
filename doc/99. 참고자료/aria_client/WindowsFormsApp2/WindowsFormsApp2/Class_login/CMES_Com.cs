using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESComm
{
    class CLogInReqResponse
    {
        public CLogInReqResponse(string _data)
        {
            // result, right, nak_reason ex) "OK", "OPER", ""
            sResult = "";
            sRight = "";
            sNakReason = "";
        }
        public string sResult="";
        public string sRight = "";
        public string sNakReason = "";
    }


    class CUser_set
    {
        public CUser_set()
        {

        }
    }

    public class Model
    {
        public string model_id { get; set; }
        public float temp_margin { get; set; }
        public float humid_margin { get; set; }
        public string model_name { get; set; }
    }
}

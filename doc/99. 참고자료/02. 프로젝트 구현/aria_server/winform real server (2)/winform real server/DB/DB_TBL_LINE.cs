using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_real_server
{
    class DB_TBL_LINE1
    {
        public string _Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Working_Lot { get; set; }
        public string Line_Temp { get; set; }
        public string Line_Humidity { get; set; }
        public string Lot_Reserve { get; set; }
        public static string Line1_All_Info { get; set; }
        public DB_TBL_LINE1(string _id, string name, string state, string working_lot, string line_temp, string line_humidity, string lot_reserve)
        {
            _Id = _id;
            Name = name;
            State = state;
            Working_Lot = working_lot;
            Line_Temp = line_temp;
            Line_Humidity = line_temp;
            Lot_Reserve = lot_reserve;
        }
        public DB_TBL_LINE1()
        {

        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Class
{
    class DB_TBL_LINE
    {
        public string _Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Working_Lot { get; set; }
        public string Line_Temp { get; set; }
        public string Line_Humidity { get; set; }
        public string Lot_Reserve { get; set; }
    }    
}

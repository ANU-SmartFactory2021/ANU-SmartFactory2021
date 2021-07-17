using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Class_lot
{
    class Aria_lot
    {
        public string lot_id { get; set; }
        public string model_id { get; set; }
        public string line_id { get; set; }
        public int total_prod_count { get; set; }
        public int prod_speed_warn { get; set; }
        public string prod_fail_rate_warn { get; set; }
        public string prod_color { get; set; }
        public decimal temp_margin { get; set; }
        public decimal humid_margin { get; set; }
        public string oper_id { get; set; }
        public string working_state { get; set; }
        public string lot_created_time { get; set; }
        public string lot_start_time { get; set; }
        public string lot_end_time { get; set; }
    }
}

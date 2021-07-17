using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_real_server
{
    class DB_TBL_LOT
    {
        public string Lot_Id { get; set; }
        public string Model_Id { get; set; }
        public string Line_Id { get; set; }
        public string Total_Product_Count { get; set; }
        public string Product_Speed_Warn { get; set; }
        public string Product_Fail_Rate_Warn { get; set; }
        public string Product_Color { get; set; }
        public string Temp_Margin { get; set; }
        public string Humid_Margin { get; set; }
        public string Oper_Id { get; set; }
        public string Working_State { get; set; }
        public string Lot_Created_Time { get; set; }
        public string Lot_Start_Time { get; set; }
        public string Lot_End_Time { get; set; }

        public DB_TBL_LOT(string lot_id, string model_id, string line_id, string total_product_count, string product_speed_warn, string product_fail_rate_warn, string product_color, string temp_margin, string humid_margin,
            string oper_id, string working_state, string lot_created_time, string lot_start_time, string lot_end_time)
        {
            Lot_Id = lot_id;
            Model_Id = model_id;
            Line_Id = line_id;
            Total_Product_Count = total_product_count;
            Product_Speed_Warn = product_speed_warn;
            Product_Fail_Rate_Warn = product_fail_rate_warn;
            Product_Color = product_color;
            Temp_Margin = temp_margin;
            Humid_Margin = humid_margin;
            Oper_Id = oper_id;
            Working_State = working_state;
            Lot_Created_Time = lot_created_time;
            Lot_Start_Time = lot_start_time;
            Lot_End_Time = lot_end_time;
        }
        public DB_TBL_LOT()
        {

        }
    }
}

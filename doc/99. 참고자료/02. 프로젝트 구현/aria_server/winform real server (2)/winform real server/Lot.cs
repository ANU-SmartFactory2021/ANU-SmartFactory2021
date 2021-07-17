using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_real_server
{
    class Lot // Lot 지시 클래스
    {
        Form1 ff;
        public Lot(Form1 fe)
        {
            ff = fe;
        }
        public void LO_CRE(string lot_id, string model_id, string line_id, string total_pro_co, string prop_sp, string pro_fail, string pro_color,
                           string temp_mar, string humid_mar, string oper_id, string work_state) // Lot 지시 insert
        {
            MySqlConnection conn;
            string strconn = "Server=192.168.111.226;Database=Aria;Uid=root;Pwd=1234;";
            conn = new MySqlConnection(strconn);
            conn.Open();
            string SQL = "INSERT INTO TBL_LOT (lot_id,model_id,line_id,total_product_count,product_speed_warn,product_fail_rate_warn,product_color,temp_margin,humid_margin,oper_id,working_state) " +
                         "VALUES('" + lot_id + "'," + model_id + ",'" + line_id + "'," + total_pro_co + "," + prop_sp + "," + pro_fail + ",'" + pro_color + "'," + temp_mar + "," + humid_mar + ",'" + oper_id + "'," + work_state +");";
            MySqlCommand cmd = new MySqlCommand(SQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}

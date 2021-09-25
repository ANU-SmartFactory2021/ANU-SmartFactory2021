using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;


namespace CanFactoryServer
{
    class database
    { 

        OracleConnection conn;
        OracleCommand cmd;

        string strConn = "Data Source=(DESCRIPTION=" +
                 "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                 "(HOST=localhost)(PORT=1521)))" +
                 "(CONNECT_DATA=(SERVER=DEDICATED)" +
                 "(SERVICE_NAME=xe)))" +
                 ";User Id=hr;Password=hr;";


        // db 연결하는 코드들 메서드로 만들자 

        

        public void insert_data_coke()
        {
            conn = new OracleConnection(strConn);

            cmd = new OracleCommand();
            cmd.Connection = conn;

            conn.Open();

            cmd.CommandText = "UPDATE PRODUCT SET INVENTORY = INVENTORY + 1 WHERE PRODUCT_NAME = '콜라'";    
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void insert_data_cider()
        {
            conn = new OracleConnection(strConn);

            cmd = new OracleCommand();
            cmd.Connection = conn;

            conn.Open();

            cmd.CommandText = "UPDATE PRODUCT SET INVENTORY = INVENTORY + 1 WHERE PRODUCT_NAME = '사이다'";
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void insert_data_hwanta()
        {
            conn = new OracleConnection(strConn);

            cmd = new OracleCommand();
            cmd.Connection = conn;

            conn.Open();

            cmd.CommandText = "UPDATE PRODUCT SET INVENTORY = INVENTORY + 1 WHERE PRODUCT_NAME = '환타'";
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void update_data()
        {
            conn = new OracleConnection(strConn);

            cmd = new OracleCommand();
            cmd.Connection = conn;

            conn.Open();

            cmd.CommandText = "commit";
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        
        
    }
    //
}

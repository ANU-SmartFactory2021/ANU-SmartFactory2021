using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.panel
{
    public partial class Monitor_panel : UserControl
    {
        string strConn = "Data Source=(DESCRIPTION=" +
                "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                "(HOST=localhost)(PORT=1521)))" +
                "(CONNECT_DATA=(SERVER=DEDICATED)" +
                "(SERVICE_NAME=xe)))" +
                ";User Id=hr;Password=hr;";

        OracleConnection conn;
        OracleCommand cmd;

        public Monitor_panel()
        {
            InitializeComponent();            
        }

        public void FieldClear()
        {
            M_Company_txt.Text = " ";
            M_Kcal_txt.Text = " ";
            M_Product_txt.Text = " ";
            M_Serialnum_txt.Text = " ";
        }

        private void M_Serialnum_txt_TextChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(strConn);

            cmd = new OracleCommand();
            cmd.Connection = conn;

            if (M_Serialnum_txt.Text != " ")
            {
                conn.Open();
                string m_serialnum = M_Serialnum_txt.Text;

                cmd.CommandText = $"select PRODUCT_NAME, KCAL, COMPANY from product where PRODUCT_ID = '{m_serialnum}'";
                OracleDataReader rdr = cmd.ExecuteReader();

                while(rdr.Read())
                {
                    string product_name = rdr["PRODUCT_NAME"].ToString();
                    M_Product_txt.Text = product_name;
                    string kcal = rdr["KCAL"].ToString();
                    M_Kcal_txt.Text = kcal;
                    string company = rdr["COMPANY"].ToString();
                    M_Company_txt.Text = company;
                }
            }
        }

        
    }
}

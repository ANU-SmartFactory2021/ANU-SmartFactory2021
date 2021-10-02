using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Client.panel
{
    public partial class Fairqual_panel : UserControl
    {
        string strConn = "Data Source=(DESCRIPTION=" +
                "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                "(HOST=localhost)(PORT=1521)))" +
                "(CONNECT_DATA=(SERVER=DEDICATED)" +
                "(SERVICE_NAME=xe)))" +
                ";User Id=hr;Password=hr;";

        OracleConnection conn;
        OracleCommand cmd;
        public Fairqual_panel()
        {
            InitializeComponent();
            conn = new OracleConnection(strConn);
            conn.Open();
            cmd = new OracleCommand();
            cmd.Connection = conn;
            
            read();
        }
        public void read()
        {
            cmd.CommandText = $"select * from QR_VAL where QUALITY='PASS'";
            OracleDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridView1.DataSource = dt;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            cmd.CommandText = $"commit";
            read();
        }
    }
}

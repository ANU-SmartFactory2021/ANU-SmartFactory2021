using Oracle.ManagedDataAccess.Client;
using System;
using System.Text;
using System.Windows.Forms;

namespace ClientTest01.panel
{
    public partial class Start_panel : UserControl
    {
        string strConn = "Data Source=(DESCRIPTION=" +
                "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                "(HOST=localhost)(PORT=1521)))" +
                "(CONNECT_DATA=(SERVER=DEDICATED)" +
                "(SERVICE_NAME=xe)))" +
                ";User Id=hr;Password=hr;";

        OracleConnection conn;
        OracleCommand cmd;

        public Start_panel()
        {
            InitializeComponent();
            fillCombo();
        }     
        public void FieldClear()
        {
            //콤보박스
            Product_combo.SelectedIndex = -1;
            //텍스트
            Company_txt.Text = " ";
            Serialnum_txt.Text = " ";
            Outputnum_txt.Text = " ";
            //이미지
            product_png.Image = null;
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            FieldClear();            
        }

        public void fillCombo()
        {            
            conn = new OracleConnection(strConn);

            cmd = new OracleCommand();
            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.CommandText = "SELECT PRODUCT_NAME FROM PRODUCT";
                OracleDataReader myReader = cmd.ExecuteReader();
                while(myReader.Read())
                {
                    string sName = myReader.GetString(0);
                    Product_combo.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Product_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Product_combo.SelectedIndex != -1)
            {
                string selected = Product_combo.SelectedItem.ToString();

                cmd.CommandText = $"select PRODUCT_ID, COMPANY from product where PRODUCT_NAME = '{selected}'";
                OracleDataReader rdr = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (rdr.Read())
                {
                    string company = rdr["COMPANY"].ToString();
                    sb.Append(company);
                    Company_txt.Text = sb.ToString();
                    sb.Clear();
                    string product_id = rdr["PRODUCT_ID"].ToString();
                    sb.Append(product_id);
                    Serialnum_txt.Text = sb.ToString();
                    sb.Clear();

                    product_png.Load(@"C:\Users\Admin\source\repos\ClientTest01\img\" + selected + ".png");
                }

            }
        }


    }
}

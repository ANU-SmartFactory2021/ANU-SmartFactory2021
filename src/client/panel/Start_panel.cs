using Oracle.ManagedDataAccess.Client;
using System;
using System.Text;
using System.Windows.Forms;

namespace Client.panel
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

        public delegate void DataPassEventHandler(object sender);
        public event DataPassEventHandler DataPassEvent;
        public int state;        

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
            Kcal_txt.Text = " ";
            //이미지
            product_png.Image = null;
        }

        //완료버튼 클릭
        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            FieldClear();
            state = 0;
            DataPassEvent(state);

            MainForm.sc.send("<CMD=STOP>");
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

        void Product_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Product_combo.SelectedIndex != -1)
            {
                string selected = Product_combo.SelectedItem.ToString();

                cmd.CommandText = $"select PRODUCT_ID, KCAL, COMPANY from product where PRODUCT_NAME = '{selected}'";
                OracleDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    string company = rdr["COMPANY"].ToString();
                    Company_txt.Text = company;
                    string product_id = rdr["PRODUCT_ID"].ToString();
                    Serialnum_txt.Text = product_id;
                    string kcal = rdr["KCAL"].ToString();
                    Kcal_txt.Text = kcal;

                    
                    product_png.Load(@"C:\Users\Admin\source\repos\ClientTest01\img\" + selected + ".png");
                    
                }
               
            }
            
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {                           
            state = 1;           
            DataPassEvent(state);
            MainForm.sc.send("<CMD=START>");

        }        
    }
}

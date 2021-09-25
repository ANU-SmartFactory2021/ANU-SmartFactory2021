using Oracle.ManagedDataAccess.Client;
using System;
using System.Drawing;
using System.Threading;
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

        public delegate void DataPassEventHandler(object sender);
        public event DataPassEventHandler DataPassEvent;
        public int state;

        string qual = " ";
        int product_num = 0;
        int qr_num = 0;
        
        int st_num = 0;
        
        public Monitor_panel()
        {
            InitializeComponent();
            conn = new OracleConnection(strConn);
            conn.Open();           
            cmd = new OracleCommand();
            cmd.Connection = conn;
            MainForm.sc.set_recv_callback(recv_callback);            
        }

        public void FieldClear()
        {
            M_Company_txt.Text = " ";
            output_num_txt.Text = " ";
            M_Product_txt.Text = " ";
            M_Serialnum_txt.Text = " ";

            st_num = 0;
        }
                
        private void M_Serialnum_txt_TextChanged(object sender, EventArgs e)
        {            
            if (M_Serialnum_txt.Text != " ")
            {
                
                string m_serialnum = M_Serialnum_txt.Text;

                cmd.CommandText = $"select PRODUCT_NAME, COMPANY from product where PRODUCT_ID = '{m_serialnum}'";
                OracleDataReader rdr = cmd.ExecuteReader();

                while(rdr.Read())
                {
                    string product_name = rdr["PRODUCT_NAME"].ToString();
                    M_Product_txt.Text = product_name;
                    
                    string company = rdr["COMPANY"].ToString();
                    M_Company_txt.Text = company;
                }
            }
        }

        delegate void del_draw_view(string _msg);
        public void draw_view( string _msg )
        {

            //MessageBox.Show(_msg);

            Console.WriteLine(_msg);
            string[] result = _msg.Split(new char[] { '|' });

            if (result.Length > 1)
            {

                byte[] imageBytes = Convert.FromBase64String(result[2]);
                System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                Image img = (Image)converter.ConvertFrom(imageBytes);
                pictureBox1.Image = img;
                Console.WriteLine(result[1]);
                
                if (result[1] == "QUALITY=PASS")
                {
                    good_txt.BackColor = Color.Green;
                    Delay(1000);
                    good_txt.BackColor = Color.White;
                }
                else if(result[1] == "QUALITY=FAIL")
                {
                    bad_txt.BackColor = Color.Red;
                    Thread.Sleep(1000);
                    bad_txt.BackColor = Color.White;
                }

                qual = result[1].Substring(8);
                Console.WriteLine(qual);
                product_num = Convert.ToInt32(M_Serialnum_txt.Text);
                Console.WriteLine(product_num);
                qr_num = Convert.ToInt32(result[0].Substring(7));
                Console.WriteLine(qr_num);

                save();
            }
            else
            {
                //카메라 켜짐
                if (_msg == "CMD=PI_ONE_READY")
                {
                    cam_off.BackColor = Color.White;
                    cam_on.BackColor = Color.Green;
                }
                //적외선 센서 켜짐
                else if(_msg == "CMD=IS")
                {
                    sensor_off.BackColor = Color.White;
                    sensor_on.BackColor = Color.Green;
                }
                //컨베이어 벨트 작동
                else if(_msg == "CMD=RUN")
                {
                    belt_off.BackColor = Color.White;
                    belt_on.BackColor = Color.Green;
                }
                //적외선 센서 꺼짐
                else if(_msg == "CMD=REMOVE")
                {
                    sensor_on.BackColor = Color.White;
                    sensor_off.BackColor = Color.Red;
                }

                else if (_msg == "CMD=LAST")
                {
                    st_num++;
                    output_num_txt.Text = st_num.ToString();                                      
                }

                else if(_msg == "CMD=FINISH")
                {
                    state = 3;
                    DataPassEvent(state);
                }
                
                else if (_msg == "CMD=EMERGENCY")
                {
                    state = 11;
                    DataPassEvent(state);
                }
            }
        }

        public void recv_callback(string _msg)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new del_draw_view(draw_view), _msg);
            }
            else
            {
                draw_view(_msg);
            }
        }

        public void save()
        {
            cmd.CommandText = $"INSERT INTO QR_VAL VALUES({product_num},{qr_num},SYSDATE,'{qual}')";
            cmd.ExecuteNonQuery();                      
        }

        //딜레이 함수
        private static DateTime Delay(int MS)

        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }        
    }
}

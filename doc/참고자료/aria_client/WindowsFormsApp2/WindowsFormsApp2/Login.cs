using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;           // IPAddress, IPEndPoint 클래스 사용
using System.Net.Sockets;   // Socket 클래스 사용
using System.Threading;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using System.Collections;
using MESComm;

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        public static int abc = Convert.ToInt32(3222);
        public Login()
        {
            InitializeComponent();
            picbox_id_fail.Hide();
            picbox_pw_fail.Hide();
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Button 클릭시 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void login_button_Click(object sender, EventArgs e)
        {
            // DRY (Don't Repeat Your-Self)

            // send request log_in
            string bindIp = "220.69.249.232";   // 클라이언트(?) IP 지정
            string serverIp = "220.69.249.226"; // 서버 IP 지정
            const int serverPort = 8037;        // 임의 서버 포트 지정

            // 디자인에서 Text에 들어갈 문자를 담을 변수
            
            string us_id = txtbox_user_id.Text;
            string us_pw = txtbox_pw.Text;

            // Aria 프로토콜 지정 => {{#!!, ... , ,#}}
            string message;
            message = "{{#!!," + txtbox_user_id.Text + "," + txtbox_pw.Text + ",#}}";

            /* -------------------------- IPEndPoint Class --------------------------
             Represents a network endpoint as an IP address and a port number
             IPEndPoint 클래스의 생성자엔 총 두 개의 매개변수가 필요합니다.
             첫 번째는 IP 주소를 나타내는 IPAddress 클래스이고,
             두 번째는 포트 번호를 나타내는 값입니다.
             IPAddress 클래스를 보면 정적 필드로 정의된 필드들이 있습니다.
             그 중 자주 사용되는 몇 가지 필드에 대해서 설명드리도록 하겠습니다.
             IPAddress.Any - 사용 중인 '모든' 네트워크 인터페이스(랜카드에 할당된 IP 주소)를 나타냅니다.
             일반 데스크탑의 경우엔 유선 랜카드 하나만 있어서 상관이 없지만, 노트북의 경우 유/무선 랜카드가 각각
             하나씩 있는 경우엔 어떤 주소를 사용하여 바인딩 할 것인지 결정해야 합니다.
             IPAddress.Loopback - 127.0.0.1, 또는 localhost로 알려진 루프백 주소입니다.
             이 주소는 자기 자신만 사용하고 연결할 수 있습니다.
            ----------------------------------------------------------------------- */
            message = "{{#!!," + txtbox_user_id.Text + "," + txtbox_pw.Text + ",#}}";
            IPEndPoint clientAddress = new IPEndPoint(IPAddress.Parse(bindIp), Login.abc);
            Login.abc++;

            /* -------------------------- IPAddress Class --------------------------
             IP 주소 제공하는 클래스
             Provides an Internet Protocol (IP) address
             Parse(serverIp) 
              - Converts an IP address string to IPAddress instance
             IPEndPoint(220.69.249.226, 8037) ---> (hostIP, 서버의 포트번호)
             */
            IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse(serverIp), serverPort);

            // TCP 네트워크 서비스에 대한 클라이언트 제공
            TcpClient client = new TcpClient(clientAddress);

            // IPEndPoint에서 설정한 서버주소와 연결
            client.Connect(serverAddress);

            // String -> byte[]로 변환
            byte[] data = System.Text.Encoding.Default.GetBytes(message);

            // 네트워크 액세스를 위한 기본 데이터 스트림 제공
            // 읽기, 쓰기를 위한 클라이언트 스트림 받기...
            NetworkStream stream = client.GetStream();

            // Write() --> 지정된 byte 배열범위에서 NetworkStream 작성
            stream.Write(data, 0, data.Length);

            // receive request_log_in
            data = new byte[256];
            string responseData = "";

            // Read() --> NetworkStream으로 부터 데이터를 읽고, byte 배열에 저장
            int bytes = stream.Read(data, 0, data.Length); //
            responseData = Encoding.Default.GetString(data, 0, bytes);           

            CLogInReqResponse result = new CLogInReqResponse(responseData);

            // log-in process
            try
            {
                if (responseData == "정답입니다!") //result.sResult == "OK"
                {
                    this.Visible = false;
                    fmMainMenu menu = new fmMainMenu();
                    //Form3 form3 = new Form3();
                    //form3.Close();
                    menu.ShowDialog();
                }
                else
                {
                    string sErr = result.sNakReason;
                    MessageBox.Show(sErr);
                }
            }
            catch (System.IndexOutOfRangeException j)
            {
                MessageBox.Show(j.Message);
            }

            // 객체 종료
            stream.Close();
            client.Close();
            Application.Exit();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("종료하시겠습니까?", "종료확인", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPIPServerTest
{
    public partial class Form1 : Form
    {
        private string ip = "127.0.0.1";
        private int port = 25101;
        private Thread listenThread;        // Accept() 블럭
        private Thread receiveThread;       // Receive() 작업
        private Socket clientSocket;        // 연결된 클라이언트 소켓

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// listBox에 현재 날짜, 데이터 상태 등을 표시
        /// </summary>
        /// <param name="msg">매개변수 표시</param>
        private void Log(string msg)
        {
            listBox1.Items.Add(string.Format("[{0}]{1}", DateTime.Now.ToString(), msg));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "시작")
            {
                button1.Text = "멈춤";
                Log("서버 시작됨");  // 위에서 정의한 Log 메소드 --> 날짜 + 서버시작됨 이 표시

                // Listen 쓰레드 처리
                listenThread = new Thread(new ThreadStart(Listen));     // 실행되는 메소드
                listenThread.IsBackground = true;   // 스레드가 배경 스레드인지 나타내는 함수

                // 운영체제에서 현재 인스턴스의 상태를 Run으로 만듬(시작)
                listenThread.Start();
            }
            else
            {
                button1.Text = "시작";
                Log("서버 멈춤");
            }
        }

        private void Listen()
        {
            /* -------------------------- IPAddress Class --------------------------
             IP 주소 제공하는 클래스 < 종단점 >
             Provides an Internet Protocol (IP) address
             Parse(serverIp) 
              - Converts an IP address string to IPAddress instance
             IPEndPoint(220.69.249.226, 8037) ---> (hostIP, 서버의 포트번호)
             */

             // IP 주소 문자열을 IPAddress 인스턴스로 변환
            IPAddress ipaddress = IPAddress.Parse(ip);  


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

            // 네트워크 끝점(종단점)을 IP주소 및 포트번호로 나타냄
            IPEndPoint endPoint = new IPEndPoint(ipaddress, port);

            // 소켓 생성
            Socket listenSocket = new Socket(
                // Socket 클래스의 인스턴스가 사용할 수 있는 주소지정 체계 지정
                AddressFamily.InterNetwork,     
                SocketType.Stream,              // 소켓 유형 지정
                ProtocolType.Tcp                // 프로토콜 지정
                );

            // Socket을 endPoint와 연결(IP주소, 포트번호 할당)
            listenSocket.Bind(endPoint);

            // Socket을 수신 상태로 둔다.(연결 가능한 상태)
            // 클라이언트에 의한 연결 요청이 수신될때까지 기다린다.
            listenSocket.Listen(10);

            Log("클라이언트 요청 대기중...");
            
            // 연결 요청에 대한 수락
            clientSocket = listenSocket.Accept();

            Log("클라이언트 접속됨 - " + clientSocket.LocalEndPoint.ToString());

            // Receive 스레드 호출
            receiveThread = new Thread(new ThreadStart(Receive));
            receiveThread.IsBackground = true;
            receiveThread.Start();      // Receive() 호출
        }

        // 수신 처리...
        private void Receive()
        {
            while (true)
            {
                // 연결된 클라이언트가 보낸 데이터 수신
                byte[] receiveBuffer = new byte[512];
                int length = clientSocket.Receive(receiveBuffer,
                    receiveBuffer.Length, SocketFlags.None);

                // 엔터 처리
                //richTextBox1.AppendText(msg);

                // 디코딩
                string msg = Encoding.UTF8.GetString(receiveBuffer);

                //
                Showmsg("상대]" + msg);
                Log("메시지 수신함");
            }
        }

        // 송수신 메시지를 대화창에 출력
        private void Showmsg(string msg)
        {
            // richTextBOX에서 개행이 정상적으로 작용되지 않으면
            // 아래처럼 따로따로
            richTextBox1.AppendText(msg);
            richTextBox1.AppendText("\r\n");

            // 입력된 텍스트에 맞게 스크롤을 내려준다.
            this.Activate();
            richTextBox1.Focus();

            // 캐럿(커서)를 텍스트박스의 끝으로 내려준다.
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();   // 스크럴을 캐럿(커서)위치에 맞춰준다.

        }

        // TextBox1에 키를 처음 누를때 발생
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // 메시지 전송
            if(textBox1.Text.Trim() != "" && e.KeyCode == Keys.Enter)
            {
                byte[] sendBuffer = Encoding.UTF8.GetBytes(textBox1.Text.Trim());
                clientSocket.Send(sendBuffer);
                Log("메시지 전송됨");
                Showmsg("나]" + textBox1.Text);
                textBox1.Text = ""; // 초기화
            }
                
        }
    }
}

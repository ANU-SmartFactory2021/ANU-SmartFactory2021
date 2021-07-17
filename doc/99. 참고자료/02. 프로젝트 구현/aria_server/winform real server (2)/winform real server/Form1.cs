//using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
//이게진짜
namespace winform_real_server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Server server = new Server(this);
            Thread c = new Thread(server.Server_Open);
            c.IsBackground = true;
            c.Start();

        }
        public void Server_Open()
        {
            
            //string bintIp = "220.69.249.226";
            //const int bindPort = 4000;
            //TcpListener server = null;
            ////서버주소 바인딩(ip번호, port번호)


            //IPEndPoint localAddress = new IPEndPoint(IPAddress.Parse(bintIp), bindPort);
            ////서버 만들기, 주소바인딩~!!!
            //server = new TcpListener(localAddress);

            //server.Start();
            //textBox1.Text = "ARIA 프로젝트 서버";

            //while (true)
            //{
            //    TcpClient client = server.AcceptTcpClient();

            //    ((IPEndPoint)client.Client.RemoteEndPoint).ToString();

            //    NetworkStream stream = client.GetStream();

            //    int length;
            //    string receive_data = null; // 클라이언트로부터 수신되는 값이 저장 될 변수
            //    string send_data = null; // 클라이언트에게 송신할 값이 저장 될 변수
            //    byte[] bytes = new byte[256];
            //    length = stream.Read(bytes, 0, bytes.Length);

            //    receive_data = Encoding.Default.GetString(bytes, 0, length);// 데이터 수신
            //    textBox2.Text = textBox2.Text + receive_data;

            //    string receive_data_1, receive_data_2;
            //    receive_data_1 = receive_data.Substring(0, 4);
            //    receive_data_2 = receive_data.Substring(4, 1);
            //    Model Mo = new Model(this);
            //    Lot Lo = new Lot(this);
            //    string[] receive_data_division = receive_data.Split(new char[] { ',' });


            //    if (receive_data_division[0] == "{{01") // 유저 프로토콜
            //    {
            //        if (receive_data_2 == "user_insert") // 유저 insert
            //        {
            //            receive_data = "insert 받았습니다~";
            //            byte[] Response_Data = Encoding.Default.GetBytes(receive_data);
            //            stream.Write(Response_Data, 0, Response_Data.Length); // 데이터 송신
            //            textBox3.Text = receive_data;
            //        }
            //        else if (receive_data_2 == "@") // 유저 delete
            //        {
            //            receive_data = "delete 받았습니다~";
            //            byte[] Response_Data = Encoding.Default.GetBytes(receive_data);
            //            stream.Write(Response_Data, 0, Response_Data.Length); // 데이터 송신
            //            textBox3.Text = receive_data;
            //        }
            //        else if (receive_data_2 == "#") // 유저 update
            //        {
            //            receive_data = "update 받았습니다~";
            //            byte[] Response_Data = Encoding.Default.GetBytes(receive_data);
            //            stream.Write(Response_Data, 0, Response_Data.Length); // 데이터 송신
            //            textBox3.Text = receive_data;
            //        }
            //        else if (receive_data_2 == "$") // 유저 select
            //        {
            //            receive_data = "select 받았습니다~";
            //            byte[] Response_Data = Encoding.Default.GetBytes(receive_data);
            //            stream.Write(Response_Data, 0, Response_Data.Length); // 데이터 송신
            //            textBox3.Text = receive_data;
            //        }
            //    }

            //    else if (receive_data_1 == "{{#@") // 모델 프로토콜
            //    {
            //        if (receive_data_2 == "!") // 모델 insert
            //        {
            //            receive_data = "insert 받았습니다~";
            //            Mo.m_i(Int32.Parse(receive_data_division[1]), Convert.ToSingle(receive_data_division[2]), Convert.ToSingle(receive_data_division[3]), receive_data_division[4]);
            //            byte[] Response_Data = Encoding.Default.GetBytes(receive_data);
            //            stream.Write(Response_Data, 0, Response_Data.Length);
            //            textBox3.Text = receive_data;
            //        }
            //        else if (receive_data_2 == "@") // 모델 delete
            //        {
            //            receive_data = "delete 받았습니다~";
            //            Mo.m_d(Int32.Parse(receive_data_division[1]));
            //            byte[] Response_Data = Encoding.Default.GetBytes(receive_data);
            //            stream.Write(Response_Data, 0, Response_Data.Length);
            //            textBox3.Text = receive_data;
            //        }
            //        else if (receive_data_2 == "#") // 모델 update
            //        {
            //            receive_data = "update 받았습니다~";
            //            Mo.m_u(1, Int32.Parse(receive_data_division[1]), Convert.ToSingle(receive_data_division[2]), Convert.ToSingle(receive_data_division[3]), receive_data_division[4]);
            //            byte[] Response_Data = Encoding.Default.GetBytes(receive_data);
            //            stream.Write(Response_Data, 0, Response_Data.Length);
            //            textBox3.Text = receive_data;
            //        }
            //        else if (receive_data_2 == "$") // 모델 select
            //        {
            //            Mo.Model_select();
            //            receive_data = Model.All_se;
            //            byte[] Response_Data = Encoding.Default.GetBytes(receive_data);
            //            stream.Write(Response_Data, 0, Response_Data.Length);
            //            textBox3.Text = receive_data;
            //        }
            //        else if (receive_data_2 == "%") // 모델 select
            //        {
            //            Mo.m_s2();
            //            receive_data = Model.All_se;
            //            byte[] Response_Data = Encoding.Default.GetBytes(receive_data);
            //            stream.Write(Response_Data, 0, Response_Data.Length);
            //            textBox3.Text = receive_data;
            //        }
            //    }

            //    else if (receive_data_1 == "{{##") // lot 프로토콜
            //    {
            //        if (receive_data_2 == "!") // lot insert
            //        {
            //            Lo.LO_CRE(receive_data_division[1], receive_data_division[2], receive_data_division[3], receive_data_division[4], receive_data_division[5], receive_data_division[6], receive_data_division[7], receive_data_division[8], receive_data_division[9], receive_data_division[10], receive_data_division[11]);
            //            receive_data = "작업지시 받았습니다~";
            //            byte[] Response_Data = Encoding.Default.GetBytes(receive_data);
            //            stream.Write(Response_Data, 0, Response_Data.Length);
            //            textBox3.Text = textBox3.Text + receive_data;
            //        }
            //    }

            //    else if (receive_data_division[0] == "{{$00") // 로그인 프로토콜
            //    {
            //        if (receive_data_division[1] == "req_user_log_in")
            //        {
            //            List<DB_USERS> List_Users = new List<DB_USERS>();
            //            DB_MGR.Users_Select(ref List_Users);

            //            for (int i = 0; i<List_Users.Count; i++)
            //            {
            //                if(receive_data_division[2] == List_Users[i].User_Id && receive_data_division[3] == List_Users[i].Pass_Word) // 아이디 비밀번호 일치 판단문
            //                {
            //                    Req_User_Log_In.result ="OK";

            //                    Req_User_Log_In.level = List_Users[i].Level;
            //                    if(Req_User_Log_In.level == "1")
            //                    {
            //                        Req_User_Log_In.right = "OPER";
            //                    }
            //                    else if(Req_User_Log_In.level == "2")
            //                    {
            //                        Req_User_Log_In.right = "ADMIN";
            //                    }
            //                    break;
            //                }
            //                else
            //                {
            //                    Req_User_Log_In.result = "NG";
            //                }
                            
            //            }
            //            if (Req_User_Log_In.result == "NG")
            //            {
            //                Req_User_Log_In.nak_reason = "오류남";
            //            }
            //            send_data = "{{#00,login_req_ack," + Req_User_Log_In.result + "," + Req_User_Log_In.right + "," + Req_User_Log_In.nak_reason + ",#}}";
            //            byte[] Response_Data = Encoding.Default.GetBytes(send_data);
            //            stream.Write(Response_Data, 0, Response_Data.Length);
            //            textBox3.Text = send_data + Req_User_Log_In.level;
            //        }
            //    }



            //    else if (receive_data == "ㅂㅇㄹ")
            //    {
            //                receive_data = "는 바이루";
            //        byte[] msg = Encoding.Default.GetBytes(receive_data);
            //        stream.Write(msg, 0, msg.Length);
            //        textBox3.Text = receive_data;
            //    }



            //}
        }

            private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace winform_real_server
{
    class Server
    {
        fmMain fm;
        public static string bintIp = "220.69.249.226";
        const int bindPort = 4000;
        
        public static IPEndPoint localAddress = new IPEndPoint(IPAddress.Parse(bintIp), bindPort);
        public static TcpListener server = new TcpListener(localAddress);

        public Server(fmMain ff)
        {
            fm = ff;
        }
        public Server()
        {

        }
        public void Server_Open()
        {
            server.Start();
            fm.textBox1.Text = "Aria Project Server Open";

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();

                ((IPEndPoint)client.Client.RemoteEndPoint).ToString();

                NetworkStream stream = client.GetStream();

                int length;
                string receive_data = null; // 클라이언트로부터 수신되는 값이 저장 될 변수
                string send_data = null; // 클라이언트에게 송신할 값이 저장 될 변수
                byte[] bytes = new byte[256];
                length = stream.Read(bytes, 0, bytes.Length);

                receive_data = Encoding.Default.GetString(bytes, 0, length);// 데이터 수신
                fm.textBox2.Text = fm.textBox2.Text + receive_data;

                string[] receive_data_division = receive_data.Split(new char[] { ',' });

                if(receive_data_division[0] == "{{$00")
                {
                    if(receive_data_division[1] == "req_user_log_in") // user_login 프로토콜
                    {
                        List<DB_USERS> List_Users = new List<DB_USERS>();
                        DB_MGR.Users_Select(ref List_Users);

                        for (int i = 0; i < List_Users.Count; i++)
                        {
                            if (receive_data_division[2] == List_Users[i].User_Id && receive_data_division[3] == List_Users[i].Pass_Word) // 아이디 비밀번호 일치 판단문
                            {
                                Req_User_Log_In.result = "OK";

                                Req_User_Log_In.level = List_Users[i].Level;
                                if (Req_User_Log_In.level == "1")
                                {
                                    Req_User_Log_In.right = "OPER";
                                }
                                else if (Req_User_Log_In.level == "2")
                                {
                                    Req_User_Log_In.right = "ADMIN";
                                }
                                break;
                            }
                            else
                            {
                                Req_User_Log_In.result = "NG";
                            }

                        }
                        if (Req_User_Log_In.result == "NG")
                        {
                            Req_User_Log_In.nak_reason = "오류남";
                        }
                        send_data = "{{$00,login_req_ack," + Req_User_Log_In.result + "," + Req_User_Log_In.right + "," + Req_User_Log_In.nak_reason + ",#}}";
                        byte[] Response_Data = Encoding.Default.GetBytes(send_data);
                        stream.Write(Response_Data, 0, Response_Data.Length);
                        fm.textBox3.Text = send_data + Req_User_Log_In.level;
                    }
                }
                else if(receive_data_division[0] == "{{$01")
                {
                    

                    if (receive_data_division[1] == "req_new_user_create")
                    {
                        DB_USERS User = new DB_USERS(receive_data_division[2], receive_data_division[3], receive_data_division[4], receive_data_division[5], receive_data_division[6], receive_data_division[7]);
                        DB_MGR.Users_Insert(ref User);

                        send_data = "{{$01,req_new_user_create_ack,result,ng_reasondddddddddddddddddddddddd$}}";
                        byte[] Response_Data = Encoding.Default.GetBytes(send_data);
                        stream.Write(Response_Data, 0, Response_Data.Length);
                        fm.textBox3.Text = send_data + Req_User_Log_In.level;
                    }
                    else if (receive_data_division[1] == "req_user_delete")
                    {
                        DB_USERS User2 = new DB_USERS();
                        User2.User_Id = receive_data_division[2];
                        DB_MGR.Users_Delete(ref User2);

                        send_data = "{{$01,req_user_delete,딜리트했슴요,ng_reason,$}}";
                        byte[] Response_Data = Encoding.Default.GetBytes(send_data);
                        stream.Write(Response_Data, 0, Response_Data.Length);
                        fm.textBox3.Text = send_data + Req_User_Log_In.level;
                    }
                    else if (receive_data_division[1] == "req_user_update")
                    {
                        //DB_MGR.Users_Update(ref User);

                        send_data = "{{$01,req_user_update,result,ng_reason$}}";
                    }
                    else if (receive_data_division[1] == "req_user_select")
                    {
                        List<DB_USERS> User = new List<DB_USERS>();
                        DB_MGR.Users_Select(ref User);
                        int a = 0;
                        foreach(DB_USERS ee in User)
                        {
                            send_data = send_data + ee.User_Id + "\n";
                            a++;
                        }

                        byte[] Response_Data = Encoding.Default.GetBytes(send_data);
                        stream.Write(Response_Data, 0, Response_Data.Length);
                        fm.textBox3.Text = send_data + Req_User_Log_In.level;
                    }
                }
                }
            }
            /*string bintIp = "220.69.249.226";
            const int bindPort = 4000;
            TcpListener server = null;
            //서버주소 바인딩(ip번호, port번호)


            IPEndPoint localAddress = new IPEndPoint(IPAddress.Parse(bintIp), bindPort);
            //서버 만들기, 주소바인딩~!!!
            server = new TcpListener(localAddress);

            server.Start();
            textBox1.Text = "ARIA 프로젝트 서버";

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();

                ((IPEndPoint)client.Client.RemoteEndPoint).ToString();

                NetworkStream stream = client.GetStream();

                int length;
                string data = null;
                byte[] bytes = new byte[256];
                length = stream.Read(bytes, 0, bytes.Length);

                data = Encoding.Default.GetString(bytes, 0, length);// 데이터 수신
                textBox2.Text = data;

                string Ddta, Ddta2;
                Ddta = data.Substring(0, 4);
                Ddta2 = data.Substring(4, 1);
                Model Mo = new Model(this);
                Lot Lo = new Lot(this);
                string[] Moar = data.Split(new char[] { ',' });


                if (Ddta == "{{#!") // 유저 프로토콜
                {
                    if (Ddta2 == "!") // 유저 insert
                    {
                        data = "insert 받았습니다~";
                        byte[] msg = Encoding.Default.GetBytes(data);
                        stream.Write(msg, 0, msg.Length); // 데이터 송신
                        textBox3.Text = data;
                    }
                    else if (Ddta2 == "@") // 유저 delete
                    {
                        data = "delete 받았습니다~";
                        byte[] msg = Encoding.Default.GetBytes(data);
                        stream.Write(msg, 0, msg.Length); // 데이터 송신
                        textBox3.Text = data;
                    }
                    else if (Ddta2 == "#") // 유저 update
                    {
                        data = "update 받았습니다~";
                        byte[] msg = Encoding.Default.GetBytes(data);
                        stream.Write(msg, 0, msg.Length); // 데이터 송신
                        textBox3.Text = data;
                    }
                    else if (Ddta2 == "$") // 유저 select
                    {
                        data = "select 받았습니다~";
                        byte[] msg = Encoding.Default.GetBytes(data);
                        stream.Write(msg, 0, msg.Length); // 데이터 송신
                        textBox3.Text = data;
                    }
                }

                else if (Ddta == "{{#@") // 모델 프로토콜
                {
                    if (Ddta2 == "!") // 모델 insert
                    {
                        data = "insert 받았습니다~";
                        Mo.m_i(Int32.Parse(Moar[1]), Convert.ToSingle(Moar[2]), Convert.ToSingle(Moar[3]), Moar[4]);
                        byte[] msg = Encoding.Default.GetBytes(data);
                        stream.Write(msg, 0, msg.Length);
                        textBox3.Text = data;
                    }
                    else if (Ddta2 == "@") // 모델 delete
                    {
                        data = "delete 받았습니다~";
                        Mo.m_d(Int32.Parse(Moar[1]));
                        byte[] msg = Encoding.Default.GetBytes(data);
                        stream.Write(msg, 0, msg.Length);
                        textBox3.Text = data;
                    }
                    else if (Ddta2 == "#") // 모델 update
                    {
                        data = "update 받았습니다~";
                        Mo.m_u(1, Int32.Parse(Moar[1]), Convert.ToSingle(Moar[2]), Convert.ToSingle(Moar[3]), Moar[4]);
                        byte[] msg = Encoding.Default.GetBytes(data);
                        stream.Write(msg, 0, msg.Length);
                        textBox3.Text = data;
                    }
                    else if (Ddta2 == "$") // 모델 select
                    {
                        Mo.m_s();
                        data = Model.All_se;
                        byte[] msg = Encoding.Default.GetBytes(data);
                        stream.Write(msg, 0, msg.Length);
                        textBox3.Text = data;
                    }
                    else if (Ddta2 == "%") // 모델 select
                    {
                        Mo.m_s2();
                        data = Model.All_se;
                        byte[] msg = Encoding.Default.GetBytes(data);
                        stream.Write(msg, 0, msg.Length);
                        textBox3.Text = data;
                    }
                }

                else if (Ddta == "{{##") // lot 프로토콜
                {
                    if (Ddta2 == "!") // lot insert
                    {
                        Lo.LO_CRE(Moar[1], Moar[2], Moar[3], Moar[4], Moar[5], Moar[6], Moar[7], Moar[8], Moar[9], Moar[10], Moar[11]);
                        data = "작업지시 받았습니다~";
                        byte[] msg = Encoding.Default.GetBytes(data);
                        stream.Write(msg, 0, msg.Length);
                        textBox3.Text = data;
                    }
                }



                else if (data == "ㅂㅇㄹ")
                {
                    data = "는 바이루";
                    byte[] msg = Encoding.Default.GetBytes(data);
                    stream.Write(msg, 0, msg.Length);
                    textBox3.Text = data;
                }



            }*/
        }
    }


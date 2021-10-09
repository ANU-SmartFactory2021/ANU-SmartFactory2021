﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CanFactoryServer
{
    class server  
    {

        //서버 세팅

        TcpListener server_socket = new TcpListener(IPAddress.Any, 9999);
        TcpClient inspect_client = new TcpClient();
        TcpClient control_client = new TcpClient();
        TcpClient winform_client = new TcpClient();

        List<Socket> client_list = new List<Socket>();

        Thread accept_thread = null;
        Thread recieve_message_thread = null;

       



        public void server_start()  //서버 시작 함수 
        {
            server_socket.Start();

            accept_thread = new Thread(new ThreadStart(Accept_thread));
            accept_thread.Start();

            recieve_message_thread = new Thread(new ThreadStart(Recieve_message_thread));
            recieve_message_thread.Start();

        }

        void Accept_thread()   //서버 수용 쓰레드 함수 
        {
            while (true)
            {
                Thread.Sleep(1);

                TcpClient tc = server_socket.AcceptTcpClient();
                Console.WriteLine("Accept " + tc.Client.AddressFamily.ToString());

                //byte[] buff = new byte[256];
                //tc.Client.Receive(buff);
                //string recv_str = Encoding.Default.GetString(buff);
                //recv_str = recv_str.Trim('\0');
                string recv_str = Receive(tc);
                recv_str = recv_str.Trim('\0');
                recv_str = recv_str.Trim('\n');
                recv_str = recv_str.Trim('\r');

                if (recv_str.Contains("CLIENT_TYPE"))   //서버 수신 시 클라이언트 타입 별로 상태메시지 출력 
                {
                    string[] token = recv_str.Split('=');
                    if (token.Length < 2)
                    {
                        tc.Close();
                        continue;
                    }

                    if (token[1].ToUpper() == "INSPECTION")
                    {
                        Console.WriteLine(recv_str);
                        inspect_client = tc;
                        send_inspect_client("ack");
                    }
                    else if (token[1].ToUpper() == "CONTROL")
                    {
                        control_client = tc;
                        send_control_client("ack");
                    }
                    else if (token[1].ToUpper() == "WINFORM")
                    {
                        winform_client = tc;
                    }
                }
            }
        }

        string total_data = "";
        string remaind_data = "";

        string Receive(TcpClient _client)   //데이터 수신 메소드  
        {
            while (true)
            {
                byte[] buff = new byte[4096];
                try
                {
                    _client.Client.Receive(buff);
                }
                catch (Exception ex)
                {
                    _client.Close();
                    return "";
                }

                string recv_str = Encoding.Default.GetString(buff);
                recv_str = recv_str.Trim('\0');

                if (remaind_data.Length > 0)
                {
                    recv_str = remaind_data + recv_str;
                    remaind_data = "";
                }

                int start_index = recv_str.IndexOf('<');
                if (0 <= start_index)
                {
                    total_data = "";
                    recv_str = recv_str.Remove(0, start_index);
                }
                total_data += recv_str;

                if (total_data.Contains('>'))
                {
                    string[] split_data = total_data.Split('>');
                    total_data = split_data[0];
                    remaind_data = split_data[1];

                    total_data = total_data.Remove(0, 1);    // 맨 앞 '<' 제거.
                    Console.WriteLine("RECIEVE DATA = " + total_data);
                    Console.WriteLine("@@@@@@@@@@@");
                    Console.WriteLine("");
                    return total_data;
                }
            }

        }



        void Recieve_message_thread()  //메시지 수신 쓰레드 
        {
            while (true)
            {
                Thread.Sleep(1);

                if (inspect_client_connected() == true && inspect_client.Client.Available > 0)             // PI_1 리시브 시
                {
                    string inspect_recv_str = Receive(inspect_client);
                    inspect_recv_str = inspect_recv_str.Trim('\0');

                    if (inspect_recv_str.Contains("PI_ONE_STATE"))
                    {
                        string[] token = inspect_recv_str.Split('=');

                        if (token[1].ToUpper() == "START")
                        {
                            send_winform_client("<CMD=PI_ONE_READY>");
                        }

                        else if (token[1].ToUpper() == "FAIL")
                        {
                            send_inspect_client("<CMD=REQUEST_START>");
                        }

                        else if (token[1].ToUpper() == "STOP")
                        {
                            send_winform_client("<CMD=CHANGE>");
                        }
                    }

                    if (inspect_recv_str.Contains("RECV_ACK"))
                    {
                        send_control_client("<CMD=BELT_START>");
                    }

                    if (inspect_recv_str.Contains("QRCODE"))
                    {
                        //   <QRCODE=1234567890|QUALITY=PASS|이미지 데이터>

                        var recv_data = inspect_recv_str.Split('|');
                        string image_data = recv_data[2];
                        string state_result = recv_data[1];
                        string qrcode_num = recv_data[0];

                        send_winform_client("<" + inspect_recv_str + ">");

                        string[] QR_VALUE = qrcode_num.Split('=');

                        string[] token = state_result.Split('=');

                        if (token[1].ToUpper() == "PASS")
                        {
                            send_control_client("<CMD=CLASSIFY_LEFT>");
                        }

                        else if (token[1].ToUpper() == "FAIL")
                        {
                            send_control_client("<CMD=CLASSIFY_RIGHT>");
                        }

                    }

                }

                if (control_client_connected() == true && control_client.Client.Available > 0)      // PI_2  리시브 시
                {
                    string control_recv_str = Receive(control_client);
                    control_recv_str = control_recv_str.Trim('\0');

                    if (control_recv_str.Contains("PI_TWO_STATE"))
                    {
                        string[] token = control_recv_str.Split('=');

                        if (token[1].ToUpper() == "START")
                        {
                            send_winform_client("<CMD=PI_TWO_READY>");
                            send_control_client("<CMD=REQUEST_SENSOR_STATE>");
                        }

                        else if (token[1].ToUpper() == "FAIL")
                        {
                            send_control_client("<CMD=REQUEST_START>");
                        }
                    }

                    if (control_recv_str.Contains("SENSOR_STATE"))
                    {
                        string[] token = control_recv_str.Split('=');

                        if (token[1].ToUpper() == "ON")
                        {
                            send_winform_client("<CMD=IS>");

                            send_inspect_client("<CMD=CAPTURE_START>");

                        }

                        else if (token[1].ToUpper() == "OFF")
                        {
                            send_control_client("<CMD=REQUEST_SENSOR_STATE>");
                        }
                    }

                    if (control_recv_str.Contains("LINE_STATE"))
                    {
                        string[] token = control_recv_str.Split('=');

                        if (token[1].ToUpper() == "RUNNING")
                        {
                            Thread.Sleep(1000);
                            send_winform_client("<CMD=RUN>");
                        }

                        else if (token[1].ToUpper() == "PASSING")
                        {
                            send_winform_client("<CMD=REMOVE>");
                        }

                        else if (token[1].ToUpper() == "CLASSIFYING")
                        {
                            send_control_client("<ACK>");
                            send_winform_client("<CMD=LAST>");
                        }

                        else if (token[1].ToUpper() == "STOP")
                        {
                            send_winform_client("<CMD=EMERGENCY>");
                        }

                        else if (token[1].ToUpper() == "WORKING")
                        {
                            send_winform_client("<CMD=CLASSIFY>");
                        }

                        else if (token[1].ToUpper() == "COMPLETE")
                        {                         
                            send_winform_client("<CMD=FINISH>");
                        }

                    }
                }

                if (winform_client_connected() == true && winform_client.Client.Available > 0)      // PI_3(윈폼) 리시브
                {
                    string winform_recv_str = Receive(winform_client);
                    winform_recv_str = winform_recv_str.Trim('\0');

                    if (winform_recv_str.Contains("CMD"))
                    {
                        string[] token = winform_recv_str.Split('=');

                        if (token[1].ToUpper() == "START")
                        {
                            send_inspect_client("<CMD=REQUEST_START>");
                            send_control_client("<CMD=REQUEST_START>");
                        }

                        if (token[1].ToUpper() == "STOP")
                        {
                            send_control_client("<CMD=BELT_STOP>");
                            send_inspect_client("<CMD=CAPTURE_STOP>");
                        }
                    }
                }


            }
        }




        public bool winform_client_connected()   //PI_3 연결 확인 
        {
            if (winform_client.Client != null)
            {
                return winform_client.Client.Connected;
            }
            return false;
        }

        public bool inspect_client_connected()  //PI_1 연결 확인 
        {
            if (inspect_client.Client != null)
            {
                return inspect_client.Client.Connected;
            }
            return false;
        }

        public bool control_client_connected() //PI_2 연결 확인 
        {
            if (control_client.Client != null)
            {
                return control_client.Client.Connected;
            }
            return false;
        }



        public void send_winform_client(string _cmd)    //  PI_3 메시지 전송 함수 
        {
            if (winform_client_connected() == true)
            {
                winform_client.Client.Send(Encoding.UTF8.GetBytes(_cmd));
            }
            else if (winform_client_connected() == false)
            {
                Console.WriteLine("WINFORM_CLIENT is not connected !");
            }


        }

        public void send_inspect_client(string _cmd)    //  PI_1 메시지 전송 함수 
        {
            if (inspect_client_connected() == true)
            {
                inspect_client.Client.Send(Encoding.UTF8.GetBytes(_cmd));
                Console.WriteLine("INSPECTION_CLIENT send : " + _cmd);
            }
            else if (inspect_client_connected() == false)
                Console.WriteLine("INSPECTION_CLIENT is not connected !");


        }

        public void send_control_client(string _cmd)   //  PI_2 메시지 전송 함수 
        {
            if (control_client_connected() == true)
            {
                control_client.Client.Send(Encoding.UTF8.GetBytes(_cmd));
            }
            else if (control_client_connected() == false)
                Console.WriteLine("CONTROL_CLIENT is not connected !");
        }



    }
}



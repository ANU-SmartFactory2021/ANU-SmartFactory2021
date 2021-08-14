using System;
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
        TcpListener server_socket = new TcpListener(IPAddress.Any, 12345);
        TcpClient inspect_client = new TcpClient();
        TcpClient control_client = new TcpClient();
        TcpClient winform_client = new TcpClient();

        List<Socket> client_list = new List<Socket>();
 
        
    

        Thread accept_thread = null;
        Thread recieve_message_thread = null;



        string total_data = "";
        string remaind_data = "";


        public void server_start()
        {
            server_socket.Start();

            accept_thread = new Thread(new ThreadStart(Accept_thread));
            accept_thread.Start();

            recieve_message_thread = new Thread(new ThreadStart(Recieve_message_thread));
            recieve_message_thread.Start();
        
        }

        void Accept_thread()
        {
            while (true)
            {
                Thread.Sleep(1);

                TcpClient tc = server_socket.AcceptTcpClient();

                byte[] buff = new byte[256];
                tc.Client.Receive(buff);
                string recv_str = Encoding.Default.GetString(buff);
                recv_str = recv_str.Trim('\0');
               

                if (recv_str.Contains("CLIENT_TYPE"))
                {
                    string[] token = recv_str.Split('=');
                    if (token.Length < 2)
                    {
                        tc.Close();
                        continue;
                    }

                    if (token[1].ToUpper() == "INSPECTION")
                    {
                        inspect_client = tc;
                    }
                    else if (token[1].ToUpper() == "CONTROL")
                    {
                        control_client = tc;
                    }
                    else if (token[1].ToUpper() == "WINFORM")
                    {
                        winform_client = tc; 
                    }
                }
            }
        }


        string Receive( TcpClient _client )
		{
            while( true )
			{
                byte[] buff = new byte[ 4096 ];
                try
                {
                    _client.Client.Receive( buff );
                }
                catch( Exception ex )
                {
                    _client.Close();
                    return "";
                }

                string recv_str = Encoding.Default.GetString( buff );
                recv_str = recv_str.Trim( '\0' );

                if( remaind_data.Length > 0 )
                {
                    recv_str = remaind_data + recv_str;
                    remaind_data = "";
                }

                int start_index = recv_str.IndexOf( '<' );
                if( 0 <= start_index )
                {
                    total_data = "";
                    recv_str = recv_str.Remove( 0, start_index );
                }
                total_data += recv_str;

                if( total_data.Contains( '>' ) )
                {
                    string[] split_data = total_data.Split( '>' );
                    total_data = split_data[ 0 ];
                    remaind_data = split_data[ 1 ];

                    total_data = total_data.Remove( 0, 1 ); // 맨 앞 '<' 제거.

                    break;
                }
            }


            return total_data;
        }


        void Recieve_message_thread()
        {
            while(true)
            {
                Thread.Sleep(1);
                
                if(inspect_client_connected() == true && inspect_client.Client.Available > 0)             // PI 1 리시브 
                {
                    //byte[] message = new byte[256];
                    //inspect_client.Client.Receive(message);
                    //string inspect_recv_str = Encoding.Default.GetString(message);
                    string inspect_recv_str = Receive( inspect_client );
                    inspect_recv_str = inspect_recv_str.Trim('\0');                     

                    if (inspect_recv_str.Contains("PI_ONE_STATE"))
                    {
                        string[] token = inspect_recv_str.Split('=');

                        if (token[1].ToUpper() == "START")
                        {
                            
                        }
                        
                        else if (token[1].ToUpper()== "FAIL")
                        {

                        }


                    }
                }
                if(control_client_connected() == true && control_client.Client.Available > 0)      // PI2  리시브 
                {
                    //byte[] message = new byte[256];
                    //control_client.Client.Receive(message);
                    //string control_recv_str = Encoding.Default.GetString(message);
                    string control_recv_str = Receive( control_client );
                    control_recv_str = control_recv_str.Trim('\0');

                    if (control_recv_str.Contains("PI_TWO_STATE"))
                    {
                        string[] token = control_recv_str.Split('=');

                        if (token[1].ToUpper() == "START")
                        {
                            
                        }

                        else if (token[1].ToUpper() == "FAIL")
                        {

                        }
                    }

                    if (control_recv_str.Contains("SENSOR_STATE"))
                    {
                        string[] token = control_recv_str.Split('=');

                        if (token[1].ToUpper() == "ON")
                        {

                        }

                        else if(token[1].ToUpper() == "OFF")
                        {

                        }
                    }

                    if (control_recv_str.Contains("LINE_STATE"))
                    {
                        string[] token = control_recv_str.Split('=');

                        if (token[1].ToUpper() == "RUNNING")
                        {

                        }

                        else if (token[1].ToUpper() == "PASSING")
                        {

                        }

                        else if (token[1].ToUpper() == "STOP")
                        {

                        }

                        else if (token[1].ToUpper() == "WORKING")
                        {

                        }

                        else if (token[1].ToUpper() == "COMPLETE")
                        {

                        }

                    }
                }

                if(winform_client_connected() == true && winform_client.Client.Available > 0 )      // PI3(윈폼)  리시브 
                {
                    //byte[] message = new byte[256];
                    //winform_client.Client.Receive(message);
                    //string winform_recv_str = Encoding.Default.GetString(message);
                    string winform_recv_str = Receive( winform_client );
                    winform_recv_str = winform_recv_str.Trim('\0');

                    if (winform_recv_str.Contains("CMD"))
                    {
                        string[] token = winform_recv_str.Split('=');

                        if (token[1].ToUpper() == "START")
                        {

                        }
                    }
                }
               

            }
        }




        public bool winform_client_connected()
        {
            return winform_client.Client.Connected;
        }

        public bool inspect_client_connected()
        {
            return inspect_client.Client.Connected;
        }

        public bool control_client_connected()
        {
            return control_client.Client.Connected;
        }

       

        public void send_winform_client( string _cmd )
        {
            winform_client.Client.Send(Encoding.UTF8.GetBytes( _cmd ));
        }

        public void send_inspect_client(string _cmd)
        {
            inspect_client.Client.Send(Encoding.UTF8.GetBytes(_cmd));
        }

        public void send_control_client(string _cmd)
        {
            control_client.Client.Send(Encoding.UTF8.GetBytes(_cmd));
        }

        

    }
}

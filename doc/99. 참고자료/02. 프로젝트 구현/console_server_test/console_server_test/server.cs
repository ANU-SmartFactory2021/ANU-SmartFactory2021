using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace console_server_test
{
	class server
	{
		TcpListener m_server_socket = new( IPAddress.Any, 12345 );
		TcpClient m_inspection_client = new();
		TcpClient m_classifying_client = new();

		List<Socket> client_list = new();

		Thread accpet_thread = null;

		public void server_start()
		{
			m_server_socket.Start();

			accpet_thread = new( new ThreadStart( accept_thread ) );
			accpet_thread.Start();
		}

		void accept_thread()
		{
			while( true )
			{
				Thread.Sleep( 1 );

				TcpClient tc = m_server_socket.AcceptTcpClient();

				byte[] buff = new byte[ 256 ];
				tc.Client.Receive( buff );
				string recv_str = Encoding.Default.GetString( buff );
				recv_str = recv_str.Trim('\0');

				if( recv_str.Contains( "CLIENT_TYPE" ) )
				{
					string[] token = recv_str.Split( '=' );
					if( token.Length < 2 )
					{
						tc.Close();
						continue;
					}

					if( token[ 1 ].ToUpper() == "INSPECTION" )
					{
						m_inspection_client = tc;
					}
					else if( token[ 1 ].ToUpper() == "CLASSIFYING" )
					{
						m_classifying_client = tc;
					}
				}
			}
		}

		public bool inspection_client_connected()
		{
			return m_inspection_client.Client.Connected;
		}

		public void send_inspection_client( string _cmd )
		{
			m_inspection_client.Client.Send( Encoding.UTF8.GetBytes( _cmd ) );
		}
	}
}

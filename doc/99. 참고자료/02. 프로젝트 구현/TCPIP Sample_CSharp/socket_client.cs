using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TCPIP_Sample_CSharp {

	class socket_client {

		static string m_ip = null;
		static int m_port = 0;
		Thread m_thread = null;
		static TcpClient m_tc = null;
		public delegate void recv_callback( string _msg );
		static recv_callback m_recv_callback;

		public socket_client( recv_callback _recv_callback = null ) {
			m_recv_callback = _recv_callback;
		}


		public void connect( string _ip, int _port ) {
			disconnect();

			m_ip = _ip;
			m_port = _port;

			m_tc = new TcpClient( _ip, _port );
			if( m_tc.Connected == true ) {
				m_recv_callback?.Invoke( string.Format( "Connect to server, success" ) );

				ThreadStart ts = new ThreadStart( thread_proc_on_recv );
				m_thread = new Thread( ts );
				m_thread.Start();
			}
		}

		public void disconnect() {

			if( m_tc != null ) {
				if( m_tc.Connected == true )
					m_tc.Client.Disconnect( false );
				m_tc.Close();
			}
			m_thread?.Abort();
		}

		private static async void thread_proc_on_recv() {
			NetworkStream stream = null;
			while( true ) {
				try {
					if( m_tc.Connected == false ) {
						Thread.Sleep( 100 );
						continue;
					}

					stream = m_tc.GetStream();

					// (4) 스트림으로부터 바이트 데이타 읽기
					byte[] outbuf = new byte[ 1024 ];
					int nbytes = await stream.ReadAsync( outbuf, 0, outbuf.Length );
					if( nbytes > 0 ) {
						string msg = Encoding.ASCII.GetString( outbuf, 0, nbytes );
						m_recv_callback?.Invoke( string.Format( "[Recv] : " + msg ) );
					} else {
						m_tc.Close();
					}
				} catch( Exception ) {
					stream.Close();
				}
			}
		}
		public void send( string _msg ) {
			m_tc.GetStream().WriteAsync( Encoding.ASCII.GetBytes( _msg ), 0, _msg.Length );
		}
	}
}

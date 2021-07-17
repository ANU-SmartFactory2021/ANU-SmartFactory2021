using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace TCPIP_Sample_CSharp {
	class socket_server {

		static int m_port = 0;
		Thread m_thread = null;
		static List<TcpClient> m_client_list = new List<TcpClient>();

		static TcpListener m_listener = null;
		public delegate void recv_callback( string _msg );
		static recv_callback m_recv_callback;

		public socket_server( recv_callback _recv_callback = null ) {
			m_recv_callback = _recv_callback;
		}

		public void start( int _port ) {
			stop();

			m_port = _port;

			ThreadStart ts = new ThreadStart( thread_proc_server_run );
			m_thread = new Thread( ts );
			m_thread.Start();
		}

		public void stop() {
			foreach( var client in m_client_list ) {
				client.Close();
			}
			m_listener?.Stop();
			m_thread?.Abort();
		}

		private static void thread_proc_server_run() {
			try {
				if( async_accept().IsCompleted )
					async_accept().Wait();
			} catch( Exception ex ) {
				m_recv_callback?.Invoke( string.Format( "Server Error : " + ex.Message ) );
			}
		}

		async static Task async_accept() {
			m_listener = new TcpListener( IPAddress.Any, m_port );
			m_listener.Start();
			m_recv_callback?.Invoke( string.Format( "Server Start, success" ) );
			while( true ) {

				// 비동기 Accept                
				TcpClient tc = await m_listener.AcceptTcpClientAsync().ConfigureAwait( false );
				m_client_list.Add( tc );
				m_recv_callback?.Invoke( string.Format( "Accept Client" ) );

				// 새 쓰레드에서 처리
				await Task.Factory.StartNew( thread_proc_on_recv, tc );
			}
		}

		async private static void thread_proc_on_recv( object _obj ) {
			TcpClient tc = ( TcpClient )_obj;
			NetworkStream stream = null;
			while( true ) {
				try {
					if( tc.Connected == false ) {
						Thread.Sleep( 100 );
						continue;
					}

					int MAX_SIZE = 1024;  // 가정
					stream = tc.GetStream();

					// 비동기 수신
					var buff = new byte[ MAX_SIZE ];
					var nbytes = await stream.ReadAsync( buff, 0, buff.Length ).ConfigureAwait( false );
					if( nbytes > 0 ) {
						string msg = Encoding.ASCII.GetString( buff, 0, nbytes );
						m_recv_callback?.Invoke( string.Format( "[Recv] : " + msg ) );
					}
				} catch( Exception ex ) {
					stream.Close();
					tc.Close();
					m_recv_callback?.Invoke( string.Format( "Receive Error : " + ex.Message ) );
				}
			}
		}

		public void send( string _msg ) {
			foreach( var client in m_client_list ) {
				client.GetStream().WriteAsync( Encoding.ASCII.GetBytes( _msg ), 0, _msg.Length );
			}
		}
	}
}

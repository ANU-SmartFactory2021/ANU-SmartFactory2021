using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPIP_Sample_CSharp {
	public partial class main : Form {

		socket_server m_server = null;
		socket_client m_client = null;

		public main() {
			InitializeComponent();
		}

		private void main_Shown( object sender, EventArgs e ) {
			m_server = new socket_server( recv_callback );
			m_client = new socket_client( recv_callback );
		}

		private void on_click_server_client( object sender, EventArgs e ) {
			tb_server_setting_port.Enabled = false;
			tb_client_setting_ip.Enabled = false;
			tb_client_setting_port.Enabled = false;
			btn_server_setting_start.Enabled = false;
			btn_client_setting_connect.Enabled = false;
			m_server?.stop();
			m_client?.disconnect();

			if( sender.Equals( rbtn_server ) == true ) {
				tb_server_setting_port.Enabled = true;
				btn_server_setting_start.Enabled = true;
				rbtn_client.Checked = false;
			} else if( sender.Equals( rbtn_client ) == true ) {
				tb_client_setting_ip.Enabled = true;
				tb_client_setting_port.Enabled = true;
				btn_client_setting_connect.Enabled = true;
				rbtn_server.Checked = false;
			}
		}


		delegate void StringArgReturningVoidDelegate( string _msg );
		private void insert_log( string _msg ) {
			if( lbox_dialog.InvokeRequired == true ) {
				StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate( recv_callback );
				Invoke( d, new object[] { _msg } );
			} else {
				lbox_dialog.Items.Add( string.Format( "[{0}] : {1}", DateTime.Now.GetDateTimeFormats( 'T' )[ 0 ], _msg ) );
				lbox_dialog.SelectedIndex = lbox_dialog.Items.Count - 1;
			}

		}

		private void btn_server_setting_start_Click( object sender, EventArgs e ) {
			try {
				int port = Convert.ToInt32( tb_server_setting_port.Text );
				insert_log( string.Format( "Server Start ( Port : {0} )", port ) );

				m_server.start( port );
			} catch( Exception ex ) {
				insert_log( "Server Start Error : " + ex.Message );
			}
		}

		private void btn_client_setting_connect_Click( object sender, EventArgs e ) {
			try {
				string ip = tb_client_setting_ip.Text;
				int port = Convert.ToInt32( tb_client_setting_port.Text );
				insert_log( string.Format( "Connect to server Start ( IP : {0}, Port : {1} )", ip, port ) );

				m_client.connect( ip, port );
			} catch( Exception ex ) {
				insert_log( "Connect to server Error : " + ex.Message );
			}
		}

		private void btn_send_Click( object sender, EventArgs e ) {
			try {
				string msg = tb_input.Text;

				if( rbtn_server.Checked == true ) {
					m_server?.send( msg );
				} else if( rbtn_client.Checked == true ) {
					m_client?.send( msg );
				}

				insert_log( "[Send] : " + msg );
				tb_input.Text = "";
			} catch( Exception ex ) {
				insert_log( "Send Error : " + ex.Message );
			}
		}

		private void main_FormClosing( object sender, FormClosingEventArgs e ) {
			m_server?.stop();
			m_client?.disconnect();
		}

		private void recv_callback( string _msg ) {
			insert_log( _msg );
		}

		private void tb_input_KeyPress( object sender, KeyPressEventArgs e ) {
			char c = e.KeyChar;
			if( c == '\r' ) {
				btn_send_Click( sender, null );
			}
		}
	}
}

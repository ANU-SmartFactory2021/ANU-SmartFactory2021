using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using console_server_test;

namespace WinFormsApp1
{
	public partial class Form1 : Form
	{
		server svr = new server();

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load( object sender, EventArgs e )
		{
			svr.server_start();

			timer1.Interval = 1000;
			timer1.Enabled = true;
		}

		private void timer1_Tick( object sender, EventArgs e )
		{
			if( svr.image_data?.Length > 0 )
			{
				// Convert Base64 String to byte[]
				byte[] imageBytes = Convert.FromBase64String( svr.image_data );

				System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
				Image img = ( Image )converter.ConvertFrom( imageBytes );
				pictureBox1.Image = img;
				svr.image_data = "";
			}
		}

		private void textBox1_TextChanged( object sender, EventArgs e )
		{

		}

		private void btnLoadImage_Click( object sender, EventArgs e )
		{
			OpenFileDialog ofd = new OpenFileDialog();
			DialogResult dr = ofd.ShowDialog();
			if( dr == DialogResult.OK )
			{
				load_image.Image = Image.FromFile( ofd.FileName );
			}
		}

		private void btnSendImage_Click( object sender, EventArgs e )
		{
			using( MemoryStream m = new MemoryStream() )
			{
				load_image.Image.Save( m, load_image.Image.RawFormat );
				byte[] imageBytes = m.ToArray();
				string base64String = Convert.ToBase64String( imageBytes );

				//svr.send_clients( string.Format( "<QRCODE=1234567890|QUALITY=PASS|{0}>", "test" ) );
				svr.send_clients( string.Format("<QRCODE=1234567890|QUALITY=PASS|{0}>", base64String ) );
			}
		}

		private void btnSendText_Click( object sender, EventArgs e )
		{
			send_text();
		}

		private void send_text()
		{
			string text = textBox1.Text;
			svr.send_clients( text );

			print_log( text );

			textBox1.Text = "";
		}

		private void textBox1_KeyDown( object sender, KeyEventArgs e )
		{
			if( e.KeyCode == Keys.Enter )
			{
				send_text();
			}
		}

		public void print_log( string _text )
		{
			DateTime time = DateTime.Now;
			listBox1.Items.Add( string.Format( "[{0}] : {1}", time.ToString(), _text ) );
		}
	}
}

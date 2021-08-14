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
	}
}

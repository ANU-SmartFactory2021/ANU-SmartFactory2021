using System;
using System.Threading;

namespace console_server_test
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine( "Hello World!" );

			server server = new();
			server.server_start();

			while( true )
			{
				Thread.Sleep( 1000 );
				if( server.inspection_client_connected() )
					break;
			}

			server.send_inspection_client( "CMD=REQUEST_SENSOR_STATE" );
		}
	}
}

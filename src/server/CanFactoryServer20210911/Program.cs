using System;
using System.Threading;

namespace CanFactoryServer
{
	class Program
	{
       
        static void Main(string[] args)
		{
			Console.WriteLine("START SERVER...");

			server server = new server();
			server.server_start();

			database database = new database();
			

			
			
			

			while( true )
            {
				Thread.Sleep( 1000 );
				if (server.winform_client_connected())
                {
					Console.Write("WINFORM_CLIENT is connected");				
					break;
				}
          									
            }
					

			
			
			
		}
	}
}

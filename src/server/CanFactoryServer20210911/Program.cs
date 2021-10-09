using System;
using System.Threading;

namespace CanFactoryServer
{
	class Program
	{
       
        static void Main(string[] args)
		{
			Console.WriteLine("START SERVER...");   //서버 시작 메시지 출력 

			server server = new server();      
			server.server_start();           //서버 시작



			while ( true )
            {
				Thread.Sleep( 1000 );
				if (server.winform_client_connected())
                {
					Console.Write("WINFORM_CLIENT is connected");
					Console.WriteLine(""); 
					break;
				}
          									
            }
					

			
			
			
		}
	}
}

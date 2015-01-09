using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

using System.Net.NetworkInformation;
namespace ConsoleApplication1
{
    class Program
    {
        public static string data;
        static void Main(string[] args)
        {
            
            IPAddress ipAddress = IPAddress.Any;
            
            Int32 port = 9999;
            TcpListener listen = new TcpListener(ipAddress, port);
            listen.Start();
            byte[] bytes = new byte[1024];
            
            while (true)
            {

                
                TcpClient client = listen.AcceptTcpClient();
                


                NetworkStream stream = client.GetStream();

                int i;

                i = stream.Read(bytes, 0, bytes.Length);

                while (i != 0)
                {
                    // Translate data bytes to a ASCII string.
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    Console.WriteLine(String.Format("Received: {0}", data));

                    // Process the data sent by the client.
                    data = data.ToUpper();

                    

                   
                    

                    i = stream.Read(bytes, 0, bytes.Length);
                }
                if (data.Equals("dont"))
                {

                }
                else
                {
                    hack();
                }
                
            }
            
        }

        private static void hack()
        {
            Ping ping = new Ping();
            ping.Send(data);
        }
       
    }
}

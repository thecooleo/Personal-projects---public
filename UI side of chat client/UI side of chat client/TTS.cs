using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UI_side_of_chat_client
{
    class TTS
    {
        String IP;
        Int32 port;
        String username;
        int pin;
        public TTS(String IP, String username, Int32 port, int pin){
            this.IP = IP;
            this.username = username;
            this.port = port;
            this.pin = pin;

    }
        public void login()
        {
            String message = "log";
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

            TcpClient client = new TcpClient(IP, port);
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace ProxyTool
{/*
    class HttpServer
    {
        public void Start(int port)
        {
            var _tcpListener = new TcpListener(IPAddress.Any, port);
            _tcpListener.Start();

            Console.WriteLine("Server Started at port {0}", port);

            while(true)
            {
                var newClient = _tcpListener.AcceptTcpClient();
                ThreadPool.QueueUserWorkItem(new WaitCallback(ProcessClient), newClient);
            }
        }
        void ProcessClient(object state)
        {
            TcpClient client = (TcpClient) state;
            var buffer = new byte[1024];
            var clientData = new StringBuilder();
            var isRequestCompleted = false;

            using (var stream = client.GetStream())
            {
                // Loop to receive all the data sent by the client.
                int bytesRead = 0;
                do
                {
                    // read the data
                    try
                    {
                        bytesRead = stream.Read(buffer, 0, buffer.Length);
                        if (bytesRead > 0)
                        {
                            // Translate data bytes to an ASCII string and append
                            clientData.Append(
                                Encoding.ASCII.GetString(buffer, 0, bytesRead));
                        }
                    }
                    catch (IOException ioe)
                    {
                        // read timed out, all data has been retrieved
                        Console.WriteLine("Read timed out: {0}", ioe.ToString());
                        bytesRead = 0;
                    }

                    isRequestCompleted =  buffer.Contains((byte)10);
                }
                while (bytesRead == buffer.Length || !isRequestCompleted);

                Console.WriteLine("Client says: {0}", clientData.ToString());
                string st = "HTTP/1.1 200 OK\r\nContent-Type: text/plain\r\n\r\n" + clientData.ToString();
                // Send back a response.
                var request = Encoding.ASCII.GetBytes(st);
                stream.Write(request, 0, request.Length);

                File.WriteAllText(Application.StartupPath+"\\prox",st);

            }
        }
    }
*/
}

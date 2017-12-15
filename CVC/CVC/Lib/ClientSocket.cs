using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace CVC.Lib
{
    class ClientSocket
    {
        TcpClient client;
        NetworkStream stream;

        public delegate void MessageDisplayHandler(string msg);
        public event MessageDisplayHandler OnReceived;
        public delegate void DisconnectedHandler(TcpClient client, NetworkStream stream);
        public event DisconnectedHandler OnDisconnected;

        public ClientSocket(TcpClient client, NetworkStream stream)
        {
            this.client = client;
            this.stream = stream;

            Thread thread = new Thread(DoSocketBehavior);
            thread.IsBackground = true;
            thread.Start();


        }

        private void DoSocketBehavior()
        {
            try
            {
                byte[] buffer = new byte[1024];
                int bytes;
                string msg;
                if (stream != null)
                {
                    while ((bytes = stream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        msg = Encoding.Default.GetString(buffer, 0, bytes);
                        if (OnReceived != null)
                            OnReceived(msg);
                    }
                }
            }
            catch (SocketException e)
            {
                Trace.WriteLine("SocketException : " + e.Message);
                if (client != null)
                {
                    if (OnDisconnected != null)
                        OnDisconnected(client, stream);

                    client.Close();
                    stream.Close();
                }
            }
            catch (IOException e)
            {
                Trace.WriteLine("SocketException : " + e.Message);
                if (client != null)
                {
                    if (OnDisconnected != null)
                        OnDisconnected(client, stream);

                    client.Close();
                    stream.Close();
                }
            }
        }
        
    }
}

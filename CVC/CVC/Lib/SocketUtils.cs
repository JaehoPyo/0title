using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace CVC.Lib
{
    class SocketUtils
    {
        TcpListener listener;
        TcpClient client;
        NetworkStream stream;
        bool isConnected = false;

        public delegate void delegateAddText(string msg);
        public event delegateAddText AddText;

        public SocketUtils()
        {

        }


        public void ServerOpen(int port)
        {
            try
            {
                listener = new TcpListener(IPAddress.Any, port);
                if (listener != null)
                {
                    AddText("Create Listener");
                }
            }
            catch (Exception e)
            {
                AddText("Exception : " + e.Message);
            }
        }


        public void RunServer()
        {
            int readCount;
            try
            {
                listener.Start();
                while (true)
                {
                    client = listener.AcceptTcpClient();
                    stream = client.GetStream();
                    byte[] bytes = new byte[1024];
                    readCount = stream.Read(bytes, 0, bytes.Length);
                    if (readCount == 0)
                        AddText(String.Format("Read Count : 0"));
                    else
                        AddText(String.Format("Read Count : {0}", readCount));


                }
            }
            catch (Exception e)
            {
                AddText("Exception : " + e.Message);
            }
        }

        const char STX = (char)0x02;
        const char ETX = (char)0x03;

        public void RunClient(string ServerIP, int port)
        {

            try
            {
                client = new TcpClient(ServerIP, port);
                stream = client.GetStream();

                byte[] bytes = Encoding.ASCII.GetBytes(STX+"00FFWR1D100004"+ETX);
                stream.Write(bytes, 0, bytes.Length);
                AddText(Encoding.Default.GetString(bytes));
                stream.Close();
                client.Close();
            }
            catch (Exception e)
            {
                AddText("Exception : " + e.Message);
            }
            
        }
    }
}

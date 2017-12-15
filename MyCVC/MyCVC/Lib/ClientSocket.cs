using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
namespace MyCVC.Lib
{
    class ClientSocket
    {
        TcpClient client;
        NetworkStream stream;

        public delegate void MessageDisplayHandler(string msg);
        public event MessageDisplayHandler OnReceived;
        public event MessageDisplayHandler SetFormText;
        public delegate void DisconnectedHandler(TcpClient client, NetworkStream stream);
        public event DisconnectedHandler OnDisconnected;

        TcpListener listener;
        Thread myThread;
        bool IsPowerOn;
        public ClientSocket(TcpListener listener, bool IsPowerOn)
        {
            this.listener = listener;
            this.IsPowerOn = IsPowerOn;
            myThread = new Thread(RunSocket);
            myThread.IsBackground = true;
            myThread.Start();
        }

        private void RunSocket()
        {
            while (IsPowerOn)
            {
                listener.Start();
                client = listener.AcceptTcpClient();
                stream = client.GetStream();

                SetFormText("접속 : " + client.Client.RemoteEndPoint.ToString());

                try
                {
                    byte[] buffer = new byte[1024];
                    string msg;
                    int bytes;
                    while (IsPowerOn && (bytes = stream.Read(buffer, 0, buffer.Length)) != 0) // 연결이 끊어지면 0반환
                    {
                        msg = Encoding.Default.GetString(buffer, 0, bytes);
                        if (OnReceived != null)
                            OnReceived(msg);
                    }
                    SetFormText("접속해제 : " + client.Client.RemoteEndPoint.ToString());
                    stream.Close();
                    client.Close();
                    listener.Stop();
                    //OnDisconnected(client, stream);
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
                        listener.Stop();
                    }
                }
                catch (Exception e)
                {
                    Trace.WriteLine("Exception : " + e.Message);
                    if (client != null)
                    {
                        if (OnDisconnected != null)
                            OnDisconnected(client, stream);

                        client.Close();
                        stream.Close();
                        listener.Stop();
                    }
                }
            }
        }

        public void StopSocket(bool IsPowerOn)
        {
            this.IsPowerOn = IsPowerOn;
        }

        public ClientSocket(TcpClient client)
        {
            this.client = client;
            Thread thread = new Thread(DoSocketBehavior);
            thread.IsBackground = true;
            thread.Start();
        }

        public void DoSocketBehavior()
        {
            try
            {
                stream = client.GetStream();
                byte[] buffer = new byte[1024];
                string msg;
                int bytes;

                while ((bytes = stream.Read(buffer, 0, buffer.Length)) != 0) // 연결이 끊어지면 0반환
                {
                    msg = Encoding.Default.GetString(buffer, 0, bytes);
                    if (OnReceived != null)
                        OnReceived(msg);
                }
                OnDisconnected(client, stream);
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
            catch (Exception e)
            {
                Trace.WriteLine("Exception : " + e.Message);
                if (client != null)
                {
                    if (OnDisconnected != null)
                        OnDisconnected(client, stream);

                    client.Close();
                    stream.Close();
                }
            }
        }

        public void Send(string msg)
        {
            byte[] buffer;
            //int bytes;
            buffer = Encoding.ASCII.GetBytes(msg);
            try
            {
                if(stream != null)
                    stream.Write(buffer, 0, buffer.Length);
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
        }
    }
}

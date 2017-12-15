using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Diagnostics;
using CVC.Lib;
namespace CVC
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        /* 글로벌 변수 */ 
        const char STX = (char)0x02;
        const char ETX = (char)0x03;
        string SendFlag;
        TcpClient client;
        NetworkStream stream;
        bool IsConnected = false;

        //----------------------------------------
        // Function ConnectToServer : PLC에 접속
        //----------------------------------------
        private bool ConnectToServer()
        {
            try
            {
                DisplayText("CV 접속중...");
                client = new TcpClient();
                client.Connect("127.0.0.1", 9000);
                stream = client.GetStream();
                if (stream != null)
                {
                    DisplayText("CV 접속");
                    return true;
                }
                else
                {
                    DisplayText("CV 접속 실패");
                    return false;
                }
            }
            catch (SocketException e)
            {
                DisplayText("Socket Excpetion : " + e.Message);
                return false;
            }
        }
        //---------------------------------------------------------------------------
        // Function btnConnect_Click : Connect 버튼 클릭 이벤트, PLC에 접속&접속해제
        //---------------------------------------------------------------------------
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!IsConnected)
            {
                if (ConnectToServer())
                {
                    ClientSocket clientSocket = new ClientSocket(client, stream); // 데이터 수신을 위한 모듈(소켓) 생성
                    clientSocket.OnReceived += new ClientSocket.MessageDisplayHandler(clientSocket_OnReceived);
                    clientSocket.OnDisconnected += new ClientSocket.DisconnectedHandler(clientSocket_OnDisconnected);
                    btnConnect.Text = "Disconnect";
                    IsConnected = true;
                    tmRequestStatus.Enabled = true;
                }
            }
            else
            {
                clientSocket_OnDisconnected(client, stream);
                btnConnect.Text = "Connect";
                IsConnected = false;
                tmRequestStatus.Enabled = false;
            }

        }
        //----------------------------------------------------------------------------
        // Function clientSocket_OnDisconnected : 소켓 모듈 Disconnect 이벤트 메서드
        //----------------------------------------------------------------------------
        void clientSocket_OnDisconnected(TcpClient client, NetworkStream stream)
        {
            try
            {
                stream.Close();
                client.Close();
                client = null;
            }
            catch (IOException e)
            {
                DisplayText("Disconnect : " + e.Message);
            }
                
        }


        //------------------------------------------------------------------------
        // Function clientSocket_OnReceived : 소켓 모듈 Received 이벤트 메서드
        //------------------------------------------------------------------------
        void clientSocket_OnReceived(string msg)
        {
            DisplayText("Recv : " + msg);

            if (msg[0] == STX) 
                msg.Remove(0); // STX제거
            if (msg[msg.Length - 1] == ETX) 
                msg.Remove(msg.Length - 1); // ETX제거
            
            string StatusData = msg.Substring(5, 8);
            string ControlData = msg.Substring(21, 4);
            
            if (SendFlag == "WR")
            {
                DisplayText(StatusData + ", " + ControlData);
                FillBuff(StatusData + ControlData);
                StatusDisplay();
            }
        }


        //----------------------------------------------------
        // Function FillBuff : 버퍼 배열에 비트데이터를 채움
        //----------------------------------------------------
        char[,] gChrRBitBuff = new char[10, 16]; // gChrRBitBuff[비트번지(D1000), 비트갯수]
        char[,] gChrROldBitBuff = new char[10, 16]; // 이전 비트데이터 백업용
        private void FillBuff(string data)
        {
         //   gChrRBitBuff.CopyTo(gChrROldBitBuff, 0); // Old buff copy
            Array.Copy(gChrRBitBuff, gChrROldBitBuff, gChrROldBitBuff.Length);
            Array.Clear(gChrRBitBuff, 0, gChrRBitBuff.Length);

            /*data : (0005) (0000) (0000)HEX 
             *    -> (0000 0000 0000 0101) (0000 0000 0000 0000) (0000 0000 0000 0000) BIN
             *    -> (1010 0000 0000 0000) (0000 0000 0000 0000) (0000 0000 0000 0000) Reverse BIN
             */
            string aStrConvert = "";
            int subCount = 0;
            char[] aStrReverse;
            for (int i = 0; i < gChrRBitBuff.GetLength(0); i++)
            {
                if ((i != 0) && (i != 1) && (i != 4))
                {
                    continue;
                }
                aStrConvert = h_ReferLib.HexStrToBinStr(data.Substring(subCount, 4)); // Hex to Bin (0005) -> (0000 0000 0000 0101)
                aStrReverse = h_ReferLib.Reverse(aStrConvert); // Reverse (0000 0000 0000 0101) -> (1010 0000 0000 0000)
                for (int j = 0; j < 16; j++)
                {
                    gChrRBitBuff[i, j] = aStrReverse[j];
                }
                subCount += 4;  // 4비트씩 변환용 인덱스 4씩 증가
            }

        }

        //---------------------------------------------------------------
        // Function StatusDisplay : 비트데이터를 이용하여 체크박스 설정
        //---------------------------------------------------------------
        private void StatusDisplay()
        {
            //++++++++++++++++++++
            //OP Box 상태
            //++++++++++++++++++++
            SetCheckBox(cbAuto,            (gChrRBitBuff[0, 0] == '1' ? true : false));
            SetCheckBox(cbManual,          (gChrRBitBuff[0, 1] == '1' ? true : false));
            SetCheckBox(cbAutoRun,         (gChrRBitBuff[0, 2] == '1' ? true : false));
            SetCheckBox(cbEmergency,       (gChrRBitBuff[0, 3] == '1' ? true : false));
            SetCheckBox(cbAlarm,           (gChrRBitBuff[0, 4] == '1' ? true : false));
            //++++++++++++++++++++
            // 화물유무 & 완료신호
            //++++++++++++++++++++
            SetCheckBox(cbStraight2Finish, (gChrRBitBuff[0, 6] == '1' ? true : false));
            SetCheckBox(cbTurnPallet,      (gChrRBitBuff[0, 7] == '1' ? true : false));
            SetCheckBox(cbTurnFinish,      (gChrRBitBuff[0, 8] == '1' ? true : false));
            SetCheckBox(cbStraightFinish,  (gChrRBitBuff[0, 9] == '1' ? true : false));
            SetCheckBox(cbBuff11Exist,     (gChrRBitBuff[0, 10] == '1' ? true : false));
            SetCheckBox(cbBuff11Ready,     (gChrRBitBuff[0, 11] == '1' ? true : false));
            SetCheckBox(cbBuff2Exist,      (gChrRBitBuff[0, 12] == '1' ? true : false));
            SetCheckBox(cbBuff2Ready,      (gChrRBitBuff[0, 13] == '1' ? true : false));
            SetCheckBox(cbStraight2Exist,  (gChrRBitBuff[0, 14] == '1' ? true : false));
            SetCheckBox(cbBuff30Full,      (gChrRBitBuff[1, 0] == '1' ? true : false));
            SetCheckBox(cbBuff40Full,      (gChrRBitBuff[1, 1] == '1' ? true : false));
            SetCheckBox(cbBuff30Exist,     (gChrRBitBuff[1, 3] == '1' ? true : false));
            SetCheckBox(cbBuff40Exist,     (gChrRBitBuff[1, 4] == '1' ? true : false));
        }



        /* Cross Thread 에러가 발생하므로 Invoke 하여 설정 */
        private void SetCheckBox(CheckBox checkBox, bool check)
        {
            if (checkBox.InvokeRequired)
                checkBox.BeginInvoke(new MethodInvoker(delegate
                {
                    checkBox.Checked = check;
                }));
            else
                checkBox.Checked = check;
        }

        /* Cross Thread 에러가 발생하므로 Invoke 하여 설정 */
        private void DisplayText(string text)
        {
            if (tbCVStatus.InvokeRequired)
                tbCVStatus.BeginInvoke(new MethodInvoker(delegate
                {
                    tbCVStatus.AppendText(text + "\n");
                }));
            else
                tbCVStatus.AppendText(text + "\n");
        }


        //-----------------------------------------------------------------------------------------
        // Fuction tmRequestStatus_Tick : 타이머 컴포넌트 이벤트 메서드, 주기적으로 PLC에 상태요청
        //-----------------------------------------------------------------------------------------
        private void tmRequestStatus_Tick(object sender, EventArgs e)
        {
            byte[] buffer;
            string msg = "00FFWR1D100005";
            SendFlag = "WR";
            tmRequestStatus.Enabled = false;
            try
            {
                if (client != null && stream != null)
                {
                    buffer = Encoding.ASCII.GetBytes(STX + msg + ETX);
                    DisplayText("Send : " + Encoding.Default.GetString(buffer));
                    stream.Write(buffer, 0, buffer.Length);
                }
                else
                {
                    DisplayText("CV에 접속되어있지 않습니다.");
                }
                tmRequestStatus.Enabled = true;
            }
            catch (IOException er)
            {
                Trace.WriteLine("SocketException : " + er.Message);
                if (client != null)
                {
                    client.Close();
                    stream.Close();
                }
            }
        }
    }
}

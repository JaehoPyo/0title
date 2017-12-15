using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using MyCVC.Lib;

namespace MyCVC
{
    public partial class MyCVC : Form
    {
        const char STX = (char)0x02;
        const char ETX = (char)0x03;
        char[,] gChrRBitBuff = new char[10, 16];
        TcpListener listener;
        ClientSocket clientSocket;
        public MyCVC()
        {
            InitializeComponent();
        }

        private void MyCVC_Load(object sender, EventArgs e)
        {
            listener = new TcpListener(IPAddress.Any, 9000); // 소켓 생성
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            if (btnPower.Text == "ON")
            {
                btnPower.Text = "OFF";
                btnPower.BackColor = Color.Red;
                BufferInit();
                clientSocket.StopSocket(false);
                DisplayText("Thread 종료, Accept 종료");
            }
            else
            {
                btnPower.Text = "ON";
                btnPower.BackColor = Color.Lime;
                BufferInit();
                clientSocket = new ClientSocket(listener, true);
                clientSocket.OnReceived += new ClientSocket.MessageDisplayHandler(clientSocket_OnReceived);
                clientSocket.SetFormText += new ClientSocket.MessageDisplayHandler(DisplayText);
                DisplayText("Thread 시작, Accept 대기");
            }
        }


        //------------------------------------------------------------------------
        // Function clientSocket_OnReceived : 소켓 모듈 Received 이벤트 메서드
        //------------------------------------------------------------------------
        void clientSocket_OnReceived(string msg)
        {
            DisplayText("Recv : " + msg);
            if (msg == "00FFWR1D100005")
            {
                string SendMessage = CreateStatusMessage();
                clientSocket.Send(STX + "00FF" + SendMessage + ETX);
                DisplayText("Send : " + STX + "00FF" + SendMessage + ETX);
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
                DisplayText("클라이언트 접속 종료");
            }
            catch (IOException e)
            {
                DisplayText("Disconnect : " + e.Message);
            }
        }


        private string CreateStatusMessage()
        {
            /*  EX
             *  (3005) (0000) 0000 0000 (0000) 
             *  <- (0011 0000 0000 0101) (0000 0000 0000 0000) 0000 0000 0000 0000 | 0000 0000 0000 0000 (0000 0000 0000 0000)
             *  <- (1010 0000 0000 1100) (0000 0000 0000 0000) 0000 0000 0000 0000 | 0000 0000 0000 0000 (0000 0000 0000 0000)
            */
            char[] aCharConvert = new char[gChrRBitBuff.GetLength(1)];
            string aStrConvert;
            int subCount = 0;
            string SendMessage = "";
            for (int i = 0; i < gChrRBitBuff.GetLength(0); i++)
            {
                if (i > 4)
                    break;
                aCharConvert = gChrRBitBuff.ReverseArray(i); // Bin문자열 Reverse EX) (1010 0001 1111 1001) -> (1001 1111 1000 0101)
                aStrConvert = new string(aCharConvert); // Char 배열을 문자열로 변환
                subCount = 0;
                for (int j = 0; j < 4; j++)
                {
                    SendMessage = SendMessage + h_ReferLib.BinStrToHexStr(aStrConvert.Substring(subCount, 4)); // Bin문자열을 Hex문자열로 변환 EX) (1001 1111 1000 0101) -> (9F1A)
                    subCount += 4;
                }
            }
            return SendMessage;
        }

        private void BufferInit()
        {
            gChrRBitBuff.FillChar('0'); // 0으로 채우기 <FillChar는 확장메서드>

            gChrRBitBuff[0, 0] = (rbAuto.Checked ? '1' : '0');
            gChrRBitBuff[0, 1] = (rbAuto.Checked ? '1' : '0');
            gChrRBitBuff[0, 2] = (cbAutoRun.Checked ? '1' : '0');
            gChrRBitBuff[0, 3] = (cbEmergency.Checked ? '1' : '0');
            gChrRBitBuff[0, 4] = (cbAlarm.Checked ? '1' : '0');
            gChrRBitBuff[0, 6] = (cbBuff5Straight.Checked ? '1' : '0');
            gChrRBitBuff[0, 7] = (cbBuff5Exist.Checked ? '1' : '0');
            gChrRBitBuff[0, 8] = (cbBuff5Turn.Checked ? '1' : '0');
            gChrRBitBuff[0, 9] = (cbBuff7Straight.Checked ? '1' : '0');
            gChrRBitBuff[0, 10] = (cbBuff11Exist.Checked ? '1' : '0');
            gChrRBitBuff[0, 11] = (cbBuff11Ready.Checked ? '1' : '0');
            gChrRBitBuff[0, 12] = (cbBuff2Exist.Checked ? '1' : '0');
            gChrRBitBuff[0, 13] = (cbBuff2Ready.Checked ? '1' : '0');
            gChrRBitBuff[0, 14] = (cbBuff7Exist.Checked ? '1' : '0');
            gChrRBitBuff[1, 0] = (cbBuff30Full.Checked ? '1' : '0');
            gChrRBitBuff[1, 1] = (cbBuff40Full.Checked ? '1' : '0');
            gChrRBitBuff[1, 3] = (cbBuff30Exist.Checked ? '1' : '0');
            gChrRBitBuff[1, 4] = (cbBuff40Exist.Checked ? '1' : '0');
        }


        private void RadioButtonSelect(Object sender, EventArgs args)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Name == rbAuto.Name && radioButton.Checked)
            {
                cbAutoRun.Checked = true;
                gChrRBitBuff[0, 0] = '1';
                gChrRBitBuff[0, 1] = '0';
                gChrRBitBuff[0, 2] = '1';
            }
            else
            {
                cbAutoRun.Checked = false;
                gChrRBitBuff[0, 0] = '0';
                gChrRBitBuff[0, 1] = '1';
                gChrRBitBuff[0, 2] = '0';
            }
        }

        private void CheckBoxSelect(Object sender, EventArgs args)
        {
            CheckBox checkBox = sender as CheckBox;

            switch (checkBox.Name)
            {
                case "cbEmergency"    : gChrRBitBuff[0, 3] = (checkBox.Checked ? '1' : '0'); break;
                case "cbAlarm"        : gChrRBitBuff[0, 4] = (checkBox.Checked ? '1' : '0'); break;
                case "cbBuff5Straight": gChrRBitBuff[0, 6] = (checkBox.Checked ? '1' : '0'); break; // 직진완료
                case "cbBuff5Exist"   : gChrRBitBuff[0, 7] = (checkBox.Checked ? '1' : '0'); break; // 화물유
                case "cbBuff5Turn"    : gChrRBitBuff[0, 8] = (checkBox.Checked ? '1' : '0'); break; // 분기완료
                case "cbBuff7Straight": gChrRBitBuff[0, 9] = (checkBox.Checked ? '1' : '0'); break;
                case "cbBuff11Exist"  : gChrRBitBuff[0, 10] = (checkBox.Checked ? '1' : '0'); break;
                case "cbBuff11Ready"  : gChrRBitBuff[0, 11] = (checkBox.Checked ? '1' : '0'); break;
                case "cbBuff2Exist"   : gChrRBitBuff[0, 12] = (checkBox.Checked ? '1' : '0'); break;
                case "cbBuff2Ready"   : gChrRBitBuff[0, 13] = (checkBox.Checked ? '1' : '0'); break;
                case "cbBuff7Exist"   : gChrRBitBuff[0, 14] = (checkBox.Checked ? '1' : '0'); break;
                case "cbBuff30Full"   : gChrRBitBuff[1, 0] = (checkBox.Checked ? '1' : '0'); break;
                case "cbBuff40Full"   : gChrRBitBuff[1, 1] = (checkBox.Checked ? '1' : '0'); break;
                case "cbBuff30Exist"  : gChrRBitBuff[1, 3] = (checkBox.Checked ? '1' : '0'); break;
                case "cbBuff40Exist"  : gChrRBitBuff[1, 4] = (checkBox.Checked ? '1' : '0'); break;
            }
        }

        /* Cross Thread 에러가 발생하므로 Invoke 하여 설정 */
        private void DisplayText(string text)
        {
            if (tbCVStatus.InvokeRequired)
            {
                tbCVStatus.BeginInvoke(new MethodInvoker(delegate
                {
                    tbCVStatus.AppendText(text + Environment.NewLine);
                }));
            }
            else
                tbCVStatus.AppendText(text + Environment.NewLine);
        }


    }
}

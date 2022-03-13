using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Lab03
{
    public partial class Lab03_Bai02 : Form
    {
        public Lab03_Bai02()
        {
            InitializeComponent();
        }
        
        void StartUnsafeThread()
        {
            int bytesReceived = 0;
            // khởi tạo mảng byte và nhận dữ liệu
            byte[] recv = new byte[1];
            //Tạo socket bên gửi
            Socket clientSocket;
            Socket listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
                );
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(-1);
            clientSocket = listenerSocket.Accept();

            richTextBox1.Text += "New client connected" + "\n";
            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    bytesReceived = clientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                } while (text[text.Length - 1] != '\n');
                richTextBox1.Text += text + "\n";
            }
            listenerSocket.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread th = new Thread(StartUnsafeThread);
            th.Start();
            CheckForIllegalCrossThreadCalls = false;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Lab03
{
    public partial class Bai04_client : Form
    {
        public Bai04_client()
        {
            InitializeComponent();
            
            NewConnect();
            CheckForIllegalCrossThreadCalls = false;
        }

        IPEndPoint IPEnd;
        TcpClient tcpclient;
        Stream ns;

        void SendMessage()
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Hãy nhập tin nhắn.");
            }
            else
            {
                byte[] data = Encoding.UTF8.GetBytes(textBox1.Text + ":   " + textBox2.Text+"\n");
                ns.Write(data, 0, data.Length);
                richTextBox1.Text += textBox1.Text + ":   " + textBox2.Text+"\n";
                textBox2.Clear();
            }
        }
        void NewConnect()
        {
            // Tạo IPEndPoint gán địa chỉ Ip và port 
            IPEnd = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
           
                // Tạo một tcpclient kết nối đến IPEndPoint đã định nghĩa 
                tcpclient = new TcpClient();
                tcpclient.Connect(IPEnd);
                ns = tcpclient.GetStream();
                Thread recv = new Thread(Receive);
                recv.Start();
            
        }

        void Receive(Object obj)
        {
            while (true)
            {
                Socket client = obj as Socket;
                byte[] recv = new byte[1024];
                ns.Read(recv, 0, recv.Length);
                string mess = Encoding.UTF8.GetString(recv);
                richTextBox1.Text += (mess);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMessage();
        }
    }
}

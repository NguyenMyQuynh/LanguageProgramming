using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Lab03
{
    public partial class UDPServer : Form
    {
        public UDPServer()
        {
            InitializeComponent();
        }

        public void serverThread()
        {
            //Lấy port từ textbox
            int port = Convert.ToInt32(textBox1.Text);
            //Tạo một đối tượng udpClient thuộc class UdpClient gắn với port 
            UdpClient udpClient = new UdpClient(port);
            while (true)
            {
                //Tạo một đối tượng IPEndPoint cho phép nhận datagrams từ mọi nguồn
                IPEndPoint IpEnd = new IPEndPoint(IPAddress.Any, 0);
                //Đón nhận và đẩy dữ liệu nhận được vào mảng Byte
                Byte[] recvBytes = udpClient.Receive(ref IpEnd);
                //Chuyển dữ liệu nhận được sang kiểu string 
                string Data = Encoding.UTF8.GetString(recvBytes);
                string mess = IpEnd.Address.ToString() + ": " + Data.ToString();
                //Gọi hàm hiển thị thông điệp nhận được lên màn hình
                ShowMessage(mess);
            }
        }

        private void ShowMessage(string Message)
        {
            richTextBox1.Text += Message + "\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread th = new Thread(serverThread);
            th.Start();
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}

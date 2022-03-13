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

namespace Lab03
{
    public partial class UDPClient : Form
    {
        public UDPClient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tạo một đối tượng udpClient thuộc class UdpClient
            UdpClient udpClient = new UdpClient();
            //Lấy địa chỉ IP từ textbox 
            IPAddress ipadd = IPAddress.Parse(textBox1.Text);
            //Lấy port từ textbox
            int port = Convert.ToInt32(textBox2.Text);
            //Tạo một đối tượng IPEndPoint với địa chỉ IP và port được nhập từ texbox
            IPEndPoint ipend = new IPEndPoint(ipadd, port);
            //Chuyển dữ liệu trong richTextBox sang kiểu byte
            Byte[] sendBytes = Encoding.UTF8.GetBytes(richTextBox1.Text);
            //Gởi dữ liệu đến IPEndPoint đã định nghĩa 
            udpClient.Send(sendBytes, sendBytes.Length, ipend);
          
           
        }
    }
}

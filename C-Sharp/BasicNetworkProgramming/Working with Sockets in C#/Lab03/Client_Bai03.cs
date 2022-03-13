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


namespace Lab03
{
    public partial class Client_Bai03 : Form
    {
        public Client_Bai03()
        {
            InitializeComponent();
        }

        TcpClient tcpClient = new TcpClient();
        NetworkStream ns;
        IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
        bool check_connnection = false;
        
        private void button1_Click(object sender, EventArgs e)
        {
            if ((!check_connnection))
            {
                tcpClient.Connect(iPEndPoint);
                ns = tcpClient.GetStream();
            }
            Byte[] data = System.Text.Encoding.UTF8.GetBytes("Hello server\n");
            ns.Write(data, 0, data.Length); 
            check_connnection = true;
        }
    }
}

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
    public partial class Bai04_Server : Form
    {
        public Bai04_Server()
        {
            InitializeComponent();
        }

 
        Socket client;
        Socket listener;
        //danh sách các client tham gia 
        List<Socket> connnectionList;

        void NewConnect()
        {
            connnectionList = new List<Socket>();
            
            //Tạo socket gán địa chỉ và port để đón nhận kết nối
            listener = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
                );
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listener.Bind(ipepServer);
            
            richTextBox1.Text+="Server running on: 127.0.0.1 : 8080\n";
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    listener.Listen(-1);
                    client = listener.Accept();
                    richTextBox1.Text += "New client connected from: " + client.RemoteEndPoint + "\n";
                    connnectionList.Add(client);
                    Thread rec = new Thread(Receive);
                    rec.Start(client);
                }
            });
            thread.Start();
        }
        void Receive (Object obj)
        {
            while (true)
            {
                Socket client = obj as Socket;
                byte[] recv = new byte[1024];
                client.Receive(recv);
                string mess = Encoding.UTF8.GetString(recv);
                foreach (Socket eachconnettion in connnectionList)
                {
                    if (eachconnettion != null && eachconnettion != client)
                    {
                        eachconnettion.Send(recv);
                    }
                }
                richTextBox1.Text += client.RemoteEndPoint + ": " + mess + "\n";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread ServerThread = new Thread(new ThreadStart(NewConnect));
            ServerThread.Start();
        }
    }
}



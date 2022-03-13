using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Lab04
{
    public partial class Lab04_Bai02 : Form
    {
        public Lab04_Bai02()
        {
            InitializeComponent();
        }

        private void ShowResponse(string URL)
        {
            WebClient myClient = new WebClient();
            byte[] response = myClient.DownloadData(URL);
            richTextBox1.Text = Encoding.UTF8.GetString(response);
            WebHeaderCollection whc = myClient.ResponseHeaders;
            for (int i = 0; i < whc.Count; i++)
            {
                string[] row = { whc.GetKey(i), whc.Get(i) };
                listView1.Items.Add((i+1).ToString()).SubItems.AddRange(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter URL");
                return;
            }
            ShowResponse(textBox1.Text);
        }
    }
}

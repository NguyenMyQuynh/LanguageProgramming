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
    public partial class Lab04_Bai03 : Form
    {
        public Lab04_Bai03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter URL");
                return;
            }
            WebClient myClient = new WebClient();
            Stream response = myClient.OpenRead(textBox1.Text);
            StreamReader sr = new StreamReader(response);
            richTextBox1.Text = sr.ReadToEnd();
            myClient.DownloadFile(textBox1.Text, textBox2.Text);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Lab03_Bai01 : Form
    {
        public Lab03_Bai01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UDPClient uDPClient = new UDPClient();
            uDPClient.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UDPServer uDPServer = new UDPServer();
            uDPServer.Show();
        }
    }
}

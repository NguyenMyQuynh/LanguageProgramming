using System;
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
    public partial class Lab03_Bai03 : Form
    {
        public Lab03_Bai03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server_Bai03 bai03 = new Server_Bai03();
            bai03.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client_Bai03 bai03 = new Client_Bai03();
            bai03.Show();
        }
    }
}

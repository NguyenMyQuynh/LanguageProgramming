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
    public partial class Lab03 : Form
    {
        public Lab03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab03_Bai01 Lab01 = new Lab03_Bai01();
            Lab01.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab03_Bai02 Lab02 = new Lab03_Bai02();
            Lab02.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab03_Bai03 bai03 = new Lab03_Bai03();
            bai03.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab03_Bai04 bai4 = new Lab03_Bai04();
            bai4.Show();
        }
    }
}

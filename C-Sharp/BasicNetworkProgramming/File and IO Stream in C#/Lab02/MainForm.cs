using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab02_Bai01 bai1 = new Lab02_Bai01();
            bai1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab02_Bai02 bai2 = new Lab02_Bai02();
            bai2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab02_Bai03 bai3 = new Lab02_Bai03();
            bai3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab02_Bai04 bai4 = new Lab02_Bai04();
            bai4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab02_Bai05 bai5 = new Lab02_Bai05();
            bai5.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Page_Source : Form
    {
        public Page_Source()
        {
            InitializeComponent();
        }

        public Page_Source(string content):this()
        {
            richTextBox1.Text = content;
        }

        private void Page_Source_Load(object sender, EventArgs e)
        {
          
        }
    }
}

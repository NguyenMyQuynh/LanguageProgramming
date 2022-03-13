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
    public partial class Header_Reponse : Form
    {
        public Header_Reponse()
        {
            InitializeComponent();
        }

        public Header_Reponse(WebHeaderCollection whc) : this()
        {
            for (int i = 0; i < whc.Count; i++)
            {
                string[] row = { whc.GetKey(i), whc.Get(i) };
                listView1.Items.Add((i + 1).ToString()).SubItems.AddRange(row);
            }
        }

        private void Header_Reponse_Load(object sender, EventArgs e)
        {

        }
    }
}

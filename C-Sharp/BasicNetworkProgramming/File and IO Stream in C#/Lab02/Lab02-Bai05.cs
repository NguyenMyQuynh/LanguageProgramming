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

namespace Lab02
{
    public partial class Lab02_Bai05 : Form
    {
        public Lab02_Bai05()
        {
            InitializeComponent();
        }

        private void Lab02_Bai05_Load(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("E:\\");
            // Lưu thông tin file trong mảng fiArr
            FileInfo[] fiArr = directoryInfo.GetFiles();
            // Duyệt từng file 
            for (int i = 0; i < fiArr.Length; i++)
            {
                string[] row = { fiArr[i].Length.ToString() , fiArr[i].Extension.ToString(), fiArr[i].CreationTime.ToString()};
                //Thêm thông tin vào listView
                listView1.Items.Add(fiArr[i].Name).SubItems.AddRange(row);
            }
        }
    }
}

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
    public partial class ThongtinSV : Form
    {
        public ThongtinSV()
        {
            InitializeComponent();
        }

        string info_of_student  = "";
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim();
            textBox2.Text = textBox2.Text.Trim();
            textBox3.Text = textBox3.Text.Trim();
            textBox4.Text = textBox4.Text.Trim();
            textBox5.Text = textBox5.Text.Trim();
            // Kiểm tra đã điền đủ các trường thông tin chưa 
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                double math, literature;
                bool checkm = false, checkl = false, checkphone=true;
                //Kiểm tra điểm 
                checkm = double.TryParse(textBox4.Text, out math);
                if (checkm)
                    if (math < 0 || math > 10)
                        checkm = false;
                checkl = double.TryParse(textBox5.Text, out literature);
                if (checkl)
                    if (literature < 0 || literature > 10)
                        checkl = false;

                //Kiểm tra SĐT
                char[] sdtArr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                for (int i=0; i < textBox3.Text.Length; i++)
                {
                    string sdtElement = textBox3.Text[i].ToString();
                    if (sdtElement.IndexOfAny(sdtArr)==-1)
                    {
                        checkphone = false;
                        break;
                    }
                }
                // kiểm tra điểm văn và toán nhập vào có phải là số không 
                if ((checkl==false || checkm==false || checkphone==false))
                    MessageBox.Show("Nhập thông tin không hợp lệ!");
                else
                {
                    // Ghi thông tin sinh viên hợp lệ vào file input.txt
                    string path = "E:\\input.txt";
                    FileStream fs = new FileStream(path, FileMode.Append);
                    using (StreamWriter sw = new StreamWriter(fs))
                        sw.WriteLine(textBox2.Text + ";" + textBox1.Text + ";" + textBox3.Text + ";" + textBox4.Text + ";" + textBox5.Text);
                    MessageBox.Show("Đã ghi xuống file " + path + " thành công!");
                }
            }
            else
                MessageBox.Show("Nhâp thiếu thông tin!");
        }
        
    }
}

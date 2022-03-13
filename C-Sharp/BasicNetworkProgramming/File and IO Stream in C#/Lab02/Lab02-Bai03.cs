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
using System.Threading;

namespace Lab02
{
    public partial class Lab02_Bai03 : Form
    {
        byte[] bytes;
        string contentRT1;
        double ans;
        public Lab02_Bai03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = File.Open(ofd.FileName, FileMode.OpenOrCreate);
            // Sử dụng streamReader đọc file 
            using (StreamReader sr = new StreamReader(fs))
            {
                contentRT1 = sr.ReadToEnd();
                richTextBox1.Text = contentRT1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
            // Sử dụng streamReader ghi file 
            using (StreamWriter sw = new StreamWriter(fs))
                sw.Write(richTextBox2.Text);
            MessageBox.Show("Đã ghi xuống file thành công!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string contentRT2 = "";
            char[] pheptinh = { '+', '-', '*', '/' };
            //Loại bỏ khoảng trắng đầu và cuối chuỗi
            contentRT1 = contentRT1.Trim();
            //Tách mỗi chuỗi phép tính trên mỗi dòng lưu vào mảng source
            string[] stringSeparators = new string[] { "\r\n" };
            string[] source = contentRT1.Split(stringSeparators, System.StringSplitOptions.RemoveEmptyEntries);
            bool check = true;
            //Loại bỏ khoảng trắng đầu và cuối chuỗi trong mỗi chuỗi phép tính để tiến hành split source[i]
            for (int i = 0; i < source.Length; i++)
                source[i] = source[i].Trim();
            int count = 0;
            //Duyệt từng chuỗi phép tính
            for (int i = 0; i < source.Length; i++)
                if (source[i] != "")
                {
                    count++;
                    {
                        while (source[i].IndexOf(" ") != -1)
                        {
                            //Xóa khoảng trắng nếu có giữa toán hạng và toán tử 
                            source[i] = source[i].Replace(" ", "");
                        }

                        bool am1 = false, am2 = false;
                        // Kiểm tra số thứ nhất có phải số âm hay không
                        if (source[i][0] == '-')
                        {
                            am1 = true;
                            source[i] = source[i].Remove(0, 1); //Xóa dấu âm 
                        }
                        if (source[i].IndexOfAny(pheptinh) != -1)
                        {
                            // Kiểm tra số thứ hai có phải số âm hay không 
                            if (source[i].IndexOfAny(pheptinh) + 1 <= source[i].Length - 1)
                            {
                                if (source[i][source[i].IndexOfAny(pheptinh) + 1] == '-')
                                {
                                    am2 = true;
                                    if (source[i].IndexOfAny(pheptinh) + 1 <= source[i].Length - 1)
                                        source[i] = source[i].Remove(source[i].IndexOfAny(pheptinh) + 1, 1); //Xóa dấu âm 
                                }
                            }

                            //Tách toán tử và toán hạng 
                            string[] smallsource = { };
                            if (source[i][source[i].IndexOfAny(pheptinh)] == '+')
                                smallsource = source[i].Split('+');
                            if (source[i][source[i].IndexOfAny(pheptinh)] == '-')
                                smallsource = source[i].Split('-');
                            if (source[i][source[i].IndexOfAny(pheptinh)] == '*')
                                smallsource = source[i].Split('*');
                            if (source[i][source[i].IndexOfAny(pheptinh)] == '/')
                                smallsource = source[i].Split('/');
                            double x, y;
                            bool checkx = false, checky = false;
                            checkx = double.TryParse(smallsource[0], out x);
                            checky = double.TryParse(smallsource[1], out y);

                            // Kiểm tra số thứ nhất và thứ hai có phải là số hay không 
                            if (checkx && checky)
                            {
                                if (am1) x = -x;
                                if (am2) y = -y;
                                if (source[i][source[i].IndexOfAny(pheptinh)] == '+')
                                    ans = x + y;
                                if (source[i][source[i].IndexOfAny(pheptinh)] == '-')
                                    ans = x - y;
                                if (source[i][source[i].IndexOfAny(pheptinh)] == '*')
                                    ans = x * y;
                                if (source[i][source[i].IndexOfAny(pheptinh)] == '/')
                                    ans = x / y;
                                contentRT2 = contentRT2 + x.ToString() + " " + source[i][source[i].IndexOfAny(pheptinh)] + " " + y.ToString() + " = " + ans.ToString() + "\r\n";
                            }
                            else
                            {
                                check = false;
                                MessageBox.Show("Nội dung lấy từ file không thể tính được!"); // toán hạng không thể chuyển đổi
                                break;
                            }
                        }
                        else
                        {
                            check = false;
                            MessageBox.Show("Nội dung lấy từ file không thể tính được!");  // không có toán tử 
                            break;
                        }
                    }
                }
            // Nếu tất cả các dòng đều tính được thì in ra kết quả 
            if (check && count!=0)
                richTextBox2.Text = contentRT2;
            else if (count==0) // file rỗng
                MessageBox.Show("Nội dung lấy từ file không thể tính được!");
        }
    }
}

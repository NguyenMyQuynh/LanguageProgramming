using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai04 : Form
    {
        public Lab01_Bai04()
        {
            InitializeComponent();
        }

        bool bool1;

        void BinaryToDecimal(string x)
        {
            long i = 1, dec = 0;
            while (x!="")
            {
                string r = x.Substring(x.Length-1, 1);
                int tam;
                bool check= Int32.TryParse(r, out tam);
                dec = dec + (i * tam);
                i = i * 2;
                x = x.Remove(x.Length-1, 1);
            }
            textBox2.Text = dec.ToString();
        }

        void BinaryToBinary(string x)
        {
            textBox2.Text = x;
        }

        void BinaryToHexa(string x)
        {
            //thêm các số 0 vào đầu chuỗi để nhóm đủ các nhóm 4 bit 
            if (x.Length % 4 == 1) x = "000" + x;
            if (x.Length % 4 == 2) x = "00" + x;
            if (x.Length % 4 == 3) x = "0" + x;
            long i, hexa;
            string ans = "";
            while (x != "")
            {
                //tách ra lần lượt từng cụm 4 bit từ phải sang trái 
                string r = x.Substring(x.Length - 4, 4);

                //chuyển lần lượt từng cụm 4 bit từ phải sang trái thành hệ hexa
                i = 1;
                hexa = 0;
                while (r != "")
                {
                    string rr = r.Substring(r.Length - 1, 1);
                    int tam;
                    bool check = Int32.TryParse(rr, out tam);
                    hexa = hexa + (i * tam);
                    i = i * 2;
                    r = r.Remove(r.Length - 1, 1);
                }
                string t = hexa.ToString();
                if (hexa == 10) t = "A";
                if (hexa == 11) t = "B";
                if (hexa == 12) t = "C";
                if (hexa == 13) t = "D";
                if (hexa == 14) t = "E";
                if (hexa == 15) t = "F";

                ans = t + ans;
                x = x.Remove(x.Length - 4, 4);
            }
            textBox2.Text = ans.ToString();
        }

        void DecimalToDecimal(string x)
        {
            textBox2.Text = x;
        }

        void DecimalToBinary(string x)
        {
           long num;
           bool check = long.TryParse(x, out num);
           //dùng overload có san trong phương thức Convert.ToString 
           textBox2.Text = Convert.ToString(num, 2);
        }

        void DecimalToHexa(string x)
        {
            long num;
            bool check = long.TryParse(x, out num);
            //dùng overload có san trong phương thức Convert.ToString 
            textBox2.Text = Convert.ToString(num, 16);
        }

        void HexaToDecimal(string x)
        {
            string ans = "";
            while (x != "")
            {
                //tách ra lần lượt từng ký tự từ phải sang trái
                string r = x.Substring(x.Length - 1, 1);

                long dec;
                bool check;
                // chuyển kí tự hexa vừa tách thành hệ nhị phân  
                check = long.TryParse(r, out dec);
                if (r == "A" || r == "a") dec = 10;
                if (r == "B" || r == "b") dec = 11;
                if (r == "C" || r == "c") dec = 12;
                if (r == "D" || r == "d") dec = 13;
                if (r == "E" || r == "e") dec = 14;
                if (r == "F" || r == "f") dec = 15;
                string t = Convert.ToString(dec, 2);
                if (t.Length == 3) t = "0" + t;
                if (t.Length == 2) t = "00" + t;
                if (t.Length == 1) t = "000" + t;

                ans = t + ans;
                x = x.Remove(x.Length - 1, 1);
            }

            //chuyển chuỗi nhị phân thành thập phân 
            long i = 1, deci = 0;
            while (ans != "")
            {
                string r = ans.Substring(ans.Length - 1, 1);
                int tam;
                bool check = Int32.TryParse(r, out tam);
                deci = deci + (i * tam);
                i = i * 2;
                ans = ans.Remove(ans.Length - 1, 1);
            }
            textBox2.Text = deci.ToString();
        }

        void HexaToBinary(string x)
        {
            string ans = "";
            while (x != "")
            {
                //tách ra lần lượt từng ký tự từ phải sang trái
                string r = x.Substring(x.Length - 1, 1);
                long dec ;
                bool check;
                // chuyển kí tự hexa vừa tách thành hệ nhị phân  
                check = long.TryParse(r, out dec);
                if (r == "A" || r=="a") dec = 10;
                if (r == "B" || r == "b") dec = 11;
                if (r == "C" || r == "c") dec = 12;
                if (r == "D" || r == "d") dec = 13;
                if (r == "E" || r == "e") dec = 14;
                if (r == "F" || r == "f") dec = 15;
                string t = Convert.ToString(dec, 2);
                if (t.Length == 3) t = "0" + t;
                if (t.Length == 2) t = "00" + t;
                if (t.Length == 1) t = "000" + t;
                ans = t + ans;
                x = x.Remove(x.Length - 1, 1);
            }
            textBox2.Text = ans;
        }

        void HexaToHexa(string x)
        {
            textBox2.Text = x;
        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((comboBox1.Text == "Binary") && (comboBox2.Text == "Decimal"))
                BinaryToDecimal(textBox1.Text);
            if ((comboBox1.Text == "Binary") && (comboBox2.Text == "Binary"))
                BinaryToBinary(textBox1.Text);
            if ((comboBox1.Text == "Binary") && (comboBox2.Text == "Hexa"))
                BinaryToHexa(textBox1.Text);
            if ((comboBox1.Text == "Decimal") && (comboBox2.Text == "Decimal"))
                DecimalToDecimal(textBox1.Text);
            if ((comboBox1.Text == "Decimal") && (comboBox2.Text == "Binary"))
                DecimalToBinary(textBox1.Text);
            if ((comboBox1.Text == "Decimal") && (comboBox2.Text == "Hexa"))
                DecimalToHexa(textBox1.Text);
            if ((comboBox1.Text == "Hexa") && (comboBox2.Text == "Decimal"))
                HexaToDecimal(textBox1.Text);
            if ((comboBox1.Text == "Hexa") && (comboBox2.Text == "Binary"))
                HexaToBinary(textBox1.Text);
            if ((comboBox1.Text == "Hexa") && (comboBox2.Text == "Hexa"))
                HexaToHexa(textBox1.Text);
        }
    }
}

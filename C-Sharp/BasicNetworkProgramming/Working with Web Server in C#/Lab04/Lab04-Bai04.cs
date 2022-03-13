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
using HtmlAgilityPack;
using System.Linq;

namespace Lab04
{
    public partial class Lab04_Bai04 : Form
    {
        public Lab04_Bai04()
        {
            InitializeComponent();
        }

        void Downloadfile(string fileurl)
        {
            //url của trang web 
            string url = toolStripComboBox1.Text.Trim();
            //Đường dẫn đến thư mục chứa tệp lưu nội dung trang web 
            string DR = System.IO.Path.GetDirectoryName(fileurl);
            WebClient myClient = new WebClient();
            //response chứa nội dung trang web 
            Stream response = myClient.OpenRead(url);
            if (fileurl != null)
            {
                //Lưu nội dung get về từ url vào file có đường dẫn fileurl
                myClient.DownloadFile(url, fileurl);
            }
            //Tạo HtmlDocument chứa nội dung response
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.Load(response);
            //Tạo mảng chứa đối tượng HtmlNode là image
            HtmlNode[] nodeimg = document.DocumentNode.SelectNodes("//img").ToArray();
            //Tạo đường dẫn thư mục Image
            string ImageDirectory = System.IO.Path.Combine(@"" + DR, @"Images\");
            //Tạo thư mục Images
            if (!Directory.Exists(ImageDirectory))
                Directory.CreateDirectory(ImageDirectory);
            //Duyệt từng node img
            foreach (HtmlNode node in nodeimg)
            {
                WebClient client = new WebClient();
                //Lây tên file ảnh 
                string fn = System.IO.Path.GetFileName(node.GetAttributeValue("src", ""));
               
                //Tạo đường dẫn để lưu file ảnh 
                string fileName = System.IO.Path.Combine(@"" + ImageDirectory, @"" + fn);
                string reurl = "";
                //Xét trường hợp  url tuyệt đối và không tuyệt đối
                reurl = ("m" + node.GetAttributeValue("src", "")).IndexOf("http") > 0 ? "" : url;
                string filedownload = reurl + node.GetAttributeValue("src", "");
            
                //Lưu ảnh về
                client.DownloadFile(filedownload, fileName);
            }
            response.Close();
            MessageBox.Show("Downloaded!");
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "")
            {
                MessageBox.Show("Please enter URL");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "*.html";
            sfd.DefaultExt = "html";
            sfd.ValidateNames = true;
            sfd.ShowDialog();
            Downloadfile(sfd.FileName);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "")
            {
                MessageBox.Show("Please enter URL");
                return;
            }
            webBrowser1.Navigate(toolStripComboBox1.Text);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "")
            {
                MessageBox.Show("Please enter URL");
                return;
            }
            WebClient myClient = new WebClient();
            Stream response = myClient.OpenRead(toolStripComboBox1.Text);
            StreamReader sr = new StreamReader(response);
            string content = sr.ReadToEnd();
            Page_Source pagesource = new Page_Source(content);
            pagesource.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "")
            {
                MessageBox.Show("Please enter URL");
                return;
            }
            WebClient myClient = new WebClient();
            byte[] response = myClient.DownloadData(toolStripComboBox1.Text);
            WebHeaderCollection whc = myClient.ResponseHeaders;
            Header_Reponse header_Reponse = new Header_Reponse(whc);
            header_Reponse.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "")
            {
                MessageBox.Show("Please enter URL");
                return;
            }
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "AppleWebKit/{WebKit Rev} (KHTML, like Gecko)");
            Stream response = client.OpenRead(toolStripComboBox1.Text);
            StreamReader sr = new StreamReader(response);
            string content = sr.ReadToEnd();
            Page_Source pagesource = new Page_Source(content);
            pagesource.Show();
        }

        
    }
}

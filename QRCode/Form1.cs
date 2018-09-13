using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;

namespace QRCode
{
    public partial class Form1 : Form
    {
        private string path;
        public Form1()
        {
            InitializeComponent();
            //创建文件夹
            if (!Directory.Exists(Environment.CurrentDirectory + "\\QRpics"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\QRpics");

            }
            this.path = Environment.CurrentDirectory + "\\QRpics\\";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 生成二维码的内容
            string strCode = this.textBox1.Text;
            Bitmap bmp = QRCodeBimapForString(strCode);
            ShowBmp(bmp);

        }

        private void ShowBmp(Bitmap bmp)
        {
            if (bmp != null)
            {
                this.pictureBox1.Image = bmp;
                this.pictureBox1.Image.Save(this.path + DateTime.Now.ToLongDateString() + Guid.NewGuid().ToString() + ".bmp");

            }
            else
            {
                this.pictureBox1.Image = null;
            }
        }

        public Bitmap QRCodeBimapForString(string str, int version = 0)
        {
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            Bitmap bmp = null;
            try
            {
                qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;  //编码方式(注意：BYTE能支持中文，ALPHA_NUMERIC扫描出来的都是数字)
                qrCodeEncoder.QRCodeScale = 4;//大小(值越大生成的二维码图片像素越高)  //版本(注意：设置为0主要是防止编码的字符串太长时发生错误)
                qrCodeEncoder.QRCodeVersion = version;//0，自动调整大小，40，固定大小，且是最大

                qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M; //错误效验、错误更正(有4个等级)
                bmp = qrCodeEncoder.Encode(str, Encoding.GetEncoding("UTF-8"));


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

            return bmp;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.trackBar1.Value = 20;
            string str = Clipboard.GetText();
            this.textBox1.Text = str;
            if (str.Length > 0)
            {
                Bitmap bmp = QRCodeBimapForString(str);
                ShowBmp(bmp);

            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int count = trackBar1.Value;
            string str;
            if (this.textBox1.Text.Length > 0)
            {
                str = this.textBox1.Text;
            }
            else
            {
                str = Clipboard.GetText();
            }
            Bitmap bmp = QRCodeBimapForString(str, count);
            ShowBmp(bmp);

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;

namespace QR
{
    public partial class QR : Form
    {
        public QR()
        {
            InitializeComponent();

        }
        public Bitmap QRCodeBimapForString(string nrazz)
        {
            string enCodeString = "dsa";
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();

            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;  //编码方式(注意：BYTE能支持中文，ALPHA_NUMERIC扫描出来的都是数字)
            qrCodeEncoder.QRCodeScale = 2;//大小(值越大生成的二维码图片像素越高)  //版本(注意：设置为0主要是防止编码的字符串太长时发生错误)

            qrCodeEncoder.QRCodeVersion = 40;//0，自动调整大小，40，固定大小，且是最大

            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M; //错误效验、错误更正(有4个等级)


            return qrCodeEncoder.Encode(enCodeString, Encoding.GetEncoding("UTF-8"));

        }

        private void QR_Load(object sender, EventArgs e)
        {
            //从剪贴板得到内容：

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ThreadAndTask
{
    public partial class Form1 : Form
    {
        private delegate void MyDel(int n);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          var t1=  new Thread(() =>
            {
                int count = 0;
                while (true)
                {
                    count++;
                    if (this.textBox1 != null || !this.textBox1.IsDisposed)
                        lock (textBox1)
                        {
                            this.textBox1.Invoke(new MyDel(Show), new object[] { count });
                        }

                    Thread.Sleep(10);
                }


            }) ;
            t1.IsBackground = true;
            t1.Start();

            var t2 = new Thread(() =>
              {
                  int count = 0;
                  while (true)
                  {
                      count++;
                      if (this.textBox1 != null || !this.textBox1.IsDisposed)
                          lock (textBox1)
                          {
                              this.textBox1.Invoke(new MyDel(Show), new object[] { count });
                          }
                      Thread.Sleep(10);
                  }

              });
            t2.IsBackground = true;
            t2.Start();
        }
        static object obj = new object();
        private void Show(int n)
        {
            this.textBox1.AppendText("thread..." + n + "\r\n");

        }
    }
}

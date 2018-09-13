using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAndInvoke
{
    public partial class Form1 : Form
    {
        // 结论：
        //Control.invoke  control.begininvoke都是在UI 线程上执行，会阻塞UI；都不要放长时间内容
        //应该起一个线程，执行后，在线程的最后，用invoke或begininvoke更新到控件上。
        //invoke 没有任何提示，begininvoke鼠标会变成等待的圆圈


        //delegete 的invoke是在当前线程上执行，会阻塞调用线程。begininvoke是从线程池中取1个，不会阻塞。


        //自己测试foreach 效率略低于for，和网上的结论相反，不过差别不大。



        public Form1()
        {
            InitializeComponent();
        }

        private void btnInvoke_Click(object sender, EventArgs e)
        {
            //this.btnInvoke.Invoke(new MyDel(DelMethod));
            //MessageBox.Show("invoke ok");

            //Thread t = new Thread(ThreadMethod);
            //t.Start();

            //this.textBox1.AppendText("from main begin \r\n ");
            //new Thread(() =>
            //{
            //    this.textBox1.Invoke(new MyDel(() => { this.textBox1.AppendText("from threadMethod  \r\n"); }));
            //    MyDel md2 = new MyDel(() =>
            //    {
            //        Thread.Sleep(2000);
            //        //this.textBox1.AppendText("from delegate \r\n ");
            //    });
            //    md2.Invoke();
            //}).Start();
            //this.textBox1.AppendText("main end  \r\n");


            //测试如下===============================

            //case 1: 卡2秒后  from delegate  from main  
            //MyDel md = new MyDel(() =>
            //{
            //    Thread.Sleep(2000);               
            //    this.textBox1.Invoke(new MyDel(() =>
            //    {
            //        this.textBox1.AppendText("from delegate  ");
            //    }));
            //});
            //md.Invoke();
            //this.textBox1.AppendText("from main  ");

            //case 2: 卡2秒后  from main  from delegate   
            //MyDel md = new MyDel(() =>
            //{
            //    Thread.Sleep(2000);
            //    this.textBox1.BeginInvoke(new MyDel(() =>
            //    {
            //        this.textBox1.AppendText("from delegate  ");
            //    }));
            //});
            //md.Invoke();
            //this.textBox1.AppendText("from main  ");

            //case 3: 立刻from main，不卡的等待2S，然后  from delegate    
            //MyDel md = new MyDel(() =>
            //{
            //    Thread.Sleep(2000);
            //    this.textBox1.Invoke(new MyDel(() =>
            //    {
            //        this.textBox1.AppendText("from delegate  ");
            //    }));
            //});
            //md.BeginInvoke(null, null);
            //this.textBox1.AppendText("from main  ");


            //case 4: 立刻from main，不卡的等待2S，然后  from delegate  结果同上  
            Thread.CurrentThread.Name = "ui";
            MyDel md = new MyDel(() =>
            {
                Thread.CurrentThread.Name = "begininvoke";
                Thread.Sleep(2000);
                Debug.WriteLine(Thread.CurrentThread.Name);
                this.textBox1.BeginInvoke(new MyDel(() =>
                {
                    Debug.WriteLine(Thread.CurrentThread.Name);
                    this.textBox1.AppendText("from delegate  ");//在UI 线程
                }));
            });
            md.BeginInvoke(null, null);//从线程池中取1个线程。
            this.textBox1.AppendText("from main  ");

        }
        private void btnBeginInvoke_Click(object sender, EventArgs e)
        {
            this.btnInvoke.BeginInvoke(new MyDel(DelMethod));
            MessageBox.Show("beginiinvoke ok");
        }

        private void ThreadMethod()
        {
            //耗时操作
            Thread.Sleep(10000);
            //传给窗体，不耗时操作
            this.btnInvoke.Invoke(new MyDel(DelMethod));
            MyDel md = null;

        }

        private void DelMethod()
        {
            //Thread.Sleep(10000); 
            Stopwatch sw = new Stopwatch();

            List<int> list = new List<int>();
            for (int i = 0; i < 10000 * 1000; i++)
            {
                list.Add(1);
            }
            int sum = 0;
            int max = list.Count();


            sw.Reset();
            sw.Start();
            for (int ji = 0; ji < 60; ji++)
            {
                sum = 0;
                for (int i = 0; i < max; i++)
                {
                    sum += list[i];
                }
            }

            sw.Stop();
            Debug.WriteLine("for " + sw.ElapsedMilliseconds.ToString());

            //sum = 0;
            //sw.Reset();
            //sw.Start();
            //for (int ri = 0; ri < 200; ri++)
            //{
            //    sum = 0;
            //    foreach (int item in list)
            //    {
            //        sum += item;
            //    }
            //}
            //sw.Stop();
            //Debug.WriteLine("foreach " + sw.ElapsedMilliseconds.ToString());


        }


    }

    delegate void MyDel();


}

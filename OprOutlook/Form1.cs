using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OprOutlook
{
    public partial class Form1 : Form
    {
        private Point mouse_offset;
        public Form1()
        {
            InitializeComponent();
            foreach (var item in this.Controls)
            {
                Label lbl = item as Label;
                if (lbl != null)
                {
                    lbl.MouseDown += MyMouseDown;
                    lbl.MouseUp += MyMouseUp;
                }

            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //start
            string str = null;
            foreach (var item in this.grbName.Controls)
            {
                str += (item as Label).Text;
            }
            if (str != null)
            {
                this.textBox1.AppendText(str + "\r\n");
            }


            str = null;
            foreach (var item in this.grbType.Controls)
            {
                str += (item as Label).Text;
            }
            if (str != null)
            {
                this.textBox1.AppendText(str + "\r\n");
            }

        }

        private void MyMouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private int countA = 0;
        private int countB = 0;

        private void MyMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.X > this.splitter1.Right)
                {
                    //创建
                    Label lbl = sender as Label;
                    Label label = new Label();
                    label.Name = lbl.Name;
                    label.Text = lbl.Text;
                    label.BackColor = lbl.BackColor;
                    label.Size = lbl.Size;
                    label.Font = lbl.Font;
                    label.BorderStyle = lbl.BorderStyle;
                    label.Tag = lbl.Tag;
                    label.MouseDown += MyMouseDown;
                    label.MouseUp += MyMouseUp;
                    //label.Location = ((Control)sender).Parent.PointToClient(mousePos);
                    if (label.Tag.ToString() == "A")
                    {
                        label.Location = new Point(countA * label.Width + 10, 20);
                        this.grbName.Controls.Add(label);
                        countA++;
                    }
                    else
                    {
                        label.Location = new Point(countB * label.Width + 10, 20);
                        this.grbType.Controls.Add(label);
                        countB++;
                    }
                    label.Show();
                }
                else
                {
                    //移除
                    Label lbl = sender as Label;
                    if (lbl.Tag.ToString() == "A")
                    {
                        this.grbName.Controls.Remove(lbl);
                        this.countA--;
                        this.countA = this.countA < 0 ? 0 : this.countA;
                        for (int i = 0; i < this.grbName.Controls.Count; i++)
                        {
                            this.grbName.Controls[i].Left = i * this.grbName.Controls[i].Width + 10;
                        }

                    }
                    else
                    {
                        this.grbType.Controls.Remove(lbl);
                        this.countB--;
                        this.countB = this.countB < 0 ? 0 : this.countB;
                        for (int i = 0; i < this.grbType.Controls.Count; i++)
                        {
                            this.grbType.Controls[i].Left = i * this.grbType.Controls[i].Width + 10;
                        }
                    }


                }



            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string str = @"E:\4-其他类\15-房子\9-西华房子";

            //openFileDialog1.InitialDirectory = str;
            //openFileDialog1.ShowDialog( );
            //this.txtPath.Text = openFileDialog1.SafeFileName;

            folderBrowserDialog1.SelectedPath = str;
            
            folderBrowserDialog1.ShowDialog();
            this.txtPath.Text = folderBrowserDialog1.SelectedPath;


        }
    }



}

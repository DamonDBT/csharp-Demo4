namespace OprOutlook
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblSenderName = new System.Windows.Forms.Label();
            this.lblReceiveName = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblSenderTime = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grbName = new System.Windows.Forms.GroupBox();
            this.grbType = new System.Windows.Forms.GroupBox();
            this.lblXSL = new System.Windows.Forms.Label();
            this.lblDOC = new System.Windows.Forms.Label();
            this.lblRAR = new System.Windows.Forms.Label();
            this.lblJPG = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(189, 770);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(507, 17);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(73, 44);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "开始";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblSenderName
            // 
            this.lblSenderName.BackColor = System.Drawing.Color.White;
            this.lblSenderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSenderName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSenderName.Location = new System.Drawing.Point(31, 17);
            this.lblSenderName.Name = "lblSenderName";
            this.lblSenderName.Size = new System.Drawing.Size(100, 20);
            this.lblSenderName.TabIndex = 2;
            this.lblSenderName.Tag = "A";
            this.lblSenderName.Text = "发件人";
            // 
            // lblReceiveName
            // 
            this.lblReceiveName.BackColor = System.Drawing.Color.White;
            this.lblReceiveName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReceiveName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReceiveName.Location = new System.Drawing.Point(31, 53);
            this.lblReceiveName.Name = "lblReceiveName";
            this.lblReceiveName.Size = new System.Drawing.Size(100, 20);
            this.lblReceiveName.TabIndex = 3;
            this.lblReceiveName.Tag = "A";
            this.lblReceiveName.Text = "收件人";
            // 
            // lblFileName
            // 
            this.lblFileName.BackColor = System.Drawing.Color.White;
            this.lblFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFileName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFileName.Location = new System.Drawing.Point(31, 89);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(100, 20);
            this.lblFileName.TabIndex = 4;
            this.lblFileName.Tag = "A";
            this.lblFileName.Text = "文件名";
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.Color.White;
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCount.Location = new System.Drawing.Point(31, 125);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(100, 20);
            this.lblCount.TabIndex = 5;
            this.lblCount.Tag = "A";
            this.lblCount.Text = "计数器";
            // 
            // lblSenderTime
            // 
            this.lblSenderTime.BackColor = System.Drawing.Color.White;
            this.lblSenderTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSenderTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSenderTime.Location = new System.Drawing.Point(31, 161);
            this.lblSenderTime.Name = "lblSenderTime";
            this.lblSenderTime.Size = new System.Drawing.Size(100, 20);
            this.lblSenderTime.TabIndex = 6;
            this.lblSenderTime.Tag = "A";
            this.lblSenderTime.Text = "发件日期";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(195, 348);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(685, 410);
            this.textBox1.TabIndex = 7;
            // 
            // grbName
            // 
            this.grbName.Location = new System.Drawing.Point(195, 92);
            this.grbName.Name = "grbName";
            this.grbName.Size = new System.Drawing.Size(685, 89);
            this.grbName.TabIndex = 8;
            this.grbName.TabStop = false;
            this.grbName.Text = "名字格式：";
            // 
            // grbType
            // 
            this.grbType.Location = new System.Drawing.Point(195, 197);
            this.grbType.Name = "grbType";
            this.grbType.Size = new System.Drawing.Size(685, 89);
            this.grbType.TabIndex = 8;
            this.grbType.TabStop = false;
            this.grbType.Text = "文件类型：";
            // 
            // lblXSL
            // 
            this.lblXSL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblXSL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblXSL.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblXSL.Location = new System.Drawing.Point(31, 197);
            this.lblXSL.Name = "lblXSL";
            this.lblXSL.Size = new System.Drawing.Size(100, 20);
            this.lblXSL.TabIndex = 9;
            this.lblXSL.Tag = "B";
            this.lblXSL.Text = "XSL";
            // 
            // lblDOC
            // 
            this.lblDOC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblDOC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDOC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDOC.Location = new System.Drawing.Point(31, 233);
            this.lblDOC.Name = "lblDOC";
            this.lblDOC.Size = new System.Drawing.Size(100, 20);
            this.lblDOC.TabIndex = 10;
            this.lblDOC.Tag = "B";
            this.lblDOC.Text = "DOC";
            // 
            // lblRAR
            // 
            this.lblRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblRAR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRAR.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRAR.Location = new System.Drawing.Point(31, 269);
            this.lblRAR.Name = "lblRAR";
            this.lblRAR.Size = new System.Drawing.Size(100, 20);
            this.lblRAR.TabIndex = 11;
            this.lblRAR.Tag = "B";
            this.lblRAR.Text = "RAR";
            // 
            // lblJPG
            // 
            this.lblJPG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblJPG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJPG.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblJPG.Location = new System.Drawing.Point(31, 305);
            this.lblJPG.Name = "lblJPG";
            this.lblJPG.Size = new System.Drawing.Size(100, 20);
            this.lblJPG.TabIndex = 12;
            this.lblJPG.Tag = "B";
            this.lblJPG.Text = "JPG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "登录名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "密  码：";
            // 
            // cmbUserName
            // 
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(255, 19);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(184, 20);
            this.cmbUserName.TabIndex = 16;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(255, 42);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(184, 21);
            this.txtPwd.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "保存路径：";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(255, 307);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(511, 21);
            this.txtPath.TabIndex = 18;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(805, 305);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 19;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 770);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbUserName);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblJPG);
            this.Controls.Add(this.lblRAR);
            this.Controls.Add(this.lblDOC);
            this.Controls.Add(this.lblXSL);
            this.Controls.Add(this.grbType);
            this.Controls.Add(this.grbName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSenderTime);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblReceiveName);
            this.Controls.Add(this.lblSenderName);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblSenderName;
        private System.Windows.Forms.Label lblReceiveName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblSenderTime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grbName;
        private System.Windows.Forms.GroupBox grbType;
        private System.Windows.Forms.Label lblXSL;
        private System.Windows.Forms.Label lblDOC;
        private System.Windows.Forms.Label lblRAR;
        private System.Windows.Forms.Label lblJPG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
    }
}


namespace 邮件发送器
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.sendtoo = new System.Windows.Forms.TextBox();
            this.titlee = new System.Windows.Forms.TextBox();
            this.bodyy = new System.Windows.Forms.TextBox();
            this.sendto = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.Label();
            this.file = new System.Windows.Forms.Label();
            this.filee = new System.Windows.Forms.TextBox();
            this.filechoose = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "点击发送邮件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sendtoo
            // 
            this.sendtoo.Location = new System.Drawing.Point(105, 56);
            this.sendtoo.Name = "sendtoo";
            this.sendtoo.Size = new System.Drawing.Size(302, 21);
            this.sendtoo.TabIndex = 1;
            // 
            // titlee
            // 
            this.titlee.Location = new System.Drawing.Point(105, 99);
            this.titlee.Name = "titlee";
            this.titlee.Size = new System.Drawing.Size(302, 21);
            this.titlee.TabIndex = 2;
            // 
            // bodyy
            // 
            this.bodyy.Location = new System.Drawing.Point(105, 146);
            this.bodyy.Name = "bodyy";
            this.bodyy.Size = new System.Drawing.Size(302, 21);
            this.bodyy.TabIndex = 3;
            // 
            // sendto
            // 
            this.sendto.AutoSize = true;
            this.sendto.Location = new System.Drawing.Point(28, 59);
            this.sendto.Name = "sendto";
            this.sendto.Size = new System.Drawing.Size(53, 12);
            this.sendto.TabIndex = 4;
            this.sendto.Text = "目标邮箱";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(28, 102);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(53, 12);
            this.title.TabIndex = 5;
            this.title.Text = "邮件主题";
            // 
            // body
            // 
            this.body.AutoSize = true;
            this.body.Location = new System.Drawing.Point(28, 155);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(53, 12);
            this.body.TabIndex = 6;
            this.body.Text = "发送内容";
            // 
            // file
            // 
            this.file.AutoSize = true;
            this.file.Location = new System.Drawing.Point(28, 197);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(77, 12);
            this.file.TabIndex = 7;
            this.file.Text = "发送附件路径";
            // 
            // filee
            // 
            this.filee.Location = new System.Drawing.Point(105, 194);
            this.filee.Name = "filee";
            this.filee.Size = new System.Drawing.Size(233, 21);
            this.filee.TabIndex = 8;
            // 
            // filechoose
            // 
            this.filechoose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.filechoose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.filechoose.Location = new System.Drawing.Point(338, 191);
            this.filechoose.Name = "filechoose";
            this.filechoose.Size = new System.Drawing.Size(69, 25);
            this.filechoose.TabIndex = 9;
            this.filechoose.Text = "选择文件";
            this.filechoose.UseVisualStyleBackColor = false;
            this.filechoose.Click += new System.EventHandler(this.filechoose_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 21);
            this.button2.TabIndex = 10;
            this.button2.Text = "一键开启25端口";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 318);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.filechoose);
            this.Controls.Add(this.filee);
            this.Controls.Add(this.file);
            this.Controls.Add(this.body);
            this.Controls.Add(this.title);
            this.Controls.Add(this.sendto);
            this.Controls.Add(this.bodyy);
            this.Controls.Add(this.titlee);
            this.Controls.Add(this.sendtoo);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "邮件简易发送器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sendtoo;
        private System.Windows.Forms.TextBox titlee;
        private System.Windows.Forms.TextBox bodyy;
        private System.Windows.Forms.Label sendto;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label body;
        private System.Windows.Forms.Label file;
        private System.Windows.Forms.TextBox filee;
        private System.Windows.Forms.Button filechoose;
        private System.Windows.Forms.Button button2;
    }
}


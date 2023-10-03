using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;

namespace 课件整理工具
{

    public partial class Form1 : Form
    {
        public static NotifyIcon notify;
        private System.Timers.Timer time;
        private bool switchs = false;
        private string desPath;
        private string divName;

        //这段代码定义了一个窗体类 Form1，其中包含了一些私有成员变量，用于在窗体应用程序中执行特定的任务和操作


        public Form1()
        {
            InitializeComponent();
            desPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            divName = Path.Combine(desPath, "课件");

            // 初始化计时器，但不启动
            time = new System.Timers.Timer(3600000);
            time.Elapsed += 计划任务;
            //到达时间执行计划任务

            
            notify = new NotifyIcon();
            notify.Icon = SystemIcons.Application;
            notify.DoubleClick += 托盘被点击;
            notify.ContextMenuStrip = new ContextMenuStrip();
            //创建notify的菜单
            notify.ContextMenuStrip.Items.Add("程序主界面", null, 开启);
            notify.ContextMenuStrip.Items.Add("开启整理功能", null, 启动);
            notify.ContextMenuStrip.Items.Add("关闭整理功能", null, 关闭);
            notify.ContextMenuStrip.Items.Add("关闭大师", null, 托盘的退出);

            notify.Visible = true;
            //这段代码设置了退出按钮，最小化和系统显示
            this.WindowState = FormWindowState.Minimized;
            switchs = true;
            time.Start();
            uiButton1.Enabled = false;
            uiButton2.Enabled = true;
            qidongNotify();
        }

        public  void qidongNotify()
        {
            
            notify.BalloonTipTitle = "桌面课件整理已启动！";
            Random 随机一言 = new Random();
            switch (随机一言.Next(1, 6))
            {
                case 1:
                    notify.BalloonTipText = "极度震惊！某班多媒体管理员又因少一次整理课件而续命5秒钟！！!";
                    break;
                case 2:
                    notify.BalloonTipText = "据说有同学会在老师开机后看到这条信息，我刚开始是不信的，不会真有人看吧！！!";
                    break;
                case 3:
                    notify.BalloonTipText = "科学研究表示:你读完这里就会浪费五秒时间，这五秒堪比多媒体管理员整理课件的时间！！!";
                    break;
                case 4:
                    notify.BalloonTipText = "少壮不努力，老大像我一样整理课件当劳力！！!";
                    break;
                case 5:
                    notify.BalloonTipText = "我又为懒人多媒体管理员节约了5秒整理课件的时间，这软件谁写的？太狠了！！!";
                    break;
            }

            notify.ShowBalloonTip(20000);
        }

      
        private void 开启(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = false;
        }
        private void 启动(object sender, EventArgs e)
        {
            switchs = true;
            time.Start();
            uiButton1.Enabled = false;
            uiButton2.Enabled = true;
        }
        private void 关闭(object sender, EventArgs e)
        {
            switchs = false;
            time.Stop();
            uiButton1.Enabled = true;
            uiButton2.Enabled = false;
        }
        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (switchs == false)
            {
                switchs = true;
                time.Start();
                uiButton1.Enabled = false;
                uiButton2.Enabled = true;
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (switchs)
            {
                switchs = false;
                time.Stop();
                uiButton1.Enabled = true;
                uiButton2.Enabled = false;
            }
        }

        private void 计划任务(object sender, ElapsedEventArgs e)
        {
            if (switchs == true)
            {
                // 获取桌面上的所有文件
                string[] 桌面文件大全 = Directory.GetFiles(desPath, "*.*");

                foreach (string file in 桌面文件大全)
                {
                    // 获取文件的扩展名
                    string 扩展名 = Path.GetExtension(file).ToLower();

                    // 检查文件是否是PDF、DOC/DOCX或PPT/PPTX文件
                    if (扩展名 == ".pdf" || 扩展名 == ".doc" || 扩展名 == ".docx" || 扩展名 == ".ppt" || 扩展名 == ".pptx")
                    {
                        string 结果文件 = Path.Combine(divName, Path.GetFileName(file));
                        try
                        {
                            File.Move(file, 结果文件);
                        }
                        catch { };
                    }
                }


            }
        }




        private void 托盘被点击(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = false;
        }

        private bool isRunningInBackground = false;

        private void 托盘的退出(object sender, EventArgs e)
        {
            // 停止计时器（如果它正在运行）
            if (switchs)
            {
                time.Stop();
            }

            // 关闭应用程序
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !isRunningInBackground)
            {
                e.Cancel = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;

            }
        }



        private void uiButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("软件由十五班多媒体管理员c#语言编写 使用SunnyUI作为界面优化。本软件每小时自动清理桌面课件，保持桌面整洁(需要先创建一个课件文件夹在桌面)", "课件整理工具V4.2", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                notify.BalloonTipTitle = "感谢支持！";
                notify.BalloonTipText = "谢谢你愿意了解作者！";
                notify.ShowBalloonTip(3000);
            }
            else
            {
            }
        }



       

        private void uiButton5_Click(object sender, EventArgs e)
        {
            Process.Start("https://487487.xyz/kj/");
        }

        private void uiButton6_Click(object sender, EventArgs e)
        {
            展台工具 form11 = new 展台工具();
            form11.Show();
        }

        private void uiButton7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("摸鱼中");
        }

        private void uiButton8_Click(object sender, EventArgs e)
        {
            系统工具 xitong = new 系统工具();
            xitong.Show();

        }
    }
}


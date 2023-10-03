using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace 课件整理工具
{
    public partial class 展台工具 : Form
    {
        public 展台工具()
        {
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            
            string today=MingZi();
            bool cunZai=Directory.Exists(@"D:\EasiCameraPhoto\" + today);
            string kejian = @"D:\EasiCameraPhoto\" + today;
            if (cunZai)
            {
                Process.Start("explorer.exe", kejian);
            }
            else
            {
                MessageBox.Show("哥，别瞎玩了，这一天你拍照了吗？我这也没检测到历史记录啊？？？","错误1-不...不...不...");
            }
        }

        public string MingZi()
        {
            DateTime dt = DateTime.Now;
            
            int day = dt.Day;
            int year = dt.Year;
            int month = dt.Month;
           return year + "-" + month.ToString("00") + "-" + day.ToString("00");

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
           Process[] zhantai=Process.GetProcessesByName("Easicamera");
            if (zhantai.Length > 0)
            {
                foreach (Process process in zhantai)
                {
                    process.Kill();
                }
            }
            else
            {
                MessageBox.Show("没有找到进程，byd玩我呢？","错误2-你就苟吧");
            }

        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            string today = MingZi();
            bool cunZai = Directory.Exists(@"D:\EasiCameraPhoto\" + today);
            string kejian = @"D:\EasiCameraPhoto\";
            if (cunZai)
            {
                Process.Start("explorer.exe", kejian);
            }
            else
            {
                MessageBox.Show("哥，你们的展台软件安装位置好像不对，这功能你们用不了", "错误3-展台安装有误");
            }
        }
    }
}

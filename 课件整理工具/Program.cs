using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;

namespace 课件整理工具
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process[] processes = Process.GetProcessesByName("课件整理工具");
            if (processes.Length > 1)
            {
                MessageBox.Show("不是，兄弟，软件已经开了，别点了！点击右下角朝上的小箭头，即可打开托盘，双击程序图标就可以进入","你先别急");
                Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}

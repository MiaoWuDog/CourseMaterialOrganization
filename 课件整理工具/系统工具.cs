using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 课件整理工具
{
    public partial class 系统工具 : Form
    {
        public 系统工具()
        {
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string[] processNames = { "seewo", "Office", "EasiCamera", "WPS", "课件整理工具" };

            foreach (string processName in processNames)
            {
                Process[] processes = Process.GetProcessesByName(processName);
                if (processes.Length > 0)
                {
                    foreach (Process process in processes)
                    {
                       
                            process.Kill();
                            process.WaitForExit(); // 等待进程退出
                        MessageBox.Show("你能看见这个弹窗？那可能存在有bug");
                    }
                }
                
               
            }


        }
    }
    }

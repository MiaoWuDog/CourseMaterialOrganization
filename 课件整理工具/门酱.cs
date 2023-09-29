using System;
using System.Drawing;
using System.Windows.Forms;

namespace 课件整理工具
{
    
    public partial class 门酱 : Form
    {
    
        public 门酱()
        {
            InitializeComponent();
        }
        private int 启动次数2 = 0;
        private void uiButton1_Click(object sender, EventArgs e)
        {
            int x = this.ClientSize.Width - uiButton1.Width;
            int y = this.ClientSize.Height - uiButton1.Height;
            Random loc = new Random();
            uiButton1.Location = new Point(loc.Next(0,x),loc.Next(0,y));
            
            启动次数2++;
            if (启动次数2==10)
            {
                DialogResult 启动结果 = MessageBox.Show("你成功和门酱结婚了！婚礼？启动！", "获得成就 - 还真结婚了");
                if (启动结果==DialogResult.OK)
                {
                    
                    this.Close();
                }
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这就不行了？？？", "获得成就-逃兵");
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            uiLabel1.Text=uiLabel1.Text.Substring(1) + uiLabel1.Text.Substring(0, 1);
        }
    }
}

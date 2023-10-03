namespace 课件整理工具
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uiStyleManager1 = new Sunny.UI.UIStyleManager(this.components);
            this.uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            this.uiButton8 = new Sunny.UI.UIButton();
            this.uiButton7 = new Sunny.UI.UIButton();
            this.uiButton6 = new Sunny.UI.UIButton();
            this.uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            this.uiTitlePanel3 = new Sunny.UI.UITitlePanel();
            this.uiTitlePanel1.SuspendLayout();
            this.uiTitlePanel2.SuspendLayout();
            this.uiTitlePanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("黑体", 12F);
            this.uiButton1.Location = new System.Drawing.Point(13, 73);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(155, 50);
            this.uiButton1.TabIndex = 0;
            this.uiButton1.Text = "开启整理模式";
            this.uiButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("黑体", 12F);
            this.uiButton2.Location = new System.Drawing.Point(14, 162);
            this.uiButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(154, 50);
            this.uiButton2.TabIndex = 1;
            this.uiButton2.Text = "关闭整理模式";
            this.uiButton2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.Font = new System.Drawing.Font("黑体", 12F);
            this.uiButton3.Location = new System.Drawing.Point(12, 67);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(155, 50);
            this.uiButton3.TabIndex = 4;
            this.uiButton3.Text = "关于程序";
            this.uiButton3.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.uiButton8);
            this.uiTitlePanel1.Controls.Add(this.uiButton7);
            this.uiTitlePanel1.Controls.Add(this.uiButton6);
            this.uiTitlePanel1.Font = new System.Drawing.Font("黑体", 12F);
            this.uiTitlePanel1.Location = new System.Drawing.Point(180, 0);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.ShowText = false;
            this.uiTitlePanel1.Size = new System.Drawing.Size(366, 248);
            this.uiTitlePanel1.TabIndex = 8;
            this.uiTitlePanel1.Text = "实用功能";
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiButton8
            // 
            this.uiButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton8.Font = new System.Drawing.Font("黑体", 12F);
            this.uiButton8.Location = new System.Drawing.Point(15, 162);
            this.uiButton8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton8.Name = "uiButton8";
            this.uiButton8.Size = new System.Drawing.Size(155, 50);
            this.uiButton8.TabIndex = 2;
            this.uiButton8.Text = "系统相关";
            this.uiButton8.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton8.Click += new System.EventHandler(this.uiButton8_Click);
            // 
            // uiButton7
            // 
            this.uiButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton7.Font = new System.Drawing.Font("黑体", 12F);
            this.uiButton7.Location = new System.Drawing.Point(15, 73);
            this.uiButton7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton7.Name = "uiButton7";
            this.uiButton7.Size = new System.Drawing.Size(155, 50);
            this.uiButton7.TabIndex = 1;
            this.uiButton7.Text = "白板相关";
            this.uiButton7.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton7.Click += new System.EventHandler(this.uiButton7_Click);
            // 
            // uiButton6
            // 
            this.uiButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton6.Font = new System.Drawing.Font("黑体", 12F);
            this.uiButton6.Location = new System.Drawing.Point(198, 73);
            this.uiButton6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton6.Name = "uiButton6";
            this.uiButton6.Size = new System.Drawing.Size(155, 50);
            this.uiButton6.TabIndex = 0;
            this.uiButton6.Text = "展台相关";
            this.uiButton6.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton6.Click += new System.EventHandler(this.uiButton6_Click);
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Controls.Add(this.uiButton2);
            this.uiTitlePanel2.Controls.Add(this.uiButton1);
            this.uiTitlePanel2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel2.Location = new System.Drawing.Point(-2, 0);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.ShowText = false;
            this.uiTitlePanel2.Size = new System.Drawing.Size(181, 248);
            this.uiTitlePanel2.TabIndex = 7;
            this.uiTitlePanel2.Text = "主要功能";
            this.uiTitlePanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTitlePanel3
            // 
            this.uiTitlePanel3.Controls.Add(this.uiButton3);
            this.uiTitlePanel3.Font = new System.Drawing.Font("黑体", 12F);
            this.uiTitlePanel3.Location = new System.Drawing.Point(-1, 249);
            this.uiTitlePanel3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.uiTitlePanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel3.Name = "uiTitlePanel3";
            this.uiTitlePanel3.ShowText = false;
            this.uiTitlePanel3.Size = new System.Drawing.Size(547, 153);
            this.uiTitlePanel3.TabIndex = 9;
            this.uiTitlePanel3.Text = "其他功能";
            this.uiTitlePanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(542, 395);
            this.Controls.Add(this.uiTitlePanel3);
            this.Controls.Add(this.uiTitlePanel2);
            this.Controls.Add(this.uiTitlePanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "课件整理大师V4.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel2.ResumeLayout(false);
            this.uiTitlePanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton3;
        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UIStyleManager uiStyleManager1;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private Sunny.UI.UITitlePanel uiTitlePanel3;
        private Sunny.UI.UIButton uiButton7;
        private Sunny.UI.UIButton uiButton6;
        private Sunny.UI.UIButton uiButton8;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaiQiu
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Point startPoint;           //线条开始坐标
        private Point endPoint;             //线条结束坐标
        private float penWidth = 1;         //线条宽度
        private Color penColor = Color.Red; //绘图颜色
        private float radius = 15f;
        private const float radius_base = 9.5f;
        private Point circle2Center;        //目标球圆心
        private TimeSpan exitTime;         //退出时间
        public Form1()
        {
            InitializeComponent();
            //创建Graphics对象
            g = this.CreateGraphics();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {   
                //清除图像
                this.Refresh();
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                //记住线条起点
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point cur_pos = new Point(e.X, e.Y); //鼠标当前位置
            Pen pen;        
            if (startPoint != endPoint) //擦除：绘制和背景色一样的线条
            {
                pen = new Pen(this.BackColor, penWidth); //使用背景色创建画笔
                g.DrawLine(pen, startPoint, endPoint); //绘制线条
                //绘制母球
                g.DrawEllipse(new Pen(this.BackColor, penWidth), endPoint.X - radius, endPoint.Y - radius, radius * 2, radius * 2);
                //绘制目标球
                g.DrawEllipse(new Pen(this.BackColor, penWidth), circle2Center.X - radius, circle2Center.Y - radius, radius * 2, radius * 2);
            }
            
            //绘制线条
            pen = new Pen(penColor, penWidth);
            g.DrawLine(pen, startPoint, cur_pos);
            //绘制母球
            g.DrawEllipse(pen, e.X - radius, e.Y - radius, radius * 2, radius * 2);

            //画目标球
            circle2Center = GetDestCircle(e.X, e.Y);
            g.DrawEllipse(pen, circle2Center.X - radius, circle2Center.Y - radius, radius * 2, radius * 2);

            endPoint = cur_pos; //线条结束点是鼠标当前位置
        }

        //窗口透明度
        private void frmOpacityTrackBar_Scroll(object sender, EventArgs e)
        {
            this.Opacity = frmOpacityTrackBar.Value / 100.0;
        }

        //线宽
        private void penWeigthTrackBar_Scroll(object sender, EventArgs e)
        {
            this.penWidth = penWeigthTrackBar.Value/10;
        }

        //改变母球大小
        private void ballSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            this.radius = radius_base +  ballSizeTrackBar.Value / 10;
        }

        //颜色
        private void colorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                colorBtn.BackColor = penColor = colorDialog1.Color;
            }
        }

        //从注册表加载配置
        private void LoadConfigInfo()
        {
            ConfigInfo info = new ConfigInfo();
            frmOpacityTrackBar.Value = info.GetOpacity();
            penWeigthTrackBar.Value = info.GetLineWidth();
            ballSizeTrackBar.Value = info.GetBallSize();
        }
        //写配置到注册表
        private void WriteConfigInfo()
        {
            ConfigInfo info = new ConfigInfo();
            info.WriteOpacity(frmOpacityTrackBar.Value);
            info.WriteLineWidth(penWeigthTrackBar.Value);
            info.WriteBallSize(ballSizeTrackBar.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadConfigInfo();
            this.Opacity = frmOpacityTrackBar.Value;
            penWidth = penWeigthTrackBar.Value / 10;
            radius = radius_base + ballSizeTrackBar.Value / 10;

            //检测注册
            if (!IsRegister())
            {
                label3.Visible = true;
                label4.Visible = true;
                regButton.Visible = true;
                timer1.Start();
                exitTime = DateTime.Now.TimeOfDay.Add(new TimeSpan(0, 7, 0)); //退出时间
                //label3.Text = exitTime.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteConfigInfo();
        }

        //根据当前点计算目标球圆心
        private Point GetDestCircle(float x, float y)
        {
            //计算圆2的 原点
            float x0 = 0, y0 = 0;
            float linelength = (float)Math.Abs(CalcLineLength(startPoint.X, startPoint.Y, x, y));
            float n = (y - startPoint.Y) * (linelength - 2 * radius) / linelength;
            float m = (x - startPoint.X) * (linelength - 2 * radius) / linelength;

            if (x != startPoint.X && y != startPoint.Y)
            {
                x0 = startPoint.X + m;
                y0 = startPoint.Y + n;
            }
            else
            {
                x0 = x;
                y0 = y;
            }

            return new Point((int)x0, (int)y0);
        }

        //计算两点间距离
        private double CalcLineLength(float x1, float y1, float x2, float y2)
        {
            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        }

        //帮助
        private void helpBtn_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.Show();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            RegsterForm form = new RegsterForm();
            form.ShowDialog();
        }

        //检测是否已注册
        private bool IsRegister()
        {
            CdKeyTools tools = new CdKeyTools();
            string cdkey = tools.GetRegisterCdkey();
            if (!string.IsNullOrEmpty(cdkey) &&
                cdkey == tools.GetCdKey())
                return true;
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan t = exitTime - DateTime.Now.TimeOfDay;
            label3.Text = string.Format("{0}:{1}", t.Minutes.ToString("D2"), t.Seconds.ToString("D2"));
            if (t.Minutes <= 0)
                Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace TQ
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Point startPoint;
        private Point endPoint, endPoint2;
        private float penWidth = 1;
        private Color penColor = Color.Red;
        private float radius;
        private const float radius_base = 9.5f;
        private TimeSpan startTime;
        public float PenWidth
        {
            get { return penWidth; }
            set { penWidth = 1 + value / 10; }
        }

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            startPoint.X = -1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //从注册表加载配置
            LoadConfigInfo();

            this.Opacity = trackBar1.Value;
            radius = radius_base + trackBar3.Value / 10; //球半径
            PenWidth = trackBar2.Value;

#if !SELF_USER
            //检测注册
            if (!IsRegister())
            {
                label3.Visible = true;
                label4.Visible = true;
                regButton.Visible = true;
                timer1.Start();
                startTime = DateTime.Now.TimeOfDay.Add(new TimeSpan(0, 7, 0)); //退出时间
                label3.Text = startTime.ToString();
            }
#endif

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //写入注册表
            WriteConfigInfo();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
#if !SELF_USER
            MessageBox.Show("感謝使用!歡迎訪問敏捷學院http://www.mjxy.cn!");

            Process.Start("http://www.mjxy.cn");
#endif

        }

        
        //从注册表加载配置
        private void LoadConfigInfo()
        {
            ConfigInfo info = new ConfigInfo();
            trackBar1.Value = info.GetOpacity();
            trackBar2.Value = info.GetLineWidth();
            trackBar3.Value = info.GetBallSize();
        }
        //写配置到注册表
        private void WriteConfigInfo()
        {
            ConfigInfo info = new ConfigInfo();
            info.WriteOpacity(trackBar1.Value);
            info.WriteLineWidth(trackBar2.Value);
            info.WriteBallSize(trackBar3.Value);
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

        //窗口透明度
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //this.Text = (trackBar1.Value / 100.0).ToString();
            this.Opacity = trackBar1.Value / 100.0;
        }

        //线条粗细
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            PenWidth = trackBar2.Value;
            //this.Text = PenWidth.ToString();
        }

        //母球大小
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            float r = radius_base + trackBar3.Value / 10;
            this.radius = r;
            //this.Text = r.ToString();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.Refresh();
                startPoint.X = -1;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                startPoint = new Point(e.X, e.Y);
                //g.DrawEllipse(new Pen(penColor, PenWidth), e.X - radius, e.Y - radius, radius * 2, radius * 2);

            }
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPoint != endPoint)
            {
                g.DrawLine(new Pen(this.BackColor, PenWidth), startPoint, endPoint);
                g.DrawEllipse(new Pen(this.BackColor, PenWidth), endPoint.X - radius, endPoint.Y - radius, radius * 2, radius * 2);
                g.DrawEllipse(new Pen(this.BackColor, PenWidth), endPoint2.X - radius, endPoint2.Y - radius, radius * 2, radius * 2);

            }

            //Debug.WriteLine(linelength);

            if (startPoint.X != -1)
            {
                Point pos = new Point(e.X, e.Y);
                Pen pen = new Pen(penColor, PenWidth);
                g.DrawLine(pen, startPoint, pos);
                g.DrawEllipse(pen, e.X - radius, e.Y - radius, radius * 2, radius * 2);

                //画圆2
                Point p = GetDestCircle(e.X, e.Y);
                g.DrawEllipse(pen, p.X - radius, p.Y - radius, radius * 2, radius * 2);

                endPoint = pos;
                endPoint2 = p;
            }

            // this.Text = string.Format("{0},{1}", e.X, e.Y);
        }

        //根据当前点计算目标球圆心
        private Point GetDestCircle(float x, float y)
        {
            //计算圆2的 原点
            float x0 = 0, y0 = 0;
            float linelength = (float)Math.Abs(CalcLineLength(startPoint.X, startPoint.Y, x, y));
            float n = (y - startPoint.Y) * (linelength - 2 * radius) / linelength;
            float m = (x - startPoint.X) * (linelength - 2 * radius) / linelength;
            /*
                        if (y > startPoint.Y && x < startPoint.X)
                        {
                            x0 = startPoint.X + m;
                            y0 = startPoint.Y + n;
                        }
                        else if (y < startPoint.Y && x > startPoint.X)
                        {
                            x0 = startPoint.X + m;
                            y0 = startPoint.Y + n;
                        }
                        else if (y < startPoint.Y && x < startPoint.X)//右上角
                        {
                            x0 = startPoint.X  +m ;
                            y0 = startPoint.Y + n;
                        }
                        else if (y > startPoint.Y && x > startPoint.X) //右下角
                        {
                            x0 = startPoint.X +m;
                            y0 = startPoint.Y +n;
                        }
                        else*/
            /*if (y == startPoint.Y && x > startPoint.X) //在正左边
            {
                x0 = x - (int)(2 * radius);
                y0 = y;
            }
            else if (y == startPoint.Y && x < startPoint.X) //在正右边
            {
                x0 = x + (int)(2 * radius);
                y0 = y;
            }
            else if (x == startPoint.X && y > startPoint.Y) //在正上边
            {
                x0 = x;
                y0 = y - (int)(2 * radius);

            }
            else if (x == startPoint.X && y < startPoint.Y) //在正下边
            {
                x0 = x;
                y0 = y + (int)(2 * radius);
            }
            else */
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



        private void label1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                label1.BackColor = penColor = colorDialog1.Color;
            }
        }




        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // key +
            switch (e.KeyCode)
            {
                case Keys.Oemplus:
                    trackBar3_Scroll(sender, e);
                    if (trackBar3.Value < trackBar3.Maximum) trackBar3.Value += 1;
                    break;
                case Keys.OemMinus:
                    trackBar3_Scroll(sender, e);
                    if (trackBar3.Value > trackBar3.Minimum) trackBar3.Value -= 1;
                    break;
            }

        }


        private void label2_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.Show();
        }

      

        private void TrackBar_MouseEnter(object sender, EventArgs e)
        {
            //this.rem_opacity = this.Opacity;
            this.Opacity = 0.8;
        }

        private void TrackBar_MouseLeave(object sender, EventArgs e)
        {
            this.Opacity = trackBar1.Value / 100.0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan t = startTime - DateTime.Now.TimeOfDay;
            label3.Text = string.Format("{0}:{1}", t.Minutes.ToString("D2"), t.Seconds.ToString("D2"));
            if (t.Minutes <= 0)
                Application.Exit();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            RegsterForm form = new RegsterForm();
            form.ShowDialog();
        }

    }
}

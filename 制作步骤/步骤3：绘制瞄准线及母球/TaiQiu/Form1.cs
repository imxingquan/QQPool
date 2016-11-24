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
        public Form1()
        {
            InitializeComponent();
            //创建Graphics对象
            g = this.CreateGraphics();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //记住线条起点
            startPoint = new Point(e.X, e.Y);
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
            }
            
            //绘制线条
            pen = new Pen(penColor, penWidth);
            g.DrawLine(pen, startPoint, cur_pos);
            //绘制母球
            g.DrawEllipse(pen, e.X - radius, e.Y - radius, radius * 2, radius * 2);

            endPoint = cur_pos; //线条结束点是鼠标当前位置   
        }
    }
}

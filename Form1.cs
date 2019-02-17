using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafikaGenryczna
{
    public partial class Form1 : Form
    {
        private Graphics ob;
        System.Drawing.Pen Pen;
        double alfa = 0.0;

        public Form1()
        {
            InitializeComponent();

            ob = this.CreateGraphics();
            Pen = new System.Drawing.Pen(System.Drawing.Color.BlueViolet);
            //ob.DrawEllipse(Pen, new Rectangle(270, 206, 50, 50));
            //ob.DrawEllipse(Pen, new Rectangle(245, 181, 100, 100));
            //ob.DrawEllipse(Pen, new Rectangle(220, 156, 150, 150));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ob.DrawEllipse(Pen, new Rectangle(270, 206, 50, 50));
            
            drawPetal(ob, Pen, alfa);
            alfa = alfa + 0.5;
        
        }

        private void drawPetal(Graphics ob, System.Drawing.Pen Pen, double angle)
        {
            // współrzędne środka okręgów
            int a = 295;
            int b = 231;

            //promienie okręgów
            int r1 = 25;
            int r2 = 50;
            int r3 = 75;

            double angle2 = angle - 0.25;
            double angle3 = angle + 0.25;

            double cosinusAngle = Math.Cos(angle);
            double sinusAngle = Math.Sin(angle);

            System.Drawing.PointF point2 = new PointF((int)((double)a + (double)r1 * cosinusAngle), (int)((double)b + (double)r1 * sinusAngle));
            System.Drawing.PointF point3 = new PointF((int)((double)a + (double)r2 * Math.Cos(angle2)), (int)((double)b + (double)r2 * Math.Sin(angle2)));
            System.Drawing.PointF point4 = new PointF((int)((double)a + (double)r2 * Math.Cos(angle3)), (int)((double)b + (double)r2 * Math.Sin(angle3)));
            System.Drawing.PointF point5 = new PointF((int)((double)a + (double)r3 * cosinusAngle), (int)((double)b + (double)r3 * sinusAngle));
            System.Drawing.PointF[] points = { point2, point3, point5, point4 };
            ob.DrawPolygon(Pen, points);
        }
    }
}

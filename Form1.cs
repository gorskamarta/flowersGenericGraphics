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
        System.Drawing.Pen PenCircle;
        System.Drawing.Pen PenPetal;
        double alfa = 0.0;
        // współrzędne środka okręgów
        int a = 295;
        int b = 231;

        //promienie okręgów
        int r1 = 25;
        int r2 = 50;
        int r3 = 75;

        int countFlower = 0;

        System.Drawing.Color[] colors = new System.Drawing.Color[] {
            System.Drawing.Color.Red,
            System.Drawing.Color.Purple,
            System.Drawing.Color.Pink,
            System.Drawing.Color.Plum,
            System.Drawing.Color.OrangeRed,
            System.Drawing.Color.BlueViolet
        };
        public Form1()
        {
            InitializeComponent();

            ob = this.CreateGraphics();
            PenCircle = new System.Drawing.Pen(System.Drawing.Color.Orange);
            Random random = new Random();
            int randomNumber1 = random.Next(0, 1);
            PenPetal = new System.Drawing.Pen(colors[randomNumber1]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawPetal(ob, PenPetal, alfa);
            alfa = alfa + 0.5;
        }

        private void drawPetal(Graphics ob, System.Drawing.Pen Pen, double angle)
        {
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

        private void Circle_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            if (countFlower == 0)
            {
                ob.DrawEllipse(PenCircle, new Rectangle(a - 25, b - 25, 50, 50));

            } else
            {
                int randomNumber = random.Next(50, 450);
                a = randomNumber;
                randomNumber = random.Next(50, 450);
                b = randomNumber;
                ob.DrawEllipse(PenCircle, new Rectangle(a - 25, b - 25, 50, 50));
            }

            int randomColorNumber = random.Next(0, 5);
            PenPetal.Color = colors[randomColorNumber];
            countFlower += 1;
        }
    }
}

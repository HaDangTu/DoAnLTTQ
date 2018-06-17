using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Mh_chinh
{
    class Line
    {
        private Point start;
        private Point end;
        private Pen pen;

        public Point Start
        {
            get
            {
                return start;
            }

            set
            {
                start = value;
            }
        }
        public Point End
        {
            get
            {
                return end;
            }

            set
            {
                end = value;
            }
        }

        public Line()
        {
            Start = new Point(0, 0);
            End = new Point(0, 0);
            pen = new Pen(Color.Black);
            pen.Width = 4f;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
        }
        public Line(int start_x, int start_y, int end_x, int end_y)
        {
            pen = new Pen(Color.Black);
            pen.Width = 4f;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            start = new Point(start_x, start_y);
            end = new Point(end_x, end_y);
        }

        public double Length(Point point1, Point point2)
        {
            return (Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2)));
        }

        public void Draw_Line(Graphics g)
        {            
            g.DrawLine(pen, start, end);
        }
        //public void Clear_Line(Graphics g)
        //{
        //    pen = new Pen(new SolidBrush(Color.White));
        //    g.DrawLine(pen, start, end);
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Mh_chinh
{
    class Container
    {
        Point pos;
        Rectangle rec;
        Pen pen;

        public Point Pos
        {
            get
            {
                return pos;
            }

            set
            {
                pos = value;
            }
        }
        public Rectangle Rec
        {
            get
            {
                return rec;
            }

            set
            {
                rec = value;
            }
        }

        public Container ()
        {
            pen = new Pen(Color.Black);
            pen.Width = 2f;
            Pos = new Point(120, 120);
            Rec = new Rectangle(Pos, new Size(40, 50));
        }

        public Container(Point p, int width, int height)
        {
            pen = new Pen(Color.Black);
            pen.Width = 2f;
            Pos = p;
            Rec = new Rectangle(Pos, new Size(width, height));
        }

        public void Draw_Container(Graphics g)
        {
            g.DrawRectangle(pen, rec);
        }
    }
}

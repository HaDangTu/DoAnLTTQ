using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Mh_chinh
{
    class Node
    {
        private string info;
        private Pen pen;
        private Point pos;
        //private Point pos2;
        private Rectangle rec;
        private Line link;

        public string Info
        {
            get
            {
                return info;
            }

            set
            {
                info = value;
            }
        }
        public Pen Pen
        {
            get
            {
                return pen;
            }

            set
            {
                pen = value;
            }
        }
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

        internal Line Link
        {
            get
            {
                return link;
            }

            set
            {
                link = value;
            }
        }

        public Node()
        {
            info = "";
            Pen = new Pen(new SolidBrush(Color.Black));
            Pos = new Point(0, 0);
            Rec = new Rectangle(Pos, new Size(80, 40));
            Link = new Line();

        }
        public Node(string str, int x, int y)
        {
            Info = str;
            Pen = new Pen(new SolidBrush(Color.Black));
            Pos = new Point(x, y);
            Rec = new Rectangle(Pos, new Size(80, 40));
            Link = new Line();
        }
        public Node(string str, Point p)
        {
            info = str;
            pos = p;
            rec = new Rectangle(pos.X, pos.Y, 80, 40);
            link = new Line();
            pen = new Pen(Color.Black);
        }

        public Node(string str, Point p, int start_x, int start_y, int end_x, int end_y)
        {
            info = str;
            pos = p;
            rec = new Rectangle(pos.X, pos.Y, 80, 40);
            link = new Line(start_x, start_y, end_x, end_y);
            pen = new Pen(Color.Black);
        }

        public void Draw_Node(Graphics g)
        {
            g.DrawString(info, new Font("Arial", 14),
               new SolidBrush(Color.Black), Rec);
            g.DrawRectangle(pen, Rec);
            if (Link.Start != Link.End)
                Link.Draw_Line(g);

        }

        //public void Clear_node(Graphics g)
        //{
        //    pen = new Pen(new SolidBrush(Color.White));
        //    g.DrawString(Info, new Font("Arial", 14),
        //       new SolidBrush(Color.White), Rec);
        //    g.DrawRectangle(pen, Rec);           
        //    //Link.Clear_Line(g);
        //}
    }
}

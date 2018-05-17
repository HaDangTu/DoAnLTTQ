using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mh_chinh
{
    public partial class FrmStack : Form
    {
        List<Node> myListNode;
        Node Head;
        Node Tail;
        int speed;
        public FrmStack()
        {
            InitializeComponent();
            DoubleBuffered = true;
            myListNode = new List<Node>();
            speed = 10;
            //Khởi tạo head, tail
            Head = new Node("Head", 120, 120);
            Tail = new Node("Tail", 120, 400);
        }

        public void Init(object sender, PaintEventArgs pea)
        {
            Head.Draw_Node(pea.Graphics);
            Tail.Draw_Node(pea.Graphics);
        }

        private void FrmStack_Load(object sender, EventArgs e)
        {
            Paint += new PaintEventHandler(Init);
        }

        //Kiểm tra dữ liệu nhập
        private bool Check(string m)
        {
            if (m.Trim() == "") return false;
            return true;
        }
        private void btPush_Click(object sender, EventArgs e)
        {
            if (Check(tbInput.Text))
            {

                Node node = new Node(tbInput.Text, new Point(240, 120));
                myListNode.Add(node);


                Paint += new PaintEventHandler(Push);
                Timer timer1 = new Timer();
                timer1.Enabled = true;
                timer1.Interval = 60;
                timer1.Tick += new EventHandler(TimerPush1_Tick);
            }
            else MessageBox.Show("Thông tin Node bị thiếu");
        }

        public void Push(object sender, PaintEventArgs pea)
        {
            int i;
            for (i = 0; i < myListNode.Count; i++)
                myListNode[i].Draw_Node(pea.Graphics);
        }

        private void TimerPush1_Tick(object sender, EventArgs e)
        {

            Timer t = (Timer)sender;
            if (myListNode.Count > 1)
            {
                myListNode[myListNode.Count - 1].Link.Start = new Point(myListNode[myListNode.Count - 1].Pos.X + myListNode[myListNode.Count - 1].Rec.Width,
                  myListNode[myListNode.Count - 1].Pos.Y + myListNode[myListNode.Count - 1].Rec.Height / 2);
                myListNode[myListNode.Count - 1].Link.End = new Point(myListNode[myListNode.Count - 2].Pos.X,
                    myListNode[myListNode.Count - 2].Pos.Y + myListNode[myListNode.Count - 2].Rec.Height / 2);

                Head.Link.Start = new Point(Head.Pos.X + Head.Rec.Width / 2, Head.Pos.Y + Head.Rec.Height);
                Tail.Link.Start = new Point(Tail.Pos.X + Tail.Rec.Width / 2, Tail.Pos.Y);
                Invalidate();
                t.Stop();

                Timer timer2 = new Timer();
                timer2.Interval = 60;
                timer2.Enabled = true;
                timer2.Tick += new EventHandler(timerPush2_Tick);
            }
            else
            {
                Head.Link.Start = new Point(Head.Pos.X + Head.Rec.Width / 2, Head.Pos.Y + Head.Rec.Height);
                Head.Link.End = new Point(myListNode[myListNode.Count - 1].Pos.X + myListNode[myListNode.Count - 1].Rec.Width / 2,
                    myListNode[myListNode.Count - 1].Pos.Y);

                Tail.Link.Start = new Point(Tail.Pos.X + Tail.Rec.Width / 2, Tail.Pos.Y);
                Tail.Link.End = new Point(myListNode[myListNode.Count - 1].Pos.X + myListNode[myListNode.Count - 1].Rec.Width / 2,
                    myListNode[myListNode.Count - 1].Pos.Y + myListNode[myListNode.Count - 1].Rec.Height);

                Invalidate();
                t.Stop();

                Timer timer2 = new Timer();
                timer2.Interval = 60;
                timer2.Enabled = true;
                timer2.Tick += new EventHandler(timerPush4_Tick);
            }
        }

        public void timerPush2_Tick(object sender, EventArgs e)
        {
            Timer t = (Timer)sender;

            Head.Link.End = new Point(myListNode[myListNode.Count - 1].Pos.X + myListNode[myListNode.Count - 1].Rec.Width / 2,
                myListNode[myListNode.Count - 1].Pos.Y);

            t.Stop();

            Timer timer2 = new Timer();
            timer2.Interval = 60;
            timer2.Enabled = true;
            timer2.Tick += new EventHandler(timerPush3_Tick);
            Invalidate();
        }

        private void timerPush3_Tick(object sender, EventArgs e)
        {
            Timer t = (Timer)sender;
            int i;
            if (myListNode[0].Pos.X < myListNode.Count * 120)
            {

                //myListNode[0] = new Node(myListNode[0].Info,
                //     new Point(myListNode[0].Pos.X + speed, myListNode[0].Pos.Y));

                for (i = myListNode.Count - 2; i > 0; i--)
                {
                    //thay đổi vị trí của node theo myLisNode[i] = myListNode[i - 1]
                    //Lưu ý: Nếu áp dụng theo công thức trên thì info của node myListNode[i] sẽ thay đổi theo giá trị info của 
                    //myListNode[i - 1] nên ta sẽ sử dụng theo cách ở bên dưới

                    myListNode[i] = new Node(myListNode[i].Info,
                     new Point(myListNode[i - 1].Pos.X - 120 + speed, myListNode[i - 1].Pos.Y));//số 120 là (chiều dài của node + chiều dài đường mũi tên giữa hai node)

                    myListNode[i].Link.Start = new Point(myListNode[i].Pos.X + myListNode[i].Rec.Width,
                        myListNode[i].Pos.Y + myListNode[i].Rec.Height / 2);

                    myListNode[i].Link.End = new Point(myListNode[i - 1].Pos.X + speed,
                       myListNode[i].Pos.Y + myListNode[i].Rec.Height / 2);


                }

                myListNode[0] = new Node(myListNode[0].Info,
                     new Point(myListNode[0].Pos.X + speed, myListNode[0].Pos.Y));


                Head.Link.End = new Point(myListNode[myListNode.Count - 1].Pos.X + myListNode[myListNode.Count - 1].Rec.Width / 2,
                    myListNode[myListNode.Count - 1].Pos.Y);

                myListNode[myListNode.Count - 1].Link.End = new Point(myListNode[myListNode.Count - 2].Pos.X,
                    myListNode[myListNode.Count - 2].Pos.Y + myListNode[myListNode.Count - 2].Rec.Height / 2);

                //Thiết lập vị trí mũi tên của tail khi di chuyển danh sách về phía sau
                Tail.Link.Start = new Point(Tail.Pos.X + Tail.Rec.Width / 2, Tail.Pos.Y);
                Tail.Link.End = new Point(myListNode[0].Pos.X + myListNode[0].Rec.Width / 2,
                    myListNode[0].Pos.Y + myListNode[0].Rec.Height);
                Invalidate();
            }
            else
            {
                t.Stop();

                Timer timer3 = new Timer();
                timer3.Interval = 60;
                timer3.Tick += new EventHandler(timerPush4_Tick);
                timer3.Enabled = true;
            }
        }

        private void timerPush4_Tick(object sender, EventArgs e)
        {
            Timer t = (Timer)sender;
            if (myListNode.Count > 1)
            {
                myListNode[myListNode.Count - 1] = new Node(myListNode[myListNode.Count - 1].Info,
                  new Point(120, 260));

                myListNode[myListNode.Count - 1].Link.Start = new Point(myListNode[myListNode.Count - 1].Pos.X + myListNode[myListNode.Count - 1].Rec.Width,
                      myListNode[myListNode.Count - 1].Pos.Y + myListNode[myListNode.Count - 1].Rec.Height / 2);
                myListNode[myListNode.Count - 1].Link.End = new Point(myListNode[myListNode.Count - 2].Pos.X,
                    myListNode[myListNode.Count - 2].Pos.Y + myListNode[myListNode.Count - 2].Rec.Height / 2);

                Head.Link.End = new Point(myListNode[myListNode.Count - 1].Pos.X + myListNode[myListNode.Count - 1].Rec.Width / 2,
                   myListNode[myListNode.Count - 1].Pos.Y);
            }
            else
            {
                myListNode[myListNode.Count - 1] = new Node(myListNode[myListNode.Count - 1].Info,
                  new Point(120, 260));
                Head.Link.Start = new Point(Head.Pos.X + Head.Rec.Width / 2, Head.Pos.Y + Head.Rec.Height);
                Head.Link.End = new Point(myListNode[myListNode.Count - 1].Pos.X + myListNode[myListNode.Count - 1].Rec.Width / 2,
                    myListNode[myListNode.Count - 1].Pos.Y);
                Tail.Link.Start = new Point(Tail.Pos.X + Tail.Rec.Width / 2, Tail.Pos.Y);
                Tail.Link.End = new Point(myListNode[myListNode.Count - 1].Pos.X + myListNode[myListNode.Count - 1].Rec.Width / 2,
                    myListNode[myListNode.Count - 1].Pos.Y + myListNode[myListNode.Count - 1].Rec.Height);
            }
            Invalidate();
            t.Stop();
        }
        //Pop
        private void btPop_Click(object sender, EventArgs e)
        {
            if (myListNode.Count > 0)
            {
                tbPopVal .Text = myListNode[myListNode.Count - 1].Info;
                myListNode.RemoveAt(myListNode.Count - 1);

                Timer timer = new Timer();
                timer.Interval = trbAniSpeed.Value;
                timer.Enabled = true;
                timer.Tick += new EventHandler(timerPop_Tick);
                Paint += new PaintEventHandler(Pop);
            }
            else MessageBox.Show("Queue trống");
        }

        public void Pop(object sender, PaintEventArgs pea)
        {
            int i;
            if (myListNode.Count != 0)
                for (i = myListNode.Count - 1; i >= 0; i--)
                    myListNode[i].Draw_Node(pea.Graphics);
        }

        public void timerPop_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            if (myListNode.Count > 0)
            {
                //Thiết lập vị trí mũi tên của Head đến vị trí node Head mới
                Head.Link.Start = new Point(Head.Pos.X + Head.Rec.Width / 2, Head.Pos.Y + Head.Rec.Width / 2);
                Head.Link.End = new Point(myListNode[myListNode.Count - 1].Pos.X + myListNode[myListNode.Count - 1].Rec.Width / 2,
                    myListNode[myListNode.Count - 1].Pos.Y);
                Invalidate();
                timer.Stop();

                //Dịch chuyển các node sau khi đã xóa node đầu
                Timer timer1 = new Timer();
                timer1.Interval = trbAniSpeed.Value;
                timer1.Enabled = true;
                timer1.Tick += new EventHandler(timerPop1_Tick);
            }
            else
            {
                Head.Link.End = Head.Link.Start;
                Tail.Link.End = Tail.Link.Start;
                Invalidate();
            }
        }

        public void timerPop1_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            int temp = myListNode[myListNode.Count - 1].Pos.X;
            //Dịch chuyển node về phía trước
            if (temp > 120)
            {
                int i;
                for (i = 0; i < myListNode.Count - 1; i++)
                {
                    myListNode[i] = new Node(myListNode[i].Info,
                         new Point(myListNode[i + 1].Pos.X + 120, myListNode[i + 1].Pos.Y));

                    myListNode[i].Link.Start = new Point(myListNode[i + 1].Pos.X + myListNode[i + 1].Rec.Width,
                          myListNode[i].Pos.Y + myListNode[i].Rec.Height / 2);
                    myListNode[i].Link.End = new Point(myListNode[i].Pos.X,
                       myListNode[i].Pos.Y + myListNode[i].Rec.Height / 2);
                }
                //Thiết lập vị trí cho node myListNode[myListNode.Count - 1]
                temp -= speed;
                myListNode[myListNode.Count - 1] = new Node(myListNode[myListNode.Count - 1].Info,
                    new Point(temp, myListNode[myListNode.Count - 1].Pos.Y));

                //Thiết lập vị trí mũi tên của head 
                Head.Link.Start = new Point(Head.Pos.X + Head.Rec.Width / 2, Head.Pos.Y + Head.Rec.Width / 2);
                Head.Link.End = new Point(myListNode[myListNode.Count - 1].Pos.X + myListNode[myListNode.Count - 1].Rec.Width / 2,
                    myListNode[myListNode.Count - 1].Pos.Y);

                //thiết lập vị trí mũi tên của tail
                Tail.Link.Start = new Point(Tail.Pos.X + Tail.Rec.Width / 2, Tail.Pos.Y);
                Tail.Link.End = new Point(myListNode[0].Pos.X + myListNode[0].Rec.Width / 2,
                    myListNode[0].Pos.Y + myListNode[0].Rec.Height);
                Invalidate();
            }
            else
                timer.Stop();
        }
    }
}

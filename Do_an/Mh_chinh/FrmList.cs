using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Mh_chinh
{

    public partial class FrmList : Form
    {
        List<Node> myListNode;
        Node Head;
        Node Tail;
        int speed;
        int index;
        bool flag = false; 
        int collison; //Xác định node đang kéo thả
        public FrmList()
        {
            InitializeComponent();
            DoubleBuffered = true;
            myListNode = new List<Node>();
            speed = 10;
            //Khởi tạo head, tail
            Head = new Node("Head", 120, 40);
            Tail = new Node("Tail", 120, 320);
            panelDraw.Paint += new PaintEventHandler(Draw_LinkList);
        }
       

        public void Mh_Stack_Load(object sender, EventArgs e)
        {

            panelDraw.Paint += new PaintEventHandler(Init);
        }

        public void Init(object sender, PaintEventArgs pea)
        {
            Head.Draw_Node(pea.Graphics);
            Tail.Draw_Node(pea.Graphics);
        }

        //Kiểm tra dữ liêu Nhập
        private bool Check(string m)
        {
            if (m.Trim() == "") return false;
            return true;
        }
        //Tìm kiếm vị trí node có thông tin được nhập từ textbox Index
        private int Find_Node(string str)
        {
            int i;
            for (i = 0; i < myListNode.Count; i++)
                if (myListNode[i].Info == str) return i;
            return 0;
        }
        //Kiểm tra node đã có trong danh sách hay chưa
        private bool isValidNode(string str)
        {
            int i;
            for (i = 0; i < myListNode.Count; i++)
                if (myListNode[i].Info == str) return false;
            return true;
        }
        public void Draw_LinkList(object sender, PaintEventArgs pea)
        {
            int i;
            for (i = 0; i < myListNode.Count; i++)
                myListNode[i].Draw_Node(pea.Graphics);
        }

        //Thêm node đầu  danh sách liên kết

        // Scroll panel
        public void AutoResizePanel ()
        {
            if (myListNode.Count > 1)
            {
                while (myListNode[0].Pos.X + myListNode[0].Rec.Width >= panelDraw.Width - 80) //chỉnh kích thước panel vẽ
                    panelDraw.Width = panelDraw.Width + 120;
            }
        }
        private void btAddFirst_Click(object sender, EventArgs e)
        {

            if (Check(tbInput.Text) == true && isValidNode (tbInput.Text) == true)
            {
                AutoResizePanel();
                Node node = new Node(tbInput.Text, new Point(240, 40));
                myListNode.Add(node);


                //panelDraw.Paint += new PaintEventHandler(Draw_LinkList);
                Timer timer1 = new Timer();
                timer1.Enabled = true;
                timer1.Interval = trbAniSp.Value;
                timer1.Tick += new EventHandler(TimerAddFirst1_Tick);
            }
            else MessageBox.Show("Thông tin Node bị thiếu hoặc Node đã có trong danh sách");
        }

        public void TimerAddFirst1_Tick(object sender, EventArgs e)
        {
            Timer t = (Timer)sender;
            if (myListNode.Count > 1)
            {
                myListNode[myListNode.Count - 1].Link.Start = new Point(myListNode[myListNode.Count - 1].Pos.X +
                    myListNode[myListNode.Count - 1].Rec.Width,
                  myListNode[myListNode.Count - 1].Pos.Y + myListNode[myListNode.Count - 1].Rec.Height / 2);

                myListNode[myListNode.Count - 1].Link.End = new Point(myListNode[myListNode.Count - 2].Pos.X,
                    myListNode[myListNode.Count - 2].Pos.Y + myListNode[myListNode.Count - 2].Rec.Height / 2);               
            }
            else
            {
                Head.Link.Start = new Point(Head.Pos.X + Head.Rec.Width / 2, Head.Pos.Y + Head.Rec.Height);
                Head.Link.End = new Point(myListNode[0].Pos.X + myListNode[0].Rec.Width / 2, myListNode [0].Pos.Y);
                                  
                Tail.Link.Start = new Point(Tail.Pos.X + Tail.Rec.Width / 2, Tail.Pos.Y);
                Tail.Link.End = new Point(myListNode[0].Pos.X + myListNode[0].Rec.Width / 2,
                    myListNode[0].Pos.Y + myListNode[0].Rec.Height);             
            }
            panelDraw.Invalidate();
            t.Stop();

            Timer timer2 = new Timer();
            timer2.Interval = trbAniSp.Value;
            timer2.Enabled = true;
            timer2.Tick += new EventHandler(timerAddFirst2_Tick);
        }

        public void timerAddFirst2_Tick(object sender, EventArgs e)
        {
            //Thay đổi mũi tên của con trỏ head đến node đầu tiên trong list
            Timer t = (Timer)sender;

            Head.Link.End = new Point(myListNode[myListNode.Count - 1].Pos.X + myListNode[myListNode.Count - 1].Rec.Width / 2,
                myListNode[myListNode.Count - 1].Pos.Y);

            Tail.Link.End = new Point(myListNode[0].Pos.X + myListNode[0].Rec.Width / 2,
                    myListNode[0].Pos.Y + myListNode[0].Rec.Height);
            t.Stop();

            Timer timer2 = new Timer();
            timer2.Interval = trbAniSp.Value;
            timer2.Enabled = true;
            timer2.Tick += new EventHandler(timerAddFirst3_Tick);
            panelDraw.Invalidate();
        }

        public void timerAddFirst3_Tick(object sender, EventArgs e)
        {
            Timer t = (Timer)sender;
            int i;
                if (myListNode[0].Pos.X < myListNode.Count * 120)
                {
                    for (i = 0; i < myListNode.Count - 1; i++)
                    {
                        myListNode[i] = new Node(myListNode[i].Info,
                         new Point(myListNode[i].Pos.X + speed, myListNode[i].Pos.Y),
                         myListNode[i].Link.Start.X + speed, myListNode[i].Link.Start.Y,
                         myListNode[i].Link.End.X + speed, myListNode[i].Link.End.Y);
                    }

                    myListNode[myListNode.Count - 1].Link.End = new Point(myListNode[myListNode.Count - 2].Pos.X,
                        myListNode[myListNode.Count - 2].Rec.Height / 2 + myListNode[myListNode.Count - 2].Pos.Y);

                    Head.Link.End = new Point(myListNode[myListNode.Count - 1].Pos.X + myListNode[myListNode.Count - 1].Rec.Width / 2,
                        myListNode[myListNode.Count - 1].Pos.Y);

                    Tail.Link.End = new Point(myListNode[0].Pos.X + myListNode[0].Rec.Width / 2,
                        myListNode[0].Pos.Y + myListNode[0].Rec.Height);
                }
                else
                {
                    t.Stop();
                    Timer timer3 = new Timer();
                    timer3.Interval = trbAniSp.Value;
                    timer3.Tick += new EventHandler(timerAddFirst4_Tick);
                    timer3.Enabled = true;
                }
              
            panelDraw.Invalidate();
        }

        public void timerAddFirst4_Tick(object sender, EventArgs e)
        {
            Timer t = (Timer)sender;
            if (myListNode.Count > 1)
            {
                myListNode[myListNode.Count - 1] = new Node(myListNode[myListNode.Count - 1].Info,
                  new Point(120, 180));

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
                  new Point(120, 180));
                
                Head.Link.End = new Point(myListNode[myListNode.Count - 1].Pos.X + myListNode[myListNode.Count - 1].Rec.Width / 2,
                    myListNode[myListNode.Count - 1].Pos.Y);
                
                Tail.Link.End = new Point(myListNode[myListNode.Count - 1].Pos.X + myListNode[myListNode.Count - 1].Rec.Width / 2,
                    myListNode[myListNode.Count - 1].Pos.Y + myListNode[myListNode.Count - 1].Rec.Height);
            }
            panelDraw.Invalidate();
            tbInput.Text = String.Empty;
            t.Stop();
        }

        //Xóa node đầu trong danh sách liên kết
        private void btDelFst_Click(object sender, EventArgs e)
        {
            if (myListNode.Count > 0)
            {
                //panelDraw.Paint += new PaintEventHandler(Draw_LinkList);
                Timer timer = new Timer();
                timer.Interval = trbAniSp.Value;
                timer.Enabled = true;
                timer.Tick += new EventHandler(timerDelFirst1_Tick);

            }
            else MessageBox.Show("Danh sách trống");
        }

        private void timerDelFirst1_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            if (myListNode.Count > 1)
            {
                //đưa vị trí con trỏ head về node myListNode[myListNode.Count - 2]             
                Head.Link.End = new Point(myListNode[myListNode.Count - 2].Pos.X + myListNode[myListNode.Count - 2].Rec.Width / 2,
                    myListNode[myListNode.Count - 2].Pos.Y);                
            }
            else
            {
                Head.Link.End = Head.Link.Start;
                Tail.Link.End = Tail.Link.Start;                
            }
            panelDraw.Invalidate();
            timer.Stop();

            Timer timer1 = new Timer();
            timer1.Interval = trbAniSp.Value;
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timerDelFirst2_Tick);
        }

        private void timerDelFirst2_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            //xóa liên kết giữa myListNode[myListNode.Count - 1] và myListNode[myListNode.Count - 2]

            myListNode[myListNode.Count - 1].Link.End = myListNode[myListNode.Count - 1].Link.Start;
            panelDraw.Invalidate();
            timer.Stop();

            Timer timer3 = new Timer();
            timer3.Interval = trbAniSp.Value;
            timer3.Enabled = true;
            timer3.Tick += new EventHandler(timerDelFirst3_Tick);

        }

        private void timerDelFirst3_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            //Xóa myListNode[myListNode.Count - 1] trong mảng myListNode
            myListNode.RemoveAt(myListNode.Count - 1);
            panelDraw.Invalidate();
            timer.Stop();

            Timer timer4 = new Timer();
            timer4.Interval = trbAniSp.Value;
            timer4.Enabled = true;
            timer4.Tick += new EventHandler(timerDelFirst4_Tick);

            
        }

        private void timerDelFirst4_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            if (myListNode.Count > 0)
            {
                if (myListNode[myListNode.Count - 1].Pos.X > 120)
                {
                    int i;
                    for (i = 0; i < myListNode.Count; i++)
                    {
                        myListNode[i] = new Node(myListNode[i].Info,
                            new Point(myListNode[i].Pos.X - speed, myListNode[i].Pos.Y),
                            myListNode[i].Link.Start.X - speed, myListNode[i].Link.Start.Y,
                            myListNode[i].Link.End.X - speed, myListNode[i].Link.End.Y);
                    }

                    Head.Link.End = new Point(myListNode[myListNode.Count - 1].Pos.X + myListNode[myListNode.Count - 1].Rec.Width / 2,
                        myListNode[myListNode.Count - 1].Pos.Y);

                    Tail.Link.End = new Point(myListNode[0].Pos.X + myListNode[0].Rec.Width / 2,
                        myListNode[0].Pos.Y + myListNode[0].Rec.Height);

                }
                else timer.Stop();
            }
            
            panelDraw.Invalidate();
            
        }




        //Thêm 1 node vào trước 1 node cho trước
        private void btAddBefore_Click(object sender, EventArgs e)
        {
            if (Check(tbInput.Text) == true && (Check(tbIndex.Text) == true)
                && isValidNode (tbInput.Text))
            {
                AutoResizePanel();
                Node node = new Node(tbInput.Text, new Point(240, 40));
                index = Find_Node(tbIndex.Text);
                if (index == myListNode.Count - 1) //Trường hợp cần chèn node lên đầu danh sách
                {
                    myListNode.Add(node);
                    Timer t = new Timer();
                    t.Interval = trbAniSp.Value;
                    t.Enabled = true;
                    t.Tick += new EventHandler(TimerAddFirst1_Tick);
                }
                else
                {
                    index = index + 1;
                    myListNode.Insert(index, node);
                   // panelDraw.Paint += new PaintEventHandler(Draw_LinkList);
                    index++;
                    Timer timer1 = new Timer();
                    timer1.Enabled = true;
                    timer1.Interval = 60;
                    timer1.Tick += new EventHandler(timerAddAfter1_Tick);
                }
                tbInput.Text = string.Empty;
                tbIndex.Text = string.Empty;
            }
            else MessageBox.Show("Lỗi nhập giá trị");
        }

        //Xóa node trước 1 node cho trước
        private void btDelBefore_Click(object sender, EventArgs e)
        {
            if (Check(tbIndex.Text) == true
                && myListNode.Count > 0)
            {
                index = Find_Node(tbIndex.Text);
                if (index == myListNode.Count - 1)
                    MessageBox.Show("Không có phần tử nào ở phía trước để xóa");
                else if (index == myListNode.Count - 2)
                {
                    Timer timer1 = new Timer();
                    timer1.Interval = trbAniSp.Value;
                    timer1.Enabled = true;
                    timer1.Tick += new EventHandler(timerDelFirst1_Tick);
                }
                else
                {
                    index += 2;

                    Timer timer1 = new Timer();
                    timer1.Interval = trbAniSp.Value;
                    timer1.Enabled = true;
                    timer1.Tick += new EventHandler(timerDelAfter1_Tick);
                    //panelDraw.Paint += new PaintEventHandler(Draw_LinkList);
                }
                tbIndex.Text = string.Empty;
            }
            else MessageBox.Show("Lỗi nhập giá trị hoặc List trống");
        }




        //Thêm 1 node vào sau 1 node cho trước
        private void btAddAfter_Click(object sender, EventArgs e)
        {
            if (Check(tbInput.Text) == true && (Check(tbIndex.Text) == true) 
                && isValidNode(tbInput.Text) == true)
            {
                AutoResizePanel();
                Node node = new Node(tbInput.Text, new Point(240, 40));
                index = Find_Node(tbIndex.Text);
                if (index == 0)
                {
                    myListNode.Insert(index, node);
                    Timer t = new Timer();
                    t.Interval = trbAniSp.Value;
                    t.Enabled = true;
                    t.Tick += new EventHandler(TimerAddLast_Tick);
                }
                else
                {
                    myListNode.Insert(index, node);

                    index++;
                    //panelDraw.Paint += new PaintEventHandler(Draw_LinkList);
                    Timer timer1 = new Timer();
                    timer1.Enabled = true;
                    timer1.Interval = trbAniSp.Value;
                    timer1.Tick += new EventHandler(timerAddAfter1_Tick);
                }
            }
            else MessageBox.Show("Lỗi nhập giá trị hoặc node đã có trong danh sách");
        }

        private void timerAddAfter1_Tick(object sender, EventArgs e)
        {
            Timer t = (Timer)sender;
           

            myListNode[index - 1].Link.Start = new Point(myListNode[index - 1].Pos.X + myListNode[index - 1].Rec.Width,
                myListNode[index - 1].Pos.Y + myListNode[index - 1].Rec.Height / 2);

            myListNode[index - 1].Link.End = new Point(myListNode[index - 2].Pos.X,
                myListNode[index - 2].Pos.Y + myListNode[index - 2].Rec.Height / 2);
            panelDraw.Invalidate();
            t.Stop();

            Timer timer2 = new Timer();
            timer2.Interval = trbAniSp .Value;
            timer2.Enabled = true;
            timer2.Tick += new EventHandler(timerAddAfter2_Tick);
        }

        private void timerAddAfter2_Tick(object sender, EventArgs e)
        {
            Timer t = (Timer)sender;
            myListNode[index].Link.End = new Point(myListNode[index - 1].Pos.X,
               myListNode[index - 1].Pos.Y + myListNode[index - 1].Rec.Height / 2);

            panelDraw.Invalidate();
            t.Stop();

            Timer timer3 = new Timer();
            timer3.Interval = trbAniSp .Value;
            timer3.Enabled = true;
            timer3.Tick += new EventHandler(timerAddAfter3_Tick);
        }

        private void timerAddAfter3_Tick(object sender, EventArgs e)
        {
            Timer t = (Timer)sender;
            if (myListNode[0].Pos.X < myListNode.Count * 120)
            {
                int i;
                for (i = 0; i < index - 1; i++)
                {
                    myListNode[i] = new Node(myListNode[i].Info,
                        new Point(myListNode[i].Pos.X + speed, myListNode[i].Pos.Y),
                        myListNode[i].Link.Start.X + speed, myListNode[i].Link.Start.Y,
                        myListNode[i].Link.End.X + speed, myListNode[i].Link.End.Y);
                }

                myListNode[index - 1].Link.End = new Point(myListNode[index - 2].Pos.X,
                    myListNode[index - 2].Pos.Y + myListNode[index - 2].Rec.Height / 2);
                Tail.Link.End = new Point(myListNode[0].Pos.X + myListNode[0].Rec.Width / 2,
                    myListNode[0].Pos.Y + myListNode[0].Rec.Height);


                panelDraw.Invalidate();
            }
            else
            {
                t.Stop();
                Timer timer4 = new Timer();
                timer4.Interval = trbAniSp .Value;
                timer4.Enabled = true;
                timer4.Tick += timerAddAfter4_Tick;
            }
        }

        private void timerAddAfter4_Tick(object sender, EventArgs e)
        {
            Timer t = (Timer)sender;
            myListNode[index - 1] = new Node(myListNode[index - 1].Info,
            new Point(myListNode[index].Pos.X + 120, myListNode[index].Pos.Y));

            myListNode[index].Link.End = new Point(myListNode[index - 1].Pos.X, 
                myListNode[index - 1].Pos.Y + myListNode[index - 1].Rec.Height / 2);

            myListNode[index - 1].Link.Start = new Point(myListNode[index - 1].Pos.X + myListNode[index - 1].Rec.Width,
                myListNode[index - 1].Pos.Y + myListNode[index - 1].Rec.Height / 2);
            myListNode[index - 1].Link.End = new Point(myListNode[index - 2].Pos.X,
                myListNode[index - 2].Pos.Y + myListNode[index - 2].Rec.Height  / 2);
            panelDraw.Invalidate();
            t.Stop();
            tbIndex.Text = string.Empty;
            tbInput.Text = string.Empty;
        }

        //Xóa 1 node sau 1 node cho trước
        private void btDelAfter_Click(object sender, EventArgs e)
        {
            if (Check(tbIndex .Text) == true)
            {
                index = Find_Node(tbIndex.Text);
                if (index == 0)
                    MessageBox.Show("Không còn node nào phía sau của node cần xóa");    
                else if (index == 1)
                {
                    Timer timer1 = new Timer();
                    timer1.Interval = trbAniSp.Value;
                    timer1.Enabled = true;
                    timer1.Tick += new EventHandler(timerDelLast1_Tick);
                }           
                else
                {
                    Timer timer1 = new Timer();
                    timer1.Interval = trbAniSp.Value;
                    timer1.Enabled = true;
                    timer1.Tick += new EventHandler(timerDelAfter1_Tick);
                    //panelDraw.Paint += new PaintEventHandler(Draw_LinkList);
                }
            }else MessageBox.Show("Thông tin node cần xóa phía sau bị trống");
        }

        private void timerDelAfter1_Tick(object sender, EventArgs e)
        {
            Timer t = (Timer)sender;
            myListNode[index].Link.End = new Point(myListNode[index - 2].Pos.X,
                myListNode[index - 2].Pos.Y + myListNode[index - 2].Rec.Height / 2);
            panelDraw.Invalidate();
            t.Stop();

            Timer timer2 = new Timer();
            timer2.Interval = trbAniSp .Value;
            timer2.Enabled = true;
            timer2.Tick += new EventHandler(timerDelAfter2_Tick);
        }

        private void timerDelAfter2_Tick(object sender, EventArgs e)
        {
            Timer t = (Timer)sender;
            myListNode[index - 1].Link.End = myListNode[index - 1].Link.Start;
            panelDraw.Invalidate();
            t.Stop();

            Timer timer3 = new Timer();
            timer3.Interval = trbAniSp.Value;
            timer3.Enabled = true;
            timer3.Tick += new EventHandler(timerDelAfter3_Tick);
        }

        private void timerDelAfter3_Tick (object sender, EventArgs e)
        {
            Timer t = (Timer)sender;
            myListNode.RemoveAt(index - 1);
            index--;
            panelDraw.Invalidate();
            t.Stop();

            Timer timer4 = new Timer();
            timer4.Interval = trbAniSp.Value;
            timer4.Enabled = true;
            timer4.Tick += new EventHandler(timerDelAfter4_Tick); 
        }

        private void timerDelAfter4_Tick(object sender, EventArgs e)
        {
            Timer t = (Timer)sender;
            int i;
            if (myListNode[index - 1].Pos.X > myListNode[index].Pos.X + 120)
            {
                for (i = 0; i <= index - 1; i++)
                {
                    myListNode[i] = new Node(myListNode[i].Info,
                         new Point(myListNode[i].Pos.X - speed, myListNode[i + 1].Pos.Y),
                         myListNode[i].Link.Start.X - speed, myListNode [i].Link.Start.Y, 
                         myListNode[i].Link.End.X - speed, myListNode[i].Link.End.Y);
                }

                //myListNode[index - 1] = new Node(myListNode[index - 1].Info,
                //     new Point(myListNode[index - 1].Pos.X - speed, myListNode[index - 1].Pos.Y));

                myListNode[index].Link.End = new Point(myListNode[index - 1].Pos.X,
                    myListNode[index - 1].Pos.Y + myListNode[index - 1].Rec.Height / 2);

                Tail.Link.End = new Point(myListNode[0].Pos.X + myListNode[0].Rec.Width / 2,
                    myListNode[0].Pos.Y + myListNode[0].Rec.Height);
                panelDraw.Invalidate();
                tbIndex.Text = string.Empty;
            }
            else t.Stop();
        }




        //Thêm node cuối
        private void btAddLast_Click(object sender, EventArgs e)
        {
            if (Check(tbInput.Text))
            {
                AutoResizePanel();
                if (myListNode.Count == 0)
                {
                    Node node = new Node(tbInput.Text, new Point(0, 260));
                    //myListNode.Add(node);
                    myListNode.Insert(0, node);
                }
                else
                {

                    Node node = new Node(tbInput.Text,
                        new Point(myListNode[0].Pos.X - myListNode.Count * 120, myListNode[0].Pos.Y));
                    //myListNode.Add(node);
                    
                    myListNode.Insert(0, node);
                }

                Timer timer1 = new Timer();
                timer1.Enabled = true;
                timer1.Interval = trbAniSp .Value;
                timer1.Tick += new EventHandler(TimerAddLast_Tick);
            }
            else MessageBox.Show("Thông tin Node bị thiếu");
        }

        private void TimerAddLast_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;


            int temp = myListNode[0].Pos.X;
            if (temp < myListNode.Count * 120)
            {
                for (int i = myListNode.Count; i > 1; i--)
                {
                    myListNode[i - 1].Link.Start = new Point(myListNode[i - 1].Pos.X + myListNode[i - 1].Rec.Width, myListNode[i - 1].Pos.Y + myListNode[i - 1].Rec.Height / 2);
                    myListNode[i - 1].Link.End = new Point(myListNode[i - 2].Pos.X, myListNode[i - 2].Pos.Y + myListNode[i - 2].Rec.Height / 2);
                }

                //thay đổi vị trí của myListNode[0]
                temp += speed;
                myListNode[0] = new Node(myListNode[0].Info,
                    new Point(temp, myListNode[0].Pos.Y));

                //Head

                Head.Link.Start = new Point(Head.Pos.X + 40, Head.Pos.Y + 40);
                Head.Link.End = new Point(myListNode[myListNode.Count - 1].Pos.X + 40, myListNode[myListNode.Count - 1].Pos.Y);

                //Thiết lập vị trí mũi tên của tail khi di chuyển danh sách về phía sau
                Tail.Link.Start = new Point(Tail.Pos.X + Tail.Rec.Width / 2, Tail.Pos.Y);
                Tail.Link.End = new Point(myListNode[0].Pos.X + myListNode[0].Rec.Width / 2,
                    myListNode[0].Pos.Y + myListNode[0].Rec.Height);

                //Lưu ý: do hàm Add trong List chỉ thêm vào vị trí cuối của List nên đầu List sẽ là
                //phần tử myListNode[myListNode.Count - 1] và phần tử cuối của list là myListNode[0];
                panelDraw.Invalidate();
            }
            else
            {
                timer.Stop();
                Timer timer1 = new Timer();
                timer.Interval = trbAniSp .Value;
                timer.Tick += new EventHandler(timerAddLast_Tick1);
                timer.Enabled = true;
            }
        }

        private void timerAddLast_Tick1(object sender, EventArgs e)
        {
            //Tail
            Tail.Link.Start = new Point(Tail.Pos.X + 40, Tail.Pos.Y);
            Tail.Link.End = new Point(myListNode[0].Pos.X + 40, myListNode[0].Pos.Y + 40);

            Timer timer = (Timer)sender;
            timer.Stop();
            tbInput.Text = string.Empty;
            panelDraw.Invalidate();
        }

        //Xóa node cuối
        private void btDelLast_Click(object sender, EventArgs e)
        {
            if (myListNode.Count > 0)
            {
                Timer timer1 = new Timer();
                timer1.Interval = trbAniSp.Value;
                timer1.Enabled = true;
                timer1.Tick += new EventHandler(timerDelLast1_Tick);
                
            }
            else MessageBox.Show("Danh sách trống");
        }

        private void timerDelLast1_Tick(object sender, EventArgs e)
        {
            Timer t = (Timer)sender;
            if (myListNode.Count > 1)
            {
                Tail.Link.End = new Point(myListNode[1].Pos.X + myListNode[1].Rec.Width / 2,
                    myListNode[1].Pos.Y + myListNode[1].Rec.Height);
                t.Stop();

                Timer timer2 = new Timer();
                timer2.Interval = trbAniSp.Value;
                timer2.Enabled = true;
                timer2.Tick += new EventHandler(timerDelLast2_Tick);

            }
            else
            {
                Tail.Link.End = Tail.Link.Start;
                Head.Link.End = Head.Link.Start;
                t.Stop();

                Timer timer3 = new Timer();
                timer3.Interval = trbAniSp.Value;
                timer3.Enabled = true;
                timer3.Tick += new EventHandler(timerDelLast3_Tick);
            }

            panelDraw.Invalidate();
            
        }

        private void timerDelLast2_Tick(object sender, EventArgs e)
        {
            Timer t = (Timer)sender;
            myListNode[1].Link.End = myListNode[1].Link.Start;
            panelDraw.Invalidate();
            t.Stop();

            Timer timer3 = new Timer();
            timer3.Interval = trbAniSp.Value;
            timer3.Enabled = true;
            timer3.Tick += new EventHandler(timerDelLast3_Tick);
        }

        private void timerDelLast3_Tick(object sender, EventArgs e)
        {
            Timer t = (Timer)sender;
            myListNode.RemoveAt(0);
            panelDraw.Invalidate();
     
            t.Stop();
        }

        // Di chuyển node bằng kéo thả chuột
        public void OnMouseDown(object sender, MouseEventArgs e)
        {
           
            Rectangle rect = new Rectangle(e.X, e.Y, 5, 5);
            int i;
            for (i = 0; i < myListNode .Count; i++)
            {
                if (myListNode [i].Rec.IntersectsWith (rect))
                {
                    flag = true;
                    collison = i;
                    if (i > 0 && i < myListNode.Count - 1)
                    {
                        myListNode[i] = new Node(myListNode[i].Info,
                          new Point(e.X, e.Y),
                          e.X + myListNode [i].Rec.Width , e.Y + myListNode[i].Rec.Height / 2,
                          myListNode[i].Link.End.X, myListNode[i].Link.End.Y);

                        myListNode[i + 1].Link.End = new Point(myListNode[i].Pos.X,
                            myListNode[i].Pos.Y + myListNode[i].Rec.Height / 2);
                    }
                    else
                        if (i == 0)
                    {
                        myListNode[i] = new Node(myListNode[i].Info,
                          new Point(e.X, e.Y));

                        myListNode[i + 1].Link.End = new Point(myListNode[i].Pos.X,
                            myListNode[i].Pos.Y + myListNode[i].Rec.Height / 2);

                        Tail.Link.End = new Point(myListNode[0].Pos.X + myListNode[0].Rec.Width / 2,
                            myListNode[0].Pos.Y + myListNode[0].Rec.Height);
                    }
                    else
                    {
                        myListNode[i] = new Node(myListNode[i].Info,
                          new Point(e.X, e.Y),
                          e.X + myListNode [i].Rec.Width , e.Y + myListNode[i].Rec.Height / 2,
                          myListNode[i].Link.End.X, myListNode[i].Link.End.Y);

                        Head.Link.End = new Point(myListNode[myListNode.Count - 1].Pos.X + myListNode[0].Rec.Width / 2,
                            myListNode[myListNode.Count - 1].Pos.Y);
                    }
                }
            }
            panelDraw.Invalidate();
        }

        public  void OnMouseMove(object sender, MouseEventArgs e)
        {
           
            if (flag == true)
            {
                if (collison  > 0 && collison < myListNode.Count - 1)
                {
                    myListNode[collison] = new Node(myListNode[collison].Info,
                      new Point(e.X, e.Y),
                      e.X + myListNode[collison].Rec.Width, e.Y + myListNode[collison].Rec.Height / 2,
                      myListNode[collison].Link.End.X, myListNode[collison].Link.End.Y);

                    myListNode[collison + 1].Link.End = new Point(myListNode[collison].Pos.X,
                        myListNode[collison].Pos.Y + myListNode[collison].Rec.Height / 2);
                }
                else
                        if (collison == 0)
                {
                    myListNode[collison] = new Node(myListNode[collison].Info,
                          new Point(e.X, e.Y));

                    myListNode[collison + 1].Link.End = new Point(myListNode[collison].Pos.X,
                        myListNode[collison].Pos.Y + myListNode[collison].Rec.Height / 2);

                    Tail.Link.End = new Point(myListNode[0].Pos.X + myListNode[0].Rec.Width / 2,
                        myListNode[0].Pos.Y + myListNode[0].Rec.Height);
                }
                else
                {
                    myListNode[collison] = new Node(myListNode[collison].Info,
                          new Point(e.X, e.Y),
                          e.X + myListNode[collison].Rec.Width, e.Y + myListNode[collison].Rec.Height / 2,
                          myListNode[collison].Link.End.X, myListNode[collison].Link.End.Y);

                    Head.Link.End = new Point(myListNode[myListNode.Count - 1].Pos.X + myListNode[0].Rec.Width / 2,
                        myListNode[myListNode.Count - 1].Pos.Y);
                }
                panelDraw.Invalidate();
            }
            
        }

        public void OnMouseUp(object sender, MouseEventArgs e)
        {
            
            if (flag == true)
            {
                if (collison > 0 && collison < myListNode.Count - 1)
                {
                    myListNode[collison] = new Node(myListNode[collison].Info,
                      new Point(e.X, e.Y),
                      e.X + myListNode[collison].Rec.Width, e.Y + myListNode[collison].Rec.Height / 2,
                      myListNode[collison].Link.End.X, myListNode[collison].Link.End.Y);

                    myListNode[collison + 1].Link.End = new Point(myListNode[collison].Pos.X,
                        myListNode[collison].Pos.Y + myListNode[collison].Rec.Height / 2);
                }
                else
                        if (collison == 0)
                {
                    myListNode[collison] = new Node(myListNode[collison].Info,
                          new Point(e.X, e.Y));

                    myListNode[collison + 1].Link.End = new Point(myListNode[collison].Pos.X,
                        myListNode[collison].Pos.Y + myListNode[collison].Rec.Height / 2);

                    Tail.Link.End = new Point(myListNode[0].Pos.X + myListNode[0].Rec.Width / 2,
                        myListNode[0].Pos.Y + myListNode[0].Rec.Height);
                }
                else
                {
                    myListNode[collison] = new Node(myListNode[collison].Info,
                          new Point(e.X, e.Y),
                          e.X + myListNode[collison].Rec.Width, e.Y + myListNode[collison].Rec.Height / 2,
                          myListNode[collison].Link.End.X, myListNode[collison].Link.End.Y);

                    Head.Link.End = new Point(myListNode[myListNode.Count - 1].Pos.X + myListNode[0].Rec.Width / 2,
                        myListNode[myListNode.Count - 1].Pos.Y);
                }
                flag = false;
                panelDraw.Invalidate();
            }         
        }



        // Tạo mới List bằng file có sẵn
        private void btCreatNew_Click(object sender, EventArgs e)
        {
            if (myListNode.Count > 0)
                myListNode.Clear();
            using (StreamReader strreader = new StreamReader("Init.txt"))
            {
                string value;
                while ((value = strreader.ReadLine()) != null)
                {
                    myListNode.Insert(0, new Node(value,
                        new Point(myListNode.Count * 120 + 120, 180),
                        200 + myListNode.Count * 120, 200,
                        200 + myListNode.Count * 120 + 40, 200));
                }
            }
            myListNode[0] = new Node(myListNode[0].Info,
                myListNode[0].Pos,
                myListNode[0].Link.Start.X, myListNode [0].Link .Start .Y,
                myListNode[0].Link.Start.X, myListNode[0].Link.Start.Y);

            Head.Link.Start = new Point(Head.Pos.X + Head.Rec.Width / 2,
                Head.Pos.Y + Head.Rec.Height);
            Head.Link.End = new Point(myListNode[myListNode.Count - 1].Pos.X + myListNode[myListNode.Count - 1].Rec.Width / 2,
                myListNode[myListNode.Count - 1].Pos.Y);

            Tail.Link.Start = new Point(Tail.Pos.X + Tail.Rec.Width / 2, Tail.Pos.Y);
            Tail.Link.End = new Point(myListNode[0].Pos.X + myListNode[0].Rec.Width / 2,
                myListNode[0].Pos.Y + myListNode[0].Rec.Height);
            panelDraw.Invalidate();
            //panelDraw.Paint += new PaintEventHandler(Draw_LinkList);
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}

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
    public partial class FrmQueue : Form
    {
        List<Node> myQueue;
        List<Timer> myTimer;      
        int speed;       
        int max_Element;
        int index; // Xác định timer vừa dừng khi bấm nút pause
        bool flag;
        bool pause;
        Container container;
        public FrmQueue()
        {
            InitializeComponent();
            //DoubleBuffered = true;
            //SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //UpdateStyles();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | 
                ControlStyles.DoubleBuffer, true);           
            myQueue = new List<Node>();
            myTimer = new List<Timer>();
            speed = 10 ;
            max_Element = 10;
            flag = false;
            //pause = false;                       
            container = new Container(new Point(120, 40), 80, max_Element * 40);
            panelDraw.Paint += new PaintEventHandler(Init);
            panelDraw.Paint += new PaintEventHandler(Draw_Queue);
            myTimer.Add(timerEnqueue1);
            myTimer.Add(timerEnqueue2);
            myTimer.Add(timerDequeue1);
            myTimer.Add(timerDequeue2);
            myTimer.Add(timerDequeue3);
        }

        private void FrmQueue_Load(object sender, EventArgs e)
        {
            
            tbMElement.Text = max_Element.ToString();
            
        }
        
        public void Init(object sender, PaintEventArgs pea)
        {
            container.Draw_Container(pea.Graphics);
        }

        //Kiểm tra dữ liệu nhập
        private bool Check(string m)
        {
            if (m.Trim() == "") return false;
            return true;
        }
        
        private bool isValidNode(string str)
        {
            int i;
            for (i = 0; i < myQueue.Count; i++)
                if (myQueue[i].Info == str) return false;
            return true;
        }

        public void Draw_Queue(object sender, PaintEventArgs pea)
        {
            int i;
            for (i = 0; i < myQueue.Count; i++)
                myQueue[i].Draw_Node(pea.Graphics);
        }
        //Enqueue
        private void btEnqueue_Click(object sender, EventArgs e)
        {
            if (Check(tbInput.Text) == true && isValidNode(tbInput.Text) == true && 
                myQueue .Count < max_Element)
            {
                if (max_Element != Int16.Parse(tbMElement.Text))
                {
                    max_Element = Int16.Parse(tbMElement.Text);
                    container = new Container(new Point(120, 40), 80, max_Element * 40);
                    //panelDraw.Paint += new PaintEventHandler(Init);

                    while (container.Pos.Y + container.Rec.Height >= panelDraw.Height) //chỉnh kích thước panel vẽ
                        panelDraw.Height = panelDraw.Height + 40;
                }

                Node node = new Node(tbInput.Text, new Point(400, 40));
                myQueue.Add(node);
                max_Element--;
                tbMElement.Text = max_Element.ToString();

                timerEnqueue1.Interval = trbAniSpeed.Value;
                timerEnqueue1.Enabled = true;
                //panelDraw.Paint += new PaintEventHandler(Draw_Queue);
                tbInput.Text = string.Empty;
            }
            else MessageBox.Show("Thông tin thiếu hoặc node đã có trong queue");

        }
        private void timerEnqueue1_Tick(object sender, EventArgs e)
        {
            if (myQueue[myQueue.Count - 1].Pos.X > container.Pos.X)
                myQueue[myQueue.Count - 1] = new Node(myQueue[myQueue.Count - 1].Info,
                    new Point(myQueue[myQueue.Count - 1].Pos.X - speed, myQueue[myQueue.Count - 1].Pos.Y));
            else
            {
                timerEnqueue1.Enabled = false;

                timerEnqueue2.Interval = trbAniSpeed.Value;
                timerEnqueue2.Enabled = true;               
            }

            panelDraw.Invalidate();
        }

        private void timerEnqueue2_Tick(object sender, EventArgs e)
        {
            if (myQueue[myQueue.Count - 1].Pos.Y + 40 < myQueue.Count * 40 + 40)//40 là container.Pos.Y

                myQueue[myQueue.Count - 1] = new Node(myQueue[myQueue.Count - 1].Info,
                      new Point(myQueue[myQueue.Count - 1].Pos.X, myQueue[myQueue.Count - 1].Pos.Y + speed));

            else timerEnqueue2.Enabled = false;
            panelDraw.Invalidate();
        }
        //Dequeue
        private void btDequeue_Click(object sender, EventArgs e)
        {
            if (myQueue.Count > 0)
            {
                
                timerDequeue1 .Interval = trbAniSpeed.Value;
                timerDequeue1.Enabled = true;               
                //panelDraw.Paint += new PaintEventHandler(Draw_Queue);
                
                
            }
            else MessageBox.Show("Queue trống");
        }

        private void timerDequeue1_Tick(object sender, EventArgs e)
        {
            if (myQueue[0].Pos.X < 400)
                myQueue[0] = new Node(myQueue[0].Info,
                    new Point(myQueue[0].Pos.X + speed, myQueue[0].Pos.Y));
            else
            {
                timerDequeue1.Stop();

                timerDequeue2.Interval = trbAniSpeed.Value;
                timerDequeue2.Enabled = true;

            }
            panelDraw.Invalidate();
        }

        private void timerDequeue2_Tick(object sender, EventArgs e)
        {
            tbDeqVal.Text = myQueue[0].Info;
            max_Element++;
            tbMElement.Text = max_Element.ToString();
            myQueue.RemoveAt(0);

            panelDraw.Invalidate();
            timerDequeue2.Stop();


            timerDequeue3.Interval = trbAniSpeed.Value;
            timerDequeue3.Enabled = true;
        }

        private void timerDequeue3_Tick(object sender, EventArgs e)
        {
            if (myQueue.Count > 0)
            {
                if (myQueue[0].Pos.Y > container.Pos.Y)
                {
                    int i;
                    for (i = 0; i < myQueue.Count; i++)
                        myQueue[i] = new Node(myQueue[i].Info,
                            new Point(myQueue[i].Pos.X, myQueue[i].Pos.Y - speed));
                }
                else timerDequeue3.Stop();
                panelDraw.Invalidate();
            }
        }

        //Tạo mới queue bằng danh sách cho trước

        private void btCreate_Click(object sender, EventArgs e)
        {
            if (myQueue.Count > 0)
                myQueue.Clear();
             using (StreamReader stReader = new StreamReader("Init.txt"))
             {
                string value;
                while ((value = stReader.ReadLine()) != null)
                {
                    Node node = new Node(value,
                            new Point(container.Pos.X, container.Pos.Y + myQueue.Count * 40));
                    myQueue.Add(node);

                    max_Element--;
                    tbMElement.Text = max_Element.ToString();
                    panelDraw.Invalidate();
                    
                }
                
            }
            
        }
        //Kéo thả chuột
        private void panelDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (myQueue.Count > 0)
            {
                Rectangle rect = new Rectangle(e.X, e.Y, 5, 5);
                if (myQueue[0].Rec.IntersectsWith(rect))
                {
                    flag = true;
                    myQueue[0] = new Node(myQueue[0].Info,
                                new Point(e.X, e.Y));
                }
                panelDraw.Invalidate();
            }
            
        }

        private void panelDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (myQueue.Count > 0)
            {
                if (flag == true)
                {
                    myQueue[0] = new Node(myQueue[0].Info,
                                new Point(e.X, e.Y));
                    panelDraw.Invalidate();
                }
            }
            
        }

        private void panelDraw_MouseUp(object sender, MouseEventArgs e)
        {
            if (myQueue.Count > 0)
            {
                if (flag == true)
                {
                    myQueue[0] = new Node(myQueue[0].Info,
                                new Point(e.X, e.Y));
                    if (myQueue[0].Rec.IntersectsWith(container.Rec) == false)
                    {
                        timerDequeue2.Interval = trbAniSpeed.Value;
                        timerDequeue2.Enabled = true;
                    }
                    flag = false;
                }
                panelDraw.Invalidate();
            }
           
        }     
    }
}

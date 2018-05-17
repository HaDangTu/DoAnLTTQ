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
        int speed;
        bool flag;
        int max_Element;
        Container container;
        public FrmQueue()
        {
            InitializeComponent();
            DoubleBuffered = true;
            myQueue = new List<Node>();
            speed = 10 ;
            flag = false;
            max_Element = 10;
            container = new Container(new Point(120, 120), 80, max_Element * 40);
        }

        private void FrmQueue_Load(object sender, EventArgs e)
        {
            Paint += new PaintEventHandler(Init);
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
            if (Check(tbInput.Text) == true && isValidNode(tbInput.Text) == true)
            {
                Node node = new Node(tbInput.Text, new Point(400, 120));
                myQueue.Add(node);
                max_Element--;
                tbMElement.Text = max_Element.ToString();

                Timer timer1 = new Timer();
                timer1.Interval = trbAniSpeed.Value;
                timer1.Enabled = true;
                timer1.Tick += new EventHandler(timerEnqueue1_Tick);
                Paint += new PaintEventHandler(Draw_Queue);
            }
            else MessageBox.Show("Thông tin thiếu");

        }

        private void timerEnqueue1_Tick(object sender, EventArgs e)
        {

                Timer timer = (Timer)sender;
                if (myQueue[myQueue.Count - 1].Pos.X > container.Pos.X)
                    myQueue[myQueue.Count - 1] = new Node(myQueue[myQueue.Count - 1].Info,
                        new Point(myQueue[myQueue.Count - 1].Pos.X - speed, myQueue[myQueue.Count - 1].Pos.Y));
                else
                {
                    timer.Stop();
                    Timer timer2 = new Timer();
                    timer2.Interval = trbAniSpeed.Value;
                    timer2.Enabled = true;
                    timer2.Tick += new EventHandler(timerEnqueue2_Tick);
                }

                Invalidate();
    
        }
        private void timerEnqueue2_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            if (myQueue[myQueue.Count - 1].Pos.Y + 40 < myQueue.Count * 40 + 120)
            
                myQueue[myQueue.Count - 1] = new Node(myQueue[myQueue.Count - 1].Info,
                      new Point(myQueue[myQueue.Count - 1].Pos.X, myQueue[myQueue.Count - 1].Pos.Y + speed));
                
            else timer.Stop();
            
            Invalidate();
        }
        //Dequeue
        private void btDequeue_Click(object sender, EventArgs e)
        {           
            Timer timer1 = new Timer();
            timer1.Interval = trbAniSpeed.Value;
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timerDequeue1_Tick);
            Paint += new PaintEventHandler(Draw_Queue);
        }

        private void timerDequeue1_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            if (myQueue[0].Pos.X < 400)
                myQueue[0] = new Node(myQueue[0].Info,
                    new Point(myQueue[0].Pos.X + speed, myQueue[0].Pos.Y));
            else
            {
                timer.Stop();
                Timer timer2 = new Timer();
                timer2.Interval = trbAniSpeed.Value;
                timer2.Enabled = true;
                timer2.Tick += new EventHandler(timerDequeue2_Tick);
            }
            Invalidate();
        }

        public void timerDequeue2_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            tbDeqVal.Text = myQueue[0].Info;
            max_Element++;
            tbMElement.Text = max_Element.ToString();
            myQueue.RemoveAt(0);
            Invalidate();
            timer.Stop();

            Timer timer3 = new Timer();
            timer3.Interval = trbAniSpeed.Value;
            timer3.Enabled = true;
            timer3.Tick += new EventHandler(timerDequeue3_Tick);
        }

        public void timerDequeue3_Tick(object sender, EventArgs e)
        {

            Timer timer = (Timer)sender;
            if (myQueue.Count > 0)
            {
                if (myQueue[0].Pos.Y > container.Pos.Y)
                {
                    int i;
                    for (i = 0; i < myQueue.Count; i++)
                        myQueue[i] = new Node(myQueue[i].Info,
                            new Point(myQueue[i].Pos.X, myQueue[i].Pos.Y - speed));
                }
                else timer.Stop();
                Invalidate();
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Rectangle rect = new Rectangle(e.X, e.Y, 5, 5);
            if (myQueue[0].Rec .IntersectsWith (rect))
            {
                flag = true;
                myQueue[0] = new Node(myQueue[0].Info,
                            new Point(e.X, e.Y));
            }
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (flag == true)
            {
                myQueue[0] = new Node(myQueue[0].Info,
                            new Point(e.X, e.Y));
            }
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (flag == true)
            {
                myQueue[0] = new Node(myQueue[0].Info,
                            new Point(e.X, e.Y));
                if (myQueue[0].Rec.IntersectsWith (container.Rec) == false)
                { 
                    Timer timer = new Timer();
                    timer.Interval = trbAniSpeed.Value;
                    timer.Enabled = true;
                    timer.Tick += new EventHandler(timerDequeue2_Tick);
                    Paint += new PaintEventHandler(Draw_Queue);
                }
                flag = false;
            }
            Invalidate();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            using (StreamReader stReader = new StreamReader("Init.txt"))
            {
                string value;
                while ((value = stReader.ReadLine()) != null)
                {
                    Node node = new Node(value, new Point(400, 120));
                    myQueue.Add(node);

                    max_Element--;
                    tbMElement.Text = max_Element.ToString();

                    Timer timer1 = new Timer();
                    timer1.Interval = trbAniSpeed.Value;
                    timer1.Enabled = true;
                    timer1.Tick += new EventHandler(timerEnqueue1_Tick);
                    Paint += new PaintEventHandler(Draw_Queue);
                    //Node node = new Node(value,
                    //    new Point(container.Pos.X, container.Pos.Y + myQueue.Count * 40));
                    //myQueue.Add(node);

                    //max_Element--;
                    //tbMElement.Text = max_Element.ToString();

                }

            }
            
           
        }


    }
}

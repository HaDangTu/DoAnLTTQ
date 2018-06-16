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
    public partial class FrmStack : Form
    {
        List<Node> myStack;
        int speed;
        bool flag;
        int max_Element;
        Container container;
        public FrmStack()
        {
            InitializeComponent();
            //DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true);
            myStack = new List<Node>();
            speed = 10;
            flag = false;
            max_Element = 10;
            container = new Container(new Point(120, 40), 80, max_Element * 40);
        }

        public void Init(object sender, PaintEventArgs pea)
        {
            container.Draw_Container(pea.Graphics);
        }

        private void FrmStack_Load(object sender, EventArgs e)
        {
            panelDraw.Paint += new PaintEventHandler(Init);
            tbMElement.Text = max_Element.ToString();
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
            for (i = 0; i < myStack.Count; i++)
                if (myStack[i].Info == str) return false;
            return true;
        }

        public void Draw_Stack(object sender, PaintEventArgs pea)
        {
            int i;
            for (i = 0; i < myStack.Count; i++)
                myStack[i].Draw_Node(pea.Graphics);
        }

        private void btPush_Click(object sender, EventArgs e)
        {
            if (Check(tbInput.Text) == true && isValidNode(tbInput.Text) == true)
            {
                if (max_Element != Int16.Parse(tbMElement.Text))
                {
                    max_Element = Int16.Parse(tbMElement.Text);
                    container = new Container(new Point(120, 40), 80, max_Element * 40);
                    panelDraw.Paint += new PaintEventHandler(Init);

                    while (container.Pos.Y + container.Rec.Height >= panelDraw.Height) //chỉnh kích thước panel vẽ
                        panelDraw.Height = panelDraw.Height + 40;
                }

                Node node = new Node(tbInput.Text, new Point(400, 40));
                myStack.Insert(0,node);
                max_Element--;
                tbMElement.Text = max_Element.ToString();
                
                timerPush1.Interval = trbAniSpeed.Value;
                timerPush1.Enabled = true;
                
                panelDraw.Paint += new PaintEventHandler(Draw_Stack);
            }
            else MessageBox.Show("Thông tin thiếu hoặc node đã có trong stack");
        }

        private void timerPush1_Tick(object sender, EventArgs e)
        {
            if (myStack[0].Pos.X > container.Pos.X)
                myStack[0] = new Node(myStack[0].Info,
                    new Point(myStack[0].Pos.X - speed, myStack[0].Pos.Y));
            else
            {
                timerPush1.Stop();

                timerPush2.Interval = trbAniSpeed.Value;
                timerPush2.Enabled = true;
            }

            panelDraw.Invalidate();
        }

        private void timerPush2_Tick(object sender, EventArgs e)
        {
            if (myStack[0].Pos.Y + 40 < 40 - myStack.Count * 40 + container.Rec.Height + 40)//+ 40  vì myQueue.Count * 40 khi Count = 0 thì sẽ bị thiếu 1 đoạn là 40
            {
                myStack[0] = new Node(myStack[0].Info,
                    new Point(myStack[0].Pos.X, myStack[0].Pos.Y + speed));
            }
            else
                timerPush2.Stop();
            panelDraw.Invalidate();

        }

        //Pop
        private void btPop_Click(object sender, EventArgs e)
        {
            if (myStack.Count > 0)
            {              
                timerPop1.Interval = trbAniSpeed.Value;
                timerPop1.Enabled = true;
                
                panelDraw.Paint += new PaintEventHandler(Draw_Stack);
            }
            else MessageBox.Show("Stack trống");
        }

        private void timerPop1_Tick(object sender, EventArgs e)
        {
            if (myStack[0].Pos.Y > container.Pos.Y)
                myStack[0] = new Node(myStack[0].Info,
                    new Point(myStack[0].Pos.X, myStack[0].Pos.Y - speed));
            else
            {
                timerPop1.Stop();

                timerPop2.Interval = trbAniSpeed.Value;
                timerPop2.Enabled = true;

            }
            panelDraw.Invalidate();
        }

        private void timerPop2_Tick(object sender, EventArgs e)
        {
            if (myStack[0].Pos.X < 400)
                myStack[0] = new Node(myStack[0].Info,
                    new Point(myStack[0].Pos.X + speed, myStack[0].Pos.Y));
            else
            {
                timerPop2.Stop();

                timerPop3.Interval = trbAniSpeed.Value;
                timerPop3.Enabled = true;
            }
            panelDraw.Invalidate();
        }

        private void timerPop3_Tick(object sender, EventArgs e)
        {

            tbPopVal.Text = myStack[0].Info;
            max_Element++;
            tbMElement.Text = max_Element.ToString();
            myStack.RemoveAt(0);
            panelDraw.Invalidate();
            timerPop3.Stop();
        }

        //Tạo mới STACK từ file
        private void btCreate_Click(object sender, EventArgs e)
        {
            if (myStack.Count > 0)
                myStack.Clear();
            
            using (StreamReader stReader = new StreamReader("Init.txt"))
            {
                string value;
                while ((value = stReader.ReadLine()) != null)
                {
                    Node node = new Node(value,
                        new Point(container.Pos.X,
                        container.Pos.Y + container.Rec.Height - myStack.Count * 40 - 40));

                    myStack.Insert(0, node);
                    max_Element--;
                    tbMElement.Text = max_Element.ToString();
                    panelDraw.Paint += new PaintEventHandler(Draw_Stack);
                }
                
            }
            
        }

        //Pop stack bằng cách kéo thả chuột       

        private void panelDraw_MouseDown(object sender, MouseEventArgs e)
        {
            Rectangle rect = new Rectangle(e.X, e.Y, 5, 5);
            if (myStack.Count > 0)
            {
                if (myStack[0].Rec.IntersectsWith(rect))
                {
                    flag = true;
                    myStack[0] = new Node(myStack[0].Info,
                                new Point(e.X, e.Y));
                }
            }
            else MessageBox.Show("Stack trống");
            panelDraw.Invalidate();
        }

        private void panelDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (myStack.Count > 0)
            {
                if (flag == true)
                {
                    myStack[0] = new Node(myStack[0].Info,
                                new Point(e.X, e.Y));
                }
            }

            panelDraw.Invalidate();
        }

        private void panelDraw_MouseUp(object sender, MouseEventArgs e)
        {
            if (myStack.Count > 0)
            {
                if (flag == true)
                {
                    myStack[0] = new Node(myStack[0].Info,
                                new Point(e.X, e.Y));
                    if (myStack[0].Rec.IntersectsWith(container.Rec) == false)
                    {
                        
                        timerPop3.Interval = trbAniSpeed.Value;
                        timerPop3.Enabled = true;
                        panelDraw.Paint += new PaintEventHandler(Draw_Stack);
                        
                    }                    
                    flag = false;
                }              
            }
            panelDraw.Invalidate();
        }

        
    }
}

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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmList frmList = new FrmList();
            frmList.MdiParent = this;
            frmList.Show();
        }

        private void stackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStack frmStack = new FrmStack();
            frmStack.MdiParent = this;
            frmStack.Show();
        }

        private void queueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQueue frmQueue = new FrmQueue();
            frmQueue.MdiParent = this;
            frmQueue.Show();
        }
       
    }
}

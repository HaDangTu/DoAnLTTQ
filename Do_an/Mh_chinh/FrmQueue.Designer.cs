namespace Mh_chinh
{
    partial class FrmQueue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btEnqueue = new System.Windows.Forms.Button();
            this.btDequeue = new System.Windows.Forms.Button();
            this.trbAniSpeed = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDeqVal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMElement = new System.Windows.Forms.TextBox();
            this.btCreate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.timerEnqueue1 = new System.Windows.Forms.Timer(this.components);
            this.timerEnqueue2 = new System.Windows.Forms.Timer(this.components);
            this.timerDequeue1 = new System.Windows.Forms.Timer(this.components);
            this.timerDequeue2 = new System.Windows.Forms.Timer(this.components);
            this.timerDequeue3 = new System.Windows.Forms.Timer(this.components);
            this.panelScroll = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trbAniSpeed)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelScroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(47, 5);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(100, 22);
            this.tbInput.TabIndex = 1;
            // 
            // btEnqueue
            // 
            this.btEnqueue.Location = new System.Drawing.Point(47, 29);
            this.btEnqueue.Name = "btEnqueue";
            this.btEnqueue.Size = new System.Drawing.Size(75, 23);
            this.btEnqueue.TabIndex = 2;
            this.btEnqueue.Text = "Enqueue";
            this.btEnqueue.UseVisualStyleBackColor = true;
            this.btEnqueue.Click += new System.EventHandler(this.btEnqueue_Click);
            // 
            // btDequeue
            // 
            this.btDequeue.Location = new System.Drawing.Point(97, 29);
            this.btDequeue.Name = "btDequeue";
            this.btDequeue.Size = new System.Drawing.Size(75, 23);
            this.btDequeue.TabIndex = 3;
            this.btDequeue.Text = "Dequeue";
            this.btDequeue.UseVisualStyleBackColor = true;
            this.btDequeue.Click += new System.EventHandler(this.btDequeue_Click);
            // 
            // trbAniSpeed
            // 
            this.trbAniSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbAniSpeed.Location = new System.Drawing.Point(491, 588);
            this.trbAniSpeed.Maximum = 1000;
            this.trbAniSpeed.Minimum = 1;
            this.trbAniSpeed.Name = "trbAniSpeed";
            this.trbAniSpeed.Size = new System.Drawing.Size(485, 45);
            this.trbAniSpeed.TabIndex = 4;
            this.trbAniSpeed.Value = 100;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(653, 636);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Animation Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dequeue value";
            // 
            // tbDeqVal
            // 
            this.tbDeqVal.Location = new System.Drawing.Point(97, 3);
            this.tbDeqVal.Name = "tbDeqVal";
            this.tbDeqVal.ReadOnly = true;
            this.tbDeqVal.Size = new System.Drawing.Size(100, 22);
            this.tbDeqVal.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Max Element";
            // 
            // tbMElement
            // 
            this.tbMElement.Location = new System.Drawing.Point(236, 5);
            this.tbMElement.Name = "tbMElement";
            this.tbMElement.Size = new System.Drawing.Size(100, 22);
            this.tbMElement.TabIndex = 9;
            // 
            // btCreate
            // 
            this.btCreate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreate.Location = new System.Drawing.Point(236, 33);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(100, 23);
            this.btCreate.TabIndex = 10;
            this.btCreate.Text = "Create New";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbMElement);
            this.panel1.Controls.Add(this.btEnqueue);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btCreate);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 60);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tbDeqVal);
            this.panel2.Controls.Add(this.btDequeue);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(373, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 60);
            this.panel2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Enqueue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(452, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Dequeue";
            // 
            // panelDraw
            // 
            this.panelDraw.AllowDrop = true;
            this.panelDraw.Location = new System.Drawing.Point(3, 3);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(1301, 463);
            this.panelDraw.TabIndex = 15;
            this.panelDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseDown);
            this.panelDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseMove);
            this.panelDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseUp);
            // 
            // timerEnqueue1
            // 
            this.timerEnqueue1.Tick += new System.EventHandler(this.timerEnqueue1_Tick);
            // 
            // timerEnqueue2
            // 
            this.timerEnqueue2.Tick += new System.EventHandler(this.timerEnqueue2_Tick);
            // 
            // timerDequeue1
            // 
            this.timerDequeue1.Tick += new System.EventHandler(this.timerDequeue1_Tick);
            // 
            // timerDequeue2
            // 
            this.timerDequeue2.Tick += new System.EventHandler(this.timerDequeue2_Tick);
            // 
            // timerDequeue3
            // 
            this.timerDequeue3.Tick += new System.EventHandler(this.timerDequeue3_Tick);
            // 
            // panelScroll
            // 
            this.panelScroll.AutoScroll = true;
            this.panelScroll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelScroll.Controls.Add(this.panelDraw);
            this.panelScroll.Location = new System.Drawing.Point(12, 99);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(1326, 483);
            this.panelScroll.TabIndex = 0;
            // 
            // FrmQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 654);
            this.Controls.Add(this.trbAniSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelScroll);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FrmQueue";
            this.Text = "FrmQueue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmQueue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbAniSpeed)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelScroll.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btEnqueue;
        private System.Windows.Forms.Button btDequeue;
        private System.Windows.Forms.TrackBar trbAniSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDeqVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMElement;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timerEnqueue1;
        private System.Windows.Forms.Timer timerEnqueue2;
        private System.Windows.Forms.Timer timerDequeue1;
        private System.Windows.Forms.Timer timerDequeue2;
        private System.Windows.Forms.Timer timerDequeue3;
        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.Panel panelScroll;
    }
}
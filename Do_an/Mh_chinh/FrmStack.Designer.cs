namespace Mh_chinh
{
    partial class FrmStack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStack));
            this.tbInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btPush = new System.Windows.Forms.Button();
            this.btPop = new System.Windows.Forms.Button();
            this.trbAniSpeed = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPopVal = new System.Windows.Forms.TextBox();
            this.btCreate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMElement = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.timerPush1 = new System.Windows.Forms.Timer(this.components);
            this.timerPush2 = new System.Windows.Forms.Timer(this.components);
            this.timerPop1 = new System.Windows.Forms.Timer(this.components);
            this.timerPop2 = new System.Windows.Forms.Timer(this.components);
            this.timerPop3 = new System.Windows.Forms.Timer(this.components);
            this.panelScroll = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trbAniSpeed)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelScroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(44, 13);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(100, 22);
            this.tbInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input";
            // 
            // btPush
            // 
            this.btPush.Location = new System.Drawing.Point(44, 39);
            this.btPush.Name = "btPush";
            this.btPush.Size = new System.Drawing.Size(75, 23);
            this.btPush.TabIndex = 2;
            this.btPush.Text = "Push";
            this.btPush.UseVisualStyleBackColor = true;
            this.btPush.Click += new System.EventHandler(this.btPush_Click);
            // 
            // btPop
            // 
            this.btPop.Location = new System.Drawing.Point(68, 39);
            this.btPop.Name = "btPop";
            this.btPop.Size = new System.Drawing.Size(75, 23);
            this.btPop.TabIndex = 3;
            this.btPop.Text = "Pop";
            this.btPop.UseVisualStyleBackColor = true;
            this.btPop.Click += new System.EventHandler(this.btPop_Click);
            // 
            // trbAniSpeed
            // 
            this.trbAniSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbAniSpeed.Location = new System.Drawing.Point(370, 582);
            this.trbAniSpeed.Maximum = 1000;
            this.trbAniSpeed.Minimum = 1;
            this.trbAniSpeed.Name = "trbAniSpeed";
            this.trbAniSpeed.Size = new System.Drawing.Size(319, 45);
            this.trbAniSpeed.TabIndex = 4;
            this.trbAniSpeed.Value = 100;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 614);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Animation Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pop value";
            // 
            // tbPopVal
            // 
            this.tbPopVal.Location = new System.Drawing.Point(68, 13);
            this.tbPopVal.Name = "tbPopVal";
            this.tbPopVal.ReadOnly = true;
            this.tbPopVal.Size = new System.Drawing.Size(100, 22);
            this.tbPopVal.TabIndex = 7;
            // 
            // btCreate
            // 
            this.btCreate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreate.Location = new System.Drawing.Point(228, 44);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(75, 23);
            this.btCreate.TabIndex = 8;
            this.btCreate.Text = "Create new";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Max Element";
            // 
            // tbMElement
            // 
            this.tbMElement.Location = new System.Drawing.Point(233, 13);
            this.tbMElement.Name = "tbMElement";
            this.tbMElement.Size = new System.Drawing.Size(100, 22);
            this.tbMElement.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbMElement);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbInput);
            this.panel1.Controls.Add(this.btPush);
            this.panel1.Controls.Add(this.btCreate);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 69);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tbPopVal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btPop);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(358, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 69);
            this.panel2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Push";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(441, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pop";
            // 
            // panelDraw
            // 
            this.panelDraw.AutoScroll = true;
            this.panelDraw.Location = new System.Drawing.Point(3, 3);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(1300, 468);
            this.panelDraw.TabIndex = 13;
            this.panelDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseDown);
            this.panelDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseMove);
            this.panelDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseUp);
            // 
            // timerPush1
            // 
            this.timerPush1.Tick += new System.EventHandler(this.timerPush1_Tick);
            // 
            // timerPush2
            // 
            this.timerPush2.Tick += new System.EventHandler(this.timerPush2_Tick);
            // 
            // timerPop1
            // 
            this.timerPop1.Tick += new System.EventHandler(this.timerPop1_Tick);
            // 
            // timerPop2
            // 
            this.timerPop2.Tick += new System.EventHandler(this.timerPop2_Tick);
            // 
            // timerPop3
            // 
            this.timerPop3.Tick += new System.EventHandler(this.timerPop3_Tick);
            // 
            // panelScroll
            // 
            this.panelScroll.AutoScroll = true;
            this.panelScroll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelScroll.Controls.Add(this.panelDraw);
            this.panelScroll.Location = new System.Drawing.Point(12, 98);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(1326, 478);
            this.panelScroll.TabIndex = 0;
            // 
            // FrmStack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 661);
            this.Controls.Add(this.panelScroll);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trbAniSpeed);
            this.Name = "FrmStack";
            this.Text = "Stack";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStack_Load);
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

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPush;
        private System.Windows.Forms.Button btPop;
        private System.Windows.Forms.TrackBar trbAniSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPopVal;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMElement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.Timer timerPush1;
        private System.Windows.Forms.Timer timerPush2;
        private System.Windows.Forms.Timer timerPop1;
        private System.Windows.Forms.Timer timerPop2;
        private System.Windows.Forms.Timer timerPop3;
        private System.Windows.Forms.Panel panelScroll;
    }
}
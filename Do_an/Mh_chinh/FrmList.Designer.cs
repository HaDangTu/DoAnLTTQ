namespace Mh_chinh
{
    partial class FrmList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmList));
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btAddAfter = new System.Windows.Forms.Button();
            this.btAddBefore = new System.Windows.Forms.Button();
            this.btAddFirst = new System.Windows.Forms.Button();
            this.btAddLast = new System.Windows.Forms.Button();
            this.trbAniSp = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btDelFst = new System.Windows.Forms.Button();
            this.tbIndex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btDelLast = new System.Windows.Forms.Button();
            this.btDelAfter = new System.Windows.Forms.Button();
            this.btDelBefore = new System.Windows.Forms.Button();
            this.btCreatNew = new System.Windows.Forms.Button();
            this.panelScroll = new System.Windows.Forms.Panel();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trbAniSp)).BeginInit();
            this.panelScroll.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(42, 3);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(180, 22);
            this.tbInput.TabIndex = 0;
            // 
            // btAddAfter
            // 
            this.btAddAfter.Location = new System.Drawing.Point(247, 4);
            this.btAddAfter.Name = "btAddAfter";
            this.btAddAfter.Size = new System.Drawing.Size(105, 23);
            this.btAddAfter.TabIndex = 1;
            this.btAddAfter.Text = "Add After";
            this.btAddAfter.UseVisualStyleBackColor = true;
            this.btAddAfter.Click += new System.EventHandler(this.btAddAfter_Click);
            // 
            // btAddBefore
            // 
            this.btAddBefore.Location = new System.Drawing.Point(376, 4);
            this.btAddBefore.Name = "btAddBefore";
            this.btAddBefore.Size = new System.Drawing.Size(105, 23);
            this.btAddBefore.TabIndex = 2;
            this.btAddBefore.Text = "Add Before";
            this.btAddBefore.UseVisualStyleBackColor = true;
            this.btAddBefore.Click += new System.EventHandler(this.btAddBefore_Click);
            // 
            // btAddFirst
            // 
            this.btAddFirst.Location = new System.Drawing.Point(244, 3);
            this.btAddFirst.Name = "btAddFirst";
            this.btAddFirst.Size = new System.Drawing.Size(98, 23);
            this.btAddFirst.TabIndex = 3;
            this.btAddFirst.Text = "Add First";
            this.btAddFirst.UseVisualStyleBackColor = true;
            this.btAddFirst.Click += new System.EventHandler(this.btAddFirst_Click);
            // 
            // btAddLast
            // 
            this.btAddLast.Location = new System.Drawing.Point(352, 3);
            this.btAddLast.Name = "btAddLast";
            this.btAddLast.Size = new System.Drawing.Size(98, 23);
            this.btAddLast.TabIndex = 4;
            this.btAddLast.Text = "Add Last";
            this.btAddLast.UseVisualStyleBackColor = true;
            this.btAddLast.Click += new System.EventHandler(this.btAddLast_Click);
            // 
            // trbAniSp
            // 
            this.trbAniSp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbAniSp.Location = new System.Drawing.Point(424, 556);
            this.trbAniSp.Maximum = 1000;
            this.trbAniSp.Minimum = 1;
            this.trbAniSp.Name = "trbAniSp";
            this.trbAniSp.Size = new System.Drawing.Size(476, 45);
            this.trbAniSp.TabIndex = 6;
            this.trbAniSp.Value = 100;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 618);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Animation Speed";
            // 
            // btDelFst
            // 
            this.btDelFst.Location = new System.Drawing.Point(352, 32);
            this.btDelFst.Name = "btDelFst";
            this.btDelFst.Size = new System.Drawing.Size(98, 23);
            this.btDelFst.TabIndex = 10;
            this.btDelFst.Text = "Delete First";
            this.btDelFst.UseVisualStyleBackColor = true;
            this.btDelFst.Click += new System.EventHandler(this.btDelFst_Click);
            // 
            // tbIndex
            // 
            this.tbIndex.Location = new System.Drawing.Point(46, 4);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(180, 22);
            this.tbIndex.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Index";
            // 
            // btDelLast
            // 
            this.btDelLast.Location = new System.Drawing.Point(244, 32);
            this.btDelLast.Name = "btDelLast";
            this.btDelLast.Size = new System.Drawing.Size(98, 23);
            this.btDelLast.TabIndex = 14;
            this.btDelLast.Text = "Delete Last";
            this.btDelLast.UseVisualStyleBackColor = true;
            this.btDelLast.Click += new System.EventHandler(this.btDelLast_Click);
            // 
            // btDelAfter
            // 
            this.btDelAfter.Location = new System.Drawing.Point(247, 33);
            this.btDelAfter.Name = "btDelAfter";
            this.btDelAfter.Size = new System.Drawing.Size(105, 23);
            this.btDelAfter.TabIndex = 15;
            this.btDelAfter.Text = "Delete After";
            this.btDelAfter.UseVisualStyleBackColor = true;
            this.btDelAfter.Click += new System.EventHandler(this.btDelAfter_Click);
            // 
            // btDelBefore
            // 
            this.btDelBefore.Location = new System.Drawing.Point(376, 33);
            this.btDelBefore.Name = "btDelBefore";
            this.btDelBefore.Size = new System.Drawing.Size(105, 23);
            this.btDelBefore.TabIndex = 16;
            this.btDelBefore.Text = "Delete Before";
            this.btDelBefore.UseVisualStyleBackColor = true;
            this.btDelBefore.Click += new System.EventHandler(this.btDelBefore_Click);
            // 
            // btCreatNew
            // 
            this.btCreatNew.Location = new System.Drawing.Point(5, 36);
            this.btCreatNew.Name = "btCreatNew";
            this.btCreatNew.Size = new System.Drawing.Size(75, 23);
            this.btCreatNew.TabIndex = 17;
            this.btCreatNew.Text = "Create New";
            this.btCreatNew.UseVisualStyleBackColor = true;
            this.btCreatNew.Click += new System.EventHandler(this.btCreatNew_Click);
            // 
            // panelScroll
            // 
            this.panelScroll.AutoScroll = true;
            this.panelScroll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelScroll.Controls.Add(this.panelDraw);
            this.panelScroll.Location = new System.Drawing.Point(12, 83);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(1326, 450);
            this.panelScroll.TabIndex = 21;
            // 
            // panelDraw
            // 
            this.panelDraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelDraw.Location = new System.Drawing.Point(3, 3);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(1316, 440);
            this.panelDraw.TabIndex = 22;
            this.panelDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.panelDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.panelDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbInput);
            this.panel1.Controls.Add(this.btDelFst);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btDelLast);
            this.panel1.Controls.Add(this.btAddFirst);
            this.panel1.Controls.Add(this.btAddLast);
            this.panel1.Controls.Add(this.btCreatNew);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 65);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tbIndex);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btDelBefore);
            this.panel2.Controls.Add(this.btAddBefore);
            this.panel2.Controls.Add(this.btDelAfter);
            this.panel2.Controls.Add(this.btAddAfter);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(473, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 65);
            this.panel2.TabIndex = 23;
            // 
            // FrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trbAniSp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelScroll);
            this.Name = "FrmList";
            this.Text = "List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mh_Stack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbAniSp)).EndInit();
            this.panelScroll.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btAddAfter;
        private System.Windows.Forms.Button btAddBefore;
        private System.Windows.Forms.Button btAddFirst;
        private System.Windows.Forms.Button btAddLast;
        private System.Windows.Forms.TrackBar trbAniSp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDelFst;
        private System.Windows.Forms.TextBox tbIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDelLast;
        private System.Windows.Forms.Button btDelAfter;
        private System.Windows.Forms.Button btDelBefore;
        private System.Windows.Forms.Button btCreatNew;
       
        private System.Windows.Forms.Panel panelScroll;
        internal System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
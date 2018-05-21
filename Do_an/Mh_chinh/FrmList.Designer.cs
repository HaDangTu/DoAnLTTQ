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
            ((System.ComponentModel.ISupportInitialize)(this.trbAniSp)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(95, 37);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(208, 20);
            this.tbInput.TabIndex = 0;
            // 
            // btAddAfter
            // 
            this.btAddAfter.Location = new System.Drawing.Point(518, 35);
            this.btAddAfter.Name = "btAddAfter";
            this.btAddAfter.Size = new System.Drawing.Size(75, 23);
            this.btAddAfter.TabIndex = 1;
            this.btAddAfter.Text = "Add After";
            this.btAddAfter.UseVisualStyleBackColor = true;
            this.btAddAfter.Click += new System.EventHandler(this.btAddAfter_Click);
            // 
            // btAddBefore
            // 
            this.btAddBefore.Location = new System.Drawing.Point(616, 35);
            this.btAddBefore.Name = "btAddBefore";
            this.btAddBefore.Size = new System.Drawing.Size(88, 23);
            this.btAddBefore.TabIndex = 2;
            this.btAddBefore.Text = "Add Before";
            this.btAddBefore.UseVisualStyleBackColor = true;
            this.btAddBefore.Click += new System.EventHandler(this.btAddBefore_Click);
            // 
            // btAddFirst
            // 
            this.btAddFirst.Location = new System.Drawing.Point(309, 35);
            this.btAddFirst.Name = "btAddFirst";
            this.btAddFirst.Size = new System.Drawing.Size(75, 23);
            this.btAddFirst.TabIndex = 3;
            this.btAddFirst.Text = "Add First";
            this.btAddFirst.UseVisualStyleBackColor = true;
            this.btAddFirst.Click += new System.EventHandler(this.btAddFirst_Click);
            // 
            // btAddLast
            // 
            this.btAddLast.Location = new System.Drawing.Point(416, 35);
            this.btAddLast.Name = "btAddLast";
            this.btAddLast.Size = new System.Drawing.Size(75, 23);
            this.btAddLast.TabIndex = 4;
            this.btAddLast.Text = "Add Last";
            this.btAddLast.UseVisualStyleBackColor = true;
            this.btAddLast.Click += new System.EventHandler(this.btAddLast_Click);
            // 
            // trbAniSp
            // 
            this.trbAniSp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbAniSp.Location = new System.Drawing.Point(309, 591);
            this.trbAniSp.Maximum = 1000;
            this.trbAniSp.Minimum = 1;
            this.trbAniSp.Name = "trbAniSp";
            this.trbAniSp.Size = new System.Drawing.Size(207, 45);
            this.trbAniSp.TabIndex = 6;
            this.trbAniSp.Value = 60;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 639);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Animation Speed";
            // 
            // btDelFst
            // 
            this.btDelFst.Location = new System.Drawing.Point(309, 64);
            this.btDelFst.Name = "btDelFst";
            this.btDelFst.Size = new System.Drawing.Size(75, 23);
            this.btDelFst.TabIndex = 10;
            this.btDelFst.Text = "Delete First";
            this.btDelFst.UseVisualStyleBackColor = true;
            this.btDelFst.Click += new System.EventHandler(this.btDelFst_Click);
            // 
            // tbIndex
            // 
            this.tbIndex.Location = new System.Drawing.Point(95, 66);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(208, 20);
            this.tbIndex.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Index";
            // 
            // btDelLast
            // 
            this.btDelLast.Location = new System.Drawing.Point(416, 64);
            this.btDelLast.Name = "btDelLast";
            this.btDelLast.Size = new System.Drawing.Size(75, 23);
            this.btDelLast.TabIndex = 14;
            this.btDelLast.Text = "Delete Last";
            this.btDelLast.UseVisualStyleBackColor = true;
            this.btDelLast.Click += new System.EventHandler(this.btDelLast_Click);
            // 
            // btDelAfter
            // 
            this.btDelAfter.Location = new System.Drawing.Point(518, 64);
            this.btDelAfter.Name = "btDelAfter";
            this.btDelAfter.Size = new System.Drawing.Size(75, 23);
            this.btDelAfter.TabIndex = 15;
            this.btDelAfter.Text = "Delete After";
            this.btDelAfter.UseVisualStyleBackColor = true;
            this.btDelAfter.Click += new System.EventHandler(this.btDelAfter_Click);
            // 
            // btDelBefore
            // 
            this.btDelBefore.Location = new System.Drawing.Point(617, 63);
            this.btDelBefore.Name = "btDelBefore";
            this.btDelBefore.Size = new System.Drawing.Size(88, 23);
            this.btDelBefore.TabIndex = 16;
            this.btDelBefore.Text = "Delete Before";
            this.btDelBefore.UseVisualStyleBackColor = true;
            // 
            // btCreatNew
            // 
            this.btCreatNew.Location = new System.Drawing.Point(728, 34);
            this.btCreatNew.Name = "btCreatNew";
            this.btCreatNew.Size = new System.Drawing.Size(75, 23);
            this.btCreatNew.TabIndex = 17;
            this.btCreatNew.Text = "Create New";
            this.btCreatNew.UseVisualStyleBackColor = true;
            this.btCreatNew.Click += new System.EventHandler(this.btCreatNew_Click);
            // 
            // FrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 661);
            this.Controls.Add(this.btCreatNew);
            this.Controls.Add(this.btDelBefore);
            this.Controls.Add(this.btDelAfter);
            this.Controls.Add(this.btDelLast);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIndex);
            this.Controls.Add(this.btDelFst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trbAniSp);
            this.Controls.Add(this.btAddLast);
            this.Controls.Add(this.btAddFirst);
            this.Controls.Add(this.btAddBefore);
            this.Controls.Add(this.btAddAfter);
            this.Controls.Add(this.tbInput);
            this.Name = "FrmList";
            this.Text = "List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mh_Stack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbAniSp)).EndInit();
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
    }
}
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
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btStepBack = new System.Windows.Forms.Button();
            this.btStepForward = new System.Windows.Forms.Button();
            this.btPause = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.trbAniSp)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.bunifuGradientPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(40, 6);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(180, 20);
            this.tbInput.TabIndex = 0;
            // 
            // btAddAfter
            // 
            this.btAddAfter.Location = new System.Drawing.Point(246, 8);
            this.btAddAfter.Name = "btAddAfter";
            this.btAddAfter.Size = new System.Drawing.Size(105, 23);
            this.btAddAfter.TabIndex = 1;
            this.btAddAfter.Text = "Add After";
            this.btAddAfter.UseVisualStyleBackColor = true;
            this.btAddAfter.Click += new System.EventHandler(this.btAddAfter_Click);
            // 
            // btAddBefore
            // 
            this.btAddBefore.Location = new System.Drawing.Point(375, 8);
            this.btAddBefore.Name = "btAddBefore";
            this.btAddBefore.Size = new System.Drawing.Size(105, 23);
            this.btAddBefore.TabIndex = 2;
            this.btAddBefore.Text = "Add Before";
            this.btAddBefore.UseVisualStyleBackColor = true;
            this.btAddBefore.Click += new System.EventHandler(this.btAddBefore_Click);
            // 
            // btAddFirst
            // 
            this.btAddFirst.Location = new System.Drawing.Point(242, 4);
            this.btAddFirst.Name = "btAddFirst";
            this.btAddFirst.Size = new System.Drawing.Size(98, 23);
            this.btAddFirst.TabIndex = 3;
            this.btAddFirst.Text = "Add First";
            this.btAddFirst.UseVisualStyleBackColor = true;
            this.btAddFirst.Click += new System.EventHandler(this.btAddFirst_Click);
            // 
            // btAddLast
            // 
            this.btAddLast.Location = new System.Drawing.Point(350, 4);
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
            this.trbAniSp.Location = new System.Drawing.Point(414, 19);
            this.trbAniSp.Maximum = 1000;
            this.trbAniSp.Minimum = 1;
            this.trbAniSp.Name = "trbAniSp";
            this.trbAniSp.Size = new System.Drawing.Size(476, 45);
            this.trbAniSp.TabIndex = 6;
            this.trbAniSp.Value = 600;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(638, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Animation Speed";
            // 
            // btDelFst
            // 
            this.btDelFst.Location = new System.Drawing.Point(350, 33);
            this.btDelFst.Name = "btDelFst";
            this.btDelFst.Size = new System.Drawing.Size(98, 23);
            this.btDelFst.TabIndex = 10;
            this.btDelFst.Text = "Delete First";
            this.btDelFst.UseVisualStyleBackColor = true;
            this.btDelFst.Click += new System.EventHandler(this.btDelFst_Click);
            // 
            // tbIndex
            // 
            this.tbIndex.Location = new System.Drawing.Point(45, 6);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(180, 20);
            this.tbIndex.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Index";
            // 
            // btDelLast
            // 
            this.btDelLast.Location = new System.Drawing.Point(242, 33);
            this.btDelLast.Name = "btDelLast";
            this.btDelLast.Size = new System.Drawing.Size(98, 23);
            this.btDelLast.TabIndex = 14;
            this.btDelLast.Text = "Delete Last";
            this.btDelLast.UseVisualStyleBackColor = true;
            this.btDelLast.Click += new System.EventHandler(this.btDelLast_Click);
            // 
            // btDelAfter
            // 
            this.btDelAfter.Location = new System.Drawing.Point(246, 37);
            this.btDelAfter.Name = "btDelAfter";
            this.btDelAfter.Size = new System.Drawing.Size(105, 23);
            this.btDelAfter.TabIndex = 15;
            this.btDelAfter.Text = "Delete After";
            this.btDelAfter.UseVisualStyleBackColor = true;
            this.btDelAfter.Click += new System.EventHandler(this.btDelAfter_Click);
            // 
            // btDelBefore
            // 
            this.btDelBefore.Location = new System.Drawing.Point(375, 37);
            this.btDelBefore.Name = "btDelBefore";
            this.btDelBefore.Size = new System.Drawing.Size(105, 23);
            this.btDelBefore.TabIndex = 16;
            this.btDelBefore.Text = "Delete Before";
            this.btDelBefore.UseVisualStyleBackColor = true;
            this.btDelBefore.Click += new System.EventHandler(this.btDelBefore_Click);
            // 
            // btCreatNew
            // 
            this.btCreatNew.Location = new System.Drawing.Point(3, 37);
            this.btCreatNew.Name = "btCreatNew";
            this.btCreatNew.Size = new System.Drawing.Size(75, 23);
            this.btCreatNew.TabIndex = 17;
            this.btCreatNew.Text = "Create New";
            this.btCreatNew.UseVisualStyleBackColor = true;
            this.btCreatNew.Click += new System.EventHandler(this.btCreatNew_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.tbInput);
            this.bunifuGradientPanel1.Controls.Add(this.btDelLast);
            this.bunifuGradientPanel1.Controls.Add(this.btAddFirst);
            this.bunifuGradientPanel1.Controls.Add(this.btCreatNew);
            this.bunifuGradientPanel1.Controls.Add(this.btDelFst);
            this.bunifuGradientPanel1.Controls.Add(this.btAddLast);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(12, 7);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(458, 70);
            this.bunifuGradientPanel1.TabIndex = 18;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuGradientPanel2.Controls.Add(this.tbIndex);
            this.bunifuGradientPanel2.Controls.Add(this.label3);
            this.bunifuGradientPanel2.Controls.Add(this.btAddAfter);
            this.bunifuGradientPanel2.Controls.Add(this.btDelBefore);
            this.bunifuGradientPanel2.Controls.Add(this.btDelAfter);
            this.bunifuGradientPanel2.Controls.Add(this.btAddBefore);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(476, 7);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(491, 70);
            this.bunifuGradientPanel2.TabIndex = 19;
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.btStepBack);
            this.bunifuGradientPanel3.Controls.Add(this.btStepForward);
            this.bunifuGradientPanel3.Controls.Add(this.btPause);
            this.bunifuGradientPanel3.Controls.Add(this.trbAniSp);
            this.bunifuGradientPanel3.Controls.Add(this.label1);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(12, 556);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(893, 93);
            this.bunifuGradientPanel3.TabIndex = 20;
            // 
            // btStepBack
            // 
            this.btStepBack.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStepBack.Location = new System.Drawing.Point(221, 41);
            this.btStepBack.Name = "btStepBack";
            this.btStepBack.Size = new System.Drawing.Size(121, 23);
            this.btStepBack.TabIndex = 23;
            this.btStepBack.Text = "Step Back";
            this.btStepBack.UseVisualStyleBackColor = true;
            // 
            // btStepForward
            // 
            this.btStepForward.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStepForward.Location = new System.Drawing.Point(93, 41);
            this.btStepForward.Name = "btStepForward";
            this.btStepForward.Size = new System.Drawing.Size(116, 23);
            this.btStepForward.TabIndex = 22;
            this.btStepForward.Text = "Step Forward";
            this.btStepForward.UseVisualStyleBackColor = true;
            this.btStepForward.Click += new System.EventHandler(this.btStepForward_Click);
            // 
            // btPause
            // 
            this.btPause.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPause.Location = new System.Drawing.Point(3, 41);
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(75, 23);
            this.btPause.TabIndex = 21;
            this.btPause.Text = "Pause";
            this.btPause.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(335, 536);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(68, 17);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Animation";
            // 
            // FrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 661);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "FrmList";
            this.Text = "List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mh_Stack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbAniSp)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel3.PerformLayout();
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
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private System.Windows.Forms.Button btStepBack;
        private System.Windows.Forms.Button btStepForward;
        private System.Windows.Forms.Button btPause;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}
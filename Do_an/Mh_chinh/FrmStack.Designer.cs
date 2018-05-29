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
            ((System.ComponentModel.ISupportInitialize)(this.trbAniSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(53, 44);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(100, 20);
            this.tbInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input";
            // 
            // btPush
            // 
            this.btPush.Location = new System.Drawing.Point(183, 41);
            this.btPush.Name = "btPush";
            this.btPush.Size = new System.Drawing.Size(75, 23);
            this.btPush.TabIndex = 2;
            this.btPush.Text = "Push";
            this.btPush.UseVisualStyleBackColor = true;
            this.btPush.Click += new System.EventHandler(this.btPush_Click);
            // 
            // btPop
            // 
            this.btPop.Location = new System.Drawing.Point(290, 42);
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
            this.trbAniSpeed.Location = new System.Drawing.Point(142, 582);
            this.trbAniSpeed.Maximum = 1000;
            this.trbAniSpeed.Minimum = 1;
            this.trbAniSpeed.Name = "trbAniSpeed";
            this.trbAniSpeed.Size = new System.Drawing.Size(319, 45);
            this.trbAniSpeed.TabIndex = 4;
            this.trbAniSpeed.Value = 60;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 639);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Animation Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pop value";
            // 
            // tbPopVal
            // 
            this.tbPopVal.Location = new System.Drawing.Point(468, 44);
            this.tbPopVal.Name = "tbPopVal";
            this.tbPopVal.ReadOnly = true;
            this.tbPopVal.Size = new System.Drawing.Size(100, 20);
            this.tbPopVal.TabIndex = 7;
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(626, 41);
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
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Max Element";
            // 
            // tbMElement
            // 
            this.tbMElement.Location = new System.Drawing.Point(86, 85);
            this.tbMElement.Name = "tbMElement";
            this.tbMElement.Size = new System.Drawing.Size(100, 20);
            this.tbMElement.TabIndex = 10;
            // 
            // FrmStack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 661);
            this.Controls.Add(this.tbMElement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.tbPopVal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trbAniSpeed);
            this.Controls.Add(this.btPop);
            this.Controls.Add(this.btPush);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInput);
            this.Name = "FrmStack";
            this.Text = "Stack";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbAniSpeed)).EndInit();
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
    }
}
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
            ((System.ComponentModel.ISupportInitialize)(this.trbAniSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(49, 34);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(100, 20);
            this.tbInput.TabIndex = 1;
            // 
            // btEnqueue
            // 
            this.btEnqueue.Location = new System.Drawing.Point(181, 31);
            this.btEnqueue.Name = "btEnqueue";
            this.btEnqueue.Size = new System.Drawing.Size(75, 23);
            this.btEnqueue.TabIndex = 2;
            this.btEnqueue.Text = "Enqueue";
            this.btEnqueue.UseVisualStyleBackColor = true;
            this.btEnqueue.Click += new System.EventHandler(this.btEnqueue_Click);
            // 
            // btDequeue
            // 
            this.btDequeue.Location = new System.Drawing.Point(283, 31);
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
            this.trbAniSpeed.Location = new System.Drawing.Point(346, 567);
            this.trbAniSpeed.Maximum = 1000;
            this.trbAniSpeed.Minimum = 1;
            this.trbAniSpeed.Name = "trbAniSpeed";
            this.trbAniSpeed.Size = new System.Drawing.Size(235, 45);
            this.trbAniSpeed.TabIndex = 4;
            this.trbAniSpeed.Value = 60;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 628);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Animation Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dequeue value";
            // 
            // tbDeqVal
            // 
            this.tbDeqVal.Location = new System.Drawing.Point(469, 34);
            this.tbDeqVal.Name = "tbDeqVal";
            this.tbDeqVal.ReadOnly = true;
            this.tbDeqVal.Size = new System.Drawing.Size(100, 20);
            this.tbDeqVal.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Max Element";
            // 
            // tbMElement
            // 
            this.tbMElement.Location = new System.Drawing.Point(86, 60);
            this.tbMElement.Name = "tbMElement";
            this.tbMElement.Size = new System.Drawing.Size(100, 20);
            this.tbMElement.TabIndex = 9;
            // 
            // FrmQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 661);
            this.Controls.Add(this.tbMElement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDeqVal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trbAniSpeed);
            this.Controls.Add(this.btDequeue);
            this.Controls.Add(this.btEnqueue);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.label1);
            this.Name = "FrmQueue";
            this.Text = "FrmQueue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmQueue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbAniSpeed)).EndInit();
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
    }
}
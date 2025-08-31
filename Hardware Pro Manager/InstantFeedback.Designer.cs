namespace Hardware_Pro_Manager
{
    partial class InstantFeedback
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.FeedbackRtb = new System.Windows.Forms.RichTextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.CustNameCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.FeedbackRtb);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.CustNameCb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 620);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 23);
            this.label10.TabIndex = 35;
            this.label10.Text = "< Back";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // FeedbackRtb
            // 
            this.FeedbackRtb.Location = new System.Drawing.Point(398, 312);
            this.FeedbackRtb.Name = "FeedbackRtb";
            this.FeedbackRtb.Size = new System.Drawing.Size(274, 98);
            this.FeedbackRtb.TabIndex = 32;
            this.FeedbackRtb.Text = "";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Hardware_Pro_Manager.Properties.Resources.Designer__5__upscaled;
            this.pictureBox5.Location = new System.Drawing.Point(482, 74);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(123, 75);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(482, 425);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(115, 42);
            this.SaveBtn.TabIndex = 27;
            this.SaveBtn.Text = "Add";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(454, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 30);
            this.label9.TabIndex = 26;
            this.label9.Text = "Add Feedback";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // CustNameCb
            // 
            this.CustNameCb.FormattingEnabled = true;
            this.CustNameCb.Location = new System.Drawing.Point(412, 175);
            this.CustNameCb.Name = "CustNameCb";
            this.CustNameCb.Size = new System.Drawing.Size(244, 28);
            this.CustNameCb.TabIndex = 20;
            this.CustNameCb.Text = "Choose a customer name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(394, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Add you opinion/feedback";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(963, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "x";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // InstantFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1034, 655);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InstantFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstantFeedback";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CustNameCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox FeedbackRtb;
        private System.Windows.Forms.Label label10;
    }
}
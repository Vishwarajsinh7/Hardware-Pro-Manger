
namespace Hardware_Pro_Manager
{
    partial class InstantFeedback
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
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
			this.panel1.Controls.Add(this.richTextBox1);
			this.panel1.Controls.Add(this.pictureBox5);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.comboBox2);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(673, 410);
			this.panel1.TabIndex = 1;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(11, 14);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(55, 19);
			this.label10.TabIndex = 35;
			this.label10.Text = "< Back";
			this.label10.Click += new System.EventHandler(this.label10_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(265, 203);
			this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(184, 64);
			this.richTextBox1.TabIndex = 32;
			this.richTextBox1.Text = "";
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::Hardware_Pro_Manager.Properties.Resources.Designer__5__upscaled;
			this.pictureBox5.Location = new System.Drawing.Point(321, 48);
			this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(82, 49);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 31;
			this.pictureBox5.TabStop = false;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(321, 276);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(77, 27);
			this.button1.TabIndex = 27;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(303, 10);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(128, 21);
			this.label9.TabIndex = 26;
			this.label9.Text = "Add Feedback";
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "S.S.",
            "Brass",
            "Aluminium",
            "M.S.",
            "Iron\t"});
			this.comboBox2.Location = new System.Drawing.Point(275, 114);
			this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(164, 21);
			this.comboBox2.TabIndex = 20;
			this.comboBox2.Text = "Choose a customer name:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(263, 187);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(198, 19);
			this.label6.TabIndex = 18;
			this.label6.Text = "Add you opinion/feedback";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(642, 10);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(18, 21);
			this.label5.TabIndex = 16;
			this.label5.Text = "x";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// InstantFeedback
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Firebrick;
			this.ClientSize = new System.Drawing.Size(689, 426);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label10;
    }
}
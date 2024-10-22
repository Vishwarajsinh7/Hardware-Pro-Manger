
namespace Hardware_Pro_Manager
{
    partial class Sales
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
<<<<<<< HEAD
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystallReportOfBill = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SalesDGV = new System.Windows.Forms.DataGridView();
            this.BIDDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustIDDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustNameDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmountDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
=======
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
>>>>>>> c95f7139356dc744dc5fab087756fd21e09633a6
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDGV)).BeginInit();
=======
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
>>>>>>> c95f7139356dc744dc5fab087756fd21e09633a6
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
<<<<<<< HEAD
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Controls.Add(this.CrystallReportOfBill);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.SalesDGV);
=======
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dataGridView1);
>>>>>>> c95f7139356dc744dc5fab087756fd21e09633a6
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 631);
            this.panel1.TabIndex = 2;
<<<<<<< HEAD
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(19, 67);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(969, 561);
            this.crystalReportViewer1.TabIndex = 38;
            this.crystalReportViewer1.Visible = false;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // CrystallReportOfBill
            // 
            this.CrystallReportOfBill.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrystallReportOfBill.Location = new System.Drawing.Point(399, 564);
            this.CrystallReportOfBill.Name = "CrystallReportOfBill";
            this.CrystallReportOfBill.Size = new System.Drawing.Size(239, 45);
            this.CrystallReportOfBill.TabIndex = 37;
            this.CrystallReportOfBill.Text = "Crystal Report of Bill";
            this.CrystallReportOfBill.UseVisualStyleBackColor = true;
            this.CrystallReportOfBill.Click += new System.EventHandler(this.CrystallReportOfBill_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 23);
            this.label10.TabIndex = 36;
            this.label10.Text = "< Logout";
            this.label10.Click += new System.EventHandler(this.label10_Click);
=======
>>>>>>> c95f7139356dc744dc5fab087756fd21e09633a6
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(494, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 30);
            this.label9.TabIndex = 26;
            this.label9.Text = "Bills";
            // 
<<<<<<< HEAD
            // SalesDGV
            // 
            this.SalesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BIDDGV,
            this.CustIDDGV,
            this.CustNameDGV,
            this.TotalAmountDGV});
            this.SalesDGV.Location = new System.Drawing.Point(82, 127);
            this.SalesDGV.Name = "SalesDGV";
            this.SalesDGV.RowHeadersWidth = 62;
            this.SalesDGV.RowTemplate.Height = 28;
            this.SalesDGV.Size = new System.Drawing.Size(870, 418);
            this.SalesDGV.TabIndex = 25;
            // 
            // BIDDGV
            // 
            this.BIDDGV.DataPropertyName = "BId";
            this.BIDDGV.HeaderText = "Bill No.";
            this.BIDDGV.MinimumWidth = 8;
            this.BIDDGV.Name = "BIDDGV";
            this.BIDDGV.Width = 150;
            // 
            // CustIDDGV
            // 
            this.CustIDDGV.DataPropertyName = "CustId";
            this.CustIDDGV.HeaderText = "Customer ID";
            this.CustIDDGV.MinimumWidth = 8;
            this.CustIDDGV.Name = "CustIDDGV";
            this.CustIDDGV.Width = 150;
            // 
            // CustNameDGV
            // 
            this.CustNameDGV.DataPropertyName = "CustName";
            this.CustNameDGV.HeaderText = "Customer Name";
            this.CustNameDGV.MinimumWidth = 8;
            this.CustNameDGV.Name = "CustNameDGV";
            this.CustNameDGV.Width = 150;
            // 
            // TotalAmountDGV
            // 
            this.TotalAmountDGV.DataPropertyName = "Amount";
            this.TotalAmountDGV.HeaderText = "Total Amount";
            this.TotalAmountDGV.MinimumWidth = 8;
            this.TotalAmountDGV.Name = "TotalAmountDGV";
            this.TotalAmountDGV.Width = 150;
=======
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(870, 479);
            this.dataGridView1.TabIndex = 25;
>>>>>>> c95f7139356dc744dc5fab087756fd21e09633a6
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
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Hardware_Pro_Manager.Properties.Resources.Designer__5__upscaled;
            this.pictureBox4.Location = new System.Drawing.Point(649, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(696, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "Feedback";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Hardware_Pro_Manager.Properties.Resources.Designer__5__upscaled;
            this.pictureBox3.Location = new System.Drawing.Point(531, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(578, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sales";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hardware_Pro_Manager.Properties.Resources.Designer__5__upscaled;
            this.pictureBox2.Location = new System.Drawing.Point(347, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Customers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hardware_Pro_Manager.Properties.Resources.Designer__5__upscaled;
            this.pictureBox1.Location = new System.Drawing.Point(185, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Products";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
<<<<<<< HEAD
=======
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 23);
            this.label10.TabIndex = 36;
            this.label10.Text = "< Logout";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
>>>>>>> c95f7139356dc744dc5fab087756fd21e09633a6
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1036, 656);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.SalesDGV)).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
>>>>>>> c95f7139356dc744dc5fab087756fd21e09633a6
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
<<<<<<< HEAD
        private System.Windows.Forms.DataGridView SalesDGV;
=======
        private System.Windows.Forms.DataGridView dataGridView1;
>>>>>>> c95f7139356dc744dc5fab087756fd21e09633a6
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
<<<<<<< HEAD
        private System.Windows.Forms.Button CrystallReportOfBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIDDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustIDDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustNameDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmountDGV;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
=======
>>>>>>> c95f7139356dc744dc5fab087756fd21e09633a6
    }
}
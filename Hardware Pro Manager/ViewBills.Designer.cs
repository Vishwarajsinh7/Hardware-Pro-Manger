
namespace Hardware_Pro_Manager
{
    partial class ViewBills
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
            this.CrystallReportOfBill = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SalesDGV = new System.Windows.Forms.DataGridView();
            this.BIDDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustIDDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustNameDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmountDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Controls.Add(this.CrystallReportOfBill);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.SalesDGV);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 622);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.label10.Size = new System.Drawing.Size(76, 23);
            this.label10.TabIndex = 36;
            this.label10.Text = "< Back";
            this.label10.Click += new System.EventHandler(this.label10_Click);
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
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(16, 65);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(969, 527);
            this.crystalReportViewer1.TabIndex = 39;
            this.crystalReportViewer1.Visible = false;
            // 
            // ViewBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1023, 645);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewBills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBills";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CrystallReportOfBill;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView SalesDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIDDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustIDDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustNameDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmountDGV;
        private System.Windows.Forms.Label label5;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}
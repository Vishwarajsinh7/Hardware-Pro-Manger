
namespace Hardware_Pro_Manager
{
    partial class Billing
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
<<<<<<< HEAD
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
=======
<<<<<<< HEAD
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.PrintBtn = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button4 = new System.Windows.Forms.Button();
			this.ProdPriceTb = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ProdNameTb = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.AddToBillBtn = new System.Windows.Forms.Button();
			this.ProdQtyTb = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.CustNameTb = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ViewSells = new System.Windows.Forms.Button();
			this.TotalLbl = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.BillDGV = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.CustomerDGV = new System.Windows.Forms.DataGridView();
			this.CustIDDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustNameDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PhoneDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemDGV = new System.Windows.Forms.DataGridView();
			this.IDDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NameDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CatDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TypeDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PriceDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QtyDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BillDGV)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemDGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(310, 10);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 21);
			this.label3.TabIndex = 8;
			this.label3.Text = "Billing";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(645, 10);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(18, 21);
			this.label5.TabIndex = 16;
			this.label5.Text = "x";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(103, 10);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(113, 21);
			this.label9.TabIndex = 26;
			this.label9.Text = "Customer List";
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// PrintBtn
			// 
			this.PrintBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PrintBtn.Location = new System.Drawing.Point(512, 183);
			this.PrintBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.PrintBtn.Name = "PrintBtn";
			this.PrintBtn.Size = new System.Drawing.Size(77, 29);
			this.PrintBtn.TabIndex = 28;
			this.PrintBtn.Text = "Print";
			this.PrintBtn.UseVisualStyleBackColor = true;
			this.PrintBtn.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Snow;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.button4);
			this.panel2.Controls.Add(this.ProdPriceTb);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.ProdNameTb);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.AddToBillBtn);
			this.panel2.Controls.Add(this.ProdQtyTb);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.CustNameTb);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Location = new System.Drawing.Point(19, 44);
			this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(267, 130);
			this.panel2.TabIndex = 29;
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(133, 100);
			this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(107, 27);
			this.button4.TabIndex = 30;
			this.button4.Text = "Reset";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// ProdPriceTb
			// 
			this.ProdPriceTb.Enabled = false;
			this.ProdPriceTb.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdPriceTb.Location = new System.Drawing.Point(143, 71);
			this.ProdPriceTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ProdPriceTb.Name = "ProdPriceTb";
			this.ProdPriceTb.Size = new System.Drawing.Size(115, 21);
			this.ProdPriceTb.TabIndex = 28;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(177, 54);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 19);
			this.label1.TabIndex = 29;
			this.label1.Text = "Price";
			// 
			// ProdNameTb
			// 
			this.ProdNameTb.Enabled = false;
			this.ProdNameTb.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdNameTb.Location = new System.Drawing.Point(11, 29);
			this.ProdNameTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ProdNameTb.Name = "ProdNameTb";
			this.ProdNameTb.Size = new System.Drawing.Size(115, 21);
			this.ProdNameTb.TabIndex = 17;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(15, 12);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(109, 19);
			this.label6.TabIndex = 18;
			this.label6.Text = "Product Name";
			// 
			// AddToBillBtn
			// 
			this.AddToBillBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddToBillBtn.Location = new System.Drawing.Point(22, 100);
			this.AddToBillBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.AddToBillBtn.Name = "AddToBillBtn";
			this.AddToBillBtn.Size = new System.Drawing.Size(107, 27);
			this.AddToBillBtn.TabIndex = 27;
			this.AddToBillBtn.Text = "Add to bill";
			this.AddToBillBtn.UseVisualStyleBackColor = true;
			this.AddToBillBtn.Click += new System.EventHandler(this.AddToBillBtn_Click);
			// 
			// ProdQtyTb
			// 
			this.ProdQtyTb.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdQtyTb.Location = new System.Drawing.Point(143, 29);
			this.ProdQtyTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ProdQtyTb.Name = "ProdQtyTb";
			this.ProdQtyTb.Size = new System.Drawing.Size(115, 21);
			this.ProdQtyTb.TabIndex = 21;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(185, 12);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(34, 19);
			this.label7.TabIndex = 22;
			this.label7.Text = "Qty";
			// 
			// CustNameTb
			// 
			this.CustNameTb.Enabled = false;
			this.CustNameTb.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CustNameTb.Location = new System.Drawing.Point(11, 71);
			this.CustNameTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.CustNameTb.Name = "CustNameTb";
			this.CustNameTb.Size = new System.Drawing.Size(115, 21);
			this.CustNameTb.TabIndex = 23;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(11, 54);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(120, 19);
			this.label8.TabIndex = 24;
			this.label8.Text = "Customer Name";
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Snow;
			this.panel1.Controls.Add(this.ViewSells);
			this.panel1.Controls.Add(this.TotalLbl);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.BillDGV);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.PrintBtn);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(9, 8);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(673, 410);
			this.panel1.TabIndex = 1;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// ViewSells
			// 
			this.ViewSells.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ViewSells.Location = new System.Drawing.Point(33, 183);
			this.ViewSells.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ViewSells.Name = "ViewSells";
			this.ViewSells.Size = new System.Drawing.Size(159, 29);
			this.ViewSells.TabIndex = 36;
			this.ViewSells.Text = "View Sells";
			this.ViewSells.UseVisualStyleBackColor = true;
			this.ViewSells.Click += new System.EventHandler(this.ViewSells_Click);
			// 
			// TotalLbl
			// 
			this.TotalLbl.AutoSize = true;
			this.TotalLbl.Location = new System.Drawing.Point(434, 192);
			this.TotalLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.TotalLbl.Name = "TotalLbl";
			this.TotalLbl.Size = new System.Drawing.Size(0, 13);
			this.TotalLbl.TabIndex = 35;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(6, 10);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(68, 19);
			this.label10.TabIndex = 34;
			this.label10.Text = "< Logout";
			this.label10.Click += new System.EventHandler(this.label10_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(264, 183);
			this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(159, 29);
			this.button3.TabIndex = 33;
			this.button3.Text = "Add Feedback";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Cursor = System.Windows.Forms.Cursors.AppStarting;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(481, 35);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 21);
			this.label4.TabIndex = 32;
			this.label4.Text = "Bills";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// BillDGV
			// 
			this.BillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.BillDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
=======
>>>>>>> eb0c822c4d08bda6e7c8a308d2cfb34688a97f2e
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.ProdPriceTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProdNameTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddToBillBtn = new System.Windows.Forms.Button();
            this.ProdQtyTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CustNameTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ViewSells = new System.Windows.Forms.Button();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BillDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.CustomerDGV = new System.Windows.Forms.DataGridView();
            this.CustIDDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustNameDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDGV = new System.Windows.Forms.DataGridView();
            this.IDDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(465, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Billing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(968, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "x";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(155, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 30);
            this.label9.TabIndex = 26;
            this.label9.Text = "Customer List";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.Location = new System.Drawing.Point(768, 281);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(115, 45);
            this.PrintBtn.TabIndex = 28;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.ProdPriceTb);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ProdNameTb);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.AddToBillBtn);
            this.panel2.Controls.Add(this.ProdQtyTb);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.CustNameTb);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(29, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 199);
            this.panel2.TabIndex = 29;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(200, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 42);
            this.button4.TabIndex = 30;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ProdPriceTb
            // 
            this.ProdPriceTb.Enabled = false;
            this.ProdPriceTb.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPriceTb.Location = new System.Drawing.Point(215, 109);
            this.ProdPriceTb.Name = "ProdPriceTb";
            this.ProdPriceTb.Size = new System.Drawing.Size(171, 27);
            this.ProdPriceTb.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Price";
            // 
            // ProdNameTb
            // 
            this.ProdNameTb.Enabled = false;
            this.ProdNameTb.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdNameTb.Location = new System.Drawing.Point(16, 45);
            this.ProdNameTb.Name = "ProdNameTb";
            this.ProdNameTb.Size = new System.Drawing.Size(171, 27);
            this.ProdNameTb.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Product Name";
            // 
            // AddToBillBtn
            // 
            this.AddToBillBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToBillBtn.Location = new System.Drawing.Point(33, 154);
            this.AddToBillBtn.Name = "AddToBillBtn";
            this.AddToBillBtn.Size = new System.Drawing.Size(161, 42);
            this.AddToBillBtn.TabIndex = 27;
            this.AddToBillBtn.Text = "Add to bill";
            this.AddToBillBtn.UseVisualStyleBackColor = true;
            this.AddToBillBtn.Click += new System.EventHandler(this.AddToBillBtn_Click);
            // 
            // ProdQtyTb
            // 
            this.ProdQtyTb.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdQtyTb.Location = new System.Drawing.Point(215, 45);
            this.ProdQtyTb.Name = "ProdQtyTb";
            this.ProdQtyTb.Size = new System.Drawing.Size(171, 27);
            this.ProdQtyTb.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(278, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Qty";
            // 
            // CustNameTb
            // 
            this.CustNameTb.Enabled = false;
            this.CustNameTb.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNameTb.Location = new System.Drawing.Point(16, 109);
            this.CustNameTb.Name = "CustNameTb";
            this.CustNameTb.Size = new System.Drawing.Size(171, 27);
            this.CustNameTb.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "Customer Name";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Controls.Add(this.ViewSells);
            this.panel1.Controls.Add(this.TotalLbl);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BillDGV);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.PrintBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 631);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(13, 68);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(980, 547);
            this.crystalReportViewer1.TabIndex = 37;
            this.crystalReportViewer1.Visible = false;
            // 
            // ViewSells
            // 
            this.ViewSells.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewSells.Location = new System.Drawing.Point(50, 281);
            this.ViewSells.Name = "ViewSells";
            this.ViewSells.Size = new System.Drawing.Size(239, 45);
            this.ViewSells.TabIndex = 36;
            this.ViewSells.Text = "View Sells";
            this.ViewSells.UseVisualStyleBackColor = true;
            this.ViewSells.Click += new System.EventHandler(this.ViewSells_Click);
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Location = new System.Drawing.Point(651, 295);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(0, 20);
            this.TotalLbl.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 23);
            this.label10.TabIndex = 34;
            this.label10.Text = "< Logout";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(396, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(239, 45);
            this.button3.TabIndex = 33;
            this.button3.Text = "Add Feedback";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(721, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 30);
            this.label4.TabIndex = 32;
            this.label4.Text = "Bills";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BillDGV
            // 
<<<<<<< HEAD
            this.BillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
=======
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
>>>>>>> c95f7139356dc744dc5fab087756fd21e09633a6
>>>>>>> eb0c822c4d08bda6e7c8a308d2cfb34688a97f2e
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
<<<<<<< HEAD
            this.BillDGV.Location = new System.Drawing.Point(455, 87);
            this.BillDGV.Name = "BillDGV";
            this.BillDGV.RowHeadersWidth = 62;
            this.BillDGV.RowTemplate.Height = 28;
            this.BillDGV.Size = new System.Drawing.Size(538, 180);
            this.BillDGV.TabIndex = 31;
=======
<<<<<<< HEAD
			this.BillDGV.Location = new System.Drawing.Point(303, 57);
			this.BillDGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.BillDGV.Name = "BillDGV";
			this.BillDGV.RowHeadersWidth = 62;
			this.BillDGV.RowTemplate.Height = 28;
			this.BillDGV.Size = new System.Drawing.Size(359, 117);
			this.BillDGV.TabIndex = 31;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "ID";
			this.Column1.MinimumWidth = 8;
			this.Column1.Name = "Column1";
			this.Column1.Width = 50;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Product";
			this.Column2.MinimumWidth = 8;
			this.Column2.Name = "Column2";
			this.Column2.Width = 150;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Price";
			this.Column3.MinimumWidth = 8;
			this.Column3.Name = "Column3";
			this.Column3.Width = 80;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Quantity";
			this.Column4.MinimumWidth = 8;
			this.Column4.Name = "Column4";
			this.Column4.Width = 80;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Total";
			this.Column5.MinimumWidth = 8;
			this.Column5.Name = "Column5";
			this.Column5.Width = 80;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.CustomerDGV);
			this.panel3.Controls.Add(this.ItemDGV);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Location = new System.Drawing.Point(9, 216);
			this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(653, 184);
			this.panel3.TabIndex = 30;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(67, -3);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(73, 13);
			this.label11.TabIndex = 37;
			this.label11.Text = "Crystal Report";
			// 
			// CustomerDGV
			// 
			this.CustomerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.CustomerDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustIDDGV,
            this.CustNameDGV,
            this.PhoneDGV});
			this.CustomerDGV.Location = new System.Drawing.Point(11, 31);
			this.CustomerDGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.CustomerDGV.Name = "CustomerDGV";
			this.CustomerDGV.RowHeadersWidth = 25;
			this.CustomerDGV.RowTemplate.Height = 28;
			this.CustomerDGV.Size = new System.Drawing.Size(313, 142);
			this.CustomerDGV.TabIndex = 37;
			this.CustomerDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDGV_CellClick);
			// 
			// CustIDDGV
			// 
			this.CustIDDGV.DataPropertyName = "CustId";
			this.CustIDDGV.HeaderText = "ID";
			this.CustIDDGV.MinimumWidth = 8;
			this.CustIDDGV.Name = "CustIDDGV";
			this.CustIDDGV.Width = 50;
			// 
			// CustNameDGV
			// 
			this.CustNameDGV.DataPropertyName = "CustName";
			this.CustNameDGV.HeaderText = "Name";
			this.CustNameDGV.MinimumWidth = 8;
			this.CustNameDGV.Name = "CustNameDGV";
			this.CustNameDGV.Width = 150;
			// 
			// PhoneDGV
			// 
			this.PhoneDGV.DataPropertyName = "CustPhone";
			this.PhoneDGV.HeaderText = "Phone";
			this.PhoneDGV.MinimumWidth = 8;
			this.PhoneDGV.Name = "PhoneDGV";
			this.PhoneDGV.Width = 75;
			// 
			// ItemDGV
			// 
			this.ItemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ItemDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDGV,
            this.NameDGV,
            this.CatDGV,
            this.TypeDGV,
            this.PriceDGV,
            this.QtyDGV});
			this.ItemDGV.Location = new System.Drawing.Point(328, 31);
			this.ItemDGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ItemDGV.Name = "ItemDGV";
			this.ItemDGV.RowHeadersWidth = 25;
			this.ItemDGV.RowTemplate.Height = 28;
			this.ItemDGV.Size = new System.Drawing.Size(313, 142);
			this.ItemDGV.TabIndex = 29;
			this.ItemDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemDGV_CellClick);
			// 
			// IDDGV
			// 
			this.IDDGV.DataPropertyName = "ItId";
			this.IDDGV.HeaderText = "ID";
			this.IDDGV.MinimumWidth = 8;
			this.IDDGV.Name = "IDDGV";
			this.IDDGV.Width = 50;
			// 
			// NameDGV
			// 
			this.NameDGV.DataPropertyName = "ItName";
			this.NameDGV.HeaderText = "Name";
			this.NameDGV.MinimumWidth = 8;
			this.NameDGV.Name = "NameDGV";
			this.NameDGV.Width = 150;
			// 
			// CatDGV
			// 
			this.CatDGV.DataPropertyName = "ItCat";
			this.CatDGV.HeaderText = "Categories";
			this.CatDGV.MinimumWidth = 8;
			this.CatDGV.Name = "CatDGV";
			this.CatDGV.Width = 90;
			// 
			// TypeDGV
			// 
			this.TypeDGV.DataPropertyName = "ItType";
			this.TypeDGV.HeaderText = "Type";
			this.TypeDGV.MinimumWidth = 8;
			this.TypeDGV.Name = "TypeDGV";
			this.TypeDGV.Width = 75;
			// 
			// PriceDGV
			// 
			this.PriceDGV.DataPropertyName = "ItPrice";
			this.PriceDGV.HeaderText = "Price";
			this.PriceDGV.MinimumWidth = 8;
			this.PriceDGV.Name = "PriceDGV";
			this.PriceDGV.Width = 75;
			// 
			// QtyDGV
			// 
			this.QtyDGV.DataPropertyName = "ItQty";
			this.QtyDGV.HeaderText = "Qty";
			this.QtyDGV.MinimumWidth = 8;
			this.QtyDGV.Name = "QtyDGV";
			this.QtyDGV.Width = 75;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Cursor = System.Windows.Forms.Cursors.AppStarting;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(443, 10);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 21);
			this.label2.TabIndex = 28;
			this.label2.Text = "Product List";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Hardware_Pro_Manager.Properties.Resources.Designer__5__upscaled;
			this.pictureBox1.Location = new System.Drawing.Point(279, 10);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(27, 20);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Document = this.printDocument1;
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// Billing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Firebrick;
			this.ClientSize = new System.Drawing.Size(691, 426);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Billing";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Billing";
			this.Load += new System.EventHandler(this.Billing_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.BillDGV)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemDGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
=======
            this.dataGridView3.Location = new System.Drawing.Point(455, 87);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(538, 180);
            this.dataGridView3.TabIndex = 31;
>>>>>>> eb0c822c4d08bda6e7c8a308d2cfb34688a97f2e
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.CustomerDGV);
            this.panel3.Controls.Add(this.ItemDGV);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(13, 332);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 283);
            this.panel3.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(101, -5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "Crystal Report";
            // 
            // CustomerDGV
            // 
            this.CustomerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustIDDGV,
            this.CustNameDGV,
            this.PhoneDGV});
            this.CustomerDGV.Location = new System.Drawing.Point(16, 48);
            this.CustomerDGV.Name = "CustomerDGV";
            this.CustomerDGV.RowHeadersWidth = 25;
            this.CustomerDGV.RowTemplate.Height = 28;
            this.CustomerDGV.Size = new System.Drawing.Size(470, 219);
            this.CustomerDGV.TabIndex = 37;
            this.CustomerDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDGV_CellClick);
            // 
            // CustIDDGV
            // 
            this.CustIDDGV.DataPropertyName = "CustId";
            this.CustIDDGV.HeaderText = "ID";
            this.CustIDDGV.MinimumWidth = 8;
            this.CustIDDGV.Name = "CustIDDGV";
            this.CustIDDGV.Width = 50;
            // 
            // CustNameDGV
            // 
            this.CustNameDGV.DataPropertyName = "CustName";
            this.CustNameDGV.HeaderText = "Name";
            this.CustNameDGV.MinimumWidth = 8;
            this.CustNameDGV.Name = "CustNameDGV";
            this.CustNameDGV.Width = 150;
            // 
            // PhoneDGV
            // 
            this.PhoneDGV.DataPropertyName = "CustPhone";
            this.PhoneDGV.HeaderText = "Phone";
            this.PhoneDGV.MinimumWidth = 8;
            this.PhoneDGV.Name = "PhoneDGV";
            this.PhoneDGV.Width = 75;
            // 
            // ItemDGV
            // 
            this.ItemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDGV,
            this.NameDGV,
            this.CatDGV,
            this.TypeDGV,
            this.PriceDGV,
            this.QtyDGV});
            this.ItemDGV.Location = new System.Drawing.Point(492, 48);
            this.ItemDGV.Name = "ItemDGV";
            this.ItemDGV.RowHeadersWidth = 25;
            this.ItemDGV.RowTemplate.Height = 28;
            this.ItemDGV.Size = new System.Drawing.Size(470, 219);
            this.ItemDGV.TabIndex = 29;
            this.ItemDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemDGV_CellClick);
            // 
            // IDDGV
            // 
            this.IDDGV.DataPropertyName = "ItId";
            this.IDDGV.HeaderText = "ID";
            this.IDDGV.MinimumWidth = 8;
            this.IDDGV.Name = "IDDGV";
            this.IDDGV.Width = 50;
            // 
            // NameDGV
            // 
            this.NameDGV.DataPropertyName = "ItName";
            this.NameDGV.HeaderText = "Name";
            this.NameDGV.MinimumWidth = 8;
            this.NameDGV.Name = "NameDGV";
            this.NameDGV.Width = 150;
            // 
            // CatDGV
            // 
            this.CatDGV.DataPropertyName = "ItCat";
            this.CatDGV.HeaderText = "Categories";
            this.CatDGV.MinimumWidth = 8;
            this.CatDGV.Name = "CatDGV";
            this.CatDGV.Width = 90;
            // 
            // TypeDGV
            // 
            this.TypeDGV.DataPropertyName = "ItType";
            this.TypeDGV.HeaderText = "Type";
            this.TypeDGV.MinimumWidth = 8;
            this.TypeDGV.Name = "TypeDGV";
            this.TypeDGV.Width = 75;
            // 
            // PriceDGV
            // 
            this.PriceDGV.DataPropertyName = "ItPrice";
            this.PriceDGV.HeaderText = "Price";
            this.PriceDGV.MinimumWidth = 8;
            this.PriceDGV.Name = "PriceDGV";
            this.PriceDGV.Width = 75;
            // 
            // QtyDGV
            // 
            this.QtyDGV.DataPropertyName = "ItQty";
            this.QtyDGV.HeaderText = "Qty";
            this.QtyDGV.MinimumWidth = 8;
            this.QtyDGV.Name = "QtyDGV";
            this.QtyDGV.Width = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(665, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 30);
            this.label2.TabIndex = 28;
            this.label2.Text = "Product List";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hardware_Pro_Manager.Properties.Resources.Designer__5__upscaled;
            this.pictureBox1.Location = new System.Drawing.Point(418, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1036, 656);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
>>>>>>> c95f7139356dc744dc5fab087756fd21e09633a6

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
<<<<<<< HEAD
        private System.Windows.Forms.Button PrintBtn;
=======
<<<<<<< HEAD
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ProdPriceTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProdNameTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddToBillBtn;
        private System.Windows.Forms.TextBox ProdQtyTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CustNameTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView BillDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView ItemDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyDGV;
        private System.Windows.Forms.Label TotalLbl;
=======
        private System.Windows.Forms.Button button2;
>>>>>>> eb0c822c4d08bda6e7c8a308d2cfb34688a97f2e
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ProdPriceTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProdNameTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddToBillBtn;
        private System.Windows.Forms.TextBox ProdQtyTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CustNameTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView BillDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
<<<<<<< HEAD
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView ItemDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyDGV;
        private System.Windows.Forms.Label TotalLbl;
=======
>>>>>>> c95f7139356dc744dc5fab087756fd21e09633a6
>>>>>>> eb0c822c4d08bda6e7c8a308d2cfb34688a97f2e
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> eb0c822c4d08bda6e7c8a308d2cfb34688a97f2e
        private System.Windows.Forms.DataGridView CustomerDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustIDDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustNameDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneDGV;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button ViewSells;
        private System.Windows.Forms.Label label11;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
<<<<<<< HEAD
=======
=======
        private System.Windows.Forms.Label label10;
>>>>>>> c95f7139356dc744dc5fab087756fd21e09633a6
>>>>>>> eb0c822c4d08bda6e7c8a308d2cfb34688a97f2e
    }
}
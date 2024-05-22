namespace MilkDistributionApp
{
    partial class FrmBillPay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBillPay));
            this.panelBillPay = new System.Windows.Forms.Panel();
            this.panelBack = new System.Windows.Forms.Panel();
            this.panelFront = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.dgvCustomerBillDetails = new System.Windows.Forms.DataGridView();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.txtBuffMilk = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCustYear = new System.Windows.Forms.TextBox();
            this.txtCustMonth = new System.Windows.Forms.TextBox();
            this.txtCowMilk = new System.Windows.Forms.TextBox();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.txtCustMobile = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtRecieptNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPayNow = new System.Windows.Forms.Button();
            this.txtBalAmt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPaidAmt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPreBal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalAmt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBillPay.SuspendLayout();
            this.panelBack.SuspendLayout();
            this.panelFront.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerBillDetails)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBillPay
            // 
            this.panelBillPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBillPay.Controls.Add(this.panelBack);
            this.panelBillPay.Location = new System.Drawing.Point(2, 2);
            this.panelBillPay.Name = "panelBillPay";
            this.panelBillPay.Size = new System.Drawing.Size(1153, 671);
            this.panelBillPay.TabIndex = 0;
            this.panelBillPay.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBillPay_Paint);
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.White;
            this.panelBack.Controls.Add(this.panelFront);
            this.panelBack.Controls.Add(this.panel4);
            this.panelBack.Controls.Add(this.panel5);
            this.panelBack.Location = new System.Drawing.Point(4, 3);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(1144, 665);
            this.panelBack.TabIndex = 1;
            // 
            // panelFront
            // 
            this.panelFront.BackColor = System.Drawing.Color.White;
            this.panelFront.Controls.Add(this.btnExport);
            this.panelFront.Controls.Add(this.label15);
            this.panelFront.Controls.Add(this.txtSearchCustomer);
            this.panelFront.Controls.Add(this.dgvCustomerBillDetails);
            this.panelFront.Controls.Add(this.btnPrintAll);
            this.panelFront.Controls.Add(this.panel8);
            this.panelFront.Location = new System.Drawing.Point(-3, -4);
            this.panelFront.Name = "panelFront";
            this.panelFront.Size = new System.Drawing.Size(1152, 666);
            this.panelFront.TabIndex = 0;
            this.panelFront.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFront_Paint);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.BackgroundImage = global::MilkDistributionApp.Properties.Resources.Excel_removebg_preview;
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(749, 77);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(58, 39);
            this.btnExport.TabIndex = 641;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(288, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 18);
            this.label15.TabIndex = 634;
            this.label15.Text = "Search Customer";
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.Location = new System.Drawing.Point(443, 85);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(242, 26);
            this.txtSearchCustomer.TabIndex = 633;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            // 
            // dgvCustomerBillDetails
            // 
            this.dgvCustomerBillDetails.AllowUserToAddRows = false;
            this.dgvCustomerBillDetails.AllowUserToDeleteRows = false;
            this.dgvCustomerBillDetails.AllowUserToResizeRows = false;
            this.dgvCustomerBillDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerBillDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomerBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerBillDetails.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCustomerBillDetails.Location = new System.Drawing.Point(197, 128);
            this.dgvCustomerBillDetails.Name = "dgvCustomerBillDetails";
            this.dgvCustomerBillDetails.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerBillDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCustomerBillDetails.RowHeadersVisible = false;
            this.dgvCustomerBillDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerBillDetails.Size = new System.Drawing.Size(729, 490);
            this.dgvCustomerBillDetails.TabIndex = 632;
            this.dgvCustomerBillDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerBillDetails_CellClick);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrintAll.BackgroundImage")));
            this.btnPrintAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintAll.FlatAppearance.BorderSize = 0;
            this.btnPrintAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPrintAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrintAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrintAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintAll.Location = new System.Drawing.Point(699, 75);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(49, 42);
            this.btnPrintAll.TabIndex = 639;
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel8.Controls.Add(this.label16);
            this.panel8.Controls.Add(this.btnClose);
            this.panel8.Location = new System.Drawing.Point(2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1151, 50);
            this.panel8.TabIndex = 631;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(427, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(254, 33);
            this.label16.TabIndex = 1;
            this.label16.Text = "Bill Customer List";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1103, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 30);
            this.btnClose.TabIndex = 632;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.btnPayNow);
            this.panel4.Controls.Add(this.txtBalAmt);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txtPaidAmt);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txtPreBal);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txtTotalAmt);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(119, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(897, 593);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MilkDistributionApp.Properties.Resources.milklogo2;
            this.pictureBox1.Location = new System.Drawing.Point(313, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 638;
            this.pictureBox1.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(425, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 16);
            this.label18.TabIndex = 637;
            this.label18.Text = "For healty life";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(409, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(143, 32);
            this.label19.TabIndex = 636;
            this.label19.Text = "Milk Dairy";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.txtCustID);
            this.panel3.Controls.Add(this.dtpBillDate);
            this.panel3.Controls.Add(this.txtBuffMilk);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.txtCustYear);
            this.panel3.Controls.Add(this.txtCustMonth);
            this.panel3.Controls.Add(this.txtCowMilk);
            this.panel3.Controls.Add(this.txtCustAddress);
            this.panel3.Controls.Add(this.txtCustMobile);
            this.panel3.Controls.Add(this.txtCustName);
            this.panel3.Controls.Add(this.txtRecieptNo);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(102, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(679, 247);
            this.panel3.TabIndex = 635;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkGreen;
            this.label20.Location = new System.Drawing.Point(269, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(114, 23);
            this.label20.TabIndex = 639;
            this.label20.Text = "Monthly Bill";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(306, 94);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(38, 20);
            this.txtCustID.TabIndex = 638;
            this.txtCustID.Visible = false;
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.Location = new System.Drawing.Point(451, 56);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(209, 20);
            this.dtpBillDate.TabIndex = 113;
            // 
            // txtBuffMilk
            // 
            this.txtBuffMilk.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuffMilk.Location = new System.Drawing.Point(451, 118);
            this.txtBuffMilk.Name = "txtBuffMilk";
            this.txtBuffMilk.Size = new System.Drawing.Size(209, 23);
            this.txtBuffMilk.TabIndex = 112;
            this.txtBuffMilk.Text = " ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century", 9.75F);
            this.label17.Location = new System.Drawing.Point(374, 118);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 16);
            this.label17.TabIndex = 111;
            this.label17.Text = "Buff Milk";
            // 
            // txtCustYear
            // 
            this.txtCustYear.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustYear.Location = new System.Drawing.Point(451, 183);
            this.txtCustYear.Name = "txtCustYear";
            this.txtCustYear.Size = new System.Drawing.Size(209, 23);
            this.txtCustYear.TabIndex = 109;
            this.txtCustYear.Text = " ";
            // 
            // txtCustMonth
            // 
            this.txtCustMonth.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustMonth.Location = new System.Drawing.Point(451, 150);
            this.txtCustMonth.Name = "txtCustMonth";
            this.txtCustMonth.Size = new System.Drawing.Size(209, 23);
            this.txtCustMonth.TabIndex = 108;
            this.txtCustMonth.Text = " ";
            // 
            // txtCowMilk
            // 
            this.txtCowMilk.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCowMilk.Location = new System.Drawing.Point(451, 86);
            this.txtCowMilk.Name = "txtCowMilk";
            this.txtCowMilk.Size = new System.Drawing.Size(209, 23);
            this.txtCowMilk.TabIndex = 107;
            this.txtCowMilk.Text = " ";
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustAddress.Location = new System.Drawing.Point(91, 170);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(209, 23);
            this.txtCustAddress.TabIndex = 106;
            this.txtCustAddress.Text = " ";
            // 
            // txtCustMobile
            // 
            this.txtCustMobile.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustMobile.Location = new System.Drawing.Point(91, 131);
            this.txtCustMobile.Name = "txtCustMobile";
            this.txtCustMobile.Size = new System.Drawing.Size(209, 23);
            this.txtCustMobile.TabIndex = 105;
            this.txtCustMobile.Text = " ";
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(91, 92);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(209, 23);
            this.txtCustName.TabIndex = 104;
            this.txtCustName.Text = " ";
            // 
            // txtRecieptNo
            // 
            this.txtRecieptNo.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecieptNo.Location = new System.Drawing.Point(91, 54);
            this.txtRecieptNo.Name = "txtRecieptNo";
            this.txtRecieptNo.Size = new System.Drawing.Size(209, 23);
            this.txtRecieptNo.TabIndex = 103;
            this.txtRecieptNo.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 9.75F);
            this.label9.Location = new System.Drawing.Point(374, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Cow Milk";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 9.75F);
            this.label8.Location = new System.Drawing.Point(374, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Bill Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 9.75F);
            this.label7.Location = new System.Drawing.Point(376, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 9.75F);
            this.label6.Location = new System.Drawing.Point(376, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 9.75F);
            this.label5.Location = new System.Drawing.Point(13, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9.75F);
            this.label4.Location = new System.Drawing.Point(13, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mobile No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F);
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cust Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F);
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receipt No";
            // 
            // btnPayNow
            // 
            this.btnPayNow.BackgroundImage = global::MilkDistributionApp.Properties.Resources.f_removebg_preview10;
            this.btnPayNow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayNow.FlatAppearance.BorderSize = 0;
            this.btnPayNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayNow.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayNow.ForeColor = System.Drawing.Color.White;
            this.btnPayNow.Location = new System.Drawing.Point(426, 519);
            this.btnPayNow.Name = "btnPayNow";
            this.btnPayNow.Size = new System.Drawing.Size(121, 55);
            this.btnPayNow.TabIndex = 634;
            this.btnPayNow.Text = "Pay Now";
            this.btnPayNow.UseVisualStyleBackColor = true;
            this.btnPayNow.Click += new System.EventHandler(this.btnPayNow_Click);
            // 
            // txtBalAmt
            // 
            this.txtBalAmt.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalAmt.Location = new System.Drawing.Point(338, 486);
            this.txtBalAmt.Name = "txtBalAmt";
            this.txtBalAmt.Size = new System.Drawing.Size(294, 23);
            this.txtBalAmt.TabIndex = 114;
            this.txtBalAmt.Text = " ";
            this.txtBalAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century", 9.75F);
            this.label13.Location = new System.Drawing.Point(207, 489);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 16);
            this.label13.TabIndex = 113;
            this.label13.Text = "Balance Amount";
            // 
            // txtPaidAmt
            // 
            this.txtPaidAmt.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmt.Location = new System.Drawing.Point(338, 448);
            this.txtPaidAmt.Name = "txtPaidAmt";
            this.txtPaidAmt.Size = new System.Drawing.Size(294, 23);
            this.txtPaidAmt.TabIndex = 1;
            this.txtPaidAmt.Text = " ";
            this.txtPaidAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaidAmt.TextChanged += new System.EventHandler(this.txtPaidAmt_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century", 9.75F);
            this.label12.Location = new System.Drawing.Point(207, 451);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 16);
            this.label12.TabIndex = 111;
            this.label12.Text = "Paid Amount";
            // 
            // txtPreBal
            // 
            this.txtPreBal.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreBal.Location = new System.Drawing.Point(338, 408);
            this.txtPreBal.Name = "txtPreBal";
            this.txtPreBal.Size = new System.Drawing.Size(294, 23);
            this.txtPreBal.TabIndex = 110;
            this.txtPreBal.Text = " 0";
            this.txtPreBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 9.75F);
            this.label11.Location = new System.Drawing.Point(207, 411);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 16);
            this.label11.TabIndex = 109;
            this.label11.Text = "Previous Balance";
            // 
            // txtTotalAmt
            // 
            this.txtTotalAmt.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmt.Location = new System.Drawing.Point(338, 368);
            this.txtTotalAmt.Name = "txtTotalAmt";
            this.txtTotalAmt.Size = new System.Drawing.Size(294, 23);
            this.txtTotalAmt.TabIndex = 108;
            this.txtTotalAmt.Text = " ";
            this.txtTotalAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 9.75F);
            this.label10.Location = new System.Drawing.Point(207, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 107;
            this.label10.Text = "Total Amount";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.btnBack);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(2, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1147, 42);
            this.panel5.TabIndex = 632;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::MilkDistributionApp.Properties.Resources.f_removebg_preview10;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(5, -4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 46);
            this.btnBack.TabIndex = 76;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(536, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bill ";
            // 
            // FrmBillPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 674);
            this.Controls.Add(this.panelBillPay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBillPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBillPay";
            this.Load += new System.EventHandler(this.FrmBillPay_Load);
            this.Shown += new System.EventHandler(this.FrmBillPay_Shown);
            this.panelBillPay.ResumeLayout(false);
            this.panelBack.ResumeLayout(false);
            this.panelFront.ResumeLayout(false);
            this.panelFront.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerBillDetails)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBillPay;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnPayNow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelFront;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.DataGridView dgvCustomerBillDetails;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtBalAmt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPaidAmt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalAmt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.TextBox txtBuffMilk;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCustYear;
        private System.Windows.Forms.TextBox txtCustMonth;
        private System.Windows.Forms.TextBox txtCowMilk;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.TextBox txtCustMobile;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtRecieptNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPrintAll;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtPreBal;
    }
}
namespace MilkDistributionApp
{
    partial class FrmNewDashbord
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("DashBoard");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Add MilkMan");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("AddRoute");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("AddProducts");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("AddCustomer");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("CustomerDetails");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Generate Bill", 9, 9);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("BillPay");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Payment History");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewDashbord));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.lblCompanyAdd = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlForms = new System.Windows.Forms.Panel();
            this.panDash = new System.Windows.Forms.Panel();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotalAmt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlBalance = new System.Windows.Forms.Panel();
            this.lblBalanceAmt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panPaidAmt = new System.Windows.Forms.Panel();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelDeactive = new System.Windows.Forms.Panel();
            this.lblDeactiveCust = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelActive = new System.Windows.Forms.Panel();
            this.lblactiveCust = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panDash.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.pnlBalance.SuspendLayout();
            this.panPaidAmt.SuspendLayout();
            this.panelDeactive.SuspendLayout();
            this.panelActive.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Controls.Add(this.pnlForms);
            this.panel2.Controls.Add(this.panDash);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 768);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.BackgroundImage = global::MilkDistributionApp.Properties.Resources.o10;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnMinimized);
            this.panel1.Controls.Add(this.lblCompanyAdd);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblCompanyName);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1359, 88);
            this.panel1.TabIndex = 612;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MilkDistributionApp.Properties.Resources.milklogo2;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimized.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimized.BackgroundImage = global::MilkDistributionApp.Properties.Resources.download_removebg_preview;
            this.btnMinimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.Location = new System.Drawing.Point(1270, 4);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(48, 44);
            this.btnMinimized.TabIndex = 611;
            this.btnMinimized.UseVisualStyleBackColor = false;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // lblCompanyAdd
            // 
            this.lblCompanyAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompanyAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyAdd.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblCompanyAdd.ForeColor = System.Drawing.Color.White;
            this.lblCompanyAdd.Location = new System.Drawing.Point(-2, 48);
            this.lblCompanyAdd.Name = "lblCompanyAdd";
            this.lblCompanyAdd.Size = new System.Drawing.Size(1358, 35);
            this.lblCompanyAdd.TabIndex = 640;
            this.lblCompanyAdd.Text = "Generate Bill";
            this.lblCompanyAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::MilkDistributionApp.Properties.Resources.images_close__prev_ui;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1319, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 33);
            this.btnClose.TabIndex = 610;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompanyName.AutoEllipsis = true;
            this.lblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.White;
            this.lblCompanyName.Location = new System.Drawing.Point(-5, -1);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(1362, 49);
            this.lblCompanyName.TabIndex = 639;
            this.lblCompanyName.Text = "Generate Bill";
            this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.treeView1.Font = new System.Drawing.Font("Century", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Indent = 20;
            this.treeView1.ItemHeight = 45;
            this.treeView1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.treeView1.Location = new System.Drawing.Point(0, 88);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 7;
            treeNode1.Name = "DashBoard";
            treeNode1.SelectedImageKey = "download__1_-removebg-preview (1).png";
            treeNode1.Text = "DashBoard";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "FrmAddMilkMan";
            treeNode2.SelectedImageKey = "milkman_2_-removebg-preview.png";
            treeNode2.Text = "Add MilkMan";
            treeNode3.ImageIndex = 5;
            treeNode3.Name = "FrmAddRoute";
            treeNode3.SelectedImageKey = "608769.png";
            treeNode3.Text = "AddRoute";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "FrmAddProducts";
            treeNode4.SelectedImageKey = "Product.jpg";
            treeNode4.Text = "AddProducts";
            treeNode5.ImageIndex = 2;
            treeNode5.Name = "FrmAddCustomer";
            treeNode5.SelectedImageKey = "download__1_-removebg-preview.png";
            treeNode5.Text = "AddCustomer";
            treeNode6.ImageIndex = 2;
            treeNode6.Name = "FrmCustomerDetails";
            treeNode6.SelectedImageKey = "download__1_-removebg-preview.png";
            treeNode6.Text = "CustomerDetails";
            treeNode7.ImageIndex = 9;
            treeNode7.Name = "GenerateBill";
            treeNode7.SelectedImageIndex = 9;
            treeNode7.Text = "Generate Bill";
            treeNode8.ImageIndex = 3;
            treeNode8.Name = "FrmBillPay";
            treeNode8.SelectedImageKey = "billpay.png";
            treeNode8.Text = "BillPay";
            treeNode9.ImageIndex = 4;
            treeNode9.Name = "FrmPaymentHistory";
            treeNode9.SelectedImageKey = "payment-removebg-preview.png";
            treeNode9.Text = "Payment History";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(204, 677);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "milkman_2_-removebg-preview.png");
            this.imageList1.Images.SetKeyName(1, "Product.jpg");
            this.imageList1.Images.SetKeyName(2, "download__1_-removebg-preview.png");
            this.imageList1.Images.SetKeyName(3, "billpay.png");
            this.imageList1.Images.SetKeyName(4, "payment-removebg-preview.png");
            this.imageList1.Images.SetKeyName(5, "608769.png");
            this.imageList1.Images.SetKeyName(6, "milkman_2_-removebg-preview.png");
            this.imageList1.Images.SetKeyName(7, "download__1_-removebg-preview (1).png");
            this.imageList1.Images.SetKeyName(8, "download (1).png");
            this.imageList1.Images.SetKeyName(9, "generate-removebg-preview.png");
            // 
            // pnlForms
            // 
            this.pnlForms.BackColor = System.Drawing.Color.Silver;
            this.pnlForms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlForms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlForms.ForeColor = System.Drawing.Color.Black;
            this.pnlForms.Location = new System.Drawing.Point(204, 88);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(1158, 677);
            this.pnlForms.TabIndex = 613;
            // 
            // panDash
            // 
            this.panDash.BackColor = System.Drawing.Color.Silver;
            this.panDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panDash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panDash.Controls.Add(this.pnlTotal);
            this.panDash.Controls.Add(this.pnlBalance);
            this.panDash.Controls.Add(this.panPaidAmt);
            this.panDash.Controls.Add(this.panelDeactive);
            this.panDash.Controls.Add(this.panelActive);
            this.panDash.Controls.Add(this.btnGenerateBill);
            this.panDash.ForeColor = System.Drawing.Color.Black;
            this.panDash.Location = new System.Drawing.Point(204, 88);
            this.panDash.Name = "panDash";
            this.panDash.Size = new System.Drawing.Size(1158, 680);
            this.panDash.TabIndex = 5;
            // 
            // pnlTotal
            // 
            this.pnlTotal.BackgroundImage = global::MilkDistributionApp.Properties.Resources._96247682;
            this.pnlTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTotal.Controls.Add(this.lblTotalAmt);
            this.pnlTotal.Controls.Add(this.label4);
            this.pnlTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlTotal.Location = new System.Drawing.Point(87, 339);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(284, 216);
            this.pnlTotal.TabIndex = 646;
            this.pnlTotal.Click += new System.EventHandler(this.pnlTotal_Click);
            this.pnlTotal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTotal_Paint);
            // 
            // lblTotalAmt
            // 
            this.lblTotalAmt.AutoSize = true;
            this.lblTotalAmt.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalAmt.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmt.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmt.Location = new System.Drawing.Point(122, 80);
            this.lblTotalAmt.Name = "lblTotalAmt";
            this.lblTotalAmt.Size = new System.Drawing.Size(25, 27);
            this.lblTotalAmt.TabIndex = 3;
            this.lblTotalAmt.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(63, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Amount";
            // 
            // pnlBalance
            // 
            this.pnlBalance.BackgroundImage = global::MilkDistributionApp.Properties.Resources._96247682;
            this.pnlBalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBalance.Controls.Add(this.lblBalanceAmt);
            this.pnlBalance.Controls.Add(this.label9);
            this.pnlBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBalance.Location = new System.Drawing.Point(794, 339);
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.Size = new System.Drawing.Size(284, 216);
            this.pnlBalance.TabIndex = 645;
            this.pnlBalance.Click += new System.EventHandler(this.pnlBalance_Click);
            // 
            // lblBalanceAmt
            // 
            this.lblBalanceAmt.AutoSize = true;
            this.lblBalanceAmt.BackColor = System.Drawing.Color.Transparent;
            this.lblBalanceAmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBalanceAmt.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceAmt.ForeColor = System.Drawing.Color.White;
            this.lblBalanceAmt.Location = new System.Drawing.Point(122, 80);
            this.lblBalanceAmt.Name = "lblBalanceAmt";
            this.lblBalanceAmt.Size = new System.Drawing.Size(25, 27);
            this.lblBalanceAmt.TabIndex = 3;
            this.lblBalanceAmt.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(52, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Balance Amount";
            // 
            // panPaidAmt
            // 
            this.panPaidAmt.BackgroundImage = global::MilkDistributionApp.Properties.Resources._96247683;
            this.panPaidAmt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panPaidAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panPaidAmt.Controls.Add(this.lblPaidAmount);
            this.panPaidAmt.Controls.Add(this.label7);
            this.panPaidAmt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panPaidAmt.Location = new System.Drawing.Point(442, 339);
            this.panPaidAmt.Name = "panPaidAmt";
            this.panPaidAmt.Size = new System.Drawing.Size(284, 216);
            this.panPaidAmt.TabIndex = 645;
            this.panPaidAmt.Click += new System.EventHandler(this.panPaidAmt_Click);
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblPaidAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPaidAmount.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidAmount.ForeColor = System.Drawing.Color.White;
            this.lblPaidAmount.Location = new System.Drawing.Point(122, 80);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(25, 27);
            this.lblPaidAmount.TabIndex = 3;
            this.lblPaidAmount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(71, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Paid Amount";
            // 
            // panelDeactive
            // 
            this.panelDeactive.BackgroundImage = global::MilkDistributionApp.Properties.Resources._96247682;
            this.panelDeactive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDeactive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDeactive.Controls.Add(this.lblDeactiveCust);
            this.panelDeactive.Controls.Add(this.label5);
            this.panelDeactive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelDeactive.Location = new System.Drawing.Point(618, 64);
            this.panelDeactive.Name = "panelDeactive";
            this.panelDeactive.Size = new System.Drawing.Size(284, 216);
            this.panelDeactive.TabIndex = 645;
            this.panelDeactive.Click += new System.EventHandler(this.panelDeactive_Click);
            // 
            // lblDeactiveCust
            // 
            this.lblDeactiveCust.AutoSize = true;
            this.lblDeactiveCust.BackColor = System.Drawing.Color.Transparent;
            this.lblDeactiveCust.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeactiveCust.ForeColor = System.Drawing.Color.White;
            this.lblDeactiveCust.Location = new System.Drawing.Point(125, 78);
            this.lblDeactiveCust.Name = "lblDeactiveCust";
            this.lblDeactiveCust.Size = new System.Drawing.Size(25, 27);
            this.lblDeactiveCust.TabIndex = 3;
            this.lblDeactiveCust.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(51, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Deactive Customer";
            // 
            // panelActive
            // 
            this.panelActive.BackgroundImage = global::MilkDistributionApp.Properties.Resources._96247682;
            this.panelActive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelActive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelActive.Controls.Add(this.lblactiveCust);
            this.panelActive.Controls.Add(this.label2);
            this.panelActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelActive.Location = new System.Drawing.Point(264, 64);
            this.panelActive.Name = "panelActive";
            this.panelActive.Size = new System.Drawing.Size(284, 216);
            this.panelActive.TabIndex = 644;
            this.panelActive.Click += new System.EventHandler(this.panelActive_Click);
            this.panelActive.Paint += new System.Windows.Forms.PaintEventHandler(this.panelActive_Paint);
            // 
            // lblactiveCust
            // 
            this.lblactiveCust.AutoSize = true;
            this.lblactiveCust.BackColor = System.Drawing.Color.Transparent;
            this.lblactiveCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblactiveCust.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblactiveCust.ForeColor = System.Drawing.Color.White;
            this.lblactiveCust.Location = new System.Drawing.Point(122, 80);
            this.lblactiveCust.Name = "lblactiveCust";
            this.lblactiveCust.Size = new System.Drawing.Size(25, 27);
            this.lblactiveCust.TabIndex = 1;
            this.lblactiveCust.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Active Customer";
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateBill.BackgroundImage = global::MilkDistributionApp.Properties.Resources.generate_removebg_preview;
            this.btnGenerateBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerateBill.FlatAppearance.BorderSize = 0;
            this.btnGenerateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateBill.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateBill.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerateBill.Location = new System.Drawing.Point(972, 594);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(62, 53);
            this.btnGenerateBill.TabIndex = 637;
            this.btnGenerateBill.UseVisualStyleBackColor = false;
            this.btnGenerateBill.Visible = false;
            // 
            // FrmNewDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNewDashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNewDashbord";
            this.Load += new System.EventHandler(this.FrmNewDashbord_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panDash.ResumeLayout(false);
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.pnlBalance.ResumeLayout(false);
            this.pnlBalance.PerformLayout();
            this.panPaidAmt.ResumeLayout(false);
            this.panPaidAmt.PerformLayout();
            this.panelDeactive.ResumeLayout(false);
            this.panelDeactive.PerformLayout();
            this.panelActive.ResumeLayout(false);
            this.panelActive.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMinimized;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panDash;
        private System.Windows.Forms.Button btnGenerateBill;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCompanyAdd;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBalance;
        private System.Windows.Forms.Panel panPaidAmt;
        private System.Windows.Forms.Panel panelDeactive;
        private System.Windows.Forms.Panel panelActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDeactiveCust;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblactiveCust;
        private System.Windows.Forms.Label lblBalanceAmt;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotalAmt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlForms;
    }
}
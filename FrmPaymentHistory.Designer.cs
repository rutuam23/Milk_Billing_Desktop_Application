namespace MilkDistributionApp
{
    partial class FrmPaymentHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaymentHistory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBack = new System.Windows.Forms.Panel();
            this.panelFront = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.dgvPaymentlist = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvPaymentDetails = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPaymentHistory = new System.Windows.Forms.Panel();
            this.panelBack.SuspendLayout();
            this.panelFront.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentlist)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panelPaymentHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.White;
            this.panelBack.Controls.Add(this.panelFront);
            this.panelBack.Controls.Add(this.panel2);
            this.panelBack.Controls.Add(this.panel4);
            this.panelBack.Location = new System.Drawing.Point(3, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(1162, 665);
            this.panelBack.TabIndex = 0;
            // 
            // panelFront
            // 
            this.panelFront.BackColor = System.Drawing.Color.White;
            this.panelFront.Controls.Add(this.panel1);
            this.panelFront.Controls.Add(this.panel3);
            this.panelFront.Location = new System.Drawing.Point(1, 2);
            this.panelFront.Name = "panelFront";
            this.panelFront.Size = new System.Drawing.Size(1161, 660);
            this.panelFront.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnPrintAll);
            this.panel1.Controls.Add(this.txtSearchCustomer);
            this.panel1.Controls.Add(this.dgvPaymentlist);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(91, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 558);
            this.panel1.TabIndex = 82;
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
            this.btnExport.Location = new System.Drawing.Point(671, 17);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(58, 39);
            this.btnExport.TabIndex = 643;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            this.btnPrintAll.Location = new System.Drawing.Point(619, 18);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(52, 38);
            this.btnPrintAll.TabIndex = 639;
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.Location = new System.Drawing.Point(338, 26);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(264, 26);
            this.txtSearchCustomer.TabIndex = 80;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            // 
            // dgvPaymentlist
            // 
            this.dgvPaymentlist.AllowUserToAddRows = false;
            this.dgvPaymentlist.AllowUserToDeleteRows = false;
            this.dgvPaymentlist.AllowUserToResizeRows = false;
            this.dgvPaymentlist.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPaymentlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentlist.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPaymentlist.Location = new System.Drawing.Point(59, 80);
            this.dgvPaymentlist.Name = "dgvPaymentlist";
            this.dgvPaymentlist.RowHeadersVisible = false;
            this.dgvPaymentlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentlist.Size = new System.Drawing.Size(871, 420);
            this.dgvPaymentlist.TabIndex = 81;
            this.dgvPaymentlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentlist_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(207, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 18);
            this.label7.TabIndex = 79;
            this.label7.Text = "Search Customer";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1158, 49);
            this.panel3.TabIndex = 78;
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
            this.btnClose.Location = new System.Drawing.Point(1103, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 30);
            this.btnClose.TabIndex = 634;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(439, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Payment History List";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.dgvPaymentDetails);
            this.panel2.Controls.Add(this.txtCustId);
            this.panel2.Controls.Add(this.txtNumber);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(300, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 501);
            this.panel2.TabIndex = 79;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(264, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 16);
            this.label18.TabIndex = 638;
            this.label18.Text = "For healty life";
            // 
            // dgvPaymentDetails
            // 
            this.dgvPaymentDetails.AllowUserToAddRows = false;
            this.dgvPaymentDetails.AllowUserToDeleteRows = false;
            this.dgvPaymentDetails.AllowUserToResizeRows = false;
            this.dgvPaymentDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPaymentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Month,
            this.Amount});
            this.dgvPaymentDetails.Location = new System.Drawing.Point(80, 180);
            this.dgvPaymentDetails.Name = "dgvPaymentDetails";
            this.dgvPaymentDetails.RowHeadersVisible = false;
            this.dgvPaymentDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentDetails.Size = new System.Drawing.Size(393, 283);
            this.dgvPaymentDetails.TabIndex = 80;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 150;
            // 
            // Month
            // 
            this.Month.HeaderText = "Month";
            this.Month.Name = "Month";
            this.Month.Width = 120;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.Width = 120;
            // 
            // txtCustId
            // 
            this.txtCustId.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustId.Location = new System.Drawing.Point(394, 92);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(40, 23);
            this.txtCustId.TabIndex = 9;
            this.txtCustId.Visible = false;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(165, 131);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(223, 23);
            this.txtNumber.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(165, 92);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(223, 23);
            this.txtName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MilkDistributionApp.Properties.Resources.milklogo2;
            this.pictureBox1.Location = new System.Drawing.Point(129, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(249, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Milk Dairy";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btnBack);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1159, 52);
            this.panel4.TabIndex = 78;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1109, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 30);
            this.button1.TabIndex = 635;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::MilkDistributionApp.Properties.Resources.f_removebg_preview10;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(10, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 40);
            this.btnBack.TabIndex = 76;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(488, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payment History";
            // 
            // panelPaymentHistory
            // 
            this.panelPaymentHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelPaymentHistory.Controls.Add(this.panelBack);
            this.panelPaymentHistory.Location = new System.Drawing.Point(1, -1);
            this.panelPaymentHistory.Name = "panelPaymentHistory";
            this.panelPaymentHistory.Size = new System.Drawing.Size(1168, 673);
            this.panelPaymentHistory.TabIndex = 10;
            // 
            // FrmPaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 674);
            this.Controls.Add(this.panelPaymentHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPaymentHistory";
            this.Text = "FrmPaymentHistory";
            this.Load += new System.EventHandler(this.FrmPaymentHistory_Load);
            this.Shown += new System.EventHandler(this.FrmPaymentHistory_Shown);
            this.panelBack.ResumeLayout(false);
            this.panelFront.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentlist)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelPaymentHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPaymentDetails;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelFront;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvPaymentlist;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrintAll;
        private System.Windows.Forms.Panel panelPaymentHistory;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button button1;
    }
}
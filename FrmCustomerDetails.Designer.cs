namespace MilkDistributionApp
{
    partial class FrmCustomerDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerDetails));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCust = new System.Windows.Forms.Panel();
            this.panelFront = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSearchRoute = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvRouteDetails = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelBack = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pcloader = new System.Windows.Forms.PictureBox();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCustomerDetails = new System.Windows.Forms.DataGridView();
            this.cmbSearchTime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelCust.SuspendLayout();
            this.panelFront.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRouteDetails)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelBack.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcloader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCust
            // 
            this.panelCust.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelCust.Controls.Add(this.panelFront);
            this.panelCust.Controls.Add(this.panelBack);
            this.panelCust.Location = new System.Drawing.Point(1, 1);
            this.panelCust.Name = "panelCust";
            this.panelCust.Size = new System.Drawing.Size(1154, 671);
            this.panelCust.TabIndex = 0;
            // 
            // panelFront
            // 
            this.panelFront.BackColor = System.Drawing.Color.White;
            this.panelFront.Controls.Add(this.panel4);
            this.panelFront.Controls.Add(this.panel3);
            this.panelFront.Location = new System.Drawing.Point(3, 2);
            this.panelFront.Name = "panelFront";
            this.panelFront.Size = new System.Drawing.Size(1148, 663);
            this.panelFront.TabIndex = 635;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtSearchRoute);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.dgvRouteDetails);
            this.panel4.Location = new System.Drawing.Point(209, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(716, 600);
            this.panel4.TabIndex = 631;
            // 
            // txtSearchRoute
            // 
            this.txtSearchRoute.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRoute.Location = new System.Drawing.Point(254, 23);
            this.txtSearchRoute.Name = "txtSearchRoute";
            this.txtSearchRoute.Size = new System.Drawing.Size(335, 27);
            this.txtSearchRoute.TabIndex = 627;
            this.txtSearchRoute.TextChanged += new System.EventHandler(this.txtSearchRoute_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(131, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 628;
            this.label5.Text = "Search Route";
            // 
            // dgvRouteDetails
            // 
            this.dgvRouteDetails.AllowUserToAddRows = false;
            this.dgvRouteDetails.AllowUserToDeleteRows = false;
            this.dgvRouteDetails.AllowUserToResizeRows = false;
            this.dgvRouteDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRouteDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRouteDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRouteDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRouteDetails.Location = new System.Drawing.Point(135, 69);
            this.dgvRouteDetails.Name = "dgvRouteDetails";
            this.dgvRouteDetails.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRouteDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRouteDetails.RowHeadersVisible = false;
            this.dgvRouteDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRouteDetails.Size = new System.Drawing.Size(454, 477);
            this.dgvRouteDetails.TabIndex = 629;
            this.dgvRouteDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRouteDetails_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1151, 51);
            this.panel3.TabIndex = 630;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(503, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Route List";
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
            this.btnClose.Location = new System.Drawing.Point(1101, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 30);
            this.btnClose.TabIndex = 633;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.White;
            this.panelBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBack.Controls.Add(this.panel5);
            this.panelBack.Controls.Add(this.panel2);
            this.panelBack.Location = new System.Drawing.Point(4, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(1147, 658);
            this.panelBack.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.pcloader);
            this.panel5.Controls.Add(this.txtSearchCustomer);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.dgvCustomerDetails);
            this.panel5.Controls.Add(this.cmbSearchTime);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(93, 64);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(958, 572);
            this.panel5.TabIndex = 635;
            // 
            // pcloader
            // 
            this.pcloader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcloader.BackColor = System.Drawing.Color.Transparent;
            this.pcloader.Image = global::MilkDistributionApp.Properties.Resources.memes_loading_unscreen;
            this.pcloader.Location = new System.Drawing.Point(439, 300);
            this.pcloader.Name = "pcloader";
            this.pcloader.Size = new System.Drawing.Size(84, 45);
            this.pcloader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcloader.TabIndex = 634;
            this.pcloader.TabStop = false;
            this.pcloader.Visible = false;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.Location = new System.Drawing.Point(250, 15);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(226, 27);
            this.txtSearchCustomer.TabIndex = 629;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(94, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 630;
            this.label4.Text = "Search Customer";
            // 
            // dgvCustomerDetails
            // 
            this.dgvCustomerDetails.AllowUserToAddRows = false;
            this.dgvCustomerDetails.AllowUserToDeleteRows = false;
            this.dgvCustomerDetails.AllowUserToResizeRows = false;
            this.dgvCustomerDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerDetails.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCustomerDetails.Location = new System.Drawing.Point(163, 70);
            this.dgvCustomerDetails.Name = "dgvCustomerDetails";
            this.dgvCustomerDetails.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCustomerDetails.RowHeadersVisible = false;
            this.dgvCustomerDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerDetails.Size = new System.Drawing.Size(623, 490);
            this.dgvCustomerDetails.TabIndex = 633;
            this.dgvCustomerDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerDetails_CellClick);
            // 
            // cmbSearchTime
            // 
            this.cmbSearchTime.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchTime.FormattingEnabled = true;
            this.cmbSearchTime.Items.AddRange(new object[] {
            "Morning",
            "Evening"});
            this.cmbSearchTime.Location = new System.Drawing.Point(652, 14);
            this.cmbSearchTime.Name = "cmbSearchTime";
            this.cmbSearchTime.Size = new System.Drawing.Size(229, 28);
            this.cmbSearchTime.TabIndex = 632;
            this.cmbSearchTime.Text = "Select Time";
            this.cmbSearchTime.TextChanged += new System.EventHandler(this.cmbSearchTime_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(521, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 631;
            this.label3.Text = "Search Time";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Location = new System.Drawing.Point(-2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1148, 51);
            this.panel2.TabIndex = 634;
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
            this.button1.Location = new System.Drawing.Point(1096, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 30);
            this.button1.TabIndex = 633;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(471, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer List";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::MilkDistributionApp.Properties.Resources.f_removebg_preview10;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(8, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 44);
            this.btnBack.TabIndex = 75;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FrmCustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 674);
            this.Controls.Add(this.panelCust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCustomerDetails";
            this.Text = "FrmCustomerDetails";
            this.Load += new System.EventHandler(this.FrmCustomerDetails_Load);
            this.Shown += new System.EventHandler(this.FrmCustomerDetails_Shown);
            this.panelCust.ResumeLayout(false);
            this.panelFront.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRouteDetails)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelBack.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcloader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCust;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvCustomerDetails;
        private System.Windows.Forms.ComboBox cmbSearchTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Panel panelFront;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRouteDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchRoute;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pcloader;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
    }
}
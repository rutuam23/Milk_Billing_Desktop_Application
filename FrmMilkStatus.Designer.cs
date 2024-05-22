namespace MilkDistributionApp
{
    partial class FrmMilkStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMilkStatus));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnPreviousMonth = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPlanVaccation = new System.Windows.Forms.Button();
            this.dgvMilkStatus = new System.Windows.Forms.DataGridView();
            this.btnEvenOdd = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dsAddCustomer1 = new MilkDistributionApp.RDLCReports.DSAddCustomer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMilkStatus)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAddCustomer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 663);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnPlanVaccation);
            this.panel2.Controls.Add(this.dgvMilkStatus);
            this.panel2.Controls.Add(this.btnEvenOdd);
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1146, 626);
            this.panel2.TabIndex = 83;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.daycontainer);
            this.panel3.Location = new System.Drawing.Point(428, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 273);
            this.panel3.TabIndex = 83;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel9.Controls.Add(this.btnNextMonth);
            this.panel9.Controls.Add(this.lblDate);
            this.panel9.Controls.Add(this.btnPreviousMonth);
            this.panel9.Location = new System.Drawing.Point(0, 1);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(284, 34);
            this.panel9.TabIndex = 14;
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.BackColor = System.Drawing.Color.DarkGray;
            this.btnNextMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextMonth.ForeColor = System.Drawing.Color.Blue;
            this.btnNextMonth.Location = new System.Drawing.Point(239, 6);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(36, 24);
            this.btnNextMonth.TabIndex = 6;
            this.btnNextMonth.Text = ">";
            this.btnNextMonth.UseVisualStyleBackColor = false;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(55, 7);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(175, 20);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Month   Year";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPreviousMonth
            // 
            this.btnPreviousMonth.BackColor = System.Drawing.Color.DarkGray;
            this.btnPreviousMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousMonth.ForeColor = System.Drawing.Color.Blue;
            this.btnPreviousMonth.Location = new System.Drawing.Point(14, 6);
            this.btnPreviousMonth.Name = "btnPreviousMonth";
            this.btnPreviousMonth.Size = new System.Drawing.Size(35, 24);
            this.btnPreviousMonth.TabIndex = 4;
            this.btnPreviousMonth.Text = "<";
            this.btnPreviousMonth.UseVisualStyleBackColor = false;
            this.btnPreviousMonth.Click += new System.EventHandler(this.btnPreviousMonth_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Wed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(249, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Thu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sun";
            // 
            // daycontainer
            // 
            this.daycontainer.BackColor = System.Drawing.Color.White;
            this.daycontainer.Location = new System.Drawing.Point(0, 66);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(286, 201);
            this.daycontainer.TabIndex = 5;
            this.daycontainer.Paint += new System.Windows.Forms.PaintEventHandler(this.daycontainer_Paint);
            // 
            // btnPlanVaccation
            // 
            this.btnPlanVaccation.BackColor = System.Drawing.Color.Transparent;
            this.btnPlanVaccation.BackgroundImage = global::MilkDistributionApp.Properties.Resources.f_removebg_preview10;
            this.btnPlanVaccation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlanVaccation.FlatAppearance.BorderSize = 0;
            this.btnPlanVaccation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlanVaccation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlanVaccation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanVaccation.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnPlanVaccation.ForeColor = System.Drawing.Color.White;
            this.btnPlanVaccation.Location = new System.Drawing.Point(363, 271);
            this.btnPlanVaccation.Name = "btnPlanVaccation";
            this.btnPlanVaccation.Size = new System.Drawing.Size(130, 67);
            this.btnPlanVaccation.TabIndex = 76;
            this.btnPlanVaccation.Text = "PLAN VACCATION";
            this.btnPlanVaccation.UseVisualStyleBackColor = false;
            this.btnPlanVaccation.Click += new System.EventHandler(this.btnPlanVaccation_Click);
            // 
            // dgvMilkStatus
            // 
            this.dgvMilkStatus.AllowUserToAddRows = false;
            this.dgvMilkStatus.AllowUserToDeleteRows = false;
            this.dgvMilkStatus.AllowUserToResizeRows = false;
            this.dgvMilkStatus.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMilkStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMilkStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMilkStatus.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMilkStatus.Location = new System.Drawing.Point(163, 344);
            this.dgvMilkStatus.Name = "dgvMilkStatus";
            this.dgvMilkStatus.RowHeadersVisible = false;
            this.dgvMilkStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMilkStatus.Size = new System.Drawing.Size(808, 260);
            this.dgvMilkStatus.TabIndex = 82;
            // 
            // btnEvenOdd
            // 
            this.btnEvenOdd.BackColor = System.Drawing.Color.Transparent;
            this.btnEvenOdd.BackgroundImage = global::MilkDistributionApp.Properties.Resources.f_removebg_preview10;
            this.btnEvenOdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEvenOdd.FlatAppearance.BorderSize = 0;
            this.btnEvenOdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEvenOdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEvenOdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvenOdd.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnEvenOdd.ForeColor = System.Drawing.Color.White;
            this.btnEvenOdd.Location = new System.Drawing.Point(646, 273);
            this.btnEvenOdd.Name = "btnEvenOdd";
            this.btnEvenOdd.Size = new System.Drawing.Size(130, 66);
            this.btnEvenOdd.TabIndex = 75;
            this.btnEvenOdd.Text = "EVEN/ODD";
            this.btnEvenOdd.UseVisualStyleBackColor = false;
            this.btnEvenOdd.Click += new System.EventHandler(this.btnEvenOdd_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(-2, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1152, 38);
            this.panel4.TabIndex = 77;
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
            this.btnClose.Location = new System.Drawing.Point(1108, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 30);
            this.btnClose.TabIndex = 634;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(517, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Milk Status";
            // 
            // dsAddCustomer1
            // 
            this.dsAddCustomer1.DataSetName = "DSAddCustomer";
            this.dsAddCustomer1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmMilkStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1157, 671);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMilkStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMilkStatus";
            this.Load += new System.EventHandler(this.FrmMilkStatus_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMilkStatus)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAddCustomer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEvenOdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvMilkStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnPreviousMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private RDLCReports.DSAddCustomer dsAddCustomer1;
        private System.Windows.Forms.FlowLayoutPanel daycontainer;
        private System.Windows.Forms.Button btnPlanVaccation;
    }
}
namespace MilkDistributionApp
{
    partial class FrmPlanVaccation
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
            this.panelVacc = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelBack = new System.Windows.Forms.Panel();
            this.panelFront = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pcloader = new System.Windows.Forms.PictureBox();
            this.btnfromDate = new System.Windows.Forms.Button();
            this.btnToDate = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnPreviousMonth = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCanceldate = new System.Windows.Forms.Button();
            this.btnOkDate = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelVacc.SuspendLayout();
            this.panelBack.SuspendLayout();
            this.panelFront.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcloader)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVacc
            // 
            this.panelVacc.BackColor = System.Drawing.Color.White;
            this.panelVacc.Controls.Add(this.btnOk);
            this.panelVacc.Controls.Add(this.btnCancel);
            this.panelVacc.Controls.Add(this.panelBack);
            this.panelVacc.Controls.Add(this.panel5);
            this.panelVacc.Location = new System.Drawing.Point(5, 3);
            this.panelVacc.Name = "panelVacc";
            this.panelVacc.Size = new System.Drawing.Size(466, 430);
            this.panelVacc.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.BackgroundImage = global::MilkDistributionApp.Properties.Resources.f_removebg_preview4;
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(103, 363);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(107, 50);
            this.btnOk.TabIndex = 80;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::MilkDistributionApp.Properties.Resources.f_removebg_preview4;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(251, 363);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 52);
            this.btnCancel.TabIndex = 81;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelBack
            // 
            this.panelBack.Controls.Add(this.panelFront);
            this.panelBack.Controls.Add(this.panel3);
            this.panelBack.Controls.Add(this.btnCanceldate);
            this.panelBack.Controls.Add(this.btnOkDate);
            this.panelBack.Location = new System.Drawing.Point(0, 45);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(425, 334);
            this.panelBack.TabIndex = 628;
            // 
            // panelFront
            // 
            this.panelFront.Controls.Add(this.panel2);
            this.panelFront.Location = new System.Drawing.Point(1, 0);
            this.panelFront.Name = "panelFront";
            this.panelFront.Size = new System.Drawing.Size(452, 385);
            this.panelFront.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(23, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 302);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Date From and To";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.pcloader);
            this.panel6.Controls.Add(this.btnfromDate);
            this.panel6.Controls.Add(this.btnToDate);
            this.panel6.Controls.Add(this.lblTo);
            this.panel6.Controls.Add(this.lblFrom);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(44, 75);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(310, 186);
            this.panel6.TabIndex = 5;
            // 
            // pcloader
            // 
            this.pcloader.Image = global::MilkDistributionApp.Properties.Resources.memes_loading_unscreen;
            this.pcloader.Location = new System.Drawing.Point(96, 46);
            this.pcloader.Name = "pcloader";
            this.pcloader.Size = new System.Drawing.Size(100, 69);
            this.pcloader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcloader.TabIndex = 6;
            this.pcloader.TabStop = false;
            this.pcloader.Click += new System.EventHandler(this.pcloader_Click);
            // 
            // btnfromDate
            // 
            this.btnfromDate.BackgroundImage = global::MilkDistributionApp.Properties.Resources.calendar_prev_ui__;
            this.btnfromDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfromDate.FlatAppearance.BorderSize = 0;
            this.btnfromDate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnfromDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnfromDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnfromDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfromDate.Location = new System.Drawing.Point(202, 12);
            this.btnfromDate.Name = "btnfromDate";
            this.btnfromDate.Size = new System.Drawing.Size(44, 34);
            this.btnfromDate.TabIndex = 624;
            this.btnfromDate.UseVisualStyleBackColor = true;
            this.btnfromDate.Click += new System.EventHandler(this.btnfromDate_Click);
            // 
            // btnToDate
            // 
            this.btnToDate.BackgroundImage = global::MilkDistributionApp.Properties.Resources.calendar_prev_ui__;
            this.btnToDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnToDate.FlatAppearance.BorderSize = 0;
            this.btnToDate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnToDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnToDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnToDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToDate.Location = new System.Drawing.Point(202, 94);
            this.btnToDate.Name = "btnToDate";
            this.btnToDate.Size = new System.Drawing.Size(45, 34);
            this.btnToDate.TabIndex = 623;
            this.btnToDate.UseVisualStyleBackColor = true;
            this.btnToDate.Click += new System.EventHandler(this.btnToDate_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(54, 99);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(55, 16);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "To Date";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(54, 21);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(73, 16);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "From Date";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(-10, 76);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(335, 2);
            this.panel7.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.daycontainer);
            this.panel3.Location = new System.Drawing.Point(80, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 265);
            this.panel3.TabIndex = 628;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel9.Controls.Add(this.btnNextMonth);
            this.panel9.Controls.Add(this.lblDate);
            this.panel9.Controls.Add(this.btnPreviousMonth);
            this.panel9.Location = new System.Drawing.Point(1, 1);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(280, 40);
            this.panel9.TabIndex = 14;
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.BackColor = System.Drawing.Color.DarkGray;
            this.btnNextMonth.Location = new System.Drawing.Point(214, 6);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(36, 24);
            this.btnNextMonth.TabIndex = 6;
            this.btnNextMonth.Text = ">";
            this.btnNextMonth.UseVisualStyleBackColor = false;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label4.Location = new System.Drawing.Point(126, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Wed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(249, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(167, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Thu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Sun";
            // 
            // daycontainer
            // 
            this.daycontainer.Location = new System.Drawing.Point(2, 67);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(280, 193);
            this.daycontainer.TabIndex = 5;
            // 
            // btnCanceldate
            // 
            this.btnCanceldate.BackgroundImage = global::MilkDistributionApp.Properties.Resources.f_removebg_preview5;
            this.btnCanceldate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCanceldate.FlatAppearance.BorderSize = 0;
            this.btnCanceldate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanceldate.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanceldate.ForeColor = System.Drawing.Color.White;
            this.btnCanceldate.Location = new System.Drawing.Point(95, 272);
            this.btnCanceldate.Name = "btnCanceldate";
            this.btnCanceldate.Size = new System.Drawing.Size(94, 41);
            this.btnCanceldate.TabIndex = 627;
            this.btnCanceldate.Text = "Cancel";
            this.btnCanceldate.UseVisualStyleBackColor = true;
            this.btnCanceldate.Visible = false;
            this.btnCanceldate.Click += new System.EventHandler(this.btnCanceldate_Click);
            // 
            // btnOkDate
            // 
            this.btnOkDate.BackgroundImage = global::MilkDistributionApp.Properties.Resources.f_removebg_preview6;
            this.btnOkDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOkDate.FlatAppearance.BorderSize = 0;
            this.btnOkDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkDate.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkDate.ForeColor = System.Drawing.Color.White;
            this.btnOkDate.Location = new System.Drawing.Point(235, 272);
            this.btnOkDate.Name = "btnOkDate";
            this.btnOkDate.Size = new System.Drawing.Size(100, 41);
            this.btnOkDate.TabIndex = 626;
            this.btnOkDate.Text = "Ok";
            this.btnOkDate.UseVisualStyleBackColor = true;
            this.btnOkDate.Visible = false;
           
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(1, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(465, 44);
            this.panel5.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(141, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "PlanVaccation";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FrmPlanVaccation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(476, 439);
            this.Controls.Add(this.panelVacc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPlanVaccation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPlanVaccation";
            this.Load += new System.EventHandler(this.FrmPlanVaccation_Load);
            this.panelVacc.ResumeLayout(false);
            this.panelBack.ResumeLayout(false);
            this.panelFront.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcloader)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVacc;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Button btnCanceldate;
        private System.Windows.Forms.Button btnOkDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnfromDate;
        private System.Windows.Forms.Button btnToDate;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnPreviousMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel daycontainer;
        private System.Windows.Forms.Panel panelFront;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pcloader;
    }
}
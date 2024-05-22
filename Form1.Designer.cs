namespace MilkDistributionApp
{
    partial class Form1
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
            this.dgvCheckBox = new System.Windows.Forms.DataGridView();
            this.Che = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnPreviousMonth = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pcloader = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcloader)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCheckBox
            // 
            this.dgvCheckBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Che});
            this.dgvCheckBox.Location = new System.Drawing.Point(12, 182);
            this.dgvCheckBox.Name = "dgvCheckBox";
            this.dgvCheckBox.Size = new System.Drawing.Size(41, 20);
            this.dgvCheckBox.TabIndex = 0;
            this.dgvCheckBox.Visible = false;
            // 
            // Che
            // 
            this.Che.HeaderText = "CheckBox";
            this.Che.Name = "Che";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(634, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.White;
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.ForeColor = System.Drawing.Color.Black;
            this.monthCalendar1.Location = new System.Drawing.Point(8, 5);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.daycontainer);
            this.panel1.Location = new System.Drawing.Point(281, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 288);
            this.panel1.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel9.Controls.Add(this.btnNextMonth);
            this.panel9.Controls.Add(this.lblDate);
            this.panel9.Controls.Add(this.btnPreviousMonth);
            this.panel9.Location = new System.Drawing.Point(1, 1);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(333, 40);
            this.panel9.TabIndex = 14;
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.Location = new System.Drawing.Point(278, 7);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(36, 24);
            this.btnNextMonth.TabIndex = 6;
            this.btnNextMonth.Text = ">";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(82, 5);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(178, 27);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Month Year";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPreviousMonth
            // 
            this.btnPreviousMonth.Location = new System.Drawing.Point(14, 6);
            this.btnPreviousMonth.Name = "btnPreviousMonth";
            this.btnPreviousMonth.Size = new System.Drawing.Size(35, 24);
            this.btnPreviousMonth.TabIndex = 4;
            this.btnPreviousMonth.Text = "<";
            this.btnPreviousMonth.UseVisualStyleBackColor = true;
            this.btnPreviousMonth.Click += new System.EventHandler(this.btnPreviousMonth_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Wed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(303, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(254, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Thu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sun";
            // 
            // daycontainer
            // 
            this.daycontainer.BackColor = System.Drawing.Color.White;
            this.daycontainer.Location = new System.Drawing.Point(6, 74);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(328, 188);
            this.daycontainer.TabIndex = 5;
            // 
            // pcloader
            // 
            this.pcloader.BackColor = System.Drawing.Color.Transparent;
            this.pcloader.Image = global::MilkDistributionApp.Properties.Resources.Loading_icon;
            this.pcloader.Location = new System.Drawing.Point(59, 191);
            this.pcloader.Name = "pcloader";
            this.pcloader.Size = new System.Drawing.Size(58, 11);
            this.pcloader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcloader.TabIndex = 4;
            this.pcloader.TabStop = false;
            this.pcloader.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(722, 307);
            this.Controls.Add(this.pcloader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcloader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCheckBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Che;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Button btnPreviousMonth;
        private System.Windows.Forms.FlowLayoutPanel daycontainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pcloader;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
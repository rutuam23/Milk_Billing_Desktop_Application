namespace MilkDistributionApp
{
    partial class FrmAddRoute
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddRoute));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSearchRoute = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvRoute = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbAgentName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRoute = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblClear = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoute)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 671);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.btnNew);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.lblClear);
            this.panel4.Controls.Add(this.lblSave);
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.btnSave1);
            this.panel4.Controls.Add(this.lblUpdate);
            this.panel4.Location = new System.Drawing.Point(3, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1147, 616);
            this.panel4.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(660, 508);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 18);
            this.label8.TabIndex = 634;
            this.label8.Text = "New";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtSearchRoute);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.dgvRoute);
            this.panel5.Controls.Add(this.txtId);
            this.panel5.Controls.Add(this.cmbAgentName);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtRoute);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(89, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(876, 502);
            this.panel5.TabIndex = 41;
            // 
            // txtSearchRoute
            // 
            this.txtSearchRoute.Font = new System.Drawing.Font("Century", 9.75F);
            this.txtSearchRoute.Location = new System.Drawing.Point(406, 100);
            this.txtSearchRoute.Name = "txtSearchRoute";
            this.txtSearchRoute.Size = new System.Drawing.Size(239, 23);
            this.txtSearchRoute.TabIndex = 631;
            this.txtSearchRoute.TextChanged += new System.EventHandler(this.txtSearchRoute_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 11.25F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(276, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 18);
            this.label7.TabIndex = 632;
            this.label7.Text = "Search MilkMan";
            // 
            // dgvRoute
            // 
            this.dgvRoute.AllowUserToAddRows = false;
            this.dgvRoute.AllowUserToDeleteRows = false;
            this.dgvRoute.AllowUserToResizeRows = false;
            this.dgvRoute.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoute.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRoute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoute.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRoute.GridColor = System.Drawing.SystemColors.Control;
            this.dgvRoute.Location = new System.Drawing.Point(247, 142);
            this.dgvRoute.Name = "dgvRoute";
            this.dgvRoute.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoute.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRoute.RowHeadersVisible = false;
            this.dgvRoute.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoute.Size = new System.Drawing.Size(432, 351);
            this.dgvRoute.TabIndex = 39;
            this.dgvRoute.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoute_CellClick_1);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(98, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(29, 20);
            this.txtId.TabIndex = 40;
            this.txtId.Visible = false;
            // 
            // cmbAgentName
            // 
            this.cmbAgentName.DisplayMember = "AgentName";
            this.cmbAgentName.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAgentName.FormattingEnabled = true;
            this.cmbAgentName.Location = new System.Drawing.Point(345, 59);
            this.cmbAgentName.Name = "cmbAgentName";
            this.cmbAgentName.Size = new System.Drawing.Size(334, 24);
            this.cmbAgentName.TabIndex = 38;
            this.cmbAgentName.Text = "Select Agent";
            this.cmbAgentName.ValueMember = "Id";
            this.cmbAgentName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAgentName_KeyDown_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Enter Route";
            // 
            // txtRoute
            // 
            this.txtRoute.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoute.Location = new System.Drawing.Point(345, 21);
            this.txtRoute.Name = "txtRoute";
            this.txtRoute.Size = new System.Drawing.Size(334, 23);
            this.txtRoute.TabIndex = 37;
            this.txtRoute.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRoute_KeyDown_1);
            this.txtRoute.Leave += new System.EventHandler(this.txtRoute_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Agent Name";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.BackgroundImage = global::MilkDistributionApp.Properties.Resources.new_2__prev_ui;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNew.Location = new System.Drawing.Point(662, 528);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(44, 40);
            this.btnNew.TabIndex = 625;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(541, 528);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(44, 40);
            this.btnUpdate.TabIndex = 631;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.BackColor = System.Drawing.Color.Transparent;
            this.lblClear.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.ForeColor = System.Drawing.Color.Black;
            this.lblClear.Location = new System.Drawing.Point(1067, 509);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(52, 18);
            this.lblClear.TabIndex = 627;
            this.lblClear.Text = "Clear";
            this.lblClear.Visible = false;
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.BackColor = System.Drawing.Color.Transparent;
            this.lblSave.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.ForeColor = System.Drawing.Color.Black;
            this.lblSave.Location = new System.Drawing.Point(422, 507);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(50, 18);
            this.lblSave.TabIndex = 626;
            this.lblSave.Text = "Save ";
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(1069, 534);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(44, 40);
            this.btnClear.TabIndex = 630;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave1
            // 
            this.btnSave1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave1.BackgroundImage")));
            this.btnSave1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave1.FlatAppearance.BorderSize = 0;
            this.btnSave1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave1.Location = new System.Drawing.Point(425, 528);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(44, 40);
            this.btnSave1.TabIndex = 629;
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdate.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.ForeColor = System.Drawing.Color.Black;
            this.lblUpdate.Location = new System.Drawing.Point(535, 508);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(66, 18);
            this.lblUpdate.TabIndex = 628;
            this.lblUpdate.Text = "Update";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1154, 50);
            this.panel2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(486, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Route";
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
            this.btnClose.Location = new System.Drawing.Point(1104, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 30);
            this.btnClose.TabIndex = 632;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmAddRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 674);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddRoute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAddRoute";
            this.Load += new System.EventHandler(this.FrmAddRoute_Load);
            this.Shown += new System.EventHandler(this.FrmAddRoute_Shown);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoute)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSearchRoute;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvRoute;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbAgentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRoute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Label lblUpdate;
    }
}
namespace MilkDistributionApp
{
    partial class FrmCompanyID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompanyID));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGetCompanyID = new System.Windows.Forms.Button();
            this.txtCompanyId = new System.Windows.Forms.TextBox();
            this.txtCompanyEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 253);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnGetCompanyID);
            this.panel2.Controls.Add(this.txtCompanyId);
            this.panel2.Controls.Add(this.txtCompanyEmail);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(34, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 193);
            this.panel2.TabIndex = 636;
            // 
            // btnGetCompanyID
            // 
            this.btnGetCompanyID.BackColor = System.Drawing.Color.Silver;
            this.btnGetCompanyID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGetCompanyID.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGetCompanyID.FlatAppearance.BorderSize = 0;
            this.btnGetCompanyID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGetCompanyID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGetCompanyID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetCompanyID.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetCompanyID.ForeColor = System.Drawing.Color.Black;
            this.btnGetCompanyID.Location = new System.Drawing.Point(122, 79);
            this.btnGetCompanyID.Name = "btnGetCompanyID";
            this.btnGetCompanyID.Size = new System.Drawing.Size(126, 31);
            this.btnGetCompanyID.TabIndex = 637;
            this.btnGetCompanyID.Text = "GetCompanyID";
            this.btnGetCompanyID.UseVisualStyleBackColor = false;
            this.btnGetCompanyID.Click += new System.EventHandler(this.btnGetCompanyID_Click);
            // 
            // txtCompanyId
            // 
            this.txtCompanyId.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyId.Location = new System.Drawing.Point(143, 135);
            this.txtCompanyId.Name = "txtCompanyId";
            this.txtCompanyId.Size = new System.Drawing.Size(202, 23);
            this.txtCompanyId.TabIndex = 36;
            this.txtCompanyId.TextChanged += new System.EventHandler(this.txtCompanyId_TextChanged);
            // 
            // txtCompanyEmail
            // 
            this.txtCompanyEmail.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyEmail.Location = new System.Drawing.Point(143, 21);
            this.txtCompanyEmail.Name = "txtCompanyEmail";
            this.txtCompanyEmail.Size = new System.Drawing.Size(202, 23);
            this.txtCompanyEmail.TabIndex = 34;
            this.txtCompanyEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCompanyEmail_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Company ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Company Email";
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
            this.btnClose.Location = new System.Drawing.Point(401, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 30);
            this.btnClose.TabIndex = 635;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmCompanyID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(452, 259);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCompanyID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCompanyID";
            this.Shown += new System.EventHandler(this.FrmCompanyID_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCompanyEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompanyId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGetCompanyID;
    }
}
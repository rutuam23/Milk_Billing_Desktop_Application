namespace MilkDistributionApp
{
    partial class FrmPopupPin
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
            this.pnlmsg = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvmsg = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPinNumber = new System.Windows.Forms.TextBox();
            this.pnlmsg.SuspendLayout();
            this.dgvmsg.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlmsg
            // 
            this.pnlmsg.BackColor = System.Drawing.Color.White;
            this.pnlmsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlmsg.Controls.Add(this.btnCancel);
            this.pnlmsg.Controls.Add(this.dgvmsg);
            this.pnlmsg.Controls.Add(this.btnOk);
            this.pnlmsg.Controls.Add(this.panel2);
            this.pnlmsg.Location = new System.Drawing.Point(360, 213);
            this.pnlmsg.Name = "pnlmsg";
            this.pnlmsg.Size = new System.Drawing.Size(356, 237);
            this.pnlmsg.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::MilkDistributionApp.Properties.Resources.f_removebg_preview8;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(199, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 41);
            this.btnCancel.TabIndex = 77;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // dgvmsg
            // 
            this.dgvmsg.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvmsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvmsg.Controls.Add(this.txtPinNumber);
            this.dgvmsg.Controls.Add(this.label3);
            this.dgvmsg.Controls.Add(this.label2);
            this.dgvmsg.Location = new System.Drawing.Point(24, 51);
            this.dgvmsg.Name = "dgvmsg";
            this.dgvmsg.Size = new System.Drawing.Size(309, 128);
            this.dgvmsg.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "This Is Your Pin Number For Login....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.BackgroundImage = global::MilkDistributionApp.Properties.Resources.f_removebg_preview7;
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(68, 183);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 40);
            this.btnOk.TabIndex = 76;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Century", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.panel2.Location = new System.Drawing.Point(1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 46);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PinCode Generate";
            // 
            // txtPinNumber
            // 
            this.txtPinNumber.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPinNumber.Location = new System.Drawing.Point(82, 31);
            this.txtPinNumber.Multiline = true;
            this.txtPinNumber.Name = "txtPinNumber";
            this.txtPinNumber.Size = new System.Drawing.Size(132, 25);
            this.txtPinNumber.TabIndex = 49;
            this.txtPinNumber.TextChanged += new System.EventHandler(this.txtPinNumber_TextChanged);
            // 
            // FrmPopupPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1063, 671);
            this.Controls.Add(this.pnlmsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPopupPin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMassage";
            this.Load += new System.EventHandler(this.FrmPopupPin_Load);
            this.pnlmsg.ResumeLayout(false);
            this.dgvmsg.ResumeLayout(false);
            this.dgvmsg.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlmsg;
        private System.Windows.Forms.Panel dgvmsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPinNumber;
    }
}
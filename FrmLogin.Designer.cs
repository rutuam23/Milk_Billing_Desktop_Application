namespace MilkDistributionApp
{
    partial class FrmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblGetCompanyID = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCompanyEmail = new System.Windows.Forms.TextBox();
            this.txtCompanyId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MilkDistributionApp.Properties.Resources._96247681;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.lblGetCompanyID);
            this.panel1.Controls.Add(this.panelLogin);
            this.panel1.Controls.Add(this.lblCreateAccount);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnCancel1);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 418);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::MilkDistributionApp.Properties.Resources.milklogo3;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(134, 9);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(109, 100);
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            // 
            // lblGetCompanyID
            // 
            this.lblGetCompanyID.AutoSize = true;
            this.lblGetCompanyID.BackColor = System.Drawing.Color.Transparent;
            this.lblGetCompanyID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGetCompanyID.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetCompanyID.ForeColor = System.Drawing.Color.DarkRed;
            this.lblGetCompanyID.Location = new System.Drawing.Point(215, 374);
            this.lblGetCompanyID.Name = "lblGetCompanyID";
            this.lblGetCompanyID.Size = new System.Drawing.Size(107, 16);
            this.lblGetCompanyID.TabIndex = 42;
            this.lblGetCompanyID.Text = "Get ComanyID ?";
            this.lblGetCompanyID.Click += new System.EventHandler(this.lblGetCompanyID_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.txtCompanyEmail);
            this.panelLogin.Controls.Add(this.txtCompanyId);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.pictureBox2);
            this.panelLogin.Controls.Add(this.pictureBox3);
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Location = new System.Drawing.Point(-5, 119);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(372, 155);
            this.panelLogin.TabIndex = 0;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(141, 108);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(211, 21);
            this.txtPassword.TabIndex = 39;
            this.txtPassword.Text = "123456789";
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtCompanyEmail
            // 
            this.txtCompanyEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyEmail.Location = new System.Drawing.Point(141, 66);
            this.txtCompanyEmail.Name = "txtCompanyEmail";
            this.txtCompanyEmail.Size = new System.Drawing.Size(211, 21);
            this.txtCompanyEmail.TabIndex = 38;
            this.txtCompanyEmail.Text = "abc@gmail.com";
            this.txtCompanyEmail.TextChanged += new System.EventHandler(this.txtCompanyEmail_TextChanged);
            this.txtCompanyEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCompanyEmail_KeyDown_1);
            // 
            // txtCompanyId
            // 
            this.txtCompanyId.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyId.Location = new System.Drawing.Point(141, 26);
            this.txtCompanyId.Name = "txtCompanyId";
            this.txtCompanyId.Size = new System.Drawing.Size(211, 21);
            this.txtCompanyId.TabIndex = 0;
            this.txtCompanyId.Text = "RB2TSE";
            this.txtCompanyId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCompanyId_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Company ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = " Email";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::MilkDistributionApp.Properties.Resources.lock_icon_prev_ui;
            this.pictureBox2.Location = new System.Drawing.Point(12, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::MilkDistributionApp.Properties.Resources.emailNew1_prev_ui;
            this.pictureBox3.Location = new System.Drawing.Point(18, 67);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 17);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MilkDistributionApp.Properties.Resources.ID_prev_ui;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Password";
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAccount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCreateAccount.Location = new System.Drawing.Point(40, 373);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(126, 16);
            this.lblCreateAccount.TabIndex = 41;
            this.lblCreateAccount.Text = "Create an account ?";
            this.lblCreateAccount.Click += new System.EventHandler(this.lblCreateAccount_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = global::MilkDistributionApp.Properties.Resources.f_removebg_preview;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(39, 319);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(113, 48);
            this.btnLogin.TabIndex = 38;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel1
            // 
            this.btnCancel1.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel1.BackgroundImage = global::MilkDistributionApp.Properties.Resources.f_removebg_preview1;
            this.btnCancel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel1.FlatAppearance.BorderSize = 0;
            this.btnCancel1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancel1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel1.ForeColor = System.Drawing.Color.White;
            this.btnCancel1.Location = new System.Drawing.Point(214, 320);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(111, 48);
            this.btnCancel1.TabIndex = 37;
            this.btnCancel1.Text = "Cancel";
            this.btnCancel1.UseVisualStyleBackColor = false;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(386, 428);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblCreateAccount;
        private System.Windows.Forms.Label lblGetCompanyID;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.TextBox txtCompanyId;
        private System.Windows.Forms.TextBox txtCompanyEmail;
        private System.Windows.Forms.TextBox txtPassword;
    }
}
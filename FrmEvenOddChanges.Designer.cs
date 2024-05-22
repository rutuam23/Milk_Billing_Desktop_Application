namespace MilkDistributionApp
{
    partial class FrmEvenOddChanges
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinMaxSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelFront = new System.Windows.Forms.Panel();
            this.numericUpDownHMilktype = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMilkType = new System.Windows.Forms.NumericUpDown();
            this.lblMilktype = new System.Windows.Forms.Label();
            this.txtMilktypeTotAmt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMilktyperate = new System.Windows.Forms.TextBox();
            this.panelBack = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFinalTotAmt = new System.Windows.Forms.TextBox();
            this.txtBMTotAmt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBMRate = new System.Windows.Forms.TextBox();
            this.numericUpDownBMHQty = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBMQty = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCMTotAmt = new System.Windows.Forms.TextBox();
            this.numericUpDownCMHQty = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCMQty = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCMRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNoMilkSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSelectDeliveryType = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pcloader = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelFront.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHMilktype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMilkType)).BeginInit();
            this.panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBMHQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBMQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCMHQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCMQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcloader)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Even/Odd Changes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnMinMaxSubmit);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 266);
            this.panel2.TabIndex = 1;
            // 
            // btnMinMaxSubmit
            // 
            this.btnMinMaxSubmit.BackgroundImage = global::MilkDistributionApp.Properties.Resources.f_removebg_preview10;
            this.btnMinMaxSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinMaxSubmit.FlatAppearance.BorderSize = 0;
            this.btnMinMaxSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinMaxSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinMaxSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinMaxSubmit.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinMaxSubmit.ForeColor = System.Drawing.Color.White;
            this.btnMinMaxSubmit.Location = new System.Drawing.Point(50, 197);
            this.btnMinMaxSubmit.Name = "btnMinMaxSubmit";
            this.btnMinMaxSubmit.Size = new System.Drawing.Size(131, 52);
            this.btnMinMaxSubmit.TabIndex = 80;
            this.btnMinMaxSubmit.Text = "Min/Max Submit";
            this.btnMinMaxSubmit.UseVisualStyleBackColor = true;
            this.btnMinMaxSubmit.Click += new System.EventHandler(this.btnMinMaxSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::MilkDistributionApp.Properties.Resources.f_removebg_preview10;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(236, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 52);
            this.btnCancel.TabIndex = 81;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panelFront);
            this.panel3.Controls.Add(this.panelBack);
            this.panel3.Controls.Add(this.btnNoMilkSubmit);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cmbSelectDeliveryType);
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(448, 192);
            this.panel3.TabIndex = 77;
            // 
            // panelFront
            // 
            this.panelFront.Controls.Add(this.numericUpDownHMilktype);
            this.panelFront.Controls.Add(this.numericUpDownMilkType);
            this.panelFront.Controls.Add(this.lblMilktype);
            this.panelFront.Controls.Add(this.txtMilktypeTotAmt);
            this.panelFront.Controls.Add(this.label9);
            this.panelFront.Controls.Add(this.label10);
            this.panelFront.Controls.Add(this.txtMilktyperate);
            this.panelFront.Location = new System.Drawing.Point(2, 52);
            this.panelFront.Name = "panelFront";
            this.panelFront.Size = new System.Drawing.Size(441, 115);
            this.panelFront.TabIndex = 767;
            // 
            // numericUpDownHMilktype
            // 
            this.numericUpDownHMilktype.Font = new System.Drawing.Font("Century", 9.75F);
            this.numericUpDownHMilktype.Location = new System.Drawing.Point(261, 21);
            this.numericUpDownHMilktype.Name = "numericUpDownHMilktype";
            this.numericUpDownHMilktype.Size = new System.Drawing.Size(116, 23);
            this.numericUpDownHMilktype.TabIndex = 765;
            this.numericUpDownHMilktype.ValueChanged += new System.EventHandler(this.numericUpDownHMilktype_ValueChanged);
            // 
            // numericUpDownMilkType
            // 
            this.numericUpDownMilkType.Font = new System.Drawing.Font("Century", 9.75F);
            this.numericUpDownMilkType.Location = new System.Drawing.Point(127, 21);
            this.numericUpDownMilkType.Name = "numericUpDownMilkType";
            this.numericUpDownMilkType.Size = new System.Drawing.Size(119, 23);
            this.numericUpDownMilkType.TabIndex = 764;
            this.numericUpDownMilkType.ValueChanged += new System.EventHandler(this.numericUpDownMilkType_ValueChanged);
            // 
            // lblMilktype
            // 
            this.lblMilktype.AutoSize = true;
            this.lblMilktype.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilktype.Location = new System.Drawing.Point(18, 26);
            this.lblMilktype.Name = "lblMilktype";
            this.lblMilktype.Size = new System.Drawing.Size(51, 16);
            this.lblMilktype.TabIndex = 763;
            this.lblMilktype.Text = "CMQty";
            // 
            // txtMilktypeTotAmt
            // 
            this.txtMilktypeTotAmt.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMilktypeTotAmt.Location = new System.Drawing.Point(281, 65);
            this.txtMilktypeTotAmt.Name = "txtMilktypeTotAmt";
            this.txtMilktypeTotAmt.Size = new System.Drawing.Size(68, 23);
            this.txtMilktypeTotAmt.TabIndex = 752;
            this.txtMilktypeTotAmt.Text = " 0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(90, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 749;
            this.label9.Text = "Rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(221, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 750;
            this.label10.Text = "TotAmt";
            // 
            // txtMilktyperate
            // 
            this.txtMilktyperate.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMilktyperate.Location = new System.Drawing.Point(144, 66);
            this.txtMilktyperate.Name = "txtMilktyperate";
            this.txtMilktyperate.Size = new System.Drawing.Size(71, 23);
            this.txtMilktyperate.TabIndex = 751;
            this.txtMilktyperate.Text = " ";
            this.txtMilktyperate.TextChanged += new System.EventHandler(this.txtMilktyperate_TextChanged);
            // 
            // panelBack
            // 
            this.panelBack.Controls.Add(this.label11);
            this.panelBack.Controls.Add(this.txtFinalTotAmt);
            this.panelBack.Controls.Add(this.txtBMTotAmt);
            this.panelBack.Controls.Add(this.label7);
            this.panelBack.Controls.Add(this.label8);
            this.panelBack.Controls.Add(this.txtBMRate);
            this.panelBack.Controls.Add(this.numericUpDownBMHQty);
            this.panelBack.Controls.Add(this.numericUpDownBMQty);
            this.panelBack.Controls.Add(this.label6);
            this.panelBack.Controls.Add(this.txtCMTotAmt);
            this.panelBack.Controls.Add(this.numericUpDownCMHQty);
            this.panelBack.Controls.Add(this.numericUpDownCMQty);
            this.panelBack.Controls.Add(this.label2);
            this.panelBack.Controls.Add(this.label3);
            this.panelBack.Controls.Add(this.txtCMRate);
            this.panelBack.Controls.Add(this.label5);
            this.panelBack.Location = new System.Drawing.Point(2, 50);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(443, 140);
            this.panelBack.TabIndex = 762;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(136, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 768;
            this.label11.Text = "FinalTotAmt";
            this.label11.Visible = false;
            // 
            // txtFinalTotAmt
            // 
            this.txtFinalTotAmt.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalTotAmt.Location = new System.Drawing.Point(228, 94);
            this.txtFinalTotAmt.Name = "txtFinalTotAmt";
            this.txtFinalTotAmt.Size = new System.Drawing.Size(60, 23);
            this.txtFinalTotAmt.TabIndex = 767;
            this.txtFinalTotAmt.Text = " 0";
            this.txtFinalTotAmt.Visible = false;
            // 
            // txtBMTotAmt
            // 
            this.txtBMTotAmt.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBMTotAmt.Location = new System.Drawing.Point(404, 59);
            this.txtBMTotAmt.Name = "txtBMTotAmt";
            this.txtBMTotAmt.Size = new System.Drawing.Size(34, 23);
            this.txtBMTotAmt.TabIndex = 766;
            this.txtBMTotAmt.Text = " 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(240, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 763;
            this.label7.Text = "Rate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(343, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 764;
            this.label8.Text = "TotAmt";
            // 
            // txtBMRate
            // 
            this.txtBMRate.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBMRate.Location = new System.Drawing.Point(292, 61);
            this.txtBMRate.Name = "txtBMRate";
            this.txtBMRate.Size = new System.Drawing.Size(48, 23);
            this.txtBMRate.TabIndex = 765;
            this.txtBMRate.Text = " ";
            this.txtBMRate.TextChanged += new System.EventHandler(this.txtBMRate_TextChanged);
            // 
            // numericUpDownBMHQty
            // 
            this.numericUpDownBMHQty.Font = new System.Drawing.Font("Century", 9.75F);
            this.numericUpDownBMHQty.Location = new System.Drawing.Point(367, 18);
            this.numericUpDownBMHQty.Name = "numericUpDownBMHQty";
            this.numericUpDownBMHQty.Size = new System.Drawing.Size(72, 23);
            this.numericUpDownBMHQty.TabIndex = 762;
            this.numericUpDownBMHQty.ValueChanged += new System.EventHandler(this.numericUpDownBMHQty_ValueChanged);
            // 
            // numericUpDownBMQty
            // 
            this.numericUpDownBMQty.Font = new System.Drawing.Font("Century", 9.75F);
            this.numericUpDownBMQty.Location = new System.Drawing.Point(292, 18);
            this.numericUpDownBMQty.Name = "numericUpDownBMQty";
            this.numericUpDownBMQty.Size = new System.Drawing.Size(71, 23);
            this.numericUpDownBMQty.TabIndex = 761;
            this.numericUpDownBMQty.ValueChanged += new System.EventHandler(this.numericUpDownBMQty_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(237, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 760;
            this.label6.Text = "BMQty";
            // 
            // txtCMTotAmt
            // 
            this.txtCMTotAmt.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMTotAmt.Location = new System.Drawing.Point(159, 60);
            this.txtCMTotAmt.Name = "txtCMTotAmt";
            this.txtCMTotAmt.Size = new System.Drawing.Size(47, 23);
            this.txtCMTotAmt.TabIndex = 748;
            this.txtCMTotAmt.Text = " 0";
            // 
            // numericUpDownCMHQty
            // 
            this.numericUpDownCMHQty.Font = new System.Drawing.Font("Century", 9.75F);
            this.numericUpDownCMHQty.Location = new System.Drawing.Point(130, 16);
            this.numericUpDownCMHQty.Name = "numericUpDownCMHQty";
            this.numericUpDownCMHQty.Size = new System.Drawing.Size(73, 23);
            this.numericUpDownCMHQty.TabIndex = 759;
            this.numericUpDownCMHQty.ValueChanged += new System.EventHandler(this.numericUpDownCMHQty_ValueChanged);
            // 
            // numericUpDownCMQty
            // 
            this.numericUpDownCMQty.Font = new System.Drawing.Font("Century", 9.75F);
            this.numericUpDownCMQty.Location = new System.Drawing.Point(56, 16);
            this.numericUpDownCMQty.Name = "numericUpDownCMQty";
            this.numericUpDownCMQty.Size = new System.Drawing.Size(72, 23);
            this.numericUpDownCMQty.TabIndex = 758;
            this.numericUpDownCMQty.ValueChanged += new System.EventHandler(this.numericUpDownCMQty_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 745;
            this.label2.Text = "Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 746;
            this.label3.Text = "TotAmt";
            // 
            // txtCMRate
            // 
            this.txtCMRate.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMRate.Location = new System.Drawing.Point(55, 60);
            this.txtCMRate.Name = "txtCMRate";
            this.txtCMRate.Size = new System.Drawing.Size(48, 23);
            this.txtCMRate.TabIndex = 747;
            this.txtCMRate.Text = " ";
            this.txtCMRate.TextChanged += new System.EventHandler(this.txtCMRate_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 79;
            this.label5.Text = "CMQty";
            // 
            // btnNoMilkSubmit
            // 
            this.btnNoMilkSubmit.BackgroundImage = global::MilkDistributionApp.Properties.Resources.f_removebg_preview10;
            this.btnNoMilkSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNoMilkSubmit.FlatAppearance.BorderSize = 0;
            this.btnNoMilkSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNoMilkSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNoMilkSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoMilkSubmit.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoMilkSubmit.ForeColor = System.Drawing.Color.White;
            this.btnNoMilkSubmit.Location = new System.Drawing.Point(319, 0);
            this.btnNoMilkSubmit.Name = "btnNoMilkSubmit";
            this.btnNoMilkSubmit.Size = new System.Drawing.Size(123, 43);
            this.btnNoMilkSubmit.TabIndex = 82;
            this.btnNoMilkSubmit.Text = "No Milk Submit";
            this.btnNoMilkSubmit.UseVisualStyleBackColor = true;
            this.btnNoMilkSubmit.Click += new System.EventHandler(this.btnNoMilkSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 749;
            this.label4.Text = "Select";
            // 
            // cmbSelectDeliveryType
            // 
            this.cmbSelectDeliveryType.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectDeliveryType.FormattingEnabled = true;
            this.cmbSelectDeliveryType.Items.AddRange(new object[] {
            "Even",
            "Odd"});
            this.cmbSelectDeliveryType.Location = new System.Drawing.Point(78, 12);
            this.cmbSelectDeliveryType.Name = "cmbSelectDeliveryType";
            this.cmbSelectDeliveryType.Size = new System.Drawing.Size(136, 24);
            this.cmbSelectDeliveryType.TabIndex = 78;
            this.cmbSelectDeliveryType.Text = "Select Days";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pcloader
            // 
            this.pcloader.BackColor = System.Drawing.Color.White;
            this.pcloader.Image = global::MilkDistributionApp.Properties.Resources.memes_loading_unscreen;
            this.pcloader.Location = new System.Drawing.Point(172, 122);
            this.pcloader.Name = "pcloader";
            this.pcloader.Size = new System.Drawing.Size(91, 62);
            this.pcloader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcloader.TabIndex = 766;
            this.pcloader.TabStop = false;
            this.pcloader.Visible = false;
            // 
            // FrmEvenOddChanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(457, 318);
            this.Controls.Add(this.pcloader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEvenOddChanges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEvenOddChanges";
            this.Load += new System.EventHandler(this.FrmEvenOddChanges_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelFront.ResumeLayout(false);
            this.panelFront.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHMilktype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMilkType)).EndInit();
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBMHQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBMQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCMHQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCMQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcloader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSelectDeliveryType;
        private System.Windows.Forms.Button btnMinMaxSubmit;
        private System.Windows.Forms.Button btnNoMilkSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.TextBox txtBMTotAmt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBMRate;
        private System.Windows.Forms.NumericUpDown numericUpDownBMHQty;
        private System.Windows.Forms.NumericUpDown numericUpDownBMQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCMTotAmt;
        private System.Windows.Forms.NumericUpDown numericUpDownCMHQty;
        private System.Windows.Forms.NumericUpDown numericUpDownCMQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCMRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelFront;
        private System.Windows.Forms.NumericUpDown numericUpDownHMilktype;
        private System.Windows.Forms.NumericUpDown numericUpDownMilkType;
        private System.Windows.Forms.Label lblMilktype;
        private System.Windows.Forms.TextBox txtMilktypeTotAmt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMilktyperate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFinalTotAmt;
        private System.Windows.Forms.PictureBox pcloader;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
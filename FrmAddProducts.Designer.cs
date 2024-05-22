namespace MilkDistributionApp
{
    partial class FrmAddProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddProducts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.cmbWeight = new System.Windows.Forms.ComboBox();
            this.cmbProdName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProdSN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProdRate = new System.Windows.Forms.TextBox();
            this.txtProdQty = new System.Windows.Forms.TextBox();
            this.lblDelete = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblSave = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblClear = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 666);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.lblDelete);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.btnNew);
            this.panel4.Controls.Add(this.lblSave);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.lblClear);
            this.panel4.Controls.Add(this.lblUpdate);
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Location = new System.Drawing.Point(3, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1148, 614);
            this.panel4.TabIndex = 37;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(708, 527);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 40);
            this.btnDelete.TabIndex = 636;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvProduct);
            this.panel5.Controls.Add(this.txtId);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btnAddProd);
            this.panel5.Controls.Add(this.cmbWeight);
            this.panel5.Controls.Add(this.cmbProdName);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txtProdSN);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtProdRate);
            this.panel5.Controls.Add(this.txtProdQty);
            this.panel5.Location = new System.Drawing.Point(141, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(863, 500);
            this.panel5.TabIndex = 55;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Quantity,
            this.ProductUnit,
            this.Rate,
            this.ShortName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.Location = new System.Drawing.Point(112, 207);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(643, 280);
            this.dgvProduct.TabIndex = 46;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick_1);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 160;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 120;
            // 
            // ProductUnit
            // 
            this.ProductUnit.HeaderText = "ProductUnit";
            this.ProductUnit.Name = "ProductUnit";
            this.ProductUnit.ReadOnly = true;
            this.ProductUnit.Width = 120;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            this.Rate.Width = 120;
            // 
            // ShortName
            // 
            this.ShortName.HeaderText = "ShortName";
            this.ShortName.Name = "ShortName";
            this.ShortName.ReadOnly = true;
            this.ShortName.Width = 120;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(9, 11);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(36, 23);
            this.txtId.TabIndex = 49;
            this.txtId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Product Name";
            // 
            // btnAddProd
            // 
            this.btnAddProd.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProd.BackgroundImage = global::MilkDistributionApp.Properties.Resources.plus_5_xxl_removebg_preview1;
            this.btnAddProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProd.CausesValidation = false;
            this.btnAddProd.FlatAppearance.BorderSize = 0;
            this.btnAddProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddProd.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProd.Location = new System.Drawing.Point(654, 27);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(35, 28);
            this.btnAddProd.TabIndex = 48;
            this.btnAddProd.UseVisualStyleBackColor = false;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // cmbWeight
            // 
            this.cmbWeight.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWeight.FormattingEnabled = true;
            this.cmbWeight.Items.AddRange(new object[] {
            "gm",
            "kg",
            "ltr",
            "qty",
            "bottle",
            "dozen"});
            this.cmbWeight.Location = new System.Drawing.Point(655, 69);
            this.cmbWeight.Name = "cmbWeight";
            this.cmbWeight.Size = new System.Drawing.Size(109, 24);
            this.cmbWeight.TabIndex = 2;
            this.cmbWeight.Text = "Select Weight";
            // 
            // cmbProdName
            // 
            this.cmbProdName.DisplayMember = "ProductName";
            this.cmbProdName.FormattingEnabled = true;
            this.cmbProdName.Location = new System.Drawing.Point(259, 31);
            this.cmbProdName.Name = "cmbProdName";
            this.cmbProdName.Size = new System.Drawing.Size(390, 21);
            this.cmbProdName.TabIndex = 0;
            this.cmbProdName.ValueMember = "Id";
            this.cmbProdName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProdName_KeyDown);
            this.cmbProdName.Leave += new System.EventHandler(this.cmbProdName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Product Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Product Rate";
            // 
            // txtProdSN
            // 
            this.txtProdSN.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdSN.Location = new System.Drawing.Point(259, 156);
            this.txtProdSN.Name = "txtProdSN";
            this.txtProdSN.Size = new System.Drawing.Size(390, 23);
            this.txtProdSN.TabIndex = 4;
            this.txtProdSN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdSN_KeyDown);
            this.txtProdSN.Leave += new System.EventHandler(this.txtProdSN_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "ProductShortName";
            // 
            // txtProdRate
            // 
            this.txtProdRate.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdRate.Location = new System.Drawing.Point(259, 114);
            this.txtProdRate.Name = "txtProdRate";
            this.txtProdRate.Size = new System.Drawing.Size(390, 23);
            this.txtProdRate.TabIndex = 3;
            this.txtProdRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdRate_KeyDown);
            // 
            // txtProdQty
            // 
            this.txtProdQty.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdQty.Location = new System.Drawing.Point(259, 70);
            this.txtProdQty.Name = "txtProdQty";
            this.txtProdQty.Size = new System.Drawing.Size(390, 23);
            this.txtProdQty.TabIndex = 1;
            this.txtProdQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdQty_KeyDown);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.BackColor = System.Drawing.Color.Transparent;
            this.lblDelete.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDelete.ForeColor = System.Drawing.Color.Black;
            this.lblDelete.Location = new System.Drawing.Point(704, 509);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(61, 18);
            this.lblDelete.TabIndex = 635;
            this.lblDelete.Text = "Delete";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(617, 508);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 18);
            this.label8.TabIndex = 634;
            this.label8.Text = "New";
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
            this.btnNew.Location = new System.Drawing.Point(615, 527);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(44, 40);
            this.btnNew.TabIndex = 625;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.BackColor = System.Drawing.Color.Transparent;
            this.lblSave.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.ForeColor = System.Drawing.Color.Black;
            this.lblSave.Location = new System.Drawing.Point(422, 508);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(50, 18);
            this.lblSave.TabIndex = 626;
            this.lblSave.Text = "Save ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(518, 527);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(44, 40);
            this.btnUpdate.TabIndex = 631;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(425, 528);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(44, 40);
            this.btnSave.TabIndex = 629;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.BackColor = System.Drawing.Color.Transparent;
            this.lblClear.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.ForeColor = System.Drawing.Color.Black;
            this.lblClear.Location = new System.Drawing.Point(938, 523);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(52, 18);
            this.lblClear.TabIndex = 627;
            this.lblClear.Text = "Clear";
            this.lblClear.Visible = false;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdate.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.ForeColor = System.Drawing.Color.Black;
            this.lblUpdate.Location = new System.Drawing.Point(511, 507);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(66, 18);
            this.lblUpdate.TabIndex = 628;
            this.lblUpdate.Text = "Update";
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(941, 550);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(44, 40);
            this.btnClear.TabIndex = 630;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Location = new System.Drawing.Point(0, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1154, 54);
            this.panel3.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(505, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Add Product ";
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
            this.btnClose.Location = new System.Drawing.Point(1098, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 30);
            this.btnClose.TabIndex = 632;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // FrmAddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 674);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Name = "FrmAddProducts";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddProducts";
            this.Load += new System.EventHandler(this.FrmAddProducts_Load);
            this.Shown += new System.EventHandler(this.FrmAddProducts_Shown);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbProdName;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.TextBox txtProdSN;
        private System.Windows.Forms.TextBox txtProdRate;
        private System.Windows.Forms.TextBox txtProdQty;
        private System.Windows.Forms.ComboBox cmbWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortName;
    }
}
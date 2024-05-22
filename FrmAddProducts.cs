using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkDistributionApp
{
    public partial class FrmAddProducts : Form
    {
        public FrmAddProducts()
        {
            InitializeComponent();
        }
        ClassConn objcls = new ClassConn();
        DataSet ds = new DataSet();
        string sql;
        int cnt;
      
        private void FrmAddProducts_Load(object sender, EventArgs e)
        {
            FillProdName();
            filldt();
            //cmbProdName.TabIndex = 0;
            //cmbProdName.Focus();
            cmbProdName.SelectedIndex = -1;
            btnUpdate.Enabled = false;
            lblUpdate.Enabled = false;          
        }

        public void FillProdName()
        {
            sql = "Select Id,ProductName from ProductNameMasters where CompanyId='" + ClassConn.Companyid + "' ORDER BY Id DESC";
            ds = objcls.fillDs(sql);
            cmbProdName.DataSource = ds.Tables[0];
        }

        public void filldt()
        {
            sql = "select * from ProductMasters where CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            dgvProduct.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dgvProduct.Rows.Add();
                dgvProduct.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i].ItemArray[0].ToString();//id
                dgvProduct.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i].ItemArray[2].ToString();//name
                dgvProduct.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i].ItemArray[4].ToString();//Qty
                dgvProduct.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i].ItemArray[6].ToString();//Unit
                dgvProduct.Rows[i].Cells[4].Value = ds.Tables[0].Rows[i].ItemArray[3].ToString();//rate
                dgvProduct.Rows[i].Cells[5].Value = ds.Tables[0].Rows[i].ItemArray[5].ToString();//ShortName
            }
        }

        public void Clear()
        {        
            txtProdQty.ResetText();
            txtProdRate.ResetText();
            txtProdSN.ResetText();
            cmbWeight.Text = "Select Weight";
            cmbProdName.SelectedIndex = -1;
        }

        private void dgvProduct_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvProduct.SelectedCells[0].Value.ToString();
            cmbProdName.Text = dgvProduct.SelectedCells[1].Value.ToString();
            txtProdQty.Text = dgvProduct.SelectedCells[2].Value.ToString();
            cmbWeight.Text = dgvProduct.SelectedCells[3].Value.ToString();
            txtProdRate.Text = dgvProduct.SelectedCells[4].Value.ToString();
            txtProdSN.Text = dgvProduct.SelectedCells[5].Value.ToString();
            btnSave.Enabled = false;
            lblSave.Enabled = false;
            btnUpdate.Enabled = true;
            lblUpdate.Enabled = true;
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            //btnAddProd.Enabled = false;
            if (cmbProdName.Text == "")
            {
                MessageBox.Show("Please Enter Product Name..");
                return;
            }
            sql = "select * from ProductNameMasters where ProductName='" + cmbProdName.Text.Trim() + "' and CompanyId='" + ClassConn.Companyid + "'";
            cnt = objcls.executescal(sql);
            if (cnt != 0)
            {
                MessageBox.Show("ProductName Already Available..");
                return;
            }
            sql = "Insert into ProductNameMasters(ProductName,CompanyId)values('" + cmbProdName.Text.Trim() + "','" + ClassConn.Companyid + "')";
            objcls.execute(sql);
            MessageBox.Show("Record Saved Successfully.....");
            FillProdName();
            //btnAddProd.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            if (cmbProdName.Text == "")
            {
                MessageBox.Show("Please Enter Product Name..");
                return;
            }
            if (txtProdQty.Text == "")
            {
                MessageBox.Show("Please Enter Quantity..");
                return;
            }
            if (txtProdRate.Text == "")
            {
                MessageBox.Show("Please Enter Rate..");
                return;
            }           
            if (cmbWeight.Text == "Select Weight")
            {
                MessageBox.Show("Please Select Weight..");
                return;
            }
            sql = "select count(*) from ProductNameMasters where ProductName='" + cmbProdName.Text.Trim() + "' and CompanyId='" + ClassConn.Companyid + "'";
            cnt = objcls.executescal(sql);
            if (cnt == 0)
            {
                MessageBox.Show("Add ProductName first...");
                return;
            }
            else
            {
                sql = "Insert into ProductMasters(ProductNameId,ProductName,ProductRate,ProductQty,ProductShortName,ProductUnit,CompanyId)values('" + cmbProdName.SelectedValue.ToString() + "','" + cmbProdName.Text.Trim() + "','" + txtProdRate.Text.Trim() + "','" + txtProdQty.Text.Trim() + "','" + txtProdSN.Text.Trim() + "','" + cmbWeight.Text.Trim() + "','" + ClassConn.Companyid + "')";
                objcls.execute(sql);
                MessageBox.Show("Record Saved Successfully.....");
                filldt();
                Clear();
                cmbProdName.ResetText();
            }
            btnSave.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            if (cmbProdName.Text == "")
            {
                MessageBox.Show("Please Enter Product Name..");
                return;
            }
            if (txtProdQty.Text == "")
            {
                MessageBox.Show("Please Enter Quantity..");
                return;
            }
            if (txtProdRate.Text == "")
            {
                MessageBox.Show("Please Enter Rate..");
                return;
            }
            if (cmbWeight.Text == "Select Weight")
            {
                MessageBox.Show("Please Select Weight..");
                return;
            }

            sql = " UPDATE ProductMasters SET ProductNameId='" + cmbProdName.SelectedValue + "',ProductName='" + cmbProdName.Text.Trim() + "',  ProductRate='" + txtProdRate.Text.Trim() + "', ProductQty='" + txtProdQty.Text.Trim() + "', ProductShortName='" + txtProdSN.Text.Trim() + "',  ProductUnit='" + cmbWeight.Text.Trim() + "' WHERE (Id=" + txtId.Text + ")'" + ClassConn.Companyid + "'";
            objcls.execute(sql);
            MessageBox.Show("Record Updated Successfully....");
            filldt();
            Clear();
            btnUpdate.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            sql = "Delete from ProductMasters WHERE (Id=" + txtId.Text + ")'" + ClassConn.Companyid + "'";
            { 
                MessageBox.Show("Please Enter Product Name..");
                return;
            }
            if (txtProdQty.Text == "")
            {
                MessageBox.Show("Please Enter Quantity..");
                return;
            }
            if (txtProdRate.Text == "")
            {
                MessageBox.Show("Please Enter Rate..");
                return;
            }
            if (cmbWeight.Text == "Select Weight")
            {
                MessageBox.Show("Please Select Weight..");
                return;
            }
            
            objcls.execute(sql);
            MessageBox.Show("Record Deleted Successfully....");
            filldt();
            Clear();
            btnDelete.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            Clear();
            txtId.ResetText();
            btnUpdate.Enabled = false;
            lblUpdate.Enabled = false;
            btnSave.Enabled = true;
            lblSave.Enabled = true;
            btnNew.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnClear.Enabled = false;
            Clear();
            btnClear.Enabled = true;
        }      
        private void cmbProdName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtProdQty.Focus();
            }
        }

        private void txtProdQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtProdRate.Focus();
            }
        }

        private void txtProdRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtProdSN.Focus();
            }
        }

        private void txtProdSN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }      
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            btnClose.Enabled = false;
            this.Close();
            btnClose.Enabled = true;
        }

        private void txtProdSN_Leave(object sender, EventArgs e)
        {
            if (txtProdSN.Text != "")
            {
                string text = txtProdSN.Text;
                string firstletterofeachstring = string.Join(" ", text.Split(' ').ToList().ConvertAll(word => word.Substring(0, 1).ToUpper() + word.Substring(1)));
                txtProdSN.Text = firstletterofeachstring;
            }
        }

        private void cmbProdName_Leave(object sender, EventArgs e)
        {
            if (cmbProdName.Text != "")
            {
                string text = cmbProdName.Text;
                string firstletterofeachstring = string.Join(" ", text.Split(' ').ToList().ConvertAll(word => word.Substring(0, 1).ToUpper() + word.Substring(1)));
                cmbProdName.Text = firstletterofeachstring;
            }
        }

        private void FrmAddProducts_Shown(object sender, EventArgs e)
        {
            cmbProdName.Focus();
        }
    }
}

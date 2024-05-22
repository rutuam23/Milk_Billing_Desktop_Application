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
    public partial class FrmBillPay : Form
    {
        public FrmBillPay()
        {
            InitializeComponent();
        }

        ClassConn objcls = new ClassConn();
        DataSet ds = new DataSet();
        string sql;
        int cnt;

        private void FrmBillPay_Load(object sender, EventArgs e)
        {
            txtRecieptNo.Text = GenerateNewRandom();
            filldt();
            txtPaidAmt.Focus();
            dgvCustomerBillDetails.Columns[0].Visible = false;
            dgvCustomerBillDetails.Columns[4].Visible = false;
            dgvCustomerBillDetails.Columns[5].Visible = false;
            dgvCustomerBillDetails.Columns[6].Visible = false;
            dgvCustomerBillDetails.Columns[7].Visible = false;         
            dgvCustomerBillDetails.Columns[9].Visible = false;          
        }

        public static string GenerateNewRandom()
        {
            Random generator = new Random();
            String r = generator.Next(0, 10000).ToString("D4");
            if (r.Distinct().Count() == 1)
            {
                r = GenerateNewRandom();
            }
            return r;
        }

        public void filldt()
        {
            sql = "Select CustId,CustomerName,MobileNo,Address,Cmonth,Cyear,CONCAT(CowMilkQty,'.',CowHalfMilkQty) as Cowmilk ,CONCAT(BuffalloMilkQty,'.',BuffalloHalfMilkQty) as BuffalloMilk,GrandTotal,CDate,OldBalance,PaidAmt,Balance from Bills where PaymentStatus=1 and CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            dgvCustomerBillDetails.DataSource = ds.Tables[0];
            dgvCustomerBillDetails.Columns[1].Width = 130;
        }

        private void dgvCustomerBillDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelFront.Visible = false;
            panelFront.SendToBack();
            panelBack.BringToFront();
            panelBack.Visible = true;
            //txtPaidAmt.Focus();
            txtCustID.Text = dgvCustomerBillDetails.SelectedCells[0].Value.ToString();
            txtCustName.Text = dgvCustomerBillDetails.SelectedCells[1].Value.ToString();
            txtCustMobile.Text = dgvCustomerBillDetails.SelectedCells[2].Value.ToString();
            txtCustAddress.Text = dgvCustomerBillDetails.SelectedCells[3].Value.ToString();
            txtCustMonth.Text = dgvCustomerBillDetails.SelectedCells[4].Value.ToString();
            txtCustYear.Text = dgvCustomerBillDetails.SelectedCells[5].Value.ToString();
            txtCowMilk.Text = dgvCustomerBillDetails.SelectedCells[6].Value.ToString();
            txtBuffMilk.Text = dgvCustomerBillDetails.SelectedCells[7].Value.ToString();
            txtTotalAmt.Text = dgvCustomerBillDetails.SelectedCells[8].Value.ToString();
            dtpBillDate.Text = dgvCustomerBillDetails.SelectedCells[9].Value.ToString();
            txtPreBal.Text = dgvCustomerBillDetails.SelectedCells[10].Value.ToString();
        }
            
        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            sql = "Select * from Bills where CustomerName like '%" + txtSearchCustomer.Text.Trim() + "%' and CompanyId='" + ClassConn.Companyid + "'";
            ds = new DataSet();
            ds = objcls.fillDs(sql);
            dgvCustomerBillDetails.DataSource = ds.Tables[0];
        }

        public void Clear()
        {
            txtCustID.ResetText();
            txtCustName.ResetText();
            txtCustMobile.ResetText();
            txtCustAddress.ResetText();
            txtCustMonth.ResetText();
            txtCustYear.ResetText();
            txtCowMilk.ResetText();
            txtBuffMilk.ResetText();    
            txtTotalAmt.Text = "0";           
           // txtBalAmt.ResetText();          
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            btnPayNow.Enabled = false;

            sql = "Select count(*) from Bills where Cmonth ='" + txtCustMonth.Text.Trim() + "' and Cyear='" + txtCustYear.Text.Trim() + "' and CompanyId ='" + ClassConn.Companyid + "'and  PaymentStatus='1'";
            cnt = objcls.executescal(sql);
            if (cnt != 0)
            {
                MessageBox.Show("Bill Already Paid...");
                return;
            }
            else
            {
                DateTime Today = DateTime.Now;
                sql = "Update Bills set PaymentStatus='1',PaidAmt='" + txtPaidAmt.Text.Trim() + "',Balance='" + txtBalAmt.Text.Trim() + "',PayDate='" + string.Format("{0:dd/MM/yyyy }", Today) + "' where CustId='" + txtCustID.Text.Trim() + "'and CompanyId='" + ClassConn.Companyid + "'and Cmonth='" + txtCustMonth.Text.Trim() + "'and Cyear='" + txtCustYear.Text.Trim() + "'";
                objcls.execute(sql);

                string sql1 = "Update CustomerProfiles set OldBalance='" + txtBalAmt.Text.Trim() + "' where Id='" + txtCustID.Text.Trim() + "'and CompanyId='" + ClassConn.Companyid + "'and Cyear='" + txtCustYear.Text.Trim() + "'";
                objcls.execute(sql1);
                MessageBox.Show("Bill Paid Successfully..");
            }
            filldt();
            Clear();
            btnPayNow.Enabled = true;
        }

        private void txtPaidAmt_TextChanged(object sender, EventArgs e)
        {
            double TotAmt = Convert.ToDouble(txtTotalAmt.Text);
            double PaidAmt = Convert.ToDouble(txtPaidAmt.Text);
            double BalanceAmt = TotAmt-PaidAmt;
            txtBalAmt.Text = Convert.ToString(BalanceAmt);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
           // btnNew.Enabled = false;
            panelFront.Visible = true;
            panelFront.BringToFront();
            panelBack.SendToBack();
           // btnNew.Enabled = true;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            panelFront.Visible = false;
            panelFront.SendToBack();
            panelBack.BringToFront();
            panelBack.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnClose.Enabled = false;
            this.Close();
            btnClose.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnBack.Enabled = false;
            panelBack.SendToBack();
            panelFront.BringToFront();
            panelFront.Visible = true;
            btnBack.Enabled = true;
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            RDLCReports.frmBillCustListReport RDLCBCL = new RDLCReports.frmBillCustListReport();
            RDLCBCL.TopLevel = false;
            panelBillPay.Controls.Add(RDLCBCL);
            RDLCBCL.BringToFront();
            RDLCBCL.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvCustomerBillDetails.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                XcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvCustomerBillDetails.Columns.Count + 1; i++)
                {
                    XcelApp.Cells[1, i] = dgvCustomerBillDetails.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvCustomerBillDetails.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvCustomerBillDetails.Columns.Count; j++)
                    {
                        XcelApp.Cells[i + 2, j + 1] = dgvCustomerBillDetails.Rows[i].Cells[j].Value.ToString();
                    }
                }
                XcelApp.Columns.AutoFit();
                XcelApp.Visible = true;
            }
        }

        private void panelFront_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBillPay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBillPay_Shown(object sender, EventArgs e)
        {
            txtSearchCustomer.Focus();
        }
    }
    }

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace MilkDistributionApp
{
    public partial class FrmPaymentHistory : Form
    {
        public FrmPaymentHistory()
        {
            InitializeComponent();
        }
        ClassConn objcls = new ClassConn();
        DataSet ds = new DataSet();
        string sql;

       // public static ArrayList DetForm = new ArrayList();

        private void FrmPaymentHistory_Load(object sender, EventArgs e)
        {
            filldt();
            txtSearchCustomer.Focus();
        }

        public void filldt()
        {
            // sql = "select Id,CDate,CustomerName,MobileNo,Address,Cmonth from CustomerProfiles where CompanyId='" + ClassConn.Companyid + "'and CustomerStatus='Active'";
            sql = "select CustId,CDate,CustomerName,MobileNo,Address,Balance,PaidAmt,GrandTotal from Bills where CompanyId='" + ClassConn.Companyid + "'and CustomerStatus='Active'";
            ds = objcls.fillDs(sql);
            dgvPaymentlist.DataSource = ds.Tables[0];
            dgvPaymentlist.Columns[0].Visible = false;

            dgvPaymentlist.Columns[2].Width = 150;
            dgvPaymentlist.Columns[3].Width = 130;
            dgvPaymentlist.Columns[4].Width = 130;
            dgvPaymentlist.Columns[5].Width = 120;
            dgvPaymentlist.Columns[6].Width = 120;
            dgvPaymentlist.Columns[7].Width = 130;
        }


        private void dgvPaymentlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelFront.Visible = false;
            panelFront.SendToBack();
            panelBack.BringToFront();
            panelBack.Visible = true;
            txtName.TabIndex = 0; ;
            txtName.Focus();
            txtCustId.Text = dgvPaymentlist.SelectedCells[0].Value.ToString();
            txtName.Text = dgvPaymentlist.SelectedCells[2].Value.ToString();
            txtNumber.Text = dgvPaymentlist.SelectedCells[3].Value.ToString();
            sql = "Select CustId,CDate,Cmonth,PaidAmt from Bills where CustId='" + txtCustId.Text + "' and CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            dgvPaymentDetails.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dgvPaymentDetails.Rows.Add();
                dgvPaymentDetails.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                dgvPaymentDetails.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                dgvPaymentDetails.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i].ItemArray[3].ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnClose.Enabled = false;
            this.Controls.Remove(this);
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
            btnPrintAll.Enabled = false;
            RDLCReports.frmPaymentHistoryReport RDLCPH = new RDLCReports.frmPaymentHistoryReport();
            RDLCPH.TopLevel = false;
            panelPaymentHistory.Controls.Add(RDLCPH);
            RDLCPH.BringToFront();
            RDLCPH.Show();
            btnPrintAll.Enabled = true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            btnExport.Enabled = false;
            if (dgvPaymentlist.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                XcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvPaymentlist.Columns.Count + 1; i++)
                {
                    XcelApp.Cells[1, i] = dgvPaymentlist.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvPaymentlist.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvPaymentlist.Columns.Count; j++)
                    {
                        XcelApp.Cells[i + 2, j + 1] = dgvPaymentlist.Rows[i].Cells[j].Value.ToString();
                    }
                }
                XcelApp.Columns.AutoFit();
                XcelApp.Visible = true;
            }
            btnExport.Enabled = true;
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            sql = "select Id,CDate,CustomerName,MobileNo,Address,Balance,PaidAmt,GrandTotal from Bills where CustomerName like '%" + txtSearchCustomer.Text + "%'  and CompanyId='" + ClassConn.Companyid + "'";
            ds = new DataSet();
            ds = objcls.fillDs(sql);
            dgvPaymentlist.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            this.Close();
            button1.Enabled = true;
        }

        private void FrmPaymentHistory_Shown(object sender, EventArgs e)
        {
            txtSearchCustomer.Focus();
        }
    }
}

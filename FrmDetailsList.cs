using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkDistributionApp
{
    public partial class FrmDetailsList : Form
    {

        string formnm = "";

        public FrmDetailsList(string FormName)
        {
            InitializeComponent();
            formnm = FormName;
        }
        ClassConn objcls = new ClassConn();
        DataSet ds = new DataSet();
        string sql;
        int cnt;

        private void FrmDetailsList_Load(object sender, EventArgs e)
        {
            FillData();
            //dgvActive.Columns[0].Visible = false;
            //dgvDeactive.Columns[0].Visible = false;
            //dgvPaidAmt.Columns[0].Visible = false;
            //dgvBalanceAmt.Columns[0].Visible = false;
            //dgvTotalAmt.Columns[0].Visible = false;
        }

        public void SelectActiveCust()
        {
            sql = "Select * from CustomerProfiles where CustomerStatus ='Active' and CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            dgvActive.DataSource = ds.Tables[0];
        }
        public void SelectDeactiveCust()
        {
            sql = "Select * from CustomerProfiles where CustomerStatus ='Deactive' and CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            dgvDeactive.DataSource = ds.Tables[0];
        }
        public void PaidAmount()
        {
            DateTime month = Convert.ToDateTime(DateTime.Now.AddMonths(-1));
            int CMonth = month.Month;//month
            int Cyear = month.Year;//year

            string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(CMonth);

            sql = "Select * from Bills where Cmonth<='" + MonthName + "' and Cyear<='" + Cyear + "' and CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            dgvPaidAmt.DataSource = ds.Tables[0];
        }

        public void BalanceAmount()
        {
            DateTime month = Convert.ToDateTime(DateTime.Now.AddMonths(-1));
            int CMonth = month.Month;//month
            int Cyear = month.Year;//year

            string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(CMonth);

            sql = "Select * from Bills where Cmonth<='" + MonthName + "' and Cyear<='" + Cyear + "' and CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            dgvBalanceAmt.DataSource = ds.Tables[0];
        }

        public void TotalAmt()
        {
            DateTime month = Convert.ToDateTime(DateTime.Now.AddMonths(-1));
            int CMonth = month.Month;//month
            int Cyear = month.Year;//year

            string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(CMonth);

            sql = "Select * from Bills where Cmonth<='" + MonthName + "' and Cyear<='" + Cyear + "' and CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            dgvTotalAmt.DataSource = ds.Tables[0];
        }
        public void FillData()
        {
            if (formnm == "pnlActive")
            {
                pnlActive.BringToFront();
                pnlActive.Visible = true;
                SelectActiveCust();
            }
            if (formnm == "pnlDeactive")
            {
                pnlActive.SendToBack();
                pnlActive.Visible = false;
                pnlDeactiveCust.BringToFront();
                pnlDeactiveCust.Visible = true;
                SelectDeactiveCust();
            }
            if (formnm == "pnlTotal")
            {
                pnlActive.SendToBack();
                pnlActive.Visible = false;
                pnlDeactiveCust.SendToBack();
                pnlDeactiveCust.Visible = false;
                pnlTotalAmt.BringToFront();
                TotalAmt();
            }
            if (formnm == "pnlPaidAmt")
            {
                pnlActive.SendToBack();
                pnlActive.Visible = false;
                pnlDeactiveCust.SendToBack();
                pnlDeactiveCust.Visible = false;
                pnlTotalAmt.SendToBack();
                pnlTotalAmt.Visible = false;
                PnlPaidAmount.BringToFront();
                PaidAmount();
            }
        
            if (formnm == "pnlBalanceAmt")
            {
                pnlActive.SendToBack();
                pnlActive.Visible = false;
                pnlDeactiveCust.SendToBack();
                pnlDeactiveCust.Visible = false;
                pnlTotalAmt.SendToBack();
                pnlTotalAmt.Visible = false;
                PnlPaidAmount.SendToBack();
                PnlPaidAmount.Visible = false;
                PnlBalanceAmt.BringToFront();
                BalanceAmount();
            }       
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            btnClose.Enabled = false;
            this.Close();
            btnClose.Enabled = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkDistributionApp
{
    public partial class FrmNewDashbord : Form
    {
        public FrmNewDashbord()
        {
            InitializeComponent();
        }
        ClassConn objcls = new ClassConn();
        DataSet ds = new DataSet();
        string sql;
        int cnt;

        //bool showLogin = false;        //bool showBird = true;

        private void FrmNewDashbord_Load(object sender, EventArgs e)
        {
            lblCompanyName.TextAlign = ContentAlignment.MiddleCenter;
            lblCompanyAdd.TextAlign= ContentAlignment.MiddleCenter;
            SelectCompanyName();
            SelectActiveCust();
            SelectDeactiveCust();
            PaidAmount();
            BalanceAmount();
            TotalAmt();
        }

        public void SelectActiveCust()
        {
            sql = "Select count(*) from CustomerProfiles where CompanyId='" + ClassConn.Companyid + "' and CustomerStatus ='Active'";
            cnt = objcls.executescal(sql);
            lblactiveCust.Text =Convert.ToString(cnt);
        }
        public void SelectDeactiveCust()
        {
            sql = "Select count(*) from CustomerProfiles where CompanyId='" + ClassConn.Companyid + "' and CustomerStatus ='Deactive'";
            int dcnt = objcls.executescal(sql);
            lblDeactiveCust.Text = Convert.ToString(dcnt);
        }

        public void PaidAmount()
        {
            DateTime month = Convert.ToDateTime(DateTime.Now.AddMonths(-1));
            int CMonth = month.Month;//month
            int Cyear = month.Year;//year

            string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(CMonth);
            int pcnt;
            sql = "Select count(PaidAmt) from Bills where Cmonth<='" + MonthName + "' and Cyear<='" + Cyear + "'";
            int cntp = objcls.executescal(sql);
            if (cntp!=0)
            {
               sql = "Select sum(cast(PaidAmt as float)) from Bills where Cmonth<='" + MonthName + "' and Cyear<='" + Cyear + "' ";
               pcnt = objcls.executescal(sql);
            }
            else
            {
                pcnt = 0;
            }
            lblPaidAmount.Text = Convert.ToString(pcnt);
        }

        public void BalanceAmount()
        {
            DateTime month = Convert.ToDateTime(DateTime.Now.AddMonths(-1));
            int CMonth = month.Month;//month
            int Cyear = month.Year;//year

            string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(CMonth);
            int Bcnt;
            sql = "Select count(Balance) from Bills where CompanyId='" + ClassConn.Companyid + "' and Cmonth<='" + MonthName + "' and Cyear<='" + Cyear + "'";
            int cntp = objcls.executescal(sql);
            if (cntp != 0)
            {
                sql = "Select sum(cast(Balance as float)) from Bills where CompanyId='" + ClassConn.Companyid + "' and Cmonth<='" + MonthName + "' and Cyear<='" + Cyear + "' ";
                Bcnt = objcls.executescal(sql);
            }
            else
            {
                Bcnt = 0;
            }
            lblBalanceAmt.Text = Convert.ToString(Bcnt);
        }
        public void TotalAmt()
        {
            DateTime month = Convert.ToDateTime(DateTime.Now.AddMonths(-1));
            int CMonth = month.Month;//month
            int Cyear = month.Year;//year

            string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(CMonth);
            int gcnt;
            sql= "Select count(GrandTotal) from Bills where CompanyId='" + ClassConn.Companyid + "' and Cmonth<='" + MonthName + "' and Cyear<='" + Cyear + "'";
            int cntp = objcls.executescal(sql);
            if (cntp != 0)
            {
                sql = "Select sum(cast(GrandTotal as float)) from Bills where CompanyId='" + ClassConn.Companyid + "' and Cmonth<='" + MonthName + "' and Cyear<='" + Cyear + "' ";
                gcnt = objcls.executescal(sql);
            }
            else
            {
                gcnt = 0;
            }
            lblTotalAmt.Text = Convert.ToString(gcnt);
        }


        public void SelectCompanyName()
        {
            sql = "select CompanyName,Address from CompanyRegistrations where CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                lblCompanyName.Text = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                lblCompanyAdd.Text = ds.Tables[0].Rows[i].ItemArray[1].ToString();
            }
        }
        //select TreeNode and ChildNode then display on formLoad 
        public void LoadForm(string form, Form F)
        {
            try
            {
                Type objectType = (from asm in AppDomain.CurrentDomain.GetAssemblies()
                                   from type in asm.GetTypes()
                                   where type.IsClass && type.Name == form
                                   select type).Single();
                object obj = Activator.CreateInstance(objectType);
                Form f = obj as Form;
                f.ShowDialog();
            }
            catch
            {
            }
        }       
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "DashBoard")
            {
                panDash.Visible = true;
                panDash.BringToFront();
            }           
        
            if (e.Node.Name == "FrmAddMilkMan")
            {
                pnlForms.Visible = true;
                pnlForms.BringToFront();
                FrmAddMilkMan frmAM = new FrmAddMilkMan();
                frmAM.TopLevel = false;
                pnlForms.Controls.Add(frmAM);
                frmAM.BringToFront();
                frmAM.Show();
            }
            if (e.Node.Name == "FrmAddRoute")
            {
                pnlForms.Visible = true;
                pnlForms.BringToFront();
                FrmAddRoute frmAR = new FrmAddRoute();
                frmAR.TopLevel = false;
                pnlForms.Controls.Add(frmAR);
                frmAR.BringToFront();
                frmAR.Show();
            }
            if (e.Node.Name == "FrmAddProducts")
            {
                pnlForms.Visible = true;
                pnlForms.BringToFront();
                FrmAddProducts frmAP = new FrmAddProducts();
                frmAP.TopLevel = false;
                pnlForms.Controls.Add(frmAP);
                frmAP.BringToFront();
                frmAP.Show();
            }
            if (e.Node.Name == "FrmAddCustomer")
            {
                pnlForms.Visible = true;
                pnlForms.BringToFront();
                FrmAddCustomer frmAC = new FrmAddCustomer();
                frmAC.TopLevel = false;
                pnlForms.Controls.Add(frmAC);
                frmAC.BringToFront();
                frmAC.Show();
            }
            if (e.Node.Name == "FrmCustomerDetails")
            {
                pnlForms.Visible = true;
                pnlForms.BringToFront();
                FrmCustomerDetails frmCD = new FrmCustomerDetails();
                frmCD.TopLevel = false;
                pnlForms.Controls.Add(frmCD);
                frmCD.BringToFront();
                frmCD.Show();
            }

            if (e.Node.Name == "GenerateBill")
            {
                pnlForms.Visible = true;
                pnlForms.BringToFront();
                FrmMassage frmMgg = new FrmMassage();
                frmMgg.TopLevel = false;
                pnlForms.Controls.Add(frmMgg);
                frmMgg.BringToFront();
                frmMgg.Show();
                      
            }

            if (e.Node.Name == "FrmBillPay")
            {
                pnlForms.Visible = true;
                pnlForms.BringToFront();
                FrmBillPay frmBP = new FrmBillPay();
                frmBP.TopLevel = false;
                pnlForms.Controls.Add(frmBP);
                frmBP.BringToFront();
                frmBP.Show();
            }
            if (e.Node.Name == "FrmPaymentHistory")
            {
                pnlForms.Visible = true;
                pnlForms.BringToFront();
                FrmPaymentHistory frmPH = new FrmPaymentHistory();
                frmPH.TopLevel = false;
                pnlForms.Controls.Add(frmPH);
                frmPH.BringToFront();
                frmPH.Show();
            }
        }     
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }              
        private void panelActive_Click(object sender, EventArgs e)
        {
            pnlForms.Visible = true;
            pnlForms.BringToFront();
            FrmDetailsList objDL = new FrmDetailsList("pnlActive");
            objDL.TopLevel = false;
            pnlForms.Controls.Add(objDL);
            objDL.BringToFront();
            objDL.Show();
        }

        private void panelDeactive_Click(object sender, EventArgs e)
        {
            pnlForms.Visible = true;
            pnlForms.BringToFront();
            FrmDetailsList objdD = new FrmDetailsList("pnlDeactive");
            objdD.TopLevel = false;
            pnlForms.Controls.Add(objdD);
            objdD.BringToFront();
            objdD.Show();
        }
        private void pnlTotal_Click(object sender, EventArgs e)
        {
            pnlForms.Visible = true;
            pnlForms.BringToFront();
            FrmDetailsList objdD = new FrmDetailsList("pnlTotal");
            objdD.TopLevel = false;
            pnlForms.Controls.Add(objdD);
            objdD.BringToFront();
            objdD.Show();
        }

        private void panPaidAmt_Click(object sender, EventArgs e)
        {
            pnlForms.Visible = true;
            pnlForms.BringToFront();
            FrmDetailsList objdD = new FrmDetailsList("pnlPaidAmt");
            objdD.TopLevel = false;
            pnlForms.Controls.Add(objdD);
            objdD.BringToFront();
            objdD.Show();
        }

        private void pnlBalance_Click(object sender, EventArgs e)
        {
            pnlForms.Visible = true;
            pnlForms.BringToFront();
            FrmDetailsList objdD = new FrmDetailsList("pnlBalanceAmt");
            objdD.TopLevel = false;
            pnlForms.Controls.Add(objdD);
            objdD.BringToFront();
            objdD.Show();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelActive_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTotal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

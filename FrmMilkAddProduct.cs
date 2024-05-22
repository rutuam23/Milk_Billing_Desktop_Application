using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkDistributionApp
{
    public partial class FrmMilkAddProduct : Form
    {
        FrmMilkStatus FMS;
               
        public FrmMilkAddProduct(FrmMilkStatus MS)
        {
            InitializeComponent();
            this.FMS = MS;
        }

        ClassConn objcls = new ClassConn();
        DataSet ds = new DataSet();
        string sql;
        int cnt;
     
        private void FrmMilkAddProduct_Load(object sender, EventArgs e)
        {
            ClassConn.DateEvenOdd = Convert.ToDateTime(UserControlDays.static_day + "/" + FrmMilkStatus.static_NowMonth + "/" + FrmMilkStatus.static_NowYear);
            MilkType();
            filldt();
            fillalldt();          
            dtpSelectDate.Text = Convert.ToString(ClassConn.DateEvenOdd);
            dgvProductDetails.Columns[0].Visible = false;
            pcloader.Visible = false;
        }

        public void fillalldt()
        {
            DateTime PDate = ClassConn.DateEvenOdd;
            sql = "select ProductName,ProductQty,ProductRate,ProductShortName from ProductStatus where PDate='" + string.Format("{0:d/M/yyyy }", PDate) + "' and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            dgvAllProductDetails.DataSource = ds.Tables[0];
        }

        public void filldt()
        {
            DateTime PDate = ClassConn.DateEvenOdd;
            sql = "select ProductNameId,ProductName,ProductQty,ProductRate,ProductShortName from ProductStatus where PDate='" + string.Format("{0:d/M/yyyy }", PDate)+ "' and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            dgvProductDetails.DataSource = ds.Tables[0];
        }

        public void MilkType()
        {
            sql = "select * from CustomerProfiles where Id='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i].ItemArray[4].ToString() == "Cow Milk" && ds.Tables[0].Rows[i].ItemArray[5].ToString() == "Buffallo Milk")
                {
                    pnlF.SendToBack();
                    pnlF.Visible = false;
                    pnlB.Visible = true;
                    CMRateAll();
                    CustQtyAll();
                    CustHQtyAll();
                    BMRateAll();
                    CustBMQtyAll();
                    CustBMHQtyAll();
                }
                else if (ds.Tables[0].Rows[i].ItemArray[4].ToString() == "Cow Milk" && ds.Tables[0].Rows[i].ItemArray[5].ToString() != "Buffallo Milk")
                {
                    pnlB.SendToBack();
                    pnlF.BringToFront();
                    pnlF.Visible = true;
                    lblMilktype.Text = "Cow Milk";
                    CMRate();
                    CustQty();
                    CustHQty();
                }
                else if (ds.Tables[0].Rows[i].ItemArray[5].ToString() == "Buffallo Milk" && ds.Tables[0].Rows[i].ItemArray[4].ToString() != "Cow Milk")
                {
                    pnlB.SendToBack();
                    pnlF.BringToFront();
                    pnlF.Visible = true;
                    lblMilktype.Text = "Buffallo Milk";
                    BMRate();
                    CustBMQty();
                    CustBMHQty();
                }
            }
        }

        // for Cow Milk
        public void CMRate()
        {
            sql = "Select Cowrate from MilkRates where CompanyId='" + ClassConn.Companyid + "'";
            cnt = objcls.executescal(sql);
            txtMilktyperate.Text = Convert.ToString(cnt);
        }
        public void CustQty()
        {
            sql = "Select CowMilkQty from CustomerProfiles where Id='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
            cnt = objcls.executescal(sql);
            numericUpDownMilkType.Text = Convert.ToString(cnt);
        }
        public void CustHQty()
        {
            sql = "Select CowHalfMilkQty from CustomerProfiles where Id='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
            cnt = objcls.executescal(sql);
            numericUpDownHMilktype.Text = Convert.ToString(cnt);
        }
        public void CMQTYcalculation()
        {
            try
            {
                double CMFullRate = Convert.ToDouble(txtMilktyperate.Text);
                double CMHalfRate = Convert.ToDouble(txtMilktyperate.Text) / 2;
                double CalCMFullRate = (Convert.ToDouble(numericUpDownMilkType.Value) * (CMFullRate));
                double CalCMHalfRate = (Convert.ToDouble(numericUpDownHMilktype.Value) * (CMHalfRate));
                txtMilktypeTotAmt.Text = Convert.ToString(CalCMFullRate + CalCMHalfRate);
            }
            catch { }
        }
        // for Buffallo Milk
        public void BMRate()
        {
            sql = "Select Buffallorate from MilkRates where CompanyId='" + ClassConn.Companyid + "'";
            cnt = objcls.executescal(sql);
            txtMilktyperate.Text = Convert.ToString(cnt);
        }
        public void CustBMQty()
        {
            sql = "Select BuffalloMilkQty from CustomerProfiles where Id='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
            cnt = objcls.executescal(sql);
            numericUpDownMilkType.Text = Convert.ToString(cnt);
        }
        public void CustBMHQty()
        {
            sql = "Select BuffalloHalfMilkQty from CustomerProfiles where Id='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
            cnt = objcls.executescal(sql);
            numericUpDownHMilktype.Text = Convert.ToString(cnt);
        }
        public void BMQTYcalculation()
        {
            try
            {
                double BMFullRate = Convert.ToDouble(txtMilktyperate.Text);
                double BMHalfRate = Convert.ToDouble(txtMilktyperate.Text) / 2;
                double CalBMFullRate = (Convert.ToDouble(numericUpDownMilkType.Value) * (BMFullRate));
                double CalBMHalfRate = (Convert.ToDouble(numericUpDownHMilktype.Value) * (BMHalfRate));
                txtMilktypeTotAmt.Text = Convert.ToString(CalBMFullRate + CalBMHalfRate);
            }
            catch { }
        }
        private void numericUpDownMilkType_ValueChanged(object sender, EventArgs e)
        {
            if (lblMilktype.Text == "Cow Milk")
            {
                CMQTYcalculation();
            }
            else
            {
                BMQTYcalculation();
            }
        }
        private void numericUpDownHMilktype_ValueChanged(object sender, EventArgs e)
        {
            if (lblMilktype.Text == "Cow Milk")
            {
                CMQTYcalculation();
            }
            else
            {
                BMQTYcalculation();
            }
        }
        // for Cow and Buffallo Milk
        public void CMRateAll()
        {
            sql = "Select Cowrate from MilkRates where CompanyId='" + ClassConn.Companyid + "'";
            cnt = objcls.executescal(sql);
            txtCMRate.Text = Convert.ToString(cnt);
        }
        public void CustQtyAll()
        {
            sql = "Select CowMilkQty from CustomerProfiles where Id='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
            cnt = objcls.executescal(sql);
            numericUpDownCMQty.Text = Convert.ToString(cnt);
        }
        public void CustHQtyAll()
        {
            sql = "Select CowHalfMilkQty from CustomerProfiles where Id='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
            cnt = objcls.executescal(sql);
            numericUpDownCMHQty.Text = Convert.ToString(cnt);
        }
        public void CMQTYcalculationAll()
        {
            try
            {
                double CMFullRate = Convert.ToDouble(txtCMRate.Text);
                double CMHalfRate = Convert.ToDouble(txtCMRate.Text) / 2;
                double CalCMFullRate = (Convert.ToDouble(numericUpDownCMQty.Value) * (CMFullRate));
                double CalCMHalfRate = (Convert.ToDouble(numericUpDownCMHQty.Value) * (CMHalfRate));
                txtCMTotAmt.Text = Convert.ToString(CalCMFullRate + CalCMHalfRate);
            }
            catch { }
        }
        public void BMRateAll()
        {
            sql = "Select Buffallorate from MilkRates where CompanyId='" + ClassConn.Companyid + "'";
            cnt = objcls.executescal(sql);
            txtBMRate.Text = Convert.ToString(cnt);
        }
        public void CustBMQtyAll()
        {
            sql = "Select BuffalloMilkQty from CustomerProfiles where Id='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
            cnt = objcls.executescal(sql);
            numericUpDownBMQty.Text = Convert.ToString(cnt);
        }
        public void CustBMHQtyAll()
        {
            sql = "Select BuffalloHalfMilkQty from CustomerProfiles where Id='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
            cnt = objcls.executescal(sql);
            numericUpDownBMHQty.Text = Convert.ToString(cnt);
        }
        public void BMQTYcalculationAll()
        {
            try
            {
                double BMFullRate = Convert.ToDouble(txtBMRate.Text);
                double BMHalfRate = Convert.ToDouble(txtBMRate.Text) / 2;
                double CalBMFullRate = (Convert.ToDouble(numericUpDownBMQty.Value) * (BMFullRate));
                double CalBMHalfRate = (Convert.ToDouble(numericUpDownBMHQty.Value) * (BMHalfRate));
                txtBMTotAmt.Text = Convert.ToString(CalBMFullRate + CalBMHalfRate);
            }
            catch { }
        }
        public void CalFinalTotAmt()
        {
            double CMTotAmt = Convert.ToDouble(txtCMTotAmt.Text);
            double BMTotAm = Convert.ToDouble(txtBMTotAmt.Text);
            double FinalTotAmt = Convert.ToDouble((CMTotAmt) + (BMTotAm));
            txtFinalTotAmt.Text = Convert.ToString(FinalTotAmt);
        }
        private void numericUpDownCMQty_ValueChanged(object sender, EventArgs e)
        {
            CMQTYcalculationAll();
            CalFinalTotAmt();
        }
        private void numericUpDownCMHQty_ValueChanged(object sender, EventArgs e)
        {
            CMQTYcalculationAll();
            CalFinalTotAmt();
        }
        private void numericUpDownBMQty_ValueChanged(object sender, EventArgs e)
        {
            BMQTYcalculationAll();
            CalFinalTotAmt();
        }
        private void numericUpDownBMHQty_ValueChanged(object sender, EventArgs e)
        {
            BMQTYcalculationAll();
            CalFinalTotAmt();
        }

        public void ProductName()
        {
            sql = "select ProductNameId,ProductName from ProductMasters where CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            cmbProduct.DataSource = ds.Tables[0];
        }
        public void ProductRate()
        {
            sql = "select ProductRate from ProductMasters where ProductNameId='" + cmbProduct.SelectedValue + "'";
            cnt = objcls.executescal(sql);
            txtRate.Text = Convert.ToString(cnt);
        }
        public void ProductQty()
        {
            sql = "select ProductQty+'/'+ProductUnit as ProductQty from ProductMasters where ProductNameId='" + cmbProduct.SelectedValue + "'";
            ds = objcls.fillDs(sql);
            cmbProQty.DataSource = ds.Tables[0];
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            btnAddProduct.Enabled = false;
            panelFront.SendToBack();
            panelFront.Visible = false;
            panelBack.Visible = true;
            ProductName();
            btnAddProduct.Enabled = true;
        }
        private void btnAddPro_Click(object sender, EventArgs e)
        {
            btnAddPro.Enabled = false;
            DateTime Date = ClassConn.DateEvenOdd;
            string PDate = string.Format("{0:d/M/yyyy }", Date);
            string CDay = Date.Day.ToString();
            string CMonth = Date.Month.ToString();
            string Cyear = Date.Year.ToString();

            sql = "Select * from ProductMasters where ProductNameId='" + cmbProduct.SelectedValue.ToString() + "'";
            ds = objcls.fillDs(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                sql = "Insert into ProductStatus(CustId,ProductNameId,ProductName,ProductRate,ProductQty,ProductShortName,ProductUnit,AddProductStatus,CompanyId,PDate,PTotalAmt,Cday,Cmonth,Cyear)values('" + ClassConn.CustID + "','" + cmbProduct.SelectedValue + "','" + cmbProduct.Text + "','" + txtRate.Text + "','" + cmbProQty.Text + "','" + ds.Tables[0].Rows[i].ItemArray[5].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[6].ToString() + "','AddProduct','" + ClassConn.Companyid + "','" + string.Format("{0:d/M/yyyy }", PDate) + "','0','" + CDay + "','" + CMonth + "','" + Cyear + "')";
                objcls.execute(sql);
                MessageBox.Show("Save successfully...");
            }
            filldt();
            fillalldt();
            btnAddPro.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            this.Close();
            btnCancel.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnBack.Enabled = false;
            panelBack.SendToBack();
            panelFront.BringToFront();
            panelFront.Visible = true;
            btnBack.Enabled = true;
        }       

        private void cmbProduct_SelectedValueChanged_1(object sender, EventArgs e)
        {
            ProductRate();
            ProductQty();
        }

     
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(5000);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FMS.displayPresentYearCalendar();
            pcloader.Visible = false;
            this.Hide();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
            decimal CMCQty = 0;
            decimal CMHCQty = 0;
            decimal BMCQty = 0;
            decimal BMHCQty = 0;
            decimal PCMCQty = 0;
            decimal PCMHCQty = 0;
            decimal PBMCQty = 0;
            decimal PBMHCQty = 0;

            if (cmbSelectMilkStatus.Text == "Select")
            {
                MessageBox.Show("Please Select MilkStatus");
                return;
            }
        
            DateTime CDate = ClassConn.DateEvenOdd;
            string CDay = CDate.Day.ToString();
            string CMonth = CDate.Month.ToString();
            string Cyear = CDate.Year.ToString();
            DateTime Today = DateTime.Now;

            sql = "Select CowMilkQty,CowHalfMilkQty,BuffalloMilkQty,BuffalloHalfMilkQty from CustomerProfiles where Id='" + ClassConn.CustID + "'and CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                CMCQty = Convert.ToDecimal(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                CMHCQty = Convert.ToDecimal(ds.Tables[0].Rows[i].ItemArray[1].ToString());
                BMCQty = Convert.ToDecimal(ds.Tables[0].Rows[i].ItemArray[2].ToString());
                BMHCQty = Convert.ToDecimal(ds.Tables[0].Rows[i].ItemArray[3].ToString());
            }
                sql = "Delete from DeliveryStatus where  CDate = '" + string.Format("{0:d/M/yyyy}", CDate) + "'and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
                objcls.execute(sql);
                sql = "Select * from CustomerProfiles where Id='" + ClassConn.CustID + "'and CompanyId='" + ClassConn.Companyid + "'";
                ds = objcls.fillDs(sql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                if (ds.Tables[0].Rows[i].ItemArray[4].ToString() == "Cow Milk" && ds.Tables[0].Rows[i].ItemArray[5].ToString() == "Buffallo Milk")
                {
                    PCMCQty = numericUpDownCMQty.Value;
                    PCMHCQty = numericUpDownCMHQty.Value;
                    PBMCQty = numericUpDownBMQty.Value;
                    PBMHCQty = numericUpDownBMHQty.Value;

                    if (CMCQty == PCMCQty && CMHCQty == PCMHCQty && BMCQty == PBMCQty && BMHCQty == PBMHCQty)
                    {
                        //MessageBox.Show("Change Quantity Frist");
                        //return;
                    }
                    else
                    {
                        sql = "INSERT into DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, MilkStatus, TotalAmt,DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','" + numericUpDownCMQty.Value + "','" + numericUpDownCMHQty.Value + "','" + txtCMRate.Text + "','" + numericUpDownBMQty.Value + "','" + numericUpDownBMHQty.Value + "','" + txtBMRate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','" + cmbSelectMilkStatus.Text + "','" + txtFinalTotAmt.Text + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy }", CDate) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                        objcls.execute(sql);
                    }
                }
                else if (ds.Tables[0].Rows[i].ItemArray[4].ToString() == "Cow Milk" && ds.Tables[0].Rows[i].ItemArray[5].ToString() != "Buffallo Milk")
                {
                    PCMCQty = numericUpDownMilkType.Value;
                    PCMHCQty = numericUpDownHMilktype.Value;

                    if (CMCQty == PCMCQty && CMHCQty == PCMHCQty)
                    {
                      //  MessageBox.Show("Change Quantity Frist");
                       // return;
                    }
                    else
                    {
                        sql = "INSERT into DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, MilkStatus, TotalAmt,DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','" + numericUpDownMilkType.Value + "','" + numericUpDownHMilktype.Value + "','" + txtMilktyperate.Text + "','0','0','0','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','" + cmbSelectMilkStatus.Text + "','" + txtMilktypeTotAmt.Text + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy }", CDate) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                        objcls.execute(sql);
                    }
                }
                else if (ds.Tables[0].Rows[i].ItemArray[5].ToString() == "Buffallo Milk" && ds.Tables[0].Rows[i].ItemArray[4].ToString() != "Cow Milk")
                {
                    PBMCQty = numericUpDownMilkType.Value;
                    PBMHCQty = numericUpDownHMilktype.Value;

                    if (BMCQty == PBMCQty && BMHCQty == PBMHCQty)
                    {
                        //MessageBox.Show("Change Quantity Frist");
                        //return;
                    }
                    else
                    {
                        sql = "INSERT into DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, MilkStatus, TotalAmt,DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','0','0','0','" + numericUpDownMilkType.Value + "','" + numericUpDownHMilktype.Value + "','" + txtMilktyperate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','" + cmbSelectMilkStatus.Text + "','" + txtMilktypeTotAmt.Text + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy }", CDate) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                        objcls.execute(sql);
                    }
                } 
            }
            pcloader.Visible = true;
            //pcloader.Dock = DockStyle.Fill;
            FMS.ClearPresentYearCalendar();
            backgroundWorker1.RunWorkerAsync();
            btnOk.Enabled = true;
        }

        private void cmbSelectMilkStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectMilkStatus.Text == "nomilk")
            {
                numericUpDownMilkType.Value = 0;
                numericUpDownHMilktype.Value = 0;
                numericUpDownCMQty.Value = 0;
                numericUpDownCMHQty.Value = 0;
                numericUpDownBMQty.Value = 0;
                numericUpDownBMHQty.Value = 0;
            }
            else
            {
                if (lblMilktype.Text == "Cow Milk")
                {
                    CMRate();
                    CustQty();
                    CustHQty();
                }
                if (lblMilktype.Text == "Buffallo Milk")
                {
                    BMRate();
                    CustBMQty();
                    CustBMHQty();
                }
                else
                {
                    CMRateAll();
                    CustQtyAll();
                    CustHQtyAll();
                    BMRateAll();
                    CustBMQtyAll();
                    CustBMHQtyAll();
                }             
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            btnremove.Enabled = false;
            DateTime PDate = ClassConn.DateEvenOdd;
            sql = "Delete from ProductStatus where ProductNameId='"+ dgvProductDetails.SelectedCells[0].Value.ToString() + "' and PDate='" + string.Format("{0:d/M/yyyy }", PDate) + "' and CustId='" + ClassConn.CustID + "'and CompanyId='" + ClassConn.Companyid + "'";
            objcls.executescal(sql);
            MessageBox.Show("Delete Successfully");
            filldt();
            fillalldt();
            btnremove.Enabled = true;
        }
    }
    } 

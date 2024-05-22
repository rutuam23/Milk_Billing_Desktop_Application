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
    public partial class FrmEvenOddChanges : Form
    {
        //for fetch data from another form
        FrmMilkStatus FMS;

        public FrmEvenOddChanges(FrmMilkStatus MS)
        {
            InitializeComponent();
            this.FMS = MS;
        }
        ClassConn objcls = new ClassConn();
        DataSet ds = new DataSet();
        string sql;
        int cnt;
        string DelTime;
        DateTime CustDate;

        decimal CMCQty = 0;
        decimal CMHCQty = 0;
        decimal BMCQty = 0;
        decimal BMHCQty = 0;
        decimal PCMCQty = 0;
        decimal PCMHCQty = 0;
        decimal PBMCQty = 0;
        decimal PBMHCQty = 0;

        private void FrmEvenOddChanges_Load(object sender, EventArgs e)
        {
            MilkType();
        }

        public void MilkType()
        {
            sql = "select * from CustomerProfiles where Id='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i].ItemArray[4].ToString() == "Cow Milk" && ds.Tables[0].Rows[i].ItemArray[5].ToString() == "Buffallo Milk")
                {
                    panelFront.SendToBack();
                    panelFront.Visible = false;
                    panelBack.Visible = true;
                    CMRateAll();
                    CustQtyAll();
                    CustHQtyAll();
                    BMRateAll();
                    CustBMQtyAll();
                    CustBMHQtyAll();
                }
                else if (ds.Tables[0].Rows[i].ItemArray[4].ToString() == "Cow Milk" && ds.Tables[0].Rows[i].ItemArray[5].ToString() != "Buffallo Milk")
                {
                    panelBack.SendToBack();
                    panelFront.BringToFront();
                    panelFront.Visible = true;
                    lblMilktype.Text = "Cow Milk";
                    CMRate();
                    CustQty();
                    CustHQty();
                }
                else if (ds.Tables[0].Rows[i].ItemArray[5].ToString() == "Buffallo Milk" && ds.Tables[0].Rows[i].ItemArray[4].ToString() != "Cow Milk")
                {
                    panelBack.SendToBack();
                    panelFront.BringToFront();
                    panelFront.Visible = true;
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
        private void txtMilktyperate_TextChanged(object sender, EventArgs e)
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
        private void txtCMRate_TextChanged(object sender, EventArgs e)
        {
            CMQTYcalculationAll();
            CalFinalTotAmt();
        }
        private void txtBMRate_TextChanged(object sender, EventArgs e)
        {
            BMQTYcalculationAll();
            CalFinalTotAmt();
        }

        //for Loader....
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


        private void btnMinMaxSubmit_Click(object sender, EventArgs e)
        {
            btnMinMaxSubmit.Enabled = false;

            ClassConn.DateEvenOdd = Convert.ToDateTime(FrmMilkStatus.static_NowMonth + "/" + FrmMilkStatus.static_NowYear);
            int CurrMonth = ClassConn.DateEvenOdd.Month;
            DateTime Today = DateTime.Now;
            int TodayMonth = Today.Month;

            if (CurrMonth < TodayMonth)
            {
                MessageBox.Show("Month are not Available..");
                this.Hide();
            }
            else
            {
                if (cmbSelectDeliveryType.Text == "Select Days")
                {
                    MessageBox.Show("Please Select Even or Odd Days");
                    return;
                }
                else
                {
                    sql = "Select CowMilkQty,CowHalfMilkQty,BuffalloMilkQty,BuffalloHalfMilkQty from CustomerProfiles where Id='" + ClassConn.CustID + "'and CompanyId='" + ClassConn.Companyid + "'";
                    ds = objcls.fillDs(sql);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        CMCQty = Convert.ToDecimal(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                        CMHCQty = Convert.ToDecimal(ds.Tables[0].Rows[i].ItemArray[1].ToString());
                        BMCQty = Convert.ToDecimal(ds.Tables[0].Rows[i].ItemArray[2].ToString());
                        BMHCQty = Convert.ToDecimal(ds.Tables[0].Rows[i].ItemArray[3].ToString());
                    }

                    sql = "Select CDate from CustomerProfiles where Id='" + ClassConn.CustID + "'and CompanyId='" + ClassConn.Companyid + "'";
                    ds = objcls.fillDs(sql);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        CustDate = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    }
                    int CustMonth = CustDate.Month;

                    if (CurrMonth != CustMonth)
                    {
                        //For Even Date
                        var firstDayOfMonth = new DateTime(ClassConn.DateEvenOdd.Year, ClassConn.DateEvenOdd.Month, 1);
                        var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                        for (DateTime d = firstDayOfMonth; d <= lastDayOfMonth; d = d.AddDays(1))
                        {
                            int CDay = Convert.ToInt32(d.Day.ToString());
                            string CMonth = d.Month.ToString();
                            string Cyear = d.Year.ToString();

                            sql = "Select * from DeliveryStatus where CDay='" + CDay + "'and Cmonth='" + CMonth + "' and Cyear='" + Cyear + "'and CustId='" + ClassConn.CustID + "'and CompanyId='" + ClassConn.Companyid + "'";
                            ds = objcls.fillDs(sql);
                            for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                            {
                                if (ds.Tables[0].Rows[j].ItemArray[17].ToString() != "Even" && ds.Tables[0].Rows[j].ItemArray[17].ToString() != "Odd")
                                {
                                    sql = "DELETE FROM DeliveryStatus WHERE DeliveryType is NULL  and CDay='" + CDay + "' and Cmonth='" + CMonth + "' and Cyear='" + Cyear + "'and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
                                    objcls.execute(sql);
                                }
                                else
                                {
                                    if (ds.Tables[0].Rows[j].ItemArray[17].ToString() == "Even")
                                    {
                                        sql = "DELETE FROM DeliveryStatus WHERE DeliveryType='Even' and CDay='" + CDay + "' and Cmonth='" + CMonth + "' and Cyear='" + Cyear + "'and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
                                        objcls.execute(sql);
                                    }
                                    else if (ds.Tables[0].Rows[j].ItemArray[17].ToString() == "Odd")
                                    {
                                        sql = "DELETE FROM DeliveryStatus WHERE DeliveryType='Odd' and CDay='" + CDay + "' and Cmonth='" + CMonth + "' and Cyear='" + Cyear + "'and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
                                        objcls.execute(sql);
                                    }
                                }
                            }
                            if (cmbSelectDeliveryType.Text == "Even")
                            {
                                if (CDay % 2 == 0)
                                {
                                    sql = "Select * from CustomerProfiles where Id='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
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
                                                MessageBox.Show("Change Quantity Frist");
                                                return;
                                            }
                                            else
                                            {
                                                sql = "INSERT into DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, DeliveryType, MilkStatus, TotalAmt, Pin, DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','" + numericUpDownCMQty.Value + "','" + numericUpDownCMHQty.Value + "','" + txtCMRate.Text + "','" + numericUpDownBMQty.Value + "','" + numericUpDownBMHQty.Value + "','" + txtBMRate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','Even','MinMaxMilk','" + txtFinalTotAmt.Text + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy}", d) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                                                objcls.execute(sql);
                                            }
                                        }
                                        else if (ds.Tables[0].Rows[i].ItemArray[4].ToString() == "Cow Milk" && ds.Tables[0].Rows[i].ItemArray[5].ToString() != "Buffallo Milk")
                                        {
                                            PCMCQty = numericUpDownMilkType.Value;
                                            PCMHCQty = numericUpDownHMilktype.Value;

                                            if (CMCQty == PCMCQty && CMHCQty == PCMHCQty)
                                            {
                                                MessageBox.Show("Change Quantity Frist");
                                                return;
                                            }
                                            else
                                            {
                                                sql = "INSERT into DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, DeliveryType, MilkStatus, TotalAmt, Pin, DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','" + numericUpDownMilkType.Value + "','" + numericUpDownHMilktype.Value + "','" + txtMilktyperate.Text + "','0','0','" + txtMilktyperate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','Even','MinMaxMilk','" + txtMilktypeTotAmt.Text + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy}", d) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                                                objcls.execute(sql);
                                            }
                                        }
                                        else if (ds.Tables[0].Rows[i].ItemArray[5].ToString() == "Buffallo Milk" && ds.Tables[0].Rows[i].ItemArray[4].ToString() != "Cow Milk")
                                        {
                                            PBMCQty = numericUpDownMilkType.Value;
                                            PBMHCQty = numericUpDownHMilktype.Value;

                                            if (BMCQty == PBMCQty && BMHCQty == PBMHCQty)
                                            {
                                                MessageBox.Show("Change Quantity Frist");
                                                return;
                                            }
                                            else
                                            {
                                                sql = "INSERT into DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, DeliveryType, MilkStatus, TotalAmt, Pin, DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','0','0','" + txtMilktyperate.Text + "','" + numericUpDownMilkType.Value + "','" + numericUpDownHMilktype.Value + "','" + txtMilktyperate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','Even','MinMaxMilk','" + txtMilktypeTotAmt.Text + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy}", d) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                                                objcls.execute(sql);
                                            }
                                        }
                                    }
                                }
                            }
                            //For Odd Date
                            else
                            {
                                if (CDay % 2 != 0)
                                {
                                    sql = "Select * from CustomerProfiles where Id='" + ClassConn.CustID + "'";
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
                                                MessageBox.Show("Change Quantity Frist");
                                                return;
                                            }
                                            else
                                            {
                                                sql = "INSERT into DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, DeliveryType, MilkStatus, TotalAmt, Pin, DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','" + numericUpDownCMQty.Value + "','" + numericUpDownCMHQty.Value + "','" + txtCMRate.Text + "','" + numericUpDownBMQty.Value + "','" + numericUpDownBMHQty.Value + "','" + txtBMRate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','Odd','MinMaxMilk','" + txtFinalTotAmt.Text + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy}", d) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                                                objcls.execute(sql);
                                            }
                                        }
                                        else if (ds.Tables[0].Rows[i].ItemArray[4].ToString() == "Cow Milk" && ds.Tables[0].Rows[i].ItemArray[5].ToString() != "Buffallo Milk")
                                        {
                                            PCMCQty = numericUpDownMilkType.Value;
                                            PCMHCQty = numericUpDownHMilktype.Value;

                                            if (CMCQty == PCMCQty && CMHCQty == PCMHCQty)
                                            {
                                                MessageBox.Show("Change Quantity Frist");
                                                return;
                                            }
                                            else
                                            {
                                                sql = "INSERT into DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, DeliveryType, MilkStatus, TotalAmt, Pin, DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','" + numericUpDownMilkType.Value + "','" + numericUpDownHMilktype.Value + "','" + txtMilktyperate.Text + "','0','0','" + txtMilktyperate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','Odd','MinMaxMilk','" + txtMilktypeTotAmt.Text + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy}", d) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                                                objcls.execute(sql);
                                            }
                                        }
                                        else if (ds.Tables[0].Rows[i].ItemArray[5].ToString() == "Buffallo Milk" && ds.Tables[0].Rows[i].ItemArray[4].ToString() != "Cow Milk")
                                        {
                                            PBMCQty = numericUpDownMilkType.Value;
                                            PBMHCQty = numericUpDownHMilktype.Value;

                                            if (BMCQty == PBMCQty && BMHCQty == PBMHCQty)
                                            {
                                                MessageBox.Show("Change Quantity Frist");
                                                return;
                                            }
                                            else
                                            {
                                                sql = "INSERT into DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, DeliveryType, MilkStatus, TotalAmt, Pin, DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','0','0','" + txtMilktyperate.Text + "','" + numericUpDownMilkType.Value + "','" + numericUpDownHMilktype.Value + "','" + txtMilktyperate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','Odd','MinMaxMilk','" + txtMilktypeTotAmt.Text + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy}", d) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                                                objcls.execute(sql);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    //Customer Enter in Middel of the Month
                    else
                    {
                        //For Even Date
                        var firstDayOfMonth = new DateTime(ClassConn.DateEvenOdd.Year, ClassConn.DateEvenOdd.Month, 1);
                        var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                        for (DateTime d = CustDate; d <= lastDayOfMonth; d = d.AddDays(1.0))
                        {
                            int CDay = Convert.ToInt32(d.Day.ToString());
                            string CMonth = d.Month.ToString();
                            string Cyear = d.Year.ToString();

                            sql = "Select * from DeliveryStatus where CDay='" + CDay + "'and Cmonth='" + CMonth + "' and Cyear='" + Cyear + "'and CustId='" + ClassConn.CustID + "'and CompanyId='" + ClassConn.Companyid + "'";
                            ds = objcls.fillDs(sql);
                            for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                            {
                                if (ds.Tables[0].Rows[j].ItemArray[17].ToString() != "Even" && ds.Tables[0].Rows[j].ItemArray[17].ToString() != "Odd")
                                {
                                    sql = "DELETE FROM DeliveryStatus WHERE DeliveryType is NULL  and CDay='" + CDay + "' and Cmonth='" + CMonth + "' and Cyear='" + Cyear + "'and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "' ";
                                    objcls.execute(sql);
                                }
                                else
                                {
                                    if (ds.Tables[0].Rows[j].ItemArray[17].ToString() == "Even")
                                    {
                                        sql = "DELETE FROM DeliveryStatus WHERE DeliveryType='Even' and CDay='" + CDay + "' and Cmonth='" + CMonth + "' and Cyear='" + Cyear + "'and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "' ";
                                        objcls.execute(sql);
                                    }
                                    else if (ds.Tables[0].Rows[j].ItemArray[17].ToString() == "Odd")
                                    {
                                        sql = "DELETE FROM DeliveryStatus WHERE DeliveryType='Odd' and CDay='" + CDay + "' and Cmonth='" + CMonth + "' and Cyear='" + Cyear + "'and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "' ";
                                        objcls.execute(sql);
                                    }
                                }
                            }
                            if (cmbSelectDeliveryType.Text == "Even")
                            {
                                if (CDay % 2 == 0)
                                {
                                    sql = "Select * from CustomerProfiles where Id='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
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
                                                MessageBox.Show("Change Quantity Frist");
                                                return;
                                            }
                                            else
                                            {
                                                sql = "INSERT into DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, DeliveryType, MilkStatus, TotalAmt, Pin, DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','" + numericUpDownCMQty.Value + "','" + numericUpDownCMHQty.Value + "','" + txtCMRate.Text + "','" + numericUpDownBMQty.Value + "','" + numericUpDownBMHQty.Value + "','" + txtBMRate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','Even','MinMaxMilk','" + txtFinalTotAmt.Text + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy}", d) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                                                objcls.execute(sql);
                                            }
                                        }
                                        else if (ds.Tables[0].Rows[i].ItemArray[4].ToString() == "Cow Milk" && ds.Tables[0].Rows[i].ItemArray[5].ToString() != "Buffallo Milk")
                                        {
                                            PCMCQty = numericUpDownMilkType.Value;
                                            PCMHCQty = numericUpDownHMilktype.Value;

                                            if (CMCQty == PCMCQty && CMHCQty == PCMHCQty)
                                            {
                                                MessageBox.Show("Change Quantity Frist");
                                                return;
                                            }
                                            else
                                            {
                                                sql = "INSERT into DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, DeliveryType, MilkStatus, TotalAmt, Pin, DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','" + numericUpDownMilkType.Value + "','" + numericUpDownHMilktype.Value + "','" + txtMilktyperate.Text + "','0','0','" + txtMilktyperate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','Even','MinMaxMilk','" + txtMilktypeTotAmt.Text + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy}", d) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                                                objcls.execute(sql);
                                            }
                                        }
                                        else if (ds.Tables[0].Rows[i].ItemArray[5].ToString() == "Buffallo Milk" && ds.Tables[0].Rows[i].ItemArray[4].ToString() != "Cow Milk")
                                        {
                                            PBMCQty = numericUpDownMilkType.Value;
                                            PBMHCQty = numericUpDownHMilktype.Value;

                                            if (BMCQty == PBMCQty && BMHCQty == PBMHCQty)
                                            {
                                                MessageBox.Show("Change Quantity Frist");
                                                return;
                                            }
                                            else
                                            {
                                                sql = "INSERT into DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, DeliveryType, MilkStatus, TotalAmt, Pin, DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','0','0','" + txtMilktyperate.Text + "','" + numericUpDownMilkType.Value + "','" + numericUpDownHMilktype.Value + "','" + txtMilktyperate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','Even','MinMaxMilk','" + txtMilktypeTotAmt.Text + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy}", d) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                                                objcls.execute(sql);
                                            }
                                        }
                                    }
                                }
                            }
                            //For Odd Date
                            else
                            {
                                if (CDay % 2 != 0)
                                {
                                    sql = "Select * from CustomerProfiles where Id='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
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
                                                MessageBox.Show("Change Quantity Frist");
                                                return;
                                            }
                                            else
                                            {
                                                sql = "INSERT into DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, DeliveryType, MilkStatus, TotalAmt, Pin, DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','" + numericUpDownCMQty.Value + "','" + numericUpDownCMHQty.Value + "','" + txtCMRate.Text + "','" + numericUpDownBMQty.Value + "','" + numericUpDownBMHQty.Value + "','" + txtBMRate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','Odd','MinMaxMilk','" + txtFinalTotAmt.Text + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy}", d) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                                                objcls.execute(sql);
                                            }
                                        }
                                        else if (ds.Tables[0].Rows[i].ItemArray[4].ToString() == "Cow Milk" && ds.Tables[0].Rows[i].ItemArray[5].ToString() != "Buffallo Milk")
                                        {
                                            PCMCQty = numericUpDownMilkType.Value;
                                            PCMHCQty = numericUpDownHMilktype.Value;

                                            if (CMCQty == PCMCQty && CMHCQty == PCMHCQty)
                                            {
                                                MessageBox.Show("Change Quantity Frist");
                                                return;
                                            }
                                            else
                                            {
                                                sql = "INSERT into DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, DeliveryType, MilkStatus, TotalAmt, Pin, DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','" + numericUpDownMilkType.Value + "','" + numericUpDownHMilktype.Value + "','" + txtMilktyperate.Text + "','0','0','" + txtMilktyperate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','Odd','MinMaxMilk','" + txtMilktypeTotAmt.Text + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy}", d) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                                                objcls.execute(sql);
                                            }
                                        }
                                        else if (ds.Tables[0].Rows[i].ItemArray[5].ToString() == "Buffallo Milk" && ds.Tables[0].Rows[i].ItemArray[4].ToString() != "Cow Milk")
                                        {
                                            PBMCQty = numericUpDownMilkType.Value;
                                            PBMHCQty = numericUpDownHMilktype.Value;

                                            if (BMCQty == PBMCQty && BMHCQty == PBMHCQty)
                                            {
                                                MessageBox.Show("Change Quantity Frist");
                                                return;
                                            }
                                            else
                                            {
                                                sql = "INSERT into DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, DeliveryType, MilkStatus, TotalAmt, Pin, DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','0','0','" + txtMilktyperate.Text + "','" + numericUpDownMilkType.Value + "','" + numericUpDownHMilktype.Value + "','" + txtMilktyperate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','Odd','MinMaxMilk','" + txtMilktypeTotAmt.Text + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy}", d) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                                                objcls.execute(sql);
                                            }
                                    }
                                }
                            }
                        }
                        //FMS.ClearPresentYearCalendar();
                        //backgroundWorker1.RunWorkerAsync();
                    }
                }
                pcloader.Visible = true;
                FMS.ClearPresentYearCalendar();
                backgroundWorker1.RunWorkerAsync();
            }
        }
            btnMinMaxSubmit.Enabled = true;
        }

        private void btnNoMilkSubmit_Click(object sender, EventArgs e)
        {
            btnNoMilkSubmit.Enabled = false;

            pcloader.Visible = true;

            ClassConn.DateEvenOdd = Convert.ToDateTime(FrmMilkStatus.static_NowMonth + "/" + FrmMilkStatus.static_NowYear);
            int CurrMonth = ClassConn.DateEvenOdd.Month;
            DateTime Today = DateTime.Now;
            int TodayMonth = Today.Month;

            if (CurrMonth < TodayMonth)
            {
                MessageBox.Show("Month are not Available..");
                this.Hide();
            }
            else
            {
                if (cmbSelectDeliveryType.Text == "Select Days")
                {
                    MessageBox.Show("Please Select Even or Odd Days");
                    return;
                }
                else
                {
                    sql = "Select CDate from CustomerProfiles where Id='" + ClassConn.CustID + "'and CompanyId='" + ClassConn.Companyid + "'";
                    ds = objcls.fillDs(sql);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        CustDate = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    }
                    int CustMonth = CustDate.Month;

                    numericUpDownMilkType.Value = 0;
                    numericUpDownHMilktype.Value = 0;
                    numericUpDownCMQty.Value = 0;
                    numericUpDownCMHQty.Value = 0;
                    numericUpDownBMQty.Value = 0;
                    numericUpDownBMHQty.Value = 0;

                    if (CurrMonth != CustMonth)
                    {                      
                        var firstDayOfMonth = new DateTime(ClassConn.DateEvenOdd.Year, ClassConn.DateEvenOdd.Month, 1);
                        var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                        for (DateTime d = firstDayOfMonth; d <= lastDayOfMonth; d = d.AddDays(1.0))
                        {
                            int CDay = Convert.ToInt32(d.Day.ToString());
                            string CMonth = d.Month.ToString();
                            string Cyear = d.Year.ToString();

                                sql = "Select * from DeliveryStatus where Cmonth='" + CMonth + "' and Cyear='" + Cyear + "'and CustId='" + ClassConn.CustID + "'and CompanyId='" + ClassConn.Companyid + "'";
                                ds = objcls.fillDs(sql);
                                for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                                {
                                    if (ds.Tables[0].Rows[j].ItemArray[17].ToString() != "Even" && ds.Tables[0].Rows[j].ItemArray[17].ToString() != "Odd")
                                    {
                                        sql = "DELETE FROM DeliveryStatus WHERE DeliveryType is NULL  and CDay='" + CDay + "' and Cmonth='" + CMonth + "' and Cyear='" + Cyear + "'and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "' ";
                                        objcls.execute(sql);
                                    }
                                    else
                                    {
                                        if (ds.Tables[0].Rows[j].ItemArray[17].ToString() == "Even")
                                        {
                                            sql = "DELETE FROM DeliveryStatus WHERE DeliveryType='Even' and CDay='" + CDay + "' and Cmonth='" + CMonth + "' and Cyear='" + Cyear + "'and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "' ";
                                            objcls.execute(sql);
                                        }
                                        else if (ds.Tables[0].Rows[j].ItemArray[17].ToString() == "Odd")
                                        {
                                            sql = "DELETE FROM DeliveryStatus WHERE DeliveryType='Odd' and CDay='" + CDay + "' and Cmonth='" + CMonth + "' and Cyear='" + Cyear + "'and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "' ";
                                            objcls.execute(sql);
                                        }
                                    }
                                }
                                //for Even
                            if (cmbSelectDeliveryType.Text == "Even")
                            {
                                if (CDay % 2 == 0)
                                {
                                    sql = "Select * from CustomerProfiles where Id='" + ClassConn.CustID + "'";
                                    ds = objcls.fillDs(sql);
                                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                                    {
                                        if (ds.Tables[0].Rows[i].ItemArray[4].ToString() == "Cow Milk" && ds.Tables[0].Rows[i].ItemArray[5].ToString() == "Buffallo Milk")
                                        {
                                                sql = "Insert into DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, DeliveryType, MilkStatus, TotalAmt, Pin, DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','" + numericUpDownCMQty.Value + "','" + numericUpDownCMHQty.Value + "','" + txtCMRate.Text + "','" + numericUpDownBMQty.Value + "','" + numericUpDownBMHQty.Value + "','" + txtBMRate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','Even','nomilk','" + txtFinalTotAmt.Text + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy}", d) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                                                objcls.execute(sql);
                                        }
                                        else if (ds.Tables[0].Rows[i].ItemArray[4].ToString() == "Cow Milk" && ds.Tables[0].Rows[i].ItemArray[5].ToString() != "Buffallo Milk")
                                        {
                                                sql = "Insert into DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, DeliveryType, MilkStatus, TotalAmt, Pin, DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','" + numericUpDownMilkType.Value + "','" + numericUpDownHMilktype.Value + "','" + txtMilktyperate.Text + "','0','0','" + txtMilktyperate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','Even','nomilk','" + txtMilktypeTotAmt.Text + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy}", d) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                                                objcls.execute(sql);
                                        }
                                        else if (ds.Tables[0].Rows[i].ItemArray[5].ToString() == "Buffallo Milk" && ds.Tables[0].Rows[i].ItemArray[4].ToString() != "Cow Milk")
                                        {

                                              sql = "Insert into DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, DeliveryType, MilkStatus, TotalAmt, Pin, DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','0','0','" + txtMilktyperate.Text + "','" + numericUpDownMilkType.Value + "','" + numericUpDownHMilktype.Value + "','" + txtMilktyperate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','Even','nomilk','" + txtMilktypeTotAmt.Text + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy}", d) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                                                objcls.execute(sql);
                                        }
                                    }
                                }
                            }
                            //for Odd
                            else
                            {
                                if (CDay % 2 != 0)
                                {
                                    sql = "Select * from CustomerProfiles where Id='" + ClassConn.CustID + "'";
                                    ds = objcls.fillDs(sql);
                                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                                    {
                                        if (ds.Tables[0].Rows[i].ItemArray[4].ToString() == "Cow Milk" && ds.Tables[0].Rows[i].ItemArray[5].ToString() == "Buffallo Milk")
                                        {
                                                sql = "Insert into DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, DeliveryType, MilkStatus, TotalAmt, Pin, DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','" + numericUpDownCMQty.Value + "','" + numericUpDownCMHQty.Value + "','" + txtCMRate.Text + "','" + numericUpDownBMQty.Value + "','" + numericUpDownBMHQty.Value + "','" + txtBMRate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','Odd','nomilk','" + txtFinalTotAmt.Text + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy}", d) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                                                objcls.execute(sql);
                                        }
                                        else if (ds.Tables[0].Rows[i].ItemArray[4].ToString() == "Cow Milk" && ds.Tables[0].Rows[i].ItemArray[5].ToString() != "Buffallo Milk")
                                        {
                                                sql = "Insert into DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, DeliveryType, MilkStatus, TotalAmt, Pin, DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','" + numericUpDownMilkType.Value + "','" + numericUpDownHMilktype.Value + "','" + txtMilktyperate.Text + "','0','0','" + txtMilktyperate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','Odd','nomilk','" + txtMilktypeTotAmt.Text + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy}", d) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                                                objcls.execute(sql);
                                        }
                                        else if (ds.Tables[0].Rows[i].ItemArray[5].ToString() == "Buffallo Milk" && ds.Tables[0].Rows[i].ItemArray[4].ToString() != "Cow Milk")
                                        {

                                              sql = "Insert into DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, DeliveryType, MilkStatus, TotalAmt, Pin, DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','0','0','" + txtMilktyperate.Text + "','" + numericUpDownMilkType.Value + "','" + numericUpDownHMilktype.Value + "','" + txtMilktyperate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','Odd','nomilk','" + txtMilktypeTotAmt.Text + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy}", d) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                                                objcls.execute(sql);
                                        }
                                    }
                                }
                            }
                        }
                        FMS.ClearPresentYearCalendar();
                        backgroundWorker1.RunWorkerAsync();
                    }
                    else
                    {
                        var firstDayOfMonth = new DateTime(ClassConn.DateEvenOdd.Year, ClassConn.DateEvenOdd.Month, 1);
                        var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                        for (DateTime d = CustDate; d <= lastDayOfMonth; d = d.AddDays(1.0))
                        {
                            int CDay = Convert.ToInt32(d.Day.ToString());
                            string CMonth = d.Month.ToString();
                            string Cyear = d.Year.ToString();
                           
                                sql = "Select * from DeliveryStatus where Cmonth='" + CMonth + "' and Cyear='" + Cyear + "'and CustId='" + ClassConn.CustID + "'and CompanyId='" + ClassConn.Companyid + "'";
                                ds = objcls.fillDs(sql);
                                for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                                {
                                    if (ds.Tables[0].Rows[j].ItemArray[17].ToString() != "Even" && ds.Tables[0].Rows[j].ItemArray[17].ToString() != "Odd")
                                    {
                                        sql = "DELETE FROM DeliveryStatus WHERE DeliveryType is NULL  and CDay='" + CDay + "' and Cmonth='" + CMonth + "' and Cyear='" + Cyear + "'and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "' ";
                                        objcls.execute(sql);
                                    }
                                    else
                                    {
                                        if (ds.Tables[0].Rows[j].ItemArray[17].ToString() == "Even")
                                        {
                                            sql = "DELETE FROM DeliveryStatus WHERE DeliveryType='Even' and CDay='" + CDay + "' and Cmonth='" + CMonth + "' and Cyear='" + Cyear + "'and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "' ";
                                            objcls.execute(sql);
                                        }
                                        else if (ds.Tables[0].Rows[j].ItemArray[17].ToString() == "Odd")
                                        {
                                            sql = "DELETE FROM DeliveryStatus WHERE DeliveryType='Odd' and CDay='" + CDay + "' and Cmonth='" + CMonth + "' and Cyear='" + Cyear + "'and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "' ";
                                            objcls.execute(sql);
                                        }
                                    }
                                }
                            //for Even
                            if (cmbSelectDeliveryType.Text == "Even")
                            {
                                if (CDay % 2 == 0)
                                {
                                    sql = "Select * from CustomerProfiles where Id='" + ClassConn.CustID + "'";
                                    ds = objcls.fillDs(sql);
                                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                                    {
                                        if (ds.Tables[0].Rows[i].ItemArray[4].ToString() == "Cow Milk" && ds.Tables[0].Rows[i].ItemArray[5].ToString() == "Buffallo Milk")
                                        {
                                                sql = "INSinto DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, DeliveryType, MilkStatus, TotalAmt, Pin, DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','" + numericUpDownCMQty.Value + "','" + numericUpDownCMHQty.Value + "','" + txtCMRate.Text + "','" + numericUpDownBMQty.Value + "','" + numericUpDownBMHQty.Value + "','" + txtBMRate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','Even','nomilk','" + txtFinalTotAmt.Text + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy}", d) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                                                objcls.execute(sql);
                                        }
                                        else if (ds.Tables[0].Rows[i].ItemArray[4].ToString() == "Cow Milk" && ds.Tables[0].Rows[i].ItemArray[5].ToString() != "Buffallo Milk")
                                        {
                                                sql = "INSinto DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, DeliveryType, MilkStatus, TotalAmt, Pin, DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','" + numericUpDownMilkType.Value + "','" + numericUpDownHMilktype.Value + "','" + txtMilktyperate.Text + "','0','0','" + txtMilktyperate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','Even','nomilk','" + txtMilktypeTotAmt.Text + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy}", d) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                                                objcls.execute(sql);
                                        }
                                        else if (ds.Tables[0].Rows[i].ItemArray[5].ToString() == "Buffallo Milk" && ds.Tables[0].Rows[i].ItemArray[4].ToString() != "Cow Milk")
                                        {
                                                sql = "INSinto DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, DeliveryType, MilkStatus, TotalAmt, Pin, DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','0','0','" + txtMilktyperate.Text + "','" + numericUpDownMilkType.Value + "','" + numericUpDownHMilktype.Value + "','" + txtMilktyperate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','Even','nomilk','" + txtMilktypeTotAmt.Text + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy}", d) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                                                objcls.execute(sql);
                                        }
                                    }
                                }
                            }
                            //for Odd
                            else
                            {
                                if (CDay % 2 != 0)
                                {
                                    sql = "Select * from CustomerProfiles where Id='" + ClassConn.CustID + "'";
                                    ds = objcls.fillDs(sql);
                                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                                    {
                                        if (ds.Tables[0].Rows[i].ItemArray[4].ToString() == "Cow Milk" && ds.Tables[0].Rows[i].ItemArray[5].ToString() == "Buffallo Milk")
                                        {
                                                sql = "INSinto DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, DeliveryType, MilkStatus, TotalAmt, Pin, DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','" + numericUpDownCMQty.Value + "','" + numericUpDownCMHQty.Value + "','" + txtCMRate.Text + "','" + numericUpDownBMQty.Value + "','" + numericUpDownBMHQty.Value + "','" + txtBMRate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','Odd','nomilk','" + txtFinalTotAmt.Text + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy}", d) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                                                objcls.execute(sql);
                                        }
                                        else if (ds.Tables[0].Rows[i].ItemArray[4].ToString() == "Cow Milk" && ds.Tables[0].Rows[i].ItemArray[5].ToString() != "Buffallo Milk")
                                        {
                                                sql = "INSinto DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, DeliveryType, MilkStatus, TotalAmt, Pin, DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','" + numericUpDownMilkType.Value + "','" + numericUpDownHMilktype.Value + "','" + txtMilktyperate.Text + "','0','0','" + txtMilktyperate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','Odd','nomilk','" + txtMilktypeTotAmt.Text + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy}", d) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                                                objcls.execute(sql);
                                        }
                                        else if (ds.Tables[0].Rows[i].ItemArray[5].ToString() == "Buffallo Milk" && ds.Tables[0].Rows[i].ItemArray[4].ToString() != "Cow Milk")
                                        {
                                                sql = "INSinto DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, DeliveryType, MilkStatus, TotalAmt, Pin, DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','0','0','" + txtMilktyperate.Text + "','" + numericUpDownMilkType.Value + "','" + numericUpDownHMilktype.Value + "','" + txtMilktyperate.Text + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','Odd','nomilk','" + txtMilktypeTotAmt.Text + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy}", d) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "','" + string.Format("{0:yyyy/MM/dd }", Today) + "')";
                                                objcls.execute(sql);
                                        }
                                    }
                                }
                            }
                        }
                        FMS.ClearPresentYearCalendar();
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
            }
            btnNoMilkSubmit.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            this.Close();
            btnCancel.Enabled = true;
        }
      
     
    }
}

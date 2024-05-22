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
    public partial class FrmMassage : Form
    {
        public FrmMassage()
        {
            InitializeComponent();
        }

        ClassConn objcls = new ClassConn();
        DataSet ds = new DataSet();
        string sql;
        int cnt;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            this.Close();
            btnCancel.Enabled = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
            GenerateBill();
            btnOk.Enabled = true;
        }

        //for GenerateBill
        public void GenerateBill()
        {
            btnOk.Enabled = false;

            double PRate = 0;
            double CMCQty = 0;
            double CMHCQty = 0;
            double CMCRate = 0;
            double BMCQty = 0;
            double BMHCQty = 0;
            double BMCRate = 0;
            double CMQty = 0;
            double CMHQty = 0;
            double BMQty = 0;
            double BMHQty = 0;
            double CMMilkRate = 0;
            double BMMilkRate = 0;
            double AllTotal = 0;
            double GrandTotal = 0;
            double CMBMCTot = 0;
            double Custday = 0;
            double TotalDaycal = 0;
            double MonthCMQuantity = 0;
            double MonthBMQuantity = 0;
            double CustOldBalance = 0;
            int CustCDay = 0;
            int CustMonth = 0;
            int CustYear = 0;
            string CurMon = "";

            //last Month
            DateTime month = Convert.ToDateTime(DateTime.Now.AddMonths(-1));
            int CMonth = month.Month;//month
            int Cyear = month.Year;//year
            var FristDate = new DateTime(month.Year, month.Month, 1);
            int CDay = FristDate.Day;//Day
            int days = (DateTime.DaysInMonth(Cyear, CMonth));//days in month
            DateTime Today = DateTime.Now;

            ////Present Month
            //DateTime Today = DateTime.Now;
            //int CMonth = Today.Month;//month
            //int Cyear = Today.Year;//year
            //var FristDate = new DateTime(Today.Year, Today.Month, 1);
            //int CDay = FristDate.Day;//Day
            //int days = (DateTime.DaysInMonth(Cyear, CMonth));//days in month

            if (CMonth == 1)
            {
                CurMon = "January";
            }
            else if (CMonth == 2)
            {
                CurMon = "February";
            }
            else if (CMonth == 3)
            {
                CurMon = "March";
            }
            else if (CMonth == 4)
            {
                CurMon = "April";
            }
            else if (CMonth == 5)
            {
                CurMon = "May";
            }
            else if (CMonth == 6)
            {
                CurMon = "June";
            }
            else if (CMonth == 7)
            {
                CurMon = "July";
            }
            else if (CMonth == 8)
            {
                CurMon = "August";
            }
            else if (CMonth == 9)
            {
                CurMon = "September";
            }
            else if (CMonth == 10)
            {
                CurMon = "October";
            }
            else if (CMonth == 11)
            {
                CurMon = "November";
            }
            else if (CMonth == 12)
            {
                CurMon = "December";
                Cyear--;//if we generate 12 month bill in 1 month(2023)
            }
            sql = "Select * from Bills where Cmonth ='" + CurMon + "' and Cyear='" + Cyear + "' and CompanyId ='" + ClassConn.Companyid + "'";
            cnt = objcls.executescal(sql);
            if (cnt != 0)
            {
                MessageBox.Show("Bill Already Generated...");
            }
            else
            {
                //get all Customer
               // sql = "Select * from CustomerProfiles where CustomerStatus ='Active' and CompanyId ='" + ClassConn.Companyid + "' and Cmonth<='" + CMonth + "' and Cyear<='" + Cyear + "'";
                sql = "Select * from CustomerProfiles where CustomerStatus ='Active' and CompanyId ='" + ClassConn.Companyid + "'";
                ds = objcls.fillDs(sql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    //get Qty
                    sql = "select CowMilkQty,CowHalfMilkQty,CowMilkRate,BuffalloMilkQty,BuffalloHalfMilkQty,BuffalloMilkRate from CustomerProfiles where Id='" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "' and CompanyId='" + ClassConn.Companyid + "' ";
                    DataSet ds1 = objcls.fillDs(sql);
                    for (int j = 0; j < ds1.Tables[0].Rows.Count; j++)
                    {
                        CMCQty = Convert.ToDouble(ds1.Tables[0].Rows[j].ItemArray[0].ToString());
                        CMHCQty = Convert.ToDouble(ds1.Tables[0].Rows[j].ItemArray[1].ToString());
                        CMCRate = Convert.ToDouble(ds1.Tables[0].Rows[j].ItemArray[2].ToString());
                        BMCQty = Convert.ToDouble(ds1.Tables[0].Rows[j].ItemArray[3].ToString());
                        BMHCQty = Convert.ToDouble(ds1.Tables[0].Rows[j].ItemArray[4].ToString());
                        BMCRate = Convert.ToDouble(ds1.Tables[0].Rows[j].ItemArray[5].ToString());
                        //total Cow milkrate
                        double CMCQRate = CMCQty * CMCRate;
                        double CMCHQRate = CMHCQty * CMCRate / 2;
                        double CMCMilkRate = CMCQRate + CMCHQRate;
                        //total Buffallo milkrate
                        double BMCQRate = BMCQty * BMCRate;
                        double BMCHQRate = BMHCQty * BMCRate / 2;
                        double BMCMilkRate = BMCQRate + BMCHQRate;
                        //total BMCM rate
                        CMBMCTot = CMCMilkRate + BMCMilkRate;
                    }
                    sql = "Select * from  ProductStatus where CustId='" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "'and Cmonth='" + CMonth + "' and Cyear='" + Cyear + "' and CompanyId='" + ClassConn.Companyid + "'";
                    int cnt = objcls.executescal(sql);
                    if (cnt != 0)
                    {
                        sql = "Select sum(ProductRate) from  ProductStatus where CustId='" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "'and Cmonth='" + CMonth + "' and Cyear='" + Cyear + "' and CompanyId='" + ClassConn.Companyid + "'";
                        int cntP = objcls.executescal(sql);
                        PRate = cntP;
                    }
                    else
                    {
                        PRate = 0;
                    }
                    //count total delivery days in month and year
                    sql = "Select COUNT(*) from DeliveryStatus where CustId='" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "'and Cmonth='" + CMonth + "' and Cyear='" + Cyear + "'and CompanyId='" + ClassConn.Companyid + "'";
                    cnt = objcls.executescal(sql);

                    DateTime CustDate = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[19].ToString());
                    CustCDay = CustDate.Day;//Day
                    CustMonth = CustDate.Month;
                    CustYear = CustDate.Year;
                    //Customer Datewise
                    if (CMonth == CustMonth && Cyear == CustYear)
                    {
                        var CusttotalDays = (CustDate.Date - FristDate.Date).TotalDays;
                        Custday = Convert.ToInt32(CusttotalDays);
                        double MianCustDay = days - Custday;
                        double CustDay = MianCustDay - cnt;
                        TotalDaycal = CustDay * CMBMCTot;
                        //for Customer CM Total Qty
                        double CMCQtyDay = CMCQty * CustDay;
                        double CMHCQtyDay = CMHCQty * CustDay;
                        MonthCMQuantity = CMCQtyDay + CMHCQtyDay / 2;
                        //for Customer BM Total Qty
                        double BMCQtyDay = BMCQty * CustDay;
                        double BMHCQtyDay = BMHCQty * CustDay;
                        MonthBMQuantity = BMCQtyDay + BMHCQtyDay / 2;
                    }
                    //FullMonth Datewise
                    else
                    {
                        double Totalday = days - cnt;
                        TotalDaycal = Totalday * CMBMCTot;
                        //for Delivery CM Total Qty
                        double CMCQtyDay = CMCQty * Totalday;
                        double CMHCQtyDay = CMHCQty * Totalday;
                        MonthCMQuantity = CMCQtyDay + CMHCQtyDay / 2;
                        //for Delivery BM Total Qty
                        double BMCQtyDay = BMCQty * Totalday;
                        double BMHCQtyDay = BMHCQty * Totalday;
                        MonthBMQuantity = BMCQtyDay + BMHCQtyDay / 2;
                    }
                    string sql6 = "select CowMilkRate from DeliveryStatus where CustId='" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "'and CompanyId='" + ClassConn.Companyid + "'and Cmonth='" + CMonth + "'and Cyear='" + Cyear + "'and CowMilkRate <> 0 GROUP BY CowMilkRate ";
                    int CMRate = objcls.executescal(sql6);

                    string sql7 = "select BuffalloMilkRate from DeliveryStatus where CustId='" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "'and CompanyId='" + ClassConn.Companyid + "'and Cmonth='" + CMonth + "'and Cyear='" + Cyear + "'and BuffalloMilkRate <> 0 GROUP BY BuffalloMilkRate ";
                    int BMRate = objcls.executescal(sql7);


                    string sql1 = "Select COUNT(*) from DeliveryStatus where CustId='" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "'and CompanyId='" + ClassConn.Companyid + "'and Cmonth='" + CMonth + "'and Cyear='" + Cyear + "' and MilkStatus='MinMaxMilk'";
                    int cnt1 = objcls.executescal(sql1);
                    if (cnt1 != 0)
                    {
                        string sql2 = "Select SUM(CowMilkQty) from DeliveryStatus where CustId='" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "'and CompanyId='" + ClassConn.Companyid + "'and Cmonth='" + CMonth + "'and Cyear='" + Cyear + "'and MilkStatus='MinMaxMilk'";
                        int cnt2 = objcls.executescal(sql2);
                        CMQty = cnt2;
                        string sql3 = "Select SUM(CowHalfMilkQty) from DeliveryStatus where CustId='" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "'and CompanyId='" + ClassConn.Companyid + "'and Cmonth='" + CMonth + "'and Cyear='" + Cyear + "'and MilkStatus='MinMaxMilk'";
                        int cnt3 = objcls.executescal(sql3);
                        CMHQty = cnt3;
                        string sql4 = "Select SUM(BuffalloMilkQty) from DeliveryStatus where CustId='" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "'and CompanyId='" + ClassConn.Companyid + "'and Cmonth='" + CMonth + "'and Cyear='" + Cyear + "'and MilkStatus='MinMaxMilk'";
                        int cnt4 = objcls.executescal(sql4);
                        BMQty = cnt4;
                        string sql5 = "Select SUM(BuffalloHalfMilkQty) from DeliveryStatus where CustId='" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "'and CompanyId='" + ClassConn.Companyid + "'and Cmonth='" + CMonth + "'and Cyear='" + Cyear + "'and MilkStatus='MinMaxMilk'";
                        int cnt5 = objcls.executescal(sql5);
                        BMHQty = cnt5;
                    }
                    else
                    {
                        CMQty = 0;
                        CMHQty = 0;
                        BMQty = 0;
                        BMHQty = 0;
                    }
                    //total Cow milkrate
                    double CMQRate = CMQty * CMRate;
                    double CMHQRate = CMHQty * CMRate / 2;
                    CMMilkRate = CMQRate + CMHQRate;
                    //All total CM Qty
                    double DeCMQuantity = CMQty + CMHQty / 2;
                    double Remark = MonthCMQuantity + DeCMQuantity;
                    //total Buffallo milkrate
                    double BMQRate = BMQty * BMRate;
                    double BMHQRate = BMHQty * BMRate / 2;
                    BMMilkRate = BMQRate + BMHQRate;
                    //All total BM Qty
                    double DeBMQuantity = BMQty + BMHQty / 2;
                    double UnitBuffallo = MonthBMQuantity + DeBMQuantity;

                    string sqlOld = "Select OldBalance from  CustomerProfiles where Id='" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "' and CompanyId='" + ClassConn.Companyid + "'";
                    DataSet dsOld = objcls.fillDs(sqlOld);
                    for (int k = 0; k < dsOld.Tables[0].Rows.Count; k++)
                    {
                        CustOldBalance = Convert.ToDouble(dsOld.Tables[0].Rows[k].ItemArray[0].ToString());
                    }
                    double CMBMTot = CMMilkRate + BMMilkRate;
                    double Finalcal = CMBMTot + TotalDaycal;
                    AllTotal = Convert.ToDouble(CustOldBalance) + Finalcal;
                    GrandTotal = AllTotal + PRate;

                    if (ds.Tables[0].Rows[i].ItemArray[4].ToString() == "")
                    {
                        sql = "INSERT into Bills( CustId,CustomerName,MobileNo,BuffaloMilk,CowMilkQty,CowMilkRate,BuffalloMilkQty,BuffalloMilkRate,AgentName,Remark,Cyear,Cmonth,CustomerStatus,UnitBuffallo,OldBalance,CDate,GrandTotal,Pin,Address,PaymentStatus,CowHalfMilkQty,BuffalloHalfMilkQty,CompanyId,Balance)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[5].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[6].ToString() + "','" + CMCRate + "','" + ds.Tables[0].Rows[i].ItemArray[8].ToString() + "','" + BMCRate + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','" + Remark + "' ,'" + Cyear + "','" + CurMon + "','" + ds.Tables[0].Rows[i].ItemArray[15].ToString() + "','" + UnitBuffallo + "','" + ds.Tables[0].Rows[i].ItemArray[18].ToString() + "','" + string.Format("{0:dd/MM/yyyy }", Today) + "','" + GrandTotal + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','0','" + ds.Tables[0].Rows[i].ItemArray[23].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[24].ToString() + "','" + ClassConn.Companyid + "','" + GrandTotal + "')";
                        objcls.execute(sql);
                    }
                    else if (ds.Tables[0].Rows[i].ItemArray[5].ToString() == "")
                    {
                        sql = "INSERT into Bills( CustId,CustomerName,MobileNo,CowMilk,CowMilkQty,CowMilkRate,BuffalloMilkQty,BuffalloMilkRate,AgentName,Remark,Cyear,Cmonth,CustomerStatus,UnitBuffallo,OldBalance,CDate,GrandTotal,Pin,Address,PaymentStatus,CowHalfMilkQty,BuffalloHalfMilkQty,CompanyId,Balance)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[4].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[6].ToString() + "','" + CMCRate + "','" + ds.Tables[0].Rows[i].ItemArray[8].ToString() + "','" + BMCRate + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','" + Remark + "' ,'" + Cyear + "','" + CurMon + "','" + ds.Tables[0].Rows[i].ItemArray[15].ToString() + "','" + UnitBuffallo + "','" + ds.Tables[0].Rows[i].ItemArray[18].ToString() + "','" + string.Format("{0:dd/MM/yyyy }", Today) + "','" + GrandTotal + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','0','" + ds.Tables[0].Rows[i].ItemArray[23].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[24].ToString() + "','" + ClassConn.Companyid + "','" + GrandTotal + "')";
                        objcls.execute(sql);
                    }
                    else
                    {
                        sql = "INSERT into Bills( CustId,CustomerName,MobileNo,CowMilk,BuffaloMilk,CowMilkQty,CowMilkRate,BuffalloMilkQty,BuffalloMilkRate,AgentName,Remark,Cyear,Cmonth,CustomerStatus,UnitBuffallo,OldBalance,CDate,GrandTotal,Pin,Address,PaymentStatus,CowHalfMilkQty,BuffalloHalfMilkQty,CompanyId,Balance)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[4].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[5].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[6].ToString() + "','" + CMCRate + "','" + ds.Tables[0].Rows[i].ItemArray[8].ToString() + "','" + BMCRate + "','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','" + Remark + "' ,'" + Cyear + "','" + CurMon + "','" + ds.Tables[0].Rows[i].ItemArray[15].ToString() + "','" + UnitBuffallo + "','" + ds.Tables[0].Rows[i].ItemArray[18].ToString() + "','" + string.Format("{0:dd/MM/yyyy }", Today) + "','" + GrandTotal + "','" + ds.Tables[0].Rows[i].ItemArray[20].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','0','" + ds.Tables[0].Rows[i].ItemArray[23].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[24].ToString() + "','" + ClassConn.Companyid + "','" + GrandTotal + "')";
                        objcls.execute(sql);
                    }
                }
                MessageBox.Show("Bill Generated Successfully");
            }
            btnOk.Enabled = true;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            this.Close();
            btnCancel.Enabled = true;
        }

    }
}

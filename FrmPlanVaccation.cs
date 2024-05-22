using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkDistributionApp
{
    public partial class FrmPlanVaccation : Form
    {
        int NowDay,NowMonth, NowYear;
        public static string static_day;
        public static int static_NowMonth, static_NowYear;

        FrmMilkStatus FMS;           
        public FrmPlanVaccation(FrmMilkStatus MS)
        {
            InitializeComponent();
            this.FMS = MS;
        }
        ClassConn objcls = new ClassConn();
        DataSet ds = new DataSet();
        string sql;
        DateTime CustDate;
        private bool btnfromdateWasClicked = false;
        private bool btnToDateWasClicked = false;

        private void FrmPlanVaccation_Load(object sender, EventArgs e)
        {
            btnfromdateWasClicked = false;
            btnToDateWasClicked = false;
            DateTime Nowtime = DateTime.Now;
            NowDay = Nowtime.Day;
            NowMonth = Nowtime.Month;
            NowYear = Nowtime.Year;
            displayPresentYearCalendar();
            pcloader.Visible = false;
        }

        private void btnfromDate_Click(object sender, EventArgs e)
        {
            btnfromDate.Enabled = false;

            btnToDateWasClicked = false;
            btnfromdateWasClicked = true;
            panelFront.SendToBack();
            panelFront.Visible = false;
            panelBack.Visible = true;

            btnfromDate.Enabled = true;
        }

        private void btnToDate_Click(object sender, EventArgs e)
        {
            btnToDate.Enabled = false;

            btnfromdateWasClicked = false;
            btnToDateWasClicked = true;
            panelFront.SendToBack();
            panelFront.Visible = false;
            panelBack.Visible = true;

            btnToDate.Enabled = true;
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
        private void btnOk_Click(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
            pcloader.Visible = true;
           // pcloader.Dock = DockStyle.Fill;
            try
            {
                if (lblFrom.Text == "" && lblTo.Text == "")
                {
                    MessageBox.Show("Please select date...");
                }
                else
                {
                    DateTime DTPFrom = Convert.ToDateTime(string.Format("{0:dd/MM/yyyy }", lblFrom.Text));
                    DateTime DTPTo = Convert.ToDateTime(string.Format("{0:dd/MM/yyyy }", lblTo.Text));

                    for (DateTime dtm = DTPFrom; dtm <= DTPTo; dtm = dtm.AddDays(1))
                    {
                        int CDay = Convert.ToInt32(dtm.Day.ToString());
                        string CMonth = dtm.Month.ToString();
                        string Cyear = dtm.Year.ToString();

                        sql = "DELETE FROM DeliveryStatus WHERE CDate='" + string.Format("{0:d/M/yyyy }", dtm) + "' and  CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "' ";
                        objcls.execute(sql);

                        sql = "Select * from CustomerProfiles where Id='" + ClassConn.CustID + "'";
                        ds = objcls.fillDs(sql);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            sql = "INSERT into DeliveryStatus(CustId, CustomerName, MobileNo, Address, CowMilkQty, CowHalfMilkQty, CowMilkRate, BuffalloMilkQty, BuffalloHalfMilkQty, BuffalloMilkRate, AgentName, AgentID, RouteID, MilkStatus, TotalAmt,DeliveryCharge,CompanyId, ProductNameId, ProductRate,CDate,Cday,Cmonth,Cyear,FromDate,ToDate)values('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "','" + ds.Tables[0].Rows[i].ItemArray[3].ToString() + "','0','0','0','0','0','0','" + ds.Tables[0].Rows[i].ItemArray[11].ToString() + "','0','0','nomilk','0','0','" + ClassConn.Companyid + "','0','0','" + string.Format("{0:d/M/yyyy }", dtm) + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + string.Format("{0:yyyy/MM/dd }", dtm) + "','" + string.Format("{0:yyyy/MM/dd }", DTPTo) + "')";
                            objcls.execute(sql);
                        }
                    }
                    FMS.ClearPresentYearCalendar();
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            catch { }
            btnOk.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            this.Close();
            btnCancel.Enabled = true;
        }

        public void SelectDate()
        {
            panelBack.SendToBack();
            panelFront.BringToFront();
            panelFront.Visible = true;
            CheckDate();
        }

        private void btnCanceldate_Click(object sender, EventArgs e)
        {
            btnCanceldate.Enabled = false;

            panelBack.SendToBack();
            panelFront.BringToFront();
            panelFront.Visible = true;

            btnCanceldate.Enabled = true;
        }
        public void CheckDate()
        {
            sql = "Select CDate from CustomerProfiles where Id='" + ClassConn.CustID + "'and CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                CustDate = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[0].ToString());
            }
            if (btnfromdateWasClicked == true)
            {
                DateTime Today = DateTime.Today;

                DateTime FromSelectDate = Convert.ToDateTime(UserControlPlanVacc.static_day + "/" + FrmMilkStatus.static_NowMonth + "/" + FrmMilkStatus.static_NowYear);

                if (FromSelectDate >= CustDate)
                {
                    if (FromSelectDate >= Today)
                    {
                        lblFrom.Text = Convert.ToString(string.Format("{0:dd/MM/yyyy}",FromSelectDate));
                    }
                    else
                    {
                        MessageBox.Show("Can't Change Previous or Current Day Data");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Date are not Available...");
                }
            }
            else if (btnToDateWasClicked == true)
            {
                DateTime Today = DateTime.Now;
                DateTime ToSelectDate = Convert.ToDateTime(UserControlPlanVacc.static_day + "/" + FrmMilkStatus.static_NowMonth + "/" + FrmMilkStatus.static_NowYear);

                if (ToSelectDate >= CustDate)
                {
                    if (ToSelectDate >= Today)
                    {
                        lblTo.Text = Convert.ToString(string.Format("{0:dd/MM/yyyy}", ToSelectDate));
                    }
                    else
                    {
                        MessageBox.Show("Can't Change Previous or Current Day Data");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Date are not Available...");
                }
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            CheckDate();
        }

        private void pcloader_Click(object sender, EventArgs e)
        {

        }

        public void displayPresentYearCalendar()
        {
            string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(NowMonth);
            lblDate.Text = MonthName + "" + NowYear;

            static_NowMonth = NowMonth;
            static_NowYear = NowYear;


            DateTime StartOfTheMonth = new DateTime(NowYear, NowMonth, 1);
            int Days = DateTime.DaysInMonth(NowYear, NowMonth);
            int DayInWeek = Convert.ToInt32(StartOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < DayInWeek; i++)
            {
                UserControlBlank UCBlank = new UserControlBlank();
                daycontainer.Controls.Add(UCBlank);
            }

            for (int i = 1; i <= Days; i++)
            {
                UserControlPlanVacc UCDays = new UserControlPlanVacc(this);
                UCDays.Days(i);
                daycontainer.Controls.Add(UCDays);
            }
        }

        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            btnPreviousMonth.Enabled = false;
            NowMonth--;
            if (NowMonth >= 1)
            {
                daycontainer.Controls.Clear();
                displayPresentYearCalendar();
            }
            else
            {
                NowMonth = 13;
                NowYear--;
            }
            btnPreviousMonth.Enabled = true;
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            btnNextMonth.Enabled = false;
            NowMonth++;
            if (NowMonth <= 12)
            {
                daycontainer.Controls.Clear();
                displayPresentYearCalendar();
            }
            else
            {
                NowMonth = 0;
                NowYear++;
            }
            btnNextMonth.Enabled = true;
        }
    }
}
    


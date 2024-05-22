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
    public partial class FrmMilkStatus : Form
    {
        int NowMonth,NowYear;
        public static string static_day;
        public static int static_NowMonth,static_NowYear;

        public FrmMilkStatus()
        {
            InitializeComponent();
        }

        ClassConn objcls = new ClassConn();
        DataSet ds = new DataSet();
        string sql;
        int cnt;
        string DelTime;
        DateTime CustDate;
        private bool btnEvenOddWasClicked = false;
        private bool btnPlanVaccationWasClicked = false;
        private object e;

        private void FrmMilkStatus_Load(object sender, EventArgs e)
        {
            DateTime Nowtime = DateTime.Now;
            NowMonth = Nowtime.Month;
            NowYear = Nowtime.Year;
            displayPresentYearCalendar();
            ClassConn.DateEvenOdd = Convert.ToDateTime(static_NowMonth + "/" + static_NowYear);
            Calendar();
            DateTime date = DateTime.Today;
        }

        public void Calendar()
        {
            sql = "select CDate from DeliveryStatus where Cmonth='" + NowMonth + "' and CustId = '" + ClassConn.CustID + "' and CompanyId = '" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DateTime CustCalenDate = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                var CustCalDate = CustCalenDate;
                var CustCalDay = CustCalenDate.Day.ToString();
                var lastDayOfMonth = CustCalenDate.AddMonths(1).AddDays(-1);
                var CustlastCalDay = lastDayOfMonth.Day.ToString();
            }
        }

        public void Filldt()
        {
            sql = "Select MilkStatus,CDate,CowMilkQty,CowHalfMilkQty,BuffalloMilkQty,BuffalloHalfMilkQty from DeliveryStatus where Cmonth='" + NowMonth + "'and Cyear='" + NowYear + "' and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            dgvMilkStatus.DataSource = ds.Tables[0];

            dgvMilkStatus.Columns[0].Width = 130;
            dgvMilkStatus.Columns[1].Width = 130;
            dgvMilkStatus.Columns[2].Width = 130;
            dgvMilkStatus.Columns[3].Width = 140;
            dgvMilkStatus.Columns[4].Width = 140;
            dgvMilkStatus.Columns[5].Width = 160;

            if (dgvMilkStatus.Rows.Count == 0)
            {

            }
            else
            {
                for (int i = 2; i < dgvMilkStatus.Columns.Count; i++)
                {

                    int total = 0;
                    for (int j = 0; j < dgvMilkStatus.Rows.Count - 1; j++)
                    {

                        total += Convert.ToInt32(dgvMilkStatus.Rows[j].Cells[i].Value);
                    }
                    dgvMilkStatus.Rows[dgvMilkStatus.Rows.Count - 1].Cells[0].Value = "GrandTotal";
                    dgvMilkStatus.Rows[dgvMilkStatus.Rows.Count - 1].Cells[1].Value = "";
                    dgvMilkStatus.Rows[dgvMilkStatus.Rows.Count - 1].Cells[i].Value = total;
                }
            }
        }

        private void btnPlanVaccation_Click(object sender, EventArgs e)
        {
            btnPlanVaccation.Enabled = false;
            FrmPlanVaccation frmMAP = new FrmPlanVaccation(this);
            frmMAP.Show();
            btnPlanVaccation.Enabled = true;
        }

        private void btnEvenOdd_Click(object sender, EventArgs e)
        {
            btnEvenOdd.Enabled = false;
            FrmEvenOddChanges FEOC = new FrmEvenOddChanges(this);
            FEOC.Show();
            btnEvenOdd.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnClose.Enabled = false;
            this.Close();
            btnClose.Enabled = true;
        }

        public void CallMilkAddProductFrm()
        {
            sql = "Select CDate from CustomerProfiles where Id='" + ClassConn.CustID + "'and CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                CustDate = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[0].ToString());
            }
            ClassConn.DateEvenOdd = Convert.ToDateTime(UserControlDays.static_day + "/" + static_NowMonth + "/" + static_NowYear);
            string AMonth = ClassConn.DateEvenOdd.Month.ToString();
            DateTime Today = DateTime.Now;
            string BMonth = Today.Month.ToString();
            if (ClassConn.DateEvenOdd >= CustDate)
            {
                if (AMonth == BMonth)
                {
                    if (Convert.ToDateTime(ClassConn.DateEvenOdd) >= Today)
                    {
                        FrmMilkAddProduct frmMAP = new FrmMilkAddProduct(this);
                        frmMAP.Show();
                    }
                    else
                    {
                        MessageBox.Show("Can't Change Previous or Current Day Data");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Days are Not Available... ");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Days are Not Available... ");
                return;
            }
        }
        public void ClearPresentYearCalendar()
        {
            daycontainer.Controls.Clear();
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
            for (int j = 1; j <= Days; j++)
            {
                UserControlDays UCDays = new UserControlDays(this);
                UCDays.Days(j);

                sql = "Select CDate from CustomerProfiles where Id='" + ClassConn.CustID + "'and CompanyId='" + ClassConn.Companyid + "'";
                ds = objcls.fillDs(sql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    CustDate = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                }
                int CustD = CustDate.Day;
                int CustM = CustDate.Month;
                int CustY = CustDate.Year;
                if(NowYear > CustY)
                {
                    UCDays.BackColor = Color.LimeGreen;
                }
                if(NowMonth >= CustM && NowYear>=CustY)
                {
                    UCDays.BackColor = Color.LimeGreen;
                    if (CustD <= j && CustM == NowMonth && CustY == NowYear)
                {
                    UCDays.BackColor = Color.LimeGreen;
                    sql = "Select DeliveryType,Cday,Cmonth,Cyear,MilkStatus,CDate from DeliveryStatus where Cmonth='" + NowMonth + "'and Cyear='" + NowYear + "' and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
                    DataSet ds1 = objcls.fillDs(sql);
                        if (ds1.Tables[0].Rows.Count != 0)
                        {
                            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                            {
                                int Cday = Convert.ToInt32(ds1.Tables[0].Rows[i].ItemArray[1].ToString());

                                //Even(MinMaxMilk)
                                if (ds1.Tables[0].Rows[i].ItemArray[0].ToString() == "Even" && ds1.Tables[0].Rows[i].ItemArray[4].ToString() == "MinMaxMilk")
                                {
                                        if (Cday == j)
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                            UCDays.BackColor = Color.DeepSkyBlue;
                                        }
                                        else
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                        }
                                }
                                //Even(nomilk)
                                else if (ds1.Tables[0].Rows[i].ItemArray[0].ToString() == "Even" && ds1.Tables[0].Rows[i].ItemArray[4].ToString() == "nomilk")
                                {
                                    if (Cday == j)
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                        UCDays.BackColor = Color.Red;
                                    }
                                    else
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                    }

                                }
                                //Odd(MinMaxMilk)
                                else if (ds1.Tables[0].Rows[i].ItemArray[0].ToString() == "Odd" && ds1.Tables[0].Rows[i].ItemArray[4].ToString() == "MinMaxMilk")
                                {
                                        if (Cday == j)
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                            UCDays.BackColor = Color.DeepSkyBlue;
                                        }
                                        else
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                        }
                                }
                                //Odd(nomilk)
                                else if (ds1.Tables[0].Rows[i].ItemArray[0].ToString() == "Odd" && ds1.Tables[0].Rows[i].ItemArray[4].ToString() == "nomilk")
                                {
                                    if (Cday == j)
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                        UCDays.BackColor = Color.Red;
                                    }
                                    else
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                    }

                                }
                                //PlanVaccation
                                else if (ds1.Tables[0].Rows[i].ItemArray[0].ToString() != "Even" && ds1.Tables[0].Rows[i].ItemArray[0].ToString() != "Odd" && ds1.Tables[0].Rows[i].ItemArray[4].ToString() == "nomilk")
                                {


                                    if (Cday == j)
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                        UCDays.BackColor = Color.Red;
                                    }
                                    else
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                    }
                                }
                                //AddProduct
                                else if (ds1.Tables[0].Rows[i].ItemArray[0].ToString() != "Even" && ds1.Tables[0].Rows[i].ItemArray[0].ToString() != "Odd" && ds1.Tables[0].Rows[i].ItemArray[4].ToString() == "MinMaxMilk")
                                {
                                    sql = "Select * from ProductStatus where Cday='" + Cday + "'and Cmonth='" + NowMonth + "'and Cyear='" + NowYear + "' and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
                                    cnt = objcls.executescal(sql);
                                    if (cnt != 0)
                                    {
                                        if (Cday == j)
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                            UCDays.BackColor = Color.LightGray;
                                        }
                                        else
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                        }
                                    }
                                    else
                                    {
                                        if (Cday == j)
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                            UCDays.BackColor = Color.DeepSkyBlue;
                                        }
                                        else
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                        }
                                    }


                                }
                                else if (ds1.Tables[0].Rows[i].ItemArray[0].ToString() != "Even" && ds1.Tables[0].Rows[i].ItemArray[0].ToString() != "Odd" && ds1.Tables[0].Rows[i].ItemArray[4].ToString() == "nomilk")
                                {
                                    sql = "Select * from ProductStatus where Cday='" + Cday + "'and Cmonth='" + NowMonth + "'and Cyear='" + NowYear + "' and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
                                    cnt = objcls.executescal(sql);
                                    if (cnt != 0)
                                    {
                                        if (Cday == j)
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                            UCDays.BackColor = Color.LightGray;
                                        }
                                        else
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                        }
                                    }
                                    else
                                    if (Cday == j)
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                        UCDays.BackColor = Color.Red;
                                    }
                                    else
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                    }
                                }
                                else 
                                {
                                    sql = "Select * from ProductStatus where Cday='" + Cday + "'and Cmonth='" + NowMonth + "'and Cyear='" + NowYear + "' and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
                                    cnt = objcls.executescal(sql);
                                    if (cnt != 0)
                                    {
                                        if (Cday == j)
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                            UCDays.BackColor = Color.LightGray;
                                        }
                                        else
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            daycontainer.Controls.Add(UCDays);

                        }
                }
                else
                {
                        if(CustM == NowMonth && CustY == NowYear)
                        {
                            UCDays.BackColor = Color.WhiteSmoke;
                        }
                    sql = "Select DeliveryType,Cday,Cmonth,Cyear,MilkStatus,CDate from DeliveryStatus where Cmonth='" + NowMonth + "'and Cyear='" + NowYear + "' and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
                        //SqlCommand cmd = new SqlCommand("SELECT * FROM [tbl_NewsUpdate] ORDER BY CONVERT (Datetime, NewsDate,103) ASC")
                    DataSet ds1 = objcls.fillDs(sql);
                    if (ds1.Tables[0].Rows.Count != 0)
                    {
                        for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                        {
                            int Cday = Convert.ToInt32(ds1.Tables[0].Rows[i].ItemArray[1].ToString());

                                //Even(MinMaxMilk)
                                if (ds1.Tables[0].Rows[i].ItemArray[0].ToString() == "Even" && ds1.Tables[0].Rows[i].ItemArray[4].ToString() == "MinMaxMilk")
                            {
                                    if (Cday == j)
                                {
                                    daycontainer.Controls.Add(UCDays);
                                    UCDays.BackColor = Color.DeepSkyBlue;
                                }
                                else
                                {
                                    daycontainer.Controls.Add(UCDays);
                                }
                                    }
                            //Even(nomilk)
                          else  if (ds1.Tables[0].Rows[i].ItemArray[0].ToString() == "Even" && ds1.Tables[0].Rows[i].ItemArray[4].ToString() == "nomilk")
                            {
                                        if (Cday == j)
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                            UCDays.BackColor = Color.Red;
                                        }
                                        else
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                        }
                            }
                            //Odd(MinMaxMilk)
                           else if (ds1.Tables[0].Rows[i].ItemArray[0].ToString() == "Odd" && ds1.Tables[0].Rows[i].ItemArray[4].ToString() == "MinMaxMilk")
                            {
                                        if (Cday == j)
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                            UCDays.BackColor = Color.DeepSkyBlue;
                                        }
                                        else
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                        }
                            }
                            //Odd(nomilk)
                           else if (ds1.Tables[0].Rows[i].ItemArray[0].ToString() == "Odd" && ds1.Tables[0].Rows[i].ItemArray[4].ToString() == "nomilk")
                            {
                                        if (Cday == j)
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                            UCDays.BackColor = Color.Red;
                                        }
                                        else
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                        }
                            }
                            //PlanVaccation
                           else if (ds1.Tables[0].Rows[i].ItemArray[0].ToString() != "Even" && ds1.Tables[0].Rows[i].ItemArray[0].ToString() != "Odd" && ds1.Tables[0].Rows[i].ItemArray[4].ToString() == "nomilk")
                            {
                                   
                                        if (Cday == j)
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                            UCDays.BackColor = Color.Red;
                                        }
                                        else
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                        }
                                    
                            }
                            //AddProduct
                           else if (ds1.Tables[0].Rows[i].ItemArray[0].ToString() != "Even" && ds1.Tables[0].Rows[i].ItemArray[0].ToString() != "Odd" && ds1.Tables[0].Rows[i].ItemArray[4].ToString() == "MinMaxMilk")
                            {
                                    sql = "Select * from ProductStatus where Cday='" + Cday + "'and Cmonth='" + NowMonth + "'and Cyear='" + NowYear + "' and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
                                    cnt = objcls.executescal(sql);
                                    if (cnt != 0)
                                    {
                                        if (Cday == j)
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                            UCDays.BackColor = Color.LightGray;
                                        }
                                        else
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                        }
                                    }
                                    else
                                    {
                                        if (Cday == j)
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                            UCDays.BackColor = Color.DeepSkyBlue;
                                        }
                                        else
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                        }
                                    }
                            }
                           else if (ds1.Tables[0].Rows[i].ItemArray[0].ToString() != "Even" && ds1.Tables[0].Rows[i].ItemArray[0].ToString() != "Odd" && ds1.Tables[0].Rows[i].ItemArray[4].ToString() == "nomilk")
                            {
                                    sql = "Select * from ProductStatus where Cday='" + Cday + "'and Cmonth='" + NowMonth + "'and Cyear='" + NowYear + "' and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
                                    cnt = objcls.executescal(sql);
                                    if (cnt != 0)
                                    {
                                        if (Cday == j)
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                            UCDays.BackColor = Color.LightGray;
                                        }
                                        else
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                        }
                                    }
                                   else if (Cday == j)
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                            UCDays.BackColor = Color.Red;
                                        }
                                        else
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                        }
                            }
                                else
                                {
                                    sql = "Select * from ProductStatus where Cday='" + Cday + "'and Cmonth='" + NowMonth + "'and Cyear='" + NowYear + "' and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
                                    cnt = objcls.executescal(sql);
                                    if (cnt != 0)
                                    {
                                        if (Cday == j)
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                            UCDays.BackColor = Color.LightGray;
                                        }
                                        else
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                        }
                                    }
                                }
                            }
                    }
                    else
                    {
                        daycontainer.Controls.Add(UCDays);

                    }
                }
                    sql = "Select * from ProductStatus where Cday='" + j + "'and Cmonth='" + NowMonth + "'and Cyear='" + NowYear + "' and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
                    cnt = objcls.executescal(sql);
                    if (cnt != 0)
                    {
                            daycontainer.Controls.Add(UCDays);
                            UCDays.BackColor = Color.LightGray;
                        }
                        else
                        {
                            daycontainer.Controls.Add(UCDays);
                        }
                }
                else
                {
                    sql = "Select DeliveryType,Cday,Cmonth,Cyear,MilkStatus,CDate from DeliveryStatus where Cmonth='" + NowMonth + "' and Cyear='" + NowYear + "' and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "' order by CDate asc ";
                    DataSet ds1 = objcls.fillDs(sql);
                    if (ds1.Tables[0].Rows.Count != 0)
                    {
                        for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                        {
                            int Cday = Convert.ToInt32(ds1.Tables[0].Rows[i].ItemArray[1].ToString());
                            //Even(MinMaxMilk)
                            if (ds1.Tables[0].Rows[i].ItemArray[0].ToString() == "Even" && ds1.Tables[0].Rows[i].ItemArray[4].ToString() == "MinMaxMilk")
                            {
                                    if (Cday == j)
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                        UCDays.BackColor = Color.DeepSkyBlue;
                                    }
                                    else
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                    }
                            }
                            //Even(nomilk)
                          else if (ds1.Tables[0].Rows[i].ItemArray[0].ToString() == "Even" && ds1.Tables[0].Rows[i].ItemArray[4].ToString() == "nomilk")
                            {
                                
                                    if (Cday == j)
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                        UCDays.BackColor = Color.Red;
                                    }
                                    else
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                    }
                                
                            }
                            //Odd(MinMaxMilk)
                           else if (ds1.Tables[0].Rows[i].ItemArray[0].ToString() == "Odd" && ds1.Tables[0].Rows[i].ItemArray[4].ToString() == "MinMaxMilk")
                            {
                                    if (Cday == j)
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                        UCDays.BackColor = Color.DeepSkyBlue;
                                    }
                                    else
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                    }
                            }
                            //Odd(nomilk)
                           else if (ds1.Tables[0].Rows[i].ItemArray[0].ToString() == "Odd" && ds1.Tables[0].Rows[i].ItemArray[4].ToString() == "nomilk")
                            {
                               
                                    if (Cday == j)
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                        UCDays.BackColor = Color.Red;
                                    }
                                    else
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                    }
                                
                            }
                            //PlanVaccation
                           else if (ds1.Tables[0].Rows[i].ItemArray[0].ToString() != "Even" && ds1.Tables[0].Rows[i].ItemArray[0].ToString() != "Odd" && ds1.Tables[0].Rows[i].ItemArray[4].ToString() == "nomilk")
                            {
                                    if (Cday == j)
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                        UCDays.BackColor = Color.Red;
                                    }
                                    else
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                    }
                            }
                            //AddProduct
                           else if (ds1.Tables[0].Rows[i].ItemArray[0].ToString() != "Even" && ds1.Tables[0].Rows[i].ItemArray[0].ToString() != "Odd" && ds1.Tables[0].Rows[i].ItemArray[4].ToString() == "MinMaxMilk")
                            {
                                sql = "Select * from ProductStatus where Cday='" + Cday + "'and Cmonth='" + NowMonth + "'and Cyear='" + NowYear + "' and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
                                cnt = objcls.executescal(sql);
                                if (cnt != 0)
                                {
                                    if (Cday == j)
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                        UCDays.BackColor = Color.LightGray;
                                    }
                                    else
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                    }
                                }
                                else
                                {
                                    if (Cday == j)
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                        UCDays.BackColor = Color.DeepSkyBlue;
                                    }
                                    else
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                    }
                                }
                            }
                           else if (ds1.Tables[0].Rows[i].ItemArray[0].ToString() != "Even" && ds1.Tables[0].Rows[i].ItemArray[0].ToString() != "Odd" && ds1.Tables[0].Rows[i].ItemArray[4].ToString() == "nomilk")
                            {
                                sql = "Select * from ProductStatus where Cday='" + Cday + "'and Cmonth='" + NowMonth + "'and Cyear='" + NowYear + "' and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
                                cnt = objcls.executescal(sql);
                                if (cnt != 0)
                                {
                                    if (Cday == j)
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                        UCDays.BackColor = Color.LightGray;
                                    }
                                    else
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                    }
                                }
                              else  if (Cday == j)
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                        UCDays.BackColor = Color.Red;
                                    }
                                    else
                                    {
                                        daycontainer.Controls.Add(UCDays);
                                    }
                                
                            }
                             else 
                                {
                                    sql = "Select * from ProductStatus where Cday='" + Cday + "'and Cmonth='" + NowMonth + "'and Cyear='" + NowYear + "' and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
                                    cnt = objcls.executescal(sql);
                                    if (cnt != 0)
                                    {
                                        if (Cday == j)
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                            UCDays.BackColor = Color.LightGray;
                                        }
                                        else
                                        {
                                            daycontainer.Controls.Add(UCDays);
                                        }
                                    }
                                }
                        }
                    }
                    else
                    {
                        daycontainer.Controls.Add(UCDays);

                    }
                }
                sql = "Select * from ProductStatus where Cday='" + j + "'and Cmonth='" + NowMonth + "'and Cyear='" + NowYear + "' and CustId='" + ClassConn.CustID + "' and CompanyId='" + ClassConn.Companyid + "'";
                cnt = objcls.executescal(sql);
                if (cnt != 0)
                {
                    daycontainer.Controls.Add(UCDays);
                    UCDays.BackColor = Color.LightGray;
                }
                else
                {
                    daycontainer.Controls.Add(UCDays);
                }
            
        }
            Filldt();
        }

        private void daycontainer_Paint(object sender, PaintEventArgs e)
        {

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

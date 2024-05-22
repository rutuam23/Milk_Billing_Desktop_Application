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
using System.Threading;


namespace MilkDistributionApp
{
    public partial class Form1 : Form
    {
        int NowMonth, NowYear,NextYear;
        public bool isloginSuccess = false;
        public Form1()
        {
            InitializeComponent();
            //DateTime StartDate = new DateTime(2022, 07, 21);
            //DateTime EndDate = new DateTime(2022, 07, 21);
            //monthCalendar1.SelectionRange = new SelectionRange(StartDate, EndDate);
        }

        ClassConn objcls = new ClassConn();
        DataSet ds = new DataSet();
        string CompanyIdL;
        string sql;
        int cnt;
       

        public void Filldt()
        {
            sql = "select * from RouteMasters ";
            ds = objcls.fillDs(sql);
            dgvCheckBox.DataSource = ds.Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pcloader.Visible = false;
            DateTime Nowtime = DateTime.Now;
            NowMonth = Nowtime.Month;
            NowYear = Nowtime.Year;
          
            Filldt();
            displayPresentYearCalendar();
           //displayNextYearCalendar();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //bool isCellChecked = Convert.ToBoolean(dgvCheckBox.SelectedCells[0].Value.ToString());
            //if (isCellChecked == true)
            //{
            //    dgvCheckBox.Rows.RemoveAt(dgvCheckBox.CurrentRow.Index);
            //}
            btnDelete.Enabled = false;
            pcloader.Visible = true;
            pcloader.Dock = DockStyle.Fill;
            backgroundWorker1.RunWorkerAsync();
            btnDelete.Enabled = true;
        }

        //__________Month Calendar Control__________

        public void displayPresentYearCalendar()
        {
            //string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(NowMonth);
            //lblDate.Text = MonthName + "" + NowYear;

            //DateTime StartOfTheMonth = new DateTime(NowYear, NowMonth, 1);
            //int Days = DateTime.DaysInMonth(NowYear, NowMonth);
            //int DayInWeek = Convert.ToInt32(StartOfTheMonth.DayOfWeek.ToString("d"))+1;

            //for(int i=1;i< DayInWeek;i++)
            //{
            //    UserControlBlank UCBlank = new UserControlBlank();
            //    daycontainer.Controls.Add(UCBlank);
            //}

            //for(int i=1;i<=Days;i++)
            //{
            //    UserControlDays UCDays = new UserControlDays();
            //    UCDays.Days(i);
            //    daycontainer.Controls.Add(UCDays);              
            //}
        }

        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            btnPreviousMonth.Enabled = false;
            daycontainer.Controls.Clear();
            NowMonth--;
            NextYear--;
            displayPresentYearCalendar();
            btnPreviousMonth.Enabled = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //if (LoginUserNameTB.Text == "admin" && LoginPasswordTB.Text == "admin")
            //{
            //    Thread.Sleep(1000);
            //    isloginSuccess = true;
            //}
            //else
            //{
            //    isloginSuccess = false;
            //}
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
            if (isloginSuccess)
            {
                MessageBox.Show("Login Succesfuly");
                this.Close();
            }
            else
            {
                MessageBox.Show("Check uname & Password");
                pcloader.Visible = false;
            }
            
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            
            daycontainer.Controls.Clear();
            NowMonth++;
            NextYear++;
            displayPresentYearCalendar();
        }

        public void displayNextYearCalendar()
        {
            //string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(NowMonth);
            //lblDate.Text = MonthName + "" + NextYear;

            //DateTime StartOfTheMonth = new DateTime(NextYear, NowMonth, 1);
            //int Days = DateTime.DaysInMonth(NextYear, NowMonth);
            //int DayInWeek = Convert.ToInt32(StartOfTheMonth.DayOfWeek.ToString("d")) + 1;

            //for (int i = 1; i < DayInWeek; i++)
            //{
            //    UserControlBlank UCBlank = new UserControlBlank();
            //    daycontainer.Controls.Add(UCBlank);
            //}

            //for (int i = 1; i <= Days; i++)
            //{
            //    UserControlDays UCDays = new UserControlDays(this);
            //    UCDays.Days(i);
            //    daycontainer.Controls.Add(UCDays);
            //}
        }
    }
}

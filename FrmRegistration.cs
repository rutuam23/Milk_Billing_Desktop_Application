using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkDistributionApp
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }
        ClassConn objcls = new ClassConn();
        DataSet ds = new DataSet();
        string sql;
        private Regex expr;

        public static string RandomAlphanumeric(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            txtCompanyId.Text = RandomAlphanumeric(5);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            btnRegister.Enabled = false;

            Regex pattern = new Regex("^[6-9][0-9]{9}$");
            if (pattern.IsMatch(txtMobileNo.Text))
            {
            }
            else
            {
                MessageBox.Show("Invalid phone number");
            }

            if (txtCompanyName.Text=="")
            {
                MessageBox.Show("Enter Company Name");
            }
            else if(txtMobileNo.Text=="")
            {
                MessageBox.Show("Enter Mobile No.");
            }
            else if(txtAddress.Text=="")
            {
                MessageBox.Show("Enter Address");
            }
            else if (txtEmailID.Text == "")
            {
                MessageBox.Show("Enter EmailID");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Enter Password");
            }
            else if (txtCity.Text == "")
            {
                MessageBox.Show("Enter City");
            }
            else if (txtCompanySName.Text == "")
            {
                MessageBox.Show("Enter Company Short Name");
            }

            DateTime Today = DateTime.Now;
           // string Date = DateTime.Now.ToString("dd-MM-yyyy");
            string CDate = string.Format("{0:MM/dd/yyyy }", Today);
            string Time = DateTime.Now.ToLongTimeString();
            int year = Today.Year;

            var AddMonth= Today.AddMonths(6).AddDays(1);
            string DTPDate = string.Format("{0:MM/dd/yyyy }", AddMonth);



            // var AddMonthdays = Today.AddDays(180);

            var FinancialStartDt = "01" + "-" + "04" + "-" + year;
            var FinancialEndDt = "31" + "-" + "03" + "-" + (year + 1);
            var FinancialYear = (year + "-" + (year + 1));


            string companyID = txtCompanyName.Text.Substring(0, 4) + txtCompanyId.Text.Trim();

            sql = "Insert into CompanyRegistrations(CompanyId,CompanyName,Address,CMobileno,CEmail,CompamyPassword,City,CompamyShortName,FinancialYear,FinancialStartDt,FinancialEndDt,Cdate,Ctime,IsCancled,SubscriptionStatus,SubscriptionEndDate)values('" + companyID.Trim() + "','" +txtCompanyName.Text.Trim() + "','"+txtAddress.Text.Trim() + "','"+txtMobileNo.Text.Trim() + "','"+txtEmailID.Text.Trim() + "','"+txtPassword.Text.Trim() + "','"+txtCity.Text.Trim() + "','"+txtCompanySName.Text.Trim() + "','"+ FinancialYear.Trim() + "','"+ FinancialStartDt.Trim() + "','"+ FinancialEndDt.Trim() + "','"+ CDate + "','"+Time.Trim() + "','0','Free','"+ DTPDate + "')";
            objcls.execute(sql);
            MessageBox.Show("Registered Successfully..");
            this.Hide();
            btnRegister.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = false;

            txtCompanyId.Text = RandomAlphanumeric(5);
            txtCompanyName.ResetText();
            txtMobileNo.ResetText();
            txtAddress.ResetText();
            txtEmailID.ResetText();
            txtPassword.ResetText();
            txtCity.ResetText();
            txtCompanySName.ResetText();

            btnNew.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnClose.Enabled = false;
            this.Close();
            btnClose.Enabled = true;
        }

        private void txtCompanyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMobileNo.Focus();
            }
        }

        private void txtMobileNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAddress.Focus();
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmailID.Focus();
            }
        }

        private void txtEmailID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCity.Focus();
            }
        }

        private void txtCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCompanySName.Focus();
            }
        }

        private void txtCompanySName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegister.Focus();
            }
        }
        public void PhoneNoValidation()
        {
            Regex pattern = new Regex("^[6-9][0-9]{9}${10}");
            if (pattern.IsMatch(txtMobileNo.Text))
            {
            }
            else
            {
                MessageBox.Show("Invalid phone number");
                txtMobileNo.Focus();
            }
        }
        private void txtMobileNo_Leave(object sender, EventArgs e)
        {
            PhoneNoValidation();
        }

        private void FrmRegistration_Shown(object sender, EventArgs e)
        {
            txtCompanyName.Focus();
        }
    }
  }
    
   


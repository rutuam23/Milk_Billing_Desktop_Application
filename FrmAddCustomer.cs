using Microsoft.Reporting.WinForms;
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
    public partial class FrmAddCustomer : Form
    {
        public FrmAddCustomer()
        {
            InitializeComponent();
        }
        ClassConn objcls = new ClassConn();
        DataSet ds = new DataSet();
        string sql;
        int cnt;
        string DelTime;
        //public ArrayList();
        //public static ArrayList DetForm = new ArrayList();
      

        private void FrmAddCustomer_Load(object sender, EventArgs e)
        {
            txtPin.Text = GenerateNewRandom();
            FillRouteName();
            Filldt();
            CMRate();
            BMRate();
            btnUpdate.Enabled = false;
            lblUpdate.Enabled = false;
            txtAgentName.ResetText();
            dgvCustomer.Columns[0].Visible = false;
            txtCustName.TabIndex = 0;
           
        }
          
        public static string GenerateNewRandom()
        {
            Random generator = new Random();
            String r = generator.Next(0, 1000000).ToString("D6");
            if (r.Distinct().Count() == 1)
            {
                r = GenerateNewRandom();
            }
            return r;
        }

        public void Filldt()
        {
            sql = "Select Id,CustomerName,MobileNo,Address,CowMilk,BuffaloMilk,CowMilkQty,CowHalfMilkQty,CowMilkRate,BuffalloMilkQty,BuffalloHalfMilkQty,BuffalloMilkRate,DeliveryTime,AgentName,CustomerStatus,CDate,Pin,CowMilkTotAmt,BuffalloMilkTotAmt,RouteName,OldBalance,Remark from CustomerProfiles where CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            dgvCustomer.DataSource = ds.Tables[0];
            dgvCustomer.Columns[1].Width = 160;
            dgvCustomer.Columns[3].Width = 130;
            dgvCustomer.Columns[6].Width = 100;
            dgvCustomer.Columns[7].Width = 130;
            dgvCustomer.Columns[9].Width = 120;
            dgvCustomer.Columns[10].Width = 150;
            dgvCustomer.Columns[11].Width = 130;
            dgvCustomer.Columns[13].Width = 120;
            dgvCustomer.Columns[14].Width = 120;
            dgvCustomer.Columns[17].Width = 120;
            dgvCustomer.Columns[18].Width = 150;

        }

        public void FillRouteName()
        {
            sql = "Select RouteName,Id from RouteMasters where CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            cmbRoute.DataSource = ds.Tables[0];
            cmbRoute.Text = "Select Route";
            cmbRoute.TabIndex = 0;
            cmbRoute.Focus();
        }

        public void FillAgentId()
        {
            sql = "Select AgentId from RouteMasters where RouteName='" + cmbRoute.Text.Trim() + "'and CompanyId='" + ClassConn.Companyid + "'";
            cnt =objcls.executescal(sql);
            txtAgentId.Text = Convert.ToString(cnt);
            txtAgentId.TabIndex = 0;
            txtAgentId.Focus();
         }

        public void FillAgentName()
        {
            sql = "select AgentName from RouteMasters where RouteName='" + cmbRoute.Text.Trim() + "'and CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                txtAgentName.Text = ds.Tables[0].Rows[i].ItemArray[0].ToString();
            }
        }

        public void CMRate()
        {
            sql = "Select Cowrate from MilkRates where CompanyId='" + ClassConn.Companyid + "'";
            cnt = objcls.executescal(sql);
            txtCMRate.Text = Convert.ToString(cnt);
            txtCMRate.TabIndex = 0;
            txtCMRate.Focus();
        }

        public void BMRate()
        {
            sql = "Select Buffallorate from MilkRates where CompanyId='" + ClassConn.Companyid + "'";
            cnt = objcls.executescal(sql);
            txtBMRate.Text = Convert.ToString(cnt);
            txtBMRate.TabIndex = 0;
            txtBMRate.Focus();
        }

        public void Clear()
        {
            txtId.ResetText();
            txtCustName.ResetText();
            //txtCustName.SelectedIndex = -1;
            txtCustPhone.ResetText();
            txtCustAddress.ResetText();
            cmbCustStatus.Text = "Select Status";
            txtCustBalance.ResetText();
            cmbRoute.Text= "Select Route";
            txtAgentName.ResetText();
            txtRemark.ResetText();
            numericUpDownQty.Text = "0";
            numericUpDownHQty.Text = "0";
            txtCMAmount.Text = "0";
            numericUpDownBMQty.Text = "0";
            numericUpDownBMHQty.Text = "0";
            txtBMAmount.Text = "0";
            dtpCustDate.ResetText();
            checkCowMilk.Text = "Cow Milk";
            checkBuffallo.Text = "Buffallo";
            checkCowMilk.Checked = false;
            checkBuffallo.Checked = false;
            radioMorning.Text = "Morning";
            radioEvening.Text = "Evening";
            radioMorning.Checked = false;
            radioEvening.Checked = false;
            txtPin.Text = GenerateNewRandom();
            CMRate();
            BMRate();
        }

        public void CMQTYcalculation()
        {
            try
            {
                double CMFullRate = Convert.ToDouble(txtCMRate.Text);
                double CMHalfRate = Convert.ToDouble(txtCMRate.Text) / 2;
                double CalCMFullRate = (Convert.ToDouble(numericUpDownQty.Value) * (CMFullRate));
                double CalCMHalfRate = (Convert.ToDouble(numericUpDownHQty.Value) * (CMHalfRate));
                txtCMAmount.Text = Convert.ToString(CalCMFullRate + CalCMHalfRate);
            }
            catch { }
        }

        public void BMQTYcalculation()
        {
            try
            {
                double BMFullRate = Convert.ToDouble(txtBMRate.Text);
                double BMHalfRate = Convert.ToDouble(txtBMRate.Text) / 2;
                double CalBMFullRate = (Convert.ToDouble(numericUpDownBMQty.Value) * (BMFullRate));
                double CalBMHalfRate = (Convert.ToDouble(numericUpDownBMHQty.Value) * (BMHalfRate));
                txtBMAmount.Text = Convert.ToString(CalBMFullRate + CalBMHalfRate);
            }
            catch { }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtpCustDate.Text = string.Format("{0:dd/MM/yyyy}", DateTime.Now);
            txtId.Text = dgvCustomer.SelectedCells[0].Value.ToString();
            txtCustName.Text = dgvCustomer.SelectedCells[1].Value.ToString();
            txtCustPhone.Text = dgvCustomer.SelectedCells[2].Value.ToString();
            txtCustAddress.Text = dgvCustomer.SelectedCells[3].Value.ToString();
            checkCowMilk.Text = dgvCustomer.SelectedCells[4].Value.ToString();
            if (checkCowMilk.Text == "Cow Milk")
            {
                checkCowMilk.Checked = true;
            }
            else
            {
                checkCowMilk.Checked = false;
                checkCowMilk.Text = "Cow Milk";
            }
            checkBuffallo.Text = dgvCustomer.SelectedCells[5].Value.ToString();
            if (checkBuffallo.Text == "Buffallo Milk")
            {
                checkBuffallo.Checked = true;
            }
            else
            {
                checkBuffallo.Checked = false;
                checkBuffallo.Text = "Buffallo Milk";
            }
            numericUpDownQty.Text = dgvCustomer.SelectedCells[6].Value.ToString();
            numericUpDownHQty.Text = dgvCustomer.SelectedCells[7].Value.ToString();
            txtCMRate.Text = dgvCustomer.SelectedCells[8].Value.ToString();
            numericUpDownBMQty.Text = dgvCustomer.SelectedCells[9].Value.ToString();
            numericUpDownBMHQty.Text = dgvCustomer.SelectedCells[10].Value.ToString();
            txtBMRate.Text = dgvCustomer.SelectedCells[11].Value.ToString();
            if (dgvCustomer.SelectedCells[12].Value.ToString() == "Morning")
            {
                radioMorning.Checked = true;
            }
            else
            {
                radioMorning.Checked = false;
                radioMorning.Text = "Morning";
            }
            if (dgvCustomer.SelectedCells[12].Value.ToString() == "Evening")
            {
                radioEvening.Checked = true;
            }
            else
            {
                radioEvening.Checked = false;
                radioEvening.Text = "Evening";
            }
            txtAgentName.Text = dgvCustomer.SelectedCells[13].Value.ToString();
            cmbCustStatus.Text = dgvCustomer.SelectedCells[14].Value.ToString();
            dtpCustDate.Text = dgvCustomer.SelectedCells[15].Value.ToString();
            txtPin.Text = dgvCustomer.SelectedCells[16].Value.ToString();          
            txtCMAmount.Text = dgvCustomer.SelectedCells[17].Value.ToString();
            txtBMAmount.Text = dgvCustomer.SelectedCells[18].Value.ToString();
            cmbRoute.Text = dgvCustomer.SelectedCells[19].Value.ToString();
            txtCustBalance.Text = dgvCustomer.SelectedCells[20].Value.ToString();
            txtRemark.Text = dgvCustomer.SelectedCells[21].Value.ToString();
            btnSave.Enabled = false;
            lblSave.Enabled = false;
            btnUpdate.Enabled = true;
            lblUpdate.Enabled = true;
        }

        private void cmbRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillAgentName();
            FillAgentId();
        }

        private void numericUpDownQty_ValueChanged(object sender, EventArgs e)
        {
            CMQTYcalculation();
        }

        private void numericUpDownHQty_ValueChanged(object sender, EventArgs e)
        {
            CMQTYcalculation();
        }

        private void numericUpDownBMQty_ValueChanged(object sender, EventArgs e)
        {
            BMQTYcalculation();
        }

        private void numericUpDownBMHQty_ValueChanged(object sender, EventArgs e)
        {
            BMQTYcalculation();
        }

        private void btnAddRate_Click(object sender, EventArgs e)
        {
            btnAddRate.Enabled = false;
            FrmMilkRate FMR = new FrmMilkRate();
            FMR.ShowDialog();
            CMRate();
            BMRate();
            btnAddRate.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          //  btnSave.Enabled = false;
            Regex pattern = new Regex("^[6-9][0-9]{9}${10}");
            if(txtCustPhone.Text=="")
            {
            }
            else if (pattern.IsMatch(txtCustPhone.Text))
            {
            }
            else
            {
                MessageBox.Show("Invalid phone number");
                return;
            }

            if (txtCustName.Text=="")
            {
                MessageBox.Show("Enter Customer Name ");
                return;
            }
            if(txtCustPhone.Text=="")
            {
                MessageBox.Show("Enter Phone no.");
                return;
            }
            if(txtCustAddress.Text=="")
            {
                MessageBox.Show("Enter Address");
                return;
            }
           if(cmbCustStatus.Text== "Select Status")
            {
                MessageBox.Show("Please Select Status..");
                return;
            }
           if(cmbRoute.Text== "Select Route")
            {
                MessageBox.Show("Please Select Route..");
                return;
            }
            if (radioMorning.Checked == false && radioEvening.Checked == false)
            {
                MessageBox.Show("Please Select Session..");
                return;
            }
            else
            {
                if (radioMorning.Checked == true)
                {
                    DelTime = "Morning";
                }
              else  if (radioEvening.Checked == true)
                {
                    DelTime = "Evening";
                }
            }
            if(checkCowMilk.Checked==false && checkBuffallo.Checked==false)
            {
                MessageBox.Show("Please Select MilkType..");
                return;
            }
        
            string CustDate = string.Format("{0:dd/MM/yyyy}", dtpCustDate.Value.ToString());
            DateTime datevalue = Convert.ToDateTime(CustDate);
            string CDay = datevalue.Day.ToString();
            string CMonth = datevalue.Month.ToString();
            string Cyear = datevalue.Year.ToString();

            sql = "select count(*) from CustomerProfiles where Pin = '" + txtPin.Text + "'";
            if (Convert.ToInt32(objcls.executescal(sql)) != 0)
            {
                MessageBox.Show("PinNo Already Available..");
                return;
            }

           

            if (checkCowMilk.Checked == true && checkBuffallo.Checked == true)
            {
                sql = "Insert into CustomerProfiles(CustomerName,MobileNo,Address,CowMilk,BuffaloMilk,CowMilkQty,CowMilkRate,BuffalloMilkQty,BuffalloMilkRate,DeliveryTime,AgentName,Remark,Cday,Cmonth,Cyear,CustomerStatus,Unit,UnitBuffallo,CDate,Pin,CowHalfMilkQty,BuffalloHalfMilkQty,CowMilkTotAmt,BuffalloMilkTotAmt,CompanyId,AgentID,RouteName,RouteID,GeoLocation,OldBalance)values('" + txtCustName.Text.Trim() + "','" + txtCustPhone.Text.Trim() + "','" + txtCustAddress.Text.Trim() + "','Cow Milk','Buffallo Milk','" + numericUpDownQty.Text + "','" + txtCMRate.Text.Trim() + "','" + numericUpDownBMQty.Text + "','" + txtBMRate.Text.Trim() + "','" + DelTime + "','" + txtAgentName.Text.Trim() + "','" + txtRemark.Text.Trim() + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + cmbCustStatus.Text.Trim() + "','" + txtCMUnit.Text.Trim() + "','" + txtBMUnit.Text.Trim() + "','" + dtpCustDate.Text.Trim() + "','" + txtPin.Text.Trim() + "','" + numericUpDownHQty.Text+ "','" + numericUpDownBMHQty.Text + "','" + txtCMAmount.Text.Trim() + "','" + txtBMAmount.Text.Trim() + "','" + ClassConn.Companyid + "','" + txtAgentId.Text.Trim() + "','" + cmbRoute.Text.Trim() + "','" + cmbRoute.SelectedValue.ToString() + "','0','" + txtCustBalance.Text.Trim() + "')";
                objcls.execute(sql);
                MessageBox.Show("Record Saved Successfully.....");
            }
           else if (checkCowMilk.Checked == true)
            {
                sql = "Insert into CustomerProfiles(CustomerName,MobileNo,Address,CowMilk,BuffaloMilk,CowMilkQty,CowMilkRate,BuffalloMilkQty,BuffalloMilkRate,DeliveryTime,AgentName,Remark,Cday,Cmonth,Cyear,CustomerStatus,Unit,UnitBuffallo,CDate,Pin,CowHalfMilkQty,BuffalloHalfMilkQty,CowMilkTotAmt,BuffalloMilkTotAmt,CompanyId,AgentID,RouteName,RouteID,GeoLocation,OldBalance)values('" + txtCustName.Text.Trim() + "','" + txtCustPhone.Text.Trim() + "','" + txtCustAddress.Text.Trim() + "','Cow Milk',NULL,'" + numericUpDownQty.Text + "','" + txtCMRate.Text.Trim() + "','" + numericUpDownBMQty.Text+ "','" + txtBMRate.Text.Trim() + "','" + DelTime + "','" + txtAgentName.Text.Trim() + "','" + txtRemark.Text.Trim() + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + cmbCustStatus.Text.Trim() + "','" + txtCMUnit.Text.Trim() + "','" + txtBMUnit.Text.Trim() + "','" + dtpCustDate.Text.Trim() + "','" + txtPin.Text.Trim() + "','" + numericUpDownHQty.Text + "','" + numericUpDownBMHQty.Text + "','" + txtCMAmount.Text.Trim() + "','" + txtBMAmount.Text.Trim() + "','" + ClassConn.Companyid + "','" + txtAgentId.Text.Trim() + "','" + cmbRoute.Text.Trim() + "','" + cmbRoute.SelectedValue.ToString() + "','0','" + txtCustBalance.Text.Trim() + "')";
                objcls.execute(sql);
                MessageBox.Show("Record Saved Successfully.....");
            }
            else if (checkBuffallo.Checked == true)
            {
                sql = "Insert into CustomerProfiles(CustomerName,MobileNo,Address,CowMilk,BuffaloMilk,CowMilkQty,CowMilkRate,BuffalloMilkQty,BuffalloMilkRate,DeliveryTime,AgentName,Remark,Cday,Cmonth,Cyear,CustomerStatus,Unit,UnitBuffallo,CDate,Pin,CowHalfMilkQty,BuffalloHalfMilkQty,CowMilkTotAmt,BuffalloMilkTotAmt,CompanyId,AgentID,RouteName,RouteID,GeoLocation,OldBalance)values('" + txtCustName.Text.Trim() + "','" + txtCustPhone.Text.Trim() + "','" + txtCustAddress.Text.Trim() + "',NULL,'Buffallo Milk','" + numericUpDownQty.Text + "','" + txtCMRate.Text.Trim() + "','" + numericUpDownBMQty.Text + "','" + txtBMRate.Text.Trim() + "','" + DelTime + "','" + txtAgentName.Text.Trim() + "','" + txtRemark.Text.Trim() + "','" + CDay + "','" + CMonth + "','" + Cyear + "','" + cmbCustStatus.Text.Trim() + "','" + txtCMUnit.Text.Trim() + "','" + txtBMUnit.Text.Trim() + "','" + dtpCustDate.Text.Trim() + "','" + txtPin.Text.Trim() + "','" + numericUpDownHQty.Text + "','" + numericUpDownBMHQty.Text + "','" + txtCMAmount.Text.Trim() + "','" + txtBMAmount.Text.Trim() + "','" + ClassConn.Companyid + "','" + txtAgentId.Text.Trim() + "','" + cmbRoute.Text.Trim() + "','" + cmbRoute.SelectedValue.ToString() + "','0','" + txtCustBalance.Text.Trim() + "')";
                objcls.execute(sql);
                MessageBox.Show("Record Saved Successfully.....");
            }

            Filldt();
            // Clear();
         //   btnSave.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            Regex pattern = new Regex("^[6-9][0-9]{9}${10}");
            if (txtCustPhone.Text == "")
            {
            }
            else if (pattern.IsMatch(txtCustPhone.Text))
            {
            }
            else
            {
                MessageBox.Show("Invalid phone number");
                return;
            }

            if (txtCustName.Text == "")
            {
                MessageBox.Show("Enter Customer Name ");
                return;
            }
            if (txtCustPhone.Text == "")
            {
                MessageBox.Show("Enter Phone no.");
                return;
            }
            if (txtCustAddress.Text == "")
            {
                MessageBox.Show("Enter Address");
                return;
            }
            if (cmbCustStatus.Text == "Select Status")
            {
                MessageBox.Show("Please Select Status..");
                return;
            }
            if (cmbRoute.Text == "Select Route")
            {
                MessageBox.Show("Please Select Route..");
                return;
            }
            if (radioMorning.Checked == false && radioEvening.Checked == false)
            {
                MessageBox.Show("Please Select Session..");
                return;
            }
            else
            {
                if (radioMorning.Checked == true)
                {
                    DelTime = "Morning";
                }
                else if (radioEvening.Checked == true)
                {
                    DelTime = "Evening";
                }
            }
            if (checkCowMilk.Checked == false && checkBuffallo.Checked == false)
            {
                MessageBox.Show("Please Select MilkType..");
                return;
            }

            string CustDate = string.Format("{0:dd/MMyyyy}", dtpCustDate.Value.ToString());
            DateTime datevalue = Convert.ToDateTime(CustDate);
            string CDay = datevalue.Day.ToString();
            string CMonth = datevalue.Month.ToString();
            string Cyear = datevalue.Year.ToString();

            if (radioMorning.Checked)
            {
                DelTime = "Morning";
            }
            if (radioEvening.Checked)
            {
                DelTime = "Evening";
            }
                if (checkCowMilk.Checked == true && checkBuffallo.Checked == true)
                {
                    if (numericUpDownQty.Text == "0" && numericUpDownHQty.Text == "0" && numericUpDownBMQty.Text == "0" && numericUpDownBMHQty.Text == "0")
                    {
                        MessageBox.Show("plz Enter Alteast 1 Quantity");
                    CMRate();
                    BMRate();
                }
                    else
                    {
                    sql = " UPDATE CustomerProfiles SET CustomerName='" + txtCustName.Text.Trim() + "',MobileNo='" + txtCustPhone.Text.Trim() + "',  Address='" + txtCustAddress.Text.Trim() + "', CowMilk='Cow Milk', BuffaloMilk='Buffallo Milk',CowMilkQty='" + numericUpDownQty.Text.Trim() + "',CowMilkRate='" +Convert.ToDouble(txtCMRate.Text) + "',BuffalloMilkQty='" + numericUpDownBMQty.Text.Trim() + "',BuffalloMilkRate='" + Convert.ToDouble(txtBMRate.Text)+ "',DeliveryTime='" + DelTime + "',AgentName='" + txtAgentName.Text.Trim() + "',Remark='" + txtRemark.Text.Trim() + "',CustomerStatus='" + cmbCustStatus.Text.Trim() + "',Unit='" + txtCMUnit.Text.Trim() + "',UnitBuffallo='" + txtBMUnit.Text.Trim() + "',CowHalfMilkQty='" + numericUpDownHQty.Text.Trim() + "',BuffalloHalfMilkQty='" + numericUpDownBMHQty.Text.Trim() + "',CowMilkTotAmt='" + txtCMAmount.Text.Trim() + "',BuffalloMilkTotAmt='" + txtBMAmount.Text.Trim() + "',AgentID='" + txtAgentId.Text.Trim() + "',RouteName='" + cmbRoute.Text.Trim() + "',CDate='" + dtpCustDate.Text.Trim() + "',Cday='" + CDay + "',Cmonth='" + CMonth + "',Cyear='" + Cyear + "',OldBalance='" + txtCustBalance.Text.Trim() + "' WHERE (Id=" + txtId.Text + ") and CompanyId='" + ClassConn.Companyid + "'";
                    objcls.execute(sql);
                    MessageBox.Show("Record Updated Successfully....");
                }
                }
                else if (checkCowMilk.Checked == true)
                {
                    if (numericUpDownQty.Text == "0" && numericUpDownHQty.Text == "0")
                    {
                        MessageBox.Show("plz Enter Alteast 1 CowMilk Quantity");
                    CMRate();
                    BMRate();
                }
                    else
                    {
                    sql = " UPDATE CustomerProfiles SET CustomerName='" + txtCustName.Text.Trim() + "',MobileNo='" + txtCustPhone.Text.Trim() + "',  Address='" + txtCustAddress.Text.Trim() + "', CowMilk='Cow Milk', BuffaloMilk=NULL, CowMilkQty='" + numericUpDownQty.Text.Trim() + "',CowMilkRate='" + Convert.ToDouble(txtCMRate.Text)+ "',BuffalloMilkQty='0',BuffalloMilkRate='0',DeliveryTime='" + DelTime + "',AgentName='" + txtAgentName.Text.Trim() + "',Remark='" + txtRemark.Text.Trim() + "',CustomerStatus='" + cmbCustStatus.Text.Trim() + "',Unit='" + txtCMUnit.Text.Trim() + "',UnitBuffallo='" + txtBMUnit.Text.Trim() + "',CowHalfMilkQty='" + numericUpDownHQty.Text.Trim() + "',BuffalloHalfMilkQty='0',CowMilkTotAmt='" + txtCMAmount.Text.Trim() + "',BuffalloMilkTotAmt='0',AgentID='" + txtAgentId.Text.Trim() + "',RouteName='" + cmbRoute.Text.Trim() + "',CDate='" + dtpCustDate.Text.Trim() + "',Cday='" + CDay + "',Cmonth='" + CMonth + "',Cyear='" + Cyear + "',OldBalance='" + txtCustBalance.Text.Trim() + "' WHERE (Id=" + txtId.Text + ") and CompanyId='" + ClassConn.Companyid + "'";
                    objcls.execute(sql);
                    MessageBox.Show("Record Updated Successfully....");
                }
                }
                else if (checkBuffallo.Checked == true)
                {
                    if (numericUpDownBMQty.Text == "0" && numericUpDownBMHQty.Text == "0")
                    {
                        MessageBox.Show("plz Enter Alteast 1 BuffaloMilk Quantity");
                    CMRate();
                    BMRate();
                }
                else
                    {
                    sql = " UPDATE CustomerProfiles SET CustomerName='" + txtCustName.Text.Trim() + "',MobileNo='" + txtCustPhone.Text.Trim() + "',  Address='" + txtCustAddress.Text.Trim() + "',CowMilk=NULL, BuffaloMilk='Buffallo Milk',CowMilkQty='0',CowMilkRate='0',BuffalloMilkQty='" + numericUpDownBMQty.Text.Trim() + "',BuffalloMilkRate='" + Convert.ToDouble(txtBMRate.Text) + "',DeliveryTime='" + DelTime + "',AgentName='" + txtAgentName.Text.Trim() + "',Remark='" + txtRemark.Text.Trim() + "',CustomerStatus='" + cmbCustStatus.Text.Trim() + "',Unit='" + txtCMUnit.Text.Trim() + "',UnitBuffallo='" + txtBMUnit.Text.Trim() + "',CowHalfMilkQty='0',BuffalloHalfMilkQty='" + numericUpDownBMHQty.Text.Trim() + "',CowMilkTotAmt='0',BuffalloMilkTotAmt='" + txtBMAmount.Text.Trim() + "',AgentID='" + txtAgentId.Text.Trim() + "',RouteName='" + cmbRoute.Text.Trim() + "',CDate='" + dtpCustDate.Text.Trim() + "',Cday='" + CDay + "',Cmonth='" + CMonth + "',Cyear='" + Cyear + "',OldBalance='" + txtCustBalance.Text.Trim() + "' WHERE (Id=" + txtId.Text + ") and CompanyId='" + ClassConn.Companyid + "'";
                    objcls.execute(sql);
                    MessageBox.Show("Record Updated Successfully....");
                }
                }
           
            Filldt();
            //Clear();
            btnUpdate.Enabled = true;
        }
                              
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            Clear();          
            btnSave.Enabled = true;
            lblSave.Enabled = true;
            btnUpdate.Enabled = false;
            lblUpdate.Enabled = false;
            btnNew.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnClear.Enabled = false;
            Clear();
            btnClear.Enabled = true;
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            //Variable.DetForm.Remove("frmBuilty");
            btnClose.Enabled = false;
            this.Close();
            btnClose.Enabled = true;
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            btnPrintAll.Enabled = false;
            RDLCReports.frmAddCustomerReport RDLCAC = new RDLCReports.frmAddCustomerReport();
            RDLCAC.TopLevel = false;
            panelAddCustomer.Controls.Add(RDLCAC);
            RDLCAC.BringToFront();
            RDLCAC.Show();

            btnPrintAll.Enabled = true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            btnExport.Enabled = false;
            if (dgvCustomer.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                XcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvCustomer.Columns.Count + 1; i++)
                {
                    XcelApp.Cells[1, i] = dgvCustomer.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvCustomer.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvCustomer.Columns.Count; j++)
                    {
                        XcelApp.Cells[i + 2, j + 1] = dgvCustomer.Rows[i].Cells[j].Value.ToString();
                    }
                }
                XcelApp.Columns.AutoFit();
                XcelApp.Visible = true;
            }
            btnExport.Enabled = true;
        }

    
        private void txtCustName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCustPhone.Focus();
            }
        }
        private void txtCustPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCustAddress.Focus();
            }
        }
        private void txtCustAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbCustStatus.Focus();
            }
        }
        private void cmbCustStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCustBalance.Focus();
            }
        }
        private void txtCustBalance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbRoute.Focus();
            }
        }
        private void cmbRoute_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRemark.Focus();
            }
        }

        private void panelAddCustomer_Paint(object sender, PaintEventArgs e)
        {

        }

        public void PhoneNoValidation()
        {
            Regex pattern = new Regex("^[6-9][0-9]{9}${10}");
            if (pattern.IsMatch(txtCustPhone.Text))
            {
            }
            else
            {
                MessageBox.Show("Invalid phone number");
                txtCustPhone.Focus();
            }
        }
        private void txtCustPhone_Leave(object sender, EventArgs e)
        {
            if(txtCustPhone.Text=="")
            {
            }
            else
            {
                PhoneNoValidation();
            }
           
        }

        private void txtCustName_Leave(object sender, EventArgs e)
        {
            if (txtCustName.Text != "")
            {
                string text = txtCustName.Text;
                string firstletterofeachstring = string.Join(" ", text.Split(' ').ToList().ConvertAll(word => word.Substring(0, 1).ToUpper() + word.Substring(1)));
                txtCustName.Text = firstletterofeachstring;
            }
        }

        private void txtCustAddress_Leave(object sender, EventArgs e)
        {
            if (txtCustAddress.Text != "")
            {
                string text = txtCustAddress.Text;
                string firstletterofeachstring = string.Join(" ", text.Split(' ').ToList().ConvertAll(word => word.Substring(0, 1).ToUpper() + word.Substring(1)));
                txtCustAddress.Text = firstletterofeachstring;
            }
        }

        private void txtRemark_Leave(object sender, EventArgs e)
        {
            if (txtRemark.Text.Trim() != "")
            {
                string text = txtRemark.Text.Trim();
                string firstletterofeachstring = string.Join(" ", text.Split(' ').ToList().ConvertAll(word => word.Substring(0, 1).ToUpper() + word.Substring(1)));
                txtRemark.Text = firstletterofeachstring;
                
            }

        }

        private void txtAgentName_Leave(object sender, EventArgs e)
        {
            if (txtAgentName.Text.Trim() != "")
            {
                string text = txtAgentName.Text.Trim();
                string firstletterofeachstring = string.Join(" ", text.Split(' ').ToList().ConvertAll(word => word.Substring(0, 1).ToUpper() + word.Substring(1)));
                txtAgentName.Text = firstletterofeachstring;

            }

        }

        private void FrmAddCustomer_Shown(object sender, EventArgs e)
        {
            txtCustName.Focus();
        }

        private void txtRemark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpCustDate.Focus();
            }
        }

        private void dtpCustDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                radioMorning.Focus();
            }
        }

        private void radioMorning_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddRate.Focus();
            }
        }

        private void cmbCustStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
 
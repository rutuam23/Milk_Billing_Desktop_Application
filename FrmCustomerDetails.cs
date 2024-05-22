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
    public partial class FrmCustomerDetails : Form
    {
        public FrmCustomerDetails()
        {
            InitializeComponent();
        }
        ClassConn objcls = new ClassConn();
        DataSet ds = new DataSet();
        string sql;

        private void FrmCustomerDetails_Load(object sender, EventArgs e)
        {
            sql = "select Count(*) from RouteMasters where CompanyId='" + ClassConn.Companyid + "'";
            int cnt = objcls.executescal(sql);
            if (cnt == 0)
            {
                MessageBox.Show("Please Add Route...");
                return;
            }
            else
            {
                FillRouteDetails();
                FillCustomerDetails();
                dgvCustomerDetails.Columns[0].Visible = false;
                dgvRouteDetails.Columns[0].Visible = false;
                dgvRouteDetails.Columns[3].Visible = false;
                dgvRouteDetails.Columns[4].Visible = false;
                panelFront.Enabled = true;
                panelBack.Enabled = true;
            }         
        }

    
        public void FillRouteDetails()
        {
            sql = "select * from RouteMasters where CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            dgvRouteDetails.DataSource = ds.Tables[0];
            dgvRouteDetails.Columns[1].Width = 229;
            dgvRouteDetails.Columns[2].Width = 227;
        }

        public void FillCustomerDetails()
        {
            sql = "Select Id,CustomerName,MobileNo,Pin,RouteName,CustomerStatus from CustomerProfiles where RouteName='" + dgvRouteDetails.SelectedCells[1].Value.ToString() + "'and CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            dgvCustomerDetails.DataSource = ds.Tables[0];
            dgvCustomerDetails.Columns[0].Visible = false;
            dgvCustomerDetails.Columns[1].Width = 190;
            dgvCustomerDetails.Columns[2].Width = 120;
            dgvCustomerDetails.Columns[3].Width = 120;
            dgvCustomerDetails.Columns[4].Width = 190;
        }
 
        private void txtSearchRoute_TextChanged(object sender, EventArgs e)
        {
            sql = "Select * from RouteMasters where RouteName like '%" + txtSearchRoute.Text + "%' and CompanyId='" + ClassConn.Companyid + "'";
            ds = new DataSet();
            ds = objcls.fillDs(sql);
            dgvRouteDetails.DataSource = ds.Tables[0];
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            sql = "Select Id,CustomerName,MobileNo,Pin,RouteName,RouteID from CustomerProfiles where CustomerName like '%" + txtSearchCustomer.Text + "%' and RouteName='" + dgvRouteDetails.SelectedCells[1].Value.ToString() + "'and CompanyId='" + ClassConn.Companyid + "'";
            ds = new DataSet();
            ds = objcls.fillDs(sql);
            dgvCustomerDetails.DataSource = ds.Tables[0];
        }
        private void cmbSearchTime_TextChanged(object sender, EventArgs e)
        {
            sql = "Select Id,CustomerName,MobileNo,Pin,RouteName,RouteID from CustomerProfiles where DeliveryTime like '%" + cmbSearchTime.Text + "%'and RouteName='" + dgvRouteDetails.SelectedCells[1].Value.ToString() + "'and CompanyId='" + ClassConn.Companyid + "'";
            ds = new DataSet();
            ds = objcls.fillDs(sql);
            dgvCustomerDetails.DataSource = ds.Tables[0];
        }

        private void dgvRouteDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillCustomerDetails();
            panelFront.SendToBack();
            txtSearchCustomer.Focus();
            panelFront.Visible = false;
            panelBack.Visible = true;
        }

        //for Loader....
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(5000);
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FrmMilkStatus frmCD = new FrmMilkStatus();
            frmCD.TopLevel = false;
            panelCust.Controls.Add(frmCD);
            frmCD.BringToFront();
            frmCD.Show();
            pcloader.Visible = false;
        }
        private void dgvCustomerDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassConn.CustID = dgvCustomerDetails.SelectedCells[0].Value.ToString();

           string custStatus= dgvCustomerDetails.SelectedCells[5].Value.ToString();

            if (custStatus == "Active")
            {
                pcloader.Visible = true;
                backgroundWorker1.RunWorkerAsync();
            }
            else if (custStatus == "Deactive")
            {
                MessageBox.Show("The Customer will be Deactiveted");
                return;
            }
              
        }
            
        private void btnBack_Click(object sender, EventArgs e)
        {
            btnBack.Enabled = false;
            panelBack.SendToBack();
            panelFront.BringToFront();
            panelFront.Visible = true;
            btnBack.Enabled = true;
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            this.Close();
            button1.Enabled = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnClose.Enabled = false;
            this.Close();
            btnClose.Enabled = true;
        }

        private void FrmCustomerDetails_Shown(object sender, EventArgs e)
        {
            txtSearchRoute.Focus();
        }
    }
}

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
    public partial class FrmCompanyID : Form
    {
        public FrmCompanyID()
        {
            InitializeComponent();
        }
        ClassConn objcls = new ClassConn();
        DataSet ds = new DataSet();
        string sql;

        public void CompanyID()
        {

            sql = "select CompanyId from CompanyRegistrations where CEmail='" + txtCompanyEmail.Text.Trim() + "'";
            ds = objcls.fillDs(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                txtCompanyId.Text = ds.Tables[0].Rows[i].ItemArray[0].ToString();
            }
        }

        private void txtCompanyId_TextChanged(object sender, EventArgs e)
        {
            if (txtCompanyId.Text != "")
            {
                MessageBox.Show("Please Remember Your Company ID...");
            }
        }

        private void btnGetCompanyID_Click(object sender, EventArgs e)
        {
            btnGetCompanyID.Enabled = false;
            CompanyID();
            btnGetCompanyID.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnClose.Enabled = false;
            this.Close();
            btnClose.Enabled = true;
        }

        private void txtCompanyEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnGetCompanyID.Focus();
            }
        }

        private void FrmCompanyID_Shown(object sender, EventArgs e)
        {
            txtCompanyEmail.Focus();
        }
    }
}

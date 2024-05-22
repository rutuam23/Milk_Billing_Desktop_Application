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
    public partial class FrmMilkRate : Form
    {
        public FrmMilkRate()
        {
            InitializeComponent();
        }

        ClassConn objcls = new ClassConn();
        DataSet ds = new DataSet();
        string sql;
        int cnt;

        private void FrmMilkRate_Load(object sender, EventArgs e)
        {
            CMRate();
            BMRate();
            txtCMRate.Focus();
        }

        public void CMRate()
        {
            sql = "Select Cowrate from MilkRates where CompanyId='" + ClassConn.Companyid + "'";
            cnt = objcls.executescal(sql);
            txtCMRate.Text = Convert.ToString(cnt);
        }
        public void BMRate()
        {
            sql = "Select Buffallorate from MilkRates where CompanyId='" + ClassConn.Companyid + "'";
            cnt = objcls.executescal(sql);
            txtBMRate.Text = Convert.ToString(cnt);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            this.Close();
            btnCancel.Enabled = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
            sql = "select * from MilkRates where CompanyId='" + ClassConn.Companyid + "'";
            cnt = objcls.executescal(sql);
            if (cnt != 0)
            {
                sql = " UPDATE MilkRates SET Cowrate='" + txtCMRate.Text + "',Buffallorate='" + txtBMRate.Text + "'where CompanyId='" + ClassConn.Companyid + "'";
                objcls.execute(sql);
              //  MessageBox.Show("Rate Updated Successfully....");              
                this.Hide();
                return;
            }
            sql = "Insert into MilkRates(Cowrate,Buffallorate,CompanyId)values('" + txtCMRate.Text + "','" + txtBMRate.Text + "','" + ClassConn.Companyid + "')";
            objcls.execute(sql);
            MessageBox.Show("Rate Save Successfully....");
            this.Hide();
            btnOk.Enabled = true;
        }

        private void txtCMRate_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtBMRate.Focus();
            }
        }
    }
}

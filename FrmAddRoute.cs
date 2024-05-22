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
    public partial class FrmAddRoute : Form
    {
        public FrmAddRoute()
        {
            InitializeComponent();
        }
        ClassConn objcls = new ClassConn();
        DataSet ds = new DataSet();
        string sql;

        private void FrmAddRoute_Load(object sender, EventArgs e)
        {
            fillAgentName();
            Filldt();
            btnUpdate.Enabled = false;
            lblUpdate.Enabled = false;
            dgvRoute.Columns[0].Visible = false;
            dgvRoute.Columns[3].Visible = false;
            dgvRoute.Columns[4].Visible = false;
        }

        public void fillAgentName()
        {
            sql = "Select Id,AgentName from AgentMasters where CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            cmbAgentName.DataSource = ds.Tables[0];
        }

        public void Filldt()
        {
            sql = "select * from RouteMasters where CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            dgvRoute.DataSource = ds.Tables[0];
            dgvRoute.Columns[1].Width = 229;
            dgvRoute.Columns[2].Width = 200;
        }

        public void Clear()
        {
            txtRoute.ResetText();
            cmbAgentName.ResetText();
            btnUpdate.Enabled = false;
            lblUpdate.Enabled = false;
            btnSave1.Enabled = true;
            lblSave.Enabled = true;
        }

        private void txtSearchRoute_TextChanged(object sender, EventArgs e)
        {
            sql = "Select * from RouteMasters where RouteName like '%" + txtSearchRoute.Text.Trim() + "%' and CompanyId='" + ClassConn.Companyid + "'";
            ds = new DataSet();
            ds = objcls.fillDs(sql);
            dgvRoute.DataSource = ds.Tables[0];
        }

        private void dgvRoute_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvRoute.SelectedCells[0].Value.ToString();
            txtRoute.Text = dgvRoute.SelectedCells[1].Value.ToString();
            cmbAgentName.Text = dgvRoute.SelectedCells[2].Value.ToString();
            btnSave1.Enabled = false;
            lblSave.Enabled = false;
            btnUpdate.Enabled = true;
            lblUpdate.Enabled = true;
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            btnSave1.Enabled = false;

            if (txtRoute.Text == "")
            {
                MessageBox.Show("Please Enter Route..");
                return;
            }
            if (cmbAgentName.Text == "Select Agent")
            {
                MessageBox.Show("Please Select AgentName..");
                return;
            }
            sql = "Insert into RouteMasters(RouteName,AgentName,AgentId,CompanyId)values('" + txtRoute.Text.Trim() + "','" + cmbAgentName.Text.ToString() + "','" + cmbAgentName.SelectedValue.ToString() + "','" + ClassConn.Companyid + "')";
            objcls.execute(sql);
            MessageBox.Show("Record Saved Successfully.....");
            Filldt();
            Clear();
            btnSave1.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            if (txtRoute.Text == "")
            {
                MessageBox.Show("Please Enter Route..");
                return;
            }
            if (cmbAgentName.Text == "Select Agent")
            {
                MessageBox.Show("Please Select AgentName..");
                return;
            }

            sql = " UPDATE RouteMasters SET RouteName='" + txtRoute.Text.Trim() + "',  AgentName='" + cmbAgentName.Text.Trim() + "', AgentId='" + cmbAgentName.SelectedValue.ToString() + "' WHERE (Id=" + txtId.Text + ")";
            objcls.execute(sql);
            MessageBox.Show("Record Updated Successfully....");
            Filldt();
            Clear();
            btnUpdate.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            Clear();
            btnSave1.Enabled = true;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnClose.Enabled = false;
            this.Close();
            btnClose.Enabled = true;
        }

        private void txtRoute_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbAgentName.Focus();
            }
        }

        private void cmbAgentName_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave1.Focus();
            }
        }

        private void txtRoute_Leave(object sender, EventArgs e)
        {
            if (txtRoute.Text != "")
            {
                string text = txtRoute.Text;
                string firstletterofeachstring = string.Join(" ", text.Split(' ').ToList().ConvertAll(word => word.Substring(0, 1).ToUpper() + word.Substring(1)));
                txtRoute.Text = firstletterofeachstring;
            }
        }

        private void FrmAddRoute_Shown(object sender, EventArgs e)
        {
            txtRoute.Focus();
        }
    }
}

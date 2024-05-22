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
    public partial class FrmAddMilkMan : Form
    {
        public FrmAddMilkMan()
        {
            InitializeComponent();
        }
        ClassConn objcls = new ClassConn();
        DataSet ds = new DataSet();
        string sql;

        private void FrmAddMilkMan_Load(object sender, EventArgs e)
        {
            txtPinNo.Text = GenerateNewRandom();
            filldt();
            txtMilkManN.TabIndex = 0;
            //txtMilkManN.Focus();
            btnUpdate.Enabled = false;
            lblUpdate.Enabled = false;
            dgvMilkMan.Columns[0].Visible = false;
            //dgvMilkMan.Columns[3].Visible = false;
            dgvMilkMan.Columns[4].Visible = false;
            dgvMilkMan.Columns[5].Visible = false;
            dgvMilkMan.Columns[8].Visible = false;
            dgvMilkMan.Columns[9].Visible = false;
            dgvMilkMan.Columns[10].Visible = false;
        }

        public static string GenerateNewRandom()
        {
            Random generator = new Random();
            String r = generator.Next(0, 1000000).ToString("D6");
            if (r.Distinct().Count() == 1)
            {
                r = GenerateNewRandom();
            }         
            return  r;          
        }       

        public void filldt()
        {
            sql = "select * from AgentMasters where CompanyId='" + ClassConn.Companyid + "'";
            ds = objcls.fillDs(sql);
            dgvMilkMan.DataSource = ds.Tables[0];
            dgvMilkMan.Columns[1].Width = 200;
            dgvMilkMan.Columns[2].Width = 130;
            dgvMilkMan.Columns[3].Width = 130;
            dgvMilkMan.Columns[6].Width = 130;
            dgvMilkMan.Columns[7].Width = 130;
        }

        public void Clear()
        {
            txtMilkManN.ResetText();
            txtMobileNo1.ResetText();
            txtMobileNo2.ResetText();
            checkMobNo1.Text = "Is Whatsapp No";
            checkMobNo2.Text = "Is Whatsapp No";
            checkMobNo1.Checked = false;
            checkMobNo2.Checked = false;
            txtEmailID.ResetText();
            cmbMilkManStatus.ResetText();
        }

        private void txtSearchMilkman_TextChanged(object sender, EventArgs e)
        {
            sql = "Select * from AgentMasters where AgentName like '%" + txtSearchMilkman.Text.Trim() + "%' and CompanyId='" + ClassConn.Companyid + "'";
            ds = new DataSet();
            ds = objcls.fillDs(sql);
            dgvMilkMan.DataSource = ds.Tables[0];
        }

        private void dgvMilkMan_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvMilkMan.SelectedCells[0].Value.ToString();
            txtMilkManN.Text = dgvMilkMan.SelectedCells[1].Value.ToString();
            txtMobileNo1.Text = dgvMilkMan.SelectedCells[2].Value.ToString();
            txtMobileNo2.Text = dgvMilkMan.SelectedCells[3].Value.ToString();
            txtEmailID.Text = dgvMilkMan.SelectedCells[4].Value.ToString();
            cmbMilkManStatus.Text = dgvMilkMan.SelectedCells[6].Value.ToString();
            checkMobNo1.Text = dgvMilkMan.SelectedCells[8].Value.ToString();
            if (checkMobNo1.Text == "WhatsappNo")
            {
                checkMobNo1.Checked = true;
                checkMobNo1.Text = "Is Whatsapp No";
            }
            else
            {
                checkMobNo1.Checked = false;
                checkMobNo1.Text = "Is Whatsapp No";
            }
            checkMobNo2.Text = dgvMilkMan.SelectedCells[9].Value.ToString();
            if (checkMobNo2.Text == "WhatsappNo")
            {
                checkMobNo2.Checked = true;
                checkMobNo2.Text = "Is Whatsapp No";
            }
            else
            {
                checkMobNo2.Checked = false;
                checkMobNo2.Text = "Is Whatsapp No";
            }
            btnUpdate.Enabled = true;
            lblUpdate.Enabled = true;
            btnSave1.Enabled = false;
            lblSave.Enabled = false;
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            btnSave1.Enabled = false;
            {
                Regex pattern = new Regex("^[6-9][0-9]{9}${10}");
                if (txtMobileNo1.Text == "")
                {
                }
                else if(pattern.IsMatch(txtMobileNo1.Text))
                {
                }
                else
                {
                    MessageBox.Show("Invalid phone number");
                }
            }
            {
                Regex pattern = new Regex("^[6-9][0-9]{9}${10}");
                if (txtMobileNo2.Text == "")
                {
                }
               else if (pattern.IsMatch(txtMobileNo2.Text))
                {
                }
                else
                {
                    MessageBox.Show("Invalid phone number");
                }
            }

            if (txtMilkManN.Text == "")
            {
                MessageBox.Show("Please Enter MilkMan Name..");
                return;
            }
            if (txtEmailID.Text == "")
            {
                MessageBox.Show("Please Enter EmailID..");
                return;
            }
            if (cmbMilkManStatus.Text == "")
            {
                MessageBox.Show("Please Select MilkMan Status..");
                return;
            }
            if (txtMobileNo1.Text == "" && txtMobileNo2.Text == "")
            {
                MessageBox.Show("Please Enter Mobile No..");
                return;
            }
            if (checkMobNo1.Checked == false && checkMobNo2.Checked == false)
            {
                MessageBox.Show("Please Check Mobile No..");
                return;
            }


            sql = "select count(*) from AgentMasters where Pin = '" + txtPinNo.Text + "'";
            if (Convert.ToInt32(objcls.executescal(sql)) != 0)
            {
                MessageBox.Show("PinNo Already Available..");
                return;
            }

            if (txtPinNo.Text != "")
            {
                ClassConn.PinCodeMilkMan = txtPinNo.Text;
                FrmPopupPin frmPP = new FrmPopupPin();
                frmPP.ShowDialog();

            }

            if (checkMobNo1.Checked == true)
            {
                sql = "Insert into AgentMasters(AgentName,MobileNo,MobileNo1,Emailid,AgentStatus,WhatsappNo1,CompanyId,Pin)values('" + txtMilkManN.Text.Trim() + "','" + txtMobileNo1.Text.Trim() + "','" + txtMobileNo2.Text.Trim() + "','" + txtEmailID.Text.Trim() + "','" + cmbMilkManStatus.Text.Trim() + "','WhatsappNo','" + ClassConn.Companyid + "','" + txtPinNo.Text.Trim() + "')";
                objcls.execute(sql);
            }
            else if (checkMobNo2.Checked == true)
            {
                sql = "Insert into AgentMasters(AgentName,MobileNo,MobileNo1,Emailid,AgentStatus,WhatsappNo2,CompanyId,Pin)values('" + txtMilkManN.Text.Trim() + "','" + txtMobileNo1.Text.Trim() + "','" + txtMobileNo2.Text.Trim() + "','" + txtEmailID.Text.Trim() + "','" + cmbMilkManStatus.Text.Trim() + "','WhatsappNo','" + ClassConn.Companyid + "','" + txtPinNo.Text.Trim() + "')";
                objcls.execute(sql);
            }
         
            MessageBox.Show("Record Saved Successfully.....");
            filldt();
            // Clear();

            btnSave1.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            {
                Regex pattern = new Regex("^[6-9][0-9]{9}${10}");
                if (txtMobileNo1.Text == "")
                {
                }
                else if (pattern.IsMatch(txtMobileNo1.Text))
                {
                }
                else
                {
                    MessageBox.Show("Invalid phone number");
                }
            }
            {
                Regex pattern = new Regex("^[6-9][0-9]{9}${10}");
                if (txtMobileNo2.Text == "")
                {
                }
                else if (pattern.IsMatch(txtMobileNo2.Text))
                {
                }
                else
                {
                    MessageBox.Show("Invalid phone number");
                }
            }

            if (txtMilkManN.Text == "")
            {
                MessageBox.Show("Please Enter MilkMan Name..");
                return;
            }
            if (txtEmailID.Text == "")
            {
                MessageBox.Show("Please Enter EmailID..");
                return;
            }
            if (cmbMilkManStatus.Text == "")
            {
                MessageBox.Show("Please Select MilkMan Status..");
                return;
            }
            if (txtMobileNo1.Text == "" && txtMobileNo2.Text == "")
            {
                MessageBox.Show("Please Enter Mobile No..");
                return;
            }
            if (checkMobNo1.Checked == false && checkMobNo2.Checked == false)
            {
                MessageBox.Show("Please Check Mobile No..");
                return;
            }


            if (checkMobNo1.Checked == true && checkMobNo2.Checked == true)
            {
                sql = " UPDATE AgentMasters SET AgentName='" + txtMilkManN.Text.Trim() + "',  MobileNo='" + txtMobileNo1.Text.Trim() + "', MobileNo1='" + txtMobileNo2.Text.Trim() + "', Emailid='" + txtEmailID.Text.Trim() + "',  AgentStatus='" + cmbMilkManStatus.Text.Trim() + "',  WhatsappNo1='WhatsappNo',  WhatsappNo2='WhatsappNo' WHERE (Id=" + txtId.Text.Trim() + ")";
            }

            else
            {
                if (checkMobNo1.Checked == true)
                {
                    sql = " UPDATE AgentMasters SET AgentName='" + txtMilkManN.Text.Trim() + "',  MobileNo='" + txtMobileNo1.Text.Trim() + "', MobileNo1='" + txtMobileNo2.Text.Trim() + "', Emailid='" + txtEmailID.Text.Trim() + "',  AgentStatus='" + cmbMilkManStatus.Text.Trim() + "',  WhatsappNo1='WhatsappNo',  WhatsappNo2=Null WHERE (Id=" + txtId.Text.Trim() + ")";
                }
                else if (checkMobNo2.Checked == true)
                {
                    sql = " UPDATE AgentMasters SET AgentName='" + txtMilkManN.Text.Trim() + "',  MobileNo='" + txtMobileNo1.Text.Trim() + "', MobileNo1='" + txtMobileNo2.Text.Trim() + "', Emailid='" + txtEmailID.Text.Trim() + "',  AgentStatus='" + cmbMilkManStatus.Text.Trim() + "',  WhatsappNo1=Null,  WhatsappNo2='WhatsappNo' WHERE (Id=" + txtId.Text.Trim() + ")";
                }
            }
            objcls.execute(sql);
            MessageBox.Show("Record Updated Successfully....");
            filldt();
          //Clear();
            btnUpdate.Enabled = false;
            lblUpdate.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            txtPinNo.Text = GenerateNewRandom();
            Clear();
            btnUpdate.Enabled = false;
            lblUpdate.Enabled = false;
            btnSave1.Enabled = true;
            lblSave.Enabled = true;
            btnNew.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnClear.Enabled = false;
            Clear();
            btnClear.Enabled = true;
        }        
        private void txtMilkManN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMobileNo1.Focus();
            }
        }

        private void txtMobileNo1_KeyDown(object sender, KeyEventArgs e)
        {
           

            if (e.KeyCode == Keys.Enter)
            {
              
                txtMobileNo2.Focus();
            }
        }

        private void txtMobileNo2_KeyDown(object sender, KeyEventArgs e)
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
                cmbMilkManStatus.Focus();
            }
        }

        private void cmbMilkManStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            this.Close();
            button1.Enabled = true;
        }
        public void mobailNo1Validation()
        {

            Regex pattern = new Regex("^[6-9][0-9]{9}${10}");
            if (pattern.IsMatch(txtMobileNo1.Text))
            {
            }
            else
            {
                MessageBox.Show("Invalid phone number");
                txtMobileNo1.Focus();
            }
        }

        public void mobailNo2Validation()
        {

            Regex pattern = new Regex("^[6-9][0-9]{9}${10}");
            if (pattern.IsMatch(txtMobileNo2.Text))
            {
            }
            else
            {
                MessageBox.Show("Invalid phone number");
                txtMobileNo2.Focus();
            }
        }

        private void txtMobileNo1_Leave(object sender, EventArgs e)
        {
            if(txtMobileNo1.Text=="")
            {
            }
            else
            {
                mobailNo1Validation();
            }
        }

        private void txtMobileNo2_Leave(object sender, EventArgs e)
        {
            if (txtMobileNo2.Text == "")
            {
            }
            else
            {
                mobailNo2Validation();
            }
        }

        private void txtMilkManN_Leave(object sender, EventArgs e)
        {
            if (txtMilkManN.Text != "")
            {
                string text = txtMilkManN.Text;
                string firstletterofeachstring = string.Join(" ", text.Split(' ').ToList().ConvertAll(word => word.Substring(0, 1).ToUpper() + word.Substring(1)));
                txtMilkManN.Text = firstletterofeachstring;
            }
        }

        private void txtMobileNo1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMobileNo2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmAddMilkMan_Shown(object sender, EventArgs e)
        {
            txtMilkManN.Focus();
        }
    }
}

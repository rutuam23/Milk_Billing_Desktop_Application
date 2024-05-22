using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MilkDistributionApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

        }
        ClassConn objcls = new ClassConn();
        DataSet ds = new DataSet();
        string sql;
        int cnt;
        private object btn;

        public void Clear()
        {
            // cmbCompanyid.ResetText();
            txtCompanyEmail.ResetText();
            txtPassword.ResetText();
        }       
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );
        
        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Transparent;
        }       

        private void btnLogin_MouseMove(object sender, MouseEventArgs e)
        {
            btnLogin.BackColor = Color.Transparent;
        }

       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;

            if (txtCompanyId.Text == "")
            {
                MessageBox.Show("Please Enter Company id...");
            }
            else if (txtCompanyEmail.Text == "")
            {
                MessageBox.Show("Please Enter Company Email...");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password...");
            }
           
            sql = "select * from CompanyRegistrations where CEmail='" + txtCompanyEmail.Text.Trim() + "' and CompamyPassword='" + txtPassword.Text.Trim() + "' and CompanyId = '" + txtCompanyId.Text.Trim() + "'";
            cnt = objcls.executescal(sql);

            if (cnt != 0)
            {
                ClassConn.Companyid = txtCompanyId.Text;
                MessageBox.Show("Login Successfully");
                this.Hide();
                FrmNewDashbord objfrm = new FrmNewDashbord();
                objfrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
            btnLogin.Enabled = true;
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            btnCancel1.Enabled = false;
            this.Close();
            btnCancel1.Enabled = true;
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 70, 70));
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            FrmRegistration frmReg = new FrmRegistration();
            frmReg.ShowDialog();
        }

        private void lblGetCompanyID_Click(object sender, EventArgs e)
        {
            FrmCompanyID frmCmId = new FrmCompanyID();
            frmCmId.Show();
        }
     
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        

        private void txtCompanyId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCompanyEmail.Focus();
            }
        }       

        private void txtCompanyEmail_KeyDown_1(object sender, KeyEventArgs e)
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
                btnLogin.Focus();
            }
        }

        private void txtCompanyEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}





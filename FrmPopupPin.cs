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
    public partial class FrmPopupPin : Form
    {
        public FrmPopupPin()
        {
            InitializeComponent();
        }

        ClassConn objcls = new ClassConn();
        DataSet ds = new DataSet();
        string sql;
        int cnt;

        private void FrmPopupPin_Load(object sender, EventArgs e)
        {
            txtPinNumber.Text = ClassConn.PinCodeMilkMan;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
          
        }

      

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            this.Close();
            btnCancel.Enabled = true;
        }

        private void txtPinNumber_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}

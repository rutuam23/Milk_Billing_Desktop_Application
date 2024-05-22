using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkDistributionApp
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
           
        FrmMilkStatus FMS;
        int Controlday;

        public UserControlDays(FrmMilkStatus MS)
        {
            InitializeComponent();
            this.FMS = MS;
        }
        
        private void UserControlDays_Load(object sender, EventArgs e)
        {
        }

        public void Days(int numday)
        {
            lblDays.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lblDays.Text;     
            FMS.CallMilkAddProductFrm();
        }

        private void lblDays_Click(object sender, EventArgs e)
        {
            static_day = lblDays.Text;
            FMS.CallMilkAddProductFrm();
        }
    }
}

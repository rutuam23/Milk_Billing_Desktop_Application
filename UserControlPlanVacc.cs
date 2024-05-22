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
    public partial class UserControlPlanVacc : UserControl
    {
        public static string static_day;
        FrmPlanVaccation FPV;
        public UserControlPlanVacc(FrmPlanVaccation PV)
        {
            InitializeComponent();
            this.FPV = PV;
        }

        public void Days(int numday)
        {
            lblDays.Text = numday + "";
        }

        private void UserControlPlanVacc_Click(object sender, EventArgs e)
        {
            static_day = lblDays.Text;
            FPV.SelectDate();
        }

        private void lblDays_Click(object sender, EventArgs e)
        {
            static_day = lblDays.Text;
            FPV.SelectDate();
        }
    }
}

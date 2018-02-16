using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMascotAlexL
{
    public partial class frmSchoolMascot : Form
    {
        public frmSchoolMascot()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mniIMH_Click(object sender, EventArgs e)
        {
            lblName.Text = "Immaculata";
            lblMascot.Text = "Saints";
        }

        private void mniAsh_Click(object sender, EventArgs e)
        {
            lblName.Text = "Ashbury";
            lblMascot.Text = "Colts";
        }

        private void mniMT_Click(object sender, EventArgs e)
        {
            lblName.Text = "Mother Teresa";
            lblMascot.Text = "Titans";
        }

        private void mniSP_Click(object sender, EventArgs e)
        {
            lblName.Text = "Saint Patrick's";
            lblMascot.Text = "Irish";
        }
    }
}

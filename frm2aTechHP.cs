using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP
{
    public partial class frm2aTechHP : Form
    {
        public string usernm;   // username
        public frm2aTechHP()
        {
            InitializeComponent();
        }

        public frm2aTechHP(string username)     // will be referenced from Users class
        {
            InitializeComponent();
            usernm = username;
        }

        private void btnViewServRq_Click(object sender, EventArgs e)
        {
            frm2bViewServRq frmobj = new frm2bViewServRq(usernm);
            frmobj.ShowDialog();
        }

        private void btnServCpRp_Click(object sender, EventArgs e)
        {
            frm2cServCpRp frmobj = new frm2cServCpRp(usernm);
            frmobj.ShowDialog();
        }

        private void btnModServRec_Click(object sender, EventArgs e)
        {
            frm2dModServRec frmobj = new frm2dModServRec(usernm);
            frmobj.ShowDialog();
        }

        private void frm2aTechHP_Load(object sender, EventArgs e)
        {
            lblWlc.Text = "Welcome, Technician " + usernm + " !";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {           
            frm1aLogin frmobj = new frm1aLogin();
            frmobj.ShowDialog();           
        }

        private void btnUpdProf_Click(object sender, EventArgs e)
        {
            frm3dCusUP vp = new frm3dCusUP(usernm);
            vp.ShowDialog();
        }

        /**
Remaining
1. Update Profile (Link to Update Own Profile Page)
2. Log Out (Link to Login Page)
3. Link USERNAME to Label
**/
    }
}

using System;
using System.Collections;
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
    public partial class frm2bViewServRq : Form
    {
        public string username;
        public frm2bViewServRq(string u)
        {
            InitializeComponent();
            username = u;
        }

        private void frm2bViewServRq_Load(object sender, EventArgs e)
        {
            grabServID("Urgent", cmbUrgServID);
            grabServID("Normal", cmbNormServID);

            // have a dropbox for Urgent serviceID upon formLoad
            cmbUrgServID.DroppedDown = true;
            cmbUrgServID.SelectedIndex = -1;     // set to -1, to respond to SelectedIndexChanged Event Handler
        }

        public static void grabServID(string servDmd, ComboBox cmbNm)   // method1: grab serviceID based on serviceDemand (Urgent or Normal)
        {
            ArrayList servID = new ArrayList();

            if (servDmd == "Urgent")
                servID = Services.ViewUrgOrNormServ(servDmd);   // carries "Urgent" to the SqlCommand
            else    // servDmd = "Normal"
                servID = Services.ViewUrgOrNormServ(servDmd);   // carries "Normal" to the SqlCommand

            foreach (int i in servID)       // loops through the serviceIDs in the array and add it to comboBox
                    cmbNm.Items.Add(i.ToString());
        }

        private void cmbUrgServID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNormServID.Text = "";    // clear serviceID selection from Normal Service Demand to prevent confusion
            showServInfo(cmbUrgServID);
        }

        private void cmbNormServID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbUrgServID.Text = "";     // clear serviceID selection from Urgent Service Demand to prevent confusion
            showServInfo(cmbNormServID);
        }

        private void showServInfo(ComboBox cmbNm)   // method2: to display the service info
        {
            int servID = int.Parse(cmbNm.SelectedItem.ToString());

            // creating object for serviceID, calling constructor
            Services obj1 = new Services(servID);
            Services.DisplayServInfo(obj1);     // obj1 = o1

            // GET
            lblDispServTyp.Text = obj1.ServType;
            lblDispServRqDt.Text = obj1.RequestDt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frm2aTechHP frmobj = new frm2aTechHP(username);
            frmobj.ShowDialog();
        }

        private void grpServInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}


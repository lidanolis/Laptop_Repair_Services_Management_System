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
    public partial class frm2dModServRec : Form
    {
        public int servID;      // servID declared as global, but assigned at line 92
        public string username;
        public frm2dModServRec(string u)
        {
            InitializeComponent();
            username = u;
            dtpickCpDt.Format = DateTimePickerFormat.Custom;    // set dateTimePicker to follow Custom Format
            dtpickColDt.Format = DateTimePickerFormat.Custom;           
        }

        private void frm2dModServRec_Load(object sender, EventArgs e)
        {
            dtpickCusForm("hide");
            frm2dCtrlEnabled(false);
            frm2dBtnEnabled(false);

            grabAllServID();
        }

        private void dtpickCusForm(string soh)  // method10: shows or hides dtpickValues, soh --> (show or hide)
        {
            if (soh == "hide")
            {
                dtpickCpDt.CustomFormat = " ";      // set dateTimePicker to show no value (resemble empty)
                dtpickColDt.CustomFormat = " ";
            }
            else    // (soh == "show")
            {
                dtpickCpDt.CustomFormat = "yyyy-MM-dd";     // set dateTimePicker to show value (with the mentioned format)
                dtpickColDt.CustomFormat = "yyyy-MM-dd";
            }
        }

        private void grabAllServID()    // method11: grabs all serviceID in services table, differ from grabServID() at frm2b --> (which has paramaters for servDmd and cmbName)
        {
            cmbServID.Items.Clear();    // clear comboBox items each time method is called, prevent adding redundant serviceIDs
            cmbServID.Text = "";        

            ArrayList allservID = Services.ViewAllServ();       

            foreach (int i in allservID)
            {
                cmbServID.Items.Add(i.ToString());
            }

            // assign SelectedIndex and enable DroppedDownBox inside method (since only this form will use this method), grabServID() at frm2b --> (this part was done outside method)
            cmbServID.SelectedIndex = -1;   
            cmbServID.DroppedDown = true;
        }

        private void frm2dCtrlEnabled(bool tof) // method12: enable or disable controls, tof --> true or false, DOES NOT include btnUpdate, btnDelete, btnBack & btnView
        {
            dtpickCpDt.Enabled = tof;
            rdbCp.Enabled = tof;
            rdbPending.Enabled = tof;
            txtRmk.Enabled = tof;
            dtpickColDt.Enabled = tof;
        }

        private void frm2dBtnEnabled(bool tof)  // method13: enable or disable buttons, DOES NOT include btnView & btnBack
        {
            btnUpdate.Enabled = tof;
            btnDelete.Enabled = tof;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // calling class method from Service Report form (frm2c)
            if (frm2cServCpRp.cmbVld(cmbServID) != 1)   // returns int (0 --> inaccurate info, 1 --> accurate info)
            {
                cmbServID.Focus();
                cmbServID.DroppedDown = true;
            }
            else
            {
                frm2dCtrlEnabled(true);

                servID = int.Parse(cmbServID.Text);     // text at comboBox will be an integer alr after validation, just have to convert to (int) data type

                Services obj1 = new Services(servID);   // creating obj for validated service_ID by calling constructor 

                Services.DisplayServRpInfo(obj1);       // passing obj1 to the class method, obj1 = o1

                // GET

                if (obj1.Status == "Completed")     // status can never be null, either Pending or Completed
                    rdbCp.Checked = true;
                else
                    rdbPending.Checked = true;

                // Pending Services will have null at all these entries, technically can use && as well, but || is better just in case one accidentally does not return null.
                if (obj1.CompletionDt == null || obj1.Remark == null || obj1.CollectionDt == null)
                {
                    dtpickCusForm("hide");
                    txtRmk.Clear();

                    frm2dCtrlEnabled(false);

                    MessageBox.Show("Service ID: " + servID.ToString() +
                                    "\n\nService Status: " + rdbPending.Text +
                                    "\nCompletion Date: nil" +
                                    "\nRemarks: nil" +
                                    "\nCollection Date: nil" +
                                    "\n\nOnly DELETE option is available.", "Pending Record Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    // cannot use method, frm2dBtnEnabled(bool tof) since one is true, the other is false
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = true;   // only allow delete option
                    btnDelete.Focus();
                }
                else
                {
                    dtpickCpDt.Focus();     // pulls the focus away from comboBox
                    dtpickCusForm("show");  // set dateTimePicker to show database value ("yyyy-MM-dd")

                    dtpickCpDt.Value = DateTime.Parse(obj1.CompletionDt);
                    txtRmk.Text = obj1.Remark;
                    dtpickColDt.Value = DateTime.Parse(obj1.CollectionDt);

                    frm2dBtnEnabled(true);      // allow both update and delete option
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // confirms with user that he actually wants to delete
            DialogResult result = MessageBox.Show("Service ID: " + servID.ToString() + 
                                "\n\nAre you sure you want to delete this service record ?" +
                                "\n\nProceed: Press Yes" +
                                "\nCancel: Press No", "Delete Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.No)
                cmbServID.Focus();
            else        // DialogResultl.Yes
            {
                Services obj1 = new Services(servID);   // servID validated & assigned at line 92, servID is public

                // Services.DeleteServRec(obj1) returns string --> (status on whether delete to database was achieved)
                MessageBox.Show(Services.DeleteServRec(obj1), "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm2dRefresh();
                frm2dBtnEnabled(false);

                grabAllServID();    // After DELETE, grab all serviceID again from service table, to reflect changes
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Convert dateTimePicker values to string and desired format
            string cpDt = dtpickCpDt.Value.Date.ToString("yyyy-MM-dd");
            string colDt = dtpickColDt.Value.Date.ToString("yyyy-MM-dd");

            string status;
            if (rdbCp.Checked)
                status = rdbCp.Text;
            else
                status = rdbPending.Text;

            int cnt = 1;

            if (frm2cServCpRp.rmkVld(txtRmk) != 1)  // returns int (0 --> inaccurate info, 1 --> accurate info)
            {
                txtRmk.Focus();
                cnt = 0;
            }
            else if (frm2cServCpRp.dtCheck(dtpickCpDt, dtpickColDt, cpDt) != 1) // returns int (0 --> compDt > collectDt, 1 --> collectDt >= compDt(company policy))
            {
                dtpickColDt.Focus();
                cnt = 0;               
            }

            if (cnt != 0)   // all entries validated 
            {
                frm2cServCpRp.updData(servID, cpDt, status, txtRmk.Text, colDt);
                frm2dRefresh();
                frm2dBtnEnabled(false);
            }
        }

        private void frm2dRefresh()     // method14: clear entries and disable controls (resemble frm2d form load appearance)
        {
            // clear entries
            rdbCp.Checked = false;
            rdbPending.Checked = false;
            txtRmk.Clear();
            dtpickCusForm("hide");      // unable to clear dtpick values, so just hide it

            // disable controls
            frm2dCtrlEnabled(false);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frm2aTechHP frmobj = new frm2aTechHP(username);
            frmobj.ShowDialog();
        }
    }
}

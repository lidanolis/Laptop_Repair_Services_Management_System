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
    public partial class frm2cServCpRp : Form
    {
        public int servID;
        public string cpDt = DateTime.Today.ToString("yyyy-MM-dd");      // completionDate (Service Completion Date)
        public string colDt = DateTime.Today.ToString("yyyy-MM-dd");     // collectionDate (Customer Collection Date)
        public string username;

        public frm2cServCpRp(string u)
        {
            InitializeComponent();
            username = u;
            dtpickCpDt.Format = DateTimePickerFormat.Custom;    // set dateTimePicker to follow Custom Format
            dtpickColDt.Format = DateTimePickerFormat.Custom;
        }

        private void frm2cServCpRp_Load(object sender, EventArgs e)
        {
            dtpickCpDt.CustomFormat = " ";      // set dateTimePicker to show no value (resemble empty)
            dtpickColDt.CustomFormat = " ";

            frm2cCtrlEnabled(false);
        }

        private void frm2cCtrlEnabled(bool tof)  // method3: enable or disable controls, tof --> true or false, does not include rdbUrgent, rdbNormal and btnBack
        {
            cmbServID.Enabled = tof;
            dtpickCpDt.Enabled = tof;
            chbCp.Enabled = tof;
            txtRmk.Enabled = tof;
            dtpickColDt.Enabled = tof;
            btnFinish.Enabled = tof;
            btnNewRp.Enabled = tof;
        }

        private void rdbUrgServID_CheckedChanged(object sender, EventArgs e)
        {        
            unlockCmbBox("Urgent");
        }

        private void rdbNormServID_CheckedChanged(object sender, EventArgs e)
        {
            unlockCmbBox("Normal");
        }

        private void unlockCmbBox(string servDmd)
        {
            if (rdbUrgServID.Checked == false && rdbNormServID.Checked == false)    // to account for rdbCheckedChangedEvent at frmRefresh()
                cmbServID.Enabled = false;      
            else
            {
                cmbServID.Enabled = true;
                cmbServID.Items.Clear();        // Clear the comboBox each time rdb is selected (prevent adding redundant servID)
                frm2bViewServRq.grabServID(servDmd, cmbServID);     // calling class method from Service Request form (frm2b)
                cmbServID.SelectedIndex = -1;   // set to -1, to respond to cmb_Selected_Index_Changed Event Handler
                cmbServID.DroppedDown = true;
            }
        }   // method4: ensures user has at least selected one radio button b4 enabling cmbBox

        private void cmbServID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbServID.SelectedIndex == -1)  // cmbSelectedIndex set to -1 at frmRefresh()
                cmbServID.Text = "";            // set to empty comboBox to resemble form load.
            else
            {
                servID = int.Parse(cmbServID.SelectedItem.ToString());

                dtpickCpDt.CustomFormat = "yyyy-MM-dd";     // specify format
                dtpickCpDt.Value = DateTime.Parse(cpDt);    // convert string(cpDt) to DateTime, set current date as default value

                dtpickCpDt.Enabled = true;
                chbCp.Enabled = true;
            }
        }

        private void dtpickCpDt_ValueChanged(object sender, EventArgs e)
        {
            cpDt = dtpickCpDt.Value.Date.ToString("yyyy-MM-dd");    // assigns user's date selection to cpDt, cpDt is public variable
        }

        private void chbCp_CheckedChanged(object sender, EventArgs e)
        {
            txtRmk.Enabled = true;
            txtRmk.Text = "None";   // display None as default value (when enabled)

            dtpickColDt.CustomFormat = "yyyy-MM-dd";
            dtpickColDt.Value = DateTime.Parse(colDt);

            dtpickColDt.Enabled = true;
            btnFinish.Enabled = true;
        }

        private void dtpickColDt_ValueChanged(object sender, EventArgs e)
        {
            colDt = dtpickColDt.Value.Date.ToString("yyyy-MM-dd");
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {         
            int cnt = 1;    // acts as a counter to validate all info entered is accurate and complete before updating database.

            if (cmbVld(cmbServID) != 1)          // returns int (0 --> inaccurate info, 1 --> accurate info)
            {
                cmbServID.Focus();
                cmbServID.DroppedDown = true;
                cnt = 0;
            }
            // also helps validate if other radio button is pressed (Urgent --> Normal or vice versa)
            // as UrgServID and NormServID will display different comboBoxListItems.

            else if (chbCp.Checked == false)     // catches if the checkbox is unchecked.
            {
                MessageBox.Show("Please ensure Status Checkbox is checked to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chbCp.Focus();
                cnt = 0;
            }
            else if (rmkVld(txtRmk) != 1)     // returns int (0 --> inaccurate info, 1 --> accurate info)
            {
                txtRmk.Focus();
                cnt = 0;
            }
            else if (dtCheck(dtpickCpDt, dtpickColDt, cpDt) != 1)   // returns int (0 --> compDt > collectDt, 1 --> collectDt >= compDt(company policy))
            {
                dtpickColDt.Focus();
                cnt = 0;
            }

            if (cnt != 0)       // all info has been validated
            {
                //chbCp.Text is "Completed"
                // txtRmk.Text (either is None or UserInput)
                updData(servID, cpDt, chbCp.Text, txtRmk.Text, colDt);

                btnFinish.Enabled = false;
                btnNewRp.Enabled = true;    // alows user to make another report
                btnNewRp.Focus();
            }           
        }

        public static int cmbVld(ComboBox cmbNm)    // method5: validate serviceID at cmbServID, cmbNm --> comboBox Name
        {
            int count = 1;
            if (cmbNm.Text == "")
            {
                MessageBox.Show("Service ID box is left empty. Plese enter or select a service ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                count = 0;
            }
            else
            {
                if (int.TryParse(cmbNm.Text, out int sid) == false)  // means user input is string or contains alphabetical characters
                {
                    MessageBox.Show("Invalid Service ID. Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    count = 0;
                }
                else
                {
                    if (cmbNm.Items.Contains(cmbNm.Text) == false)  // ensures the integer input or service ID is within the comboBoxListItems
                    {
                        MessageBox.Show("Service ID NOT in record. Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        count = 0;
                    }
                }
            }
            return count;
        }

        public static int rmkVld(TextBox txtNm)
        {
            int count = 1;
            if (txtNm.Text == "")
            {
                DialogResult result = MessageBox.Show("Empty Remarks will be set to None. Are you sure ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Cancel)
                {
                    txtNm.Focus();
                    count = 0;
                }
                else
                    txtNm.Text = "None";   // Remarks section will display as None
            }
            return count;
        }   // method6: validate user input at remarks section, txtNm --> textBox Name

        public static int dtCheck(DateTimePicker dtpickCpNm, DateTimePicker dtpickColNm, string cpDate) // method7: ensures collectDt >= compDt
        {
            int count = 1;
            if (dtpickColNm.Value < dtpickCpNm.Value)
            {
                MessageBox.Show("Invalid Customer Collection Date." +
                                "\n\nPlease set the date at or after " + cpDate, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                count = 0;
            }
            return count;
        }

        public static void updData(int sid, string compDt, string stat, string rmk, string collecDt)
        {
            Services obj1 = new Services(sid, compDt, stat, rmk, collecDt);

            // Services.UpdFinServInfo(obj1) returns string --> (status on whether database update was acheived)
            MessageBox.Show(Services.UpdFinServInfo(obj1), "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }   // method8: update database

        private void btnBack_Click(object sender, EventArgs e)
        {
            frm2aTechHP frmobj = new frm2aTechHP(username);
            frmobj.ShowDialog();
        }

        private void btnNewRp_Click(object sender, EventArgs e)
        {
            frmRefresh();
        }

        private void frmRefresh()
        {
            // clear entries

            rdbUrgServID.Checked = false;
            rdbNormServID.Checked = false;

            cmbServID.SelectedIndex = -1;
            cmbServID.Text = "";

            dtpickCpDt.CustomFormat = " ";     
            dtpickCpDt.Value = DateTime.Parse(cpDt);

            chbCp.Checked = false;  // checkbox
            txtRmk.Clear();

            dtpickColDt.CustomFormat = " ";
            dtpickColDt.Value = DateTime.Parse(colDt);

            // disable controls
            frm2cCtrlEnabled(false);
        }   // method9: clear entries and disable controls (resemble form load appearance)

        private void grpEnter_Enter(object sender, EventArgs e)
        {

        }
    }
}

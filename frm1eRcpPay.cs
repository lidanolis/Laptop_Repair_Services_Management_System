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
    public partial class frm1eRcpPay : Form
    {
        public frm1eRcpPay()
        {
            InitializeComponent();
        }

        private string sF = null;
        private float change;
        private string action;
        private ArrayList sFeeList = new ArrayList();
        private ArrayList sIDList = new ArrayList();
        public frm1eRcpPay(string a)
        {
            InitializeComponent();
            action = a;
        }

        private void frm1eRcpPay_Load(object sender, EventArgs e)
        {
            lblPaymentWelcome.Text = "You have choosen '" + action + "'.";
        }

        private void cbxPaymentUsername_Click(object sender, EventArgs e)
        {
            cbxPaymentUsername.Items.Clear();
            cbxPaymentService.Items.Clear();
            btnPaymentCalculate.Visible = true;
            btnPaymentConfirm.Visible = false;
            btnPaymentReceipt.Visible = false;
            txtPaymentServiceFee.Text = "The Service Fee is :";

            cbxPaymentUsername.DropDownStyle = ComboBoxStyle.DropDownList;
            ArrayList aC = new ArrayList();
            ArrayList aN = new ArrayList();

            aC = Services.customerName();

            for (int i = 0; i < aC.Count; i++)
            {
                int contradiction = 0;
                string count = aC[i].ToString();
                if (i > 0)
                {
                    for(int j = i - 1; j > -1; j--)
                    {
                        if (aC[j].ToString() == count)
                        {
                            contradiction = 1;
                        } 
                    }
                }
                if (contradiction == 0)
                {
                    aN.Add(count);
                }
            }

            foreach (var item in aN)
            {
                cbxPaymentUsername.Items.Add(item);
            }
  
        }

        private void cbxPaymentService_Click(object sender, EventArgs e)
        {
            cbxPaymentService.Items.Clear();
            btnPaymentCalculate.Visible = true;
            btnPaymentConfirm.Visible = false;
            btnPaymentReceipt.Visible = false;
            txtPaymentServiceFee.Text = "The Service Fee is : " + sF;
            cbxPaymentService.DropDownStyle = ComboBoxStyle.DropDownList;
            ArrayList sT = new ArrayList();
            if (cbxPaymentUsername.SelectedIndex != -1)
            {
                sT = Services.payService(cbxPaymentUsername.SelectedItem.ToString());
                foreach (var item in sT)
                {
                    string[] seperate = item.ToString().Split('*');
                    sIDList.Add(seperate[0]);
                    sFeeList.Add(seperate[3]);
                    cbxPaymentService.Items.Add(seperate[1] + " (" + seperate[2] + ") " + "Date = " + seperate[4]);
                }
            }
        }
        private void cbxPaymentService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPaymentService.SelectedIndex != -1)
            {
                sF = sFeeList[cbxPaymentService.SelectedIndex].ToString();
                txtPaymentServiceFee.Text = "The Service Fee is : " + sF;
            }
        }
        private void txtPayment_Click(object sender, EventArgs e)
        {
            txtPayment.Text = String.Empty;
        }

        private void btnPaymentCalculate_Click(object sender, EventArgs e)
        {
            if (sF == null || txtPayment.Text.ToString() == "" || txtPayment.Text.ToString() == "RM:")
            {
                MessageBox.Show("Incomplete Information");
            }
            else
            {
                change = float.Parse(txtPayment.Text) - float.Parse(sF);
                if (change < 0)
                {
                    MessageBox.Show("Insufficient Payment");
                    txtPayment.Text = String.Empty;
                }
                else
                {
                    txtPaymentChange.Text = "Rm: " + change.ToString("n2");
                    btnPaymentConfirm.Visible = true;
                }
            }
        }

        private void btnPaymentConfirm_Click(object sender, EventArgs e)
        {
            float assureChange = float.Parse(txtPayment.Text) - float.Parse(sF);
            string assureChangeTDP = assureChange.ToString("n2");
            string changeTDP = change.ToString("n2");
            if (float.Parse(assureChangeTDP) == float.Parse(changeTDP))
            {
                Services obj1 = new Services();
                MessageBox.Show(obj1.statChange(sIDList[cbxPaymentService.SelectedIndex].ToString()));
                btnPaymentReceipt.Visible = true;
                btnPaymentConfirm.Visible = false;
                btnPaymentCalculate.Visible = false;
            }
            else
            {
                MessageBox.Show("You have changed the payment amount, please recalculate the change to proceed");
            }
        }

        private void btnPaymentReceipt_Click(object sender, EventArgs e)
        {
            frm1fRcpReceipt obj1 = new frm1fRcpReceipt(cbxPaymentUsername.Text, cbxPaymentService.Text, sF.ToString(), txtPayment.Text, txtPaymentChange.Text);
            obj1.ShowDialog();
            btnPaymentReceipt.Visible = false;
        }

    }
}

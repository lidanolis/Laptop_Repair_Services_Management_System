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
    public partial class frm1fRcpReceipt : Form
    {
        public frm1fRcpReceipt()
        {
            InitializeComponent();
        }

        string username;
        string payService;
        string serviceFee;
        string payment;
        string paymentChange;

        public frm1fRcpReceipt(string u, string pS, string sF, string p, string pC)
        {
            InitializeComponent();
            username = u;
            payService = pS;
            serviceFee = sF;
            payment = p;
            paymentChange = pC;
        }

        private void frm1fRcpReceipt_Load(object sender, EventArgs e)
        {
            //change the text to show the values of the customer service
            lblReceipt.Text = "Thanks You, Come Again.\n------------------------------------------\n" + "Name: " + username + "\n" + "Paid Service: " + payService + "\n" + "service Fee: " + serviceFee + "\n" + "payment: " + payment + "\n" + "payment Change: " + paymentChange + "\n";

        }
    }
}

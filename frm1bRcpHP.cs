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
    public partial class frm1bRcpHP : Form
    {
        private string username;
        public frm1bRcpHP()
        {
            InitializeComponent();
        }
        
        public frm1bRcpHP(string n)
        {
            InitializeComponent();
            username = n;
        }

        private void cbxReceptionAction_Click(object sender, EventArgs e)
        {
            //change the drop down style to avoid the user from inputting their own answer
            cbxReceptionAction.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void btnReceptionConfirm_Click(object sender, EventArgs e)
        {
            if (cbxReceptionAction.SelectedIndex == -1)//this means that the user didn't selected anything
            {
                MessageBox.Show("Please Pick An Action.");
            }
            else if (cbxReceptionAction.SelectedIndex == 0)//redirect the user to other forms based on the selected action
            {
                frm1cRcpReg obj1 = new frm1cRcpReg(cbxReceptionAction.SelectedItem.ToString(), username);
                obj1.ShowDialog();
            }
            else if (cbxReceptionAction.SelectedIndex == 1)
            {
                frm1dRcpServ obj2 = new frm1dRcpServ(cbxReceptionAction.SelectedItem.ToString());
                obj2.ShowDialog();
            }
            else if (cbxReceptionAction.SelectedIndex == 2)
            {
                frm1eRcpPay obj3 = new frm1eRcpPay(cbxReceptionAction.SelectedItem.ToString());
                obj3.ShowDialog();
            }
        }
        private void frm1bRcpHP_Load(object sender, EventArgs e)//change the text upon loading the form to welcome the user
        {
            lblReceptionWelcome.Text = "Welcome Back " + username + ". Please Pick your action";
        }

        private void btnReceptionProfile_Click(object sender, EventArgs e)//redirect the user to update the user's profile
        {
            frm3dCusUP obj4 = new frm3dCusUP(username);
            obj4.ShowDialog();
        }
    }
}

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
    public partial class frm1cRcpReg : Form
    {
        public frm1cRcpReg()
        {
            InitializeComponent();
        }
        
        private string action;
        private string username;
        public frm1cRcpReg(string a, string u)
        {
            InitializeComponent();
            action = a;
            username = u;
        }

        private void btnRegisterCreate_Click(object sender, EventArgs e)
        {
            if (txtRegisterUsername.Text == "" || txtRegisterPassword.Text == "")
            {
                MessageBox.Show("Incomplete Information");
                txtRegisterUsername.Text = String.Empty;//empty the username and password
                txtRegisterPassword.Text = String.Empty;
            }
            else
            {
                Users obj1 = new Users(txtRegisterUsername.Text, txtRegisterPassword.Text);
                string status = obj1.registerNewCustomer();//register the new username and password of the new customer into the database
                if (status != null)
                {
                    MessageBox.Show(status);
                    txtRegisterUsername.Text = String.Empty;//empty the text boxes
                    txtRegisterPassword.Text = String.Empty;
                }

            }
        }

        private void frm1cRcpReg_Load(object sender, EventArgs e)
        {
            lblRegisterWelcome.Text = "You have choosen '" + action + "'.";//change the text to show the action chosen by the user
        }
    }
}

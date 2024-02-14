using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IOOP
{
    public partial class frm3dCusUP : Form
    {
        public static string name;
        public frm3dCusUP()
        {
            InitializeComponent();
        }

        public frm3dCusUP(string n)
        {
            InitializeComponent();
            name = n;
        }
        private void frm3dCusUP_Load(object sender, EventArgs e)
        {
            Profiles obj1 = new Profiles(name);
            Profiles.viewCusProfile(obj1);

            txtCusEmail.Text = obj1.Email;
            txtCusPhone.Text = obj1.PhoneNum;
        }

        private void btnCusUP_Click(object sender, EventArgs e)
        {
            Profiles obj1 = new Profiles(name);
            MessageBox.Show(obj1.updateCusProfile(txtCusEmail.Text, txtCusPhone.Text));
        }

    }
}

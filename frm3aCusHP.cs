using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IOOP
{
    public partial class frm3aCusHP : Form
    {
        public static string name;

        public frm3aCusHP()
        {
            InitializeComponent();
        }

        public frm3aCusHP(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void btnCusProfile_Click(object sender, EventArgs e)
        {
            frm3dCusUP vp = new frm3dCusUP(name);
            vp.ShowDialog();
        }

        private void frm3aCusHP_Load(object sender, EventArgs e)
        {
            lblCus2.Text = "Welcome back " + name + "!";
        }

        private void btnLogCus_Click(object sender, EventArgs e)
        {
            frm1aLogin lgup = new frm1aLogin();
            lgup.ShowDialog();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            frm3cCusHY hs = new frm3cCusHY(name);
            hs.ShowDialog();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            frm3bCusCS cs = new frm3bCusCS(name);
            cs.ShowDialog();
        }
    }
}

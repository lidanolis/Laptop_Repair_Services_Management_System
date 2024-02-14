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
    public partial class frm4aAdmnHP : Form
    {
        public static string name;

        public frm4aAdmnHP(string n)
        {
            InitializeComponent();
            name = n;
        }


        private void frm4aAdmnHP_Load(object sender, EventArgs e)
        {

        }

        private void btnAdmnRgsterTchRcp_Click(object sender, EventArgs e)
        {
            frm4bAdmnRgstr cs = new frm4bAdmnRgstr(name);
            cs.Show();
        }

        private void btnAdmnViewTotalInc_Click(object sender, EventArgs e)
        {
            frm4cAdmnInc cs = new frm4cAdmnInc (name);
            cs.ShowDialog();
        }

        private void btnAdmnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdmnUP_Click(object sender, EventArgs e)
        {
            frm3dCusUP cs = new frm3dCusUP(name);
            cs.ShowDialog();
        }
    }
}

using IOOP;
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
    public partial class frm4bAdmnRgstr : Form
    {
        public string username;
        public frm4bAdmnRgstr(string u)
        {
            InitializeComponent();
            username = u;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frm4bAdmnRgstr_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdmnBack_Click(object sender, EventArgs e)
        {
            frm4aAdmnHP cs = new frm4aAdmnHP(username);
            cs.Show();
        }

        private void btnRgstr_Click(object sender, EventArgs e) //Enter information about the user's technician or receptionist 
        {
            if (txtUsrnmebox.Text == "" || txtPsswrdbox.Text == "" ||  txtEmailbox.Text =="" || txtMblebox.Text == "" || cmbReg.Text == "")
            {
                MessageBox.Show("Incomplete Information");
                txtUsrnmebox.Text = String.Empty;   //empty out the username, password, email, mobilenumber and roles
                txtPsswrdbox.Text = String.Empty;
                txtEmailbox.Text = String.Empty;
                txtMblebox.Text = String.Empty;
                cmbReg.SelectedItem = String.Empty;
            }
            else
            {
                Users obj2 = new Users(txtUsrnmebox.Text, txtPsswrdbox.Text, txtEmailbox.Text, txtMblebox.Text, cmbReg.Text);
                string status = obj2.registerNewAdmin(); // register in the new technician or receptionist 
                if (status != null)
                {
                    MessageBox.Show(status);
                    txtUsrnmebox.Text = String.Empty; //empty out the text boxes again
                    txtPsswrdbox.Text = String.Empty;
                    txtEmailbox.Text = String.Empty;
                    txtMblebox.Text = String.Empty;
                    cmbReg.SelectedItem = String.Empty; 
                }
            }
            
        }

        private void cmbReg_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void txtUsrnmebox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPsswrdbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEmailbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtMblebox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}


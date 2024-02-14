using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP
{
    public partial class frm1aLogin : Form
    {
        int timeOut = 3;
        int seconds = 10;
        public frm1aLogin()
        {
            InitializeComponent();
        }

        private void cbxLoginRole_Click(object sender, EventArgs e)
        {
            //to make sure that the user can only pick the choices given and will not be able to provide personal answers
            cbxLoginRole.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txtLoginUsername_Click(object sender, EventArgs e)
        {
            //clear the text box everytime it is clicked
            txtLoginUsername.Text = String.Empty;
        }

        private void txtLoginPassword_Click(object sender, EventArgs e)
        {
            //clear the text box everytime it is clicked
            txtLoginPassword.Text = String.Empty;
        }
        private void btnLoginLogin_Click(object sender, EventArgs e)
        {
            string stat = null; //return the status of the login form.

            //if else statement to assure that users have made a selection.
            if (cbxLoginRole.SelectedIndex == -1 || txtLoginUsername.Text == "Please Enter Your Name" || txtLoginPassword.Text == "Please Enter Your Password" || txtLoginUsername.Text == "" || txtLoginPassword.Text == "")
            {
                MessageBox.Show("Incomplete information");
            }
            else
            {
                Users obj1 = new Users(txtLoginUsername.Text, txtLoginPassword.Text);
                stat = obj1.RoleSelect(cbxLoginRole.SelectedItem.ToString().ToLower());
                if (stat != null)
                {
                    MessageBox.Show(stat);
                    if (stat.Contains("Incorrect") == true && timeOut > 0)
                    {
                        timeOut--;
                        MessageBox.Show("You are given 3 attempts. Currently you have " + timeOut.ToString() + " attemps left.");
                    }
                    if (timeOut == 0)
                    {
                        MessageBox.Show("Time Out Innitiated. You will be allowed to re-enter try again after the timer runs out.");
                        cbxLoginRole.Visible = false;
                        lblLoginRole.Visible = false;
                        lblLoginUsername.Visible = false;
                        txtLoginUsername.Visible = false;
                        lblLoginPassword.Visible = false;
                        txtLoginPassword.Visible = false;
                        btnLoginLogin.Visible = false;
                        tmrTimeOut.Start();
                    }
                }

            }
            // clears both text boxes
            txtLoginUsername.Text = String.Empty;
            txtLoginPassword.Text = String.Empty;
        }

        private void tmrTimeOut_Tick(object sender, EventArgs e)
        {
            lblLoginForm.Text = seconds--.ToString() + " seconds left."; //change the text for every loop
            if (seconds < 0) //this will be executed when the time out event ends
            {
                tmrTimeOut.Stop();
                seconds = 10;
                timeOut = 3; //this will reset the attempt chances and the time out duration
                lblLoginForm.Text = "LOGIN PAGE"; //change the text back to the name of the form
                cbxLoginRole.Visible = true;
                lblLoginRole.Visible = true;
                lblLoginUsername.Visible = true;
                txtLoginUsername.Visible = true;
                lblLoginPassword.Visible = true;
                txtLoginPassword.Visible = true;
                btnLoginLogin.Visible = true; //makes all control visible again
            }
        }

        private void frm1aLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frm1dRcpServ : Form
    {
        public frm1dRcpServ()
        {
            InitializeComponent();
        }
        private string serviceDemand;
        private string action;
        private int price = 0;
        private int assure;
        private int reassure;
        public frm1dRcpServ(string a)
        {
            InitializeComponent();
            action = a;
        }
        private void frm1dRcpServ_Load(object sender, EventArgs e)
        {
            lblCustomerWelcome.Text = "You have choosen '" + action + "'.";
        }
        private void cbxCustomerUsername_Click(object sender, EventArgs e)
        {
            cbxCustomerUsername.Items.Clear();
            cbxCustomerService.Items.Clear();
            rbxCustomerNormal.Checked = false;
            rbxCustomerUrgent.Checked = false;
            txtCustomerFee.Text = String.Empty;
            btnCustomerConfirm.Visible = false;//empty all of the info inputted to avoid convoluting with the new customer requests
            cbxCustomerUsername.DropDownStyle = ComboBoxStyle.DropDownList;
            ArrayList nl = new ArrayList();
            nl = Users.addCustomerName();
            foreach (var item in nl)
            {
                cbxCustomerUsername.Items.Add(item);//add all of the values of the array list into the combo box
            }
        }

        private void cbxCustomerService_Click(object sender, EventArgs e)
        {
            cbxCustomerService.Items.Clear();
            cbxCustomerService.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCustomerService.Items.Add("Remove virus, malware or spyware");
            cbxCustomerService.Items.Add("Troubleshot and fix computer running slow");
            cbxCustomerService.Items.Add("Laptop screen replacement");
            cbxCustomerService.Items.Add("Laptop keyboard replacement");
            cbxCustomerService.Items.Add("Laptop battery replacement");
            cbxCustomerService.Items.Add("Operating System Format and Installation");
            cbxCustomerService.Items.Add("Data backup and recovery");
            cbxCustomerService.Items.Add("Internet connectivity issues");//add all of the services available into the combo box
            rbxCustomerNormal.Checked = false;
            rbxCustomerUrgent.Checked = false;//uncheck all of the radio box to prevent convolution of data
            btnCustomerConfirm.Visible = false;
        }

        private void btnCustomerConfirm_Click(object sender, EventArgs e)
        {
            if (rbxCustomerNormal.Checked == true)
            {
                reassure = 1;
            }
            else if (rbxCustomerUrgent.Checked == true)
            {
                reassure = 2;
            }
            if (assure == reassure) //assure that the radio box is changed but the new fee is not calculated
            {
                Services obj1 = new Services(cbxCustomerUsername.Text.ToString(), cbxCustomerService.Text.ToString(), serviceDemand, price, dtpServiceDate.Text.ToString());
                string status = obj1.addService(); //register the newly created service requests into the database
                MessageBox.Show(status);
                cbxCustomerUsername.Items.Clear();
                rbxCustomerNormal.Checked = false;
                rbxCustomerUrgent.Checked = false;
                txtCustomerFee.Text = String.Empty;
                cbxCustomerService.Items.Clear();//clears everything for the next service requests
            }
            else
            {
                MessageBox.Show("You have changed your desired service fee type, please recalculate the new fee before confirming.");
            }
        }

        private void btnCustomerCalculate_Click(object sender, EventArgs e)
        {

            if (cbxCustomerService.SelectedIndex == -1)//making sure that all of the info is inputted
            {
                MessageBox.Show("Incomplete");
            }
            else
            {
                if (rbxCustomerNormal.Checked == false && rbxCustomerUrgent.Checked == false)//making sure that all of the info is inputted
                {
                    MessageBox.Show("Incomplete");
                }
                else
                {
                    if (cbxCustomerService.SelectedIndex == 0)//assign the fee of the service chosen
                    {
                        if (rbxCustomerNormal.Checked == true)
                        {
                            price = 50;
                            serviceDemand = "normal";
                        }
                        else if (rbxCustomerUrgent.Checked == true)
                        {
                            price = 80;
                            serviceDemand = "urgent";
                        }
                    }
                    else if (cbxCustomerService.SelectedIndex == 1)
                    {
                        if (rbxCustomerNormal.Checked == true)
                        {
                            price = 60;
                            serviceDemand = "normal";
                        }
                        else if (rbxCustomerUrgent.Checked == true)
                        {
                            price = 90;
                            serviceDemand = "urgent";
                        }
                    }
                    else if (cbxCustomerService.SelectedIndex == 2)
                    {
                        if (rbxCustomerNormal.Checked == true)
                        {
                            price = 380;
                            serviceDemand = "normal";
                        }
                        else if (rbxCustomerUrgent.Checked == true)
                        {
                            price = 430;
                            serviceDemand = "urgent";
                        }
                    }
                    else if (cbxCustomerService.SelectedIndex == 3)
                    {
                        if (rbxCustomerNormal.Checked == true)
                        {
                            price = 160;
                            serviceDemand = "normal";
                        }
                        else if (rbxCustomerUrgent.Checked == true)
                        {
                            price = 200;
                            serviceDemand = "Urgent";
                        }
                    }
                    else if (cbxCustomerService.SelectedIndex == 4)
                    {
                        if (rbxCustomerNormal.Checked == true)
                        {
                            price = 180;
                            serviceDemand = "normal";
                        }
                        else if (rbxCustomerUrgent.Checked == true)
                        {
                            price = 210;
                            serviceDemand = "urgent";
                        }
                    }
                    else if (cbxCustomerService.SelectedIndex == 5)
                    {
                        if (rbxCustomerNormal.Checked == true)
                        {
                            price = 100;
                            serviceDemand = "normal";
                        }
                        else if (rbxCustomerUrgent.Checked == true)
                        {
                            price = 150;
                            serviceDemand = "urgent";
                        }
                    }
                    else if (cbxCustomerService.SelectedIndex == 6)
                    {
                        if (rbxCustomerNormal.Checked == true)
                        {
                            price = 80;
                            serviceDemand = "normal";
                        }
                        else if (rbxCustomerUrgent.Checked == true)
                        {
                            price = 130;
                            serviceDemand = "urgent";
                        }
                    }
                    else if (cbxCustomerService.SelectedIndex == 7)
                    {
                        if (rbxCustomerNormal.Checked == true)
                        {
                            price = 70;
                            serviceDemand = "normal";
                        }
                        else if (rbxCustomerUrgent.Checked == true)
                        {
                            price = 100;
                            serviceDemand = "urgent";
                        }
                    }
                    txtCustomerFee.Text = "The Service Fee is : RM " + price.ToString(); //change the text to show the service fee
                    if (rbxCustomerNormal.Checked == true)
                    {
                        assure = 1;
                    }
                    else if (rbxCustomerUrgent.Checked == true)
                    {
                        assure = 2;
                    }
                    btnCustomerConfirm.Visible = true;
                }
            }
        }

    }
}

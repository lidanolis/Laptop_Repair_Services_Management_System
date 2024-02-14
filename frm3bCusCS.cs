using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP
{
    public partial class frm3bCusCS : Form
    {
        int price = 0;
        string rqDate, nu;
        int servcIid;
        DateTime aDate = DateTime.Now;// Get the current time
        public static string cusName;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public void showData()// Show the updated data
        {
            con.Open();
            // Select data according the customer name and services status are pending
            SqlDataAdapter sqlda = new SqlDataAdapter("select " +
                "id, customerName, serviceType, serviceDemand, fee, requestDate, stat " +
                "from services where customerName = '" + cusName + "' and status = 'pending'", con);
            // Create a new table
            DataTable ftbl = new DataTable();
            sqlda.Fill(ftbl);// Adds the dataset into table
            dgvCusCs.AutoGenerateColumns = false;// Stop auto generate one more columns in last column
            dgvCusCs.DataSource = ftbl;// This DataGridView will display data for this table(ftb)
            con.Close();
        }

        private void dgvCusCs_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            servcIid = Convert.ToInt32(dgvCusCs.Rows[e.RowIndex].Cells[0].Value);// To get the service id
            lstCusSt.Text = dgvCusCs.Rows[e.RowIndex].Cells[2].Value.ToString();// To get the data of grid view in listbox             
        }

        public frm3bCusCS()
        {
            InitializeComponent();
        }

        public frm3bCusCS(string cn)
        {
            InitializeComponent();
            cusName = cn;
        }

        private void btnCuscm_Click(object sender, EventArgs e)// Assign the fee of the service chosen
        {
            if (lstCusSt.SelectedIndex == 0)
            {
                if (rbtnN.Checked == true)
                {
                    nu = "normal";
                    price = 50;
                    txtCheck.Text = price.ToString();
                }
                else if (rbtnU.Checked == true)
                {
                    nu = "urgent";
                    price = 80;
                    txtCheck.Text = price.ToString();
                }
            }
            else if (lstCusSt.SelectedIndex == 1)
            {
                if (rbtnN.Checked)
                {
                    nu = "normal";
                    price = 60;
                    txtCheck.Text = price.ToString();
                }
                else if (rbtnU.Checked)
                {
                    nu = "urgent";
                    price = 90;
                    txtCheck.Text = price.ToString();
                }
            }
            else if (lstCusSt.SelectedIndex == 2)
            {
                if (rbtnN.Checked)
                {
                    nu = "normal";
                    price = 380;
                    txtCheck.Text = price.ToString();
                }
                else if (rbtnU.Checked)
                {
                    nu = "urgent";
                    price = 430;
                    txtCheck.Text = price.ToString();
                }
            }
            else if (lstCusSt.SelectedIndex == 3)
            {
                if (rbtnN.Checked)
                {
                    nu = "normal";
                    price = 160;
                    txtCheck.Text = price.ToString();
                }
                else if (rbtnU.Checked)
                {
                    nu = "urgent";
                    price = 200;
                    txtCheck.Text = price.ToString();
                }
            }
            else if (lstCusSt.SelectedIndex == 4)
            {
                if (rbtnN.Checked)
                {
                    nu = "normal";
                    price = 180;
                    txtCheck.Text = price.ToString();
                }
                else if (rbtnU.Checked)
                {
                    nu = "urgent";
                    price = 210;
                    txtCheck.Text = price.ToString();
                }
            }
            else if (lstCusSt.SelectedIndex == 5)
            {
                if (rbtnN.Checked)
                {
                    nu = "normal";
                    price = 100;
                    txtCheck.Text = price.ToString();
                }
                else if (rbtnU.Checked)
                {
                    nu = "urgent";
                    price = 150;
                    txtCheck.Text = price.ToString();
                }
            }
            else if (lstCusSt.SelectedIndex == 6)
            {
                if (rbtnN.Checked)
                {
                    nu = "normal";
                    price = 80;
                    txtCheck.Text = price.ToString();
                }
                else if (rbtnU.Checked)
                {
                    nu = "urgent";
                    price = 130;
                    txtCheck.Text = price.ToString();
                }
            }
            else if (lstCusSt.SelectedIndex == 7)
            {
                if (rbtnN.Checked)
                {
                    nu = "normal";
                    price = 70;
                    txtCheck.Text = price.ToString();
                }
                else if (rbtnU.Checked)
                {
                    nu = "urgent";
                    price = 100;
                    txtCheck.Text = price.ToString();
                }
            }
        }

        private void btnUcs_Click(object sender, EventArgs e)
        {
            rqDate = aDate.ToString("yyyy-MM-dd");// Get the current time
            Services obj1 = new Services(servcIid);
            obj1.updateService(lstCusSt.Text, nu, price, rqDate);// Enter the data of changed service into database
            MessageBox.Show("Successful change!");
            txtCheck.Clear();// Clear this textbox when completed service changed
            showData();// Show the updated data
        }

        private void frm3bCusCS_Load(object sender, EventArgs e)
        {
            con.Open();
            // Select data according the customer name and services status are pending
            SqlDataAdapter sqlda = new SqlDataAdapter("select " +
                "id, customerName, serviceType, serviceDemand, fee, requestDate, stat " +
                "from services where customerName = '" + cusName + "' and status = 'pending'", con);
            DataTable ftbl = new DataTable();// Create a new table
            sqlda.Fill(ftbl);// Adds the dataset into table
            dgvCusCs.AutoGenerateColumns = false;// Stop auto generate one more columns in last column
            dgvCusCs.DataSource = ftbl;// This DataGridView will display data for this table(ftbl)
            con.Close();
        }      
    }
}

using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace IOOP
{
    public partial class frm4cAdmnInc : Form
    {
        public string username;
        public frm4cAdmnInc(string u)
        {
            InitializeComponent();
            username = u;
        }


        private void AdminMonthlyIncome_Load(object sender, EventArgs e)
        {

        } 

        private void btnAdmnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm4aAdmnHP cs = new frm4aAdmnHP (username);
            cs.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)  //use to apply the date time pickers to the services database
        {   
            string mainconn = ConfigurationManager.ConnectionStrings["myCS"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Select * from [dbo].[services] where collectionDate between '" + tpickDt1.Text + "' and '" +tpickDt2.Text+ "'"; 
            // uses the two date time pickers to collect information from the services database
            SqlCommand sqlcomm = new SqlCommand(sqlquery,sqlconn);    
            sqlconn.Open();
            DataTable dt = new DataTable(); // Create new table
            dt.Load(sqlcomm.ExecuteReader()); //Displays data for the table 
            dgvAdmnInc.DataSource = dt;
            sqlconn.Close();
        }

        private void button1_Click_1(object sender, EventArgs e) //tally up the total incomem
        {
            int sum = 0;
            for (int i = 0; i < dgvAdmnInc.Rows.Count; i++) //used for adding the sum
            {
                sum += Convert.ToInt32(dgvAdmnInc.Rows[i].Cells[4].Value); //finding the row and cell number of the database, it will convert all the income and add it together
            }
            MessageBox.Show("RM" + sum.ToString()); 
        }

        private void lblAdmntotal_Click(object sender, EventArgs e)
        {

        }

        private void lblAdmnForm_Click(object sender, EventArgs e)
        {

        }

        private void dgvAdmnInc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


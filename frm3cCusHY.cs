using System;
using System.Collections;
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
    public partial class frm3cCusHY : Form
    {
        public static string cusName;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public frm3cCusHY()
        {
            InitializeComponent();
        }

        public frm3cCusHY(string cn)
        {
            InitializeComponent();
            cusName = cn;
        }

        private void frm3bCusHY_Load(object sender, EventArgs e)
        {
            con.Open();
            // Select data according the customer name and services status were completed
            SqlDataAdapter sqlda = new SqlDataAdapter("select " +
                "id, customerName, serviceType, serviceDemand, fee, requestDate, completionDate, remark, collectionDate " +
                "from services where customerName = '" + cusName + "' and status = 'Completed'", con);
            DataTable ftbl = new DataTable();// Create a new table
            sqlda.Fill(ftbl);// Adds the dataset into table
            dgvCusRS.AutoGenerateColumns = false;// Stop auto generate one more columns in last column
            dgvCusRS.DataSource = ftbl;// This DataGridView will display data for this table(dtbl)
            con.Close();
        }

        private void dgvCusRS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP
{
    class Services
    {
        private int servID;
        private string cusName;
        private string servType;
        private string servDmd;
        private int fee;
        private string requestDt;
        private string completionDt;
        private string status;
        private string remark;
        private string collectionDt;
        private string stat;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        // GET SET method
        public string CusName { get => cusName; set => cusName = value; }
        public string ServType { get => servType; set => servType = value; }
        public string ServDmd { get => servDmd; set => servDmd = value; }
        public int Fee { get => fee; set => fee = value; }
        public string RequestDt { get => requestDt; set => requestDt = value; }
        public string CompletionDt { get => completionDt; set => completionDt = value; }
        public string Status { get => status; set => status = value; }
        public string Remark { get => remark; set => remark = value; }
        public string CollectionDt { get => collectionDt; set => collectionDt = value; }
        public string Stat { get => stat; set => stat = value; }

        public Services()
        {

        }
        public Services(int sid, string cpdt, string stat, string rmk, string coldt)
        {
            servID = sid;
            completionDt = cpdt;
            status = stat;
            remark = rmk;
            collectionDt = coldt;
        }

        public Services(int id)
        {
            servID = id;
        }

        //Receptionist

        public Services(string u, string st, string sd, int f, string rd)
        {
            CusName = u;
            ServType = st;
            ServDmd = sd;
            Fee = f;
            RequestDt = rd;
        }

        public Services(string u)
        {
            CusName = u;
        }

        public string addService()
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into services (customerName,serviceType,serviceDemand,fee,requestDate,status,stat) values " + "(@name,@st,@sd,@f,@rd,'pending','unpaid')", con);
            cmd.Parameters.AddWithValue("@name", CusName);
            cmd.Parameters.AddWithValue("@st", ServType);
            cmd.Parameters.AddWithValue("@sd", ServDmd);
            cmd.Parameters.AddWithValue("@f", Fee);
            cmd.Parameters.AddWithValue("@rd", RequestDt);

            int count = cmd.ExecuteNonQuery(); //add the info of the service requests into the database

            if (count != 0)
            {
                status = "Successful.";
            }
            else
            {
                status = "failed.";
            }
            con.Close();
            return status;
        }

        public static ArrayList customerName()
        {
            ArrayList cN = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select customerName from services where status ='Completed' and stat ='unpaid'", con); //find the customer names on all the service requests that is completed but has yet to be paid
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cN.Add(rd.GetString(0));
            }
            con.Close();
            return cN;
        }

        public static ArrayList payService(string u)
        {
            string username = u;
            ArrayList pS = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Id,serviceType,serviceDemand,fee,requestDate from services where customerName ='" + username + "' and status = 'Completed' and stat ='unpaid'", con); //output the customer services of the specific customer
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                pS.Add(rd.GetInt32(0).ToString() + "*" + rd.GetString(1) + "*" + rd.GetString(2) + "*" + rd.GetInt32(3).ToString() + "*" + rd.GetString(4)); //combine a row of value into one string
            }
            con.Close();
            return pS;
        }

        public string statChange(string ID)
        {
            string servID = ID; //receive and assign the id of the specific customer service
            string status = null;

            con.Open();
            SqlCommand cmd = new SqlCommand("Update services set stat='paid' where Id = " + ID, con); //change the stat of a customer service to 'paid'
            int count = cmd.ExecuteNonQuery();
            if (count != 0)
            {
                status = "Successful.";
            }
            else
            {
                status = "failed.";
            }
            con.Close();
            return status;
        }

        //technician
        public static ArrayList ViewUrgOrNormServ(string servDmd)   // ArrayList --> return type, will return array, servDmd --> ("Urgent" or "Normal")
        {
            ArrayList sid = new ArrayList();    // sid --> serviceID
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT Id FROM services WHERE serviceDemand='" + servDmd + "'AND status='Pending'", con);   // will filter only 'Pending' Service Request

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                sid.Add(rd.GetInt32(0));    // Id is (int) data type in database
            }
            con.Close();
            return sid;
        }

        public static void DisplayServInfo(Services o1)     // Student --> return type, will return object
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT serviceType, requestDate FROM services WHERE Id= '" + o1.servID.ToString() + "'", con);

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                o1.servType = rd.GetString(0);
                o1.requestDt = rd.GetString(1);
            }
            con.Close();
        }

        public static string UpdFinServInfo(Services o1)
        {
            string alert;

            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE services SET completionDate='" + o1.completionDt + "', status='" + o1.status + "', remark='" + o1.remark + "', collectionDate='" + o1.collectionDt + "' WHERE Id= '" + o1.servID.ToString() + "'", con);

            int x = cmd.ExecuteNonQuery();
            if (x != 0)
                alert = "Service Record Update Successfully !";
            else
                alert = "Service Record Update Failed !";
            con.Close();
            return alert;
        }

        public static ArrayList ViewAllServ()
        {
            ArrayList allsid = new ArrayList();     // allsid --> all serviceID
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT Id FROM services", con);  // select all serviceID

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                allsid.Add(rd.GetInt32(0));
            }
            con.Close();
            return allsid;
        }

        public static void DisplayServRpInfo(Services o1)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT completionDate, status, remark, collectionDate FROM services WHERE Id= '" + o1.servID.ToString() + "'", con);

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                if (rd.IsDBNull(0))
                    o1.completionDt = null;
                else
                    o1.completionDt = rd.GetString(0);

                o1.status = rd.GetString(1);

                if (rd.IsDBNull(2))
                    o1.remark = null;
                else
                    o1.remark = rd.GetString(2);

                if (rd.IsDBNull(3))
                    o1.collectionDt = null;
                else
                    o1.collectionDt = rd.GetString(3);
            }
            con.Close();
        }

        public static string DeleteServRec(Services o1)
        {
            string alert;

            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM services WHERE Id='" + o1.servID.ToString() + "'", con);

            int x = cmd.ExecuteNonQuery();
            if (x != 0)
                alert = "Service Record Deletion Successful !";
            else
                alert = "Service Record Deletion Failed !";
            con.Close();
            return alert;
        }

        //customer
        public void updateService (string sv, string dm, int f, string rd)
        {           
            con.Open();
            servType = sv;
            servDmd = dm;
            fee = f;
            requestDt = rd;
            // Update the data of requested service
            SqlCommand cmd = new SqlCommand("update services set serviceType ='" + servType + "', " +
                "serviceDemand='" + servDmd + "', fee='" + fee + "', " +
                "requestDate='" + requestDt + "', stat = 'unpaid' where Id='" + servID + "'", con);
            cmd.ExecuteNonQuery(); 
            con.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP
{
    class Profiles
    {
        private int profID;
        private string name;
        private string email;
        private string phoneNum;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        // GET SET method
        public int ProfID { get => profID; set => profID = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }

        public Profiles(string n, string e, string num)
        {
            name = n;
            email = e;
            phoneNum = num;
        }

        public Profiles(string n)
        {
            name = n;
        }
        public static void viewCusProfile(Profiles o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from profiles where username ='" + o1.name + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            
            while (rd.Read())
            {               
                o1.email = rd.GetString(2);// Get email
                o1.phoneNum = rd.GetString(3);// Get phonenumber
            }
            con.Close();
        }

        public string updateCusProfile(string em, string num)
        {
            string status;
            con.Open();

            email = em;
            phoneNum = num;
            SqlCommand cmd = new SqlCommand("update profiles set email ='" + email + "',phoneNumber='" + phoneNum + "' where username ='" + name + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Update Successfully.";
            else
                status = "Unable to update.";
            con.Close();

            return status;
        }
    }
}

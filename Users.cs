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
    class Users
    {
        private int userID;
        private string username;
        private string password;
        private string role;
        private string email;
        private string phonenum;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        // GET SET method
        public int UserID { get => userID; set => userID = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNum { get => phonenum; set => phonenum = value; }

        //this constructor will be needed for the login feature as well:
        public Users(string u, string p)
        {
            Username = u;// receive the inputted username and password
            Password = p;
        }
        public Users(string us, string ps, string em, string pn, string ro)
        {
            Username = us;//receive all of the info regarding the user
            Password = ps;
            Email = em;
            PhoneNum = pn;
            Role = ro;
        }

        public string RoleSelect(string r)
        {
            Role = r; //the role the user is assigned to
            string status = null;
            string check = null;

            con.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from users where username = '" + username + "'and role ='" + role + "'", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString()); //check if the username exist within the database

            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("Select password from users where username = '" + username + "'and role ='" + role + "'", con);
                check = cmd2.ExecuteScalar().ToString(); //check the validity of the password inputted by the user
                con.Close();

                if (password == check)
                {

                    if (role == "admin") //redirect users to the corresponding form based on the role 
                    {
                        frm4aAdmnHP objc1 = new frm4aAdmnHP(username);
                        objc1.ShowDialog();
                    }
                    else if (role == "customer")
                    {
                        frm3aCusHP obj1 = new frm3aCusHP(username);
                        obj1.ShowDialog();
                    }
                    else if (role == "receptionist")
                    {
                        frm1bRcpHP obj1 = new frm1bRcpHP(username);
                        obj1.ShowDialog();
                    }
                    else if (role == "technician")
                    {
                        frm2aTechHP obj1 = new frm2aTechHP(username);
                        obj1.ShowDialog();
                    }
                }
                else
                {
                    status = "Incorrect Password";
                }
            }
            else
            {
                status = "Incorrect info given. No " + role + " named " + username;
            }
            con.Close();
            return status;
        }

        public string registerNewCustomer()
        {
            string status = null;
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from users where username = '" + Username + "'", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString()); // check if the username exist within the database

            if (count == 0) //will only occur if no username exist (meaning that the username inputted is new)
            {
                SqlCommand cmd2 = new SqlCommand("Insert into users(username,password,role) values(@name,@password,'customer')", con);//insert the username and password into the database
                cmd2.Parameters.AddWithValue("@name", Username);//to prevent sql injections 
                cmd2.Parameters.AddWithValue("@password", Password);
                int register = cmd2.ExecuteNonQuery(); //this will determine if the database is changed
                if (register != 0) //the databse is changed (the new customer is added)
                {
                    status = "Registered Successfully";
                    SqlCommand cmd3 = new SqlCommand("Insert into profiles(username,email,phoneNumber) values(@name,'n/a','n/a')", con);//add a corresponding row into the "profiles" table
                    cmd3.Parameters.AddWithValue("@name", Username);
                    cmd3.ExecuteNonQuery();
                }
                else
                {
                    status = "Unable To Register";
                }
            }

            else
            {
                status = "This username has already been registered, try another.";
            }
            con.Close();
            return status;
        }

        public string registerNewAdmin()
        {
            string status = null;
            con.Open();
            SqlCommand cmd4 = new SqlCommand("select count(*) from users where username = '" + Username + "'", con);
            int count = Convert.ToInt32(cmd4.ExecuteScalar().ToString()); //used for checking on the different usernames that might exist

            if (count == 0) //will only show if the user has not existed before, if it has it will drop down to else
            {
                SqlCommand cmd5 = new SqlCommand("Insert into users(username,password,role) values(@name,@password,@role)", con); //adds the name, password and role into the database of Users 
                cmd5.Parameters.AddWithValue("@name", Username);
                cmd5.Parameters.AddWithValue("@password", Password);
                cmd5.Parameters.AddWithValue("@role", Role);
                /*cm5.ExecuteNonQuery();*/
                int register = cmd5.ExecuteNonQuery();
                if (register != 0) //shows if the customer has been succesfully added (which will cause the if statement to work and register into the database)
                {
                    status = "Registered Successfully";
                    SqlCommand cmd6 = new SqlCommand("Insert into profiles(username,email,phoneNumber) values(@name,@email,@phoneNumber)", con); //adds the name,email and phone number into database of Profiles
                    cmd6.Parameters.AddWithValue("@name", Username);
                    cmd6.Parameters.AddWithValue("@email", Email);
                    cmd6.Parameters.AddWithValue("@phoneNumber", PhoneNum);
                    cmd6.ExecuteNonQuery();
                }
                else
                {
                    status = "Unable To Register";  //if error occurs or if statement doesnt work, drops to else statement
                }
            }

            else
            {
                status = "This username has already been registered, try another.";
            }
            con.Close();
            return status;

        }

        public static ArrayList addCustomerName()
        {
            ArrayList nl = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select username from users where role ='customer'", con);//find the usernames of all registered customers
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nl.Add(rd.GetString(0));//add the list of names into a array list
            }
            con.Close();
            return nl;
        }
    }
}

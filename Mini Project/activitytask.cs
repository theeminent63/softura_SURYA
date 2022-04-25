using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Dataa
{
    class activitytask
    {
        class product
        {
            public void ProdDetails()
            {
                SqlConnection con = new SqlConnection("data source = DESKTOP-RRCVLCD; database = Trial; user ID = sa; password = P@ssw0rd ");
                SqlCommand cmd = new SqlCommand("select Prod_ID,Prod_Name,dbo.fn_rupis(Price) as Price,Manufac_Date,Exp_Date from Product", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("ID: " + dr[0] + " |Name: " + dr[1] + " |Price: " + dr[2] + " |Manufactured Date: " + dr[3] + " |Expiry Date :" + dr[4]);
                }
                con.Close();
            }
            public int bill(int proId, int units)
            {
                SqlConnection con = new SqlConnection("data source = DESKTOP-RRCVLCD; database = Trial; user ID = sa; password = P@ssw0rd ");
                int Quantity = units;
                SqlCommand cmd1 = new SqlCommand("select Price*" + Quantity + "from Product where Prod_ID=" + proId + "", con);
                con.Open();
                SqlDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    int tot = Convert.ToInt32(dr[0]);
                    return tot;
                }
                con.Close();
                return 0;
            }
            public void InsPurchase(int proId, int units, int custId, int total)
            {
                SqlConnection con = new SqlConnection("data source = DESKTOP-RRCVLCD; database = Trial; user ID = sa; password = P@ssw0rd ");
                SqlCommand cmd = new SqlCommand("insert Purchase values(" + custId + "," + proId + "," + units + "," + total + ",getdate()) ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            public void ShowBill()
            {
                SqlConnection con = new SqlConnection("data source = DESKTOP-RRCVLCD; database = Trial; user ID = sa; password = P@ssw0rd ");
                SqlCommand cmd = new SqlCommand("select top 1 Bill_No,Cust_ID,Prod_ID,Quantity,Total_Amount from Purchase  order by Bill_No desc ", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Bill NO: " + dr[0] + " |Customer ID: " + dr[1] + " |Product ID: " + dr[2] + " |Quantity: " + dr[3] + " |Total Amount:Rs." + dr[4]);
                }
                con.Close();
            }
            public void CusPurDetails(int custId)
            {
                SqlConnection con = new SqlConnection("data source = DESKTOP-RRCVLCD; database = Trial; user ID = sa; password = P@ssw0rd ");
                SqlCommand cmd = new SqlCommand("select Bill_No,Cust_ID,Prod_ID,Quantity,Total_Amount from Purchase where Cust_ID = " + custId + "", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Bill NO: " + dr[0] + " |Customer ID: " + dr[1] + " |Product ID: " + dr[2] + " |Quantity: " + dr[3] + " |Total Amount :Rs." + dr[4]);
                }
                con.Close();
            }
            public void CusPurDetailsByDate(int custId)
            {
                SqlConnection con = new SqlConnection("data source = DESKTOP-RRCVLCD; database = Trial; user ID = sa; password = P@ssw0rd ");
                SqlCommand cmd = new SqlCommand("select * from Purchase where Cust_ID =" + custId + " order by Pur_Date", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Bill No: " + dr[0] + " |Customer ID: " + dr[1] + " |Product ID: " + dr[2] + " |Quuantity: " + dr[3] + " |Total Amount :Rs." + dr[4] + " |Purchased Date :" + dr[5]);
                }
                con.Close();
            }
        }
        class customer : product
        {
            public void ValidateCustID(int custId)
            {
                SqlConnection con = new SqlConnection("data source = DESKTOP-RRCVLCD; database = Trial; user ID = sa; password = P@ssw0rd ");
                SqlCommand cmd = new SqlCommand("select Name from Customer where Cust_ID=" + custId + "", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("\n" + "Customer Name: " + dr[0]);
                }
                if (dr.HasRows)
                {
                    con.Close();
                    Console.WriteLine("\n" + "**The Product List******");
                    ProdDetails();
                }
                else
                {
                    Console.WriteLine("**Oops,You'r not in the Existing Customer*" + "\n" + "*Let's Register New**");
                    Console.WriteLine("Enter the Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the Gender(M/F):");
                    char gender = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Enter the Date of Birth:");
                    string Dob = Console.ReadLine();
                    Console.WriteLine("Enter Contact Number:");
                    string contact = Console.ReadLine();
                    Console.WriteLine("Enter the MailID:");
                    string mail = Console.ReadLine();
                    Console.WriteLine("Enter the City: Choose from," + "\n" + "1.Chennai" + "\n" + "2.Mumbai" + "\n" + "3.Kolkata" + "\n" + "4.Delhi");
                    string city = Console.ReadLine();
                    CustomerNew(name, gender, Dob, contact, mail, city);
                }
            }
            public void CustomerNew(string name, char gender, string Dob, string contact, string mail, string city)
            {
                SqlConnection con = new SqlConnection("data source = DESKTOP-RRCVLCD; database = Trial; user ID = sa; password = P@ssw0rd ");
                SqlCommand cmd = new SqlCommand("CustomerIns", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@gender", SqlDbType.Char).Value = gender;
                cmd.Parameters.Add("@Dob", SqlDbType.VarChar).Value = Dob;
                cmd.Parameters.Add("@contact", SqlDbType.Char).Value = contact;
                cmd.Parameters.Add("mail", SqlDbType.VarChar).Value = mail;
                cmd.Parameters.Add("@city", SqlDbType.VarChar).Value = city;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("\n" + "New Customer Added");
            }

        }
        public static void Main()
        {
            customer obj = new customer();
            Console.WriteLine("Enter the Customer ID:");
            int custId = Convert.ToInt32(Console.ReadLine());
            obj.ValidateCustID(custId);
            //To show the current purchase Bill
            Console.WriteLine("\n" + "Enter The Product ID You Want:");
            int proId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How Many Units:");
            int units = Convert.ToInt32(Console.ReadLine());
            int total = obj.bill(proId, units);
            obj.InsPurchase(proId, units, custId, total);
            Console.WriteLine("\n" + "**Current Bill**");
            obj.ShowBill();
            Console.WriteLine("\n" + "* Show All Purchase Details By Customer ID***");
            obj.CusPurDetails(custId);
            Console.WriteLine("\n" + "***Show Customer Purchase Details by Date");
            obj.CusPurDetailsByDate(custId);
        }
    }
}
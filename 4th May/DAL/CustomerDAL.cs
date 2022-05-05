using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using AdoMVC.Models;
using System.Data.SqlClient;
using System.Data;

namespace AdoMVC.DAL
{
    public class CustomerDAL
    {
        public string cnn = "";
        public CustomerDAL()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                (Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            cnn = builder.GetSection("ConnectionStrings:Conn").Value;
        }
        public List<Customer> GetAllCustomers()
        {
            List<Customer> listCustomer = new List<Customer>();
            using (SqlConnection con = new SqlConnection(cnn))
            {
                using (SqlCommand cmd = new SqlCommand("GetAllCustomers", con))
                {
                    if (con.State == System.Data.ConnectionState.Closed)
                        con.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listCustomer.Add(new Customer()
                        {
                            CustomerID = int.Parse(reader["CustomerID"].ToString()),
                            CustomerName = reader["CustomerName"].ToString(),
                            EmailID = reader["EmailID"].ToString(),
                            MobileNo = reader["MobileNo"].ToString()
                        });
                    }
                }
            }
            return listCustomer;
        }
        public int NewCustomer(Customer obj)
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("NewCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cname", obj.CustomerName);
            cmd.Parameters.AddWithValue("@email", obj.EmailID);
            cmd.Parameters.AddWithValue("@mobno", obj.MobileNo);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public int DelCustomer(Customer obj)
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("DelCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", obj.CustomerID);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public int UpdCustomer(Customer obj)
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("UpdCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", obj.CustomerID);
            cmd.Parameters.AddWithValue("@cname", obj.CustomerName);
            cmd.Parameters.AddWithValue("@email", obj.EmailID);
            cmd.Parameters.AddWithValue("@mobno", obj.MobileNo);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Data.SqlClient;
using CMSProj.Models;
using System.Data;

namespace CMSProj.DAL
{
    public class ClassDAL
    {
        public string cnn = "";
        public ClassDAL()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            cnn = builder.GetSection("ConnectionStrings:con").Value;
        }

        public int DoctorAd(AddDoctor doc)
        {
            int result;
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("SPadddoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FName", doc.FirstName);
            cmd.Parameters.AddWithValue("@LName", doc.LastName);
            cmd.Parameters.AddWithValue("@sex ", doc.Sex);
            cmd.Parameters.AddWithValue("@spec", doc.Specialization);
            cmd.Parameters.AddWithValue("@visitingHrs", doc.VisitingHours);
            con.Open();
            result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        public int PatientAd(AddPatient pat)
        {

            int result;
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("SPaddpatient", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PFname", pat.PFirstName);
            cmd.Parameters.AddWithValue("@PLname", pat.PLastName);
            cmd.Parameters.AddWithValue("@sex", pat.Sex);
            cmd.Parameters.AddWithValue("@age", pat.Age);
            cmd.Parameters.AddWithValue("@DOB", pat.DateOfBirth);
            con.Open();
            result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        public int AppointmentAd(AddApointment apo)
        {
            int result;
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("SPapp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PID", apo.PatientID);
            cmd.Parameters.AddWithValue("@spec", apo.Sepcialization);
            cmd.Parameters.AddWithValue("@doc", apo.Doctor);
            cmd.Parameters.AddWithValue("@vd", apo.VisitDate);
            cmd.Parameters.AddWithValue("@aptime", apo.AppointmentTime);
            con.Open();
            result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public int DeleteData(AddApointment can)
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("cancelapointment", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@patientid", can.PatientID);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public List<AddApointment> cancelapointment()
        {
            List<AddApointment> listPatient = new List<AddApointment>();
            using (SqlConnection con = new SqlConnection(cnn))
            {
                using (SqlCommand cmd = new SqlCommand("display", con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listPatient.Add(new AddApointment()
                        {
                            PatientID = int.Parse(reader["PatientID"].ToString()),
                            Sepcialization = reader["Sepcialization"].ToString(),
                            Doctor = reader["Doctor"].ToString(),
                            VisitDate = reader["VisitDate"].ToString(),
                            AppointmentTime = reader["AppointmentTime"].ToString(),
                        });
                    }
                }
            }
            return listPatient;
        }
        public List<AddDoctor> CheckDoctor()
        {
            List<AddDoctor> listPatient = new List<AddDoctor>();
            using (SqlConnection con = new SqlConnection(cnn))
            {
                using (SqlCommand cmd = new SqlCommand("disp", con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listPatient.Add(new AddDoctor()
                        {
                            FirstName = reader["FirstName"].ToString(),
                            Sex = reader["Sex"].ToString(),
                            Specialization = reader["Specialization"].ToString(),
                            VisitingHours = reader["VisitingHours"].ToString()
                        });
                    }
                }
            }
            return listPatient;
        }
        public int CheckUse(login us)
        {
            
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("loginUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UName", us.UserName);
            cmd.Parameters.AddWithValue("@Pword", us.Password);
            con.Open();
            IDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                return (1);
            }
            con.Close();
            return (0);
        }
    }
}

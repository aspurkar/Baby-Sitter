using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using BusinessObject;

namespace DataLayer
{
    public class SignUp : ISignUp
    {
        private static SqlConnection con;

        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["myConsting"].ToString();
            con = new SqlConnection(constr);
        }

        public int gurdianSignUp(Gurdian gurdian)
        {
            connection();
            SqlCommand com = new SqlCommand("gurdianSignUp", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@email", gurdian.email);
            com.Parameters.AddWithValue("@firstName", gurdian.firstName);
            com.Parameters.AddWithValue("@lstName", gurdian.lstName);
            com.Parameters.AddWithValue("@city", gurdian.city);
            com.Parameters.AddWithValue("@state", gurdian.state);
            com.Parameters.AddWithValue("@password", gurdian.password);
            com.Parameters.AddWithValue("@image", gurdian.image);
            com.Parameters.AddWithValue("@country", gurdian.country);
            com.Parameters.AddWithValue("@contactNo", gurdian.contactNo);
            com.Parameters.AddWithValue("@about", gurdian.about);
            int i=-1;
            con.Open();
            try
            {
              i=  com.ExecuteNonQuery();
            }
            catch (SqlException e) {
                System.Diagnostics.Debug.Write(e);
            }

            return i;
        }

        public int sitterSignUp(Sitter sitter)
        {

            connection();
            SqlCommand com = new SqlCommand("sitterSignUp", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@email", sitter.email);
            com.Parameters.AddWithValue("@firstName", sitter.firstName);
            com.Parameters.AddWithValue("@lstName", sitter.lstName);
            com.Parameters.AddWithValue("@password", sitter.password);
            com.Parameters.AddWithValue("@city", sitter.city);
            com.Parameters.AddWithValue("@state", sitter.state);
            com.Parameters.AddWithValue("@country", sitter.country);
            com.Parameters.AddWithValue("@salaryRange", sitter.salaryRange);
            com.Parameters.AddWithValue("@about", sitter.about);
            com.Parameters.AddWithValue("@gender", sitter.gender);
            com.Parameters.AddWithValue("@isMarried", sitter.isMarried);
            com.Parameters.AddWithValue("@birthDate", sitter.birthDate);
            com.Parameters.AddWithValue("@age", sitter.age);
            com.Parameters.AddWithValue("@image", sitter.image);
            com.Parameters.AddWithValue("@contactNo", sitter.contactNo);


            int i=-1;
         con.Open();
            try
            {
                 i = com.ExecuteNonQuery();
            }
            catch (SqlException e) {
                Console.Write(e);
            }

                con.Close();
            if (i >= 1)
            {

                return 1;

            }
            else
            {

                return -1;
            }


        }
    }
}

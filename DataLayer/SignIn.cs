using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataLayer
{
    public class SignIn : ISignIn
    {
        private static SqlConnection con;
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["myConsting"].ToString();
            con = new SqlConnection(constr);
        }

        public UserDataVO checkPassword(LoginVO model)
        {

            int type = -1;
            connection();
            SqlCommand com = new SqlCommand("checkPassGurd", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@email", model.email);
            SqlDataReader reader;
            string pass = null;
            BusinessObject.UserDataVO userDataVO = new BusinessObject.UserDataVO();
            userDataVO.Gmodel = new Gurdian();
            userDataVO.Smodel = new Sitter();
            userDataVO.type = -1;


            con.Open();
            try
            {
                pass = (string)com.ExecuteScalar();

                if (pass != null)
                    type = 0;
            }
            catch (SqlException e)
            {
                System.Diagnostics.Debug.Write(e);
            }
            con.Close();



            if (pass == null)
            {
                SqlCommand com1 = new SqlCommand("checkPassSitter", con);
                com1.CommandType = CommandType.StoredProcedure;

                com1.Parameters.AddWithValue("@email", model.email);





                try
                {
                    con.Open();
                    pass = (string)com1.ExecuteScalar();
                    if (pass != null)
                        type = 1;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.Write(e);
                }
                con.Close();

            }

            //----------------------------------------------------------------
            /*
                        if (type == -1)
                        {

                            userDataVO.type = -1;

                            return userDataVO;
                        }
                        else if (type == 0)
                        {


                            SqlCommand comGetGurd = new SqlCommand("getGurdian", con);
                            comGetGurd.CommandType = CommandType.StoredProcedure;

                            comGetGurd.Parameters.AddWithValue("@email", model.email);





                            try
                            {
                                con.Open();
                                reader = comGetGurd.ExecuteReader();

                                while (reader.Read())
                                {

                                    userDataVO.Gmodel.email = (string) reader["email"];
                                    userDataVO.Gmodel.firstName = reader["firstName"].ToString();
                                    userDataVO.Gmodel.lstName = reader["lstName"].ToString();
                                    userDataVO.Gmodel.city = reader["city"].ToString();
                                    userDataVO.Gmodel.state = reader["state"].ToString();
                                    userDataVO.Gmodel.password = reader["password"].ToString();
                                    userDataVO.Gmodel.image = (Byte[])reader["image"];
                                    userDataVO.Gmodel.country = reader["country"].ToString();
                                    userDataVO.Gmodel.contactNo = reader["contactNo"].ToString();
                                    userDataVO.Gmodel.about = reader["about"].ToString();


                                };
                                userDataVO.type = 0;

                            }
                            catch (SqlException e)
                            {
                                System.Diagnostics.Debug.Write(e);
                            }
                            con.Close();

                            return userDataVO;
                        }
                        else if(type==1) {


                            SqlCommand comGetSitter = new SqlCommand("getSitters", con);
                            comGetSitter.CommandType = CommandType.StoredProcedure;

                            comGetSitter.Parameters.AddWithValue("@email", model.email);





                            try
                            {
                                con.Open();
                                reader = comGetSitter.ExecuteReader();

                                while (reader.Read())
                                {
                                    userDataVO.Smodel.email = reader["email"].ToString();
                                    userDataVO.Smodel.firstName = reader["firstName"].ToString();
                                    userDataVO.Smodel.lstName = reader["lstName"].ToString();
                                    userDataVO.Smodel.password     = reader["password"].ToString();
                                    userDataVO.Smodel.city = reader["city"].ToString();
                                    userDataVO.Smodel.state =  reader["state"].ToString();
                                    userDataVO.Smodel.country     = reader["country"].ToString();
                                    userDataVO.Smodel.salaryRange     = reader["salaryRange"].ToString();
                                    userDataVO.Smodel.about   = reader["about"].ToString();
                                    userDataVO.Smodel.gender  =       reader["gender"].ToString();
                                    userDataVO.Smodel.isMarried = (bool) reader["isMarried"];
                                    userDataVO.Smodel.birthDate = reader["birthDate"].ToString();
                                    userDataVO.Smodel.age = (int) reader["birthDate"];
                                    userDataVO.Smodel.image = (Byte[])reader["image"];
                                    userDataVO.Smodel.contactNo = reader["contactNo"].ToString();
                                };
                                userDataVO.type = 1;

                            }
                            catch (SqlException e)
                            {
                                System.Diagnostics.Debug.Write(e);
                            }
                            con.Close();

                            return userDataVO;





                        }

                        userDataVO.type = -1;
                        return userDataVO;
    */
            System.Diagnostics.Debug.Write(type);
            

            //---------------------------------------------
            if (type == 1) {
                userDataVO.type = type;


                SqlCommand comGetSitter = new SqlCommand("getSitter", con);
                comGetSitter.CommandType = CommandType.StoredProcedure;

                comGetSitter.Parameters.AddWithValue("@email", model.email);





                try
                {
                    con.Open();
                    reader = comGetSitter.ExecuteReader();

                    while (reader.Read())
                    {

                        userDataVO.Smodel.email = reader["email"].ToString();
                        userDataVO.Smodel.firstName = reader["firstName"].ToString();
                        userDataVO.Smodel.lstName = reader["lstName"].ToString();
                        userDataVO.Smodel.password = reader["password"].ToString();
                        userDataVO.Smodel.city = reader["city"].ToString();
                        userDataVO.Smodel.state = reader["state"].ToString();
                        userDataVO.Smodel.country = reader["country"].ToString();
                        userDataVO.Smodel.salaryRange = reader["salaryRange"].ToString();
                        userDataVO.Smodel.about = reader["about"].ToString();
                        userDataVO.Smodel.gender = reader["gender"].ToString();
                        userDataVO.Smodel.isMarried = (bool)reader["isMarried"];
                        userDataVO.Smodel.birthDate = reader["birthDate"].ToString();
                        userDataVO.Smodel.age = (int)reader["age"];
                        userDataVO.Smodel.image = (Byte[])reader["image"];
                        userDataVO.Smodel.contactNo = reader["contactNo"].ToString();


                    };


                }
                catch (SqlException e)
                {
                    System.Diagnostics.Debug.Write(e);
                }
                con.Close();










            }

            //----------------------------------------------
            else if (type == 0)
            {
                userDataVO.type = type;
                SqlCommand comGetGurd = new SqlCommand("getGurdian", con);
                comGetGurd.CommandType = CommandType.StoredProcedure;

                comGetGurd.Parameters.AddWithValue("@email", model.email);





                try
                {
                    con.Open();
                    reader = comGetGurd.ExecuteReader();

                    while (reader.Read())
                    {

                        userDataVO.Gmodel.email = (string)reader["email"];
                        userDataVO.Gmodel.firstName = reader["firstName"].ToString();
                        userDataVO.Gmodel.lstName = reader["lstName"].ToString();
                        userDataVO.Gmodel.city = reader["city"].ToString();
                        userDataVO.Gmodel.state = reader["state"].ToString();
                        userDataVO.Gmodel.password = reader["password"].ToString();
                        userDataVO.Gmodel.image = (Byte[])reader["image"];
                        userDataVO.Gmodel.country = reader["country"].ToString();
                        userDataVO.Gmodel.contactNo = reader["contactNo"].ToString();
                        userDataVO.Gmodel.about = reader["about"].ToString();


                    };
                 

                }
                catch (SqlException e)
                {
                    System.Diagnostics.Debug.Write(e);
                }
                con.Close();



            }


            //----------------------------------------------
            else {
                userDataVO.type = -1;




            }



            //----------------------------------------------



            return userDataVO;

        }
    }
    }


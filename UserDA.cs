using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BussinessObject;

namespace DataAccess
{
    public class UserDA
    {
        string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
        //SqlConnection sqlConnection = new SqlConnection("constr");
        #region using command parameters
        //public int AddUserDetails(User usr)
        //{
        //    using (SqlConnection sqlconnection = new SqlConnection(constr))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("3Tier"))
        //        {
        //            try
        //            {
        //                cmd.Connection = sqlconnection;
        //                sqlconnection.Open();
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.AddWithValue("@commandtype", "Save");

        //                //cmd.Parameters.AddWithValue("@businessid", usr.businessId);
        //                //cmd.Parameters.AddWithValue("@name", usr.Name);
        //                //cmd.Parameters.AddWithValue("@Address", usr.Address);
        //                //cmd.Parameters.AddWithValue("@Sex", usr.Sex);
        //                //cmd.Parameters.AddWithValue("@Cource", usr.Cource);
        //                //cmd.Parameters.AddWithValue("@MobileNumber", usr.MobileNumber);
                        
                       
                       
        //                int result = cmd.ExecuteNonQuery();
        //                return result;
                       
        //            }
        //            catch
        //            {
        //                throw;
        //            }
        //        }


        //    }

        //}
        #endregion
        public int AddUserDetails(List<SqlParameter> sqlParameter,string procedureName)
        {
            using (SqlConnection sqlconnection = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(procedureName))
                {
                    try
                    {
                        cmd.Connection = sqlconnection;
                        sqlconnection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@commandtype", "Save");
                        foreach (var param in sqlParameter)
                        {
                            cmd.Parameters.Add(param);
                        }
                        int result = cmd.ExecuteNonQuery();
                        return result;
                        cmd.Parameters.Clear();
                    }
                    catch
                    {
                        throw;
                    }
                }


            }

        }

        public DataSet GetDataById(int Id)
        {
            using (SqlConnection sqlconnection = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("3Tier"))
                {
                    cmd.Parameters.AddWithValue("@commandtype", "GetUserById");
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        cmd.Parameters.AddWithValue("@businessId", Id);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = sqlconnection;
                        da.SelectCommand = cmd;
                        using (DataSet ds = new DataSet())
                        {
                            da.Fill(ds);
                            return ds;
                        }
                    }

                }

            }

        }
        public DataSet GetData()
        {
            using (SqlConnection sqlconnection = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("3Tier"))
                {
                    cmd.Parameters.AddWithValue("@commandtype", "GetUser");
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = sqlconnection;
                        da.SelectCommand = cmd;
                        using (DataSet ds = new DataSet())
                        {
                            da.Fill(ds);
                            return ds;
                        }
                    }

                }

            }

        }
    }
}


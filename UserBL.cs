using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using BussinessObject;
using System.Data;
using System.Data.SqlClient;

namespace BussinessLogic
{
   public class UserBL
    {
       public int AddUserregisterBL(User objUserbo)
       {
           try
           {
               
               UserDA objUserda = new UserDA();
             List<SqlParameter> sqlparameter=  AddParam(objUserbo);
               return objUserda.AddUserDetails(sqlparameter,"3tier");

           }
           catch
           {
               throw;
           }

       }
       
       public DataSet GetDataById(int Id)
       {
           try
           {
               UserDA objUserda = new UserDA();
               return objUserda.GetDataById(Id);
           }
           catch
           {
               throw;
           }
       }
       public DataSet GetData()
       {
           try
           {
               UserDA objUserda = new UserDA();
               return objUserda.GetData();
           }
           catch
           {
               throw;
           }
       }
      private List<SqlParameter> AddParam<T>(T entityObject)
       {
           List<SqlParameter> sqlparameters = new List<SqlParameter>();
           foreach (var property in entityObject.GetType().GetProperties())
           {
               SqlParameter sqlparameter = new SqlParameter("@" + property.Name, property.GetValue(entityObject));
               sqlparameters.Add(sqlparameter);
           }
           return sqlparameters;
       }
       
    }
}
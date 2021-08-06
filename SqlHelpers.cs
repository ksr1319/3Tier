using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BussinessObject;

namespace DataAccess
{
    public class SqlHelpers
    {
        public List<SqlParameter> AddParam<T>(T entityObject)
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

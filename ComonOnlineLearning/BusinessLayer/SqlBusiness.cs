using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComonOnlineLearning.BusinessLayer
{
    public class SqlBusiness
    {
        public  SqlParameter SetSqlParameter(string columnName, int id)
        {
            return new SqlParameter(columnName, id);
        }
        public  string JoinSqlParameterToStoreProc(string storedProcName, string columnName)
        {
            return $"{storedProcName} @{columnName}";
        }

    }
}

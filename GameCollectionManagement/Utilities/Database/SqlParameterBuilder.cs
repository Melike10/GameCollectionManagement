using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionManagement.Utilities.Database
{
    public class SqlParameterBuilder
    {
        private List<SqlParameter> _parameters = new List<SqlParameter>();

        public SqlParameterBuilder AddParameter(string name, object value)
        {  
            _parameters.Add(new SqlParameter(name, value ?? DBNull.Value));
            return this; 
        }
        public SqlParameterBuilder AddParameterWithValue(string name, object value,SqlDbType dbType)
        {
            _parameters.Add(new SqlParameter(name, dbType) { Value = value ?? DBNull.Value });
            return this;
        }
        public SqlParameter[] Build()
        {
            return _parameters.ToArray();
        }
    }
}

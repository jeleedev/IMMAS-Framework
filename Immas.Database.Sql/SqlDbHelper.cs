using System.Data;
using System.Data.SqlClient;

namespace Immas.Database.Sql
{
    public class SqlDbHelper : BaseDBHelper
    {
        public SqlDbHelper(string dbName, string connectionString) : base(dbName, connectionString)
        {
            this.parameterConvertor = new SqlParameterConvertor();
        }

        protected override IDbConnection CreateConnection()
        {
            return new SqlConnection(this.ConnectionString);
        }

        protected override IDbCommand CreateCommand()
        {
            return new SqlCommand();
        }

        protected override IDbDataAdapter CreateDataAdapter()
        {
            return new SqlDataAdapter();
        }
    }
}

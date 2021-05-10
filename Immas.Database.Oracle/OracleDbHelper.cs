using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Immas.Database.Oracle
{
    public class OracleDbHelper : BaseDBHelper
    {
        public OracleDbHelper(string dbName, string connectionString) : base(dbName, connectionString)
        {
            this.parameterConvertor = new OracleParameterConvertor();
        }

        protected override IDbConnection CreateConnection()
        {
            return new OracleConnection(this.ConnectionString);
        }

        protected override IDbCommand CreateCommand()
        {
            return new OracleCommand();
        }

        protected override IDbDataAdapter CreateDataAdapter()
        {
            return new OracleDataAdapter();
        }
    }
}

using Immas.Common;

namespace Immas.Database.Oracle
{
    public class OracleDbHelperFactory : BaseDbHelperFactory
    {
        public override IDBHelper Create(string dbName, string connectionString)
        {
            IDBHelper helper = AssemblyUtil.CreateInstance<IDBHelper>
            (
                "Immas.Database.Oracle.dll",
                "Immas.Database.Oracle.OracleDbHelper",
                dbName,
                connectionString
            );
            return helper;
        }
    }
}

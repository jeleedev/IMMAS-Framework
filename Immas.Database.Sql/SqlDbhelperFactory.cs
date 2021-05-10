using Immas.Common;

namespace Immas.Database.Sql
{
    public class SqlDbhelperFactory : BaseDbHelperFactory
    {
        public override IDBHelper Create(string dbName, string connectionString)
        {
            IDBHelper helper = AssemblyUtil.CreateInstance<IDBHelper>
            (
                "Immas.Database.Sql.dll",
                "Immas.Database.Sql.SqlDbHelper",
                dbName,
                connectionString
            );

            return helper;
        }
    }
}

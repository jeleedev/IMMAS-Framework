using Immas.Common;
using Immas.Database.Config;
using System;

namespace Immas.Database
{
    public static class DbHelperFactory
    {
        public static IDBHelper CreateDbHelper(string dbName)
        {
            ImmasDbConfigElement element = ImmasDbConfigSectionHandler.GetInstance().GetElement(dbName);
            string dbType = element.DbType.ToUpper();

            BaseDbHelperFactory factory = null;
            switch (dbType)
            {
                case "MSSQL":
                    factory = AssemblyUtil.CreateInstance<BaseDbHelperFactory>("Immas.Database.Sql", "Immas.Database.Sql.SqlDbhelperFactory");
                    break;
                case "ORACLE":
                    factory = AssemblyUtil.CreateInstance<BaseDbHelperFactory>("Immas.Database.Oracle", "Immas.Database.Oracle.OracleDbhelperFactory");
                    break;
            }

            if (factory == null) throw new Exception("cannot create db helper factory instance.");

            return factory.Create(dbName, element.ConnectionString);
        }
    }
}

using System.Data;

namespace Immas.Database
{
    public interface IDBHelper
    {
        string ConnectionString { get; }
        
        DataTable FillTable(string cmdText, CommandType cmdType, ParameterPackageCollection parameters);
        void ExecuteNonQuery(string cmdText, CommandType cmdType, ParameterPackageCollection parameters);
        object ExecuteScalar(string cmdText, CommandType cmdType, ParameterPackageCollection parameters);
    }
}
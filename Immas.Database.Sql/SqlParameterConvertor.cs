using System.Data;
using System.Data.SqlClient;

namespace Immas.Database.Sql
{
    public class SqlParameterConvertor : BaseParameterConvertor
    {
        public override IDbDataParameter Convert(ParameterPackage parameter)
        {
            return new SqlParameter(parameter.ParamName, parameter.Value);
        }
    }
}

using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Immas.Database.Oracle
{
    public class OracleParameterConvertor : BaseParameterConvertor
    {
        public override IDbDataParameter Convert(ParameterPackage parameter)
        {
            return new OracleParameter(parameter.ParamName, parameter.Value);
        }
    }
}

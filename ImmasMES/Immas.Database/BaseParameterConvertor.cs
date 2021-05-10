using System.Data;

namespace Immas.Database
{
    public abstract class BaseParameterConvertor
    {
        public abstract IDbDataParameter Convert(ParameterPackage parameter);
    }
}

namespace Immas.Database
{
    public class ParameterPackage
    {
        public string ParamName { get; private set; }
        public object Value     { get; private set; }

        public ParameterPackage(string paramName, object value)
        {
            this.ParamName = paramName;
            this.Value = value;
        }
    }
}

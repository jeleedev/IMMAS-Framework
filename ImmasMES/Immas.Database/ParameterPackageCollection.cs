using System.Collections;
using System.Collections.Generic;

namespace Immas.Database
{
    public class ParameterPackageCollection : IEnumerable<ParameterPackage>
    {
        private List<ParameterPackage> list;

        public ParameterPackageCollection()
        {
            this.list = new List<ParameterPackage>();
        }

        public void AddParameter(string paramName, object value)
        {
            ParameterPackage param = new ParameterPackage(paramName, value);
            this.list.Add(param);
        }

        public IEnumerator<ParameterPackage> GetEnumerator()
        {
            return this.list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.list.GetEnumerator();
        }
    }
}

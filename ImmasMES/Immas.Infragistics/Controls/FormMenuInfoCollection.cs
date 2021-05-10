using System.Collections;
using System.Collections.Generic;

namespace Immas.Infragistics.Controls
{
    public class FormMenuInfoCollection : IEnumerable<FormMenuInfo>
    {
        private List<FormMenuInfo> list = new List<FormMenuInfo>();

        public void Add(FormMenuInfo info)
        {
            this.list.Add(info);
        }

        public IEnumerator<FormMenuInfo> GetEnumerator()
        {
            return this.list.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.list.GetEnumerator();
        }
    }
}

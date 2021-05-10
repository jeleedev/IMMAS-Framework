using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Immas.Infragistics.BaseForm
{
    public class FormAuthCollection : IEnumerable<FormAuthInfo>
    {
        private List<FormAuthInfo> list;
        internal bool Changed { get; set; } = true;

        internal FormAuthCollection(List<FormAuthInfo> innerList)
        {
            foreach(FormAuthInfo info in innerList)
            {
                int count = innerList.Count(auth => auth.AuthKind == info.AuthKind);
                if (count > 1) throw new Exception("this list has more than 2 same auth kind.");
            }

            this.list = innerList;
        }

        public FormAuthInfo this[int index]
        {
            get
            {
                return this.list[index];
            }
        }
        public FormAuthInfo this[string authKind]
        {
            get
            {
                return this.list.Find(auth => auth.AuthKind == authKind);
            }
        }

        public void Update()
        {
            this.Changed = true;
        }

        public IEnumerator<FormAuthInfo> GetEnumerator()
        {
            return this.list.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.list.GetEnumerator();
        }
    }
}

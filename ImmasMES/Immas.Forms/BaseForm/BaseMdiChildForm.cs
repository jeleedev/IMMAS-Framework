
using System;
using System.Windows.Forms;

namespace Immas.Forms.BaseForm
{
    public class BaseMdiChildForm : BaseForm
    {
        public FormAuthCollection AuthCollection { get; internal set; }

        public virtual void DoInquiry()
        {
            throw new Exception("please override DoInquiry() method.");
        }
        public virtual void DoAdd()
        {
            throw new Exception("please override DoAdd() method.");
        }
        public virtual void DoDelete()
        {
            throw new Exception("please override DoDelete() method.");
        }
        public virtual void DoSave()
        {
            throw new Exception("please override DoSave() method.");
        }
    }
}

using System;
using System.Windows.Forms;

namespace Immas.Infragistics.BaseForm
{
    public class BaseForm : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (this.DesignMode == false) this.AfterFormLoad();
        }

        public virtual void AfterFormLoad()
        {
            throw new Exception("please override AfterFormLoad() method.");
        }
    }
}

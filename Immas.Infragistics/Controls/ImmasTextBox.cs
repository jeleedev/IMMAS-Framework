using System.ComponentModel;
using System.Windows.Forms;

namespace Immas.Infragistics.Controls
{
    public class ImmasTextBox : TextBox
    {
        public ImmasTextBox()
        {
            this.AutoSize = false;
        }

        [DefaultValue(false)]
        [Browsable(true)]
        public override bool AutoSize { get => base.AutoSize; set => base.AutoSize = value; }
    }   
}

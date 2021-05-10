using System.Windows.Forms;

namespace Immas.Infragistics.Dialog
{
    public partial class DialogForm : Form
    {
        #region [ Initialize             ]
        public DialogForm() : this(string.Empty, DialogType.OkOnly) { }
        public DialogForm(string message, DialogType dialogType)
        {
            InitializeComponent();
            this.Icon = Properties.Resources.information;

            DialogFormSetting(message, dialogType);
        }
        private void DialogFormSetting(string message, DialogType dialogType)
        {
            this.txtMessage.Text = message;

            switch (dialogType)
            {
                case (DialogType.OkOnly):
                    this.pnlOk.Visible = true;
                    break;
                case (DialogType.OkCancel):
                    this.pnlOkCancel.Visible = true;
                    break;
                case (DialogType.YesNo):
                    this.pnlYesNo.Visible = true;
                    break;
                case (DialogType.CancelOnly):
                    break;
            }
        }
        #endregion
        
        #region [ Event handler methods  ]
        private void btnOk_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        
        private void btnYes_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
        
        private void btnNo_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
        #endregion
    }
}

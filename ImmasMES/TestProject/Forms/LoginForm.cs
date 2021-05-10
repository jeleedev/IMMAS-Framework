using Immas.Common;
using Immas.DataAccess;
using Immas.Infragistics.Dialog;
using System;
using System.Windows.Forms;

namespace TestProject
{
    public partial class LoginForm : Form
    {
        #region [ Initialize             ]
        public LoginForm()
        {
            InitializeComponent();

            this.ActiveControl = txtPassword;
        }
        #endregion

        #region [ Event handler methods  ]
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login(txtUserId.Text, txtPassword.Text);
        }
        private void Login(string id, string password)
        {
            if (String.IsNullOrEmpty(id))
            {
                txtUserId.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(password))
            {
                txtPassword.Focus();
                return;
            }
            //
            //
            //
            string user = CommonDao.GetInstance().PasswordCheck(id, password);
            if(user == null)
            {
                DialogHelper.ShowDialog("로그인 실패!", DialogType.OkOnly);
                txtPassword.Focus();
            }
            else
            {
                SharedCache.UserId = user;
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login(txtUserId.Text, txtPassword.Text);
            }
        }
        #endregion

    }
}

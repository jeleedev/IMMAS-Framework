using Immas.Common;
using Immas.DataAccess;
using Immas.Infragistics.Dialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Immas.Forms.BaseForm
{
    public class BaseMdiParentForm : BaseForm
    {
        public BaseMdiChildForm ActiveMdiChildForm
        {
            get
            {
                return this.GetActiveMdiChildForm();
            }
        }
        private FormAuthCollection FormAuthCollection { get; set; }

        public void OpenForm(string assemblyName, string typeName, string text)
        {
            foreach(Form openForm in this.MdiChildren)
            {
                if(openForm.GetType().FullName == typeName)
                {
                    openForm.Activate();
                    return;
                }
            }
            BaseMdiChildForm form = AssemblyUtil.CreateInstance<BaseMdiChildForm>(assemblyName, typeName);
            form.AuthCollection = GetAuthCollection(form);
            form.MdiParent = this;
            form.Icon = Properties.Resources.program;
            form.Text = " " + text;
            form.BringToFront();
            form.Show();
        }
        private FormAuthCollection GetAuthCollection(BaseMdiChildForm form)
        {
            if (this.FormAuthCollection != null && this.FormAuthCollection.Changed == false) return this.FormAuthCollection;
            //
            // 로그인 유저의 화면별 권한정보
            //
            this.FormAuthCollection = form.AuthCollection;

            DataTable dt = CommonDao.GetInstance().AuthInfoSelect();

            List<FormAuthInfo> authInfoList = new List<FormAuthInfo>();
            foreach (DataRow row in dt.Rows)
            {
                FormAuthInfo authInfo = new FormAuthInfo(
                                                 viewId: row["VIEW_ID"].ToString(),
                                                 authKind: row["AUTH_KIND"].ToString(),
                                                 value: row["AUTH_YN"].ToString() == "Y" ? true : false);
                authInfoList.Add(authInfo);
            }
            authInfoList = authInfoList.FindAll(view => view.ViewId == form.Name);

            this.FormAuthCollection = new FormAuthCollection(authInfoList);
            this.FormAuthCollection.Changed = false;

            return this.FormAuthCollection;
        }

        public BaseMdiChildForm GetActiveMdiChildForm()
        {
            if (this.ActiveMdiChild == null) return null;

            if (this.ActiveMdiChild is BaseMdiChildForm == false) throw new Exception("Active form is not BaseMdiChildForm type.");

            return (BaseMdiChildForm)this.ActiveMdiChild;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            DialogResult dialogResult = DialogHelper.ShowDialog("프로그램을 종료하시겠습니까?", DialogType.OkCancel);
            if(dialogResult == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}

using Immas.Infragistics;
using Immas.Infragistics.BaseForm;
using Immas.Infragistics.Controls;
using Immas.Infragistics.Dialog;
using Infragistics.Win.UltraWinTabbedMdi;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestProject
{
    public partial class MainForm : BaseMdiParentForm
    {
        public enum ToolAction{
            Inquiry,
            Add,
            Delete,
            Save,
        }

        #region [ Initialize             ]
        public MainForm()
        {
            InitializeComponent();
        }

        public override void AfterFormLoad()
        {
            // 메뉴생성
            this.formMenuBrowser1.InitMenu();

            this.formMenuBrowser1.Menu_Event += Menu_Click_Event;
            this.immasTabbedMdiManager1.TabSelected += ImmasTabbedMdiManager1_TabSelected;

            // MdiParent BackColor 변경
            this.Controls[this.Controls.Count - 1].BackColor = Color.Gray;
        }
        #endregion

        #region [ Event handler methods  ]
        private void btnDoInquiry_Click(object sender, EventArgs e)
        {
            this.PerformAction(ToolAction.Inquiry);
        }
        private void btnDoAdd_Click(object sender, EventArgs e)
        {
            this.PerformAction(ToolAction.Add);
        }
        private void btnDoDelete_Click(object sender, EventArgs e)
        {
            this.PerformAction(ToolAction.Delete);
        }
        private void btnDoSave_Click(object sender, EventArgs e)
        {
            this.PerformAction(ToolAction.Save);
        }

        private void Menu_Click_Event(object sender, FormMenuInfo e)
        {
            if (e.ViewId == "") return;

            this.OpenForm(e.AssemblyName, $"{e.AssemblyName}.{e.ViewId}", e.MenuDesc);

            this.immasTabbedMdiManager1.Tag = e.ParentId.Split('-')[1];
            this.ExplorerUpdate(e.ParentId.Split('-')[1], e.MenuDesc);
        }

        private void ImmasTabbedMdiManager1_TabSelected(object sender, MdiTabEventArgs e)
        {
            this.ExplorerUpdate((sender as ImmasTabbedMdiManager).Tag, e.Tab.TextResolved);
        }

        private void ExplorerUpdate(string parentMenu, string activeView)
        {
            this.lblExplorer.Text = "      " + parentMenu + " > " + activeView;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.F5):
                    this.PerformAction(ToolAction.Inquiry);
                    break;
                case (Keys.Control | Keys.N):
                    this.PerformAction(ToolAction.Add);
                    break;
                case (Keys.Control | Keys.D):
                    this.PerformAction(ToolAction.Delete);
                    break;
                case (Keys.Control | Keys.S):
                    this.PerformAction(ToolAction.Save);
                    break;
                case (Keys.F1):
                    this.OpenForm("TestProject", "TestProject.SY0004", "코드 관리");
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #region PerformAction
        private void PerformAction(ToolAction action)
        {
            BaseMdiChildForm child = this.ActiveMdiChildForm;
            if (child == null) return;

            switch (action)
            {
                case ToolAction.Inquiry:
                    PerformInquiry(child, child.AuthCollection["R"]);
                    break;
                case ToolAction.Add:
                    PerformAdd(child, child.AuthCollection["C"]);
                    break;
                case ToolAction.Delete:
                    PerformDelete(child, child.AuthCollection["D"]);
                    break;
                case ToolAction.Save:
                    PerformSave(child, child.AuthCollection["S"]);
                    break;
            }
        }

        private void PerformInquiry(BaseMdiChildForm child, FormAuthInfo auth)
        {
            if (auth == null) return;

            if (auth.Value == true)
            {
                child?.DoInquiry();
            }
        }
        private void PerformAdd(BaseMdiChildForm child, FormAuthInfo auth)
        {
            if (auth == null) return;

            if (auth.Value == true)
            {
                child?.DoAdd();
            }
        }
        private void PerformDelete(BaseMdiChildForm child, FormAuthInfo auth)
        {
            if (auth == null) return;

            if (auth.Value == true)
            {
                child?.DoDelete();
            }
        }
        public void PerformSave(BaseMdiChildForm child, FormAuthInfo auth)
        {
            if (auth == null) return;

            if (auth.Value == true)
            {
                DialogResult result = DialogHelper.ShowDialog("저장하시겠습니까?", DialogType.YesNo);
                if(result == DialogResult.Yes)
                {
                    child?.DoSave();
                }
            }
        }

        #endregion
        #endregion
    }
}
using Immas.Infragistics.BaseForm;
using Immas.Infragistics.Dialog;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Data;
using System.Windows.Forms;
using TestProject.Dao;

namespace TestProject
{
    public partial class SY0002 : BaseMdiChildForm
    {
        #region [ Properties             ]
        private Control LastFocusControl { get; set; }
        #endregion

        #region [ Initialize             ]
        public SY0002()
        {
            InitializeComponent();
        }

        public override void AfterFormLoad()
        {
            this.InitEventHandlers();
            this.InitGrid();

            this.DoInquiry();
        }
        private void InitEventHandlers()
        {
            this.grdMaster.AfterRowInsert += this.grdMaster_AfterRowInsert;
            this.grdDetail.AfterRowInsert += this.grdDetail_AfterRowInsert;
        }

        private void InitGrid()
        {
            this.grdMaster.LoadGridSchema("SY0002_grdMaster.grd");
            this.grdDetail.LoadGridSchema("SY0002_grdDetail.grd");

            this.grdMaster.SetComboBoxValue("USE_YN", "USE_YN");
            this.grdDetail.SetComboBoxValue("USE_YN", "USE_YN");

            // 화면권한 그리드에 적용
            if (this.AuthCollection["C"] != null)
            {
                this.grdMaster.AllowNew = this.AuthCollection["C"].Value;
                this.grdDetail.AllowNew = this.AuthCollection["C"].Value;
            }
            if (this.AuthCollection["D"] != null)
            {
                this.grdMaster.AllowDelete = this.AuthCollection["D"].Value;
                this.grdDetail.AllowDelete = this.AuthCollection["D"].Value;
            }
        }
        #endregion

        #region [ Event handler methods  ]
        private void grdMaster_AfterRowInsert(object sender, RowEventArgs row)
        {
            grdMaster.ActiveRow.Cells["USE_YN"].Value = "Y";
        }
        private void grdDetail_AfterRowInsert(object sender, RowEventArgs e)
        {
            grdDetail.ActiveRow.Cells["USE_YN"].Value = "Y";
        }

        private void grdMaster_AfterRowActivate(object sender, EventArgs e)
        {
            DoInquiryDetail();
        }

        private void grdMaster_Enter(object sender, EventArgs e)
        {
            lblHeadMaster.Image = Properties.Resources.edit_16;
            lblHeadMaster.Text  = "     " + lblHeadMaster.Text.Trim();
            lblHeadDetail.Image = null;
            lblHeadDetail.Text  = lblHeadDetail.Text.Trim();
            LastFocusControl    = this.grdMaster;
        }
        private void grdDetail_Enter(object sender, EventArgs e)
        {
            lblHeadDetail.Image = Properties.Resources.edit_16;
            lblHeadDetail.Text  = "     " + lblHeadDetail.Text.Trim();
            lblHeadMaster.Image = null;
            lblHeadMaster.Text  = lblHeadMaster.Text.Trim();
            LastFocusControl    = this.grdDetail;
        }

        private void txtMaster_TextChanged(object sender, EventArgs e)
        {
            var defaultView = (this.grdMaster.DataSource as DataTable).DefaultView;
            defaultView.RowFilter = $"MCODE IS NULL OR MCODE = '' OR (MCODE LIKE '%{txtMasterCode.Text}%' AND NAME LIKE '%{txtMasterName.Text}%')";
        }
        private void txtDetail_TextChanged(object sender, EventArgs e)
        {
            var defaultView = (this.grdDetail.DataSource as DataTable).DefaultView;
            defaultView.RowFilter = $"CODE IS NULL OR CODE = '' OR (CODE LIKE '%{txtDetailCode.Text}%' AND NAME LIKE '%{txtDetailName.Text}%')";
        }
        #endregion

        #region [ DB CRUD                ]
        public override void DoInquiry()
        {
            DataTable resultTable = SY0002Dao.GetInstance().Select01();
            this.grdMaster.DataSource = resultTable;

            this.grdMaster.SetColumnAutoResize();
        }
        public void DoInquiryDetail()
        {
            if (this.grdMaster.ActiveRow == null) return;

            var masterCode = this.grdMaster.ActiveRow.Cells["MCODE"].Value.ToString();
            
            this.grdDetail.Layouts.Clear();
            DataTable resultTable = SY0002Dao.GetInstance().Select02(masterCode);
            this.grdDetail.DataSource = resultTable;
            
            this.grdDetail.SetColumnAutoResize();
        }
        public override void DoAdd()
        {
            if(LastFocusControl == this.grdMaster)
            {
                this.grdMaster.AddNew();
            }
            if (LastFocusControl == this.grdDetail)
            {
                if(this.grdMaster.ActiveRow == null)
                {
                    DialogHelper.ShowDialog("주 코드를 선택 하십시오.");
                }
                else
                {
                    var rowView = this.grdMaster.ActiveRow.ListObject as DataRowView;
                    switch (rowView.Row.RowState)
                    {
                        case DataRowState.Added:
                            DialogHelper.ShowDialog("신규 주 코드를 저장하십시오.");
                            return;
                        case DataRowState.Deleted:
                            DialogHelper.ShowDialog("삭제된 주 코드에는 등록 하실 수 없습니다.");
                            return;
                    }
                    var row = this.grdDetail.AddNew();
                    row.Cells["MCODE"].Value = this.grdMaster.ActiveRow.Cells["MCODE"].Value;
                }
            }
        }
        public override void DoDelete()
        {
            if(LastFocusControl == this.grdMaster)
            {
                this.grdMaster.RemoveCurrent();
            }
            if (LastFocusControl == this.grdDetail)
            {
                this.grdDetail.RemoveCurrent();
            }
        }
        public override void DoSave()
        {
            try
            {
                this.grdMaster.UpdateData();
                this.grdDetail.UpdateData();

                SY0002Dao.GetInstance().Insert01(this.grdMaster.InsertSave());
                SY0002Dao.GetInstance().Update01(this.grdMaster.UpdateSave());
                SY0002Dao.GetInstance().Delete01(this.grdMaster.DeleteSave());

                SY0002Dao.GetInstance().Insert02(this.grdDetail.InsertSave());
                SY0002Dao.GetInstance().Update02(this.grdDetail.UpdateSave());
                SY0002Dao.GetInstance().Delete02(this.grdDetail.DeleteSave());
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to save data");
            }
            finally
            {
                DoInquiryDetail();
                DoInquiry();
            }
        }
        #endregion
    }
}

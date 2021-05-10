using Immas.Infragistics.BaseForm;
using System;
using System.Data;
using TestProject.Dao;

namespace TestProject
{
    public partial class SY0005 : BaseMdiChildForm
    {
        #region [ Initialize             ]
        public SY0005()
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
            this.grdMaster.AfterRowActivate += this.grdMaster_AfterRowActive;
        }

        private void InitGrid()
        {
            this.grdMaster.LoadGridSchema("SY0005_grdMaster.grd");
            this.grdDetail.LoadGridSchema("SY0005_grdDetail.grd");
        }
        #endregion

        #region [ Event handler methods  ]
        private void grdMaster_AfterRowActive(object sender, EventArgs e)
        {
            this.DoInquiryDetail();
        }
        #endregion

        #region [ DB CRUD                ]
        public override void DoInquiry()
        {
            DataTable resultTable = SY0005Dao.GetInstance().Select01();
            this.grdMaster.DataSource = resultTable;
        }
        private void DoInquiryDetail()
        {
            if (this.grdMaster.ActiveRow == null) return;

            var code = this.grdMaster.ActiveRow.Cells["CODE"].Value.ToString();

            this.grdDetail.Layouts.Clear();
            DataTable resultTable = SY0005Dao.GetInstance().Select02(code);
            this.grdDetail.DataSource = resultTable;

            this.grdDetail.SetColumnAutoResize();
        }
        public override void DoAdd()
        {
        }
        public override void DoDelete()
        {
        }
        public override void DoSave()
        {
            try
            {
                this.grdDetail.UpdateData();
                SY0005Dao.GetInstance().Update02(this.grdDetail.UpdateSave());
            }
            catch (Exception ex)
            {
            }
            finally
            {
                DoInquiryDetail();
            }
        }
        #endregion
    }
}

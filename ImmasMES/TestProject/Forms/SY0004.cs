using Immas.Infragistics.BaseForm;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Data;
using TestProject.Dao;

namespace TestProject
{
    public partial class SY0004 : BaseMdiChildForm
    {
        #region [ Initialize             ]
        public SY0004()
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
            this.grdMaster.AfterRowInsert += this.immasGrid1_AfterRowInsert;
        }

        private void InitGrid()
        {
            this.grdMaster.LoadGridSchema("SY0004_grdMaster.grd");

            this.grdMaster.SetComboBoxValue("AUTH_KIND", "AUTH_KIND");
            this.grdMaster.SetComboBoxValue("AUTH_YN", "USE_YN");
        }
        #endregion

        #region [ Event handler methods  ]
        private void immasGrid1_AfterRowInsert(object sender, RowEventArgs row)
        {
            grdMaster.ActiveRow.Cells["AUTH_KIND"].Value  = "R";
        }
        #endregion

        #region [ DB CRUD                ]
        public override void DoInquiry()
        {
            DataTable resultTable = SY0004Dao.GetInstance().Select01();
            this.grdMaster.DataSource = resultTable;

            this.grdMaster.SetColumnAutoResize();
        }
        public override void DoAdd()
        {
            this.grdMaster.AddNew();
        }
        public override void DoDelete()
        {
            this.grdMaster.RemoveCurrent();
        }
        public override void DoSave()
        {
            try
            {
                this.grdMaster.UpdateData();

                SY0004Dao.GetInstance().Insert01(this.grdMaster.InsertSave());
                SY0004Dao.GetInstance().Update01(this.grdMaster.UpdateSave());
                SY0004Dao.GetInstance().Delete01(this.grdMaster.DeleteSave());
            }
            catch (Exception ex)
            {
            }
            finally
            {
                this.AuthCollection.Update();
                DoInquiry();
            }
        }
        #endregion
    }
}

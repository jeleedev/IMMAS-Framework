using Immas.Infragistics.BaseForm;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Data;
using TestProject.Dao;

namespace TestProject
{
    public partial class SY0003 : BaseMdiChildForm
    {
        #region [ Initialize             ]
        public SY0003()
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
            this.grdMaster.LoadGridSchema("SY0003_grdMaster.grd");

            this.grdMaster.SetComboBoxValue("USE_YN", "USE_YN");
            this.grdMaster.SetComboBoxValue("USER_GROUP", "USER_GROUP");
        }
        #endregion

        #region [ Event handler methods  ]
        private void immasGrid1_AfterRowInsert(object sender, RowEventArgs row)
        {
            grdMaster.ActiveRow.Cells["USE_YN"].Value = "N";
        }
        #endregion

        #region [ DB CRUD                ]
        public override void DoInquiry()
        {
            DataTable resultTable = SY0003Dao.GetInstance().Select01();
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

                SY0003Dao.GetInstance().Insert01(this.grdMaster.InsertSave());
                SY0003Dao.GetInstance().Update01(this.grdMaster.UpdateSave());
                SY0003Dao.GetInstance().Delete01(this.grdMaster.DeleteSave());
            }
            catch (Exception ex)
            { 
                throw new Exception("Failed to save data"); 
            }
            finally
            {
                DoInquiry();
            }
        }
        #endregion
    }
}

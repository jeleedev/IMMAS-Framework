using Immas.Infragistics.BaseForm;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Data;
using System.Drawing;
using TestProject.Dao;

namespace TestProject
{
    public partial class SY0001 : BaseMdiChildForm
    {
        #region [ Initialize             ]
        public SY0001()
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
            this.grdMaster.LoadGridSchema("SY0001_grdMaster.grd");

            this.grdMaster.SetComboBoxValue("USER_GROUP", "USER_GROUP");
            this.grdMaster.SetComboBoxValue("DEPARTMENT", "DEPARTMENT");
            this.grdMaster.SetComboBoxValue("RANK_CODE", "RANK_CODE");
        }
        #endregion

        #region [ Event handler methods  ]
        private void immasGrid1_AfterRowInsert(object sender, RowEventArgs row)
        {
        }
        #endregion

        #region [ DB CRUD                ]
        public override void DoInquiry()
        {
            DataTable resultTable = SY0001Dao.GetInstance().Select01(txtUSER_ID.Text, txtUSER_NAME.Text, txtRANK_CODE.Text);
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

                SY0001Dao.GetInstance().Insert01(this.grdMaster.InsertSave());
                SY0001Dao.GetInstance().Update01(this.grdMaster.UpdateSave());
                SY0001Dao.GetInstance().Delete01(this.grdMaster.DeleteSave());
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.immasTextBox1.ReadOnly = !this.immasTextBox1.ReadOnly;
        }
    }
}
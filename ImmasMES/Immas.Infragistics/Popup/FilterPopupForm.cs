using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using System.Data;
using System.Windows.Forms;

namespace Immas.Infragistics.Popup
{
    public partial class FilterPopupForm : BaseForm.BaseForm
    {
        public ImmasGrid        Grid    { get; private set; }
        public UltraGridColumn  Column  { get; private set; }
        public ColumnFilter     ColumnFilter
        { 
            get
            { 
                return this.Grid.DefaultBand.ColumnFilters[Column]; 
            }
        }

        #region [ Initialize             ]
        public FilterPopupForm(ImmasGrid grid, UltraGridColumn column)
        {
            InitializeComponent();

            this.Grid   = grid;
            this.Column = column;
            this.Text   = this.Text + $"[{column.Header.Caption}]";
        }

        public override void AfterFormLoad()
        {
            this.InitGrid();
            this.LoadFilterCondition();
        }

        private void InitGrid()
        {
            this.immasGrid1.SetColumn("OPERATOR", caption: "조건", columnStyle: ImmasColumnStyle.ComboBox, width: 180);
            this.immasGrid1.SetColumn("OPERAND", caption: "값", columnStyle: ImmasColumnStyle.TextBox, width: 180);
            this.immasGrid1.SetColumn("CLEAR", caption: "조건 삭제", columnStyle: ImmasColumnStyle.Button, width: 96);

            // TODO: FilterOperator 리스트
            ValueList valueList = this.immasGrid1.DisplayLayout.FilterOperatorsValueList;
            foreach(ValueListItem item in valueList.ValueListItems)
            {
                this.immasGrid1.AddComboBoxValue("OPERATOR", item.DataValue.ToString(), item.DisplayText);
            }
        }
        private void LoadFilterCondition()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("OPERATOR");
            dt.Columns.Add("OPERAND");
            dt.Columns.Add("CLEAR");

            if (this.Grid.Rows.Count > 0)
            {
                foreach (FilterCondition condition in this.ColumnFilter.FilterConditions)
                {
                    DataRow row = dt.NewRow();
                    row["OPERATOR"] = condition.ComparisionOperator.ToString();
                    row["OPERAND"]  = condition.CompareValue;
                    row["CLEAR"]    = "삭제";
                    
                    dt.Rows.Add(row);
                }
            }
            dt.AcceptChanges();
            this.immasGrid1.DataSource = dt;
        }
        #endregion

        #region [ Event handler methods  ]
        private void btnConditionAdd_Click(object sender, System.EventArgs e)
        {
            // 연산자 컬럼의 첫번째 항목을 가져옴.
            string defaultValue = ((ValueList)this.immasGrid1.Columns[0].ValueList).ValueListItems[0].DataValue.ToString();

            DataTable dt = this.immasGrid1.DataSource as DataTable;
            DataRow row = dt.NewRow();

            row["OPERATOR"]     = defaultValue;
            row["OPERAND"]      = "";
            row["CLEAR"]        = "삭제";

            dt.Rows.Add(row);
            this.immasGrid1.DataSource = dt;
        }

        private void btnApply_Click(object sender, System.EventArgs e)
        {
            SetFilterCondition();
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            SetFilterCondition();

            this.CloseWithOk();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.CloseWithCancel();
        }

        private void immasGrid1_ClickCellButton(object sender, CellEventArgs e)
        {
            if(e.Cell.Column.Key == "CLEAR")
            {
                // TODO: edit, delete 마크
                var dt = this.immasGrid1.DataSource as DataTable;

                DataRowView dataRowView = (DataRowView)this.immasGrid1.ActiveRow.ListObject;
                dt.Rows.Remove(dataRowView.Row);
                this.immasGrid1.DataSource = dt;
            }
        }
        #endregion

        #region [ User Methods           ]
        private void SetFilterCondition()
        {
            this.ColumnFilter.ClearFilterConditions();

            if (this.rdbAND.Checked) this.ColumnFilter.LogicalOperator = FilterLogicalOperator.And;
            if (this.rdbOR.Checked)  this.ColumnFilter.LogicalOperator = FilterLogicalOperator.Or;

            foreach (UltraGridRow row in this.immasGrid1.Rows)
            {
                ValueList valueList = this.immasGrid1.DisplayLayout.FilterOperatorsValueList;
                foreach (ValueListItem item in valueList.ValueListItems)
                {
                    if(row.Cells["OPERATOR"].Value.ToString() == item.DataValue.ToString())
                    {
                        FilterCondition condition = new FilterCondition((FilterComparisionOperator)item.DataValue, row.Cells["OPERAND"].Value);
                        this.ColumnFilter.FilterConditions.Add(condition);
                        break;
                    }
                }
            }
            this.Grid.DisplayLayout.RefreshFilters();
        }
        private void CloseWithOk()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void CloseWithCancel()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion

    }
}

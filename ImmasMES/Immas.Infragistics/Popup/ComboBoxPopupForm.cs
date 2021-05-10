using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using System.Data;
using System.Windows.Forms;

namespace Immas.Infragistics.Popup
{
    public partial class ComboBoxPopupForm : BaseForm.BaseForm
    {
        public  string CodeValue { get; private set; }
        private UltraGridCell selectedCell;

        #region [ Initialize             ]
        public ComboBoxPopupForm(UltraGridCell cell)
        {
            InitializeComponent();

            this.Text = cell.Column.Header.Caption;
            this.selectedCell = cell;
            this.immasGrid1.DoubleClickCell += ImmasGrid1_CellDoubleClick;
        }

        public override void AfterFormLoad()
        {
            this.InitGrid();
            this.CodeListSetting(this.selectedCell);
        }

        private void InitGrid()
        {
            this.immasGrid1.SetColumn("CODE", caption: "코드", columnStyle: ImmasColumnStyle.TextBox, width: 118);
            this.immasGrid1.SetColumn("NAME", caption: "코드명", columnStyle: ImmasColumnStyle.TextBox, width: 130);
        }
        public void CodeListSetting(UltraGridCell cell)
        {
            if (cell.Column.ValueList == null) return;
            ValueListItemsCollection valueListItems = ((ValueList)cell.Column.ValueList).ValueListItems;

            DataTable dt = new DataTable();
            dt.Columns.Add("CODE");
            dt.Columns.Add("NAME");
            foreach (var item in valueListItems)
            {
                DataRow row = dt.NewRow();
                row["CODE"] = item.DataValue;
                row["NAME"] = item.DisplayText;

                dt.Rows.Add(row);
            }
            dt.AcceptChanges();
            this.immasGrid1.DataSource = dt;

            string cellValue = cell.Value.ToString();
            foreach (UltraGridRow row in this.immasGrid1.Rows)
            {
                string codeValue = row.Cells["CODE"].Value.ToString();
                if (codeValue == cellValue)
                {
                    row.Selected = true;
                    row.Activated = true;
                    break;
                }
            }
        }
        #endregion

        #region [ Event handler methods  ]
        private void ImmasGrid1_CellDoubleClick(object sender, DoubleClickCellEventArgs e)
        {
            this.CloseWithOk();
        }
        private void btnOk_Click(object sender, System.EventArgs e)
        {
            this.CloseWithOk();
        }
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.CloseWithCancel();
        }
        #endregion

        #region [ User Methods           ]
        private void CloseWithOk()
        {
            this.CodeValue = this.immasGrid1.ActiveRow.Cells["CODE"].Value.ToString();

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

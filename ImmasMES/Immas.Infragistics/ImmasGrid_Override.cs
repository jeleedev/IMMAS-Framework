using Immas.Infragistics.Popup;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ColumnStyle = Infragistics.Win.UltraWinGrid.ColumnStyle;

namespace Immas.Infragistics
{
    public partial class ImmasGrid
    {
        /// <summary>
        /// mouse Right-click menu
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            // 현재 클릭한 GridItem 가져오기
            UIElement element = this.DisplayLayout.UIElement.ElementFromPoint(new Point(e.X, e.Y));
            object gridItem = element.GetContext();

            if (e.Button == MouseButtons.Right)
            {
                // 만약 현재 클릭한 GridItem이 UltraGridCell인 경우
                if (gridItem is UltraGridColumn)
                {
                    UltraGridCell activeCell = (UltraGridCell)element.GetContext(typeof(UltraGridCell));

                    this.ActiveRow = null;
                    this.ActiveCell = null;

                    activeCell.Activate();
                }

                // 1. 컨텍스트 메뉴 구성(생성)
                ContextMenuStrip strip = this.CreateContextMenu(element);

                // 2. 컨텍스트 메뉴 사용 가능/불가능 처리
                this.AdjustContextMenuItems(strip, element);

                strip.Show(this, new Point(e.X, e.Y));
            }
        }

        /// <summary>
        /// Perform editor mode when Enter key press
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (this.ActiveCell == null) return;

            if (e.KeyChar == (char)13)
            {
                if (this.ActiveCell.IsInEditMode == false)
                {
                    this.PerformAction(UltraGridAction.EnterEditMode);
                }
                else
                {
                    this.PerformAction(UltraGridAction.ExitEditMode);
                }
            }
        }

        /// <summary>
        /// Perform editor mode according to Cell or Column property
        /// </summary>
        /// <param name="e"></param>
        protected override void OnBeforeEnterEditMode(CancelEventArgs e)
        {
            base.OnBeforeEnterEditMode(e);

            if (this.ActiveCell is UltraGridFilterCell) return;

            // Column ReadOnly
            UltraGridColumn column = this.ActiveCell.Column;
            if (this.ReadOnlyColumns.ContainsKey(column.Key) == true)
            {
                e.Cancel = true;
                return;
            }

            // Column PrimaryKey
            if (this.PrimaryKeyColumns.ContainsKey(column.Key) == true)
            {
                DataRowView dataRowView = (DataRowView)this.ActiveRow.ListObject;
                if (dataRowView.Row.RowState != DataRowState.Added)
                {
                    e.Cancel = true;
                    return;
                }
            }

            // ComboxBox인 경우 팝업창으로 대체
            if (column.Style == ColumnStyle.DropDown)
            {
                e.Cancel = true;

                ComboBoxPopupForm popupForm = new ComboBoxPopupForm(this.ActiveCell);
                DialogResult dialogResult = popupForm.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    this.ActiveRow.Cells[column.Key].Value = popupForm.CodeValue;
                    UpdateData();
                }
            }
        }

        /// <summary>
        /// Whether to send Windows message when specifies key-in
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // true: 키 입력 메시지를 더이상 전달하지 않고 끝냄.
            // false: 키 입력 메시지를 다음 체인으로 전달.

            if (keyData == Keys.Delete)
            {
                this.RemoveCurrent();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// Allow new rows based on Form authority
        /// </summary>
        /// <param name="e"></param>
        protected override void OnBeforeRowInsert(BeforeRowInsertEventArgs e)
        {
            base.OnBeforeRowInsert(e);

            if (this.AllowNew == false)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Allow delete rows based on Form auth
        /// </summary>
        /// <param name="e"></param>
        protected override void OnBeforeRowsDeleted(BeforeRowsDeletedEventArgs e)
        {
            base.OnBeforeRowsDeleted(e);

            if (this.AllowDelete == false)
            {
                e.Cancel = true;
            }
        }
    }
}

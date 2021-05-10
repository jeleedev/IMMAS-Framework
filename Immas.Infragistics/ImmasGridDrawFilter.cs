using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinTabs;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Immas.Infragistics
{
    public class ImmasGridDrawFilter : IUIElementDrawFilter
    {
        private ImmasGrid grid;
        private SmoothingMode orginialSmoothingMode;

        public ImmasGridDrawFilter(ImmasGrid grid)
        {
            this.grid = grid;
        }

        public DrawPhase GetPhasesToFilter(ref UIElementDrawParams drawParams)
        {
            bool handling = false;

            if (drawParams.Element is RowSelectorUIElement)                     handling = true;
            if (drawParams.Element is RowSelectorHeaderUIElement)               handling = true;
            if (drawParams.Element is EditorWithComboDropDownButtonUIElement)   handling = true;
            if (drawParams.Element is SortIndicatorUIElement)                   handling = true;
            if (drawParams.Element is FilterDropDownButtonUIElement)            handling = true;
            if (drawParams.Element is CaptionAreaUIElement)                     handling = true;
            if (drawParams.Element is TabItemUIElement)                         handling = true;

            if (handling == true) return drawParams.DrawPhase;

            return DrawPhase.BeforeDrawFocus;
        }

        public bool DrawElement(DrawPhase drawPhase, ref UIElementDrawParams drawParams)
        {
            // 포커스 사각형을 그리지 않음.
            if (drawPhase == DrawPhase.BeforeDrawFocus) return true;

            // RowSelector
            if (drawParams.Element is RowSelectorUIElement)
            {
                this.DrawElement_RowSelectorUIElement(ref drawParams);
                return true;
            }

            // RowSelector Header
            if (drawParams.Element is RowSelectorHeaderUIElement)
            {
                this.DrawElement_RowSelectorHeaderUIElement(ref drawParams);
                return true;
            }

            // ComboBox ArrowButton (Code Type)
            if (drawParams.Element is EditorWithComboDropDownButtonUIElement)
            {
                this.DrawElement_EditorWithComboDropDownButtonUIElement(ref drawParams);
                return true;
            }

            // Sort Indicator(Arrow)
            if (drawParams.Element is SortIndicatorUIElement)
            {
                this.DrawElement_SortIndicatorUIElement(ref drawParams);
                return true;
            }

            // filter button
            if (drawParams.Element is FilterDropDownButtonUIElement)
            {
                this.DrawElement_FilterDropDownButtonUIElement(ref drawParams);
                return true;
            }

            // Tab (동작안됨)
            if (drawParams.Element is TabItemUIElement)
            {
                if (drawPhase == DrawPhase.BeforeDrawBorders)
                {
                    this.orginialSmoothingMode = drawParams.Graphics.SmoothingMode;
                    drawParams.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                }
                else if (drawPhase == DrawPhase.AfterDrawBorders)
                {
                    drawParams.Graphics.SmoothingMode = this.orginialSmoothingMode;
                }
            }
            return false;
        }

        private void DrawElement_RowSelectorHeaderUIElement(ref UIElementDrawParams drawParams)
        {
            drawParams.DrawBackColor(drawParams.Element.Rect);

            Border3DSide border = Border3DSide.Bottom | Border3DSide.Right;

            drawParams.DrawBorders(UIElementBorderStyle.Solid, border);
        }
        private void DrawElement_RowSelectorUIElement(ref UIElementDrawParams drawParams)
        {
            Rectangle rect = drawParams.Element.Rect;
            rect.X += 1;

            UltraGridRow ultraGridRow = (UltraGridRow)drawParams.Element.GetContext(typeof(UltraGridRow));

            // active row header color
            if (ultraGridRow.IsActiveRow == true)
            {
                drawParams.AppearanceData.BackColor = CommonColorSet.ActiveCellHeaderColor;
            }

            drawParams.DrawBackColor(rect);
            drawParams.DrawBorders(UIElementBorderStyle.Solid, Border3DSide.Top | Border3DSide.Bottom | Border3DSide.Right, rect);

            // draw row number
            drawParams.DrawString(drawParams.Element.Rect, (ultraGridRow.VisibleIndex + 1).ToString(), false, false);

            // draw CRUD image. (DataRow Only)
            Rectangle imageRect = new Rectangle(rect.Left + 3, rect.Top + (ultraGridRow.Height - Properties.Resources.new_16.Height) / 2, Properties.Resources.new_16.Width, Properties.Resources.new_16.Height);

            // DataRowView 얻기
            DataRowView dataRowView =(DataRowView)ultraGridRow.ListObject;
            DataRow dataRow = dataRowView.Row;

            switch (dataRow.RowState)
            {
                case DataRowState.Added:
                    drawParams.DrawImage(Properties.Resources.new_16, imageRect, false, null);
                    break;

                case DataRowState.Modified:
                    drawParams.DrawImage(Properties.Resources.edit_16, imageRect, false, null);
                    break;

                case DataRowState.Deleted:
                    drawParams.DrawImage(Properties.Resources.delete_16, imageRect, false, null);
                    break;
            }
        }
        private void DrawElement_EditorWithComboDropDownButtonUIElement(ref UIElementDrawParams drawParams)
        {
            EditorWithComboDropDownButtonUIElement dropDownButtonElement = (EditorWithComboDropDownButtonUIElement)drawParams.Element;
            if (dropDownButtonElement.Parent is EditorWithComboUIElement)
            {
                EditorWithComboUIElement comboElement = (EditorWithComboUIElement)dropDownButtonElement.Parent;
                UltraGridCell cell = (UltraGridCell)comboElement.SelectableItem;
                UltraGridColumn column = cell.Column;

                if (this.grid.IsCellEditable(cell) == true)
                {
                    if (dropDownButtonElement.IsHotTracked == true)
                    {
                        drawParams.AppearanceData.BackColor = Color.FromArgb(230, 230, 230);
                        drawParams.DrawBackColor(drawParams.Element.Rect);
                        drawParams.DrawImage(Properties.Resources.button_code_hover, this.GetDropDownButtonRect(drawParams), false, null);
                        drawParams.DrawBorders(UIElementBorderStyle.Solid, Border3DSide.Left);
                    }
                    else
                    {
                        drawParams.AppearanceData.BackColor = Color.FromArgb(215, 215, 215);
                        drawParams.DrawBackColor(drawParams.Element.Rect);
                        drawParams.DrawImage(Properties.Resources.button_code_normal, this.GetDropDownButtonRect(drawParams), false, null);
                        drawParams.DrawBorders(UIElementBorderStyle.Solid, Border3DSide.Left);
                    }

                }
                else
                {
                    drawParams.AppearanceData.BackColor = Color.FromArgb(180, 180, 180);
                    drawParams.DrawBackColor(drawParams.Element.Rect);
                    drawParams.DrawImage(Properties.Resources.button_code_normal, this.GetDropDownButtonRect(drawParams), false, null);
                    drawParams.DrawBorders(UIElementBorderStyle.Solid, Border3DSide.Left);
                }
            }
        }
        private void DrawElement_SortIndicatorUIElement(ref UIElementDrawParams drawParams)
        {
            SortIndicatorUIElement e = (SortIndicatorUIElement)drawParams.Element;
            global::Infragistics.Win.UltraWinGrid.ColumnHeader header = (global::Infragistics.Win.UltraWinGrid.ColumnHeader)e.GetContext(typeof(global::Infragistics.Win.UltraWinGrid.ColumnHeader));

            if (header.Column.SortIndicator == SortIndicator.Ascending)
            {
                drawParams.DrawImage(Properties.Resources.arrow_up_9, drawParams.Element.Rect, false, new ImageAttributes());
            }
            else if (header.Column.SortIndicator == SortIndicator.Descending)
            {
                drawParams.DrawImage(Properties.Resources.arrow_down_9, drawParams.Element.Rect, false, new ImageAttributes());
            }
        }
        private void DrawElement_FilterDropDownButtonUIElement(ref UIElementDrawParams drawParams)
        {
            drawParams.DrawImage(Properties.Resources.filter_12, drawParams.Element.Rect, false, new ImageAttributes());
        }
        private Rectangle GetDropDownButtonRect(UIElementDrawParams drawParams)
        {
            Rectangle originalRect = drawParams.Element.Rect;
            if (originalRect.Width <= 16 || originalRect.Height <= 16) return originalRect;

            int adjustX = (originalRect.Width - 16) / 2;
            int adjustY = (originalRect.Height - 16) / 2;
            Rectangle rect = new Rectangle(originalRect.X + adjustX, originalRect.Y + adjustY, 16, 16);
            return rect;
        }
    }
}

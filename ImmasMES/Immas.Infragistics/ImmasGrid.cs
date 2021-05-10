using Immas.Infragistics.Extension;
using Immas.Infragistics.Popup;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using ColumnHeader = Infragistics.Win.UltraWinGrid.ColumnHeader;

namespace Immas.Infragistics
{
    public partial class ImmasGrid : UltraGrid
    {
        #region [ Properties             ]
        public UltraGridBand DefaultBand { get { return this.DisplayLayout.Bands[0]; } }
        public ColumnsCollection Columns { get { return this.DefaultBand.Columns; } }


        public Dictionary<string, UltraGridColumn> ReadOnlyColumns   { get; private set; } = new Dictionary<string, UltraGridColumn>();
        public Dictionary<string, UltraGridColumn> PrimaryKeyColumns { get; private set; } = new Dictionary<string, UltraGridColumn>();

        [DefaultValue(true)]
        public bool AllowNew    { get; set; } = true;

        [DefaultValue(true)]
        public bool AllowDelete { get; set; } = true;

        public new object DataSource
        {
            get
            {
                return base.DataSource;
            }
            set
            {
                base.DataSource = value;
                this.OnDataSourceChanged();
            }
        }
        #endregion

        #region [ Initialize             ]
        public ImmasGrid() { }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Initialize();
        }

        public void Initialize()
        {
            this.Initialize_General();
            this.Initialize_ColorSetting();
        }

        private void Initialize_General()
        {
            this.UseOsThemes = DefaultableBoolean.True;
            this.DisplayLayout.ViewStyleBand = ViewStyleBand.Vertical;

            this.DisplayLayout.CaptionAppearance.TextHAlign = HAlign.Left;
            this.DisplayLayout.CaptionAppearance.TextVAlign = VAlign.Middle;

            this.DisplayLayout.Override.HeaderStyle                     = HeaderStyle.Standard;
            this.DisplayLayout.Override.HeaderAppearance.FontData.Bold  = DefaultableBoolean.True;
            this.DisplayLayout.Override.HeaderClickAction               = HeaderClickAction.Select;

            this.DisplayLayout.Override.CellClickAction = CellClickAction.CellSelect;

            this.DisplayLayout.Override.BorderStyleCell = UIElementBorderStyle.Solid;
            this.DisplayLayout.Override.BorderStyleRow  = UIElementBorderStyle.Solid;

            this.DisplayLayout.Bands[0].Override.RowSelectors   = DefaultableBoolean.True;
            this.DisplayLayout.Override.RowSelectorHeaderStyle  = RowSelectorHeaderStyle.SeparateElement;
            this.DisplayLayout.Override.RowSelectorNumberStyle  = RowSelectorNumberStyle.VisibleIndex;

            this.DisplayLayout.Override.RowSelectorAppearance.TextHAlign = HAlign.Center;
            this.DisplayLayout.Override.RowSelectorAppearance.TextVAlign = VAlign.Middle;
            this.DisplayLayout.Override.RowSelectorWidth = 52;
            this.DisplayLayout.Override.RowSelectorAppearance.FontData.Bold = DefaultableBoolean.True;

            this.DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation.Copy | AllowMultiCellOperation.Cut | AllowMultiCellOperation.Paste);

            this.DisplayLayout.Override.AllowColMoving = AllowColMoving.NotAllowed;

            this.DisplayLayout.Bands[0].Override.ButtonStyle = UIElementButtonStyle.ScenicRibbonButton;
            this.DisplayLayout.Bands[0].ColHeaderLines = 2;

            this.DisplayLayout.ScrollBarLook.ViewStyle = ScrollBarViewStyle.Office2010;

            this.DisplayLayout.Override.DefaultRowHeight = 25;

            // Corner rounding
            this.DisplayLayout.BorderStyle = UIElementBorderStyle.Rounded4Thick;

            //Rectangle gridRect = new Rectangle(Point.Empty, this.Size);
            //this.Region = DrawUtility.CreateBorderRegion(gridRect, this.DisplayLayout.BorderStyle);

            this.DrawFilter = new ImmasGridDrawFilter(this);

            Font font = new Font("맑은 고딕", 9F, FontStyle.Regular);
            this.Font = font;
        }

        private void Initialize_ColorSetting()
        {
            this.DisplayLayout.Override.ActiveRowAppearance.BackColor   = Color.Empty;
            this.DisplayLayout.Override.ActiveRowAppearance.ForeColor   = Color.Black;

            this.DisplayLayout.Override.SelectedRowAppearance.BackColor = CommonColorSet.ActiveRowBackColor;
            this.DisplayLayout.Override.SelectedRowAppearance.ForeColor = Color.Black;

            this.DisplayLayout.Override.ActiveCellAppearance.BackColor              = CommonColorSet.ActiveCellBackColor;
            this.DisplayLayout.Override.ActiveCellAppearance.BorderColor            = Color.FromArgb(64, 64, 64);
            this.DisplayLayout.Override.ActiveCellColumnHeaderAppearance.BackColor  = CommonColorSet.ActiveCellBackColor;
            this.DisplayLayout.Override.ActiveCellBorderThickness = 1;

            this.DisplayLayout.Override.HeaderAppearance.BackColor      = CommonColorSet.BrightGray;
            this.DisplayLayout.Override.HeaderAppearance.BorderColor    = Color.Gray;
            this.DisplayLayout.Override.RowSelectorAppearance.BackColor = CommonColorSet.NormalGray;

            this.DisplayLayout.Override.RowAppearance.BackColor          = Color.White;
            this.DisplayLayout.Override.RowAlternateAppearance.BackColor = CommonColorSet.RowAlternateColor;

            this.DisplayLayout.Override.BorderStyleHeader = UIElementBorderStyle.Solid;
        }
        #endregion

        #region [ Etc Methods            ]
        public bool IsCellEditable(UltraGridCell cell)
        {
            if (cell is UltraGridFilterCell) return true;

            // EditMode로 들어갈 수 없는 경우 Edit 불가.
            if (cell.CanEnterEditMode == false) return false;

            // 삭제 할 Row는 더이상 Edit 불가
            if (cell.Row.GetDataRow().RowState == DataRowState.Deleted) return false;

            return true;
        }
        #endregion

        #region [ ContextMenuSettings    ]
        private ContextMenuStrip CreateContextMenu(UIElement element)
        {
            ContextMenuStrip strip = new ContextMenuStrip();
            ToolStripMenuItem item = null;
            
            ColumnHeader header = (ColumnHeader)element.GetContext(typeof(ColumnHeader));

            // 행 추가
            item         = new ToolStripMenuItem("행 추가", Properties.Resources.new_16);
            item.Name    = "add";
            item.Click   += this.HandleContextMenuMouseClick;
            item.ShortcutKeys = (Keys.Control | Keys.N);
            item.Enabled = false;
            item.Tag     = header;
            strip.Items.Add(item);

            // 행 삭제
            item         = new ToolStripMenuItem("행 삭제", Properties.Resources.delete_16);
            item.Name    = "delete";
            item.Click   += this.HandleContextMenuMouseClick;
            item.ShortcutKeys = (Keys.Control | Keys.D);
            item.Enabled = false;
            item.Tag     = header;
            strip.Items.Add(item);

            // 행 편집
            item         = new ToolStripMenuItem("셀 편집", Properties.Resources.edit_16);
            item.Name    = "edit";
            item.Click   += this.HandleContextMenuMouseClick;
            item.ShortcutKeys = (Keys.F2);
            item.Enabled = false;
            item.Tag     = header;
            strip.Items.Add(item);

            strip.Items.Add(new ToolStripSeparator());

            // 복사
            item = new ToolStripMenuItem("복사", Properties.Resources.copy_16);
            item.Name   = "copy";
            item.Click  += this.HandleContextMenuMouseClick;
            item.ShortcutKeys = (Keys.Control | Keys.C);
            item.Enabled = false;
            item.Tag    = header;
            strip.Items.Add(item);

            // 붙여넣기
            item        = new ToolStripMenuItem("붙여넣기", Properties.Resources.paste_16);
            item.Name   = "paste";
            item.Click  += this.HandleContextMenuMouseClick;
            item.ShortcutKeys = (Keys.Control | Keys.V);
            item.Enabled = false;
            item.Tag    = header;
            strip.Items.Add(item);

            strip.Items.Add(new ToolStripSeparator());

            // 엑셀 내보내기
            item        = new ToolStripMenuItem("Excel로 내보내기", Properties.Resources.excel_16);
            item.Name   = "excel";
            item.Click  += this.HandleContextMenuMouseClick;
            item.Enabled = true;
            item.Tag    = header;
            strip.Items.Add(item);

            // 구분선
            strip.Items.Add(new ToolStripSeparator());

            // 열 필터
            item        = new ToolStripMenuItem("열 필터", Properties.Resources.filter_16);
            item.Name   = "filter";
            item.Click  += HandleContextMenuMouseClick;
            item.Enabled = false;
            item.Tag    = header;
            strip.Items.Add(item);

            // 오름차순
            item        = new ToolStripMenuItem("오름차순", Properties.Resources.asc_16);
            item.Name   = "asc";
            item.Click  += HandleContextMenuMouseClick;
            item.Enabled = false;
            item.Tag    = header;
            strip.Items.Add(item);

            // 내림차순
            item        = new ToolStripMenuItem("내림차순", Properties.Resources.desc_16);
            item.Name   = "desc";
            item.Click  += HandleContextMenuMouseClick;
            item.Enabled = false;
            item.Tag    = header;
            strip.Items.Add(item);

            // 정렬없음
            item        = new ToolStripMenuItem("정렬없음", null);
            item.Name   = "none";
            item.Click  += HandleContextMenuMouseClick;
            item.Enabled = false;
            item.Tag    = header;
            strip.Items.Add(item);

            return strip;
        }
        private void HandleContextMenuMouseClick(object sender, EventArgs args)
        {
            ToolStripMenuItem menuItem  = (ToolStripMenuItem)sender;
            UltraGridColumn column      = ((ColumnHeader)menuItem.Tag)?.Column;
            
            switch (menuItem.Name)
            {
                case "add"       : this.AddNew()                                        ; break;
                case "delete"    : this.RemoveCurrent()                                 ; break;
                case "edit"      : this.PerformAction(UltraGridAction.EnterEditMode)    ; break;
                case "excel"     : this.PerformExportToExcel()                          ; break;
                case "filter"    : this.PerformFilter(column)                           ; break;
                case "copy"      : this.PerformAction(UltraGridAction.Copy)             ; UpdateData() ; break;
                case "paste"     : this.PerformAction(UltraGridAction.Paste)            ; UpdateData(); break;
                case "asc"       : this.PerformSort(column, ImmasSortOrder.Asc)         ; break;
                case "desc"      : this.PerformSort(column, ImmasSortOrder.Desc)        ; break;
                case "none"      : this.PerformSort(null, ImmasSortOrder.None)          ; break;
            }
        }

        private void PerformExportToExcel()
        {
        }

        private void PerformSort(UltraGridColumn column, ImmasSortOrder sortOrder)
        {
            // 기존에 적용 된 정렬을 제거
            this.DefaultBand.SortedColumns.Clear();

            if (column != null)
            {
                switch (sortOrder)
                {
                    case ImmasSortOrder.Asc:
                        this.DefaultBand.SortedColumns.Add(column, false);
                        break;

                    case ImmasSortOrder.Desc:
                        this.DefaultBand.SortedColumns.Add(column, true);
                        break;
                }
            }
            // 새로 적용한 정렬을 적용하여 화면 갱신.
            this.DefaultBand.SortedColumns.RefreshSort(true);
        }
        private void PerformFilter(UltraGridColumn column)
        {
            FilterPopupForm popupForm = new FilterPopupForm(this, column);
            popupForm.ShowDialog();
        }
        private void AdjustContextMenuItems(ContextMenuStrip strip, UIElement element)
        {
            // 복사 & 붙여넣기는 UltraGridCell을 우클릭 했을 경우에만 활성화
            if (element.GetContext() is UltraGridColumn)
            {
                strip.Items["add"].Enabled      = true;
                strip.Items["delete"].Enabled   = true;
                strip.Items["edit"].Enabled     = true;
                strip.Items["copy"].Enabled     = true;
                strip.Items["paste"].Enabled    = true;
            }

            if (element.GetContext() is ColumnHeader)
            {
                strip.Items["filter"].Enabled = true;
                strip.Items["asc"].Enabled    = true;
                strip.Items["desc"].Enabled   = true;
                strip.Items["none"].Enabled   = true;
            }
        }
        #endregion

        #region [ Load Grid Schema       ]
        public void LoadGridSchema(string fileName)
        {
            BinaryFormatter binary = new BinaryFormatter();
            using (var stream = new FileStream(@"Forms\" + fileName, FileMode.Open))
            {
                var gridSchema = binary.Deserialize(stream) as ImmasGridSchemaCollection;
                this.SetGridSchema(gridSchema);
            }
        }
        private void SetGridSchema(ImmasGridSchemaCollection gridSchemaCollection)
        {
            if (gridSchemaCollection.Count == 0) return;

            foreach (ImmasGridSchema column in gridSchemaCollection)
            {
                this.SetColumn(column.Key, column.Caption, column.ColumnStyle, column.Width
                              , HAlign.Center, VAlign.Middle
                              , column.PrimaryKey, column.ReadOnly, column.Hidden);
            }
        }

        public void SetColumnAutoResize()
        {
            if (this.Rows.Count > 0)
            {
                foreach (UltraGridColumn column in this.DisplayLayout.Bands[0].Columns)
                {
                    int originalWidth = column.Width;
                    column.PerformAutoResize(PerformAutoSizeType.AllRowsInBand);
                    column.Width = column.Width + 10;

                    if (column.Width < originalWidth)
                    {
                        column.Width = originalWidth;
                    }
                }
            }
        }
        #endregion

        #region [ Grid CRUD              ]
        public UltraGridRow AddNew()
        {
            UltraGridRow row = this.DefaultBand.AddNew();
            this.UpdateData();
            
            return row;
        }

        public void RemoveCurrent()
        {
            // 삭제를 허용하지 않는 경우에는 빠져나감.
            if (this.AllowDelete == false) return;

            if (this.ActiveCell != null)
            {
                if (this.Selected.Cells.All.Length == 0) this.ActiveCell.Selected = true;

                foreach(UltraGridCell cell in this.Selected.Cells.All)
                {
                    cell.Row.Selected = true;
                }
            }
            if(this.Selected.Rows.Count > 0)
            {
                this.DeleteSelectedRows(false);
            }
        }

        private void OnDataSourceChanged()
        {
            if (this.DataSource is DataTable)
            {
                this.ChangeRowStateFilter();
            }

            this.ActiveCell = null;
            this.ActiveRow = null;
        }

        private void ChangeRowStateFilter()
        {
            var dt = this.DataSource as DataTable;
            dt.DefaultView.RowStateFilter = dt.DefaultView.RowStateFilter | DataViewRowState.Deleted;
        }

        public DataTable InsertSave()
        {
            var dt = this.DataSource as DataTable;
            return dt.GetChanges(DataRowState.Added);
        }

        public DataTable UpdateSave()
        {
            var dt = this.DataSource as DataTable;
            return dt.GetChanges(DataRowState.Modified);
        }

        public DataTable DeleteSave()
        {
            var dt = this.DataSource as DataTable;
            return dt.GetChanges(DataRowState.Deleted);
        }
        #endregion
    }
}

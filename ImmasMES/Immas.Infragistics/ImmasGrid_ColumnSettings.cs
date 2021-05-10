using Immas.DataAccess;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using System.Data;
using ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle;

namespace Immas.Infragistics
{
    public partial class ImmasGrid
    {
        public UltraGridColumn AddColumn(string key)
        {
            UltraGridColumn col = this.DefaultBand.Columns.Add(key);
            return col;
        }
        public void SetColumnStyle(string key, int width = -1, string caption = "")
        {
            // set width
            if (width > -1) this.DefaultBand.Columns[key].Width = width;

            // set caption
            if (caption != "") this.DefaultBand.Columns[key].Header.Caption = caption;
        }

        public void SetColumn(string key, string caption = "", ImmasColumnStyle columnStyle = ImmasColumnStyle.Normal, int width = -1, HAlign halign = HAlign.Center, VAlign valign = VAlign.Middle, bool primaryKey = false, bool readOnly = false, bool hidden = false)
        {
            // set key
            UltraGridColumn column = this.DefaultBand.Columns.Add(key);

            // set header align
            this.DefaultBand.Columns[key].Header.Appearance.TextHAlign = HAlign.Center;

            // set caption
            if (caption != "") this.DefaultBand.Columns[key].Header.Caption = caption;

            // set columnType
            switch (columnStyle)
            {
                case (ImmasColumnStyle.TextBox):
                case (ImmasColumnStyle.Normal):
                    this.DefaultBand.Columns[key].Style = ColumnStyle.Edit;
                    break;
                case (ImmasColumnStyle.CheckBox):
                    this.DefaultBand.Columns[key].Style = ColumnStyle.CheckBox;
                    break;
                case (ImmasColumnStyle.ComboBox):
                    this.DefaultBand.Columns[key].Style = ColumnStyle.DropDown;
                    this.DefaultBand.Columns[key].ButtonDisplayStyle = ButtonDisplayStyle.Always;
                    break;
                case (ImmasColumnStyle.Button):
                    this.DefaultBand.Columns[key].Style = ColumnStyle.Button;
                    break;
            }

            // set width
            if (width > -1) this.DefaultBand.Columns[key].Width = width;

            // set Vertical align
            switch (valign)
            {
                case (VAlign.Top):

                    this.DefaultBand.Columns[key].CellAppearance.TextVAlign = VAlign.Top;
                    break;
                case (VAlign.Middle):
                    this.DefaultBand.Columns[key].CellAppearance.TextVAlign = VAlign.Middle;
                    break;
                case (VAlign.Bottom):
                    this.DefaultBand.Columns[key].CellAppearance.TextVAlign = VAlign.Bottom;
                    break;
                case (VAlign.Default):
                    this.DefaultBand.Columns[key].CellAppearance.TextVAlign = VAlign.Default;
                    break;
            }

            // set Horizontal align
            switch (halign)
            {
                case (HAlign.Center):
                    this.DefaultBand.Columns[key].CellAppearance.TextHAlign = HAlign.Center;
                    break;
                case (HAlign.Left):
                    this.DefaultBand.Columns[key].CellAppearance.TextHAlign = HAlign.Left;
                    break;
                case (HAlign.Right):
                    this.DefaultBand.Columns[key].CellAppearance.TextHAlign = HAlign.Right;
                    break;
                case (HAlign.Default):
                    this.DefaultBand.Columns[key].CellAppearance.TextHAlign = HAlign.Default;
                    break;
            }

            // set hidden
            if (hidden)
                this.DefaultBand.Columns[key].Hidden = true;

            if (readOnly == true)
            {
                this.ReadOnlyColumns[key] = column;
            }

            // set primaryKey
            if (primaryKey == true)
            {
                this.PrimaryKeyColumns[key] = column;
            }
        }

        public void AddComboBoxValue(string colName, string code, string name)
        {
            if (!this.DisplayLayout.ValueLists.Exists(colName))
            {
                this.DisplayLayout.ValueLists.Add(colName);
            }
            this.DisplayLayout.ValueLists[colName].ValueListItems.Add(code, name);
            this.DefaultBand.Columns[colName].ValueList = this.DisplayLayout.ValueLists[colName];
        }
        public void AddComboBoxValue(string colName, DataRow row)
        {
            var code = row["CODE"].ToString();
            var name = row["NAME"].ToString();

            if (!this.DisplayLayout.ValueLists.Exists(colName))
            {
                this.DisplayLayout.ValueLists.Add(colName);
            }
            this.DisplayLayout.ValueLists[colName].ValueListItems.Add(code, name);
            this.DefaultBand.Columns[colName].ValueList = this.DisplayLayout.ValueLists[colName];
        }

        public void SetComboBoxValue(string colName, string masterCode)
        {
            DataTable dt = CommonDao.GetInstance().ComboBoxCodeSelect(masterCode);
            if (dt == null) return;

            foreach (DataRow row in dt.Rows)
            {
                this.AddComboBoxValue(colName, row);
            }
        }
    }
}

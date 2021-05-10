using Infragistics.Win.UltraWinGrid;
using System;
using System.Data;

namespace Immas.Infragistics.Extension
{
    public static class UltraGridRowExtension
    {
        public static DataRow GetDataRow(this UltraGridRow row)
        {
            DataRowView rowView = row.ListObject as DataRowView;
            if (rowView == null) throw new Exception("this grid does not bind to DataTable.");

            return rowView.Row;
        }
    }
}

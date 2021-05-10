using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Immas.Forms.Controls
{
    public enum ImmasColumnType
    {
        TextBox = 0,
        Combobox = 1
    }

    public delegate void AfterRowAddedEventHandler(object sender, DataRow row);

    public class ImmasGrid : DataGridView
    {
        public event AfterRowAddedEventHandler AfterRowAdded;

        public ImmasGrid()
        {
        }

        public void Initialize()
        {
            this.AllowDrop             = false;
            this.AllowUserToAddRows    = false;
            this.AllowUserToDeleteRows = false;

            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ColumnHeadersHeight = 30;
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 235, 235);
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb( 64,  64,  64);
            this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.EnableHeadersVisualStyles = false;

            this.DataSourceChanged += this.ImmasGrid_DataSourceChanged;
        }

        private void ImmasGrid_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.DataSource is DataTable)
            {
                this.DataSource = new BindingSource(this.DataSource, "");
            }
        }

        public void AddColumn(ImmasColumnType columnStyle, string colName, string caption)
        {
            DataGridViewColumn column = null;

            switch (columnStyle)
            {
                case ImmasColumnType.TextBox:
                    column = new DataGridViewTextBoxColumn();
                    break;

                case ImmasColumnType.Combobox:
                    column = new DataGridViewComboBoxColumn();
                    break;
            }
            
            column.ValueType        = typeof(string);
            column.Name             = colName;
            column.DataPropertyName = colName;
            column.HeaderText       = caption;

            this.AfterColumnCreate(column);

            this.Columns.Add(column);
        }
        private void AfterColumnCreate(DataGridViewColumn column)
        {
            if (column is DataGridViewComboBoxColumn)
            {
                DataGridViewComboBoxColumn comboBoxColumn = (DataGridViewComboBoxColumn)column;

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("CODE_VALUE", typeof(string));
                dataTable.Columns.Add("CODE_DESC",  typeof(string));

                comboBoxColumn.DataSource    = dataTable;
                comboBoxColumn.ValueMember   = "CODE_VALUE";
                comboBoxColumn.DisplayMember = "CODE_DESC";
            }
        }

        public void SetColumnStyle(string colName, int width = -1)
        {
            if (this.Columns.Contains(colName) == false) throw new Exception($"Column [{colName}] does not exist.");

            DataGridViewColumn column = this.Columns[colName];

            if (width > -1)
            {
                column.Width = width;
            }
        }

        public void AddComboBoxValue(string colName, string codeValue, string codeDesc)
        {
            if (this.Columns.Contains(colName) == false) throw new Exception($"Column [{colName}] does not exist.");

            DataGridViewComboBoxColumn column = (DataGridViewComboBoxColumn)this.Columns[colName];

            DataTable codeTable = (DataTable)column.DataSource;

            DataRow newRow = codeTable.NewRow();
            newRow["CODE_VALUE"] = codeValue;
            newRow["CODE_DESC"] = codeDesc;

            codeTable.Rows.Add(newRow);
        }
        public void SetComboboxValues(string colName, DataTable valueTable, string valueMemberName, string displayMemberName)
        {
            if (this.Columns.Contains(colName) == false) throw new Exception($"Column [{colName}] does not exist.");

            DataGridViewComboBoxColumn column = (DataGridViewComboBoxColumn)this.Columns[colName];

            foreach(DataRow dataRow in valueTable.Rows)
            {
                this.AddComboBoxValue(colName, (string)dataRow[valueMemberName], (string)dataRow[displayMemberName]);
            }
        }

        public DataRow AddNew()
        {
            BindingSource bs = (BindingSource)this.DataSource;
            DataRow dataRow = ((DataRowView)bs.AddNew()).Row;

            this.AfterRowAdded?.Invoke(this, dataRow);
            return dataRow;
        }
        public void RemoveCurrent()
        {
            BindingSource bs = (BindingSource)this.DataSource;
            bs.RemoveCurrent();
        }
    }
}
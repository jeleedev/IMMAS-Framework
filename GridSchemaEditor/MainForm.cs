using Immas.Infragistics;
using Immas.Infragistics.BaseForm;
using Immas.Infragistics.Dialog;
using Infragistics.Win;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GridSchemaEditor
{
    public partial class MainForm : BaseForm
    {
        #region [ Properties             ]
        private string FilePath { get; set; } 
        #endregion

        #region [ Initialize             ]
        public MainForm()
        {
            InitializeComponent();
        }

        public override void AfterFormLoad()
        {
            this.immasGrid1.AllowDrop = true;
            
            this.InitEventHandlers();
            this.InitGrid();
        }

        private void InitEventHandlers()
        {
            this.immasGrid1.DragDrop  += ImmasGrid1_DragDrop;
            this.immasGrid1.DragEnter += ImmasGrid1_DragEnter;
        }

        private void InitGrid()
        {
            this.immasGrid1.SetColumn("Key"         , caption: "Key"         ,   columnStyle: ImmasColumnStyle.TextBox, width: 100);
            this.immasGrid1.SetColumn("Caption"     , caption: "Caption"     ,   columnStyle: ImmasColumnStyle.TextBox, width: 100);
            this.immasGrid1.SetColumn("ColumnStyle" , caption: "ColumnStyle" ,   columnStyle: ImmasColumnStyle.ComboBox, width: 120);
            this.immasGrid1.SetColumn("Width"       , caption: "Width"       ,   columnStyle: ImmasColumnStyle.TextBox, width: 100);
            this.immasGrid1.SetColumn("HAlign"      , caption: "HAlign"      ,   columnStyle: ImmasColumnStyle.ComboBox, width: 120);
            this.immasGrid1.SetColumn("VAlign"      , caption: "VAlign"      ,   columnStyle: ImmasColumnStyle.ComboBox, width: 120);
            this.immasGrid1.SetColumn("PrimaryKey"  , caption: "PrimaryKey"  ,   columnStyle: ImmasColumnStyle.CheckBox, width: 80);
            this.immasGrid1.SetColumn("ReadOnly"    , caption: "ReadOnly"    ,   columnStyle: ImmasColumnStyle.CheckBox, width: 80);
            this.immasGrid1.SetColumn("Hidden"      , caption: "Hidden"      ,   columnStyle: ImmasColumnStyle.CheckBox, width: 80);

            this.immasGrid1.AddComboBoxValue("ColumnStyle", ((int)ImmasColumnStyle.TextBox).ToString()  , ImmasColumnStyle.TextBox.ToString());
            this.immasGrid1.AddComboBoxValue("ColumnStyle", ((int)ImmasColumnStyle.CheckBox).ToString() , ImmasColumnStyle.CheckBox.ToString());
            this.immasGrid1.AddComboBoxValue("ColumnStyle", ((int)ImmasColumnStyle.ComboBox).ToString() , ImmasColumnStyle.ComboBox.ToString());
            this.immasGrid1.AddComboBoxValue("ColumnStyle", ((int)ImmasColumnStyle.Button).ToString()   , ImmasColumnStyle.Button.ToString());
            this.immasGrid1.AddComboBoxValue("ColumnStyle", ((int)ImmasColumnStyle.DateTime).ToString() , ImmasColumnStyle.DateTime.ToString());

            this.immasGrid1.AddComboBoxValue("HAlign", ((int)HAlign.Center).ToString()  , HAlign.Center.ToString());
            this.immasGrid1.AddComboBoxValue("HAlign", ((int)HAlign.Left).ToString()    , HAlign.Left.ToString());
            this.immasGrid1.AddComboBoxValue("HAlign", ((int)HAlign.Right).ToString()   , HAlign.Right.ToString());
            this.immasGrid1.AddComboBoxValue("HAlign", ((int)HAlign.Default).ToString() , HAlign.Default.ToString());

            this.immasGrid1.AddComboBoxValue("VAlign", ((int)VAlign.Top).ToString()     , VAlign.Top.ToString());
            this.immasGrid1.AddComboBoxValue("VAlign", ((int)VAlign.Bottom).ToString()  , VAlign.Bottom.ToString());
            this.immasGrid1.AddComboBoxValue("VAlign", ((int)VAlign.Middle).ToString()  , VAlign.Middle.ToString());
            this.immasGrid1.AddComboBoxValue("VAlign", ((int)VAlign.Default).ToString(), VAlign.Default.ToString());

            this.Font = new Font("Gothic A1", 9F);
        }
        #endregion

        #region [ Event handler methods  ]
        private void ImmasGrid1_DragDrop(object sender, DragEventArgs e)
        {
            // 파일을 끌어다 놨을 때 동작
            try
            {
                this.FilePath = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];

                // 역직렬화
                BinaryDeserialize(this.FilePath);
            }
            catch (Exception ex) { }
        }
        private void ImmasGrid1_DragEnter(object sender, DragEventArgs e)
        {
            // 파일을 그리드 영역 내로 끌어왔을 때 동작
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable dt = this.immasGrid1.DataSource as DataTable;
            if (dt == null)
            {
                dt = new DataTable();
                dt.Columns.Add("Key");
                dt.Columns.Add("Caption");
                dt.Columns.Add("ColumnStyle");
                dt.Columns.Add("Width");
                dt.Columns.Add("HAlign");
                dt.Columns.Add("VAlign");
                dt.Columns.Add("PrimaryKey");
                dt.Columns.Add("ReadOnly");
                dt.Columns.Add("Hidden");
            }
            DataRow row = dt.NewRow();
            row["ColumnStyle"]  = (int)ImmasColumnStyle.TextBox;
            row["Width"]        = 100;
            row["HAlign"]       = (int)HAlign.Center;
            row["VAlign"]       = (int)VAlign.Middle;
            row["PrimaryKey"]   = false;
            row["ReadOnly"]     = false;
            row["Hidden"]       = false;

            dt.Rows.Add(row);
            this.immasGrid1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.immasGrid1.RemoveCurrent();
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            if (this.FilePath == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialog.DefaultExt = "grd";
                saveFileDialog.Filter = "(*.grd)|*.grd";
                saveFileDialog.OverwritePrompt = true;

                if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

                this.FilePath = saveFileDialog.FileName;
            }
            if (BinarySerialize() == true)
            {
                DialogHelper.ShowDialog("그리드 설정이 저장되었습니다.");
                BinaryDeserialize(this.FilePath);
            }
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.grd)|*.grd";
            DialogResult dialogResult = ofd.ShowDialog();
            if (dialogResult != DialogResult.OK) return;

            BinaryDeserialize(ofd.FileName);
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            this.txtPath.Text   = "";
            this.txtViewID.Text = "";
            this.FilePath       = string.Empty;
        }
        #endregion

        #region [ Methods                ]
        #region [ BinarySerialize ]
        bool BinarySerialize()
        {
            try
            {
                var data = GetData();

                BinaryFormatter binary = new BinaryFormatter();
                using (var stream = new FileStream(this.FilePath, FileMode.Create))
                {
                    binary.Serialize(stream, data);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        void BinaryDeserialize(string fileName)
        {
            this.FilePath = fileName;

            BinaryFormatter binary = new BinaryFormatter();
            using (var stream = new FileStream(this.FilePath, FileMode.Open))
            {
                var data = binary.Deserialize(stream) as ImmasGridSchemaCollection;

                SetData(data);
            }
            //
            //
            //
            this.txtPath.Text   = this.FilePath;
            this.txtViewID.Text = this.FilePath.Substring(this.FilePath.LastIndexOf('\\') + 1).Replace(".grd", "");
        }
        #endregion

        #region [ XmlSerialize ]
        void XmlSerialize()
        {
            var data = GetData();

            using (var stream = new FileStream(this.FilePath, FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(ImmasGridSchemaCollection));
                serializer.Serialize(stream, data);
            }
        }
        void XmlDeserialize()
        {
            using (var stream = new FileStream(this.FilePath, FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(ImmasGridSchemaCollection));
                var data = serializer.Deserialize(stream) as ImmasGridSchemaCollection;
                //
                //
                //
                SetData(data);
            }
        }
        #endregion

        private ImmasGridSchemaCollection GetData()
        {
            var dt = this.immasGrid1.DataSource as DataTable;
            ImmasGridSchemaCollection columnCollection = new ImmasGridSchemaCollection();

            if (dt == null) return null;

            foreach (DataRow row in dt.Rows)
            {
                if (row.RowState == DataRowState.Deleted) continue;
                ImmasGridSchema column = new ImmasGridSchema();
                
                column.Key          = row["Key"].ToString();
                column.Caption      = row["Caption"].ToString();
                column.ColumnStyle  = (ImmasColumnStyle)int.Parse(row["ColumnStyle"].ToString());
                column.Width        = int.Parse(row["Width"].ToString() == "" ? "0" : row["Width"].ToString());
                column.HAlign       = (HAlign)int.Parse(row["HAlign"].ToString());
                column.VAlign       = (VAlign)int.Parse(row["VAlign"].ToString());
                column.Hidden       = bool.Parse(row["Hidden"].ToString()     == "" ? "false" : row["Hidden"].ToString());
                column.ReadOnly     = bool.Parse(row["ReadOnly"].ToString()   == "" ? "false" : row["ReadOnly"].ToString());
                column.PrimaryKey   = bool.Parse(row["PrimaryKey"].ToString() == "" ? "false" : row["PrimaryKey"].ToString());

                columnCollection.Add(column);
            }
            return columnCollection;
        }
        private void SetData(ImmasGridSchemaCollection data)
        {
            if (data.Count == 0) return;

            var dt = this.immasGrid1.DataSource as DataTable;
            if(dt != null) { dt.Clear(); }

            if (dt == null)
            {
                dt = new DataTable();
                dt.Columns.Add("Key");
                dt.Columns.Add("Caption");
                dt.Columns.Add("ColumnStyle");
                dt.Columns.Add("Width");
                dt.Columns.Add("HAlign");
                dt.Columns.Add("VAlign");
                dt.Columns.Add("PrimaryKey");
                dt.Columns.Add("ReadOnly");
                dt.Columns.Add("Hidden");
            }

            foreach (ImmasGridSchema column in data)
            {
                DataRow row = dt.NewRow();

                row["Key"]          = column.Key;
                row["Caption"]      = column.Caption;
                row["ColumnStyle"]  = (int)column.ColumnStyle;
                row["Width"]        = column.Width;
                row["HAlign"]       = (int)column.HAlign;
                row["VAlign"]       = (int)column.VAlign;
                row["PrimaryKey"]   = column.PrimaryKey;
                row["ReadOnly"]     = column.ReadOnly;
                row["Hidden"]       = column.Hidden;

                dt.Rows.Add(row);
            }
            dt.AcceptChanges();
            this.immasGrid1.DataSource = dt;
        }
        #endregion
    }
}

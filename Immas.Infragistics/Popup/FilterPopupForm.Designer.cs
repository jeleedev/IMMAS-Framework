
namespace Immas.Infragistics.Popup
{
    partial class FilterPopupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            global::Infragistics.Win.Appearance appearance1 = new global::Infragistics.Win.Appearance();
            global::Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new global::Infragistics.Win.UltraWinGrid.UltraGridBand("", -1);
            global::Infragistics.Win.Appearance appearance2 = new global::Infragistics.Win.Appearance();
            global::Infragistics.Win.Appearance appearance3 = new global::Infragistics.Win.Appearance();
            global::Infragistics.Win.Appearance appearance4 = new global::Infragistics.Win.Appearance();
            global::Infragistics.Win.Appearance appearance5 = new global::Infragistics.Win.Appearance();
            global::Infragistics.Win.Appearance appearance6 = new global::Infragistics.Win.Appearance();
            global::Infragistics.Win.Appearance appearance7 = new global::Infragistics.Win.Appearance();
            global::Infragistics.Win.Appearance appearance8 = new global::Infragistics.Win.Appearance();
            global::Infragistics.Win.Appearance appearance9 = new global::Infragistics.Win.Appearance();
            global::Infragistics.Win.Appearance appearance10 = new global::Infragistics.Win.Appearance();
            global::Infragistics.Win.Appearance appearance11 = new global::Infragistics.Win.Appearance();
            global::Infragistics.Win.Appearance appearance12 = new global::Infragistics.Win.Appearance();
            global::Infragistics.Win.Appearance appearance13 = new global::Infragistics.Win.Appearance();
            global::Infragistics.Win.Appearance appearance14 = new global::Infragistics.Win.Appearance();
            global::Infragistics.Win.Appearance appearance15 = new global::Infragistics.Win.Appearance();
            global::Infragistics.Win.UltraWinScrollBar.ScrollBarLook scrollBarLook1 = new global::Infragistics.Win.UltraWinScrollBar.ScrollBarLook();
            this.btnOk = new global::Infragistics.Win.Misc.UltraButton();
            this.btnCancel = new global::Infragistics.Win.Misc.UltraButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnApply = new global::Infragistics.Win.Misc.UltraButton();
            this.immasGrid1 = new Immas.Infragistics.ImmasGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConditionAdd = new global::Infragistics.Win.Misc.UltraButton();
            this.rdbOR = new System.Windows.Forms.RadioButton();
            this.rdbAND = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.immasGrid1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOk.Location = new System.Drawing.Point(298, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(116, 29);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "확인";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(414, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 29);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "취소";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 414);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(535, 39);
            this.panel1.TabIndex = 4;
            // 
            // btnApply
            // 
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnApply.Location = new System.Drawing.Point(182, 5);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(116, 29);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "적용";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // immasGrid1
            // 
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.immasGrid1.DisplayLayout.Appearance = appearance1;
            ultraGridBand1.ColHeaderLines = 2;
            ultraGridBand1.Override.ButtonStyle = global::Infragistics.Win.UIElementButtonStyle.ScenicRibbonButton;
            ultraGridBand1.Override.RowSelectors = global::Infragistics.Win.DefaultableBoolean.True;
            this.immasGrid1.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.immasGrid1.DisplayLayout.BorderStyle = global::Infragistics.Win.UIElementBorderStyle.Solid;
            appearance2.TextHAlignAsString = "Left";
            appearance2.TextVAlignAsString = "Middle";
            this.immasGrid1.DisplayLayout.CaptionAppearance = appearance2;
            this.immasGrid1.DisplayLayout.CaptionVisible = global::Infragistics.Win.DefaultableBoolean.False;
            appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance3.BackGradientStyle = global::Infragistics.Win.GradientStyle.Vertical;
            appearance3.BorderColor = System.Drawing.SystemColors.Window;
            this.immasGrid1.DisplayLayout.GroupByBox.Appearance = appearance3;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.immasGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance4;
            this.immasGrid1.DisplayLayout.GroupByBox.BorderStyle = global::Infragistics.Win.UIElementBorderStyle.Solid;
            appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackColor2 = System.Drawing.SystemColors.Control;
            appearance5.BackGradientStyle = global::Infragistics.Win.GradientStyle.Horizontal;
            appearance5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.immasGrid1.DisplayLayout.GroupByBox.PromptAppearance = appearance5;
            this.immasGrid1.DisplayLayout.MaxColScrollRegions = 1;
            this.immasGrid1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            appearance6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            appearance6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.immasGrid1.DisplayLayout.Override.ActiveCellAppearance = appearance6;
            appearance7.ForeColor = System.Drawing.Color.Black;
            this.immasGrid1.DisplayLayout.Override.ActiveRowAppearance = appearance7;
            this.immasGrid1.DisplayLayout.Override.AllowColMoving = global::Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            this.immasGrid1.DisplayLayout.Override.AllowMultiCellOperations = ((global::Infragistics.Win.UltraWinGrid.AllowMultiCellOperation)(((global::Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Copy | global::Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Cut) 
            | global::Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Paste)));
            this.immasGrid1.DisplayLayout.Override.BorderStyleCell = global::Infragistics.Win.UIElementBorderStyle.Solid;
            this.immasGrid1.DisplayLayout.Override.BorderStyleHeader = global::Infragistics.Win.UIElementBorderStyle.Solid;
            this.immasGrid1.DisplayLayout.Override.BorderStyleRow = global::Infragistics.Win.UIElementBorderStyle.Solid;
            appearance8.BackColor = System.Drawing.SystemColors.Window;
            this.immasGrid1.DisplayLayout.Override.CardAreaAppearance = appearance8;
            appearance9.BorderColor = System.Drawing.Color.Silver;
            appearance9.TextTrimming = global::Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.immasGrid1.DisplayLayout.Override.CellAppearance = appearance9;
            this.immasGrid1.DisplayLayout.Override.CellClickAction = global::Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect;
            this.immasGrid1.DisplayLayout.Override.CellPadding = 0;
            this.immasGrid1.DisplayLayout.Override.DefaultRowHeight = 25;
            appearance10.BackColor = System.Drawing.SystemColors.Control;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance10.BackGradientAlignment = global::Infragistics.Win.GradientAlignment.Element;
            appearance10.BackGradientStyle = global::Infragistics.Win.GradientStyle.Horizontal;
            appearance10.BorderColor = System.Drawing.SystemColors.Window;
            this.immasGrid1.DisplayLayout.Override.GroupByRowAppearance = appearance10;
            appearance11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            appearance11.TextHAlignAsString = "Left";
            this.immasGrid1.DisplayLayout.Override.HeaderAppearance = appearance11;
            this.immasGrid1.DisplayLayout.Override.HeaderClickAction = global::Infragistics.Win.UltraWinGrid.HeaderClickAction.Select;
            this.immasGrid1.DisplayLayout.Override.HeaderStyle = global::Infragistics.Win.HeaderStyle.Standard;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            appearance12.BorderColor = System.Drawing.Color.Silver;
            this.immasGrid1.DisplayLayout.Override.RowAppearance = appearance12;
            appearance13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            appearance13.TextHAlignAsString = "Right";
            appearance13.TextVAlignAsString = "Middle";
            this.immasGrid1.DisplayLayout.Override.RowSelectorAppearance = appearance13;
            this.immasGrid1.DisplayLayout.Override.RowSelectorHeaderStyle = global::Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement;
            this.immasGrid1.DisplayLayout.Override.RowSelectorNumberStyle = global::Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex;
            this.immasGrid1.DisplayLayout.Override.RowSelectors = global::Infragistics.Win.DefaultableBoolean.False;
            this.immasGrid1.DisplayLayout.Override.RowSelectorWidth = 60;
            appearance14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            appearance14.ForeColor = System.Drawing.Color.Black;
            this.immasGrid1.DisplayLayout.Override.SelectedRowAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.immasGrid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance15;
            scrollBarLook1.ViewStyle = global::Infragistics.Win.UltraWinScrollBar.ScrollBarViewStyle.Office2010;
            this.immasGrid1.DisplayLayout.ScrollBarLook = scrollBarLook1;
            this.immasGrid1.DisplayLayout.Scrollbars = global::Infragistics.Win.UltraWinGrid.Scrollbars.Vertical;
            this.immasGrid1.DisplayLayout.ScrollBounds = global::Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.immasGrid1.DisplayLayout.ScrollStyle = global::Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.immasGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.immasGrid1.Location = new System.Drawing.Point(0, 90);
            this.immasGrid1.Name = "immasGrid1";
            this.immasGrid1.Size = new System.Drawing.Size(535, 324);
            this.immasGrid1.TabIndex = 5;
            this.immasGrid1.Text = "immasGrid2";
            this.immasGrid1.UseOsThemes = global::Infragistics.Win.DefaultableBoolean.True;
            this.immasGrid1.ClickCellButton += new global::Infragistics.Win.UltraWinGrid.CellEventHandler(this.immasGrid1_ClickCellButton);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConditionAdd);
            this.panel2.Controls.Add(this.rdbOR);
            this.panel2.Controls.Add(this.rdbAND);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(535, 90);
            this.panel2.TabIndex = 6;
            // 
            // btnConditionAdd
            // 
            this.btnConditionAdd.Location = new System.Drawing.Point(78, 51);
            this.btnConditionAdd.Name = "btnConditionAdd";
            this.btnConditionAdd.Size = new System.Drawing.Size(94, 24);
            this.btnConditionAdd.TabIndex = 5;
            this.btnConditionAdd.Text = "조건 추가";
            this.btnConditionAdd.Click += new System.EventHandler(this.btnConditionAdd_Click);
            // 
            // rdbOR
            // 
            this.rdbOR.AutoSize = true;
            this.rdbOR.Location = new System.Drawing.Point(183, 23);
            this.rdbOR.Name = "rdbOR";
            this.rdbOR.Size = new System.Drawing.Size(74, 16);
            this.rdbOR.TabIndex = 3;
            this.rdbOR.Text = "또는(OR)";
            this.rdbOR.UseVisualStyleBackColor = true;
            // 
            // rdbAND
            // 
            this.rdbAND.AutoSize = true;
            this.rdbAND.Checked = true;
            this.rdbAND.Location = new System.Drawing.Point(78, 23);
            this.rdbAND.Name = "rdbAND";
            this.rdbAND.Size = new System.Drawing.Size(94, 16);
            this.rdbAND.TabIndex = 2;
            this.rdbAND.TabStop = true;
            this.rdbAND.Text = "그리고(AND)";
            this.rdbAND.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "리스트";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "조합";
            // 
            // FilterPopupForm
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(535, 453);
            this.Controls.Add(this.immasGrid1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilterPopupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "컬럼 필터: ";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.immasGrid1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private global::Infragistics.Win.Misc.UltraButton btnOk;
        private global::Infragistics.Win.Misc.UltraButton btnCancel;
        private System.Windows.Forms.Panel panel1;
        private ImmasGrid immasGrid1;
        private global::Infragistics.Win.Misc.UltraButton btnApply;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private global::Infragistics.Win.Misc.UltraButton btnConditionAdd;
        private System.Windows.Forms.RadioButton rdbOR;
        private System.Windows.Forms.RadioButton rdbAND;
        private System.Windows.Forms.Label label2;
    }
}

namespace Immas.Infragistics.Popup
{
    partial class ComboBoxPopupForm
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
            this.immasGrid1 = new Immas.Infragistics.ImmasGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.immasGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOk.Location = new System.Drawing.Point(90, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(116, 29);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "확인";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(206, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 29);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "취소";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 393);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(327, 39);
            this.panel1.TabIndex = 4;
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
            this.immasGrid1.Location = new System.Drawing.Point(0, 0);
            this.immasGrid1.Name = "immasGrid1";
            this.immasGrid1.Size = new System.Drawing.Size(327, 393);
            this.immasGrid1.TabIndex = 5;
            this.immasGrid1.Text = "immasGrid2";
            this.immasGrid1.UseOsThemes = global::Infragistics.Win.DefaultableBoolean.True;
            // 
            // ComboBoxPopupForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(327, 432);
            this.Controls.Add(this.immasGrid1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComboBoxPopupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PopupForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.immasGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private global::Infragistics.Win.Misc.UltraButton btnOk;
        private global::Infragistics.Win.Misc.UltraButton btnCancel;
        private System.Windows.Forms.Panel panel1;
        private ImmasGrid immasGrid1;
    }
}
namespace TestProject
{
    partial class SY0003
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("", -1);
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinScrollBar.ScrollBarLook scrollBarLook1 = new Infragistics.Win.UltraWinScrollBar.ScrollBarLook();
            this.grdMaster = new Immas.Infragistics.ImmasGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMaster
            // 
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.grdMaster.DisplayLayout.Appearance = appearance1;
            ultraGridBand1.ColHeaderLines = 2;
            ultraGridBand1.Override.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ScenicRibbonButton;
            ultraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True;
            this.grdMaster.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.grdMaster.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded4Thick;
            appearance2.TextHAlignAsString = "Left";
            appearance2.TextVAlignAsString = "Middle";
            this.grdMaster.DisplayLayout.CaptionAppearance = appearance2;
            this.grdMaster.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance3.BorderColor = System.Drawing.SystemColors.Window;
            this.grdMaster.DisplayLayout.GroupByBox.Appearance = appearance3;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.grdMaster.DisplayLayout.GroupByBox.BandLabelAppearance = appearance4;
            this.grdMaster.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackColor2 = System.Drawing.SystemColors.Control;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.grdMaster.DisplayLayout.GroupByBox.PromptAppearance = appearance5;
            this.grdMaster.DisplayLayout.MaxColScrollRegions = 1;
            this.grdMaster.DisplayLayout.MaxRowScrollRegions = 1;
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            appearance6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            appearance6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grdMaster.DisplayLayout.Override.ActiveCellAppearance = appearance6;
            appearance7.ForeColor = System.Drawing.Color.Black;
            this.grdMaster.DisplayLayout.Override.ActiveRowAppearance = appearance7;
            this.grdMaster.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            this.grdMaster.DisplayLayout.Override.AllowMultiCellOperations = ((Infragistics.Win.UltraWinGrid.AllowMultiCellOperation)(((Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Copy | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Cut) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Paste)));
            this.grdMaster.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid;
            this.grdMaster.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Solid;
            this.grdMaster.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance8.BackColor = System.Drawing.SystemColors.Window;
            this.grdMaster.DisplayLayout.Override.CardAreaAppearance = appearance8;
            appearance9.BorderColor = System.Drawing.Color.Silver;
            appearance9.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.grdMaster.DisplayLayout.Override.CellAppearance = appearance9;
            this.grdMaster.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect;
            this.grdMaster.DisplayLayout.Override.CellPadding = 0;
            this.grdMaster.DisplayLayout.Override.DefaultRowHeight = 25;
            appearance10.BackColor = System.Drawing.SystemColors.Control;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance10.BorderColor = System.Drawing.SystemColors.Window;
            this.grdMaster.DisplayLayout.Override.GroupByRowAppearance = appearance10;
            appearance11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            appearance11.TextHAlignAsString = "Left";
            this.grdMaster.DisplayLayout.Override.HeaderAppearance = appearance11;
            this.grdMaster.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.Select;
            this.grdMaster.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            appearance12.BorderColor = System.Drawing.Color.Silver;
            this.grdMaster.DisplayLayout.Override.RowAppearance = appearance12;
            appearance13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            appearance13.TextHAlignAsString = "Right";
            appearance13.TextVAlignAsString = "Middle";
            this.grdMaster.DisplayLayout.Override.RowSelectorAppearance = appearance13;
            this.grdMaster.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement;
            this.grdMaster.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex;
            this.grdMaster.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.grdMaster.DisplayLayout.Override.RowSelectorWidth = 60;
            appearance14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            appearance14.ForeColor = System.Drawing.Color.Black;
            this.grdMaster.DisplayLayout.Override.SelectedRowAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grdMaster.DisplayLayout.Override.TemplateAddRowAppearance = appearance15;
            scrollBarLook1.ViewStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarViewStyle.Office2010;
            this.grdMaster.DisplayLayout.ScrollBarLook = scrollBarLook1;
            this.grdMaster.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.grdMaster.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.grdMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMaster.Font = new System.Drawing.Font("Gothic A1", 9F);
            this.grdMaster.Location = new System.Drawing.Point(10, 10);
            this.grdMaster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdMaster.Name = "grdMaster";
            this.grdMaster.Size = new System.Drawing.Size(606, 339);
            this.grdMaster.TabIndex = 0;
            this.grdMaster.Text = "immasGrid1";
            this.grdMaster.UseOsThemes = Infragistics.Win.DefaultableBoolean.True;
            // 
            // SY0003
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 359);
            this.Controls.Add(this.grdMaster);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SY0003";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "SY0003";
            ((System.ComponentModel.ISupportInitialize)(this.grdMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Immas.Infragistics.ImmasGrid grdMaster;
    }
}
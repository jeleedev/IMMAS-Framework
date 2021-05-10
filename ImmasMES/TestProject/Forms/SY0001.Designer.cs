namespace TestProject
{
    partial class SY0001
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
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinScrollBar.ScrollBarLook scrollBarLook1 = new Infragistics.Win.UltraWinScrollBar.ScrollBarLook();
            this.grdMaster = new Immas.Infragistics.ImmasGrid();
            this.immasSearchPanel1 = new Immas.Infragistics.Controls.ImmasSearchPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpENTER = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.immasTextBox1 = new Immas.Infragistics.Controls.ImmasTextBox();
            this.txtUSER_ID = new Immas.Infragistics.Controls.ImmasTextBox();
            this.txtUSER_NAME = new Immas.Infragistics.Controls.ImmasTextBox();
            this.txtRANK_CODE = new Immas.Infragistics.Controls.ImmasTextBox();
            this.immasBizRuleManager1 = new Immas.Infragistics.Controls.ImmasBizRuleManager();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaster)).BeginInit();
            this.immasSearchPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpENTER)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMaster
            // 
            this.immasBizRuleManager1.SetApplyBizRule(this.grdMaster, false);
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.grdMaster.DisplayLayout.Appearance = appearance1;
            ultraGridBand1.ColHeaderLines = 2;
            ultraGridBand1.Override.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ScenicRibbonButton;
            appearance2.TextHAlignAsString = "Center";
            ultraGridBand1.Override.RowSelectorHeaderAppearance = appearance2;
            ultraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True;
            this.grdMaster.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.grdMaster.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded4Thick;
            appearance3.TextHAlignAsString = "Left";
            appearance3.TextVAlignAsString = "Middle";
            this.grdMaster.DisplayLayout.CaptionAppearance = appearance3;
            this.grdMaster.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance4.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance4.BorderColor = System.Drawing.SystemColors.Window;
            this.grdMaster.DisplayLayout.GroupByBox.Appearance = appearance4;
            appearance5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.grdMaster.DisplayLayout.GroupByBox.BandLabelAppearance = appearance5;
            this.grdMaster.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance6.BackColor2 = System.Drawing.SystemColors.Control;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.grdMaster.DisplayLayout.GroupByBox.PromptAppearance = appearance6;
            this.grdMaster.DisplayLayout.MaxColScrollRegions = 1;
            this.grdMaster.DisplayLayout.MaxRowScrollRegions = 1;
            appearance7.BackColor = System.Drawing.Color.LightSkyBlue;
            appearance7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            appearance7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grdMaster.DisplayLayout.Override.ActiveCellAppearance = appearance7;
            appearance8.ForeColor = System.Drawing.Color.Black;
            this.grdMaster.DisplayLayout.Override.ActiveRowAppearance = appearance8;
            this.grdMaster.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            this.grdMaster.DisplayLayout.Override.AllowMultiCellOperations = ((Infragistics.Win.UltraWinGrid.AllowMultiCellOperation)(((Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Copy | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Cut) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Paste)));
            this.grdMaster.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid;
            this.grdMaster.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Solid;
            this.grdMaster.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance9.BackColor = System.Drawing.SystemColors.Window;
            this.grdMaster.DisplayLayout.Override.CardAreaAppearance = appearance9;
            appearance10.BorderColor = System.Drawing.Color.Silver;
            appearance10.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.grdMaster.DisplayLayout.Override.CellAppearance = appearance10;
            this.grdMaster.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect;
            this.grdMaster.DisplayLayout.Override.CellPadding = 0;
            this.grdMaster.DisplayLayout.Override.DefaultRowHeight = 25;
            appearance11.BackColor = System.Drawing.SystemColors.Control;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance11.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance11.BorderColor = System.Drawing.SystemColors.Window;
            this.grdMaster.DisplayLayout.Override.GroupByRowAppearance = appearance11;
            appearance12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            appearance12.BorderColor = System.Drawing.Color.Gray;
            appearance12.FontData.BoldAsString = "True";
            appearance12.TextHAlignAsString = "Left";
            this.grdMaster.DisplayLayout.Override.HeaderAppearance = appearance12;
            this.grdMaster.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.Select;
            this.grdMaster.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard;
            appearance13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.grdMaster.DisplayLayout.Override.RowAlternateAppearance = appearance13;
            appearance14.BackColor = System.Drawing.Color.White;
            appearance14.BorderColor = System.Drawing.Color.Silver;
            this.grdMaster.DisplayLayout.Override.RowAppearance = appearance14;
            appearance15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            appearance15.FontData.BoldAsString = "True";
            appearance15.TextHAlignAsString = "Center";
            appearance15.TextVAlignAsString = "Middle";
            this.grdMaster.DisplayLayout.Override.RowSelectorAppearance = appearance15;
            appearance16.FontData.BoldAsString = "True";
            appearance16.TextHAlignAsString = "Center";
            this.grdMaster.DisplayLayout.Override.RowSelectorHeaderAppearance = appearance16;
            this.grdMaster.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement;
            this.grdMaster.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex;
            this.grdMaster.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.grdMaster.DisplayLayout.Override.RowSelectorWidth = 45;
            appearance17.BackColor = System.Drawing.Color.LightSkyBlue;
            appearance17.ForeColor = System.Drawing.Color.Black;
            this.grdMaster.DisplayLayout.Override.SelectedRowAppearance = appearance17;
            appearance18.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grdMaster.DisplayLayout.Override.TemplateAddRowAppearance = appearance18;
            scrollBarLook1.ViewStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarViewStyle.Office2010;
            this.grdMaster.DisplayLayout.ScrollBarLook = scrollBarLook1;
            this.grdMaster.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.grdMaster.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.grdMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMaster.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.grdMaster.Location = new System.Drawing.Point(10, 85);
            this.grdMaster.Name = "grdMaster";
            this.grdMaster.Size = new System.Drawing.Size(780, 355);
            this.grdMaster.TabIndex = 3;
            this.grdMaster.Text = "immasGrid1";
            this.grdMaster.UseOsThemes = Infragistics.Win.DefaultableBoolean.True;
            // 
            // immasSearchPanel1
            // 
            this.immasBizRuleManager1.SetApplyBizRule(this.immasSearchPanel1, false);
            this.immasSearchPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.immasSearchPanel1.Controls.Add(this.tableLayoutPanel1);
            this.immasSearchPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.immasSearchPanel1.Location = new System.Drawing.Point(10, 10);
            this.immasSearchPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.immasSearchPanel1.Name = "immasSearchPanel1";
            this.immasSearchPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.immasSearchPanel1.Size = new System.Drawing.Size(780, 75);
            this.immasSearchPanel1.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.immasBizRuleManager1.SetApplyBizRule(this.tableLayoutPanel1, false);
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 390F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpENTER, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.immasTextBox1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUSER_ID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUSER_NAME, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtRANK_CODE, 1, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Gothic A1", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 59);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // label1
            // 
            this.immasBizRuleManager1.SetApplyBizRule(this.label1, false);
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Gothic A1", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "사원 ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpENTER
            // 
            this.immasBizRuleManager1.SetApplyBizRule(this.dtpENTER, false);
            this.dtpENTER.AutoSize = false;
            this.dtpENTER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpENTER.Font = new System.Drawing.Font("Gothic A1", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpENTER.Location = new System.Drawing.Point(271, 32);
            this.dtpENTER.Margin = new System.Windows.Forms.Padding(0, 3, 2, 3);
            this.dtpENTER.Name = "dtpENTER";
            this.dtpENTER.Size = new System.Drawing.Size(120, 21);
            this.dtpENTER.TabIndex = 16;
            // 
            // label3
            // 
            this.immasBizRuleManager1.SetApplyBizRule(this.label3, false);
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Gothic A1", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "직급(직책)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.immasBizRuleManager1.SetApplyBizRule(this.label4, false);
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Gothic A1", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(191, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "입사일자";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.immasBizRuleManager1.SetApplyBizRule(this.label2, false);
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Gothic A1", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(191, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "사원명";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.immasBizRuleManager1.SetApplyBizRule(this.button1, false);
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(396, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 20;
            this.button1.Text = "Readonly";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // immasTextBox1
            // 
            this.immasBizRuleManager1.SetApplyBizRule(this.immasTextBox1, false);
            this.immasTextBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.immasTextBox1.Location = new System.Drawing.Point(396, 6);
            this.immasTextBox1.Name = "immasTextBox1";
            this.immasTextBox1.Size = new System.Drawing.Size(100, 20);
            this.immasTextBox1.TabIndex = 25;
            this.immasTextBox1.Visible = false;
            // 
            // txtUSER_ID
            // 
            this.immasBizRuleManager1.SetApplyBizRule(this.txtUSER_ID, true);
            this.txtUSER_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUSER_ID.Location = new System.Drawing.Point(86, 5);
            this.txtUSER_ID.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.txtUSER_ID.Name = "txtUSER_ID";
            this.txtUSER_ID.Size = new System.Drawing.Size(100, 22);
            this.txtUSER_ID.TabIndex = 26;
            // 
            // txtUSER_NAME
            // 
            this.immasBizRuleManager1.SetApplyBizRule(this.txtUSER_NAME, true);
            this.txtUSER_NAME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUSER_NAME.Location = new System.Drawing.Point(271, 5);
            this.txtUSER_NAME.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.txtUSER_NAME.Name = "txtUSER_NAME";
            this.txtUSER_NAME.Size = new System.Drawing.Size(120, 22);
            this.txtUSER_NAME.TabIndex = 28;
            // 
            // txtRANK_CODE
            // 
            this.immasBizRuleManager1.SetApplyBizRule(this.txtRANK_CODE, true);
            this.txtRANK_CODE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRANK_CODE.Location = new System.Drawing.Point(86, 31);
            this.txtRANK_CODE.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.txtRANK_CODE.Name = "txtRANK_CODE";
            this.txtRANK_CODE.Size = new System.Drawing.Size(100, 23);
            this.txtRANK_CODE.TabIndex = 29;
            // 
            // SY0001
            // 
            this.immasBizRuleManager1.SetApplyBizRule(this, false);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdMaster);
            this.Controls.Add(this.immasSearchPanel1);
            this.Name = "SY0001";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "SY0001";
            ((System.ComponentModel.ISupportInitialize)(this.grdMaster)).EndInit();
            this.immasSearchPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpENTER)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Immas.Infragistics.ImmasGrid grdMaster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor dtpENTER;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private Immas.Infragistics.Controls.ImmasBizRuleManager immasBizRuleManager1;
        private Immas.Infragistics.Controls.ImmasTextBox immasTextBox1;
        private Immas.Infragistics.Controls.ImmasTextBox txtUSER_ID;
        private Immas.Infragistics.Controls.ImmasTextBox txtUSER_NAME;
        private Immas.Infragistics.Controls.ImmasTextBox txtRANK_CODE;
        private Immas.Infragistics.Controls.ImmasSearchPanel immasSearchPanel1;
    }
}
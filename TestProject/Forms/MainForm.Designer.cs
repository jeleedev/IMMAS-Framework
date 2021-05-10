namespace TestProject
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.formMenuBrowser1 = new Immas.Infragistics.Controls.FormMenuBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDoInquiry = new System.Windows.Forms.ToolStripButton();
            this.btnDoAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDoDelete = new System.Windows.Forms.ToolStripButton();
            this.btnDoSave = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlExplorer = new System.Windows.Forms.Panel();
            this.lblExplorer = new System.Windows.Forms.Label();
            this.lblLine1 = new System.Windows.Forms.Label();
            this.lblLine2 = new System.Windows.Forms.Label();
            this.lblLine3 = new System.Windows.Forms.Label();
            this.immasTabbedMdiManager1 = new Immas.Infragistics.ImmasTabbedMdiManager();
            this.toolStrip1.SuspendLayout();
            this.pnlExplorer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.immasTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // formMenuBrowser1
            // 
            this.formMenuBrowser1.AutoSize = false;
            this.formMenuBrowser1.BackColor = System.Drawing.Color.White;
            this.formMenuBrowser1.Font = new System.Drawing.Font("Gothic A1", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.formMenuBrowser1.GripMargin = new System.Windows.Forms.Padding(0);
            this.formMenuBrowser1.Location = new System.Drawing.Point(0, 2);
            this.formMenuBrowser1.Name = "formMenuBrowser1";
            this.formMenuBrowser1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 0);
            this.formMenuBrowser1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.formMenuBrowser1.Size = new System.Drawing.Size(1207, 30);
            this.formMenuBrowser1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Font = new System.Drawing.Font("Gothic A1", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDoInquiry,
            this.btnDoAdd,
            this.btnDoDelete,
            this.btnDoSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 34);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1207, 60);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDoInquiry
            // 
            this.btnDoInquiry.AutoSize = false;
            this.btnDoInquiry.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDoInquiry.Font = new System.Drawing.Font("Gothic A1", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDoInquiry.Image = global::TestProject.Properties.Resources.search_16;
            this.btnDoInquiry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDoInquiry.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnDoInquiry.Name = "btnDoInquiry";
            this.btnDoInquiry.Size = new System.Drawing.Size(60, 60);
            this.btnDoInquiry.Text = "조회";
            this.btnDoInquiry.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoInquiry.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnDoInquiry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDoInquiry.ToolTipText = "조회(F5)";
            this.btnDoInquiry.Click += new System.EventHandler(this.btnDoInquiry_Click);
            // 
            // btnDoAdd
            // 
            this.btnDoAdd.AutoSize = false;
            this.btnDoAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDoAdd.Font = new System.Drawing.Font("Gothic A1", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDoAdd.Image = global::TestProject.Properties.Resources.new_16;
            this.btnDoAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDoAdd.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnDoAdd.Name = "btnDoAdd";
            this.btnDoAdd.Size = new System.Drawing.Size(60, 60);
            this.btnDoAdd.Text = "추가";
            this.btnDoAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDoAdd.ToolTipText = "추가(Ctrl+N)";
            this.btnDoAdd.Click += new System.EventHandler(this.btnDoAdd_Click);
            // 
            // btnDoDelete
            // 
            this.btnDoDelete.AutoSize = false;
            this.btnDoDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDoDelete.Font = new System.Drawing.Font("Gothic A1", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDoDelete.Image = global::TestProject.Properties.Resources.delete_16;
            this.btnDoDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDoDelete.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnDoDelete.Name = "btnDoDelete";
            this.btnDoDelete.Size = new System.Drawing.Size(60, 60);
            this.btnDoDelete.Text = "삭제";
            this.btnDoDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDoDelete.ToolTipText = "삭제(Ctrl+D)";
            this.btnDoDelete.Click += new System.EventHandler(this.btnDoDelete_Click);
            // 
            // btnDoSave
            // 
            this.btnDoSave.AutoSize = false;
            this.btnDoSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDoSave.Font = new System.Drawing.Font("Gothic A1", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDoSave.Image = global::TestProject.Properties.Resources.save_16;
            this.btnDoSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDoSave.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnDoSave.Name = "btnDoSave";
            this.btnDoSave.Size = new System.Drawing.Size(60, 60);
            this.btnDoSave.Text = "저장";
            this.btnDoSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDoSave.ToolTipText = "저장(Ctrl+S)";
            this.btnDoSave.Click += new System.EventHandler(this.btnDoSave_Click);
            // 
            // pnlExplorer
            // 
            this.pnlExplorer.Controls.Add(this.lblExplorer);
            this.pnlExplorer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlExplorer.Location = new System.Drawing.Point(0, 626);
            this.pnlExplorer.Name = "pnlExplorer";
            this.pnlExplorer.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pnlExplorer.Size = new System.Drawing.Size(1207, 26);
            this.pnlExplorer.TabIndex = 7;
            // 
            // lblExplorer
            // 
            this.lblExplorer.BackColor = System.Drawing.Color.White;
            this.lblExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExplorer.Font = new System.Drawing.Font("Gothic A1", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblExplorer.Image = global::TestProject.Properties.Resources.explorer_16;
            this.lblExplorer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblExplorer.Location = new System.Drawing.Point(3, 0);
            this.lblExplorer.Name = "lblExplorer";
            this.lblExplorer.Size = new System.Drawing.Size(1204, 26);
            this.lblExplorer.TabIndex = 0;
            this.lblExplorer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLine1
            // 
            this.lblLine1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblLine1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLine1.Location = new System.Drawing.Point(0, 0);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(1207, 2);
            this.lblLine1.TabIndex = 10;
            // 
            // lblLine2
            // 
            this.lblLine2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblLine2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLine2.Location = new System.Drawing.Point(0, 32);
            this.lblLine2.Name = "lblLine2";
            this.lblLine2.Size = new System.Drawing.Size(1207, 2);
            this.lblLine2.TabIndex = 11;
            // 
            // lblLine3
            // 
            this.lblLine3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblLine3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLine3.Location = new System.Drawing.Point(0, 94);
            this.lblLine3.Name = "lblLine3";
            this.lblLine3.Size = new System.Drawing.Size(1207, 2);
            this.lblLine3.TabIndex = 12;
            // 
            // immasTabbedMdiManager1
            // 
            this.immasTabbedMdiManager1.ActiveTabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.immasTabbedMdiManager1.ActiveTabBorderColor = System.Drawing.Color.Empty;
            this.immasTabbedMdiManager1.ActiveTabForeColor = System.Drawing.Color.Black;
            appearance1.BorderColor = System.Drawing.Color.White;
            appearance1.BorderColor2 = System.Drawing.Color.White;
            appearance1.FontData.BoldAsString = "False";
            appearance1.FontData.Name = "Gothic A1 SemiBold";
            appearance1.ImageHAlign = Infragistics.Win.HAlign.Left;
            appearance1.ImageVAlign = Infragistics.Win.VAlign.Middle;
            this.immasTabbedMdiManager1.Appearance = appearance1;
            this.immasTabbedMdiManager1.BorderStyle = Infragistics.Win.UltraWinTabbedMdi.MdiClientBorderStyle.Inset;
            this.immasTabbedMdiManager1.DisplayCloseButton = true;
            this.immasTabbedMdiManager1.DisplayFormIcon = true;
            this.immasTabbedMdiManager1.MdiParent = this;
            this.immasTabbedMdiManager1.TabBackColor = System.Drawing.Color.Gray;
            this.immasTabbedMdiManager1.TabBorderColor = System.Drawing.Color.Transparent;
            this.immasTabbedMdiManager1.TabForeColor = System.Drawing.Color.White;
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.immasTabbedMdiManager1.TabGroupSettings.TabAreaAppearance = appearance2;
            this.immasTabbedMdiManager1.TabGroupSettings.TabAreaMargins.Bottom = 2;
            this.immasTabbedMdiManager1.TabGroupSettings.TabAreaMargins.Left = 2;
            this.immasTabbedMdiManager1.TabGroupSettings.TabAreaMargins.Right = 2;
            this.immasTabbedMdiManager1.TabGroupSettings.TabAreaMargins.Top = 2;
            this.immasTabbedMdiManager1.TabGroupSettings.TabHeight = 28;
            this.immasTabbedMdiManager1.TabGroupSettings.TabStyle = Infragistics.Win.UltraWinTabs.TabStyle.Flat;
            this.immasTabbedMdiManager1.TabHeight = 28;
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            appearance3.ForeColor = System.Drawing.Color.Black;
            this.immasTabbedMdiManager1.TabSettings.ActiveTabAppearance = appearance3;
            this.immasTabbedMdiManager1.TabSettings.DisplayFormIcon = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Gray;
            appearance4.BorderColor = System.Drawing.Color.Transparent;
            appearance4.ForeColor = System.Drawing.Color.White;
            appearance4.TextHAlignAsString = "Left";
            appearance4.TextVAlignAsString = "Middle";
            this.immasTabbedMdiManager1.TabSettings.TabAppearance = appearance4;
            this.immasTabbedMdiManager1.TabSettings.TabWidth = 120;
            this.immasTabbedMdiManager1.TabWidth = 120;
            this.immasTabbedMdiManager1.Tag = null;
            this.immasTabbedMdiManager1.TextHAlign = Infragistics.Win.HAlign.Left;
            this.immasTabbedMdiManager1.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1207, 652);
            this.Controls.Add(this.lblLine3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblLine2);
            this.Controls.Add(this.formMenuBrowser1);
            this.Controls.Add(this.lblLine1);
            this.Controls.Add(this.pnlExplorer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.formMenuBrowser1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMMAS Framework";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlExplorer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.immasTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Immas.Infragistics.Controls.FormMenuBrowser formMenuBrowser1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDoInquiry;
        private System.Windows.Forms.ToolStripButton btnDoAdd;
        private System.Windows.Forms.ToolStripButton btnDoDelete;
        private System.Windows.Forms.ToolStripButton btnDoSave;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlExplorer;
        private System.Windows.Forms.Label lblExplorer;
        private System.Windows.Forms.Label lblLine1;
        private System.Windows.Forms.Label lblLine2;
        private System.Windows.Forms.Label lblLine3;
        private Immas.Infragistics.ImmasTabbedMdiManager immasTabbedMdiManager1;
    }
}


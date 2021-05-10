namespace Immas.Infragistics.Dialog
{
    partial class DialogForm
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
            this.pnlYesNo = new System.Windows.Forms.TableLayoutPanel();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.pnlOkCancel = new System.Windows.Forms.TableLayoutPanel();
            this.btnOk2 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlOk = new System.Windows.Forms.TableLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.pnlYesNo.SuspendLayout();
            this.pnlOkCancel.SuspendLayout();
            this.pnlOk.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlYesNo
            // 
            this.pnlYesNo.ColumnCount = 4;
            this.pnlYesNo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlYesNo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.pnlYesNo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlYesNo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.pnlYesNo.Controls.Add(this.btnYes, 1, 0);
            this.pnlYesNo.Controls.Add(this.btnNo, 3, 0);
            this.pnlYesNo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlYesNo.Location = new System.Drawing.Point(15, 98);
            this.pnlYesNo.Name = "pnlYesNo";
            this.pnlYesNo.RowCount = 1;
            this.pnlYesNo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlYesNo.Size = new System.Drawing.Size(501, 28);
            this.pnlYesNo.TabIndex = 4;
            this.pnlYesNo.Visible = false;
            // 
            // btnYes
            // 
            this.btnYes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnYes.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.btnYes.Location = new System.Drawing.Point(261, 3);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(114, 22);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "예";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNo.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.btnNo.Location = new System.Drawing.Point(384, 3);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(114, 22);
            this.btnNo.TabIndex = 0;
            this.btnNo.Text = "아니오";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // pnlOkCancel
            // 
            this.pnlOkCancel.ColumnCount = 4;
            this.pnlOkCancel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlOkCancel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.pnlOkCancel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlOkCancel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.pnlOkCancel.Controls.Add(this.btnOk2, 1, 0);
            this.pnlOkCancel.Controls.Add(this.btnCancel, 3, 0);
            this.pnlOkCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOkCancel.Location = new System.Drawing.Point(15, 70);
            this.pnlOkCancel.Name = "pnlOkCancel";
            this.pnlOkCancel.RowCount = 1;
            this.pnlOkCancel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlOkCancel.Size = new System.Drawing.Size(501, 28);
            this.pnlOkCancel.TabIndex = 3;
            this.pnlOkCancel.Visible = false;
            // 
            // btnOk2
            // 
            this.btnOk2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOk2.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.btnOk2.Location = new System.Drawing.Point(261, 3);
            this.btnOk2.Name = "btnOk2";
            this.btnOk2.Size = new System.Drawing.Size(114, 22);
            this.btnOk2.TabIndex = 0;
            this.btnOk2.Text = "확인";
            this.btnOk2.UseVisualStyleBackColor = true;
            this.btnOk2.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.btnCancel.Location = new System.Drawing.Point(384, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 22);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlOk
            // 
            this.pnlOk.ColumnCount = 2;
            this.pnlOk.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlOk.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.pnlOk.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlOk.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlOk.Controls.Add(this.btnOk, 1, 0);
            this.pnlOk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOk.Location = new System.Drawing.Point(15, 42);
            this.pnlOk.Name = "pnlOk";
            this.pnlOk.RowCount = 1;
            this.pnlOk.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlOk.Size = new System.Drawing.Size(501, 28);
            this.pnlOk.TabIndex = 2;
            this.pnlOk.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOk.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.btnOk.Location = new System.Drawing.Point(384, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(114, 22);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "확인";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(15, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 10);
            this.panel2.TabIndex = 1;
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.White;
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.txtMessage.Location = new System.Drawing.Point(15, 15);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.ShortcutsEnabled = false;
            this.txtMessage.Size = new System.Drawing.Size(501, 17);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.TabStop = false;
            // 
            // DialogForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 141);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlOk);
            this.Controls.Add(this.pnlOkCancel);
            this.Controls.Add(this.pnlYesNo);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MinimumSize = new System.Drawing.Size(476, 180);
            this.Name = "DialogForm";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "알림 메시지";
            this.pnlYesNo.ResumeLayout(false);
            this.pnlOkCancel.ResumeLayout(false);
            this.pnlOk.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel pnlYesNo;
        private System.Windows.Forms.TableLayoutPanel pnlOkCancel;
        private System.Windows.Forms.TableLayoutPanel pnlOk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOk2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.TextBox txtMessage;
    }
}
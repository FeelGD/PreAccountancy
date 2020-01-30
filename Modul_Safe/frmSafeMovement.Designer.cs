namespace PreAccountancy.Modul_Safe
{
    partial class frmSafeMovement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSafeMovement));
            this.DocumentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Inflow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtBalance = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtOut = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtIn = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSafeName = new DevExpress.XtraEditors.TextEdit();
            this.DocumentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DocumentNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.rightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SetTransferCard = new System.Windows.Forms.ToolStripMenuItem();
            this.SetPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Outflow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtSafeCode = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSafeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.rightClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSafeCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // DocumentType
            // 
            this.DocumentType.Caption = "Evrak Türü";
            this.DocumentType.FieldName = "DocumentType";
            this.DocumentType.Name = "DocumentType";
            this.DocumentType.OptionsColumn.AllowEdit = false;
            this.DocumentType.OptionsColumn.AllowFocus = false;
            this.DocumentType.OptionsColumn.FixedWidth = true;
            this.DocumentType.Visible = true;
            this.DocumentType.VisibleIndex = 1;
            this.DocumentType.Width = 100;
            // 
            // Description
            // 
            this.Description.Caption = "Açıklama";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.OptionsColumn.AllowEdit = false;
            this.Description.OptionsColumn.AllowFocus = false;
            this.Description.Visible = true;
            this.Description.VisibleIndex = 5;
            this.Description.Width = 301;
            // 
            // Inflow
            // 
            this.Inflow.Caption = "Giriş";
            this.Inflow.FieldName = "Inflow";
            this.Inflow.Name = "Inflow";
            this.Inflow.OptionsColumn.AllowEdit = false;
            this.Inflow.OptionsColumn.AllowFocus = false;
            this.Inflow.OptionsColumn.FixedWidth = true;
            this.Inflow.Visible = true;
            this.Inflow.VisibleIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(412, 26);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Bakiye:";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(453, 23);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Properties.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(92, 20);
            this.txtBalance.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(284, 56);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(25, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Çıkış:";
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(315, 53);
            this.txtOut.Name = "txtOut";
            this.txtOut.Properties.ReadOnly = true;
            this.txtOut.Size = new System.Drawing.Size(92, 20);
            this.txtOut.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(285, 30);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Giriş:";
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(315, 23);
            this.txtIn.Name = "txtIn";
            this.txtIn.Properties.ReadOnly = true;
            this.txtIn.Size = new System.Drawing.Size(92, 20);
            this.txtIn.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Kasa Adı:";
            // 
            // txtSafeName
            // 
            this.txtSafeName.Location = new System.Drawing.Point(95, 49);
            this.txtSafeName.Name = "txtSafeName";
            this.txtSafeName.Properties.ReadOnly = true;
            this.txtSafeName.Size = new System.Drawing.Size(184, 20);
            this.txtSafeName.TabIndex = 2;
            // 
            // DocumentID
            // 
            this.DocumentID.Caption = "Evrak ID";
            this.DocumentID.FieldName = "DocumentID";
            this.DocumentID.Name = "DocumentID";
            this.DocumentID.OptionsColumn.AllowEdit = false;
            this.DocumentID.OptionsColumn.AllowFocus = false;
            this.DocumentID.OptionsColumn.FixedWidth = true;
            // 
            // DocumentNo
            // 
            this.DocumentNo.Caption = "Belge No";
            this.DocumentNo.FieldName = "DocumentNo";
            this.DocumentNo.Name = "DocumentNo";
            this.DocumentNo.OptionsColumn.AllowEdit = false;
            this.DocumentNo.OptionsColumn.AllowFocus = false;
            this.DocumentNo.OptionsColumn.FixedWidth = true;
            this.DocumentNo.Visible = true;
            this.DocumentNo.VisibleIndex = 0;
            this.DocumentNo.Width = 100;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Kasa Kodu:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 85);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(738, 397);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Hareket Listesi";
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.rightClick;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(734, 375);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // rightClick
            // 
            this.rightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetTransferCard,
            this.SetPayment});
            this.rightClick.Name = "rightClick";
            this.rightClick.Size = new System.Drawing.Size(247, 48);
            this.rightClick.Opening += new System.ComponentModel.CancelEventHandler(this.rightClick_Opening);
            // 
            // SetTransferCard
            // 
            this.SetTransferCard.Enabled = false;
            this.SetTransferCard.Name = "SetTransferCard";
            this.SetTransferCard.Size = new System.Drawing.Size(246, 22);
            this.SetTransferCard.Text = "Devir Kartı İşlemini Düzenle";
            this.SetTransferCard.Click += new System.EventHandler(this.SetTransferCard_Click);
            // 
            // SetPayment
            // 
            this.SetPayment.Enabled = false;
            this.SetPayment.Name = "SetPayment";
            this.SetPayment.Size = new System.Drawing.Size(246, 22);
            this.SetPayment.Text = "Tahsilat/Ödeme İşlemini Düzenle";
            this.SetPayment.Click += new System.EventHandler(this.SetPayment_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.DocumentNo,
            this.DocumentType,
            this.DocumentID,
            this.Inflow,
            this.Outflow,
            this.Description,
            this.Date});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridView1.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Outflow
            // 
            this.Outflow.Caption = "Çıkış";
            this.Outflow.FieldName = "Outflow";
            this.Outflow.Name = "Outflow";
            this.Outflow.OptionsColumn.AllowEdit = false;
            this.Outflow.OptionsColumn.AllowFocus = false;
            this.Outflow.OptionsColumn.FixedWidth = true;
            this.Outflow.Visible = true;
            this.Outflow.VisibleIndex = 4;
            // 
            // Date
            // 
            this.Date.Caption = "Tarih";
            this.Date.FieldName = "Date";
            this.Date.Name = "Date";
            this.Date.OptionsColumn.AllowEdit = false;
            this.Date.OptionsColumn.AllowFocus = false;
            this.Date.Visible = true;
            this.Date.VisibleIndex = 2;
            this.Date.Width = 67;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtBalance);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtOut);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtIn);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtSafeName);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtSafeCode);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(738, 85);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Banka Bilgileri";
            // 
            // txtSafeCode
            // 
            this.txtSafeCode.Location = new System.Drawing.Point(95, 23);
            this.txtSafeCode.Name = "txtSafeCode";
            this.txtSafeCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtSafeCode.Properties.ReadOnly = true;
            this.txtSafeCode.Size = new System.Drawing.Size(184, 20);
            this.txtSafeCode.TabIndex = 0;
            this.txtSafeCode.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtSafeCode_ButtonClick);
            // 
            // frmSafeMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 482);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSafeMovement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Hareketleri";
            this.Load += new System.EventHandler(this.frmSafeMovement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSafeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.rightClick.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSafeCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn Inflow;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtBalance;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtOut;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtIn;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSafeName;
        private DevExpress.XtraGrid.Columns.GridColumn DocumentID;
        private DevExpress.XtraGrid.Columns.GridColumn DocumentType;
        private DevExpress.XtraGrid.Columns.GridColumn DocumentNo;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Outflow;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ButtonEdit txtSafeCode;
        private System.Windows.Forms.ContextMenuStrip rightClick;
        private System.Windows.Forms.ToolStripMenuItem SetTransferCard;
        private System.Windows.Forms.ToolStripMenuItem SetPayment;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
    }
}
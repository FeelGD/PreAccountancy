namespace PreAccountancy.Modul_Bank
{
    partial class frmBankMovement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankMovement));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtBalance = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtOutflow = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtInflow = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtAccountNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAccountName = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.list = new DevExpress.XtraGrid.GridControl();
            this.rightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SetBankProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.SetBankTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DocumentNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DocumentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DocumentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Inflow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Outflow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutflow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInflow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            this.rightClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtBalance);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtOutflow);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtInflow);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtAccountNo);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtAccountName);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(880, 77);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Banka Bilgileri";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(473, 52);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Bakiye:";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(514, 49);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Properties.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(93, 20);
            this.txtBalance.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(343, 52);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(25, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Çıkış:";
            // 
            // txtOutflow
            // 
            this.txtOutflow.Location = new System.Drawing.Point(374, 49);
            this.txtOutflow.Name = "txtOutflow";
            this.txtOutflow.Properties.ReadOnly = true;
            this.txtOutflow.Size = new System.Drawing.Size(93, 20);
            this.txtOutflow.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(344, 26);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Giriş:";
            // 
            // txtInflow
            // 
            this.txtInflow.Location = new System.Drawing.Point(374, 23);
            this.txtInflow.Name = "txtInflow";
            this.txtInflow.Properties.ReadOnly = true;
            this.txtInflow.Size = new System.Drawing.Size(93, 20);
            this.txtInflow.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Hesap No:";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(95, 49);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Properties.ReadOnly = true;
            this.txtAccountNo.Size = new System.Drawing.Size(243, 20);
            this.txtAccountNo.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Hesap Türü/Adı:";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(95, 23);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtAccountName.Properties.ReadOnly = true;
            this.txtAccountName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtAccountName.Size = new System.Drawing.Size(243, 20);
            this.txtAccountName.TabIndex = 0;
            this.txtAccountName.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtAccountName_ButtonClick);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.list);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 77);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(880, 430);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Hareket Listesi";
            // 
            // list
            // 
            this.list.ContextMenuStrip = this.rightClick;
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.Location = new System.Drawing.Point(2, 20);
            this.list.MainView = this.gridView1;
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(876, 408);
            this.list.TabIndex = 0;
            this.list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // rightClick
            // 
            this.rightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetBankProcess,
            this.SetBankTransfer});
            this.rightClick.Name = "rightClick";
            this.rightClick.Size = new System.Drawing.Size(209, 48);
            this.rightClick.Opening += new System.ComponentModel.CancelEventHandler(this.rightClick_Opening);
            // 
            // SetBankProcess
            // 
            this.SetBankProcess.Enabled = false;
            this.SetBankProcess.Name = "SetBankProcess";
            this.SetBankProcess.Size = new System.Drawing.Size(208, 22);
            this.SetBankProcess.Text = "Banka İşlemini Düzenle";
            this.SetBankProcess.Click += new System.EventHandler(this.SetBankProcess_Click);
            // 
            // SetBankTransfer
            // 
            this.SetBankTransfer.Enabled = false;
            this.SetBankTransfer.Name = "SetBankTransfer";
            this.SetBankTransfer.Size = new System.Drawing.Size(208, 22);
            this.SetBankTransfer.Text = "Banka Transferini Düzenle";
            this.SetBankTransfer.Click += new System.EventHandler(this.SetBankTransfer_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.DocumentNo,
            this.DocumentType,
            this.DocumentID,
            this.Inflow,
            this.Outflow,
            this.Description,
            this.Date});
            this.gridView1.GridControl = this.list;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Id
            // 
            this.Id.Caption = "ID";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
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
            // DocumentID
            // 
            this.DocumentID.Caption = "Evrak ID";
            this.DocumentID.FieldName = "DocumentID";
            this.DocumentID.Name = "DocumentID";
            this.DocumentID.OptionsColumn.AllowEdit = false;
            this.DocumentID.OptionsColumn.AllowFocus = false;
            this.DocumentID.OptionsColumn.FixedWidth = true;
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
            // Description
            // 
            this.Description.Caption = "Açıklama";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.OptionsColumn.AllowEdit = false;
            this.Description.OptionsColumn.AllowFocus = false;
            this.Description.Visible = true;
            this.Description.VisibleIndex = 5;
            this.Description.Width = 435;
            // 
            // Date
            // 
            this.Date.Caption = "Tarih";
            this.Date.FieldName = "Date";
            this.Date.Name = "Date";
            this.Date.OptionsColumn.AllowEdit = false;
            this.Date.OptionsColumn.AllowFocus = false;
            this.Date.OptionsColumn.FixedWidth = true;
            this.Date.OptionsFilter.AllowAutoFilter = false;
            this.Date.OptionsFilter.AllowFilter = false;
            this.Date.Visible = true;
            this.Date.VisibleIndex = 2;
            // 
            // frmBankMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 507);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBankMovement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Hareketleri";
            this.Load += new System.EventHandler(this.frmBankMovement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutflow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInflow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            this.rightClick.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtBalance;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtOutflow;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtInflow;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtAccountNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl list;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn DocumentNo;
        private DevExpress.XtraGrid.Columns.GridColumn DocumentType;
        private DevExpress.XtraGrid.Columns.GridColumn DocumentID;
        private DevExpress.XtraGrid.Columns.GridColumn Inflow;
        private DevExpress.XtraGrid.Columns.GridColumn Outflow;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraEditors.ButtonEdit txtAccountName;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private System.Windows.Forms.ContextMenuStrip rightClick;
        private System.Windows.Forms.ToolStripMenuItem SetBankProcess;
        private System.Windows.Forms.ToolStripMenuItem SetBankTransfer;
    }
}
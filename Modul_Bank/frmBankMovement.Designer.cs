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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankMovement));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtBalance = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtOut = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtIn = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtAccountNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DocumentNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DocumentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DocumentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Login = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Exit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtAccountType = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountType.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.groupControl1.Controls.Add(this.txtAccountNo);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtAccountType);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(880, 107);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Banka Bilgileri";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(244, 78);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Bakiye:";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(285, 75);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(53, 20);
            this.txtBalance.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(154, 78);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(25, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Çıkış:";
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(185, 75);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(53, 20);
            this.txtOut.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Giriş:";
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(95, 75);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(53, 20);
            this.txtIn.TabIndex = 4;
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
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 107);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(880, 400);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Hareket Listesi";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(876, 378);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.DocumentNumber,
            this.DocumentType,
            this.DocumentID,
            this.Login,
            this.Exit,
            this.Description});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // DocumentNumber
            // 
            this.DocumentNumber.Caption = "Belge No";
            this.DocumentNumber.FieldName = "DocumentNumber";
            this.DocumentNumber.Name = "DocumentNumber";
            this.DocumentNumber.OptionsColumn.FixedWidth = true;
            this.DocumentNumber.Visible = true;
            this.DocumentNumber.VisibleIndex = 0;
            this.DocumentNumber.Width = 100;
            // 
            // DocumentType
            // 
            this.DocumentType.Caption = "Evrak Türü";
            this.DocumentType.FieldName = "DocumentType";
            this.DocumentType.Name = "DocumentType";
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
            this.DocumentID.OptionsColumn.FixedWidth = true;
            // 
            // Login
            // 
            this.Login.Caption = "Giriş";
            this.Login.FieldName = "Login";
            this.Login.Name = "Login";
            this.Login.OptionsColumn.FixedWidth = true;
            this.Login.Visible = true;
            this.Login.VisibleIndex = 2;
            // 
            // Exit
            // 
            this.Exit.Caption = "Çıkış";
            this.Exit.FieldName = "Exit";
            this.Exit.Name = "Exit";
            this.Exit.OptionsColumn.FixedWidth = true;
            this.Exit.Visible = true;
            this.Exit.VisibleIndex = 3;
            // 
            // Description
            // 
            this.Description.Caption = "Açıklama";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 4;
            this.Description.Width = 435;
            // 
            // txtAccountType
            // 
            this.txtAccountType.Location = new System.Drawing.Point(95, 23);
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtAccountType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtAccountType.Size = new System.Drawing.Size(243, 20);
            this.txtAccountType.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.txtOut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountType.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtBalance;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtOut;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtIn;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtAccountNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn DocumentNumber;
        private DevExpress.XtraGrid.Columns.GridColumn DocumentType;
        private DevExpress.XtraGrid.Columns.GridColumn DocumentID;
        private DevExpress.XtraGrid.Columns.GridColumn Login;
        private DevExpress.XtraGrid.Columns.GridColumn Exit;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraEditors.ButtonEdit txtAccountType;
    }
}
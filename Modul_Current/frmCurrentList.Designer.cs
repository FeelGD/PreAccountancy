﻿namespace PreAccountancy.Modul_Current
{
    partial class frmCurrentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurrentList));
            this.CurrentCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CurrentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridList = new DevExpress.XtraGrid.GridControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtCurrentGroup = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCurrentName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCurrentCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentCode.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentCode
            // 
            this.CurrentCode.Caption = "Cari Kodu";
            this.CurrentCode.FieldName = "CurrentCode";
            this.CurrentCode.Name = "CurrentCode";
            this.CurrentCode.OptionsColumn.AllowEdit = false;
            this.CurrentCode.OptionsColumn.AllowFocus = false;
            this.CurrentCode.OptionsColumn.FixedWidth = true;
            this.CurrentCode.Visible = true;
            this.CurrentCode.VisibleIndex = 0;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.Name = "ID";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.CurrentCode,
            this.CurrentName});
            this.gridView1.GridControl = this.gridList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // CurrentName
            // 
            this.CurrentName.Caption = "Cari Adı";
            this.CurrentName.FieldName = "CurrentName";
            this.CurrentName.Name = "CurrentName";
            this.CurrentName.OptionsColumn.AllowEdit = false;
            this.CurrentName.OptionsColumn.AllowFocus = false;
            this.CurrentName.OptionsColumn.FixedWidth = true;
            this.CurrentName.Visible = true;
            this.CurrentName.VisibleIndex = 1;
            // 
            // gridList
            // 
            this.gridList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridList.Location = new System.Drawing.Point(0, 0);
            this.gridList.MainView = this.gridView1;
            this.gridList.Name = "gridList";
            this.gridList.Size = new System.Drawing.Size(781, 442);
            this.gridList.TabIndex = 0;
            this.gridList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridList.DoubleClick += new System.EventHandler(this.gridList_DoubleClick);
            // 
            // btnClear
            // 
            this.btnClear.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClear.ImageOptions.SvgImage")));
            this.btnClear.Location = new System.Drawing.Point(92, 198);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 41);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Temizle";
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSearch.ImageOptions.SvgImage")));
            this.btnSearch.Location = new System.Drawing.Point(7, 198);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 41);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Ara";
            // 
            // txtCurrentGroup
            // 
            this.txtCurrentGroup.Location = new System.Drawing.Point(11, 161);
            this.txtCurrentGroup.Name = "txtCurrentGroup";
            this.txtCurrentGroup.Size = new System.Drawing.Size(152, 20);
            this.txtCurrentGroup.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 141);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Cari Grubu:";
            // 
            // txtCurrentName
            // 
            this.txtCurrentName.Location = new System.Drawing.Point(11, 111);
            this.txtCurrentName.Name = "txtCurrentName";
            this.txtCurrentName.Size = new System.Drawing.Size(152, 20);
            this.txtCurrentName.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Cari Adı:";
            // 
            // txtCurrentCode
            // 
            this.txtCurrentCode.Location = new System.Drawing.Point(11, 61);
            this.txtCurrentCode.Name = "txtCurrentCode";
            this.txtCurrentCode.Size = new System.Drawing.Size(152, 20);
            this.txtCurrentCode.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cari Kodu:";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnClear);
            this.xtraTabPage1.Controls.Add(this.btnSearch);
            this.xtraTabPage1.Controls.Add(this.txtCurrentGroup);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtCurrentName);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtCurrentCode);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(179, 414);
            this.xtraTabPage1.Text = "Arama";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(185, 442);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridList);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(971, 442);
            this.splitContainerControl1.SplitterPosition = 185;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // frmCurrentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 442);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCurrentList";
            this.Text = "Cari Listesi";
            this.Load += new System.EventHandler(this.frmCurrentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentCode.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn CurrentCode;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn CurrentName;
        private DevExpress.XtraGrid.GridControl gridList;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtCurrentGroup;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCurrentName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCurrentCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    }
}
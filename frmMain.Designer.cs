namespace PreAccountancy
{
    partial class frmMain
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnStockCard = new DevExpress.XtraBars.BarButtonItem();
            this.btnStockList = new DevExpress.XtraBars.BarButtonItem();
            this.btnStockGroup = new DevExpress.XtraBars.BarButtonItem();
            this.btnStockMovements = new DevExpress.XtraBars.BarButtonItem();
            this.PageStock = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barbtnCurrentOpeningCard = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnCurrentGroup = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnCurrentList = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnCurrentMovement = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnStockCard,
            this.btnStockList,
            this.btnStockGroup,
            this.btnStockMovements,
            this.barbtnCurrentOpeningCard,
            this.barbtnCurrentGroup,
            this.barbtnCurrentList,
            this.barbtnCurrentMovement});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.PageStock,
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(906, 162);
            // 
            // btnStockCard
            // 
            this.btnStockCard.Caption = "Stok Kartı";
            this.btnStockCard.Id = 1;
            this.btnStockCard.ImageOptions.Image = global::PreAccountancy.Properties.Resources.Stok_Kartı32x32;
            this.btnStockCard.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockCard.ItemAppearance.Normal.Options.UseFont = true;
            this.btnStockCard.Name = "btnStockCard";
            this.btnStockCard.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnStockCard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStockCard_ItemClick);
            // 
            // btnStockList
            // 
            this.btnStockList.Caption = "Stok Listesi";
            this.btnStockList.Id = 2;
            this.btnStockList.ImageOptions.Image = global::PreAccountancy.Properties.Resources.Stok_Liste32x32;
            this.btnStockList.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnStockList.ItemAppearance.Normal.Options.UseFont = true;
            this.btnStockList.Name = "btnStockList";
            this.btnStockList.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnStockList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStockList_ItemClick);
            // 
            // btnStockGroup
            // 
            this.btnStockGroup.Caption = "Stok Grup";
            this.btnStockGroup.Id = 3;
            this.btnStockGroup.ImageOptions.Image = global::PreAccountancy.Properties.Resources.Stok_Grup32x32;
            this.btnStockGroup.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnStockGroup.ItemAppearance.Normal.Options.UseFont = true;
            this.btnStockGroup.Name = "btnStockGroup";
            this.btnStockGroup.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnStockGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStockGroup_ItemClick);
            // 
            // btnStockMovements
            // 
            this.btnStockMovements.Caption = "Stok Hareketleri";
            this.btnStockMovements.Id = 4;
            this.btnStockMovements.ImageOptions.Image = global::PreAccountancy.Properties.Resources.Stok_Hareket32x32;
            this.btnStockMovements.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnStockMovements.ItemAppearance.Normal.Options.UseFont = true;
            this.btnStockMovements.Name = "btnStockMovements";
            this.btnStockMovements.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnStockMovements.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStockMovements_ItemClick);
            // 
            // PageStock
            // 
            this.PageStock.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.PageStock.ImageOptions.Image = global::PreAccountancy.Properties.Resources.Stok32x32;
            this.PageStock.Name = "PageStock";
            this.PageStock.Text = "Stok";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStockCard);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStockList);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStockGroup);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStockMovements);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.ImageOptions.Image = global::PreAccountancy.Properties.Resources.Cari32x32;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Cari";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtnCurrentOpeningCard);
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtnCurrentGroup);
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtnCurrentList);
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtnCurrentMovement);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Cari İşlemleri";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barbtnCurrentOpeningCard
            // 
            this.barbtnCurrentOpeningCard.Caption = "Cari Açılış kartı";
            this.barbtnCurrentOpeningCard.Id = 5;
            this.barbtnCurrentOpeningCard.ImageOptions.Image = global::PreAccountancy.Properties.Resources.Cari_Kart32x32;
            this.barbtnCurrentOpeningCard.Name = "barbtnCurrentOpeningCard";
            this.barbtnCurrentOpeningCard.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barbtnCurrentOpeningCard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnCurrentOpeningCard_ItemClick);
            // 
            // barbtnCurrentGroup
            // 
            this.barbtnCurrentGroup.Caption = "Cari Grupları";
            this.barbtnCurrentGroup.Id = 6;
            this.barbtnCurrentGroup.ImageOptions.Image = global::PreAccountancy.Properties.Resources.Cari_Grup32x32;
            this.barbtnCurrentGroup.Name = "barbtnCurrentGroup";
            this.barbtnCurrentGroup.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barbtnCurrentGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnCurrentGroup_ItemClick);
            // 
            // barbtnCurrentList
            // 
            this.barbtnCurrentList.Caption = "Cari Listesi";
            this.barbtnCurrentList.Id = 7;
            this.barbtnCurrentList.ImageOptions.Image = global::PreAccountancy.Properties.Resources.Cari_Liste32x32;
            this.barbtnCurrentList.Name = "barbtnCurrentList";
            this.barbtnCurrentList.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barbtnCurrentList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnCurrentList_ItemClick);
            // 
            // barbtnCurrentMovement
            // 
            this.barbtnCurrentMovement.Caption = "Cari Hareketleri";
            this.barbtnCurrentMovement.Id = 8;
            this.barbtnCurrentMovement.ImageOptions.Image = global::PreAccountancy.Properties.Resources.Cari_Hareket32x32;
            this.barbtnCurrentMovement.Name = "barbtnCurrentMovement";
            this.barbtnCurrentMovement.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barbtnCurrentMovement.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnCurrentMovement_ItemClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 480);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage PageStock;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnStockCard;
        private DevExpress.XtraBars.BarButtonItem btnStockList;
        private DevExpress.XtraBars.BarButtonItem btnStockGroup;
        private DevExpress.XtraBars.BarButtonItem btnStockMovements;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barbtnCurrentOpeningCard;
        private DevExpress.XtraBars.BarButtonItem barbtnCurrentGroup;
        private DevExpress.XtraBars.BarButtonItem barbtnCurrentList;
        private DevExpress.XtraBars.BarButtonItem barbtnCurrentMovement;
    }
}


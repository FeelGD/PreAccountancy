using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PreAccountancy.Modul_Stock
{
    public partial class frmStockCard : DevExpress.XtraEditors.XtraForm
    {

        Functions.DbDataContext DB = new Functions.DbDataContext();
        Functions.Messages Messages = new Functions.Messages();
        Functions.Number Numbers = new Functions.Number();
        Functions.Forms Forms = new Functions.Forms();
        Functions.Photos Photos = new Functions.Photos();

        bool Edit = false;
        bool SelectedPhoto = false;
        int GroupID = -1;
        int StockID = -1;

        OpenFileDialog File = new OpenFileDialog();


        public frmStockCard()
        {
            InitializeComponent();
           
        }

        private void frmStockCard_Load(object sender, EventArgs e)
        {
          txtStockCode.Text=Numbers.StockCodeNumber();

        }
        void Clear()
        {
            txtStockCode.Text = Numbers.StockCodeNumber();
            txtStockGroupCode.Text = "";
            txtStockGroupName.Text = "";
            txtStockName.Text = "";
            txtSaleTAX.Text = "0";
            txtSalePrice.Text = "0";
            txtPurchaseTAX.Text = "0";
            txtPurchasePrice.Text = "0";
            txtboxUnit.SelectedIndex = 0;
            txtBarcode.Text = "";
            Edit = false;
            SelectedPhoto = false;
            GroupID = -1;
            StockID = -1;
            frmMain.Transfer = -1;
            
        }

        void SelectPhoto()
        {
            File.Filter = "Jpg(*.jpg)|*.jpg|Jpeg(*.jpeg)|*.jpeg";
            if (File.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = File.FileName;
                SelectedPhoto = true;
            }
        }

        private void btnPictureSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
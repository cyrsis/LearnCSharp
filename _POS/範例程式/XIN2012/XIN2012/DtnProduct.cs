using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using System.Linq;

namespace XIN2012
{
    public partial class fmDtnProduct : XIN2012.fmBase
    {

        XINEntities context = new XINEntities();

        public fmDtnProduct()
        {
            InitializeComponent();
        }

        private void fmDtnProduct_Load(object sender, EventArgs e)
        {
            //指定BindingSource物件
            BS = productBindingSource;
            //指定主索引鍵的欄位名稱
            IDFieldName = "ProductID";
            //指定主索引鍵的資料表名稱
            TableName = "Product";
            string NewID;
            //取得主索引鍵最大值的LINQ to Entities
            NewID = (from M in context.Product
                     orderby M.ProductID descending
                     select M.ProductID).FirstOrDefault();
            if (NewID != null)
            {
                PrimaryID = NewID;
            }
            else
            {
                PrimaryID = "";
            }
            //移至主索引鍵最大值的記錄
            FillData();
            //是否允許刪除
            AllowDelete = true;
        }

        public override void FillData()
        {
            var qry = from M in context.Product
                      where M.ProductID == PrimaryID
                      select M;
            //將BindingSource物件繫結至資料來源
            productBindingSource.DataSource = qry;
        }

        public override bool BeforeEndEdit()
        {
            bool blnValidation = true;
            if (TBStatus == 1) 
            {
                if (productIDTextBox.Text == string.Empty)
                {
                    MessageBox.Show("請輸入商品編號！", "錯誤", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    productIDTextBox.Focus();
                    return false;
                }
                var qry = context.Product.Execute(MergeOption.OverwriteChanges)
                                 .Where(P => P.ProductID 
                                        == productIDTextBox.Text)
                                 .FirstOrDefault();                                          
                if (qry != null)
                {
                    MessageBox.Show("商品編號重複！", "錯誤", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    productIDTextBox.Focus();
                    return false;
                }
            }
            if (productNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("請輸入商品名稱！", "錯誤", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                productNameTextBox.Focus();
                return false;
            }
            if (unitTextBox.Text == string.Empty)
            {
                MessageBox.Show("請輸入單位！", "錯誤", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                productNameTextBox.Focus();
                return false;
            }
            try
            {
                if (Convert.ToInt32(priceTextBox.Text) < 0)
                {
                    MessageBox.Show("建議售價不可小於0。", "錯誤", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    priceTextBox.Focus();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                blnValidation = false;
            }
           return blnValidation;
        }

        public override bool UpdateData()
        {
            try
            {
                this.Validate();
                //結束編輯
                productBindingSource.EndEdit();
                PrimaryID = productIDTextBox.Text;
                //更新資料
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "更新錯誤",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public override void SetControls()
        {
            productIDTextBox.ReadOnly = (TBStatus == 0) || (TBStatus == 2);
            productNameTextBox.ReadOnly = (TBStatus == 0);
            unitTextBox.ReadOnly = (TBStatus == 0);
            priceTextBox.ReadOnly = (TBStatus == 0);
            commentTextBox.ReadOnly = (TBStatus == 0);
            stopSalesCheckBox.Enabled = (TBStatus != 0);
            btnLoad.Enabled = (TBStatus != 0);
            btnClear.Enabled = (TBStatus != 0);
        }

        public override void SetDefaultValue()
        {
            unitTextBox.Text = "本";
            priceTextBox.Text = "0";
            stopSalesCheckBox.Checked = false;
            productBindingSource.EndEdit();
        }
        
        public override void AfterAddNew()
        {
            productIDTextBox.Focus();
        }

        public override bool BeforeDelete()
        {
            if (MessageBox.Show(string.Format(
                "刪除本筆商品資料？\r\n\r\n商品編號：{0}", productIDTextBox.Text),
                "刪除記錄", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return false;
            }
            //檢查ReceiptDetails資料表是否有要刪除的商品編號之記錄
            var Receipr = (from D in context.ReceiptDetails
                           where D.ProductID == productIDTextBox.Text
                           select D.ProductID).FirstOrDefault();
            if (Receipr != null)
            {
                MessageBox.Show(String.Format("商品編號{0}已有進貨記錄，無法刪除。",
                                productIDTextBox.Text), "參考警告",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            //檢查DeliveryDetails資料表是否有要刪除的商品編號之記錄
            var Delivery = (from D in context.DeliveryDetails
                            where D.ProductID == productIDTextBox.Text
                            select D.ProductID).FirstOrDefault();
            if (Delivery != null)
            {
                MessageBox.Show(String.Format("商品編號{0}已有出貨記錄，無法刪除。",
                                productIDTextBox.Text), "參考警告",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            //檢查TransferDetails資料表是否有要刪除的商品編號之記錄
            var Transfer = (from D in context.TransferDetails
                            where D.ProductID == productIDTextBox.Text
                            select D.ProductID).FirstOrDefault();
            if (Transfer != null)
            {
                MessageBox.Show(String.Format("商品編號{0}已有存貨異動記錄，" +
                                "無法刪除。", productIDTextBox.Text), "參考警告",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            //進行刪除記錄的程序
            DeleteID = productIDTextBox.Text;
            return true;
        }

        public override bool DeleteData()
        {
            try
            {
                //找出目前的商品記錄的物件
                var rowProduct = (Product)(productBindingSource.Current);
                if (rowProduct != null)
                {
                    //刪除商品記錄
                    context.DeleteObject(rowProduct);
                    //更新資料
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                //秀出錯誤訊息
                MessageBox.Show(ex.Message, "刪除錯誤",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            PrimaryID = productIDTextBox.Text;
            return true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //定義副檔名的類型
            openFileDlg.Filter = "bmp files (*.bmp)|*.bmp|" +
                                 "jpeg files (*.jpg)|*.jpg|" +
                                 "png files (*.png)|*.png|" +
                                 "All files (*.*)|*.*";
            //預設副檔名為jpeg files
            openFileDlg.FilterIndex = 2;
            openFileDlg.RestoreDirectory = true;
            //顯示開啟舊檔的對話方塊，讓使用者選擇圖片
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                //載入商品圖片
                Image pic;
                pic = Image.FromFile(openFileDlg.FileName);
                picturePictureBox.Image = pic;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //清除商品圖片
            picturePictureBox.Image = null;
        }

        private void fmDtnProduct_Shown(object sender, EventArgs e)
        {
            //
            productIDTextBox.Focus();
        }
    }
}

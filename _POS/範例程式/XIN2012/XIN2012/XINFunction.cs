using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Windows.Forms;

namespace XIN2012
{
    class XINFunction
    {
        //檢查是否有指定程式的指定操作項目的執行權限
        public bool CheckAuthority(string ProgramID, int Operation)
        {
            //Operation 1:新增 2:修改 3:刪除 4:列印
            //預設擁有全部權限
            bool FAuthority = true;
            //ADMIN不用檢查，擁有全部權限，直接離開
            if (fmMain.FEmployeeNo == "ADMIN")
            {
                return true;
            }
            using (var context = new XINEntities())
            {
                var qry = (from A in context.UserAuthority
                           where A.EmployeeNo == fmMain.FEmployeeNo
                           && A.ProgramID == ProgramID 
                           select new
                           {
                               A.ProgramID, A.Append, A.Edit, A.Report
                           }
                          ).FirstOrDefault();
                if (qry != null)
                {
                    if (Operation == 1)
                    {
                        //新增權限
                        FAuthority = qry.Append;
                    }
                    else if (Operation == 2)
                    {
                        //修改權限
                        FAuthority = qry.Edit;
                    }
                    else if (Operation == 3)
                    {
                        //刪除權限(有新增權限就有刪除權限)
                        FAuthority = qry.Append;
                    }
                    else
                    {
                        //列印權限
                        FAuthority = qry.Report;
                    }
                }
            }
            return FAuthority;
        }

        //檢查商品是否存在(包含檢查是否停售)
        public bool CheckProductID(string ProductID, bool CheckStopSales = false)
        {
            bool FCheck = false;
            bool StopSales = false;            
            using (var context = new XINEntities())
            {
                var qry = (from P in  context.Product
                           where P.ProductID == ProductID
                           select new
                           {
                               P.ProductID, P.StopSales
                           }).FirstOrDefault();
                if (qry != null)
                {
                    FCheck = true;
                    StopSales = (bool)qry.StopSales;
                }
            }
            if (! FCheck)
            {
                if (ProductID == null)
                {
                    MessageBox.Show("請輸入商品編號。", "參考錯誤", 
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MessageBox.Show(string.Format("商品編號{0}輸入錯誤。", 
                        ProductID), "參考錯誤", 
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                if (CheckStopSales && StopSales)
                {
                    MessageBox.Show(string.Format("商品編號{0}已經停止交易。",
                        ProductID), "資料停用", 
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    FCheck = false;
                }

            }
            return FCheck;
        }

        //取得商品名稱
        public string GetProductName(string ProductID)
        {
            string ProductName = "";
            if (ProductID != null)
            {
                using (var context = new XINEntities())
                {
                    var qry = (from P in  context.Product
                               where P.ProductID == ProductID
                               select P.ProductName).FirstOrDefault();
                    if (qry != null)
                    {
                        ProductName = (string)qry;
                    }   
                }   
            }
            return ProductName;
        }

        //取得商品單位
        public string GetUnit(string ProductID)
        {
            string Unit = "";
            if (ProductID != null)
            {
                using (var context = new XINEntities())
                {
                    var qry = (from P in  context.Product
                               where P.ProductID == ProductID
                               select P.Unit).FirstOrDefault();
                    if (qry != null)
                    {
                        Unit = (string)qry;
                    }   
                }   
            }
            return Unit;
        }

        //取得商品售價
        public int GetPrice(string ProductID)
        {
            int Price = 0;
            if (ProductID != null)
            {
                using (var context = new XINEntities())
                {
                    var qry = (from P in  context.Product
                               where P.ProductID == ProductID
                               select P.Price).FirstOrDefault();
                    if (qry != null)
                    {
                        Price = (int)qry;
                    }   
                }   
            }
            return Price;
        }

        //檢查廠商代碼是否存在
        public bool CheckSupplierID(string SupplierID)
        {
            bool FCheck = false;
            using (var context = new XINEntities())
            {
                var qry = (from S in context.Supplier
                           where S.SupplierID == SupplierID
                           select S.SupplierID).FirstOrDefault();
                if (qry != null)
                {
                    FCheck = true;
                }
            }
            if (!FCheck)
            {
                if (SupplierID == null)
                {
                    MessageBox.Show("請輸入廠商代碼。", "參考錯誤",
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MessageBox.Show(string.Format("廠商代碼{0}輸入錯誤。", 
                                    SupplierID), "參考錯誤",
                                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            return FCheck;
        }

        //取得廠商簡稱
        public string GetSupplierAttribName(string SupplierID)
        {
            string SupplierAttribName = "";
            if (SupplierID != null)
            {
                using (var context = new XINEntities())
                {
                    var qry = (from S in context.Supplier
                               where S.SupplierID == SupplierID
                               select S.AttribName).FirstOrDefault();
                    if (qry != null)
                    {
                        SupplierAttribName = (string)qry;
                    }
                }
            }
            return SupplierAttribName;
        }

        //取得廠商地址
        public string GetSupplierAddress(string SupplierID)
        {
            string SuuplierAddress = "";
            if (SupplierID != null)
            {
                using (var context = new XINEntities())
                {
                    var qry = (from S in context.Supplier
                               where S.SupplierID == SupplierID
                               select S.DeliveryAddress).FirstOrDefault();
                    if (qry != null)
                    {
                        SuuplierAddress = (string)qry;
                    }
                }
            }
            return SuuplierAddress;
        }

        //檢查客戶代碼是否存在
        public bool CheckCustomerID(string CustomerID)
        {
            bool FCheck = false;
            using (var context = new XINEntities())
            {
                var qry = (from R in context.Customer
                           where R.CustomerID == CustomerID
                           select R.CustomerID).FirstOrDefault();
                if (qry != null)
                {
                    FCheck = true;
                }
            }
            if (!FCheck)
            {
                if (CustomerID == null)
                {
                    MessageBox.Show("請輸入客戶代碼。", "參考錯誤",
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MessageBox.Show(string.Format("客戶代碼{0}輸入錯誤。", 
                                    CustomerID), "參考錯誤",
                                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            return FCheck;
        }

        //取得客戶簡稱
        public string GetCustomerAttribName(string CustomerID)
        {
            string CustomerAttribName = "";
            if (CustomerID != null)
            {
                using (var context = new XINEntities())
                {
                    var qry = (from R in context.Customer
                               where R.CustomerID == CustomerID
                               select R.AttribName).FirstOrDefault();
                    if (qry != null)
                    {
                        CustomerAttribName = (string)qry;
                    }
                }
            }
            return CustomerAttribName;
        }

        //取得客戶聯絡人
        public string GetCustomerJoinMan(string CustomerID)
        {
            string CustomerJoinMan = "";
            if (CustomerID != null)
            {
                using (var context = new XINEntities())
                {
                    var qry = (from R in context.Customer
                               where R.CustomerID == CustomerID
                               select R.JoinMan).FirstOrDefault();
                    if (qry != null)
                    {
                        CustomerJoinMan = (string)qry;
                    }
                }
            }
            return CustomerJoinMan;
        }

        //取得客戶地址
        public string GetCustomerAddress(string CustomerID)
        {
            string CustomerAddress = "";
            if (CustomerID != null)
            {
                using (var context = new XINEntities())
                {
                    var qry = (from R in context.Customer
                               where R.CustomerID == CustomerID
                               select R.DeliveryAddress).FirstOrDefault();
                    if (qry != null)
                    {
                        CustomerAddress = (string)qry;
                    }
                }
            }
            return CustomerAddress;
        }

        //增加庫存量
        public void IncStock(XINEntities _context, string ProductID, int Quantity)
        {
            if (ProductID == null)
            {
                Exception ex = new Exception("計算庫存量的資料不可以含有空值！");
                ex.Source = "null";
                throw ex;
            }
            //定義影響的資料列數
            int rowsAffected;
            //更新庫存量
            rowsAffected = _context.ExecuteStoreCommand(
               "UPDATE Product SET Stock = Stock + {0} " +
               "WHERE ProductID = {1} ",
                Quantity, ProductID);
            //檢查影響的資料列數
            if (rowsAffected == 0)
            {
                //修改失敗，舉發例外
                Exception ex = new Exception("計算庫存量發生不可預期的錯誤！");
                ex.Source = "Quantity";
                throw ex;
            }
        }

        //減少庫存量
        public void DecStock(XINEntities _context, string ProductID, int Quantity)
        {
            if (ProductID == null)
            {
                Exception ex = new Exception("計算庫存量的資料不可以含有空值！");
                ex.Source = "null";
                throw ex;
            }
            //重讀ObjectContext的庫存記錄
            _context.Refresh(RefreshMode.StoreWins, _context.Product);
            //查詢指定品項的庫存量
            var qryStock = (from P in _context.Product
                            where P.ProductID == ProductID 
                            select P.Stock).FirstOrDefault();
            int CurrQty = (int)qryStock;
            if ((CurrQty - Quantity) < 0) 
            {
                Exception ex = new Exception(string.Format(
                                "商品編號{0}的庫存量不足，無法出貨！", ProductID));
                ex.Source = "Stock";
                throw ex;
            }
            //定義影響的資料列數
            int rowsAffected;
            //更新庫存量
            rowsAffected = _context.ExecuteStoreCommand(
               "UPDATE Product SET Stock = Stock - {0} " +
               "WHERE ProductID = {1} ",
                Quantity, ProductID);
            //檢查影響的資料列數
            if (rowsAffected == 0)
            {
                //修改失敗，舉發例外
                Exception ex = new Exception("計算庫存量發生不可預期的錯誤！");
                ex.Source = "Quantity";
                throw ex;
            }
        }
    }
}

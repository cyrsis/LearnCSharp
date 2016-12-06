using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace XIN2012
{
    public partial class fmRptStockPostList : XIN2012.fmBasePreviewReport
    {

        //異動日期(起)
        DateTime FBeginDate;
        //異動日期(迄)
        DateTime FEndDate;
        //商品編號
        string FProductID;

        public fmRptStockPostList()
        {
            InitializeComponent();
        }

        //設定異動日期(起)
        public DateTime BeginDate
        {
            set
            {
                FBeginDate = value;
            }
        }

        //設定異動日期(迄)
        public DateTime EndDate
        {
            set
            {
                FEndDate = value;
            }
        }

        //設定商品編號
        public string ProductID
        {
            set
            {
                FProductID = value;
            }
        }

        public override void GenerateReport()
        {
            //商品編號起、迄
            string FBeginProductID, FEndProductID;
            //暫存數量的變數
            int OrginalQty;
            //定義DataReader物件
            SqlDataReader rdrList;
            //定義DataTable物件
            DataTable dtList = new DataTable();
            //定義DataView物件
            DataView dvList;
            //定義DataRow物件
            DataRow drList;
            //查詢記錄的位置
            int iRow;
            //儲存起始日期的變數
            DateTime BeginDate;
            //把資料集XINDataSet裡的表格指向StockPostList
            dtList = XINDataSet.Tables["StockPostList"];
            //建立DataView
            dvList = dtList.DefaultView;
            dvList.Sort = "ProductID, TransferType";
            //起始日期
            BeginDate = Convert.ToDateTime(FBeginDate).Date;
            //建立資料庫連接物件
            SqlConnection cnXIN = new SqlConnection();
            //建立命令物件
            SqlCommand cmdSQL = new SqlCommand();
            //儲存SQL敘述的變數
            string strSQL;
            //定義尋找的物件
            object[] vals = new object[2];
            //定義動態參數
            SqlParameter spDate = new SqlParameter("@Date", SqlDbType.DateTime);
            SqlParameter spBeginID = new SqlParameter("@BeginID", 
                                                      SqlDbType.NVarChar, 10);
            SqlParameter spEndID = new SqlParameter("@EndID", 
                                                    SqlDbType.NVarChar, 10);
            //取得連接字串
            cnXIN.ConnectionString = Properties.Settings.Default.XINConnection;
            //把連接物件指派給命令物件
            cmdSQL.Connection = cnXIN;
            //列印條件
            string strCondi = "單據日期：";
            strCondi = strCondi + FBeginDate.ToShortDateString() + "~" +
                                  FEndDate.ToShortDateString() +
                                  "   商品：";
            //找出商品編號的起、迄值
            if (FProductID == string.Empty)
            {
                FBeginProductID = "";
                FEndProductID = "ZZZZZZZZZZ";
                strCondi = strCondi + "全部";
            }
            else
            {
                FBeginProductID = FProductID;
                FEndProductID = FProductID;
                strCondi = strCondi + FProductID;
            }
            //
            //進貨單
            //
            strSQL = "SELECT M.ReceiptDate, M.ReceiptID, M.ReceiptType, " +
                     "D.ProductID, P.ProductName, SUM(D.Quantity) AS Qty " +
                     "FROM Receipt M INNER JOIN " + 
                     "ReceiptDetails D ON M.ReceiptID = D.ReceiptID INNER JOIN " +
                     "Product P ON D.ProductID = P.ProductID  " +
                     "WHERE M.ReceiptDate <= @Date " +
                     "AND D.ProductID >= @BeginID " +
                     "AND D.ProductID <= @EndID " +
                     "GROUP BY M.ReceiptDate, M.ReceiptID, M.ReceiptType, " +
                     "D.ProductID, P.ProductName "; 
            cmdSQL.CommandText = strSQL;
            cmdSQL.Parameters.Add(spDate);
            cmdSQL.Parameters.Add(spBeginID);
            cmdSQL.Parameters.Add(spEndID);
            //賦予cmdSQL的參數值
            cmdSQL.Parameters["@Date"].Value = FEndDate;
            cmdSQL.Parameters["@BeginID"].Value = FBeginProductID;
            cmdSQL.Parameters["@EndID"].Value = FEndProductID;
            //開啟連接
            cnXIN.Open();
            //將結果指向rdrList
            rdrList = cmdSQL.ExecuteReader();
            //將資料填入資料集
            while (rdrList.Read())
            {
                if (rdrList.GetDateTime(0) < BeginDate)
                {
                    //
                    //期初
                    //
                    vals[0] = rdrList.GetString(3); //商品編號
                    vals[1] = "0期初";
                    iRow = dvList.Find(vals);
                    if (iRow == -1)
                    {
                        drList = dtList.NewRow();
                        drList["ProductID"] = rdrList.GetString(3);
                        drList["ProductName"] = rdrList.GetString(4);
                        drList["TransferType"] = "0期初";
                        drList["AddQty"] = 0;
                        drList["SubQty"] = 0;
                        drList["Balance"] = 0;
                        dtList.Rows.Add(drList);
                    }
                    //不管有沒有找到, 再確認一次該筆產品的記錄位置
                    iRow = dvList.Find(vals);
                    if (iRow != -1)
                    {
                        //進入編輯模式
                        dvList[iRow].BeginEdit();
                        if (rdrList.GetString(2) == "1") 
                        {
                            //進貨
                            OrginalQty = Convert.ToInt32(dvList[iRow]["Balance"]) +
                                         Convert.ToInt32(rdrList.GetValue(5));
                            dvList[iRow]["Balance"] = OrginalQty;
                        }
                        else
                        {
                            //進貨退出
                            OrginalQty = Convert.ToInt32(dvList[iRow]["Balance"]) -
                                         Convert.ToInt32(rdrList.GetValue(5));
                            dvList[iRow]["Balance"] = OrginalQty;
                        }
                        //結束編輯模式
                        dvList[iRow].EndEdit();
                    }
                }
                else
                {
                    //
                    //異動期間的進貨、進貨退出記錄
                    //
                    drList = dtList.NewRow();
                    drList["ProductID"] = rdrList.GetString(3);
                    drList["ProductName"] = rdrList.GetString(4);
                    drList["TransferDate"] = rdrList.GetDateTime(0)
                                                    .Date.ToString("yyyy/MM/dd");
                    drList["TransferID"] = rdrList.GetString(1);
                    if (rdrList.GetString(2) == "1")
                    {
                        //進貨
                        drList["TransferType"] = "P進貨";
                        drList["AddQty"] = Convert.ToUInt32(rdrList.GetValue(5));
                        drList["SubQty"] = 0;
                    }
                    else
                    {
                        //進貨退出
                         drList["TransferType"] = "P進貨退出";
                         drList["AddQty"] = 0;
                         drList["SubQty"] = Convert.ToUInt32(rdrList.GetValue(5));
                    }
                    drList["Balance"] = 0;
                    dtList.Rows.Add(drList);
                }
            }
            //關閉DataReader
            rdrList.Close();
            //
            //出貨單
            //
            strSQL = "SELECT M.DeliveryDate, M.DeliveryID, M.DeliveryType, " +
                     "D.ProductID, P.ProductName, SUM(D.Quantity) AS Qty " +
                     "FROM Delivery M INNER JOIN " +
                     "DeliveryDetails D ON M.DeliveryID = D.DeliveryID INNER JOIN " +
                     "Product P ON D.ProductID = P.ProductID  " +
                     "WHERE M.DeliveryDate <= @Date " +
                     "AND D.ProductID >= @BeginID " +
                     "AND D.ProductID <= @EndID " +
                     "GROUP BY M.DeliveryDate, M.DeliveryID, M.DeliveryType, " +
                     "D.ProductID, P.ProductName ";
            cmdSQL.CommandText = strSQL;
            //賦予cmdSQL的參數值
            cmdSQL.Parameters["@Date"].Value = FEndDate;
            cmdSQL.Parameters["@BeginID"].Value = FBeginProductID;
            cmdSQL.Parameters["@EndID"].Value = FEndProductID;
            //將結果指向rdrList
            rdrList = cmdSQL.ExecuteReader();
            //將資料填入資料集
            while (rdrList.Read())
            {
                if (rdrList.GetDateTime(0) < BeginDate)
                {
                    //
                    //期初
                    //
                    vals[0] = rdrList.GetString(3); //商品編號
                    vals[1] = "0期初";
                    iRow = dvList.Find(vals);
                    if (iRow == -1)
                    {
                        drList = dtList.NewRow();
                        drList["ProductID"] = rdrList.GetString(3);
                        drList["ProductName"] = rdrList.GetString(4);
                        drList["TransferType"] = "0期初";
                        drList["AddQty"] = 0;
                        drList["SubQty"] = 0;
                        drList["Balance"] = 0;
                        dtList.Rows.Add(drList);
                    }
                    //不管有沒有找到, 再確認一次該筆產品的記錄位置
                    iRow = dvList.Find(vals);
                    if (iRow != -1)
                    {
                        //進入編輯模式
                        dvList[iRow].BeginEdit();
                        if (rdrList.GetString(2) == "1")
                        {
                            //出貨
                            OrginalQty = Convert.ToInt32(dvList[iRow]["Balance"]) -
                                         Convert.ToInt32(rdrList.GetValue(5));
                            dvList[iRow]["Balance"] = OrginalQty;
                        }
                        else
                        {
                            //出貨退回
                            OrginalQty = Convert.ToInt32(dvList[iRow]["Balance"]) +
                                         Convert.ToInt32(rdrList.GetValue(5));
                            dvList[iRow]["Balance"] = OrginalQty;
                        }
                        //結束編輯模式
                        dvList[iRow].EndEdit();
                    }
                }
                else
                {
                    //
                    //異動期間的出貨、出貨退回記錄
                    //
                    drList = dtList.NewRow();
                    drList["ProductID"] = rdrList.GetString(3);
                    drList["ProductName"] = rdrList.GetString(4);
                    drList["TransferDate"] = rdrList.GetDateTime(0)
                                                    .Date.ToString("yyyy/MM/dd");
                    drList["TransferID"] = rdrList.GetString(1);
                    if (rdrList.GetString(2) == "1")
                    {
                        //出貨
                        drList["TransferType"] = "S出貨";
                        drList["AddQty"] = 0;
                        drList["SubQty"] = Convert.ToUInt32(rdrList.GetValue(5));
                    }
                    else
                    {
                        //出貨退回
                        drList["TransferType"] = "S出貨退回";
                        drList["AddQty"] = Convert.ToUInt32(rdrList.GetValue(5));
                        drList["SubQty"] = 0;
                    }
                    drList["Balance"] = 0;
                    dtList.Rows.Add(drList);
                }
            }
            //關閉DataReader
            rdrList.Close();
            //
            //存貨異動單
            //
            strSQL = "SELECT M.TransferDate, M.TransferID, M.TransferType, " +
                     "D.ProductID, P.ProductName, SUM(D.Quantity) AS Qty " +
                     "FROM Transfer M INNER JOIN " +
                     "TransferDetails D ON M.TransferID = D.TransferID INNER JOIN " +
                     "Product P ON D.ProductID = P.ProductID  " +
                     "WHERE M.TransferDate <= @Date " +
                     "AND D.ProductID >= @BeginID " +
                     "AND D.ProductID <= @EndID " +
                     "GROUP BY M.TransferDate, M.TransferID, M.TransferType, " +
                     "D.ProductID, P.ProductName ";
            cmdSQL.CommandText = strSQL;
            //賦予cmdSQL的參數值
            cmdSQL.Parameters["@Date"].Value = FEndDate;
            cmdSQL.Parameters["@BeginID"].Value = FBeginProductID;
            cmdSQL.Parameters["@EndID"].Value = FEndProductID;
            //將結果指向rdrList
            rdrList = cmdSQL.ExecuteReader();
            //將資料填入資料集
            while (rdrList.Read())
            {
                if (rdrList.GetDateTime(0) < BeginDate)
                {
                    //
                    //期初
                    //
                    vals[0] = rdrList.GetString(3); //商品編號
                    vals[1] = "0期初";
                    iRow = dvList.Find(vals);
                    if (iRow == -1)
                    {
                        drList = dtList.NewRow();
                        drList["ProductID"] = rdrList.GetString(3);
                        drList["ProductName"] = rdrList.GetString(4);
                        drList["TransferType"] = "0期初";
                        drList["AddQty"] = 0;
                        drList["SubQty"] = 0;
                        drList["Balance"] = 0;
                        dtList.Rows.Add(drList);
                    }
                    //不管有沒有找到, 再確認一次該筆產品的記錄位置
                    iRow = dvList.Find(vals);
                    if (iRow != -1)
                    {
                        //進入編輯模式
                        dvList[iRow].BeginEdit();
                        if (rdrList.GetString(2) == "1")
                        {
                            //存貨入庫
                            OrginalQty = Convert.ToInt32(dvList[iRow]["Balance"]) +
                                         Convert.ToInt32(rdrList.GetValue(5));
                            dvList[iRow]["Balance"] = OrginalQty;
                        }
                        else
                        {
                            //存貨出庫
                            OrginalQty = Convert.ToInt32(dvList[iRow]["Balance"]) -
                                         Convert.ToInt32(rdrList.GetValue(5));
                            dvList[iRow]["Balance"] = OrginalQty;
                        }
                        //結束編輯模式
                        dvList[iRow].EndEdit();
                    }
                }
                else
                {
                    //
                    //異動期間的出貨、出貨退回記錄
                    //
                    drList = dtList.NewRow();
                    drList["ProductID"] = rdrList.GetString(3);
                    drList["ProductName"] = rdrList.GetString(4);
                    drList["TransferDate"] = rdrList.GetDateTime(0)
                                                    .Date.ToString("yyyy/MM/dd");
                    drList["TransferID"] = rdrList.GetString(1);
                    if (rdrList.GetString(2) == "1")
                    {
                        //存貨入庫
                        drList["TransferType"] = "T存貨入庫";
                        drList["AddQty"] = Convert.ToUInt32(rdrList.GetValue(5));
                        drList["SubQty"] = 0;
                    }
                    else
                    {
                        //存貨出庫
                        drList["TransferType"] = "T存貨出庫";
                        drList["AddQty"] = 0;
                        drList["SubQty"] = Convert.ToUInt32(rdrList.GetValue(5));
                    }
                    drList["Balance"] = 0;
                    dtList.Rows.Add(drList);
                }
            }
            //關閉DataReader
            rdrList.Close();
            //
            //再計算累計數量
            //
            //以未來記錄的顯示順序來排序
            dvList.Sort = "ProductID, TransferDate, TransferType, TransferID";
            int TotalQty;
            string PrevProductID, NewProductID;
            TotalQty = 0;
            PrevProductID = "";
            for (iRow = 0; iRow <= dvList.Count - 1; iRow++)
            {
                NewProductID = Convert.ToString(dvList[iRow]["ProductID"]);
                if (PrevProductID != NewProductID)
                {
                    PrevProductID = NewProductID;
                    TotalQty = 0;
                }
                if (Convert.ToString(dvList[iRow]["TransferType"]) == "0期初")
                {
                    TotalQty = Convert.ToInt32(dvList[iRow]["Balance"]);
                }
                else
                {
                    OrginalQty = TotalQty +
                                 Convert.ToInt32(dvList[iRow]["AddQty"]) -
                                 Convert.ToInt32(dvList[iRow]["SubQty"]);
                    dvList[iRow]["Balance"] = OrginalQty;
                    TotalQty = Convert.ToInt32(dvList[iRow]["Balance"]);
                }
            }
            //建立報表參數
            ReportParameter ReportCondi = new ReportParameter();
            ReportCondi.Name = "ReportCondi";
            ReportCondi.Values.Add(strCondi);
            //將報表參數反映到報表底稿上的報表參數
            this.reportViewerBase.LocalReport.SetParameters(
                                  new ReportParameter[] { ReportCondi });
        }
    }
}

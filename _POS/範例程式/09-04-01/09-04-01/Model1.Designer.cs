﻿//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace _09_04_01
{
    #region 內容
    
    /// <summary>
    /// 沒有可用的中繼資料文件。
    /// </summary>
    public partial class XINEntities : ObjectContext
    {
        #region 建構函式
    
        /// <summary>
        /// 使用在應用程式組態檔的 'XINEntities' 區段中找到的連接字串，初始化新的 XINEntities 物件。
        /// </summary>
        public XINEntities() : base("name=XINEntities", "XINEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 XINEntities 物件。
        /// </summary>
        public XINEntities(string connectionString) : base(connectionString, "XINEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 XINEntities 物件。
        /// </summary>
        public XINEntities(EntityConnection connection) : base(connection, "XINEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region 部分方法
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet 屬性
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        public ObjectSet<Product> Product
        {
            get
            {
                if ((_Product == null))
                {
                    _Product = base.CreateObjectSet<Product>("Product");
                }
                return _Product;
            }
        }
        private ObjectSet<Product> _Product;

        #endregion

        #region AddTo 方法
    
        /// <summary>
        /// 將新物件加入 Product EntitySet 的方法已被取代。請考慮改為使用關聯的 ObjectSet&lt;T&gt; 屬性的 .Add 方法。
        /// </summary>
        public void AddToProduct(Product product)
        {
            base.AddObject("Product", product);
        }

        #endregion

    }

    #endregion

    #region 實體
    
    /// <summary>
    /// 沒有可用的中繼資料文件。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="XINModel", Name="Product")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Product : EntityObject
    {
        #region Factory 方法
    
        /// <summary>
        /// 建立新 Product 物件。
        /// </summary>
        /// <param name="productID">ProductID 屬性的初始值。</param>
        public static Product CreateProduct(global::System.String productID)
        {
            Product product = new Product();
            product.ProductID = productID;
            return product;
        }

        #endregion

        #region 簡單屬性
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ProductID
        {
            get
            {
                return _ProductID;
            }
            set
            {
                if (_ProductID != value)
                {
                    OnProductIDChanging(value);
                    ReportPropertyChanging("ProductID");
                    _ProductID = StructuralObject.SetValidValue(value, false, "ProductID");
                    ReportPropertyChanged("ProductID");
                    OnProductIDChanged();
                }
            }
        }
        private global::System.String _ProductID;
        partial void OnProductIDChanging(global::System.String value);
        partial void OnProductIDChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProductName
        {
            get
            {
                return _ProductName;
            }
            set
            {
                OnProductNameChanging(value);
                ReportPropertyChanging("ProductName");
                _ProductName = StructuralObject.SetValidValue(value, true, "ProductName");
                ReportPropertyChanged("ProductName");
                OnProductNameChanged();
            }
        }
        private global::System.String _ProductName;
        partial void OnProductNameChanging(global::System.String value);
        partial void OnProductNameChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Unit
        {
            get
            {
                return _Unit;
            }
            set
            {
                OnUnitChanging(value);
                ReportPropertyChanging("Unit");
                _Unit = StructuralObject.SetValidValue(value, true, "Unit");
                ReportPropertyChanged("Unit");
                OnUnitChanged();
            }
        }
        private global::System.String _Unit;
        partial void OnUnitChanging(global::System.String value);
        partial void OnUnitChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> LastReceiptDate
        {
            get
            {
                return _LastReceiptDate;
            }
            set
            {
                OnLastReceiptDateChanging(value);
                ReportPropertyChanging("LastReceiptDate");
                _LastReceiptDate = StructuralObject.SetValidValue(value, "LastReceiptDate");
                ReportPropertyChanged("LastReceiptDate");
                OnLastReceiptDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _LastReceiptDate;
        partial void OnLastReceiptDateChanging(Nullable<global::System.DateTime> value);
        partial void OnLastReceiptDateChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> LastDeliveryDate
        {
            get
            {
                return _LastDeliveryDate;
            }
            set
            {
                OnLastDeliveryDateChanging(value);
                ReportPropertyChanging("LastDeliveryDate");
                _LastDeliveryDate = StructuralObject.SetValidValue(value, "LastDeliveryDate");
                ReportPropertyChanged("LastDeliveryDate");
                OnLastDeliveryDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _LastDeliveryDate;
        partial void OnLastDeliveryDateChanging(Nullable<global::System.DateTime> value);
        partial void OnLastDeliveryDateChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> StopSales
        {
            get
            {
                return _StopSales;
            }
            set
            {
                OnStopSalesChanging(value);
                ReportPropertyChanging("StopSales");
                _StopSales = StructuralObject.SetValidValue(value, "StopSales");
                ReportPropertyChanged("StopSales");
                OnStopSalesChanged();
            }
        }
        private Nullable<global::System.Boolean> _StopSales;
        partial void OnStopSalesChanging(Nullable<global::System.Boolean> value);
        partial void OnStopSalesChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Price
        {
            get
            {
                return _Price;
            }
            set
            {
                OnPriceChanging(value);
                ReportPropertyChanging("Price");
                _Price = StructuralObject.SetValidValue(value, "Price");
                ReportPropertyChanged("Price");
                OnPriceChanged();
            }
        }
        private Nullable<global::System.Int32> _Price;
        partial void OnPriceChanging(Nullable<global::System.Int32> value);
        partial void OnPriceChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Stock
        {
            get
            {
                return _Stock;
            }
            set
            {
                OnStockChanging(value);
                ReportPropertyChanging("Stock");
                _Stock = StructuralObject.SetValidValue(value, "Stock");
                ReportPropertyChanged("Stock");
                OnStockChanged();
            }
        }
        private Nullable<global::System.Int32> _Stock;
        partial void OnStockChanging(Nullable<global::System.Int32> value);
        partial void OnStockChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.Byte[] Picture
        {
            get
            {
                return StructuralObject.GetValidValue(_Picture);
            }
            set
            {
                OnPictureChanging(value);
                ReportPropertyChanging("Picture");
                _Picture = StructuralObject.SetValidValue(value, true, "Picture");
                ReportPropertyChanged("Picture");
                OnPictureChanged();
            }
        }
        private global::System.Byte[] _Picture;
        partial void OnPictureChanging(global::System.Byte[] value);
        partial void OnPictureChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Comment
        {
            get
            {
                return _Comment;
            }
            set
            {
                OnCommentChanging(value);
                ReportPropertyChanging("Comment");
                _Comment = StructuralObject.SetValidValue(value, true, "Comment");
                ReportPropertyChanged("Comment");
                OnCommentChanged();
            }
        }
        private global::System.String _Comment;
        partial void OnCommentChanging(global::System.String value);
        partial void OnCommentChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CatalogID
        {
            get
            {
                return _CatalogID;
            }
            set
            {
                OnCatalogIDChanging(value);
                ReportPropertyChanging("CatalogID");
                _CatalogID = StructuralObject.SetValidValue(value, true, "CatalogID");
                ReportPropertyChanged("CatalogID");
                OnCatalogIDChanged();
            }
        }
        private global::System.String _CatalogID;
        partial void OnCatalogIDChanging(global::System.String value);
        partial void OnCatalogIDChanged();

        #endregion

    }

    #endregion

}

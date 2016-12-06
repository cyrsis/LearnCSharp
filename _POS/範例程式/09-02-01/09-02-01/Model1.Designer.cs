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
namespace _09_02_01
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
        public ObjectSet<Customer> Customer
        {
            get
            {
                if ((_Customer == null))
                {
                    _Customer = base.CreateObjectSet<Customer>("Customer");
                }
                return _Customer;
            }
        }
        private ObjectSet<Customer> _Customer;

        #endregion

        #region AddTo 方法
    
        /// <summary>
        /// 將新物件加入 Customer EntitySet 的方法已被取代。請考慮改為使用關聯的 ObjectSet&lt;T&gt; 屬性的 .Add 方法。
        /// </summary>
        public void AddToCustomer(Customer customer)
        {
            base.AddObject("Customer", customer);
        }

        #endregion

    }

    #endregion

    #region 實體
    
    /// <summary>
    /// 沒有可用的中繼資料文件。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="XINModel", Name="Customer")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Customer : EntityObject
    {
        #region Factory 方法
    
        /// <summary>
        /// 建立新 Customer 物件。
        /// </summary>
        /// <param name="customerID">CustomerID 屬性的初始值。</param>
        public static Customer CreateCustomer(global::System.String customerID)
        {
            Customer customer = new Customer();
            customer.CustomerID = customerID;
            return customer;
        }

        #endregion

        #region 簡單屬性
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                if (_CustomerID != value)
                {
                    OnCustomerIDChanging(value);
                    ReportPropertyChanging("CustomerID");
                    _CustomerID = StructuralObject.SetValidValue(value, false, "CustomerID");
                    ReportPropertyChanged("CustomerID");
                    OnCustomerIDChanged();
                }
            }
        }
        private global::System.String _CustomerID;
        partial void OnCustomerIDChanging(global::System.String value);
        partial void OnCustomerIDChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AttribName
        {
            get
            {
                return _AttribName;
            }
            set
            {
                OnAttribNameChanging(value);
                ReportPropertyChanging("AttribName");
                _AttribName = StructuralObject.SetValidValue(value, true, "AttribName");
                ReportPropertyChanged("AttribName");
                OnAttribNameChanged();
            }
        }
        private global::System.String _AttribName;
        partial void OnAttribNameChanging(global::System.String value);
        partial void OnAttribNameChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CompanyName
        {
            get
            {
                return _CompanyName;
            }
            set
            {
                OnCompanyNameChanging(value);
                ReportPropertyChanging("CompanyName");
                _CompanyName = StructuralObject.SetValidValue(value, true, "CompanyName");
                ReportPropertyChanged("CompanyName");
                OnCompanyNameChanged();
            }
        }
        private global::System.String _CompanyName;
        partial void OnCompanyNameChanging(global::System.String value);
        partial void OnCompanyNameChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String EarNo
        {
            get
            {
                return _EarNo;
            }
            set
            {
                OnEarNoChanging(value);
                ReportPropertyChanging("EarNo");
                _EarNo = StructuralObject.SetValidValue(value, true, "EarNo");
                ReportPropertyChanged("EarNo");
                OnEarNoChanged();
            }
        }
        private global::System.String _EarNo;
        partial void OnEarNoChanging(global::System.String value);
        partial void OnEarNoChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String JoinMan
        {
            get
            {
                return _JoinMan;
            }
            set
            {
                OnJoinManChanging(value);
                ReportPropertyChanging("JoinMan");
                _JoinMan = StructuralObject.SetValidValue(value, true, "JoinMan");
                ReportPropertyChanged("JoinMan");
                OnJoinManChanged();
            }
        }
        private global::System.String _JoinMan;
        partial void OnJoinManChanging(global::System.String value);
        partial void OnJoinManChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Tel1
        {
            get
            {
                return _Tel1;
            }
            set
            {
                OnTel1Changing(value);
                ReportPropertyChanging("Tel1");
                _Tel1 = StructuralObject.SetValidValue(value, true, "Tel1");
                ReportPropertyChanged("Tel1");
                OnTel1Changed();
            }
        }
        private global::System.String _Tel1;
        partial void OnTel1Changing(global::System.String value);
        partial void OnTel1Changed();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Tel2
        {
            get
            {
                return _Tel2;
            }
            set
            {
                OnTel2Changing(value);
                ReportPropertyChanging("Tel2");
                _Tel2 = StructuralObject.SetValidValue(value, true, "Tel2");
                ReportPropertyChanged("Tel2");
                OnTel2Changed();
            }
        }
        private global::System.String _Tel2;
        partial void OnTel2Changing(global::System.String value);
        partial void OnTel2Changed();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Fax
        {
            get
            {
                return _Fax;
            }
            set
            {
                OnFaxChanging(value);
                ReportPropertyChanging("Fax");
                _Fax = StructuralObject.SetValidValue(value, true, "Fax");
                ReportPropertyChanged("Fax");
                OnFaxChanged();
            }
        }
        private global::System.String _Fax;
        partial void OnFaxChanging(global::System.String value);
        partial void OnFaxChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String MobilePhone
        {
            get
            {
                return _MobilePhone;
            }
            set
            {
                OnMobilePhoneChanging(value);
                ReportPropertyChanging("MobilePhone");
                _MobilePhone = StructuralObject.SetValidValue(value, true, "MobilePhone");
                ReportPropertyChanged("MobilePhone");
                OnMobilePhoneChanged();
            }
        }
        private global::System.String _MobilePhone;
        partial void OnMobilePhoneChanging(global::System.String value);
        partial void OnMobilePhoneChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CompanyAddress
        {
            get
            {
                return _CompanyAddress;
            }
            set
            {
                OnCompanyAddressChanging(value);
                ReportPropertyChanging("CompanyAddress");
                _CompanyAddress = StructuralObject.SetValidValue(value, true, "CompanyAddress");
                ReportPropertyChanged("CompanyAddress");
                OnCompanyAddressChanged();
            }
        }
        private global::System.String _CompanyAddress;
        partial void OnCompanyAddressChanging(global::System.String value);
        partial void OnCompanyAddressChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String DeliveryAddress
        {
            get
            {
                return _DeliveryAddress;
            }
            set
            {
                OnDeliveryAddressChanging(value);
                ReportPropertyChanging("DeliveryAddress");
                _DeliveryAddress = StructuralObject.SetValidValue(value, true, "DeliveryAddress");
                ReportPropertyChanged("DeliveryAddress");
                OnDeliveryAddressChanged();
            }
        }
        private global::System.String _DeliveryAddress;
        partial void OnDeliveryAddressChanging(global::System.String value);
        partial void OnDeliveryAddressChanged();
    
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

        #endregion

    }

    #endregion

}

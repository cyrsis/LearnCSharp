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
namespace _10_06_03
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
        public ObjectSet<XINUsers> XINUsers
        {
            get
            {
                if ((_XINUsers == null))
                {
                    _XINUsers = base.CreateObjectSet<XINUsers>("XINUsers");
                }
                return _XINUsers;
            }
        }
        private ObjectSet<XINUsers> _XINUsers;

        #endregion

        #region AddTo 方法
    
        /// <summary>
        /// 將新物件加入 XINUsers EntitySet 的方法已被取代。請考慮改為使用關聯的 ObjectSet&lt;T&gt; 屬性的 .Add 方法。
        /// </summary>
        public void AddToXINUsers(XINUsers xINUsers)
        {
            base.AddObject("XINUsers", xINUsers);
        }

        #endregion

    }

    #endregion

    #region 實體
    
    /// <summary>
    /// 沒有可用的中繼資料文件。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="XINModel", Name="XINUsers")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class XINUsers : EntityObject
    {
        #region Factory 方法
    
        /// <summary>
        /// 建立新 XINUsers 物件。
        /// </summary>
        /// <param name="employeeNo">EmployeeNo 屬性的初始值。</param>
        /// <param name="employeeName">EmployeeName 屬性的初始值。</param>
        /// <param name="passwordCode">PasswordCode 屬性的初始值。</param>
        public static XINUsers CreateXINUsers(global::System.String employeeNo, global::System.String employeeName, global::System.String passwordCode)
        {
            XINUsers xINUsers = new XINUsers();
            xINUsers.EmployeeNo = employeeNo;
            xINUsers.EmployeeName = employeeName;
            xINUsers.PasswordCode = passwordCode;
            return xINUsers;
        }

        #endregion

        #region 簡單屬性
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String EmployeeNo
        {
            get
            {
                return _EmployeeNo;
            }
            set
            {
                if (_EmployeeNo != value)
                {
                    OnEmployeeNoChanging(value);
                    ReportPropertyChanging("EmployeeNo");
                    _EmployeeNo = StructuralObject.SetValidValue(value, false, "EmployeeNo");
                    ReportPropertyChanged("EmployeeNo");
                    OnEmployeeNoChanged();
                }
            }
        }
        private global::System.String _EmployeeNo;
        partial void OnEmployeeNoChanging(global::System.String value);
        partial void OnEmployeeNoChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String EmployeeName
        {
            get
            {
                return _EmployeeName;
            }
            set
            {
                OnEmployeeNameChanging(value);
                ReportPropertyChanging("EmployeeName");
                _EmployeeName = StructuralObject.SetValidValue(value, false, "EmployeeName");
                ReportPropertyChanged("EmployeeName");
                OnEmployeeNameChanged();
            }
        }
        private global::System.String _EmployeeName;
        partial void OnEmployeeNameChanging(global::System.String value);
        partial void OnEmployeeNameChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PasswordCode
        {
            get
            {
                return _PasswordCode;
            }
            set
            {
                OnPasswordCodeChanging(value);
                ReportPropertyChanging("PasswordCode");
                _PasswordCode = StructuralObject.SetValidValue(value, false, "PasswordCode");
                ReportPropertyChanged("PasswordCode");
                OnPasswordCodeChanged();
            }
        }
        private global::System.String _PasswordCode;
        partial void OnPasswordCodeChanging(global::System.String value);
        partial void OnPasswordCodeChanged();

        #endregion

    }

    #endregion

}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sixeyed.CarValet.Api.ServiceAgents.Asmx.Quotes {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceAgents.Asmx.Quotes.QuoteServiceSoap")]
    public interface QuoteServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetQuotes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Sixeyed.CarValet.Api.ServiceAgents.Asmx.Quotes.GetQuotesResponse GetQuotes(Sixeyed.CarValet.Api.ServiceAgents.Asmx.Quotes.GetQuotesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetQuotes", ReplyAction="*")]
        System.Threading.Tasks.Task<Sixeyed.CarValet.Api.ServiceAgents.Asmx.Quotes.GetQuotesResponse> GetQuotesAsync(Sixeyed.CarValet.Api.ServiceAgents.Asmx.Quotes.GetQuotesRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class GetQuotesRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int vehicleIdField;
        
        private string postalCodeField;
        
        private string[] productCodesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int VehicleId {
            get {
                return this.vehicleIdField;
            }
            set {
                this.vehicleIdField = value;
                this.RaisePropertyChanged("VehicleId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string PostalCode {
            get {
                return this.postalCodeField;
            }
            set {
                this.postalCodeField = value;
                this.RaisePropertyChanged("PostalCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        public string[] ProductCodes {
            get {
                return this.productCodesField;
            }
            set {
                this.productCodesField = value;
                this.RaisePropertyChanged("ProductCodes");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ProductOption : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string optionCodeField;
        
        private string optionNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string OptionCode {
            get {
                return this.optionCodeField;
            }
            set {
                this.optionCodeField = value;
                this.RaisePropertyChanged("OptionCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string OptionName {
            get {
                return this.optionNameField;
            }
            set {
                this.optionNameField = value;
                this.RaisePropertyChanged("OptionName");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Product : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string productCodeField;
        
        private string productNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ProductCode {
            get {
                return this.productCodeField;
            }
            set {
                this.productCodeField = value;
                this.RaisePropertyChanged("ProductCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ProductName {
            get {
                return this.productNameField;
            }
            set {
                this.productNameField = value;
                this.RaisePropertyChanged("ProductName");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Quote : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int vehicleIdField;
        
        private string postalCodeField;
        
        private Product productField;
        
        private ProductOption[] optionsField;
        
        private decimal costField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int VehicleId {
            get {
                return this.vehicleIdField;
            }
            set {
                this.vehicleIdField = value;
                this.RaisePropertyChanged("VehicleId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string PostalCode {
            get {
                return this.postalCodeField;
            }
            set {
                this.postalCodeField = value;
                this.RaisePropertyChanged("PostalCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public Product Product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
                this.RaisePropertyChanged("Product");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=3)]
        public ProductOption[] Options {
            get {
                return this.optionsField;
            }
            set {
                this.optionsField = value;
                this.RaisePropertyChanged("Options");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public decimal Cost {
            get {
                return this.costField;
            }
            set {
                this.costField = value;
                this.RaisePropertyChanged("Cost");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class GetQuotesResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Quote[] quotesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        public Quote[] Quotes {
            get {
                return this.quotesField;
            }
            set {
                this.quotesField = value;
                this.RaisePropertyChanged("Quotes");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface QuoteServiceSoapChannel : Sixeyed.CarValet.Api.ServiceAgents.Asmx.Quotes.QuoteServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class QuoteServiceSoapClient : System.ServiceModel.ClientBase<Sixeyed.CarValet.Api.ServiceAgents.Asmx.Quotes.QuoteServiceSoap>, Sixeyed.CarValet.Api.ServiceAgents.Asmx.Quotes.QuoteServiceSoap {
        
        public QuoteServiceSoapClient() {
        }
        
        public QuoteServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public QuoteServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuoteServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuoteServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Sixeyed.CarValet.Api.ServiceAgents.Asmx.Quotes.GetQuotesResponse GetQuotes(Sixeyed.CarValet.Api.ServiceAgents.Asmx.Quotes.GetQuotesRequest request) {
            return base.Channel.GetQuotes(request);
        }
        
        public System.Threading.Tasks.Task<Sixeyed.CarValet.Api.ServiceAgents.Asmx.Quotes.GetQuotesResponse> GetQuotesAsync(Sixeyed.CarValet.Api.ServiceAgents.Asmx.Quotes.GetQuotesRequest request) {
            return base.Channel.GetQuotesAsync(request);
        }
    }
}
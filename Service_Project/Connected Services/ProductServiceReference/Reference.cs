﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Service_Project.ProductServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductServiceReference.ProductServiceSoap")]
    public interface ProductServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        // CODEGEN: Generating message contract since message ProductListRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ProductList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Service_Project.ProductServiceReference.ProductListResponse ProductList(Service_Project.ProductServiceReference.ProductListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ProductList", ReplyAction="*")]
        System.Threading.Tasks.Task<Service_Project.ProductServiceReference.ProductListResponse> ProductListAsync(Service_Project.ProductServiceReference.ProductListRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Pasaport : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string userNameField;
        
        private string passwordField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
                this.RaisePropertyChanged("UserName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("Password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ProductDTO : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int productIDField;
        
        private string productNameField;
        
        private System.Nullable<int> supplierIDField;
        
        private System.Nullable<int> categoryIDField;
        
        private string quantityPerUnitField;
        
        private System.Nullable<decimal> unitPriceField;
        
        private System.Nullable<short> unitsInStockField;
        
        private System.Nullable<short> unitsOnOrderField;
        
        private System.Nullable<short> reorderLevelField;
        
        private bool discontinuedField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int ProductID {
            get {
                return this.productIDField;
            }
            set {
                this.productIDField = value;
                this.RaisePropertyChanged("ProductID");
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public System.Nullable<int> SupplierID {
            get {
                return this.supplierIDField;
            }
            set {
                this.supplierIDField = value;
                this.RaisePropertyChanged("SupplierID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public System.Nullable<int> CategoryID {
            get {
                return this.categoryIDField;
            }
            set {
                this.categoryIDField = value;
                this.RaisePropertyChanged("CategoryID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string QuantityPerUnit {
            get {
                return this.quantityPerUnitField;
            }
            set {
                this.quantityPerUnitField = value;
                this.RaisePropertyChanged("QuantityPerUnit");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public System.Nullable<decimal> UnitPrice {
            get {
                return this.unitPriceField;
            }
            set {
                this.unitPriceField = value;
                this.RaisePropertyChanged("UnitPrice");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public System.Nullable<short> UnitsInStock {
            get {
                return this.unitsInStockField;
            }
            set {
                this.unitsInStockField = value;
                this.RaisePropertyChanged("UnitsInStock");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public System.Nullable<short> UnitsOnOrder {
            get {
                return this.unitsOnOrderField;
            }
            set {
                this.unitsOnOrderField = value;
                this.RaisePropertyChanged("UnitsOnOrder");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public System.Nullable<short> ReorderLevel {
            get {
                return this.reorderLevelField;
            }
            set {
                this.reorderLevelField = value;
                this.RaisePropertyChanged("ReorderLevel");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public bool Discontinued {
            get {
                return this.discontinuedField;
            }
            set {
                this.discontinuedField = value;
                this.RaisePropertyChanged("Discontinued");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ProductList", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ProductListRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public Service_Project.ProductServiceReference.Pasaport Pasaport;
        
        public ProductListRequest() {
        }
        
        public ProductListRequest(Service_Project.ProductServiceReference.Pasaport Pasaport) {
            this.Pasaport = Pasaport;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ProductListResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ProductListResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Service_Project.ProductServiceReference.ProductDTO[] ProductListResult;
        
        public ProductListResponse() {
        }
        
        public ProductListResponse(Service_Project.ProductServiceReference.ProductDTO[] ProductListResult) {
            this.ProductListResult = ProductListResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ProductServiceSoapChannel : Service_Project.ProductServiceReference.ProductServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductServiceSoapClient : System.ServiceModel.ClientBase<Service_Project.ProductServiceReference.ProductServiceSoap>, Service_Project.ProductServiceReference.ProductServiceSoap {
        
        public ProductServiceSoapClient() {
        }
        
        public ProductServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Service_Project.ProductServiceReference.ProductListResponse Service_Project.ProductServiceReference.ProductServiceSoap.ProductList(Service_Project.ProductServiceReference.ProductListRequest request) {
            return base.Channel.ProductList(request);
        }
        
        public Service_Project.ProductServiceReference.ProductDTO[] ProductList(Service_Project.ProductServiceReference.Pasaport Pasaport) {
            Service_Project.ProductServiceReference.ProductListRequest inValue = new Service_Project.ProductServiceReference.ProductListRequest();
            inValue.Pasaport = Pasaport;
            Service_Project.ProductServiceReference.ProductListResponse retVal = ((Service_Project.ProductServiceReference.ProductServiceSoap)(this)).ProductList(inValue);
            return retVal.ProductListResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Service_Project.ProductServiceReference.ProductListResponse> Service_Project.ProductServiceReference.ProductServiceSoap.ProductListAsync(Service_Project.ProductServiceReference.ProductListRequest request) {
            return base.Channel.ProductListAsync(request);
        }
        
        public System.Threading.Tasks.Task<Service_Project.ProductServiceReference.ProductListResponse> ProductListAsync(Service_Project.ProductServiceReference.Pasaport Pasaport) {
            Service_Project.ProductServiceReference.ProductListRequest inValue = new Service_Project.ProductServiceReference.ProductListRequest();
            inValue.Pasaport = Pasaport;
            return ((Service_Project.ProductServiceReference.ProductServiceSoap)(this)).ProductListAsync(inValue);
        }
    }
}
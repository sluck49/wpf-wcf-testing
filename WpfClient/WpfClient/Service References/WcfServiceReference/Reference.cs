﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfClient.WcfServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CreateFarkleRequest", Namespace="http://schemas.datacontract.org/2004/07/WcfService.Requests")]
    [System.SerializableAttribute()]
    public partial class CreateFarkleRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsFarkedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsFarked {
            get {
                return this.IsFarkedField;
            }
            set {
                if ((this.IsFarkedField.Equals(value) != true)) {
                    this.IsFarkedField = value;
                    this.RaisePropertyChanged("IsFarked");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WcfServiceResponseBase", Namespace="http://schemas.datacontract.org/2004/07/WcfService.Responses")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WpfClient.WcfServiceReference.CreateFarkleResponse))]
    public partial class WcfServiceResponseBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FailureReasonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSuccessField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FailureReason {
            get {
                return this.FailureReasonField;
            }
            set {
                if ((object.ReferenceEquals(this.FailureReasonField, value) != true)) {
                    this.FailureReasonField = value;
                    this.RaisePropertyChanged("FailureReason");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSuccess {
            get {
                return this.IsSuccessField;
            }
            set {
                if ((this.IsSuccessField.Equals(value) != true)) {
                    this.IsSuccessField = value;
                    this.RaisePropertyChanged("IsSuccess");
                }
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CreateFarkleResponse", Namespace="http://schemas.datacontract.org/2004/07/WcfService.Responses")]
    [System.SerializableAttribute()]
    public partial class CreateFarkleResponse : WpfClient.WcfServiceReference.WcfServiceResponseBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfClient.WcfServiceReference.Farkle NewFarkleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfClient.WcfServiceReference.Farkle NewFarkle {
            get {
                return this.NewFarkleField;
            }
            set {
                if ((object.ReferenceEquals(this.NewFarkleField, value) != true)) {
                    this.NewFarkleField = value;
                    this.RaisePropertyChanged("NewFarkle");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Farkle", Namespace="http://schemas.datacontract.org/2004/07/WcfService.Data.Models")]
    [System.SerializableAttribute()]
    public partial class Farkle : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfClient.WcfServiceReference.Groob[] GroobsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsFarkedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfClient.WcfServiceReference.Groob[] Groobs {
            get {
                return this.GroobsField;
            }
            set {
                if ((object.ReferenceEquals(this.GroobsField, value) != true)) {
                    this.GroobsField = value;
                    this.RaisePropertyChanged("Groobs");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsFarked {
            get {
                return this.IsFarkedField;
            }
            set {
                if ((this.IsFarkedField.Equals(value) != true)) {
                    this.IsFarkedField = value;
                    this.RaisePropertyChanged("IsFarked");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Groob", Namespace="http://schemas.datacontract.org/2004/07/WcfService.Data.Models")]
    [System.SerializableAttribute()]
    public partial class Groob : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfClient.WcfServiceReference.Farkle FarkleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FarkleIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfClient.WcfServiceReference.Farkle Farkle {
            get {
                return this.FarkleField;
            }
            set {
                if ((object.ReferenceEquals(this.FarkleField, value) != true)) {
                    this.FarkleField = value;
                    this.RaisePropertyChanged("Farkle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FarkleId {
            get {
                return this.FarkleIdField;
            }
            set {
                if ((this.FarkleIdField.Equals(value) != true)) {
                    this.FarkleIdField = value;
                    this.RaisePropertyChanged("FarkleId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfServiceReference.IWcfService")]
    public interface IWcfService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetFarkleCount", ReplyAction="http://tempuri.org/IWcfService/GetFarkleCountResponse")]
        int GetFarkleCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetFarkleCount", ReplyAction="http://tempuri.org/IWcfService/GetFarkleCountResponse")]
        System.Threading.Tasks.Task<int> GetFarkleCountAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/CreateFarkle", ReplyAction="http://tempuri.org/IWcfService/CreateFarkleResponse")]
        WpfClient.WcfServiceReference.CreateFarkleResponse CreateFarkle(WpfClient.WcfServiceReference.CreateFarkleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/CreateFarkle", ReplyAction="http://tempuri.org/IWcfService/CreateFarkleResponse")]
        System.Threading.Tasks.Task<WpfClient.WcfServiceReference.CreateFarkleResponse> CreateFarkleAsync(WpfClient.WcfServiceReference.CreateFarkleRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWcfServiceChannel : WpfClient.WcfServiceReference.IWcfService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WcfServiceClient : System.ServiceModel.ClientBase<WpfClient.WcfServiceReference.IWcfService>, WpfClient.WcfServiceReference.IWcfService {
        
        public WcfServiceClient() {
        }
        
        public WcfServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WcfServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetFarkleCount() {
            return base.Channel.GetFarkleCount();
        }
        
        public System.Threading.Tasks.Task<int> GetFarkleCountAsync() {
            return base.Channel.GetFarkleCountAsync();
        }
        
        public WpfClient.WcfServiceReference.CreateFarkleResponse CreateFarkle(WpfClient.WcfServiceReference.CreateFarkleRequest request) {
            return base.Channel.CreateFarkle(request);
        }
        
        public System.Threading.Tasks.Task<WpfClient.WcfServiceReference.CreateFarkleResponse> CreateFarkleAsync(WpfClient.WcfServiceReference.CreateFarkleRequest request) {
            return base.Channel.CreateFarkleAsync(request);
        }
    }
}

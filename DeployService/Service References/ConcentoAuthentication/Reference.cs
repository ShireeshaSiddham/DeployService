﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeployService.ConcentoAuthentication {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="auth_req", Namespace="http://schemas.datacontract.org/2004/07/ConcentoSecurity.Model")]
    [System.SerializableAttribute()]
    public partial class auth_req : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string app_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string auth_tokenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string random_keyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool req_access_listField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool req_user_profileField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string user_idField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string app_id {
            get {
                return this.app_idField;
            }
            set {
                if ((object.ReferenceEquals(this.app_idField, value) != true)) {
                    this.app_idField = value;
                    this.RaisePropertyChanged("app_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string auth_token {
            get {
                return this.auth_tokenField;
            }
            set {
                if ((object.ReferenceEquals(this.auth_tokenField, value) != true)) {
                    this.auth_tokenField = value;
                    this.RaisePropertyChanged("auth_token");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string random_key {
            get {
                return this.random_keyField;
            }
            set {
                if ((object.ReferenceEquals(this.random_keyField, value) != true)) {
                    this.random_keyField = value;
                    this.RaisePropertyChanged("random_key");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool req_access_list {
            get {
                return this.req_access_listField;
            }
            set {
                if ((this.req_access_listField.Equals(value) != true)) {
                    this.req_access_listField = value;
                    this.RaisePropertyChanged("req_access_list");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool req_user_profile {
            get {
                return this.req_user_profileField;
            }
            set {
                if ((this.req_user_profileField.Equals(value) != true)) {
                    this.req_user_profileField = value;
                    this.RaisePropertyChanged("req_user_profile");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string user_id {
            get {
                return this.user_idField;
            }
            set {
                if ((object.ReferenceEquals(this.user_idField, value) != true)) {
                    this.user_idField = value;
                    this.RaisePropertyChanged("user_id");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="auth_resp", Namespace="http://schemas.datacontract.org/2004/07/ConcentoSecurity.Model")]
    [System.SerializableAttribute()]
    public partial class auth_resp : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DeployService.ConcentoAuthentication.access_rights[] access_listField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string auth_tokenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime generated_onField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DeployService.ConcentoAuthentication.user_profile user_profileField;
        
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
        public DeployService.ConcentoAuthentication.access_rights[] access_list {
            get {
                return this.access_listField;
            }
            set {
                if ((object.ReferenceEquals(this.access_listField, value) != true)) {
                    this.access_listField = value;
                    this.RaisePropertyChanged("access_list");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string auth_token {
            get {
                return this.auth_tokenField;
            }
            set {
                if ((object.ReferenceEquals(this.auth_tokenField, value) != true)) {
                    this.auth_tokenField = value;
                    this.RaisePropertyChanged("auth_token");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime generated_on {
            get {
                return this.generated_onField;
            }
            set {
                if ((this.generated_onField.Equals(value) != true)) {
                    this.generated_onField = value;
                    this.RaisePropertyChanged("generated_on");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DeployService.ConcentoAuthentication.user_profile user_profile {
            get {
                return this.user_profileField;
            }
            set {
                if ((object.ReferenceEquals(this.user_profileField, value) != true)) {
                    this.user_profileField = value;
                    this.RaisePropertyChanged("user_profile");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="user_profile", Namespace="http://schemas.datacontract.org/2004/07/ConcentoSecurity.Model")]
    [System.SerializableAttribute()]
    public partial class user_profile : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string fnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lnameField;
        
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
        public string fname {
            get {
                return this.fnameField;
            }
            set {
                if ((object.ReferenceEquals(this.fnameField, value) != true)) {
                    this.fnameField = value;
                    this.RaisePropertyChanged("fname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lname {
            get {
                return this.lnameField;
            }
            set {
                if ((object.ReferenceEquals(this.lnameField, value) != true)) {
                    this.lnameField = value;
                    this.RaisePropertyChanged("lname");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="access_rights", Namespace="http://schemas.datacontract.org/2004/07/ConcentoSecurity.Model")]
    [System.SerializableAttribute()]
    public partial class access_rights : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool access_deleteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool access_readField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool access_writeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string featureField;
        
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
        public bool access_delete {
            get {
                return this.access_deleteField;
            }
            set {
                if ((this.access_deleteField.Equals(value) != true)) {
                    this.access_deleteField = value;
                    this.RaisePropertyChanged("access_delete");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool access_read {
            get {
                return this.access_readField;
            }
            set {
                if ((this.access_readField.Equals(value) != true)) {
                    this.access_readField = value;
                    this.RaisePropertyChanged("access_read");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool access_write {
            get {
                return this.access_writeField;
            }
            set {
                if ((this.access_writeField.Equals(value) != true)) {
                    this.access_writeField = value;
                    this.RaisePropertyChanged("access_write");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string feature {
            get {
                return this.featureField;
            }
            set {
                if ((object.ReferenceEquals(this.featureField, value) != true)) {
                    this.featureField = value;
                    this.RaisePropertyChanged("feature");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ConcentoAuthentication.IAuthentication")]
    public interface IAuthentication {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthentication/AuthenticateUser", ReplyAction="http://tempuri.org/IAuthentication/AuthenticateUserResponse")]
        DeployService.ConcentoAuthentication.auth_resp AuthenticateUser(DeployService.ConcentoAuthentication.auth_req authRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthentication/AuthenticateUser", ReplyAction="http://tempuri.org/IAuthentication/AuthenticateUserResponse")]
        System.Threading.Tasks.Task<DeployService.ConcentoAuthentication.auth_resp> AuthenticateUserAsync(DeployService.ConcentoAuthentication.auth_req authRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthentication/AuthenticateToken", ReplyAction="http://tempuri.org/IAuthentication/AuthenticateTokenResponse")]
        DeployService.ConcentoAuthentication.auth_resp AuthenticateToken(DeployService.ConcentoAuthentication.auth_req authRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthentication/AuthenticateToken", ReplyAction="http://tempuri.org/IAuthentication/AuthenticateTokenResponse")]
        System.Threading.Tasks.Task<DeployService.ConcentoAuthentication.auth_resp> AuthenticateTokenAsync(DeployService.ConcentoAuthentication.auth_req authRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthentication/CheckAccessToPath", ReplyAction="http://tempuri.org/IAuthentication/CheckAccessToPathResponse")]
        DeployService.ConcentoAuthentication.access_rights CheckAccessToPath(string appid, string username, string feature);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthentication/CheckAccessToPath", ReplyAction="http://tempuri.org/IAuthentication/CheckAccessToPathResponse")]
        System.Threading.Tasks.Task<DeployService.ConcentoAuthentication.access_rights> CheckAccessToPathAsync(string appid, string username, string feature);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthenticationChannel : DeployService.ConcentoAuthentication.IAuthentication, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthenticationClient : System.ServiceModel.ClientBase<DeployService.ConcentoAuthentication.IAuthentication>, DeployService.ConcentoAuthentication.IAuthentication {
        
        public AuthenticationClient() {
        }
        
        public AuthenticationClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthenticationClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticationClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DeployService.ConcentoAuthentication.auth_resp AuthenticateUser(DeployService.ConcentoAuthentication.auth_req authRequest) {
            return base.Channel.AuthenticateUser(authRequest);
        }
        
        public System.Threading.Tasks.Task<DeployService.ConcentoAuthentication.auth_resp> AuthenticateUserAsync(DeployService.ConcentoAuthentication.auth_req authRequest) {
            return base.Channel.AuthenticateUserAsync(authRequest);
        }
        
        public DeployService.ConcentoAuthentication.auth_resp AuthenticateToken(DeployService.ConcentoAuthentication.auth_req authRequest) {
            return base.Channel.AuthenticateToken(authRequest);
        }
        
        public System.Threading.Tasks.Task<DeployService.ConcentoAuthentication.auth_resp> AuthenticateTokenAsync(DeployService.ConcentoAuthentication.auth_req authRequest) {
            return base.Channel.AuthenticateTokenAsync(authRequest);
        }
        
        public DeployService.ConcentoAuthentication.access_rights CheckAccessToPath(string appid, string username, string feature) {
            return base.Channel.CheckAccessToPath(appid, username, feature);
        }
        
        public System.Threading.Tasks.Task<DeployService.ConcentoAuthentication.access_rights> CheckAccessToPathAsync(string appid, string username, string feature) {
            return base.Channel.CheckAccessToPathAsync(appid, username, feature);
        }
    }
}

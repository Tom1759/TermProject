﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace TermProject.CloudWS {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CloudWSSoap", Namespace="http://tempuri.org/")]
    public partial class CloudWS : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback writeCloudOperationCompleted;
        
        private System.Threading.SendOrPostCallback checkCloudExistsOperationCompleted;
        
        private System.Threading.SendOrPostCallback getFileCloudOperationCompleted;
        
        private System.Threading.SendOrPostCallback createCloudOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CloudWS() {
            this.Url = global::TermProject.Properties.Settings.Default.TermProject_CloudWS_CloudWS;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event writeCloudCompletedEventHandler writeCloudCompleted;
        
        /// <remarks/>
        public event checkCloudExistsCompletedEventHandler checkCloudExistsCompleted;
        
        /// <remarks/>
        public event getFileCloudCompletedEventHandler getFileCloudCompleted;
        
        /// <remarks/>
        public event createCloudCompletedEventHandler createCloudCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/writeCloud", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int writeCloud(object fileCloud, int accountID) {
            object[] results = this.Invoke("writeCloud", new object[] {
                        fileCloud,
                        accountID});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void writeCloudAsync(object fileCloud, int accountID) {
            this.writeCloudAsync(fileCloud, accountID, null);
        }
        
        /// <remarks/>
        public void writeCloudAsync(object fileCloud, int accountID, object userState) {
            if ((this.writeCloudOperationCompleted == null)) {
                this.writeCloudOperationCompleted = new System.Threading.SendOrPostCallback(this.OnwriteCloudOperationCompleted);
            }
            this.InvokeAsync("writeCloud", new object[] {
                        fileCloud,
                        accountID}, this.writeCloudOperationCompleted, userState);
        }
        
        private void OnwriteCloudOperationCompleted(object arg) {
            if ((this.writeCloudCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.writeCloudCompleted(this, new writeCloudCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/checkCloudExists", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool checkCloudExists(int accountID) {
            object[] results = this.Invoke("checkCloudExists", new object[] {
                        accountID});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void checkCloudExistsAsync(int accountID) {
            this.checkCloudExistsAsync(accountID, null);
        }
        
        /// <remarks/>
        public void checkCloudExistsAsync(int accountID, object userState) {
            if ((this.checkCloudExistsOperationCompleted == null)) {
                this.checkCloudExistsOperationCompleted = new System.Threading.SendOrPostCallback(this.OncheckCloudExistsOperationCompleted);
            }
            this.InvokeAsync("checkCloudExists", new object[] {
                        accountID}, this.checkCloudExistsOperationCompleted, userState);
        }
        
        private void OncheckCloudExistsOperationCompleted(object arg) {
            if ((this.checkCloudExistsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.checkCloudExistsCompleted(this, new checkCloudExistsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getFileCloud", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public object getFileCloud(int accountID) {
            object[] results = this.Invoke("getFileCloud", new object[] {
                        accountID});
            return ((object)(results[0]));
        }
        
        /// <remarks/>
        public void getFileCloudAsync(int accountID) {
            this.getFileCloudAsync(accountID, null);
        }
        
        /// <remarks/>
        public void getFileCloudAsync(int accountID, object userState) {
            if ((this.getFileCloudOperationCompleted == null)) {
                this.getFileCloudOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetFileCloudOperationCompleted);
            }
            this.InvokeAsync("getFileCloud", new object[] {
                        accountID}, this.getFileCloudOperationCompleted, userState);
        }
        
        private void OngetFileCloudOperationCompleted(object arg) {
            if ((this.getFileCloudCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getFileCloudCompleted(this, new getFileCloudCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/createCloud", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int createCloud(int accountID) {
            object[] results = this.Invoke("createCloud", new object[] {
                        accountID});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void createCloudAsync(int accountID) {
            this.createCloudAsync(accountID, null);
        }
        
        /// <remarks/>
        public void createCloudAsync(int accountID, object userState) {
            if ((this.createCloudOperationCompleted == null)) {
                this.createCloudOperationCompleted = new System.Threading.SendOrPostCallback(this.OncreateCloudOperationCompleted);
            }
            this.InvokeAsync("createCloud", new object[] {
                        accountID}, this.createCloudOperationCompleted, userState);
        }
        
        private void OncreateCloudOperationCompleted(object arg) {
            if ((this.createCloudCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.createCloudCompleted(this, new createCloudCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void writeCloudCompletedEventHandler(object sender, writeCloudCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class writeCloudCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal writeCloudCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void checkCloudExistsCompletedEventHandler(object sender, checkCloudExistsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class checkCloudExistsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal checkCloudExistsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void getFileCloudCompletedEventHandler(object sender, getFileCloudCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getFileCloudCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getFileCloudCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public object Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((object)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void createCloudCompletedEventHandler(object sender, createCloudCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class createCloudCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal createCloudCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591
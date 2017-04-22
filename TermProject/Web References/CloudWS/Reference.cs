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
        
        private System.Threading.SendOrPostCallback addDownloadDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback getMaxFileIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback getDownloadDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteFileOperationCompleted;
        
        private System.Threading.SendOrPostCallback deleteAccountOperationCompleted;
        
        private System.Threading.SendOrPostCallback deleteAllFilesOperationCompleted;
        
        private System.Threading.SendOrPostCallback resetStorageUsedOperationCompleted;
        
        private System.Threading.SendOrPostCallback logUserTransactionOperationCompleted;
        
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
        public event addDownloadDataCompletedEventHandler addDownloadDataCompleted;
        
        /// <remarks/>
        public event getMaxFileIDCompletedEventHandler getMaxFileIDCompleted;
        
        /// <remarks/>
        public event getDownloadDataCompletedEventHandler getDownloadDataCompleted;
        
        /// <remarks/>
        public event DeleteFileCompletedEventHandler DeleteFileCompleted;
        
        /// <remarks/>
        public event deleteAccountCompletedEventHandler deleteAccountCompleted;
        
        /// <remarks/>
        public event deleteAllFilesCompletedEventHandler deleteAllFilesCompleted;
        
        /// <remarks/>
        public event resetStorageUsedCompletedEventHandler resetStorageUsedCompleted;
        
        /// <remarks/>
        public event logUserTransactionCompletedEventHandler logUserTransactionCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/addDownloadData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int addDownloadData(int accountID, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] data, int verification) {
            object[] results = this.Invoke("addDownloadData", new object[] {
                        accountID,
                        data,
                        verification});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void addDownloadDataAsync(int accountID, byte[] data, int verification) {
            this.addDownloadDataAsync(accountID, data, verification, null);
        }
        
        /// <remarks/>
        public void addDownloadDataAsync(int accountID, byte[] data, int verification, object userState) {
            if ((this.addDownloadDataOperationCompleted == null)) {
                this.addDownloadDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaddDownloadDataOperationCompleted);
            }
            this.InvokeAsync("addDownloadData", new object[] {
                        accountID,
                        data,
                        verification}, this.addDownloadDataOperationCompleted, userState);
        }
        
        private void OnaddDownloadDataOperationCompleted(object arg) {
            if ((this.addDownloadDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.addDownloadDataCompleted(this, new addDownloadDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getMaxFileID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int getMaxFileID(int verification) {
            object[] results = this.Invoke("getMaxFileID", new object[] {
                        verification});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void getMaxFileIDAsync(int verification) {
            this.getMaxFileIDAsync(verification, null);
        }
        
        /// <remarks/>
        public void getMaxFileIDAsync(int verification, object userState) {
            if ((this.getMaxFileIDOperationCompleted == null)) {
                this.getMaxFileIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetMaxFileIDOperationCompleted);
            }
            this.InvokeAsync("getMaxFileID", new object[] {
                        verification}, this.getMaxFileIDOperationCompleted, userState);
        }
        
        private void OngetMaxFileIDOperationCompleted(object arg) {
            if ((this.getMaxFileIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getMaxFileIDCompleted(this, new getMaxFileIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getDownloadData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] getDownloadData(int fileID, long fileLength, int verification) {
            object[] results = this.Invoke("getDownloadData", new object[] {
                        fileID,
                        fileLength,
                        verification});
            return ((byte[])(results[0]));
        }
        
        /// <remarks/>
        public void getDownloadDataAsync(int fileID, long fileLength, int verification) {
            this.getDownloadDataAsync(fileID, fileLength, verification, null);
        }
        
        /// <remarks/>
        public void getDownloadDataAsync(int fileID, long fileLength, int verification, object userState) {
            if ((this.getDownloadDataOperationCompleted == null)) {
                this.getDownloadDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetDownloadDataOperationCompleted);
            }
            this.InvokeAsync("getDownloadData", new object[] {
                        fileID,
                        fileLength,
                        verification}, this.getDownloadDataOperationCompleted, userState);
        }
        
        private void OngetDownloadDataOperationCompleted(object arg) {
            if ((this.getDownloadDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getDownloadDataCompleted(this, new getDownloadDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteFile", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int DeleteFile(int fileID, int verification) {
            object[] results = this.Invoke("DeleteFile", new object[] {
                        fileID,
                        verification});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteFileAsync(int fileID, int verification) {
            this.DeleteFileAsync(fileID, verification, null);
        }
        
        /// <remarks/>
        public void DeleteFileAsync(int fileID, int verification, object userState) {
            if ((this.DeleteFileOperationCompleted == null)) {
                this.DeleteFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteFileOperationCompleted);
            }
            this.InvokeAsync("DeleteFile", new object[] {
                        fileID,
                        verification}, this.DeleteFileOperationCompleted, userState);
        }
        
        private void OnDeleteFileOperationCompleted(object arg) {
            if ((this.DeleteFileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteFileCompleted(this, new DeleteFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/deleteAccount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int deleteAccount(int ID, int verification) {
            object[] results = this.Invoke("deleteAccount", new object[] {
                        ID,
                        verification});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void deleteAccountAsync(int ID, int verification) {
            this.deleteAccountAsync(ID, verification, null);
        }
        
        /// <remarks/>
        public void deleteAccountAsync(int ID, int verification, object userState) {
            if ((this.deleteAccountOperationCompleted == null)) {
                this.deleteAccountOperationCompleted = new System.Threading.SendOrPostCallback(this.OndeleteAccountOperationCompleted);
            }
            this.InvokeAsync("deleteAccount", new object[] {
                        ID,
                        verification}, this.deleteAccountOperationCompleted, userState);
        }
        
        private void OndeleteAccountOperationCompleted(object arg) {
            if ((this.deleteAccountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.deleteAccountCompleted(this, new deleteAccountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/deleteAllFiles", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int deleteAllFiles(int ID, int verification) {
            object[] results = this.Invoke("deleteAllFiles", new object[] {
                        ID,
                        verification});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void deleteAllFilesAsync(int ID, int verification) {
            this.deleteAllFilesAsync(ID, verification, null);
        }
        
        /// <remarks/>
        public void deleteAllFilesAsync(int ID, int verification, object userState) {
            if ((this.deleteAllFilesOperationCompleted == null)) {
                this.deleteAllFilesOperationCompleted = new System.Threading.SendOrPostCallback(this.OndeleteAllFilesOperationCompleted);
            }
            this.InvokeAsync("deleteAllFiles", new object[] {
                        ID,
                        verification}, this.deleteAllFilesOperationCompleted, userState);
        }
        
        private void OndeleteAllFilesOperationCompleted(object arg) {
            if ((this.deleteAllFilesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.deleteAllFilesCompleted(this, new deleteAllFilesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/resetStorageUsed", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int resetStorageUsed(int ID, int verification) {
            object[] results = this.Invoke("resetStorageUsed", new object[] {
                        ID,
                        verification});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void resetStorageUsedAsync(int ID, int verification) {
            this.resetStorageUsedAsync(ID, verification, null);
        }
        
        /// <remarks/>
        public void resetStorageUsedAsync(int ID, int verification, object userState) {
            if ((this.resetStorageUsedOperationCompleted == null)) {
                this.resetStorageUsedOperationCompleted = new System.Threading.SendOrPostCallback(this.OnresetStorageUsedOperationCompleted);
            }
            this.InvokeAsync("resetStorageUsed", new object[] {
                        ID,
                        verification}, this.resetStorageUsedOperationCompleted, userState);
        }
        
        private void OnresetStorageUsedOperationCompleted(object arg) {
            if ((this.resetStorageUsedCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.resetStorageUsedCompleted(this, new resetStorageUsedCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/logUserTransaction", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void logUserTransaction(int accountID, string description, int verification) {
            this.Invoke("logUserTransaction", new object[] {
                        accountID,
                        description,
                        verification});
        }
        
        /// <remarks/>
        public void logUserTransactionAsync(int accountID, string description, int verification) {
            this.logUserTransactionAsync(accountID, description, verification, null);
        }
        
        /// <remarks/>
        public void logUserTransactionAsync(int accountID, string description, int verification, object userState) {
            if ((this.logUserTransactionOperationCompleted == null)) {
                this.logUserTransactionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlogUserTransactionOperationCompleted);
            }
            this.InvokeAsync("logUserTransaction", new object[] {
                        accountID,
                        description,
                        verification}, this.logUserTransactionOperationCompleted, userState);
        }
        
        private void OnlogUserTransactionOperationCompleted(object arg) {
            if ((this.logUserTransactionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.logUserTransactionCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void addDownloadDataCompletedEventHandler(object sender, addDownloadDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class addDownloadDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal addDownloadDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void getMaxFileIDCompletedEventHandler(object sender, getMaxFileIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getMaxFileIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getMaxFileIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void getDownloadDataCompletedEventHandler(object sender, getDownloadDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getDownloadDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getDownloadDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public byte[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((byte[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void DeleteFileCompletedEventHandler(object sender, DeleteFileCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteFileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void deleteAccountCompletedEventHandler(object sender, deleteAccountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class deleteAccountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal deleteAccountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void deleteAllFilesCompletedEventHandler(object sender, deleteAllFilesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class deleteAllFilesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal deleteAllFilesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void resetStorageUsedCompletedEventHandler(object sender, resetStorageUsedCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class resetStorageUsedCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal resetStorageUsedCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void logUserTransactionCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591
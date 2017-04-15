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

namespace TermProject.Part2WS {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Part2WSSoap", Namespace="http://tempuri.org/")]
    public partial class Part2WS : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetAccountInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateAccountOperationCompleted;
        
        private System.Threading.SendOrPostCallback uploadFileOperationCompleted;
        
        private System.Threading.SendOrPostCallback getFilesOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateFileOperationCompleted;
        
        private System.Threading.SendOrPostCallback getUploadHistoryOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteFileOperationCompleted;
        
        private System.Threading.SendOrPostCallback getFileOperationCompleted;
        
        private System.Threading.SendOrPostCallback updateStorageUsedOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Part2WS() {
            this.Url = global::TermProject.Properties.Settings.Default.TermProject_Part2WS_Part2WS;
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
        public event GetAccountInfoCompletedEventHandler GetAccountInfoCompleted;
        
        /// <remarks/>
        public event UpdateAccountCompletedEventHandler UpdateAccountCompleted;
        
        /// <remarks/>
        public event uploadFileCompletedEventHandler uploadFileCompleted;
        
        /// <remarks/>
        public event getFilesCompletedEventHandler getFilesCompleted;
        
        /// <remarks/>
        public event UpdateFileCompletedEventHandler UpdateFileCompleted;
        
        /// <remarks/>
        public event getUploadHistoryCompletedEventHandler getUploadHistoryCompleted;
        
        /// <remarks/>
        public event DeleteFileCompletedEventHandler DeleteFileCompleted;
        
        /// <remarks/>
        public event getFileCompletedEventHandler getFileCompleted;
        
        /// <remarks/>
        public event updateStorageUsedCompletedEventHandler updateStorageUsedCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAccountInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Person GetAccountInfo(string email, int verification) {
            object[] results = this.Invoke("GetAccountInfo", new object[] {
                        email,
                        verification});
            return ((Person)(results[0]));
        }
        
        /// <remarks/>
        public void GetAccountInfoAsync(string email, int verification) {
            this.GetAccountInfoAsync(email, verification, null);
        }
        
        /// <remarks/>
        public void GetAccountInfoAsync(string email, int verification, object userState) {
            if ((this.GetAccountInfoOperationCompleted == null)) {
                this.GetAccountInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAccountInfoOperationCompleted);
            }
            this.InvokeAsync("GetAccountInfo", new object[] {
                        email,
                        verification}, this.GetAccountInfoOperationCompleted, userState);
        }
        
        private void OnGetAccountInfoOperationCompleted(object arg) {
            if ((this.GetAccountInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAccountInfoCompleted(this, new GetAccountInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateAccount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateAccount(Person updatePerson, string oldEmail, int verification) {
            this.Invoke("UpdateAccount", new object[] {
                        updatePerson,
                        oldEmail,
                        verification});
        }
        
        /// <remarks/>
        public void UpdateAccountAsync(Person updatePerson, string oldEmail, int verification) {
            this.UpdateAccountAsync(updatePerson, oldEmail, verification, null);
        }
        
        /// <remarks/>
        public void UpdateAccountAsync(Person updatePerson, string oldEmail, int verification, object userState) {
            if ((this.UpdateAccountOperationCompleted == null)) {
                this.UpdateAccountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateAccountOperationCompleted);
            }
            this.InvokeAsync("UpdateAccount", new object[] {
                        updatePerson,
                        oldEmail,
                        verification}, this.UpdateAccountOperationCompleted, userState);
        }
        
        private void OnUpdateAccountOperationCompleted(object arg) {
            if ((this.UpdateAccountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateAccountCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/uploadFile", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool uploadFile(string title, string type, long length, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] data, string email, int accountID, string imagePath, int verification) {
            object[] results = this.Invoke("uploadFile", new object[] {
                        title,
                        type,
                        length,
                        data,
                        email,
                        accountID,
                        imagePath,
                        verification});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void uploadFileAsync(string title, string type, long length, byte[] data, string email, int accountID, string imagePath, int verification) {
            this.uploadFileAsync(title, type, length, data, email, accountID, imagePath, verification, null);
        }
        
        /// <remarks/>
        public void uploadFileAsync(string title, string type, long length, byte[] data, string email, int accountID, string imagePath, int verification, object userState) {
            if ((this.uploadFileOperationCompleted == null)) {
                this.uploadFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnuploadFileOperationCompleted);
            }
            this.InvokeAsync("uploadFile", new object[] {
                        title,
                        type,
                        length,
                        data,
                        email,
                        accountID,
                        imagePath,
                        verification}, this.uploadFileOperationCompleted, userState);
        }
        
        private void OnuploadFileOperationCompleted(object arg) {
            if ((this.uploadFileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.uploadFileCompleted(this, new uploadFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getFiles", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getFiles(int accountID, int verification) {
            object[] results = this.Invoke("getFiles", new object[] {
                        accountID,
                        verification});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getFilesAsync(int accountID, int verification) {
            this.getFilesAsync(accountID, verification, null);
        }
        
        /// <remarks/>
        public void getFilesAsync(int accountID, int verification, object userState) {
            if ((this.getFilesOperationCompleted == null)) {
                this.getFilesOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetFilesOperationCompleted);
            }
            this.InvokeAsync("getFiles", new object[] {
                        accountID,
                        verification}, this.getFilesOperationCompleted, userState);
        }
        
        private void OngetFilesOperationCompleted(object arg) {
            if ((this.getFilesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getFilesCompleted(this, new getFilesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateFile", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateFile(int fileID, string fileName, int verification) {
            this.Invoke("UpdateFile", new object[] {
                        fileID,
                        fileName,
                        verification});
        }
        
        /// <remarks/>
        public void UpdateFileAsync(int fileID, string fileName, int verification) {
            this.UpdateFileAsync(fileID, fileName, verification, null);
        }
        
        /// <remarks/>
        public void UpdateFileAsync(int fileID, string fileName, int verification, object userState) {
            if ((this.UpdateFileOperationCompleted == null)) {
                this.UpdateFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateFileOperationCompleted);
            }
            this.InvokeAsync("UpdateFile", new object[] {
                        fileID,
                        fileName,
                        verification}, this.UpdateFileOperationCompleted, userState);
        }
        
        private void OnUpdateFileOperationCompleted(object arg) {
            if ((this.UpdateFileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateFileCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getUploadHistory", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getUploadHistory(string email, System.DateTime fromTime, System.DateTime toTime, int verification) {
            object[] results = this.Invoke("getUploadHistory", new object[] {
                        email,
                        fromTime,
                        toTime,
                        verification});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getUploadHistoryAsync(string email, System.DateTime fromTime, System.DateTime toTime, int verification) {
            this.getUploadHistoryAsync(email, fromTime, toTime, verification, null);
        }
        
        /// <remarks/>
        public void getUploadHistoryAsync(string email, System.DateTime fromTime, System.DateTime toTime, int verification, object userState) {
            if ((this.getUploadHistoryOperationCompleted == null)) {
                this.getUploadHistoryOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetUploadHistoryOperationCompleted);
            }
            this.InvokeAsync("getUploadHistory", new object[] {
                        email,
                        fromTime,
                        toTime,
                        verification}, this.getUploadHistoryOperationCompleted, userState);
        }
        
        private void OngetUploadHistoryOperationCompleted(object arg) {
            if ((this.getUploadHistoryCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getUploadHistoryCompleted(this, new getUploadHistoryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteFile", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteFile(int fileID, int verification) {
            this.Invoke("DeleteFile", new object[] {
                        fileID,
                        verification});
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
                this.DeleteFileCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getFile", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getFile(string email, string fileName, int verification) {
            object[] results = this.Invoke("getFile", new object[] {
                        email,
                        fileName,
                        verification});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getFileAsync(string email, string fileName, int verification) {
            this.getFileAsync(email, fileName, verification, null);
        }
        
        /// <remarks/>
        public void getFileAsync(string email, string fileName, int verification, object userState) {
            if ((this.getFileOperationCompleted == null)) {
                this.getFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetFileOperationCompleted);
            }
            this.InvokeAsync("getFile", new object[] {
                        email,
                        fileName,
                        verification}, this.getFileOperationCompleted, userState);
        }
        
        private void OngetFileOperationCompleted(object arg) {
            if ((this.getFileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getFileCompleted(this, new getFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/updateStorageUsed", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void updateStorageUsed(string email, long storageUsed, int verification) {
            this.Invoke("updateStorageUsed", new object[] {
                        email,
                        storageUsed,
                        verification});
        }
        
        /// <remarks/>
        public void updateStorageUsedAsync(string email, long storageUsed, int verification) {
            this.updateStorageUsedAsync(email, storageUsed, verification, null);
        }
        
        /// <remarks/>
        public void updateStorageUsedAsync(string email, long storageUsed, int verification, object userState) {
            if ((this.updateStorageUsedOperationCompleted == null)) {
                this.updateStorageUsedOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateStorageUsedOperationCompleted);
            }
            this.InvokeAsync("updateStorageUsed", new object[] {
                        email,
                        storageUsed,
                        verification}, this.updateStorageUsedOperationCompleted, userState);
        }
        
        private void OnupdateStorageUsedOperationCompleted(object arg) {
            if ((this.updateStorageUsedCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updateStorageUsedCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1098.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Person {
        
        private string emailField;
        
        private string passwordField;
        
        private string nameField;
        
        private int accountTypeField;
        
        private long storageSpaceField;
        
        private long storageUsedField;
        
        /// <remarks/>
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public int AccountType {
            get {
                return this.accountTypeField;
            }
            set {
                this.accountTypeField = value;
            }
        }
        
        /// <remarks/>
        public long StorageSpace {
            get {
                return this.storageSpaceField;
            }
            set {
                this.storageSpaceField = value;
            }
        }
        
        /// <remarks/>
        public long StorageUsed {
            get {
                return this.storageUsedField;
            }
            set {
                this.storageUsedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    public delegate void GetAccountInfoCompletedEventHandler(object sender, GetAccountInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAccountInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAccountInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Person Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Person)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    public delegate void UpdateAccountCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    public delegate void uploadFileCompletedEventHandler(object sender, uploadFileCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class uploadFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal uploadFileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    public delegate void getFilesCompletedEventHandler(object sender, getFilesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getFilesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getFilesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    public delegate void UpdateFileCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    public delegate void getUploadHistoryCompletedEventHandler(object sender, getUploadHistoryCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getUploadHistoryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getUploadHistoryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    public delegate void DeleteFileCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    public delegate void getFileCompletedEventHandler(object sender, getFileCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getFileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    public delegate void updateStorageUsedCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591
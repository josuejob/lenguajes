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

namespace WindowsFormsApplication1.PruebasWsCancelar33 {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="wsCancelar33Soap", Namespace="www.facturaselectronicascfdi.com")]
    public partial class wsCancelar33 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback Cancelar33EncodeCSDOperationCompleted;
        
        private System.Threading.SendOrPostCallback Cancelar33OperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public wsCancelar33() {
            this.Url = global::WindowsFormsApplication1.Properties.Settings.Default.consumeWebservice_PruebasWsCancelar33_PruebasWsCancelar33;
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
        public event Cancelar33EncodeCSDCompletedEventHandler Cancelar33EncodeCSDCompleted;
        
        /// <remarks/>
        public event Cancelar33CompletedEventHandler Cancelar33Completed;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("www.facturaselectronicascfdi.com/Cancelar33EncodeCSD", RequestNamespace="www.facturaselectronicascfdi.com", ResponseNamespace="www.facturaselectronicascfdi.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public resultado33 Cancelar33EncodeCSD(string curCorreo, string password, string RfcEmisor, string UUID, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] CerFile, string KeyEncode64) {
            object[] results = this.Invoke("Cancelar33EncodeCSD", new object[] {
                        curCorreo,
                        password,
                        RfcEmisor,
                        UUID,
                        CerFile,
                        KeyEncode64});
            return ((resultado33)(results[0]));
        }
        
        /// <remarks/>
        public void Cancelar33EncodeCSDAsync(string curCorreo, string password, string RfcEmisor, string UUID, byte[] CerFile, string KeyEncode64) {
            this.Cancelar33EncodeCSDAsync(curCorreo, password, RfcEmisor, UUID, CerFile, KeyEncode64, null);
        }
        
        /// <remarks/>
        public void Cancelar33EncodeCSDAsync(string curCorreo, string password, string RfcEmisor, string UUID, byte[] CerFile, string KeyEncode64, object userState) {
            if ((this.Cancelar33EncodeCSDOperationCompleted == null)) {
                this.Cancelar33EncodeCSDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCancelar33EncodeCSDOperationCompleted);
            }
            this.InvokeAsync("Cancelar33EncodeCSD", new object[] {
                        curCorreo,
                        password,
                        RfcEmisor,
                        UUID,
                        CerFile,
                        KeyEncode64}, this.Cancelar33EncodeCSDOperationCompleted, userState);
        }
        
        private void OnCancelar33EncodeCSDOperationCompleted(object arg) {
            if ((this.Cancelar33EncodeCSDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Cancelar33EncodeCSDCompleted(this, new Cancelar33EncodeCSDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("www.facturaselectronicascfdi.com/Cancelar33", RequestNamespace="www.facturaselectronicascfdi.com", ResponseNamespace="www.facturaselectronicascfdi.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public resultado33 Cancelar33(string curCorreo, string password, string RfcEmisor, string UUID) {
            object[] results = this.Invoke("Cancelar33", new object[] {
                        curCorreo,
                        password,
                        RfcEmisor,
                        UUID});
            return ((resultado33)(results[0]));
        }
        
        /// <remarks/>
        public void Cancelar33Async(string curCorreo, string password, string RfcEmisor, string UUID) {
            this.Cancelar33Async(curCorreo, password, RfcEmisor, UUID, null);
        }
        
        /// <remarks/>
        public void Cancelar33Async(string curCorreo, string password, string RfcEmisor, string UUID, object userState) {
            if ((this.Cancelar33OperationCompleted == null)) {
                this.Cancelar33OperationCompleted = new System.Threading.SendOrPostCallback(this.OnCancelar33OperationCompleted);
            }
            this.InvokeAsync("Cancelar33", new object[] {
                        curCorreo,
                        password,
                        RfcEmisor,
                        UUID}, this.Cancelar33OperationCompleted, userState);
        }
        
        private void OnCancelar33OperationCompleted(object arg) {
            if ((this.Cancelar33Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Cancelar33Completed(this, new Cancelar33CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="www.facturaselectronicascfdi.com")]
    public partial class resultado33 {
        
        private string selloField;
        
        private string erroresField;
        
        private byte[] xmlSelladoField;
        
        private byte[] acuseField;
        
        private byte[][] arregloAcuseField;
        
        private string cadenaOriginalField;
        
        private System.DateTime fechaHoraTimbradoField;
        
        private bool fechaHoraTimbradoFieldSpecified;
        
        private bool fechaHoraTimbradoSpecified1Field;
        
        private string folioUUIDField;
        
        private byte[] pDFField;
        
        private string selloDigitalEmisorField;
        
        private string selloDigitalTimbreSATField;
        
        private byte[] xMLField;
        
        /// <remarks/>
        public string sello {
            get {
                return this.selloField;
            }
            set {
                this.selloField = value;
            }
        }
        
        /// <remarks/>
        public string errores {
            get {
                return this.erroresField;
            }
            set {
                this.erroresField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] xmlSellado {
            get {
                return this.xmlSelladoField;
            }
            set {
                this.xmlSelladoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] acuse {
            get {
                return this.acuseField;
            }
            set {
                this.acuseField = value;
            }
        }
        
        /// <remarks/>
        public byte[][] arregloAcuse {
            get {
                return this.arregloAcuseField;
            }
            set {
                this.arregloAcuseField = value;
            }
        }
        
        /// <remarks/>
        public string cadenaOriginal {
            get {
                return this.cadenaOriginalField;
            }
            set {
                this.cadenaOriginalField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime fechaHoraTimbrado {
            get {
                return this.fechaHoraTimbradoField;
            }
            set {
                this.fechaHoraTimbradoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaHoraTimbradoSpecified {
            get {
                return this.fechaHoraTimbradoFieldSpecified;
            }
            set {
                this.fechaHoraTimbradoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fechaHoraTimbradoSpecified")]
        public bool fechaHoraTimbradoSpecified1 {
            get {
                return this.fechaHoraTimbradoSpecified1Field;
            }
            set {
                this.fechaHoraTimbradoSpecified1Field = value;
            }
        }
        
        /// <remarks/>
        public string folioUUID {
            get {
                return this.folioUUIDField;
            }
            set {
                this.folioUUIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] PDF {
            get {
                return this.pDFField;
            }
            set {
                this.pDFField = value;
            }
        }
        
        /// <remarks/>
        public string selloDigitalEmisor {
            get {
                return this.selloDigitalEmisorField;
            }
            set {
                this.selloDigitalEmisorField = value;
            }
        }
        
        /// <remarks/>
        public string selloDigitalTimbreSAT {
            get {
                return this.selloDigitalTimbreSATField;
            }
            set {
                this.selloDigitalTimbreSATField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] XML {
            get {
                return this.xMLField;
            }
            set {
                this.xMLField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void Cancelar33EncodeCSDCompletedEventHandler(object sender, Cancelar33EncodeCSDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Cancelar33EncodeCSDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Cancelar33EncodeCSDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public resultado33 Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((resultado33)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void Cancelar33CompletedEventHandler(object sender, Cancelar33CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Cancelar33CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Cancelar33CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public resultado33 Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((resultado33)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591
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

namespace WindowsFormsApplication1.PruebasWsTimbradoRetencionesTexto {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="wsTimbradoRetencionesTextoSoap", Namespace="www.facturaselectronicascfdi.com")]
    public partial class wsTimbradoRetencionesTexto : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback TimbrarRetencionPorTextoOperationCompleted;
        
        private System.Threading.SendOrPostCallback SellarTimbrarRetencionPorTextoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public wsTimbradoRetencionesTexto() {
            this.Url = global::WindowsFormsApplication1.Properties.Settings.Default.consumeWebservice_PruebasWsTimbradoTexto33_wsTimbradoTexto33;
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
        public event TimbrarRetencionPorTextoCompletedEventHandler TimbrarRetencionPorTextoCompleted;
        
        /// <remarks/>
        public event SellarTimbrarRetencionPorTextoCompletedEventHandler SellarTimbrarRetencionPorTextoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("www.facturaselectronicascfdi.com/TimbrarRetencionPorTexto", RequestNamespace="www.facturaselectronicascfdi.com", ResponseNamespace="www.facturaselectronicascfdi.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public resultadoRetencion TimbrarRetencionPorTexto(string correo, string pass, string Proceso, string contenidoArchivo) {
            object[] results = this.Invoke("TimbrarRetencionPorTexto", new object[] {
                        correo,
                        pass,
                        Proceso,
                        contenidoArchivo});
            return ((resultadoRetencion)(results[0]));
        }
        
        /// <remarks/>
        public void TimbrarRetencionPorTextoAsync(string correo, string pass, string Proceso, string contenidoArchivo) {
            this.TimbrarRetencionPorTextoAsync(correo, pass, Proceso, contenidoArchivo, null);
        }
        
        /// <remarks/>
        public void TimbrarRetencionPorTextoAsync(string correo, string pass, string Proceso, string contenidoArchivo, object userState) {
            if ((this.TimbrarRetencionPorTextoOperationCompleted == null)) {
                this.TimbrarRetencionPorTextoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTimbrarRetencionPorTextoOperationCompleted);
            }
            this.InvokeAsync("TimbrarRetencionPorTexto", new object[] {
                        correo,
                        pass,
                        Proceso,
                        contenidoArchivo}, this.TimbrarRetencionPorTextoOperationCompleted, userState);
        }
        
        private void OnTimbrarRetencionPorTextoOperationCompleted(object arg) {
            if ((this.TimbrarRetencionPorTextoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TimbrarRetencionPorTextoCompleted(this, new TimbrarRetencionPorTextoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("www.facturaselectronicascfdi.com/SellarTimbrarRetencionPorTexto", RequestNamespace="www.facturaselectronicascfdi.com", ResponseNamespace="www.facturaselectronicascfdi.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public resultadoRetencion SellarTimbrarRetencionPorTexto(string correo, string pass, string Proceso, string contenidoArchivo, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] cerFile, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] keyFile, string passCer) {
            object[] results = this.Invoke("SellarTimbrarRetencionPorTexto", new object[] {
                        correo,
                        pass,
                        Proceso,
                        contenidoArchivo,
                        cerFile,
                        keyFile,
                        passCer});
            return ((resultadoRetencion)(results[0]));
        }
        
        /// <remarks/>
        public void SellarTimbrarRetencionPorTextoAsync(string correo, string pass, string Proceso, string contenidoArchivo, byte[] cerFile, byte[] keyFile, string passCer) {
            this.SellarTimbrarRetencionPorTextoAsync(correo, pass, Proceso, contenidoArchivo, cerFile, keyFile, passCer, null);
        }
        
        /// <remarks/>
        public void SellarTimbrarRetencionPorTextoAsync(string correo, string pass, string Proceso, string contenidoArchivo, byte[] cerFile, byte[] keyFile, string passCer, object userState) {
            if ((this.SellarTimbrarRetencionPorTextoOperationCompleted == null)) {
                this.SellarTimbrarRetencionPorTextoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSellarTimbrarRetencionPorTextoOperationCompleted);
            }
            this.InvokeAsync("SellarTimbrarRetencionPorTexto", new object[] {
                        correo,
                        pass,
                        Proceso,
                        contenidoArchivo,
                        cerFile,
                        keyFile,
                        passCer}, this.SellarTimbrarRetencionPorTextoOperationCompleted, userState);
        }
        
        private void OnSellarTimbrarRetencionPorTextoOperationCompleted(object arg) {
            if ((this.SellarTimbrarRetencionPorTextoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SellarTimbrarRetencionPorTextoCompleted(this, new SellarTimbrarRetencionPorTextoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="www.facturaselectronicascfdi.com")]
    public partial class resultadoRetencion {
        
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    public delegate void TimbrarRetencionPorTextoCompletedEventHandler(object sender, TimbrarRetencionPorTextoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TimbrarRetencionPorTextoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TimbrarRetencionPorTextoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public resultadoRetencion Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((resultadoRetencion)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    public delegate void SellarTimbrarRetencionPorTextoCompletedEventHandler(object sender, SellarTimbrarRetencionPorTextoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SellarTimbrarRetencionPorTextoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SellarTimbrarRetencionPorTextoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public resultadoRetencion Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((resultadoRetencion)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591
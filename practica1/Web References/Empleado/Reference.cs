﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace practica1.Empleado {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="EmpleadoServiceSOAP", Namespace="http://www.mtis.org/NewWSDLFile/")]
    public partial class EmpleadoService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback NewOperationOperationCompleted;
        
        private System.Threading.SendOrPostCallback borrarOperationCompleted;
        
        private System.Threading.SendOrPostCallback modificarOperationCompleted;
        
        private System.Threading.SendOrPostCallback consultarOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public EmpleadoService() {
            this.Url = global::practica1.Properties.Settings.Default.practica1_Empleado_EmpleadoService;
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
        public event NewOperationCompletedEventHandler NewOperationCompleted;
        
        /// <remarks/>
        public event borrarCompletedEventHandler borrarCompleted;
        
        /// <remarks/>
        public event modificarCompletedEventHandler modificarCompleted;
        
        /// <remarks/>
        public event consultarCompletedEventHandler consultarCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.mtis.org/NewWSDLFile/NewOperation", RequestElementName="nuevo", RequestNamespace="http://www.mtis.org/NewWSDLFile/", ResponseElementName="EmpleadoResponse", ResponseNamespace="http://www.mtis.org/NewWSDLFile/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("salidaNuevoEmpleado", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool NewOperation([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string DNI, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string Nombre, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string Apellidos, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string Direccion, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string Poblacion, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string Telefono, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string Email, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")] System.DateTime Fecha_Nacimiento, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string NSS, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string IBAN, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string SoapKey, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string salidaErrores) {
            object[] results = this.Invoke("NewOperation", new object[] {
                        DNI,
                        Nombre,
                        Apellidos,
                        Direccion,
                        Poblacion,
                        Telefono,
                        Email,
                        Fecha_Nacimiento,
                        NSS,
                        IBAN,
                        SoapKey});
            salidaErrores = ((string)(results[1]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void NewOperationAsync(string DNI, string Nombre, string Apellidos, string Direccion, string Poblacion, string Telefono, string Email, System.DateTime Fecha_Nacimiento, string NSS, string IBAN, string SoapKey) {
            this.NewOperationAsync(DNI, Nombre, Apellidos, Direccion, Poblacion, Telefono, Email, Fecha_Nacimiento, NSS, IBAN, SoapKey, null);
        }
        
        /// <remarks/>
        public void NewOperationAsync(string DNI, string Nombre, string Apellidos, string Direccion, string Poblacion, string Telefono, string Email, System.DateTime Fecha_Nacimiento, string NSS, string IBAN, string SoapKey, object userState) {
            if ((this.NewOperationOperationCompleted == null)) {
                this.NewOperationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnNewOperationOperationCompleted);
            }
            this.InvokeAsync("NewOperation", new object[] {
                        DNI,
                        Nombre,
                        Apellidos,
                        Direccion,
                        Poblacion,
                        Telefono,
                        Email,
                        Fecha_Nacimiento,
                        NSS,
                        IBAN,
                        SoapKey}, this.NewOperationOperationCompleted, userState);
        }
        
        private void OnNewOperationOperationCompleted(object arg) {
            if ((this.NewOperationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.NewOperationCompleted(this, new NewOperationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.mtis.org/NewWSDLFile/borrar", RequestNamespace="http://www.mtis.org/NewWSDLFile/", ResponseNamespace="http://www.mtis.org/NewWSDLFile/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("salidaBorradoEmpleado", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool borrar([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string DNI, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string SoapKey, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string salidaError) {
            object[] results = this.Invoke("borrar", new object[] {
                        DNI,
                        SoapKey});
            salidaError = ((string)(results[1]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void borrarAsync(string DNI, string SoapKey) {
            this.borrarAsync(DNI, SoapKey, null);
        }
        
        /// <remarks/>
        public void borrarAsync(string DNI, string SoapKey, object userState) {
            if ((this.borrarOperationCompleted == null)) {
                this.borrarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnborrarOperationCompleted);
            }
            this.InvokeAsync("borrar", new object[] {
                        DNI,
                        SoapKey}, this.borrarOperationCompleted, userState);
        }
        
        private void OnborrarOperationCompleted(object arg) {
            if ((this.borrarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.borrarCompleted(this, new borrarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.mtis.org/NewWSDLFile/modificar", RequestNamespace="http://www.mtis.org/NewWSDLFile/", ResponseNamespace="http://www.mtis.org/NewWSDLFile/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("salidaModificarResponse", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool modificar([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string DNI, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string Nombre, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string Apellidos, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string Direccion, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string Poblacion, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string Telefono, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string Email, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")] System.DateTime Fecha_nacimiento, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string NSS, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string IBAN, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string SoapKey, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string salidaError) {
            object[] results = this.Invoke("modificar", new object[] {
                        DNI,
                        Nombre,
                        Apellidos,
                        Direccion,
                        Poblacion,
                        Telefono,
                        Email,
                        Fecha_nacimiento,
                        NSS,
                        IBAN,
                        SoapKey});
            salidaError = ((string)(results[1]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void modificarAsync(string DNI, string Nombre, string Apellidos, string Direccion, string Poblacion, string Telefono, string Email, System.DateTime Fecha_nacimiento, string NSS, string IBAN, string SoapKey) {
            this.modificarAsync(DNI, Nombre, Apellidos, Direccion, Poblacion, Telefono, Email, Fecha_nacimiento, NSS, IBAN, SoapKey, null);
        }
        
        /// <remarks/>
        public void modificarAsync(string DNI, string Nombre, string Apellidos, string Direccion, string Poblacion, string Telefono, string Email, System.DateTime Fecha_nacimiento, string NSS, string IBAN, string SoapKey, object userState) {
            if ((this.modificarOperationCompleted == null)) {
                this.modificarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnmodificarOperationCompleted);
            }
            this.InvokeAsync("modificar", new object[] {
                        DNI,
                        Nombre,
                        Apellidos,
                        Direccion,
                        Poblacion,
                        Telefono,
                        Email,
                        Fecha_nacimiento,
                        NSS,
                        IBAN,
                        SoapKey}, this.modificarOperationCompleted, userState);
        }
        
        private void OnmodificarOperationCompleted(object arg) {
            if ((this.modificarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.modificarCompleted(this, new modificarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.mtis.org/NewWSDLFile/consultar", RequestNamespace="http://www.mtis.org/NewWSDLFile/", ResponseNamespace="http://www.mtis.org/NewWSDLFile/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Nombre", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string consultar([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] ref string DNI, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string SoapKey, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string Apellidos, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string Direccion, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string Poblacion, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string Telefono, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string Email, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")] out System.DateTime Fecha_nacimiento, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string NSS, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string IBAN, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string salidaError) {
            object[] results = this.Invoke("consultar", new object[] {
                        DNI,
                        SoapKey});
            DNI = ((string)(results[1]));
            Apellidos = ((string)(results[2]));
            Direccion = ((string)(results[3]));
            Poblacion = ((string)(results[4]));
            Telefono = ((string)(results[5]));
            Email = ((string)(results[6]));
            Fecha_nacimiento = ((System.DateTime)(results[7]));
            NSS = ((string)(results[8]));
            IBAN = ((string)(results[9]));
            salidaError = ((string)(results[10]));
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void consultarAsync(string DNI, string SoapKey) {
            this.consultarAsync(DNI, SoapKey, null);
        }
        
        /// <remarks/>
        public void consultarAsync(string DNI, string SoapKey, object userState) {
            if ((this.consultarOperationCompleted == null)) {
                this.consultarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnconsultarOperationCompleted);
            }
            this.InvokeAsync("consultar", new object[] {
                        DNI,
                        SoapKey}, this.consultarOperationCompleted, userState);
        }
        
        private void OnconsultarOperationCompleted(object arg) {
            if ((this.consultarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.consultarCompleted(this, new consultarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void NewOperationCompletedEventHandler(object sender, NewOperationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class NewOperationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal NewOperationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        
        /// <remarks/>
        public string salidaErrores {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void borrarCompletedEventHandler(object sender, borrarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class borrarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal borrarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        
        /// <remarks/>
        public string salidaError {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void modificarCompletedEventHandler(object sender, modificarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class modificarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal modificarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        
        /// <remarks/>
        public string salidaError {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void consultarCompletedEventHandler(object sender, consultarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class consultarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal consultarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string DNI {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string Apellidos {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
        
        /// <remarks/>
        public string Direccion {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[3]));
            }
        }
        
        /// <remarks/>
        public string Poblacion {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[4]));
            }
        }
        
        /// <remarks/>
        public string Telefono {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[5]));
            }
        }
        
        /// <remarks/>
        public string Email {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[6]));
            }
        }
        
        /// <remarks/>
        public System.DateTime Fecha_nacimiento {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.DateTime)(this.results[7]));
            }
        }
        
        /// <remarks/>
        public string NSS {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[8]));
            }
        }
        
        /// <remarks/>
        public string IBAN {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[9]));
            }
        }
        
        /// <remarks/>
        public string salidaError {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[10]));
            }
        }
    }
}

#pragma warning restore 1591
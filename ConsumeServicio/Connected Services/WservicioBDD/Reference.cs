﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsumeServicio.WservicioBDD {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WservicioBDD.WebServiceBDDSoap")]
    public interface WebServiceBDDSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSselect_Usuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet WSselect_Usuario();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSselect_Usuario", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> WSselect_UsuarioAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSValidar_Usuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool WSValidar_Usuario(int id, int contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSValidar_Usuario", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> WSValidar_UsuarioAsync(int id, int contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSValidar_Usuario1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet WSValidar_Usuario1(int id, int contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSValidar_Usuario1", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> WSValidar_Usuario1Async(int id, int contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSValidar_Usuario2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int WSValidar_Usuario2(int id, int contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSValidar_Usuario2", ReplyAction="*")]
        System.Threading.Tasks.Task<int> WSValidar_Usuario2Async(int id, int contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSinsert_Usuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string WSinsert_Usuario(int id_usuario, int id_clinica, string nombre_usuario, string apellido_usuario, string fecha_nac, string dpi, int nit, string direccion, string correo, int no_telelefono);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSinsert_Usuario", ReplyAction="*")]
        System.Threading.Tasks.Task<string> WSinsert_UsuarioAsync(int id_usuario, int id_clinica, string nombre_usuario, string apellido_usuario, string fecha_nac, string dpi, int nit, string direccion, string correo, int no_telelefono);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSinsert_Clinica", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string WSinsert_Clinica(int id_clinica, string nombre_clinica, string direccion, string correo, int no_telelefono, int nit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSinsert_Clinica", ReplyAction="*")]
        System.Threading.Tasks.Task<string> WSinsert_ClinicaAsync(int id_clinica, string nombre_clinica, string direccion, string correo, int no_telelefono, int nit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSBorrar_Clinica", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void WSBorrar_Clinica(int id_clinica);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSBorrar_Clinica", ReplyAction="*")]
        System.Threading.Tasks.Task WSBorrar_ClinicaAsync(int id_clinica);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceBDDSoapChannel : ConsumeServicio.WservicioBDD.WebServiceBDDSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceBDDSoapClient : System.ServiceModel.ClientBase<ConsumeServicio.WservicioBDD.WebServiceBDDSoap>, ConsumeServicio.WservicioBDD.WebServiceBDDSoap {
        
        public WebServiceBDDSoapClient() {
        }
        
        public WebServiceBDDSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceBDDSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceBDDSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceBDDSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet WSselect_Usuario() {
            return base.Channel.WSselect_Usuario();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> WSselect_UsuarioAsync() {
            return base.Channel.WSselect_UsuarioAsync();
        }
        
        public bool WSValidar_Usuario(int id, int contrasena) {
            return base.Channel.WSValidar_Usuario(id, contrasena);
        }
        
        public System.Threading.Tasks.Task<bool> WSValidar_UsuarioAsync(int id, int contrasena) {
            return base.Channel.WSValidar_UsuarioAsync(id, contrasena);
        }
        
        public System.Data.DataSet WSValidar_Usuario1(int id, int contrasena) {
            return base.Channel.WSValidar_Usuario1(id, contrasena);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> WSValidar_Usuario1Async(int id, int contrasena) {
            return base.Channel.WSValidar_Usuario1Async(id, contrasena);
        }
        
        public int WSValidar_Usuario2(int id, int contrasena) {
            return base.Channel.WSValidar_Usuario2(id, contrasena);
        }
        
        public System.Threading.Tasks.Task<int> WSValidar_Usuario2Async(int id, int contrasena) {
            return base.Channel.WSValidar_Usuario2Async(id, contrasena);
        }
        
        public string WSinsert_Usuario(int id_usuario, int id_clinica, string nombre_usuario, string apellido_usuario, string fecha_nac, string dpi, int nit, string direccion, string correo, int no_telelefono) {
            return base.Channel.WSinsert_Usuario(id_usuario, id_clinica, nombre_usuario, apellido_usuario, fecha_nac, dpi, nit, direccion, correo, no_telelefono);
        }
        
        public System.Threading.Tasks.Task<string> WSinsert_UsuarioAsync(int id_usuario, int id_clinica, string nombre_usuario, string apellido_usuario, string fecha_nac, string dpi, int nit, string direccion, string correo, int no_telelefono) {
            return base.Channel.WSinsert_UsuarioAsync(id_usuario, id_clinica, nombre_usuario, apellido_usuario, fecha_nac, dpi, nit, direccion, correo, no_telelefono);
        }
        
        public string WSinsert_Clinica(int id_clinica, string nombre_clinica, string direccion, string correo, int no_telelefono, int nit) {
            return base.Channel.WSinsert_Clinica(id_clinica, nombre_clinica, direccion, correo, no_telelefono, nit);
        }
        
        public System.Threading.Tasks.Task<string> WSinsert_ClinicaAsync(int id_clinica, string nombre_clinica, string direccion, string correo, int no_telelefono, int nit) {
            return base.Channel.WSinsert_ClinicaAsync(id_clinica, nombre_clinica, direccion, correo, no_telelefono, nit);
        }
        
        public void WSBorrar_Clinica(int id_clinica) {
            base.Channel.WSBorrar_Clinica(id_clinica);
        }
        
        public System.Threading.Tasks.Task WSBorrar_ClinicaAsync(int id_clinica) {
            return base.Channel.WSBorrar_ClinicaAsync(id_clinica);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlCitas.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ValidarUsuario", ReplyAction="http://tempuri.org/IService1/ValidarUsuarioResponse")]
        System.Data.DataSet ValidarUsuario(string Login, string Pasword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ValidarUsuario", ReplyAction="http://tempuri.org/IService1/ValidarUsuarioResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ValidarUsuarioAsync(string Login, string Pasword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertarUsuario", ReplyAction="http://tempuri.org/IService1/InsertarUsuarioResponse")]
        System.Data.DataSet InsertarUsuario(string Username, string Contrasena, int IdRole, bool Activo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertarUsuario", ReplyAction="http://tempuri.org/IService1/InsertarUsuarioResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> InsertarUsuarioAsync(string Username, string Contrasena, int IdRole, bool Activo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Rollist", ReplyAction="http://tempuri.org/IService1/RollistResponse")]
        System.Data.DataSet Rollist();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Rollist", ReplyAction="http://tempuri.org/IService1/RollistResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> RollistAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ModificarUsuario", ReplyAction="http://tempuri.org/IService1/ModificarUsuarioResponse")]
        System.Data.DataSet ModificarUsuario(int IdUsuario, string Username, string Contrasena, int IdRole, bool Activo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ModificarUsuario", ReplyAction="http://tempuri.org/IService1/ModificarUsuarioResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ModificarUsuarioAsync(int IdUsuario, string Username, string Contrasena, int IdRole, bool Activo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BuscarUsuario", ReplyAction="http://tempuri.org/IService1/BuscarUsuarioResponse")]
        System.Data.DataSet BuscarUsuario(int IdUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BuscarUsuario", ReplyAction="http://tempuri.org/IService1/BuscarUsuarioResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarUsuarioAsync(int IdUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarUsuario", ReplyAction="http://tempuri.org/IService1/EliminarUsuarioResponse")]
        System.Data.DataSet EliminarUsuario(int IdUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarUsuario", ReplyAction="http://tempuri.org/IService1/EliminarUsuarioResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> EliminarUsuarioAsync(int IdUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertRol", ReplyAction="http://tempuri.org/IService1/InsertRolResponse")]
        System.Data.DataSet InsertRol(string Nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertRol", ReplyAction="http://tempuri.org/IService1/InsertRolResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> InsertRolAsync(string Nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditRol", ReplyAction="http://tempuri.org/IService1/EditRolResponse")]
        System.Data.DataSet EditRol(int IdRole, string Nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditRol", ReplyAction="http://tempuri.org/IService1/EditRolResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> EditRolAsync(int IdRole, string Nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarRol", ReplyAction="http://tempuri.org/IService1/EliminarRolResponse")]
        System.Data.DataSet EliminarRol(int IdRole);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarRol", ReplyAction="http://tempuri.org/IService1/EliminarRolResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> EliminarRolAsync(int IdRole);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BuscarRol", ReplyAction="http://tempuri.org/IService1/BuscarRolResponse")]
        System.Data.DataSet BuscarRol(int IdRole);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BuscarRol", ReplyAction="http://tempuri.org/IService1/BuscarRolResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarRolAsync(int IdRole);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BuscarDoc", ReplyAction="http://tempuri.org/IService1/BuscarDocResponse")]
        System.Data.DataSet BuscarDoc(int IdDoctores);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BuscarDoc", ReplyAction="http://tempuri.org/IService1/BuscarDocResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarDocAsync(int IdDoctores);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BorrarDoc", ReplyAction="http://tempuri.org/IService1/BorrarDocResponse")]
        System.Data.DataSet BorrarDoc(int IdDoctores);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BorrarDoc", ReplyAction="http://tempuri.org/IService1/BorrarDocResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> BorrarDocAsync(int IdDoctores);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertDoctor", ReplyAction="http://tempuri.org/IService1/InsertDoctorResponse")]
        System.Data.DataSet InsertDoctor(string Nombre, string Apellido, string tel, string Email, int IdEspecialidad, int IdUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertDoctor", ReplyAction="http://tempuri.org/IService1/InsertDoctorResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> InsertDoctorAsync(string Nombre, string Apellido, string tel, string Email, int IdEspecialidad, int IdUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ModificarDoctor", ReplyAction="http://tempuri.org/IService1/ModificarDoctorResponse")]
        System.Data.DataSet ModificarDoctor(int IdDoctores, string Nombre, string Apellido, string tel, string Email, int IdEspecialidad, int IdUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ModificarDoctor", ReplyAction="http://tempuri.org/IService1/ModificarDoctorResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ModificarDoctorAsync(int IdDoctores, string Nombre, string Apellido, string tel, string Email, int IdEspecialidad, int IdUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListarUsuario", ReplyAction="http://tempuri.org/IService1/ListarUsuarioResponse")]
        System.Data.DataSet ListarUsuario();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListarUsuario", ReplyAction="http://tempuri.org/IService1/ListarUsuarioResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarUsuarioAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListarEspecialidad", ReplyAction="http://tempuri.org/IService1/ListarEspecialidadResponse")]
        System.Data.DataSet ListarEspecialidad();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListarEspecialidad", ReplyAction="http://tempuri.org/IService1/ListarEspecialidadResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarEspecialidadAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BuscarPaciente", ReplyAction="http://tempuri.org/IService1/BuscarPacienteResponse")]
        System.Data.DataSet BuscarPaciente(int IdPaciente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BuscarPaciente", ReplyAction="http://tempuri.org/IService1/BuscarPacienteResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarPacienteAsync(int IdPaciente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertPaciente", ReplyAction="http://tempuri.org/IService1/InsertPacienteResponse")]
        System.Data.DataSet InsertPaciente(string Nombre, string Apellido, string Direccion, string Telefono, string Email, System.DateTime FNacimiento, string DUI);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertPaciente", ReplyAction="http://tempuri.org/IService1/InsertPacienteResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> InsertPacienteAsync(string Nombre, string Apellido, string Direccion, string Telefono, string Email, System.DateTime FNacimiento, string DUI);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BorrarPaciente", ReplyAction="http://tempuri.org/IService1/BorrarPacienteResponse")]
        System.Data.DataSet BorrarPaciente(int IdPaciente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BorrarPaciente", ReplyAction="http://tempuri.org/IService1/BorrarPacienteResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> BorrarPacienteAsync(int IdPaciente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ActualizarPaciente", ReplyAction="http://tempuri.org/IService1/ActualizarPacienteResponse")]
        System.Data.DataSet ActualizarPaciente(int IdPaciente, string Nombre, string Apellido, string Direccion, string Telefono, string Email, System.DateTime FNacimiento, string DUI);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ActualizarPaciente", ReplyAction="http://tempuri.org/IService1/ActualizarPacienteResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ActualizarPacienteAsync(int IdPaciente, string Nombre, string Apellido, string Direccion, string Telefono, string Email, System.DateTime FNacimiento, string DUI);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BuscarCita", ReplyAction="http://tempuri.org/IService1/BuscarCitaResponse")]
        System.Data.DataSet BuscarCita(int IdCitas);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BuscarCita", ReplyAction="http://tempuri.org/IService1/BuscarCitaResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarCitaAsync(int IdCitas);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BorrarCita", ReplyAction="http://tempuri.org/IService1/BorrarCitaResponse")]
        System.Data.DataSet BorrarCita(int IdCitas);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BorrarCita", ReplyAction="http://tempuri.org/IService1/BorrarCitaResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> BorrarCitaAsync(int IdCitas);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertarCita", ReplyAction="http://tempuri.org/IService1/InsertarCitaResponse")]
        System.Data.DataSet InsertarCita(System.DateTime Fecha, string Hora, int IdDoctores, int IdPaciente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertarCita", ReplyAction="http://tempuri.org/IService1/InsertarCitaResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> InsertarCitaAsync(System.DateTime Fecha, string Hora, int IdDoctores, int IdPaciente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ModificarCitas", ReplyAction="http://tempuri.org/IService1/ModificarCitasResponse")]
        System.Data.DataSet ModificarCitas(int Citas, System.DateTime Fecha, string Hora, int IdDoctores, int IdPaciente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ModificarCitas", ReplyAction="http://tempuri.org/IService1/ModificarCitasResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ModificarCitasAsync(int Citas, System.DateTime Fecha, string Hora, int IdDoctores, int IdPaciente);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ControlCitas.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ControlCitas.ServiceReference1.IService1>, ControlCitas.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet ValidarUsuario(string Login, string Pasword) {
            return base.Channel.ValidarUsuario(Login, Pasword);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ValidarUsuarioAsync(string Login, string Pasword) {
            return base.Channel.ValidarUsuarioAsync(Login, Pasword);
        }
        
        public System.Data.DataSet InsertarUsuario(string Username, string Contrasena, int IdRole, bool Activo) {
            return base.Channel.InsertarUsuario(Username, Contrasena, IdRole, Activo);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> InsertarUsuarioAsync(string Username, string Contrasena, int IdRole, bool Activo) {
            return base.Channel.InsertarUsuarioAsync(Username, Contrasena, IdRole, Activo);
        }
        
        public System.Data.DataSet Rollist() {
            return base.Channel.Rollist();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> RollistAsync() {
            return base.Channel.RollistAsync();
        }
        
        public System.Data.DataSet ModificarUsuario(int IdUsuario, string Username, string Contrasena, int IdRole, bool Activo) {
            return base.Channel.ModificarUsuario(IdUsuario, Username, Contrasena, IdRole, Activo);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ModificarUsuarioAsync(int IdUsuario, string Username, string Contrasena, int IdRole, bool Activo) {
            return base.Channel.ModificarUsuarioAsync(IdUsuario, Username, Contrasena, IdRole, Activo);
        }
        
        public System.Data.DataSet BuscarUsuario(int IdUsuario) {
            return base.Channel.BuscarUsuario(IdUsuario);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarUsuarioAsync(int IdUsuario) {
            return base.Channel.BuscarUsuarioAsync(IdUsuario);
        }
        
        public System.Data.DataSet EliminarUsuario(int IdUsuario) {
            return base.Channel.EliminarUsuario(IdUsuario);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> EliminarUsuarioAsync(int IdUsuario) {
            return base.Channel.EliminarUsuarioAsync(IdUsuario);
        }
        
        public System.Data.DataSet InsertRol(string Nombre) {
            return base.Channel.InsertRol(Nombre);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> InsertRolAsync(string Nombre) {
            return base.Channel.InsertRolAsync(Nombre);
        }
        
        public System.Data.DataSet EditRol(int IdRole, string Nombre) {
            return base.Channel.EditRol(IdRole, Nombre);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> EditRolAsync(int IdRole, string Nombre) {
            return base.Channel.EditRolAsync(IdRole, Nombre);
        }
        
        public System.Data.DataSet EliminarRol(int IdRole) {
            return base.Channel.EliminarRol(IdRole);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> EliminarRolAsync(int IdRole) {
            return base.Channel.EliminarRolAsync(IdRole);
        }
        
        public System.Data.DataSet BuscarRol(int IdRole) {
            return base.Channel.BuscarRol(IdRole);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarRolAsync(int IdRole) {
            return base.Channel.BuscarRolAsync(IdRole);
        }
        
        public System.Data.DataSet BuscarDoc(int IdDoctores) {
            return base.Channel.BuscarDoc(IdDoctores);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarDocAsync(int IdDoctores) {
            return base.Channel.BuscarDocAsync(IdDoctores);
        }
        
        public System.Data.DataSet BorrarDoc(int IdDoctores) {
            return base.Channel.BorrarDoc(IdDoctores);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BorrarDocAsync(int IdDoctores) {
            return base.Channel.BorrarDocAsync(IdDoctores);
        }
        
        public System.Data.DataSet InsertDoctor(string Nombre, string Apellido, string tel, string Email, int IdEspecialidad, int IdUsuario) {
            return base.Channel.InsertDoctor(Nombre, Apellido, tel, Email, IdEspecialidad, IdUsuario);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> InsertDoctorAsync(string Nombre, string Apellido, string tel, string Email, int IdEspecialidad, int IdUsuario) {
            return base.Channel.InsertDoctorAsync(Nombre, Apellido, tel, Email, IdEspecialidad, IdUsuario);
        }
        
        public System.Data.DataSet ModificarDoctor(int IdDoctores, string Nombre, string Apellido, string tel, string Email, int IdEspecialidad, int IdUsuario) {
            return base.Channel.ModificarDoctor(IdDoctores, Nombre, Apellido, tel, Email, IdEspecialidad, IdUsuario);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ModificarDoctorAsync(int IdDoctores, string Nombre, string Apellido, string tel, string Email, int IdEspecialidad, int IdUsuario) {
            return base.Channel.ModificarDoctorAsync(IdDoctores, Nombre, Apellido, tel, Email, IdEspecialidad, IdUsuario);
        }
        
        public System.Data.DataSet ListarUsuario() {
            return base.Channel.ListarUsuario();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarUsuarioAsync() {
            return base.Channel.ListarUsuarioAsync();
        }
        
        public System.Data.DataSet ListarEspecialidad() {
            return base.Channel.ListarEspecialidad();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarEspecialidadAsync() {
            return base.Channel.ListarEspecialidadAsync();
        }
        
        public System.Data.DataSet BuscarPaciente(int IdPaciente) {
            return base.Channel.BuscarPaciente(IdPaciente);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarPacienteAsync(int IdPaciente) {
            return base.Channel.BuscarPacienteAsync(IdPaciente);
        }
        
        public System.Data.DataSet InsertPaciente(string Nombre, string Apellido, string Direccion, string Telefono, string Email, System.DateTime FNacimiento, string DUI) {
            return base.Channel.InsertPaciente(Nombre, Apellido, Direccion, Telefono, Email, FNacimiento, DUI);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> InsertPacienteAsync(string Nombre, string Apellido, string Direccion, string Telefono, string Email, System.DateTime FNacimiento, string DUI) {
            return base.Channel.InsertPacienteAsync(Nombre, Apellido, Direccion, Telefono, Email, FNacimiento, DUI);
        }
        
        public System.Data.DataSet BorrarPaciente(int IdPaciente) {
            return base.Channel.BorrarPaciente(IdPaciente);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BorrarPacienteAsync(int IdPaciente) {
            return base.Channel.BorrarPacienteAsync(IdPaciente);
        }
        
        public System.Data.DataSet ActualizarPaciente(int IdPaciente, string Nombre, string Apellido, string Direccion, string Telefono, string Email, System.DateTime FNacimiento, string DUI) {
            return base.Channel.ActualizarPaciente(IdPaciente, Nombre, Apellido, Direccion, Telefono, Email, FNacimiento, DUI);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ActualizarPacienteAsync(int IdPaciente, string Nombre, string Apellido, string Direccion, string Telefono, string Email, System.DateTime FNacimiento, string DUI) {
            return base.Channel.ActualizarPacienteAsync(IdPaciente, Nombre, Apellido, Direccion, Telefono, Email, FNacimiento, DUI);
        }
        
        public System.Data.DataSet BuscarCita(int IdCitas) {
            return base.Channel.BuscarCita(IdCitas);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarCitaAsync(int IdCitas) {
            return base.Channel.BuscarCitaAsync(IdCitas);
        }
        
        public System.Data.DataSet BorrarCita(int IdCitas) {
            return base.Channel.BorrarCita(IdCitas);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BorrarCitaAsync(int IdCitas) {
            return base.Channel.BorrarCitaAsync(IdCitas);
        }
        
        public System.Data.DataSet InsertarCita(System.DateTime Fecha, string Hora, int IdDoctores, int IdPaciente) {
            return base.Channel.InsertarCita(Fecha, Hora, IdDoctores, IdPaciente);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> InsertarCitaAsync(System.DateTime Fecha, string Hora, int IdDoctores, int IdPaciente) {
            return base.Channel.InsertarCitaAsync(Fecha, Hora, IdDoctores, IdPaciente);
        }
        
        public System.Data.DataSet ModificarCitas(int Citas, System.DateTime Fecha, string Hora, int IdDoctores, int IdPaciente) {
            return base.Channel.ModificarCitas(Citas, Fecha, Hora, IdDoctores, IdPaciente);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ModificarCitasAsync(int Citas, System.DateTime Fecha, string Hora, int IdDoctores, int IdPaciente) {
            return base.Channel.ModificarCitasAsync(Citas, Fecha, Hora, IdDoctores, IdPaciente);
        }
    }
}

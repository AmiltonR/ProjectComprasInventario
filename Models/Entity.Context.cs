//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectComprasInventario.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entity : DbContext
    {
        public Entity()
            : base("name=Entity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<archivos_cotizaciones> archivos_cotizaciones { get; set; }
        public virtual DbSet<cotizacion_proveedor> cotizacion_proveedor { get; set; }
        public virtual DbSet<cotizaciones> cotizaciones { get; set; }
        public virtual DbSet<departamentos> departamentos { get; set; }
        public virtual DbSet<estado_cotizacion> estado_cotizacion { get; set; }
        public virtual DbSet<estado_cotizacion_proveedor> estado_cotizacion_proveedor { get; set; }
        public virtual DbSet<estado_ordenCompra> estado_ordenCompra { get; set; }
        public virtual DbSet<estado_solicitud> estado_solicitud { get; set; }
        public virtual DbSet<ordenCompra> ordenCompra { get; set; }
        public virtual DbSet<proveedores> proveedores { get; set; }
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<solicitud> solicitud { get; set; }
        public virtual DbSet<solicitud_cotizacion> solicitud_cotizacion { get; set; }
        public virtual DbSet<suministros> suministros { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tipoCotizacion> tipoCotizacion { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<SP_SeleccionarSuministros_Result> SP_SeleccionarSuministros()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SeleccionarSuministros_Result>("SP_SeleccionarSuministros");
        }
    
        public virtual int SP_GuardarSolicitud(Nullable<int> usuario, Nullable<int> suministro, Nullable<int> cantidad, Nullable<int> estado)
        {
            var usuarioParameter = usuario.HasValue ?
                new ObjectParameter("usuario", usuario) :
                new ObjectParameter("usuario", typeof(int));
    
            var suministroParameter = suministro.HasValue ?
                new ObjectParameter("suministro", suministro) :
                new ObjectParameter("suministro", typeof(int));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("cantidad", cantidad) :
                new ObjectParameter("cantidad", typeof(int));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_GuardarSolicitud", usuarioParameter, suministroParameter, cantidadParameter, estadoParameter);
        }
    
        public virtual ObjectResult<SP_SeleccionarSolicitudes_Result> SP_SeleccionarSolicitudes(Nullable<int> tipoSolicitud)
        {
            var tipoSolicitudParameter = tipoSolicitud.HasValue ?
                new ObjectParameter("tipoSolicitud", tipoSolicitud) :
                new ObjectParameter("tipoSolicitud", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SeleccionarSolicitudes_Result>("SP_SeleccionarSolicitudes", tipoSolicitudParameter);
        }
    
        public virtual ObjectResult<SP_SolicitudesAprobarDenegar_Result> SP_SolicitudesAprobarDenegar(Nullable<int> departamento)
        {
            var departamentoParameter = departamento.HasValue ?
                new ObjectParameter("departamento", departamento) :
                new ObjectParameter("departamento", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SolicitudesAprobarDenegar_Result>("SP_SolicitudesAprobarDenegar", departamentoParameter);
        }
    
        public virtual ObjectResult<SP_SolicitudesUsuario_Result1> SP_SolicitudesUsuario(Nullable<int> usuario)
        {
            var usuarioParameter = usuario.HasValue ?
                new ObjectParameter("usuario", usuario) :
                new ObjectParameter("usuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SolicitudesUsuario_Result1>("SP_SolicitudesUsuario", usuarioParameter);
        }
    
        public virtual int SP_EliminarSolicitud(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_EliminarSolicitud", idParameter);
        }
    
        public virtual int SP_CambiarEstadoSolicitud(Nullable<int> id, Nullable<int> estado)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CambiarEstadoSolicitud", idParameter, estadoParameter);
        }
    
        public virtual ObjectResult<SP_TipoSolicitudes_Result> SP_TipoSolicitudes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_TipoSolicitudes_Result>("SP_TipoSolicitudes");
        }
    
        public virtual ObjectResult<SP_AprobarSolicitudes_Result2> SP_AprobarSolicitudes(Nullable<int> depart, Nullable<int> estado)
        {
            var departParameter = depart.HasValue ?
                new ObjectParameter("depart", depart) :
                new ObjectParameter("depart", typeof(int));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_AprobarSolicitudes_Result2>("SP_AprobarSolicitudes", departParameter, estadoParameter);
        }
    
        public virtual int SP_EditarSolicitud(Nullable<int> id, Nullable<int> suministro, Nullable<int> cantidad)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var suministroParameter = suministro.HasValue ?
                new ObjectParameter("suministro", suministro) :
                new ObjectParameter("suministro", typeof(int));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("cantidad", cantidad) :
                new ObjectParameter("cantidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_EditarSolicitud", idParameter, suministroParameter, cantidadParameter);
        }
    
        public virtual ObjectResult<SP_Login_Result3> SP_Login(string usuario, string contra)
        {
            var usuarioParameter = usuario != null ?
                new ObjectParameter("usuario", usuario) :
                new ObjectParameter("usuario", typeof(string));
    
            var contraParameter = contra != null ?
                new ObjectParameter("contra", contra) :
                new ObjectParameter("contra", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Login_Result3>("SP_Login", usuarioParameter, contraParameter);
        }
    
        public virtual ObjectResult<SP_SeleccionarProveedores_Result> SP_SeleccionarProveedores()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SeleccionarProveedores_Result>("SP_SeleccionarProveedores");
        }
    
        public virtual ObjectResult<SP_SolicitudesGlobales_Result4> SP_SolicitudesGlobales()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SolicitudesGlobales_Result4>("SP_SolicitudesGlobales");
        }
    
        public virtual ObjectResult<Nullable<int>> SP_GuardarCotizacion(string nombre, byte[] archivo, Nullable<int> usuario)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var archivoParameter = archivo != null ?
                new ObjectParameter("archivo", archivo) :
                new ObjectParameter("archivo", typeof(byte[]));
    
            var usuarioParameter = usuario.HasValue ?
                new ObjectParameter("usuario", usuario) :
                new ObjectParameter("usuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_GuardarCotizacion", nombreParameter, archivoParameter, usuarioParameter);
        }
    
        public virtual ObjectResult<SP_IdArchivoCotizacion_Result> SP_IdArchivoCotizacion(string nombre)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_IdArchivoCotizacion_Result>("SP_IdArchivoCotizacion", nombreParameter);
        }
    
        public virtual ObjectResult<SP_IdCotizacion_Result1> SP_IdCotizacion(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_IdCotizacion_Result1>("SP_IdCotizacion", idParameter);
        }
    
        public virtual int SP_CotizacionXProveedor(Nullable<int> cotizacion, Nullable<int> pr)
        {
            var cotizacionParameter = cotizacion.HasValue ?
                new ObjectParameter("cotizacion", cotizacion) :
                new ObjectParameter("cotizacion", typeof(int));
    
            var prParameter = pr.HasValue ?
                new ObjectParameter("pr", pr) :
                new ObjectParameter("pr", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CotizacionXProveedor", cotizacionParameter, prParameter);
        }
    
        public virtual ObjectResult<SP_SeleccionarCotizaciones_Result1> SP_SeleccionarCotizaciones()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SeleccionarCotizaciones_Result1>("SP_SeleccionarCotizaciones");
        }
    
        public virtual int SP_GuardarCotizacionRecibida(string nombre, byte[] archivo, Nullable<int> id)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var archivoParameter = archivo != null ?
                new ObjectParameter("archivo", archivo) :
                new ObjectParameter("archivo", typeof(byte[]));
    
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_GuardarCotizacionRecibida", nombreParameter, archivoParameter, idParameter);
        }
    
        public virtual ObjectResult<SP_SeleccionarProveedoresCotizaciones_Result7> SP_SeleccionarProveedoresCotizaciones(Nullable<int> cotizacion)
        {
            var cotizacionParameter = cotizacion.HasValue ?
                new ObjectParameter("cotizacion", cotizacion) :
                new ObjectParameter("cotizacion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SeleccionarProveedoresCotizaciones_Result7>("SP_SeleccionarProveedoresCotizaciones", cotizacionParameter);
        }
    
        public virtual ObjectResult<SP_SeleccionarCotizacion_Result> SP_SeleccionarCotizacion(Nullable<int> cotizacion)
        {
            var cotizacionParameter = cotizacion.HasValue ?
                new ObjectParameter("cotizacion", cotizacion) :
                new ObjectParameter("cotizacion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SeleccionarCotizacion_Result>("SP_SeleccionarCotizacion", cotizacionParameter);
        }
    }
}

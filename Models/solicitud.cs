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
    using System.Collections.Generic;
    
    public partial class solicitud
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public solicitud()
        {
            this.solicitud_cotizacion = new HashSet<solicitud_cotizacion>();
        }
    
        public int ID_solicitud { get; set; }
        public int id_usuario { get; set; }
        public int id_suministro { get; set; }
        public double cantidad { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public int id_estado { get; set; }
    
        public virtual estado_solicitud estado_solicitud { get; set; }
        public virtual suministros suministros { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<solicitud_cotizacion> solicitud_cotizacion { get; set; }
    }
}
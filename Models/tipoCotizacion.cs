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
    
    public partial class tipoCotizacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tipoCotizacion()
        {
            this.archivos_cotizaciones = new HashSet<archivos_cotizaciones>();
        }
    
        public int ID_tipoCotizacion { get; set; }
        public string tipoCotizacion1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<archivos_cotizaciones> archivos_cotizaciones { get; set; }
    }
}
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
    
    public partial class usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuarios()
        {
            this.cotizaciones = new HashSet<cotizaciones>();
        }
    
        public int ID_usuario { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int id_departamento { get; set; }
        public int id_rol { get; set; }
        public string estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cotizaciones> cotizaciones { get; set; }
        public virtual departamentos departamentos { get; set; }
        public virtual roles roles { get; set; }
    }
}

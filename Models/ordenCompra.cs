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
    
    public partial class ordenCompra
    {
        public int ID_orden_compra { get; set; }
        public int id_cotizacionRespuesta { get; set; }
        public int id_estado { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
    
        public virtual cotizacion_proveedor cotizacion_proveedor { get; set; }
        public virtual estado_ordenCompra estado_ordenCompra { get; set; }
    }
}
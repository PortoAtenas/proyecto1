//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyecto1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class detalleF
    {
        public int idDetalle { get; set; }
        public Nullable<decimal> precioU { get; set; }
        public Nullable<int> cantidad { get; set; }
        public Nullable<int> idPedido { get; set; }
    
        public virtual Pedido Pedido { get; set; }
    }
}

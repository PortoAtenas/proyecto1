using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace proyecto1.Models
{
    public class ProductoCLS
    {
        [Display(Name = "Id Producto")]
        public int iidProducto { get; set; }

        [Display(Name = "Nombre Producto")]
        public string nombreP { get; set; }

        [Display(Name = "Precio")]
        public double precio { get; set; }

        [Display(Name = "Coste")]
        public double coste { get; set; }


        [Display(Name ="Descripcion")]
        public string descripcion { get; set; }


        [Display(Name ="Cantidad Stock")]
        public int cantidad { get; set; } 


        [Display(Name ="Estado del producto")]
        public int iidState { get; set; }

    }
}
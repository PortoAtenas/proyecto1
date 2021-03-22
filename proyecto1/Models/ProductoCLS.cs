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

        [Required]
        [StringLength(50,ErrorMessage ="No se admiten mas de 50 caracteres")]
        [Display(Name = "Nombre Producto")]
        public string nombreP { get; set; }

        [Display(Name = "Precio")]
        public double precio { get; set; }

        [Display(Name = "Coste")]
        public double coste { get; set; }


        [Display(Name ="Descripcion")]
        [Required]
        [StringLength(50, ErrorMessage ="No se admiten mas de 50 caracteres")]
        public string descripcion { get; set; }


        [Display(Name ="Cantidad Stock")]
        public int cantidad { get; set; } 


        [Display(Name ="Estado del producto: 1.Activo 2.Inactivo 3.Eliminado")]
        public Nullable<int> iidState { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace proyecto1.Models
{
    public class ClienteCLS
    {
        
        [Display(Name="Cedula")]
        [Required]
        [StringLength(10, ErrorMessage ="No se admiten mas de 10 caracteres")]
        public string icedula { get; set; }


        [Display(Name ="Nombre Cliente")]
        [Required]
        [StringLength(50,ErrorMessage ="No se admiten mas de 50 caracteres")]
        public string inombreC { get; set; }


        [Display(Name ="Apellidos Cliente")]
        [Required]
        [StringLength(50,ErrorMessage ="No se admiten mas de 50 caracteres")]
        public string iapellidosC { get; set; }

       
        [Display(Name = "Direccion")]
        [Required]
        [StringLength(50,ErrorMessage ="No se admiten mas de 50 caracteres")]
        public string idireccion { get; set; }

        [Display(Name = "Celular")]
        [Required]
        [StringLength(10,ErrorMessage ="No se admiten mas de 10 caracteres")]
        public string icelular { get; set; }

        [Display(Name = "Telefono")]
        [Required]
        [StringLength(10,ErrorMessage ="No se admiten mas de 10 caracteres")]
        public string itelefono { get; set; }

    }
}
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
        public string icedula { get; set; }


        [Display(Name ="Nombre Cliente")]
        public string inombreC { get; set; }


        [Display(Name ="Apellidos Cliente")]
        public string iapellidosC { get; set; }


        [Display(Name = "Direccion")]
        public string idireccion { get; set; }

        [Display(Name = "Celular")]
        public string icelular { get; set; }

        [Display(Name = "Telefono")]
        public string itelefono { get; set; }

    }
}
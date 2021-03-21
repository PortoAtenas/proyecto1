using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace proyecto1.Models
{
    public class RolCLS
    {
        [Display(Name="Id Rol")]
        public int iidRol { get; set; }


        [Display(Name ="Nombre Rol")]
        public String nombreR { get; set; }
    }
}
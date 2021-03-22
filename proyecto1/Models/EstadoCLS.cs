using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace proyecto1.Models
{
    public class EstadoCLS
    {
        [Display(Name ="Id Estado de producto")]
        public int iidState { get; set; }

        [Display(Name ="Nombre del Estado")]
        [Required]
        [StringLength(15, ErrorMessage ="No se admiten mas de 15 caracteres")]
        public string nombreS { get; set; }


    }
}
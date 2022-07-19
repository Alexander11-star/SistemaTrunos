using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turnos2.Models
{
    public class Login
    {
        [Key]
        public int LoginID { get; set; }
        [Required (ErrorMessage ="Debe ingresar un usuario")]
        public string Usuario { get; set; }
        [Required (ErrorMessage ="Debe ingresar una constraseña")]
        public string Password { get; set; }
    }
}
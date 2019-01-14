using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoMVCEF.Models {
    public class Persona {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Apellido obligatorio")]
        public string Apellido { get; set; }

        [EmailAddress(ErrorMessage = "Dirección de mail incorrecta")]
        [Required]
        [Display(Description = "Correo electronico")]
        public String Email { get; set; }

        [DataType(DataType.Date)]
        public String FechaNacimiento { get; set; }

        [DataType(DataType.Password)]
        public String Password { get; set; }

        [Compare("Password", ErrorMessage = "Password deben ser igules")]
        [DataType(DataType.Password)]
        public String RepetirPass { get; set; }

    }
}
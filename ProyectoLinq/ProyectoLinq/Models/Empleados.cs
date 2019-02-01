using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoLinq.Models {
    public class Empleados {
        public int NumEmp { get; set; }
        public String Apellido { get; set; }
        public String Oficio { get; set; }
        public int Salario { get; set; }
    }
}
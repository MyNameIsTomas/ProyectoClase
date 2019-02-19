using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesSQL.Models {
    public class Doctor {
        public String NomHospital { get; set; }
        public String Apellido { get; set; }
        public String Especialidad { get; set; }
        public int Salario { get; set; }
        public int NumeroDoctor { get; set; }
    }
}

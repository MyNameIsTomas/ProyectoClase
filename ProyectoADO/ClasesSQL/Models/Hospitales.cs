using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesSQL.Models
{
    public class Hospitales {
        public int NumHospital { get; set; }
        public String Nombre { get; set; }
        public List<Doctor> Doctor { get; set; }
    }
}

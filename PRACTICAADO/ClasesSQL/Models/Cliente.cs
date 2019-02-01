using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesSQL.Models {
    public class Cliente {
        public String CodCliente { get; set; }
        public String NomEmpresa { get; set; }
        public String Contacto { get; set; }
        public String Cargo { get; set; }
        public String Ciudad {get; set;}
        public int Telefono { get; set; }
        public List<Pedidos> Pedidos { get; set; }
    }
}

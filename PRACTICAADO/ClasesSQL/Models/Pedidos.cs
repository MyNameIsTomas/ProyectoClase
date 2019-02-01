using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesSQL.Models
{
    public class Pedidos {
        public String CodPedido { get; set; }
        public String CodCliente { get; set; }
        public DateTime FechEntrega { get; set; }
        public String FormaEnvio { get; set; }
        public int Importe { get; set; }

    }
}

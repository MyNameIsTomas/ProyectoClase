using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase {
	public enum NomMeses {
		Enero = 0, Febrero, Marzo, Abril, Mayo, Junio,
		Julio, Agosto, Septiembre, Octubre, Noviembre
	}
	public class Mes {
		//No queremos controlar los valores de las propiedades, 
		//utilizamos propiedades autoimplementadas
		public String Nombre { get; set; }
		public int Maxima { get; set; }
		public int Minima { get; set; }
		//Necestiamos un metodo para calcular la media de cada mes
		public int GetMedia() {
			return (this.Maxima + this.Minima) / 2;
		}
		//Sobrescribo ToString() para representar los datos completos de un mes
		public override string ToString() {
			return this.Nombre + " - Max: " + this.Maxima + ", Min: " + this.Minima;
		}
	}
}


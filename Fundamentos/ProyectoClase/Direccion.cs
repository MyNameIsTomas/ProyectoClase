using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase {
	public class Direccion {
		//calle, Ciudad, Codigo Postal
		//No queremos comprobar nada, solamente crear propiedades
		//Propiedades autoimplementadas
		//Una autoimplementada no utiliza campo, nosotros no declaramos
		//un campo dentro del lenguaje se crea un campo (ni lo veo)
		public String Calle { get; set; }
		public String Ciudad { get; set; }
		public int CodigoPostal { get; set; }
		//Metodo que devuelva la descripción de la dirección
		public String GetDescripcion(){
			return this.Calle + ", " + this.Ciudad + ", " + this.CodigoPostal;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase
{
	public class Personaje {
		public String Nombre { get; set; }
		public String Apellidos { get; set; }
		public int Edad { get; set; }
		public byte[] imagen { get; set; }
		public override string ToString() {
			return this.Nombre + " " + this.Apellidos;
		}
	}
}

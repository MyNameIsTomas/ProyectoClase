using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase {
	public class Personajes: List<Personaje>{
		public int NumeroPersonajes {
			get { return this.Count; }
		}
	}
}

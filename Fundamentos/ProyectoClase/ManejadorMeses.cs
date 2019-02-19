using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase {
	public class ManejadorMeses {
		//Necestiamos manejar un conjunto de meses
		public List<Mes> Meses { get; set; }
		private Random rnd = new Random();
		//Creamos un constructor para instanciar la colección
		public ManejadorMeses() {
			this.Meses = new List<Mes>();
			this.rnd = new Random();
		}
		private String GetNombreMes(int posicion) {
			DateTime fecha = DateTime.Parse("01/" + posicion + "/2018");
			return fecha.ToString("MMMM"); ;
		}
		//Necesitamos un metodo para generar 12 meses
		public void GenerarMeses() {
			//Limpiamos la colección
			this.Meses.Clear();
			for (int i = 1; i <= 12; i++) {
				Mes month = new Mes();
				month.Nombre = this.GetNombreMes(i);
				month.Maxima = rnd.Next(10, 42);
				month.Minima = rnd.Next(-10, 9);
				this.Meses.Add(month);
			}
		}
	}
}

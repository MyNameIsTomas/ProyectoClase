using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase{
	public class Año:ManejadorMeses{
		//cada año debe tener 12 meses al ser construido
		//Tenemos que ver que sucede con mi clase Base (Los meses no son mios)
		//Los meses pueden venir cargados ya o no
		//Con más propiedades (implementado)
		public Año() {
			this.GenerarMeses();
			this.MaxAño = this.GetMaximoAño();
			this.MinAño = this.GetMinimaAño();
		}
		public List<Mes> Meses { get; set; }
		//Por cada año, deseamos generar los meses de forma dinamica
		private int GetMaximoAño() {
			int maxima = this.Meses[0].Maxima;
			foreach (Mes mes in this.Meses) {
				maxima = Math.Max(mes.Maxima, maxima);
			}
			return maxima;
		}
		private int GetMinimaAño(){
			int minima = this.Meses[0].Minima;
			foreach (Mes mes in this.Meses){
				minima = Math.Min(mes.Minima, minima);
			}
			return minima;
		}
		public int numAño { get; set; }
		public int MaxAño { get; set; }
		public int MinAño { get; set; }
		//Propiedades de solo lectura
		//Necestiamos un metodo para calcular la media de cada mes
		public int GetMediaAnual(){
			return (this.MaxAño + this.MinAño) / 2;
		}
	}
}

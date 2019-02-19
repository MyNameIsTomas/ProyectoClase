using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase {
	public class Ejecutivo: Empleado {
		#region Contructor
		public Ejecutivo() {
			Debug.WriteLine("Construcotr EJECUTIVO sin parametros");
			//Un ejecutivo cobra más que un empleado (200)
			this.salarioMinimo = 1000;
		}
		#endregion

		//Un ejecutivo queremos que tenga 26 días de vacaciones
		public override int GetDiasVacaciones() {
			//Tenemos que averiguar si se lee el metodo de la clase base
			Debug.WriteLine("GetVacaciones() EJECUTIVO");
			//Debemos llamar al metodo base de empleado
			int vacasempleado = this.GetDiasVacaciones();
			//Debemos sumar 4 a dichas vacaciones
			return vacasempleado + 4;
			
			//Primera opción
			//Sobrescribimos y no nos importa la implementación del metodo base
			//No nos importa el 22
			//return 26;
			//Segunda opción
			//Nos importa la implementación del metodo base, necesitamos
			//realizar una llamada a dicho metodo
		}

	}
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase
{
	//Indicamos que un empleado hereda de una persona
	public class Empleado: Persona
	{
		#region HERENCIA
		//Vamos a crear una propiedad para que un empleado tenga un salario minimo
		//Dicha propiedad solamente deben utilizarla los que hereden de empleado
		protected int salarioMinimo { get; set; }

		//Metodo publico para ver en el formulario el salario minimo
		public String GetSalarioMinimo() {
			return "Salario Mínimo: " + this.salarioMinimo;
		}
		#endregion

		#region CONSTRUCTORES

		//Creamos un constructor vacio para empleado
		public Empleado() : base() {
			Debug.WriteLine("Constructor EMPLEADO sin parametros");
			this.salarioMinimo = 800;
		}
		//Constructor en empleado con los mismos parametros que tiene persona
		//Y si la clase base no tiene constructor por defecto?
		//Si lo que deseamos es llamar a otro constructor de la clase base podemos hacerlo de forma explicita
		//Para hacer referencia en una clase derivada a la clase base --> base
		public Empleado(String apellidos, int edad) : base("", 0) {
			Debug.WriteLine("Constructor EMPLEADO con parametros");
			this.Apellidos = apellidos;
			this.Edad = edad;
		}

		#endregion

		//Sobrescribimos metodos
		public override string ToString(){
			return this.GetNombreCompleto();
		}
		//sobrecarga metodo
		public String ToString(int n) {
			return this.GetNombreCompleto() + " " + this.Nacionalidad;
		}
		//Con la palabra virtual indicamos que dejamos que un metodo
		//pueda ser sobrescrito en clases derivadas
		public virtual int GetDiasVacaciones() {
			//Tenemos que averiguar si se lle el metodo de clase base
			Debug.WriteLine("GetVacaciones() EMPLEADO");
			return 22;
		}

	}
}
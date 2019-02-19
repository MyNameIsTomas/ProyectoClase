using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase {
	//Aqui nunca escribimos nada
	//Dentro de un namespace se declaran las enumeraciones
	public enum Paises {
		España = 0, Alemania = 1, Holanda = 2, Francia = 3
	}
	public class Persona {
		//Nada que ver con POO
		//Herramienta del lenguaje para estructurar el codigo
		#region Propiedades


		#endregion
		#region Metodos


		#endregion
		//Sintaxis de propiedades
		//Propiedades extendidas porque tienen codigo de acceso para
		//realizar preguntas o acciones
		//Cuando hablamos de propiedades extendidas necestiamso un campo para 
		//manejar la propiedad Campo de Propiead(private)
		private String _Nombre;
		//Propiedad (public)
		public String Nombre {
			get {
				//Se ejecuta cuando alguien recupera un valor de la propiedad
				return this._Nombre;
			}
			set {
				//Se ejecuta cuando alguien cambia el valor de la propiedad
				//value Es una palabra clave donde viene el valor de la propiedad
				//Solo se utiliza en el set
				//Aquí cambiamos el valor del campo
				this._Nombre = value;
			}
		}
		//Creamos propiedad apellidos
		private String _Apellidos;
		public String Apellidos {
			get { return this._Apellidos; }
			set { this._Apellidos = value; }
		}
		//Creamos la propiedad Edad
		private int _Edad;
		public int Edad {
			get { return this._Edad; }
			set {
				//Tenemos dos posibilidades par aindicar que algo no es valido
				//En la utilización de nuestra clase
				if (value < 0) {
					//Este valor no es valido para nosotros
					//Error silencioso
					//Cambiamos el valor por alguno valido
					// this._Edad = 1;
					//Excepción real
					//Lanzar excepciones trow new Exception("Mensaje");
					throw new Exception("La edad no puede ser negativa");
				} else {
					this._Edad = value;
				}
			}
		}
		//Enumeraciones
		//Una enumeración es una herramienta del lenguaje donde nos permite
		//seleccionar entre varias posibilidades
		//Cada elemento de la enumeración contiene un numero interno
		//Esto es una ayuda para el programador que va a utilizar mi clase
		//Queremos que una persona pueda establecer su genero
		//Las enumeraciones (normalmente) se declaran en namespace
		public enum Genero {
			//Indicamos cada una de las posibilidades que deseamos
			//ofrecer al programador
			Masculino = 0, Femenino
		}
		//Lo que tenemos que hacer es declarar una propiedad con el tipo de enum
		private Genero _Sexo;
		public Genero Sexo {
			get { return this._Sexo;  }
			set {
				//Como las enumeraciones son numeros al final de todo debemos
				//comprobar los valores que nos estan enviando
				if (value == Genero.Femenino || value == Genero.Masculino) {
					this._Sexo = value;
				} else {
					throw new Exception("Valor no valido");
				}
			}
		}
		//Propiedad par ala nacionalidad
		private Paises _Nacionalidad;
		public Paises Nacionalidad {
			get { return this._Nacionalidad; }
			set { this._Nacionalidad = value; }
		}
		//Creamos propiedad autoimplementada
		public Direccion Domicilio { get; set; }
		//Propiedad Extendida
		private Direccion _DomicilioVacaciones;
		public Direccion DomicilioVacaciones {
			get { return this._DomicilioVacaciones;  }
			set { this._DomicilioVacaciones = value; }
		}
		//Propiedades indizadas
		//Una propiedad indizada no tiene nombre, se accede directamente
		//desde el objeto []. Este tipo de propiedades suelen ser Arrays
		//o colecciones. Permiten tener multiples valores por un indice
		//String texto = "NET";
		//texto[0];
		//texto.chars[0]
		//List<int> coleccion;
		//coleccion[0]
		//coleccion.Get(0)
		//Solamente tendremos una por objeto
		//Una persona puede tener varias descripciones, 5 como maximo
		//Necesitamos una variable para manejar los objetos por su indice (Array, List<>)
		private String[] _Descripciones = new string[5];
		public String this[int indice] {
			get { return this._Descripciones[indice]; }
			set { this._Descripciones[indice] = value; }
		}

		//Metodo para devolver el nombre completo
		public String GetNombreCompleto(){
			return this.Nombre + " " + this.Apellidos;
		}
		public String GetNombreCompleto(String titulo) {
			//Podemos llamat al metodo que deseemos
			return titulo + this.GetNombreCompleto();
		}

		public void GetNombreCompleto(int n1, int n2) {	}
		//La sobrecarga de un metodo para sobrecargar un metodo debemos
		//mantener la misma firma (Nombre del método) pero distinta forma(Parámetros)
		//Queremos un metodo que devuelva el nombre completo, pero apellido - nombre
		public String GetNombreCompletoReves(){
			return this.Apellidos + " " + this.Nombre;
		}
		public void ConvertirMayusculas() {
			this.Nombre = this.Nombre.ToUpper();
			this.Nombre = this.Apellidos.ToUpper();
		}
		//Un constructor es un metodo
		//Es el primer metodo en el momento de instanciar un objeto
		//En este metodo se decide como queremos un objeto inicialmene
		//Tenemos sobrecarga 
		//Un constructor no tiene constructor. Utiliza el constructor
		//por defecto de la clase Base
		public Persona(int n, int n1, int n2) { }
		private void IniciarObjeto()
		{
			//Este método se ejecuta cuando se instancia el objeto (new)
			//Sirve para iniciar todos los elementos de la clase
			//Cualquier persona se llamara Ana
			this.Nombre = "Ana";
			this.Nacionalidad = Paises.Francia;
			this.Sexo = Genero.Masculino;
		}
		public Persona() {
			//Este metodo se ejecuta cuando se instancia el objeto (new)
			//Sirve para iniciar todos los elementos de la calse
			Debug.WriteLine("Consturctor PERSONA sin parámetros");
			this.IniciarObjeto();
		}
		//Un constructor puede tener sobrecarga
		//Podemos utilizar el constructor para obligar a crear el objeto
		//de una forma 
		public Persona(String apellidos, int edad) {
			Debug.WriteLine("Consturctor PERSONA sin parámetros");
			this.IniciarObjeto();
			this.Apellidos = apellidos;
			this.Edad = edad;
		}
	}
}

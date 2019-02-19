using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Framework
using ProyectoClase; //Nuestro
namespace Fundamentos {
	public partial class Form31PruebaClase : Form {
		public Form31PruebaClase() {
			InitializeComponent();
		}
		private void btnCrear_Click(object sender, EventArgs e) {
			//Namespace acceso a un conjunto de clases
			//Instanciamos un nuevo objeto Persona
			Persona person = new Persona();
			Persona person2 = new Persona("Canales", 24);
			this.listPerona.Items.Add(person.GetNombreCompleto() + person.Nacionalidad);
			person.Nombre = "Lucas";
			person.Apellidos = "Perez Robles";
			this.listPerona.Items.Add(person.Nombre);
			this.listPerona.Items.Add(person.Apellidos);
			//Para nosotros, un numero negativo no es una edad validad
			//Debemos dar un toque a quien utiliza la clase

			try {
				//Codigo a ejecutar
				person.Edad = 14;
			} catch (Exception ex) {
				//Codigo en caso de excepción
				MessageBox.Show("Error: " + ex.Message);
			}
			//Documentación leo
			//Masculino = 0
			//Femenino = 1
			//Leer documentación Buff
			person.Sexo = Persona.Genero.Femenino;
			//person.Sexo = (Persona.Genero)14;
			person.Nacionalidad = Paises.Alemania;
			this.btnCrear.TextAlign = ContentAlignment.BottomCenter;
			this.listPerona.Items.Add("Edad: " + person.Edad);
			this.listPerona.Items.Add("Sexo: " + person.Sexo);
			this.listPerona.Items.Add("Nacionalidad: " + person.Nacionalidad);
			//person.DomicilioVacaciones.Calle = "Calle Pez";
			//Button boton = new Button();
			//boton.Text = "Nuevo";
			//boton.Site.Width = 200;

			//Primero creamos el objeto
			person.DomicilioVacaciones = new Direccion();
			//Asignamos sus propiedades
			person.DomicilioVacaciones.Calle = "Paseo del mar";
			person.DomicilioVacaciones.Ciudad = "Cadiz";
			//Tenemos dmás posibilidades en el mommento de crear objetos
			//Inicializar las propieades d eun bojeto en su construcción
			//new Objeto{ Prop = valor, Prop = Valor }
			person.Domicilio = new Direccion { Calle = "Calle Pez, 14", Ciudad = "Madrid", CodigoPostal = 28560 };
			this.listPerona.Items.Add("Calle: " + person.DomicilioVacaciones.GetDescripcion());
			this.listPerona.Items.Add("Calle: " + person.Domicilio.GetDescripcion());
			person[0] = "Rubio";
			person[1] = "Pelo largo";
			this.listPerona.Items.Add("Descripcion[0]: " + person[0]);
			this.listPerona.Items.Add(person.GetNombreCompleto());
			person.ConvertirMayusculas();
			this.listPerona.Items.Add(person.GetNombreCompleto());
		}

		private void btnEmpleado_Click(object sender, EventArgs e) {
			Empleado emp = new Empleado();
			this.listPerona.Items.Add(emp.GetNombreCompleto());
			this.listPerona.Items.Add(emp.Nacionalidad);
			Empleado emp2 = new Empleado("Sanchez", 22);
			this.listPerona.Items.Add(emp.GetNombreCompleto());
			this.listPerona.Items.Add(emp.Nacionalidad);
			this.listPerona.Items.Add(emp.ToString());
			this.listPerona.Items.Add("Vacaciones: " + emp.GetDiasVacaciones());
		}

		private void btnCrearEjecutivo_Click(object sender, EventArgs e)
		{
			this.listPerona.Items.Clear();
			Ejecutivo ej = new Ejecutivo();
			this.listPerona.Items.Add(ej.GetNombreCompleto());
			this.listPerona.Items.Add(ej.Nacionalidad);
			this.listPerona.Items.Add(ej.GetSalarioMinimo());
			this.listPerona.Items.Add("Vacaciones: " + ej.GetDiasVacaciones());
		}
	}
}

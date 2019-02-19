using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ProyectoClase;
using System.IO;

namespace Fundamentos {
	public partial class Form38Serialize : Form {
		//Vamos a utilizar un objeto serializador en los metodos (Guardar y leer)
		//Por eso lo declaramos a nivel de clase
		//En la instancia del objeto, debemos indicar al serializador que clase vamos a utilizar
		XmlSerializer serializer;
		String ruta = "persona.txt";
		public Form38Serialize() {
			InitializeComponent();
			//Aquí instanciamos el objeto indicando la clase a utilizar
			this.serializer = new XmlSerializer(typeof(Personaje));
		}
		private void btnGuardar_Click(object sender, EventArgs e) {
			//Para almacenar los objetos el xmlSerializer utiliza las clases 
			StreamWriter writer = new StreamWriter(ruta);
			//Creamos la persona para serializar
			Personaje person = new Personaje();
			person.Nombre = this.txtNombre.Text;
			person.Apellidos = this.txtApellidos.Text;
			person.Edad = int.Parse(this.txtEdad.Text);
			//Utilizamos el objeto serial indicinado el archivo donde escribimos
			//(writer) y el objeto a escribit (Personaje)
			this.serializer.Serialize(writer, person);
			writer.Flush();
			writer.Close();
			this.lblMensaje.Text = "Fichero guardado";
			this.txtApellidos.Text = "";
			this.txtNombre.Text = "";
			this.txtEdad.Text = "";
		}

		private void btnLeer_Click(object sender, EventArgs e) {
			StreamReader reader = new StreamReader(ruta);
			//Aquí no instanciamos una persona, recuperamos la persona con su forma,
			//desde el fichero deserialización
			Personaje person = (Personaje) this.serializer.Deserialize(reader);
			reader.Close();
			this.lblMensaje.Text = "Fichero leido";
			this.txtNombre.Text = person.Nombre;
			this.txtApellidos.Text = person.Apellidos;
			this.txtEdad.Text = person.Edad.ToString();
		}

	}
}

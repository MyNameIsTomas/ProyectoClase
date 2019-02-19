using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProyectoClase;
using System.Xml.Serialization;

namespace Fundamentos {
	public partial class Form39SerializacionPersonaje : Form {
		XmlSerializer serializer;
		String path;
		Personajes personajes;
		ClaseImagen ima;
		public Form39SerializacionPersonaje() {
			InitializeComponent();
			this.serializer = new XmlSerializer(typeof(Personajes));
			this.personajes = new Personajes();
			ima = new ClaseImagen();
			this.path = "personajes.txt";
		}
		private void btnInsertar_Click(object sender, EventArgs e) {
			Personaje person = new Personaje();
			person.Nombre = this.txtNombre.Text;
			person.Apellidos = this.txtApellidos.Text;
			person.Edad = int.Parse(this.txtEdad.Text);
			DialogResult resp = this.openFileDialog1.ShowDialog();
			if (resp == DialogResult.OK){
				//Almacenar imagen
				String path = this.openFileDialog1.FileName;
				person.imagen = File.ReadAllBytes(path);
				//Cargar y mostrar imagen
				//var ms = new MemoryStream(ima.MiImagen);
				//this.pictBoxImagen.Image = Image.FromStream(ms);
			}

			this.personajes.Add(person);
			PintarPersonajes();
		}
		private void PintarPersonajes() {
			this.listPersonas.Items.Clear();
			foreach (Personaje p in this.personajes) {
				this.listPersonas.Items.Add(p.ToString());
			}
		}
		private void btnGuardar_Click(object sender, EventArgs e) {
			StreamWriter writer = new StreamWriter(this.path);
			this.serializer.Serialize(writer, this.personajes);
			writer.Flush();
			writer.Close();
			this.lblMensaje.Text = "Fichero guardado";
		}

		private void btnLeer_Click(object sender, EventArgs e) {
			this.personajes.Clear();
			StreamReader reader = new StreamReader(this.path);
			this.personajes = (Personajes)this.serializer.Deserialize(reader);
			reader.Close();
			this.PintarPersonajes();
			this.lblMensaje.Text = "Colección guardada";
		}

		private void btnLimpiarColeccion_Click(object sender, EventArgs e) {
			this.personajes.Clear();
			this.listPersonas.Items.Clear();

		}

		private void btnEliminar_Click(object sender, EventArgs e) {
			int indice = this.listPersonas.SelectedIndex;
			this.personajes.RemoveAt(indice);
			this.PintarPersonajes();
		}

		private void btnModificar_Click(object sender, EventArgs e) {
			int indice = this.listPersonas.SelectedIndex;
			Personaje person = this.personajes[indice];
			person.Nombre = this.txtNombre.Text;
			person.Apellidos = this.txtApellidos.Text;
			person.Edad = int.Parse(this.txtEdad.Text);
			this.PintarPersonajes();
		}

		private void listPersonas_SelectedIndexChanged(object sender, EventArgs e) {
			int indice = this.listPersonas.SelectedIndex;
			Personaje person = this.personajes[indice];

			var ms = new MemoryStream(person.imagen);
			this.pictBoxImagen.Image = Image.FromStream(ms);
		}
	}
}

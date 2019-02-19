using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClase;
using System.IO;

namespace Fundamentos {
	public partial class Form37AlmacenarTexto : Form {
		List<Persona> personas;
		public Form37AlmacenarTexto() {
			InitializeComponent();
			this.personas = new List<Persona>();
		}
		private void btnInsertar_Click(object sender, EventArgs e) {
			String nom = this.txtNombre.Text;
			String ape = this.txtApellidos.Text;
			int edad = int.Parse(this.txtEdad.Text);
			Persona p = new Persona();
			p.Nombre = nom;
			p.Apellidos = ape;
			p.Edad = edad;
			this.personas.Add(p);
			this.listPersonas.Items.Add(p.Nombre);
		}
		private void GuardarPersonas(String path) {
			String datos = "";
			foreach (Persona per in personas) {
				//Separamos sus propiedades con /
				String textoproducto = per.Nombre + "/" + per.Apellidos + "/" + per.Edad;
				//Cada producto lo separamos con -
				datos += textoproducto + "-";
			}
			//Quitamos - del final
			datos = datos.TrimEnd('-');
			//Con los datos a almacenar creamos el fichero y lo escribimos
			FileInfo fic = new FileInfo(path);
			TextWriter writer = fic.CreateText();
			writer.Write(datos);
			writer.Flush();
			writer.Close();
		}
		private void RecuperarPersonas(String path) {
			//Necesitamos leer todo el contenido del archivo  pasar a objeto producto y a colección
			this.listPersonas.Items.Clear();
			this.personas.Clear();
			FileInfo fic = new FileInfo(path);
			TextReader reader = fic.OpenText();
			String contenido = reader.ReadToEnd();
			reader.Close();
			//Paco/Muñoz/27, 3-Manolo/Perez/40
			//Separamos los elementos por personas (-)
			String[] strproductos = contenido.Split('-');
			foreach (String p in strproductos) {
				//Separamos las propiedades (/)
				String[] propiedades = p.Split('/');
				//Alberto/Serrano/57
				//Instanciamos un producto
				Persona per = new Persona();
				per.Nombre = propiedades[0];
				per.Apellidos = propiedades[1];
				per.Edad = int.Parse(propiedades[2]);
				//Añadimos el producot a nuestra colección
				this.personas.Add(per);
			}
		}
		private void PintarPersonas(){
			this.listPersonas.Items.Clear();
			foreach (Persona per in this.personas){
				this.listPersonas.Items.Add(per.Nombre);
			}
		}
		private void btnGuardar_Click(object sender, EventArgs e) {
			this.saveFileDialog1.Filter = "Personas(*.pro)|*.pro";
			DialogResult respuesta = this.saveFileDialog1.ShowDialog();
			if (respuesta == DialogResult.OK) {
				String path = this.saveFileDialog1.FileName;
				this.GuardarPersonas(path);
			}
		}
		private void listPersonas_SelectedIndexChanged(object sender, EventArgs e){
			if (this.listPersonas.SelectedIndex != -1) {
				Persona per = this.personas[this.listPersonas.SelectedIndex];
				this.txtNombre.Text = per.Nombre;
				this.txtApellidos.Text = per.Apellidos;
				this.txtEdad.Text = per.Edad.ToString();
			}
		}

		private void btnLeer_Click(object sender, EventArgs e) {
			this.openFileDialog1.Filter = "Personas(*.pro)|*.pro";
			DialogResult resp = this.openFileDialog1.ShowDialog();
			if (resp == DialogResult.OK) {
				String path = this.openFileDialog1.FileName;
				this.RecuperarPersonas(path);
				this.PintarPersonas();
			}
		}
	}
}

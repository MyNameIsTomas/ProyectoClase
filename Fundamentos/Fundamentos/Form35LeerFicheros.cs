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

namespace Fundamentos {
	public partial class Form35LeerFicheros : Form {
		public Form35LeerFicheros() {
			InitializeComponent();
		}

		private void buttonLeer_Click(object sender, EventArgs e){
			//Pero primero, necesitamos que vamos a leer
			//Necestiamos un lector
			DialogResult respuesta = this.openFileDialog1.ShowDialog();
			if (respuesta == DialogResult.OK) {
				//Capturamos la ruta del fichero seleccionado
				String path = this.openFileDialog1.FileName;
				//this.labelAccion.Text = path;
				//Necesitamos un lector
				FileInfo fileinfo = new FileInfo(path);
				//Aquí estamos creando el lector
				String contenido = "";
				using (TextReader reader = fileinfo.OpenText()) {
					//Lo que hacemos es leer un contenido 
					contenido = reader.ReadToEnd();
					//Una vez que finalizamos de leer cerramos el lector
					reader.Close();
				}
				this.txtcontenido.Text = contenido;
				this.labelAccion.Text = "Archivo cargado";
			}
		}

		private void buttonGuardar_Click(object sender, EventArgs e) {
			//Descripción, filtro
			DialogResult respuesta = this.saveFileDialog1.ShowDialog();
			if (respuesta == DialogResult.OK) {
				String path = this.saveFileDialog1.FileName;
				FileInfo fileinfo = new FileInfo(path);
				TextWriter writer = fileinfo.CreateText();
				String contenido = this.txtcontenido.Text;
				//Podemos indicar que escriba de forma asincrona en determinadas
				//clases, existen los metodos Async()
				writer.WriteAsync(contenido);
				//Cuando escribimos en ficheros debemos liberar la memoria para
				//indicar al sistema que hemos finalizado
				writer.Flush();
				//Cerramos el fichero
				writer.Close();
				this.txtcontenido.Text = "";
				this.labelAccion.Text = "Fichero almacenado";
			}
		}
	}
}
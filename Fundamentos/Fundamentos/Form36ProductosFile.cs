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
	public partial class Form36ProductosFile : Form {
		List<Producto> productos;
		public Form36ProductosFile() {
			InitializeComponent();
			this.productos = new List<Producto>();
		}
		private void buttonNuevoPro_Click(object sender, EventArgs e) {
			String nom = this.textNombreProducto.Text;
			double prec = double.Parse(this.textPrecio.Text);
			Producto p = new Producto();
			p.Nombre = nom;
			p.Precio = prec;
			this.productos.Add(p);
			this.listProductos.Items.Add(p.Nombre);
		}
		private void GuardarProductos(String path) {
			String datos = "";
			foreach (Producto prod in productos) {
				//Separamos sus propiedades con @
				String textoproducto = prod.Nombre + "@" + prod.Precio;
				//Cada producto lo separamos con &
				datos += textoproducto + "&";
			}
			//Quitamos & del final
			datos = datos.TrimEnd('&');
			//Con los datos a almacenar creamos el fichero y lo escribimos
			FileInfo fic = new FileInfo(path);
			TextWriter writer = fic.CreateText();
			writer.Write(datos);
			writer.Flush();
			writer.Close();
		}
		private void RecuperarProductos(String path){
			//Necesitamos leer todo el contenido del archivo  pasar a objeto producto y a colección
			this.listProductos.Items.Clear();
			this.productos.Clear();
			FileInfo fic = new FileInfo(path);
			TextReader reader = fic.OpenText();
			String contenido = reader.ReadToEnd();
			reader.Close();
			//Leche@1, 5&Cacao@40
			//Separamos los elementos por productos (&)
			String[] strproductos = contenido.Split('&');
			foreach (String p in strproductos) {
				//Separamos las propiedades (@)
				String[] propiedades = p.Split('@');
				//Leche@1,5
				//Instanciamos un producto
				Producto prod = new Producto();
				prod.Nombre = propiedades[0];
				prod.Precio = double.Parse(propiedades[1]);
				//Añadimos el producot a nuestra colección
				this.productos.Add(prod);
			}
		}
		private void PintarProductos() {
			this.listProductos.Items.Clear();
			foreach (Producto prod in this.productos) {
				this.listProductos.Items.Add(prod.Nombre);
			}
		}
		private void buttonCargarPro_Click(object sender, EventArgs e) {
			this.openFileDialog1.Filter = "Producots(*.prod)|*.pro";
			DialogResult resp = this.openFileDialog1.ShowDialog();
			if (resp == DialogResult.OK) {
				String path = this.saveFileDialog1.FileName;
				this.RecuperarProductos(path);
				this.PintarProductos();
			}
		}
		private void buttonGuardarList_Click(object sender, EventArgs e) {
			this.saveFileDialog1.Filter = "Producto(*.pro)|*.pro";
			DialogResult respuesta = this.saveFileDialog1.ShowDialog();
			if (respuesta == DialogResult.OK) {
				String path = this.saveFileDialog1.FileName;
				this.GuardarProductos(path);
			}
		}
		private void listProductos_SelectedIndexChanged(object sender, EventArgs e) {
			if (this.listProductos.SelectedIndex != -1){
				Producto prod = this.productos[this.listProductos.SelectedIndex];
				this.textNombreProducto.Text = prod.Nombre;
				this.textPrecio.Text = prod.Precio.ToString();
			}
		}

		private void buttonCargarPro_Click_1(object sender, EventArgs e)
		{

		}
	}
}
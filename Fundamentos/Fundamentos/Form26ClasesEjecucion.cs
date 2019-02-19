using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos {
	public partial class Form26ClasesEjecucion : Form {
		public Form26ClasesEjecucion(){
			InitializeComponent();
		}

		private void btnCrear_Click(object sender, EventArgs e){
			//Necesitamos nuestro formulario modal Form25NumeroBotones
			Form27NumeroBotones f = new Form27NumeroBotones();
			DialogResult respuesta = f.ShowDialog();
			int numero = 5;
			if (respuesta == DialogResult.OK) {
				//En este cuadro de dialogo nos devuelve .NumeroBotones
				numero = f.NumeroBotones;
			}

			int posy = 10;
			for (int i = 1; i <= numero; i++){
				Button boton = new Button();
				boton.Text = i.ToString();
				boton.AutoSize = true;
				boton.Location = new Point(50, posy);
				posy += 30;
				boton.BackColor = Color.Yellow;
				boton.Click += Boton_Click;
				this.panel1.Controls.Add(boton);
			}
		}

		private void Boton_Click(object sender, EventArgs e){
			Button boton = (Button)sender;
			boton.BackColor = Color.Purple;
		}

		private void btnCambiarColor_Click(object sender, EventArgs e){
			//Vamos a utilizar un cuadro de dialogo. Un cuadro de dialogo es
			//un formulario modal que devuelve una respuesta
			/*
			DialogResult respuesta = MessageBox.Show("¿Desea continuar?", 
				"Question", 
				MessageBoxButtons.OKCancel);
			if (respuesta == DialogResult.OK) {

			}
			*/
			//Al igual que tenemos dialogos que son mensajes (alert), también
			//tenemos para abrir ficheros, colores, por ejemplo .ShowDialog() --> Mostrar
			//el cuadro .Propiedad Devolución
			ColorDialog cld = new ColorDialog();
			DialogResult resp = cld.ShowDialog();
			if (resp == DialogResult.OK) {
				//Aquí tenemos el color .color
				foreach (Control c in this.panel1.Controls) {
					c.BackColor = cld.Color;
				}
			}
		}

		private void btnSeleccionarImagen_Click(object sender, EventArgs e) {
			OpenFileDialog ofd = new OpenFileDialog();
			DialogResult respuesta = ofd.ShowDialog();
			if (respuesta == DialogResult.OK) {
				// .FileName
				String archivo = ofd.FileName;
				//Para dibujar imagenes se utiliza un control llamado PictureBox
				PictureBox pct = new PictureBox();
				//Para cargar una imagen se utiliza la clase Image
				//Y un metodo ImageFromFile(Path)
				pct.Image = Image.FromFile(archivo);
				pct.Size = new Size(200, 200);
				//Indicamos que la imagen se adapte a las medidas del control
				pct.SizeMode = PictureBoxSizeMode.StretchImage;
				this.panel2.Controls.Add(pct);
			}
		}
	}
}

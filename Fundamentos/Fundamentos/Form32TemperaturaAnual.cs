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
using System.Globalization;

namespace Fundamentos {
	public partial class Form32TemperaturaAnual : Form {
		List<Mes> meses;
		public Form32TemperaturaAnual() {
			InitializeComponent();
			meses = new List<Mes>();
		}
		private void btnGenerar_Click_1(object sender, EventArgs e) {
			//Borramos los meses
			this.meses.Clear();
			this.listMeses.Items.Clear();
			Random rnd = new Random();
			//Necesitamos crear 12 meses
			DateTime fecha = DateTime.Parse("01/01/2018");
			//1 MES = 1 NEW
			//12 MES = 12 NEW
			for (int i = 1; i <= 12; i++) {
				//Instanciamos un mes
				Mes month = new Mes();
				//Asignamos sus propiedades
				month.Nombre = fecha.ToString("MMMM");
				fecha = fecha.AddMonths(1);
				month.Maxima = rnd.Next(10, 40);
				month.Minima = rnd.Next(-5, 9);
				//Almacenamos cada mes en la colección
				this.meses.Add(month);
				this.listMeses.Items.Add(month.Nombre);
			}
		}

		private void listMeses_SelectedIndexChanged_1(object sender, EventArgs e) {
			//Necestiamos un mes de la colección, lo vamos a recuperar por su indice
			int indice = this.listMeses.SelectedIndex;
			//Recuperamos el mes de la colección
			Mes month = this.meses[indice];
			this.txtMinima.Text = month.Minima.ToString();
			this.txtMaxima.Text = month.Maxima.ToString();
			this.txtMedia.Text = month.GetMedia().ToString();
			//this.tx.Text = month.Nombre;
		}
	}
}
	
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

namespace Fundamentos {
	public partial class Form33TemperaturaAnual : Form {
		ManejadorMeses tool;
		public Form33TemperaturaAnual() {
			InitializeComponent();
			this.tool = new ManejadorMeses();
		}
		private void btnGenerar_Click(object sender, EventArgs e) {
			this.listMeses.Items.Clear();
			//Cada vez que pulsemos generamos meses
			tool.GenerarMeses();
			//Dibujar en el entorno
			foreach (Mes mes in tool.Meses) {
				this.listMeses.Items.Add(mes.Nombre);
			}
		}

		private void listMeses_SelectedIndexChanged(object sender, EventArgs e){
			int indice = this.listMeses.SelectedIndex;
			//Recuperamos el mes con dicho indice
			Mes mes = this.tool.Meses[indice];
			this.txtMaxima.Text = mes.Maxima.ToString();
			this.txtMinima.Text = mes.Minima.ToString();
			this.txtMedia.Text = mes.GetMedia().ToString();
		}
	}
}

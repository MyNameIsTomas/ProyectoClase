using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClase;

namespace Fundamentos {
	public partial class Form34TemeraturasAnuales : Form{
		List<Año> coleccionaños;
		public Form34TemeraturasAnuales(){
			InitializeComponent();
			this.coleccionaños = new List<Año>();
		}

		private void btngenerar_Click(object sender, EventArgs e)
		{
			this.comboAños.Items.Clear();
			this.coleccionaños.Clear();
			int numaños = int.Parse(this.textNumAños.Text);
			int contador = 2018;
			for (int i = 1; i <= numaños; i++)
			{
				Año anyo = new Año();
				anyo.numAño = contador;
				contador += 1;
				//DIBUJAMOS CADA AÑO DENTRO DEL 
				//COMBOBOX
				this.comboAños.Items.Add(anyo.numAño);
				//AÑADIMOS A LA COLECCION DE AÑOS
				//CADA AÑO GENERADO
				this.coleccionaños.Add(anyo);
			}

		}

		private void cmbanyos_SelectedIndexChanged(object sender, EventArgs e)
		{
			int indiceaño = this.comboAños.SelectedIndex;
			this.listMeses.Items.Clear();
			//BUSCAMOS EL AÑO EN LA COLECCION
			Año anyo = this.coleccionaños[indiceaño];
			this.textMaxAnual.Text = anyo.MaxAño.ToString();
			this.textMinAnual.Text = anyo.MinAño.ToString();
			this.textMediaAnual.Text = anyo.GetMediaAnual().ToString();
			foreach (Mes mes in anyo.Meses)
			{
				this.listMeses.Items.Add(mes.ToString());
			}
		}

		private void lstmeses_SelectedIndexChanged(object sender, EventArgs e)
		{
			int indiceaño = this.comboAños.SelectedIndex;
			int indicemes = this.listMeses.SelectedIndex;
			Mes mes =
this.coleccionaños[indiceaño].Meses[indicemes];
			this.txtMaxima.Text = mes.Maxima.ToString();
			this.txtMinima.Text = mes.Minima.ToString();
			this.txtMedia.Text = mes.GetMedia().ToString();
			//this.txtnombre.Text = mes.Nombre;
		}
	}
}

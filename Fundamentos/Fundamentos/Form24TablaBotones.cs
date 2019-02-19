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
	public partial class Form24TablaBotones : Form {
		//Declaramos una colección
		List<TextBox> cajas;
		public Form24TablaBotones() {
			InitializeComponent();
			cajas = new List<TextBox>();
			foreach (Control c in this.Controls) {
				if (c is TextBox) {
					cajas.Add((TextBox)c);
				} else if (c is Button) {
					((Button)c).Click += multiplicarNumeros;
				}
			}
			cajas.Reverse();
			for (int i = 0; i < cajas.Count; i++) {
				cajas[i].Text = i.ToString();
			}
		}
		private void multiplicarNumeros(object sender, EventArgs e) {
			Button boton = (Button)sender;
			int valor = int.Parse(boton.Text);
				//Recorremos todas las cajas
				/*
			for (int i = 0; i < cajas.Count; i++){
				//Hacemos la multiplicación por la posición
				int multi = valor * (i + 1);
				//En cada caja dibujamos el resultado
				cajas[i].Text = multi.ToString();
			}*/
			foreach (TextBox txt in cajas){
				//Nos interesa la posición para el multiplo
				//Podemos buscar la posición del control dentro del conjunto
				int posicion = cajas.IndexOf(txt);
				txt.Text = ((posicion + 1) * valor).ToString();
			}
		}
	}
}

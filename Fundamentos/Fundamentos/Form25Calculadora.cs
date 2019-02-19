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
	public partial class Form25Calculadora : Form {
		int valor = 0;

		String operador = "";
		public Form25Calculadora() {
			InitializeComponent();
			foreach (Control boton in this.Controls) {
				if (boton is Button) {
					if (boton.Text == "=") {
						boton.Click += operar;
					}
					else {
						boton.Click += mostrar;
					}
				}
			}
		}
		private void operar(object sender, EventArgs e){
			int segundo = int.Parse(this.txtResultado.Text);
			String mostrar = "";
			switch (operador) {
				case "/":
					mostrar = (valor / segundo).ToString();
					break;
				case "*":
					mostrar = (valor * segundo).ToString();
					break;
				case "-":
					mostrar = (valor - segundo).ToString();
					break;
				case "+":
					mostrar = (valor + segundo).ToString();
					break;
			}
			this.txtResultado.Text = mostrar;
		}
		private void mostrar(object sender, EventArgs e){
			Button boton = (Button)sender;
			if (boton.Tag is null) {
				this.txtResultado.Text += boton.Text;
			}
			else{
				valor = int.Parse(this.txtResultado.Text);
				operador = boton.Text;
				this.txtResultado.Text = "";
			}
		}
	}
}

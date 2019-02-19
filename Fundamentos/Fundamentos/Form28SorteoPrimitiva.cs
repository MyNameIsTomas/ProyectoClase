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
	public partial class Form28SorteoPrimitiva : Form {
		int contColores = 0;
		public Form28SorteoPrimitiva() {
			InitializeComponent();
			foreach (Control c in this.groupSortero.Controls) {
				if (c is Button) {
					c.Click += marcarColor;
				}
			}
		}
		private void marcarColor(object sender, EventArgs e){
			Button boton = (Button)sender;
				if (boton.BackColor == Color.White) {
				if (contColores == 6) {
					MessageBox.Show("Disculpe, solo puede marcar 6 numeros");
				} else {
					boton.BackColor = Color.Yellow;
					contColores++;
					this.listNumerosPremiados.Items.Add(boton.Text);
				}
				} else {
					boton.BackColor = Color.White;
					contColores--;
				int ind = this.listNumerosPremiados.Items.IndexOf(boton.Text);
				this.listNumerosPremiados.Items.RemoveAt(ind);
			}
		}
		private void btnSortear_Click(object sender, EventArgs e) {
			int[] valores = new int[6];
			int numero = 0;
			Random ran = new Random();
			for (var i = 0; i < 6; i++) {
				numero = ran.Next(1, 21);
				if (valores.Contains(numero)){
					i--;
				}else {
					valores[i] = numero;
				}
			}

			foreach (Control c in this.groupSortero.Controls){
				if (c is Button){
					if (valores.Contains(int.Parse(c.Text))) {
						if (c.BackColor == Color.Yellow) {
							c.BackColor = Color.Green;
							numero = this.listNumerosPremiados.Items.IndexOf(c.Text);
							this.listNumerosPremiados.SetSelected(numero, true);
						}
						else {
							c.BackColor = Color.Red;
						}
					}
				}
			}
		}
	}
}

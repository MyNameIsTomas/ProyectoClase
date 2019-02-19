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
	public partial class Form29SortePrimitiva2 : Form {
		int numApuestas = 6, contColores = 0, numJuego = 20;
		public Form29SortePrimitiva2() {
			InitializeComponent();
		}
		private void btnIniciar_Click(object sender, EventArgs e) {
			//Necesitamos nuestro formulario modal
			Form30SortePrimitivaPregunta f = new Form30SortePrimitivaPregunta();
			DialogResult respuesta;
			numJuego = 20;
			do {
				respuesta = f.ShowDialog();
				numApuestas = f.NumeroApuesta;
				numJuego = f.NumeroJugar;
			} while (numJuego <= numApuestas);
			//} while (respuesta != DialogResult.OK && numJuego > numApuestas);
			int posx = 12, posy = 12;
			for (var i = 1; i < numJuego + 1; i++) {
				Button boton = new Button();
				boton.Text = i.ToString();
				boton.AutoSize = true;
				boton.Size = new Size(40, 40);
				boton.Location = new Point(posx, posy);
				boton.BackColor = Color.White;
				boton.Click += marcarColor;
				this.panelSorteo.Controls.Add(boton);
				posx += 46;

				if (i % 5 == 0) {
					posx = 12;
					posy += 46;
				}
			}
		}

		private void marcarColor(object sender, EventArgs e) {
			Button boton = (Button)sender;
			if (boton.BackColor == Color.White) {
				if (contColores == numApuestas) {
					MessageBox.Show("Disculpe, solo puede marcar "+ numApuestas + " numeros");
				} else {
					boton.BackColor = Color.Yellow;
					contColores++;
					this.listNumeros.Items.Add(boton.Text);
				}
			} else {
				boton.BackColor = Color.White;
				contColores--;
				int ind = this.listNumeros.Items.IndexOf(boton.Text);
				this.listNumeros.Items.RemoveAt(ind);
			}
		}

		private void btnSortear_Click(object sender, EventArgs e) {
			int[] valores = new int[numApuestas];
			int numero = 0;
			Random ran = new Random();
			for (var i = 0; i < numApuestas; i++) {
				numero = ran.Next(1, (numJuego + 1));
				if (valores.Contains(numero)) {
					i--;
				} else {
					valores[i] = numero;
				}
			}
			foreach (Control c in this.panelSorteo.Controls) {
				if (c is Button) {
					if (valores.Contains(int.Parse(c.Text))){
						if (c.BackColor == Color.Yellow) {
							c.BackColor = Color.Green;
							numero = this.listNumeros.Items.IndexOf(c.Text);
							this.listNumeros.SetSelected(numero, true);
						} else {
							c.BackColor = Color.Red;
						}
					}
				}
			}
		}
	}
}

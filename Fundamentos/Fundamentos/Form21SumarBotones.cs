using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
	public partial class Form21SumarBotones : Form
	{
		public Form21SumarBotones()
		{
			InitializeComponent();
			/*
			this.button1.Click += sumarNumeros;
			this.button2.Click += sumarNumeros;
			this.button3.Click += sumarNumeros;
			this.button4.Click += sumarNumeros;
			this.button5.Click += sumarNumeros;
			this.button6.Click += sumarNumeros;
			this.button7.Click += sumarNumeros;
			this.button8.Click += sumarNumeros;
			this.button9.Click += sumarNumeros;
			*/
			//Vamos a realizar la asociación del evento de forma dinamica en todos los botones
			foreach (Control c in this.Controls) {
				//Necesitamos recuperar solo los Button
				if (c is Button) {
					
					c.Click += sumarNumeros;
				}
			}
		}

		private void sumarNumeros(object sender, EventArgs e){
			Control boton = (Control)sender;
			int valor = int.Parse(boton.Text);
			int suma = int.Parse(this.lblSuma.Text);
			this.lblSuma.Text = (valor + suma).ToString();
		}
	}
}

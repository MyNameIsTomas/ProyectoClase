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
	public partial class Form22SumarCheckbox : Form
	{
		Random random = new Random();
		public Form22SumarCheckbox()
		{
			InitializeComponent();
			foreach (Control c in this.Controls)
			{
				//Necesitamos recuperar solo los CheckBox
				if (c is CheckBox){
					c.Text = generarRandom().ToString();
					((CheckBox)c).CheckedChanged += sumarNumeros;
				}
			}
		}
		public int generarRandom() {
			int numero = random.Next(1, 100);
			return numero;
		}
		private void sumarNumeros(object sender, EventArgs e)
		{
			CheckBox boton = (CheckBox)sender;
			int valor = int.Parse(boton.Text);
			int suma = int.Parse(this.lblRespuesta.Text);
			this.lblRespuesta.Text = (valor + suma).ToString();
			if (boton.Checked == true){
				this.lblRespuesta.Text = (valor + suma).ToString();
			}
			else {
				this.lblRespuesta.Text = (suma - valor).ToString();
			}
		}
	}
}

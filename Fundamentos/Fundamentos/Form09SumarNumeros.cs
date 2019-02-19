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
	public partial class Form09SumarNumeros : Form
	{
		public Form09SumarNumeros()
		{
			InitializeComponent();
		}
		private void btnsumar_Click(object sender, EventArgs e)
		{
			String texto = this.txtnumeros.Text;
			int suma = 0;
			//Recorremos todos los caracteres del texto
			for (int i = 0; i < texto.Length; i++) {
				//Capturamos cada caracter del texto
				char caracter = texto[i];
				//Convertimos cada caracter en numero
				int numero = int.Parse(caracter.ToString());
				suma += numero;
			}
			this.resultado.Text = suma.ToString();
		}
	}
}

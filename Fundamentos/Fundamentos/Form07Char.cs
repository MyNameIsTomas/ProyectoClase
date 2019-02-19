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
	public partial class Form07Char : Form
	{
		public Form07Char()
		{
			InitializeComponent();
		}

		private void codigo_Click(object sender, EventArgs e)
		{
			//Lo primero que debemos realizar es un bucle de 0 a 255
			//que son los caracteres del codigo ASCII
			for (int i = 0; i <= 255; i++) {
				//Tenemos i que es un int y debemos convertir a char
				char letra = (char)i;
				if (char.IsLetter(letra) == true) {
					this.txtletras.Text += letra;
				} else if (char.IsNumber(letra) == true) {
					this.txtnumeros.Text += letra;
				}
				else if (char.IsPunctuation(letra) == true)
				{
					this.txtpuntuacion.Text += letra;
				}
				else if (char.IsSymbol(letra) == true)
				{
					this.txtsimbolos.Text += letra;
				}
			}
		}
	}
}

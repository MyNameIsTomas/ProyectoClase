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
	public partial class Form20Formulario : Form
	{
		public Form20Formulario()
		{
			InitializeComponent();
			this.txtNombre.KeyPress += soloLetras;
			this.txtApellido.KeyPress += soloLetras;
			this.txtEdad.KeyPress += soloNumeros;
			this.txtCodigoPostal.KeyPress += soloNumeros;
		}
		private void soloLetras(object sender, KeyPressEventArgs e) {
			char teclaBack = (char)Keys.Back;
			if (char.IsLetter(e.KeyChar) == false && e.KeyChar != teclaBack) {
				e.Handled = true;
			}
		}
		private void soloNumeros(object sender, KeyPressEventArgs e)
		{
			char teclaBack = (char)Keys.Back;
			if (char.IsDigit(e.KeyChar) == false && e.KeyChar != teclaBack)
			{
				e.Handled = true;
			}
		}
	}
}

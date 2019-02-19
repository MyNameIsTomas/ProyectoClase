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
	public partial class Form11NumeroNarcisista : Form
	{
		public Form11NumeroNarcisista()
		{
			InitializeComponent();
		}
		private void comprobar_Click(object sender, EventArgs e)
		{
			String narci = this.txtnarcisista.Text;
			double suma = 0;
			for (var i = 0; i < narci.Length; i++) {
				int numero = Convert.ToInt32(narci[i].ToString());
				//int numero = int.Parse(narci[i].ToString());
				suma += Math.Pow(numero, narci.Length);
			}
			if (suma == double.Parse(narci)){
				this.resultado.Text = "El número es NARCISISTA";
			}else {
				this.resultado.Text = "El número no es NARCISISTA";
			}
		}
	}
}

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
	public partial class Form14DatosRandom : Form
	{
		public Form14DatosRandom()
		{
			InitializeComponent();
		}

		private void btngenerar_Click(object sender, EventArgs e)
		{
			Random rand = new Random();
			int elemento = 0;
			for (var i = 0; i < 10; i++) {
				elemento = rand.Next(1, 50);
				this.listDatos.Items.Add(elemento);
			}
		}
		private void btnVerDatos_Click(object sender, EventArgs e)
		{
			int suma = 0, pares = 0, impares = 0;
			foreach (int obj in this.listDatos.Items) {
				suma += obj;
				if ((obj % 2) == 0) {
					pares += obj;
				} else {
					impares += obj;
				}
			}
			this.txtSuma.Text = suma.ToString();
			this.txtPares.Text = pares.ToString();
			this.txtImpares.Text = impares.ToString();
		}
	}
}

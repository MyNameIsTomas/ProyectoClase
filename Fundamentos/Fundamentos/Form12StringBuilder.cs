using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
	public partial class Form12StringBuilder : Form
	{
		public Form12StringBuilder()
		{
			InitializeComponent();
		}

		private void btnstringbuilder_Click(object sender, EventArgs e)
		{
			//Creamos el bojeto StringBuilder
			StringBuilder texto = new StringBuilder();
			texto.Append(this.txttexto.Text);
			Stopwatch krono = new Stopwatch();
			krono.Start();
			for (var i = 0; i < texto.Length; i++) {
				//Recuperamos la ultima letra
				char letra = texto[texto.Length - 1];
				//Eliminamos la ultima letra
				texto = texto.Remove(texto.Length - 1, 1);
				//Insertamos la letra en la posición 1
				texto = texto.Insert(i , letra.ToString());
			}
			krono.Stop();
			this.resultado.Text = "Segundos: " + krono.Elapsed.Seconds +
				"\nMilisegundos: " + krono.Elapsed.Milliseconds;
			this.txttexto.Text = texto.ToString();
		}

		private void btninvertir_Click(object sender, EventArgs e)
		{
			String texto = this.txttexto.Text;
			//Queremos medir el tiempo en realizar el proceso de invertir
			Stopwatch krono = new Stopwatch();
			krono.Start();
			for (var i = 0; i < texto.Length; i++) {
				//Recuperamos la ultima letra del texto
				char letra = texto[texto.Length - 1];
				//Eliminamos la ultima letra
				texto = texto.Remove(texto.Length - 1);
				//Insertamos la letra en la posición del contador
				texto = texto.Insert(i, letra.ToString());
			}
			krono.Stop();
			this.resultado.Text = "Segundos: " + krono.Elapsed.Seconds +
				"\nMilisegundos: " + krono.Elapsed.Milliseconds;
			this.txttexto.Text = texto;
		}

		private void Form12StringBuilder_Load(object sender, EventArgs e)
		{
			InitializeComponent();
			//Existe una colección de elementos de la clase control que 
			//contiene todos los controles del formulario .Controls 
			//Queremos cambiar el color de cada control
			foreach (Control c in this.Controls) {
				c.BackColor = Color.Yellow;
			}
			//foreach (Form f in this.MdiChildren) {

			//}
		}
	}
}

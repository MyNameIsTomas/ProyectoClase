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
	public partial class Form06DateTime : Form
	{
		//Esto es un constructor, aqui dibujaremos los elementos iniciales de nuestra clase
		public Form06DateTime()
		{
			InitializeComponent();
			this.txtactual.Text = DateTime.Now.ToString();
		}
		private void incrementa_Click(object sender, EventArgs e)
		{
			//Recuperamos el incremento
			int incremento = int.Parse(this.txtincremento.Text);
			//Necesitamos la fecha de la caja para incrementar
			DateTime fecha = DateTime.Parse(this.txtactual.Text);
			if (this.dias.Checked == true){
				fecha = fecha.AddDays(incremento);
			}
			else if (this.meses.Checked == true){
				fecha = fecha.AddMonths(incremento);
			}
			else {
				fecha = fecha.AddYears(incremento);
			}
			this.fecharesultado.Text = fecha.ToString();
		}

		private void cambiarformato_CheckedChanged(object sender, EventArgs e)
		{
			//Vamos a convertir la fecha en formato largo o corto segun el checked
			//Necesitamos la fecha de la caja
			DateTime fecha = DateTime.Parse(this.txtactual.Text);
			if (this.cambiarformato.Checked == true)
			{
				this.txtactual.Text = fecha.ToLongDateString();
			}
			else {
				this.txtactual.Text = fecha.ToShortDateString();
			}
		}

		private void diferencia_Click(object sender, EventArgs e)
		{
			DateTime fechaact = DateTime.Parse(this.txtactual.Text);
			DateTime fechanue = DateTime.Parse(this.fecharesultado.Text);
			TimeSpan diferencia = fechanue.Subtract(fechaact);
			this.txtdiasdiferencia.Text = diferencia.Days.ToString();
			this.txthorasdiferencia.Text = diferencia.Hours.ToString();
		}
	}
}

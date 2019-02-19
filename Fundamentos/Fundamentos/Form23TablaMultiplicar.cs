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
	public partial class Form23TablaMultiplicar : Form
	{
		//Declaramos una colección
		List<TextBox> cajas;
		public Form23TablaMultiplicar()
		{
			InitializeComponent();
			//Instanciamos la colección
			cajas = new List<TextBox>();
			//Recorremos todos los controles
			foreach (Control c in this.Controls){
			//foreach (Control c in this.groupBox1.Controls) { 
					//Preguntamos si son cajas
					if (c is TextBox){
					//Limitamos las cajas que no tengan Tag
					//if (!(c.Tag  is  null))
					if (c.Tag is null){
						//Añadimos a la colección
						cajas.Add((TextBox)c);
					}
				}
			}
			//Debemos invertir el orden de la colección porque los 
			//indices no estan como necesitamos 
			cajas.Reverse();
			//Recorremos la colección de cajas pra visualizar su posición
			for (int i = 0; i < cajas.Count; i++){
				cajas[i].Text = i.ToString();
			}
		}

		private void btnMostrar_Click(object sender, EventArgs e){
			//Capturamos el numero de la caja
			int numero = int.Parse(this.txtNumero.Text);
			//Recorremos todas las cajas
			for (int i = 0; i < cajas.Count; i++){
				//Hacemos la multiplicación por la posición
				int multi = numero * (i + 1);
				//En cada caja dibujamos el resultado
				cajas[i].Text = multi.ToString();
			}
		}
	}
}

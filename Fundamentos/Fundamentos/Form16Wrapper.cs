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
	public partial class Form16Wrapper : Form
	{
		public Form16Wrapper()
		{
			InitializeComponent();
		}
		private void btnLlamar_Click(object sender, EventArgs e)
		{
			int respuesta = SumarNumeros(3, 5);
			this.lblrespuesta.Text = respuesta.ToString();
			int num = 5;
			DobleNumero(num);
			this.lblrespuesta.Text = num.ToString();
			DobleNumeroReferencia(ref num);
			this.lblrespuesta.Text = num.ToString();
			CambiarColorBoton(this.btnLlamar);
			CambiarColorBoton(this.button1);
		}

		//METODO PARA CAMBIAR DE COLOR CUALQUIER BOTON
		public void CambiarColorBoton(Button boton)
		{
			boton.BackColor = Color.Yellow;
		}

		//METODO PARA ENVIAR UNA REFERENCIA
		//EN UN WRAPPER
		public void DobleNumeroReferencia
			(ref int numero)
		{
			numero = numero * 2;
		}

		//METODO PARA SACAR EL DOBLE DE UN NUMERO
		public void DobleNumero(int numero)
		{
			numero = numero * 2;
		}

		//METODO SUMAR NUMEROS
		public int SumarNumeros(int n1, int n2)
		{
			int suma = n1 + n2;
			return suma;
		}

	}
}


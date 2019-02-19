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
	public partial class Form19MetodosDelegados : Form
	{
		public Form19MetodosDelegados()
		{
			InitializeComponent();
			//AQUI ASOCIAMOS EL EVENTO A UN CONTROL
			//QUEREMOS QUE UN BOTON LEA EL METODO
			//MostrarMensaje()
			this.button1.Click += MostrarMensaje;
			//PODEMOS ASOCIAR TODAS LAS VECES QUE
			//DESEEMOS EL MISMO CONTROL
			this.button1.Click += MostrarMensaje;
			//CUALQUIER CONTROL Y EN CUALQUIER ACCION
			this.button2.MouseEnter += MostrarMensaje;
			//LA CAJA LEERA MENSAJE AL HACER CLICK
			this.textBox1.Click += MostrarMensaje;
		}

		private void Button1_Click
			(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Quitar asociaciones
			this.button1.Click -= MostrarMensaje;
		}

		public void MostrarMensaje
			(object sender, EventArgs e)
		{
			//sender Identifica el objeto que ha realizado la llamada
			//Queremos cambiar el color al boton pulsado
			//sender Viene como object y debemos hacer Casting a su clase (Button)
			Control boton = (Control)sender;
			boton.BackColor = Color.Yellow;
			MessageBox.Show("Botón pulsado " + sender);
		}
	}
}

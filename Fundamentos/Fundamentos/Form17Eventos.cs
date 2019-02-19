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
	public partial class Form17Eventos : Form
	{
		public Form17Eventos()
		{
			InitializeComponent();
		}

		private void lblRaton_MouseMove(object sender, MouseEventArgs e)
		{
			this.lblRaton.Text = "X: " + e.X + ", Y: " + e.Y;
		}

		private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
		{
			//Si ademas queremos permitir borrar, necesitamos el codigo ASCII del Back
			//Tenemos uan enumeración que indica lso codiso d elas teclas Key char <=8
			char letraBack = (char) Keys.Back;
			if (char.IsDigit(e.KeyChar) == false && e.KeyChar != letraBack) {
				e.Handled = true; 
			}
		}

		private void txtLetras_KeyPress(object sender, KeyPressEventArgs e)
		{
			char letraBack = (char)Keys.Back;
			if (char.IsLetter(e.KeyChar) == false && e.KeyChar != letraBack)
			{
				e.Handled = true;
			}
		}
	}
}

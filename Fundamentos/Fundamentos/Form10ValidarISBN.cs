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
	public partial class Form10ValidarISBN : Form
	{
		public Form10ValidarISBN()
		{
			InitializeComponent();
		}
		private void comprobar_Click(object sender, EventArgs e)
		{
			String isbn = this.txtisbn.Text;
			int suma = 0;
			if (isbn.Length == 10) {
				for (var i = 0; i < isbn.Length; i++) {
					int numero = Convert.ToInt32(isbn[i]);
					//int numero = int.Parse(isbn[i].ToString());
					
					suma += numero * (i + 1);
				}

				if (suma % 11 == 0){
					this.resultado.Text = "Este ISBN es bueno";
				}else {
					this.resultado.Text = "Este ISBN no es valido";
					this.txtisbn.Focus();
				}

			}else {
				this.resultado.Text = "Has de introducir un ISBN con 10 numeros";
			}
		}
	}
}

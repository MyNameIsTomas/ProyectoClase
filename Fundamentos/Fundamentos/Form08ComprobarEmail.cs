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
	public partial class Form08ComprobarEmail : Form
	{
		public Form08ComprobarEmail()
		{
			InitializeComponent();
		}

		private void comprobar_Click(object sender, EventArgs e)
		{
			string correo = this.txtemail.Text;
			if (correo.IndexOf('@') == -1 || correo.IndexOf('@') != correo.LastIndexOf('@')) {
				this.resultado.Text = "El caracter @ no esta introducido correctamente";
			}
			else if (correo.LastIndexOf(".") < correo.IndexOf("@"))
			{
				this.resultado.Text = "Debe existir un punto después de @";
			}else{
				//Posición del ultimo punto
				int ultimopunto = correo.LastIndexOf(".");
				//Recuperamos la cadena desde el ultimo punto en adelante para el dominio
				var dominio = correo.Substring(ultimopunto + 1);
				if (dominio.Length >= 2 && dominio.Length <= 4){
					this.resultado.Text = "Email CORRECTO!!!";
				}else{
					this.resultado.Text = "El dominio debe ser de 2 a 4.";
				}
			}
		}
	}
}

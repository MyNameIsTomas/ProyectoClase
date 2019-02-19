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
	public partial class Form02SumarNumeros : Form
	{
		public Form02SumarNumeros()
		{
			InitializeComponent();
		}

		private void btnSumar_Click(object sender, EventArgs e)
		{
			if (this.txtnumero1.Text == "" || this.txtnumero2.Text == "")
			{
				//Mostramos un alert, la clase MessageBox tiene un metodo con 25 sobrecargas para mostrar mensajes show()
				MessageBox.Show("Debes rellenar los datos", "Error de datos", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
			}
			else
			{
				//Debemos declarar dos variables int
				int num1, num2, suma;
				//this Representa el objeto donde estamos trabajando
				//Queremos guardar el texto de las cajas en sus variables
				//Debemos utilizar un .parse(String)
				num1 = int.Parse(this.txtnumero1.Text);
				num2 = int.Parse(this.txtnumero2.Text);
				suma = num1 + num2;
				//Realizamos la suma
				this.lblresultado.Text = suma.ToString();
				this.lblresultado.Font = new Font("Verdana", 25);
			}
		}
	}
}

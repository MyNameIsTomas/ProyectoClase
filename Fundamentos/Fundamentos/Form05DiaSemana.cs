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
	public partial class Form05DiaSemana : Form
	{
		public Form05DiaSemana()
		{
			InitializeComponent();
		}

		private void comprobar_Click(object sender, EventArgs e)
		{
			int di, me, an;
			string mostrar;
			di = int.Parse(this.dia.Text);
			me = int.Parse(this.mes.Text);
			an = int.Parse(this.ano.Text);
			if (me == 1){
				me = 13;
				an = an - 1;
			}else if (me == 2){
				me = 14;
				an--;
			}
			//Realizamos las operaciones para el calculo
			int op1 = ((me + 1) * 3) / 5;
			int op2 = an / 4;
			int op3 = an / 100;
			int op4 = an / 400;
			int op5 = di + (me * 2) + an + op1 + op2 - op3 + op4 + 2;
			int op6 = op5 / 7;
			int result = op5 - (op6 * 7);

			switch (result)
			{
				case 0:		mostrar = "SABADO";		break;
				case 1:		mostrar = "DOMINGO";	break;
				case 2:		mostrar = "LUNES";		break;
				case 3:		mostrar = "MARTES";		break;
				case 4:		mostrar = "MIERCOLES";	break;
				case 5: 	mostrar = "JUEVES";		break;
				case 6:		mostrar = "VIERNES";	break;
				default:	mostrar = "Error de datos: " + result;	break;
			}
			this.resultado.Text = mostrar;
		}
	}
}

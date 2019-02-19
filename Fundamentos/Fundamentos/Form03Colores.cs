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
	public partial class Form03Colores : Form
	{
		public Form03Colores()
		{
			InitializeComponent();
		}

		private void cambiar_Click(object sender, EventArgs e)
		{
			int r, g, b;
			if (this.txt1.Text == "" || this.txt2.Text == "" || this.txt3.Text == "")
			{
				MessageBox.Show("Debes introducir los valores correctamente",
										"Error de datos",
										MessageBoxButtons.AbortRetryIgnore,
										MessageBoxIcon.Stop);
			}
			else
			{
				r = int.Parse(this.txt1.Text);
				g = int.Parse(this.txt2.Text);
				b = int.Parse(this.txt3.Text);
				if (r < 0 || r > 255 || g < 0 || g > 255 || b < 0 || b > 255)
				{
					MessageBox.Show("Esos valores no son correctos",
						"Error de datos",
						MessageBoxButtons.AbortRetryIgnore,
						MessageBoxIcon.Stop);
				}
				else
				{
					this.txt1.BackColor = Color.Red;
					this.txt2.BackColor = Color.Green;
					this.txt3.BackColor = Color.Blue;
					this.BackColor = Color.FromArgb(r, g, b);
				}
			}
		}
	}
}

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
	public partial class OrdenarNumeros : Form
	{
		public OrdenarNumeros()
		{
			InitializeComponent();
		}
		private void comprobar_Click(object sender, EventArgs e)
		{
			int[] orden = new int[3];
			orden[2] = int.Parse(this.num1.Text);
			orden[1] = int.Parse(this.num2.Text);
			orden[0] = int.Parse(this.num3.Text);
			orden = orden.OrderBy(i => i).ToArray();
			this.mayor.Text = orden[0].ToString();
			this.intermedio.Text = orden[1].ToString();
			this.menor.Text = orden[2].ToString();
		}
	}
}

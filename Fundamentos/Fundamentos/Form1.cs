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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			cajatexto.Text = "Nuevo texto";
			cajatexto.Size = new Size(500, 250);
			cajatexto.BackColor = Color.Beige;
			cajatexto.TextAlign = HorizontalAlignment.Center;
			cajatexto.Paste("Hola");
		}
	}
}

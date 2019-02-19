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
	public partial class Form13ColeccionListBox : Form
	{
		public Form13ColeccionListBox()
		{
			InitializeComponent();
		}

		private void btnnuevoelm_Click(object sender, EventArgs e)
		{
			String elemento = this.txtelementos.Text;
			//Añadimos el elemento a la lista
			this.listBoxelementos.Items.Add(elemento);
		}

		private void btnborrarelm_Click(object sender, EventArgs e)
		{
			//La forma más eficiente normalmente es trabajar con indices en posiciones
			//de colecciones/arrays
			//Recuperamos el indice del elemenot seleccionado
			int indice = this.listBoxelementos.SelectedIndex;
			//Eliminamos el elementos de la colección por su indice
			this.listBoxelementos.Items.RemoveAt(indice);
		}

		private void btnlimpiarlis_Click(object sender, EventArgs e)
		{
			this.listBoxelementos.Items.Clear();
		}

		private void btnmostrar_Click(object sender, EventArgs e)
		{
			//Lo  primero que tenemos que averiguar es el tipo de objeto a recorrer
			//coleccion[0], esto nos dirá el tipo a recorrer
			foreach (String obj in this.listBoxelementos.Items) {
				this.lbltodos.Text += obj + ", ";
			}
		}

		private void btnmostrarsel_Click(object sender, EventArgs e)
		{
			foreach (String obj in this.listBoxelementos.SelectedItems) {
				this.lblseleccionados.Text += obj + ", ";
			}
		}

		private void btnborrarsel_Click(object sender, EventArgs e)
		{
			for (int i = this.listBoxelementos.SelectedIndices.Count -1; i >= 0; i--){
				int ind = this.listBoxelementos.SelectedIndices[i];
				this.listBoxelementos.Items.RemoveAt(ind);
			}
		}
	}
}

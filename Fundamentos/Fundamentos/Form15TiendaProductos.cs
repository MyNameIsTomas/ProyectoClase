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
	public partial class Form15TiendaProductos : Form
	{
		public Form15TiendaProductos()
		{
			InitializeComponent();
		}
		private void btnInsertar_Click(object sender, EventArgs e)
		{
			String valor = this.txtProducto.Text;
			int indice = 0;
			if (this.listTienda.Items.Contains(valor)) {
				indice = this.listTienda.Items.IndexOf(valor);
				this.listTienda.SelectedIndex = indice;
			} else {
				this.listTienda.Items.Add(valor);
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			int ind = 0;
			for (int i = this.listTienda.SelectedIndices.Count - 1; i >= 0; i--){
				ind = this.listTienda.SelectedIndices[i];
				this.listTienda.Items.RemoveAt(ind);
			}
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			String valor = this.txtProducto.Text;
			int index = this.listTienda.SelectedIndex;
			this.listTienda.Items[index] = valor;
		}

		private void btnLimiarLista_Click(object sender, EventArgs e)
		{
			this.listTienda.Items.Clear();
		}

		private void btnSeleccion_Click(object sender, EventArgs e)
		{
			foreach (String obj in this.listTienda.SelectedItems)
			{
				this.listAlmacen.Items.Add(obj);
			}
			for (int i = this.listTienda.SelectedIndices.Count - 1; i >= 0; i--)
			{
				int ind = this.listTienda.SelectedIndices[i];
				this.listTienda.Items.RemoveAt(ind);
			}
		}

		private void btnTodos_Click(object sender, EventArgs e)
		{
			/*
			foreach (String obj in this.listTienda.Items){
				this.listAlmacen.Items.Add(obj);
			}
			*/
			this.listAlmacen.Items.AddRange(this.listTienda.Items);
			this.listTienda.Items.Clear();
		}

		private void btnSubir_Click(object sender, EventArgs e)
		{
			String dato = this.listAlmacen.SelectedItem.ToString();
			int valor = this.listAlmacen.SelectedIndex;
			this.listAlmacen.Items.Remove(this.listAlmacen.SelectedItem);
			this.listAlmacen.Items.Insert(valor - 1, dato);
			this.listAlmacen.SelectedIndex = valor - 1;
		}
		private void btnBajar_Click(object sender, EventArgs e)
		{
			String dato = this.listAlmacen.SelectedItem.ToString();
			int valor = this.listAlmacen.SelectedIndex;
			this.listAlmacen.Items.Remove(this.listAlmacen.SelectedItem);
			this.listAlmacen.Items.Insert(valor + 1, dato);
			this.listAlmacen.SelectedIndex = valor + 1;
		}

		private void listAlmacen_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.listAlmacen.SelectedIndex == this.listAlmacen.Items.Count - 1)
			{
				this.btnBajar.Enabled = false;
			}else {
				this.btnBajar.Enabled = true;
			}
			if (this.listAlmacen.SelectedIndex == 0){
				this.btnSubir.Enabled = false;
			}else{
				this.btnSubir.Enabled = true;
			}
		}

		private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
		{
			char letraBack = (char)Keys.Enter;
			if (e.KeyChar == letraBack)
			{
				String valor = this.txtProducto.Text;
				this.listTienda.Items.Add(valor);
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoClase;

public partial class Practica : System.Web.UI.Page{
	ManejadorMeses tool;
	public Practica() {
		this.tool = new ManejadorMeses();
	}
	protected void Page_Load(object sender, EventArgs e) { }
	protected void Button1_Click(object sender, EventArgs e) {
		this.tool.GenerarMeses();
		//Pintamos
		this.ListBox1.Items.Clear();
		foreach (Mes mes in this.tool.Meses){
			this.ListBox1.Items.Add(mes.Nombre);
		}
	}

	protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e) {
		int indice = this.ListBox1.SelectedIndex;
		Mes mes = this.tool.Meses[indice];
		this.txtMaxima.Text = mes.Maxima.ToString();
		this.txtMedia.Text = mes.GetMedia().ToString();
		this.txtMinima.Text = mes.Minima.ToString();
	}
}
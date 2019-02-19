using ClasesSQL.Helpers;
using ClasesSQL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoADO.Conectado {
	public partial class Form09SQLClases : Form {
		HelperHospital helper;
		List<Doctores> hospitales;
		Doctores hos;
		int cont;
		public Form09SQLClases() {
			InitializeComponent();
			String cadenaconexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password='MCSD2018'";
			this.helper = new HelperHospital(cadenaconexion);
			this.hospitales = this.helper.GetNombreHospital();
			this.hos = new Doctores();
			this.cont = 0;
			foreach (Doctores h in hospitales) {
				this.listHospitales.Items.Add(h.Nombre);
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e) {
			int codigo = int.Parse(this.textCodHospital.Text);
			Doctores hosp = helper.BuscarHospital(codigo);
			if (hosp is null)
			{
				this.lblMensaje.Text = "No hay hospitales con el código";
			} else {
				this.textNombre.Text = hosp.Nombre;
				this.textDireccion.Text = hosp.Direccion;
				this.textTelefono.Text = hosp.Telefono;
			}
		}
		private void btnPrimero_Click(object sender, EventArgs e) {
			this.textNombre.Text = hospitales[cont].Nombre;
			this.textDireccion.Text = hospitales[cont].Direccion;
			this.textTelefono.Text = hospitales[cont].Telefono;
		}

		private void btnAnterior_Click(object sender, EventArgs e) {
			if (cont == 0) {
				cont = hospitales.Count;
			}
			cont--;
			this.textNombre.Text = hospitales[cont].Nombre;
			this.textDireccion.Text = hospitales[cont].Direccion;
			this.textTelefono.Text = hospitales[cont].Telefono;
		}

		private void btnSiguiente_Click(object sender, EventArgs e){
			cont++;
			if (cont == hospitales.Count) {
				cont = 0;
			}
			this.textNombre.Text = hospitales[cont].Nombre;
			this.textDireccion.Text = hospitales[cont].Direccion;
			this.textTelefono.Text = hospitales[cont].Telefono;
		}

		private void btnUltimo_Click(object sender, EventArgs e) {
			this.textNombre.Text = hospitales[hospitales.Count - 1].Nombre;
			this.textDireccion.Text = hospitales[hospitales.Count - 1].Direccion;
			this.textTelefono.Text = hospitales[hospitales.Count - 1].Telefono;
		}
	}
}

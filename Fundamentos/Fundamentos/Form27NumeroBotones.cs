using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos {
	public partial class Form27NumeroBotones : Form {
		public int NumeroBotones;
		public Form27NumeroBotones() {
			InitializeComponent();
		}

		private void btnAceptar_Click(object sender, EventArgs e) {
			this.NumeroBotones = int.Parse(this.txtRespuesta.Text);
			this.DialogResult = DialogResult.OK;
		}

		private void btnCancelar_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.Cancel;
		}
	}
}

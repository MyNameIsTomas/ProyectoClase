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
	public partial class Form30SortePrimitivaPregunta : Form {
		public int NumeroApuesta = 0, NumeroJugar = 0;
		public Form30SortePrimitivaPregunta() {
			InitializeComponent();
		}

		private void btnAceptar_Click(object sender, EventArgs e) {
			this.NumeroApuesta = int.Parse(this.txtApostar.Text);
			this.NumeroJugar = int.Parse(this.txtJugar.Text);
			this.DialogResult = DialogResult.OK;
		}

		private void btnCancelar_Click(object sender, EventArgs e){
			this.DialogResult = DialogResult.Cancel;
		}
	}
}

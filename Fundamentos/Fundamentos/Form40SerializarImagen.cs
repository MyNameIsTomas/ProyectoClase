using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClase;
using System.IO;
using System.Drawing.Imaging;

namespace Fundamentos {
	public partial class Form40SerializarImagen : Form {
		ClaseImagen ima;
		public Form40SerializarImagen() {
			InitializeComponent();
			ima = new ClaseImagen();
		}

		private void btnCarImagen_Click(object sender, EventArgs e) {
			DialogResult resp = this.openFileDialog1.ShowDialog();
			if (resp == DialogResult.OK) {

				String path = this.openFileDialog1.FileName;
				ima.MiImagen = File.ReadAllBytes(path);

				var ms = new MemoryStream(ima.MiImagen);
				this.pictBoxImagen.Image = Image.FromStream(ms); 
			}
		}
	}
}

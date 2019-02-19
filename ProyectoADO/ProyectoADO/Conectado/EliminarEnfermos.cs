using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoADO.Conectado {
	public partial class EliminarEnfermos : Form {
		String cadenaConexion;
		SqlConnection cn;
		SqlCommand com;
		SqlDataReader reader;
		public EliminarEnfermos() {
			InitializeComponent();
			this.cadenaConexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password='MCSD2018'";
			this.cn = new SqlConnection(this.cadenaConexion);
			this.com = new SqlCommand();
			//Nada más arrancar quiero pintar las inscripciones de los enfermos
			this.CargarEnfermos();
		}
		private void CargarEnfermos() {
			this.listIncripciones.Items.Clear();
			String sql = "SELECT INSCRIPCION FROM ENFERMO";
			//El procreso siempre sera configurar los objetos
			this.com.Connection = this.cn;
			//Tipo de consulta
			this.com.CommandType = CommandType.Text;
			//La propia consulta
			this.com.CommandText = sql;
			//entrar - salir
			this.cn.Open();
			//Ejecutamos comando
			this.reader = this.com.ExecuteReader();
			//Leemos registros
			while (this.reader.Read())
			{
				this.listIncripciones.Items.Add(this.reader["INSCRIPCION"]);
			}
			//Liberamos recursos
			this.reader.Close();
			this.cn.Close();
		}
		private void btnEliminarEnf_Click(object sender, EventArgs e) {
			String sql = "DELETE FROM ENFERMO WHERE INSCRIPCION = " + this.txtInscripcion.Text;
			//Configuramos el comando
			this.com.Connection = this.cn;
			this.com.CommandType = CommandType.Text;
			this.com.CommandText = sql;
			//Entrar - Salir
			this.cn.Open();
			int eliminados = this.com.ExecuteNonQuery();
			this.cn.Close();
			this.CargarEnfermos();
			//int indice = this.listIncripciones.SelectedIndex;
			//this.listIncripciones.Items.RemoveAt(indice);

			MessageBox.Show("Enfermos eliminados: " + eliminados);
		}

		private void listIncripciones_SelectedIndexChanged(object sender, EventArgs e) {
			if (this.listIncripciones.SelectedIndex != -1) {
				this.txtInscripcion.Text = this.listIncripciones.SelectedItem.ToString();
			}
		}
	}
}

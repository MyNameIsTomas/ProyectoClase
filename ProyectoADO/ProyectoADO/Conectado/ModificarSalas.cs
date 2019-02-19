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
	public partial class ModificarSalas : Form {
		String cadenaConexion;
		SqlConnection cn;
		SqlCommand com;
		SqlDataReader reader;
		public ModificarSalas() {
			InitializeComponent();
			this.cadenaConexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password='MCSD2018'";
			this.cn = new SqlConnection(this.cadenaConexion);
			this.com = new SqlCommand();
			this.CargarSalas();
		}
		private void CargarSalas() {
			this.listSalas.Items.Clear();
			String sql = "SELECT DISTINCT NOMBRE FROM SALA";
			//El proceso siemre sera configurar los objetos
			this.com.Connection = this.cn;
			//Tipo de consulta
			this.com.CommandType = CommandType.Text;
			//La propia consulta
			this.com.CommandText = sql;
			//Entrar - Salir
			this.cn.Open();
			//Ejecutamos comando
			this.reader = this.com.ExecuteReader();
			//Leemos registros
			while (this.reader.Read()) {
				this.listSalas.Items.Add(this.reader["NOMBRE"]);
			}
			//Liberamos recursos
			this.reader.Close();
			this.cn.Close();
		}
		private void buttonModificar_Click(object sender, EventArgs e) {
			String nomNuevo = this.textNuevoNombre.Text;
			String seleccionado = this.listSalas.SelectedItem.ToString();
			String sql = "UPDATE SALA SET NOMBRE = '"+nomNuevo+"' where NOMBRE like '" + seleccionado + "'";
			//Configuramos el comando
			this.com.Connection = this.cn;
			this.com.CommandType = CommandType.Text;
			this.com.CommandText = sql;
			//Entrar - Salir
			this.cn.Open();
			int modificados = this.com.ExecuteNonQuery();
			this.cn.Close();
			this.CargarSalas();
			MessageBox.Show("Salas modificadas: " + modificados);
		}
		private void listSalas_SelectedIndexChanged(object sender, EventArgs e) {
			if (this.listSalas.SelectedIndex != -1) {
				this.textNuevoNombre.Text = this.listSalas.SelectedItem.ToString();
			}
		}
	}
}

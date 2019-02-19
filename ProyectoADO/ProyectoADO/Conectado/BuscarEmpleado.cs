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
	public partial class BuscarEmpleado : Form {
		String cadenaConexion;
		SqlConnection cn;
		SqlCommand com;
		SqlDataReader reader;
		public BuscarEmpleado() {
			InitializeComponent();
			this.cadenaConexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password='MCSD2018'";
			this.cn = new SqlConnection(this.cadenaConexion);
			this.com = new SqlCommand();
			this.CargarEmpleados();
		}
		public void CargarEmpleados() {
			this.listBusqueda.Items.Clear();
			String sql = "SELECT APELLIDO, OFICIO FROM EMP";
			this.com.Connection = this.cn;
			this.com.CommandType = CommandType.Text;
			this.com.CommandText = sql;
			//Entrar -- Salir
			this.cn.Open();
			this.reader = this.com.ExecuteReader();
			while (this.reader.Read()) {
				this.listBusqueda.Items.Add(this.reader["APELLIDO"] + " - " + this.reader["OFICIO"]);
			}
			this.reader.Close();
			this.cn.Close();
		}

		private void buttonBuscar_Click(object sender, EventArgs e) {
			this.listBusqueda.Items.Clear();
			String busca = this.textBuscarApellido.Text;
			String sql = "select apellido, oficio from EMP where APELLIDO like '%" + busca + "%'";
			this.com.Connection = this.cn;
			this.com.CommandType = CommandType.Text;
			this.com.CommandText = sql;
			this.cn.Open();
			this.reader = this.com.ExecuteReader();
			while (this.reader.Read()){
				this.listBusqueda.Items.Add(this.reader["APELLIDO"] + " - " + this.reader["OFICIO"]);
			}
			this.reader.Close();
			this.cn.Close();
		}

		private void textBuscarApellido_TextChanged(object sender, EventArgs e) {
			this.listBusqueda.Items.Clear();
			String busca = this.textBuscarApellido.Text;
			String sql = "select apellido, oficio from EMP where APELLIDO like '%" + busca + "%'";
			this.com.Connection = this.cn;
			this.com.CommandType = CommandType.Text;
			this.com.CommandText = sql;
			this.cn.Open();
			this.reader = this.com.ExecuteReader();
			while (this.reader.Read())
			{
				this.listBusqueda.Items.Add(this.reader["APELLIDO"] + " - " + this.reader["OFICIO"]);
			}
			this.reader.Close();
			this.cn.Close();
		}
	}
}

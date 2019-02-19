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

#region Procedimientos almacenados
/*
Create procedure mostrarEnfermos
as
	select* from enfermo;
go

create procedure eliminarEnfermo(@inscipcion int)
as 
	delete from ENFERMO where INSCRIPCION = @inscipcion;
go
*/
#endregion
namespace ProyectoADO.Conectado {
	public partial class Form06Procedimientos : Form{
		String cadenaConexion;
		SqlConnection cn;
		SqlCommand com;
		SqlDataReader reader;
		List<int> inscripciones;
		public Form06Procedimientos() {
			InitializeComponent();
			this.cadenaConexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password='MCSD2018'";
			this.cn = new SqlConnection(this.cadenaConexion);
			this.com = new SqlCommand();
			this.inscripciones = new List<int>();
			this.CargarEnfermos();
		}
		private void CargarEnfermos() {
			this.inscripciones.Clear();
			this.listEnfermos.Items.Clear();
			String sql = "mostrarEnfermos";
			this.com.Connection = this.cn;
			this.com.CommandType = CommandType.StoredProcedure;
			this.com.CommandText = sql;
			this.cn.Open();
			this.reader = this.com.ExecuteReader();
			while (this.reader.Read()) {
				this.listEnfermos.Items.Add(this.reader["APELLIDO"]);
				int inscripcion = int.Parse(this.reader["INSCRIPCION"].ToString());
				this.inscripciones.Add(inscripcion);
			}
			this.reader.Close();
			this.cn.Close();
		}

		private void btnEliminarElemento_Click(object sender, EventArgs e) {
			//String inscripcion = this.textEnfermo.Text;
			int indice = this.listEnfermos.SelectedIndex;
			int inscripcion = this.inscripciones[indice];
			String sql = "eliminarEnfermo";
			SqlParameter paminsc = new SqlParameter("@inscipcion", inscripcion);
			this.com.Parameters.Add(paminsc);
			this.com.Connection = this.cn;
			this.com.CommandType = CommandType.StoredProcedure;
			this.com.CommandText = sql;
			this.cn.Open();
			int afectados = this.com.ExecuteNonQuery();
			this.com.Parameters.Clear();
			this.cn.Close();
			this.CargarEnfermos();

		}
	}
}

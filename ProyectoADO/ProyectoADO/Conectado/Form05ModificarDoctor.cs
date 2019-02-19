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
	public partial class Form05ModificarDoctor : Form {
		String cadenaConexion;
		SqlConnection cn;
		SqlCommand com;
		SqlDataReader reader;
		public Form05ModificarDoctor() {
			InitializeComponent();
			this.cadenaConexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password='MCSD2018'";
			this.cn = new SqlConnection(this.cadenaConexion);
			this.com = new SqlCommand();
			this.CargarDoctores();
		}
		public void CargarDoctores() {
			this.listDoctores.Items.Clear();
			String sql = "Select APELLIDO from DOCTOR";
			this.com.Connection = this.cn;
			this.com.CommandType = CommandType.Text;
			this.com.CommandText = sql;
			this.cn.Open();
			this.reader = this.com.ExecuteReader();
			while (this.reader.Read()) {
				this.listDoctores.Items.Add(this.reader["APELLIDO"].ToString());
			}
			this.reader.Close();
			this.cn.Close();
		}

		private void listDoctores_SelectedIndexChanged(object sender, EventArgs e) {
			if (this.listDoctores.SelectedIndex != -1) {
				String sql = "SELECT * FROM DOCTOR WHERE APELLIDO = @APELLIDO";
				String apellido = this.listDoctores.SelectedItem.ToString();
				//Creamos el objeto parameter
				SqlParameter pamape = new SqlParameter();
				//Nombre del parametro
				pamape.ParameterName = "@APELLIDO";
				//Valor del parametro
				pamape.Value = apellido;
				//Tipo de dato NET
				pamape.DbType = DbType.String;
				//Los parametros, por defecto, son in
				pamape.Direction = ParameterDirection.Input;
				//Añadimos el parametro a la colección del Command
				this.com.Parameters.Add(pamape);
				this.com.Connection = this.cn;
				this.com.CommandType = CommandType.Text;
				this.com.CommandText = sql;
				this.cn.Open();
				this.reader = this.com.ExecuteReader();
				//En teoria, solamente tenemos una fila
				//Leemos dicha fila
				this.reader.Read();
				this.textApellido.Text = this.reader["APELLIDO"].ToString();
				this.textEspecialidad.Text = this.reader["ESPECIALIDAD"].ToString();
				this.textSalario.Text = this.reader["SALARIO"].ToString();
				//Liberamos los recursos
				this.com.Parameters.Clear();
				this.reader.Close();
				this.cn.Close();
			}

		}

		private void btnModificar_Click(object sender, EventArgs e) {
			String sql = "UPDATE DOCTOR SET APELLIDO = @NEWAPE, ESPECIALIDAD = @ESPE, SALARIO = @SAL WHERE APELLIDO = @OLDAPE";
			String oldApe = this.listDoctores.SelectedItem.ToString();
			String newApe = this.textApellido.Text;
			String espe = this.textEspecialidad.Text;
			String sal = this.textSalario.Text;
			//Creamos los parametros, solamente con name y value
			SqlParameter pamold = new SqlParameter("@OLDAPE", oldApe);
			SqlParameter pamnew = new SqlParameter("@NEWAPE", newApe);
			SqlParameter pamespe = new SqlParameter("@ESPE", espe);
			SqlParameter pamsal = new SqlParameter("@SAL", sal);
			//Añadimos los parametros
			this.com.Parameters.Add(pamold);
			this.com.Parameters.Add(pamnew);
			this.com.Parameters.Add(pamespe);
			this.com.Parameters.Add(pamsal);
			this.com.Connection = this.cn;
			this.com.CommandType = CommandType.Text;
			this.com.CommandText = sql;
			this.cn.Open();
			int afectados = this.com.ExecuteNonQuery();
			this.com.Parameters.Clear();
			this.cn.Close();
			this.CargarDoctores();
			this.textApellido.Text = "";
			this.textEspecialidad.Text = "";
			this.textSalario.Text = "";

		}
	}
}

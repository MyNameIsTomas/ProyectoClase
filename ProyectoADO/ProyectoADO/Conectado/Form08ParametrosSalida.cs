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
	public partial class Form08ParametrosSalida : Form {
		String cadenaConexion;
		SqlConnection cn;
		SqlCommand com;
		SqlDataReader reader;
		List<int> hospitales;
		List<int> codigosEmpleados;

		public Form08ParametrosSalida() {
			InitializeComponent();
			this.cadenaConexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password='MCSD2018'";
			this.cn = new SqlConnection(this.cadenaConexion);
			this.com = new SqlCommand();
			this.hospitales = new List<int>();
			this.codigosEmpleados = new List<int>();
			this.cargarHospitales();
		}
		private void cargarHospitales()
		{
			this.comboHospital.Items.Clear();
			this.hospitales.Clear();
			String sql = "mostrarHospital";
			this.com.Connection = this.cn;
			this.com.CommandType = CommandType.StoredProcedure;
			this.com.CommandText = sql;
			this.cn.Open();
			this.reader = this.com.ExecuteReader();
			while (this.reader.Read())
			{
				int hospitalcod = int.Parse(this.reader["hospital_cod"].ToString());
				this.hospitales.Add(hospitalcod);
				this.comboHospital.Items.Add(this.reader["nombre"]);
			}
			this.reader.Close();
			this.cn.Close();
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			int indice = this.lstEmpleados.SelectedIndex;
			int codigo = this.codigosEmpleados[indice];
			String trabajo = this.textTrabajo.Text;
			int salario = int.Parse(this.textSalario.Text);
			SqlParameter pamcod = new SqlParameter("@codigo", codigo);
			SqlParameter pamsal = new SqlParameter("@salario", salario);
			SqlParameter pamtra = new SqlParameter("@trabajo", trabajo);
			this.com.Parameters.Add(pamcod);
			this.com.Parameters.Add(pamsal);
			this.com.Parameters.Add(pamtra);
			this.com.CommandType = CommandType.StoredProcedure;
			this.com.CommandText = "modificarEmpleadoHospital";
			this.cn.Open();
			this.com.ExecuteNonQuery();
			this.com.Parameters.Clear();
			this.cn.Close();
		}

		private void comboHospital_SelectedIndexChanged(object sender, EventArgs e)
		{
			int indice = this.comboHospital.SelectedIndex;
			if (indice != -1) {
				int hospitalcod = this.hospitales[indice];
				SqlParameter pamhosp = new SqlParameter("@HOSPITALCOD" , hospitalcod);
				this.com.Parameters.Add(pamhosp);
				//NECESITAMOS ENVIAR LOS PARAMETROS DE SALIDA PARA RECUPERAR SU VALOR
				SqlParameter pamperson = new SqlParameter();
				pamperson.ParameterName = "@PERSONAS";
				//INDICAMOS QUE ES UN PARAMETRO DE SALIDA
				pamperson.Direction = ParameterDirection.Output;
				//CUALQUIER PARAMETRO QUE ENVIAMOS A UN PROCEDIMIENTO SIEMPRE DEBE TENER UN VALOR
				pamperson.Value = 0;
				this.com.Parameters.Add(pamperson);
				SqlParameter pamsum = new SqlParameter();
				pamsum.ParameterName = "@SUMA";
				pamsum.Direction = ParameterDirection.Output;
				pamsum.Value = 0;
				this.com.Parameters.Add(pamsum);
				SqlParameter pammed = new SqlParameter();
				pammed.ParameterName = "@MEDIA";
				pammed.Direction = ParameterDirection.Output;
				pammed.Value = 0;
				this.com.Parameters.Add(pammed);
				this.com.CommandType = CommandType.StoredProcedure;
				this.com.CommandText = "MOSTRAREMPLEADOSHOSPITAL";
				this.cn.Open();
				this.reader = this.com.ExecuteReader();
				this.lstEmpleados.Items.Clear();
				this.codigosEmpleados.Clear();
				while (this.reader.Read()){
					int codigo = int.Parse(this.reader["CODIGO"].ToString());
					this.codigosEmpleados.Add(codigo);
					this.lstEmpleados.Items.Add(this.reader["APELLIDO"]);
				}
				this.reader.Close();
				//DESPUES DE CERRAR EL LECTOR DIBUJAMOS LOS PARAMETROS
				this.textPersona.Text = pamperson.Value.ToString();
				this.textSuma.Text = pamsum.Value.ToString();
				this.textMedia.Text = pammed.Value.ToString();
				this.com.Parameters.Clear();
				this.cn.Close();

			}
		}

		private void lstEmpleados_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			int indice = this.lstEmpleados.SelectedIndex;
			if (indice != -1) {
				Console.WriteLine("Hola");
				int codigo = this.codigosEmpleados[indice];
				SqlParameter pamcod = new SqlParameter("@codigo", codigo);
				this.com.Parameters.Add(pamcod);
				this.com.CommandType = CommandType.StoredProcedure;
				this.com.CommandText = "buscarEmpleadoHospital";
				this.cn.Open();
				this.reader = this.com.ExecuteReader();
				this.reader.Read();
				this.textSalario.Text = this.reader["salario"].ToString();
				this.textTrabajo.Text = this.reader["trabajo"].ToString();
				this.com.Parameters.Clear();
				this.reader.Close();
				this.cn.Close();
			}
		}
	}
}
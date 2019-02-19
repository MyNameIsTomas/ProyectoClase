using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClasesSQL.Models;

namespace ClasesSQL.Helpers
{
	public class HelperHospital {
		SqlConnection cn;
		SqlCommand com;
		SqlDataReader reader;

		//Configuración de acceso a BBDD
		public HelperHospital(String cadenaconexion) {
			this.cn = new SqlConnection(cadenaconexion);
			this.com = new SqlCommand();
			this.com.Connection = this.cn;
		}
		public Doctores BuscarHospital(int codigo) {
			String sql = "Select * from hospital where hospital_cod = @codigo";
			SqlParameter pamcod = new SqlParameter("@codigo", codigo);
			this.com.Parameters.Add(pamcod);
			this.com.CommandType = System.Data.CommandType.Text;
			this.com.CommandText = sql;
			this.cn.Open();
			this.reader = this.com.ExecuteReader();
			//Preguntamos si hay registros
			if (this.reader.HasRows == false) {
				this.reader.Close();
				this.com.Parameters.Clear();
				this.cn.Close();
				return null;
			}
			else {
				this.reader.Read();
				//Creamos nuestro modelo
				Doctores hosp = new Doctores();
				hosp.Nombre = this.reader["NOMBRE"].ToString();
				hosp.Direccion = this.reader["DIRECCION"].ToString();
				hosp.Telefono = this.reader["TELEFONO"].ToString();
				this.reader.Close();
				this.com.Parameters.Clear();
				this.cn.Close();
				return hosp;
			}

		}
		public List<Doctores> GetNombreHospital() {
			String sql = "Select * from HOSPITAL";
			this.com.CommandType = System.Data.CommandType.Text;
			this.com.CommandText = sql;
			this.cn.Open();
			this.reader = this.com.ExecuteReader();
			List<Doctores> hospitales = new List<Doctores>();
			while (this.reader.Read()){
				Doctores hospi = new Doctores();
				hospi.Nombre = reader["NOMBRE"].ToString();
				hospi.Telefono = reader["TELEFONO"].ToString();
				hospi.Direccion = reader["DIRECCION"].ToString();
				hospitales.Add(hospi);
			}
			this.reader.Close();
			this.cn.Close();
			return hospitales;
		}



	}
}

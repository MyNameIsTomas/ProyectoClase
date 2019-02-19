using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoADO.Conectado;
using System.Data.SqlClient;

namespace ProyectoADO.Conectado {
	public partial class d : Form {
		//Declaramos la cadena conexión
		String cadenaConexion;
		//Declaramos las variables de acceso a datos
		//Conexión
		SqlConnection cn;
		SqlCommand com;
		SqlDataReader reader;

		public d() {
			InitializeComponent();
			//En el constructor, creamos la cadena
			this.cadenaConexion = "Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password='MCSD2018'";
			//Debemos instanciar los objetos siempre en el constructor
			//La cadena de conexión se establece al instanciar un SqlConnection
			this.cn = new SqlConnection(this.cadenaConexion);
			this.com = new SqlCommand();
			//Creamos el evento StateChanged para visualizar el cambio de estado de la conexión
			this.cn.StateChange += Cn_StateChange;

		}

		private void btnConectar_Click(object sender, EventArgs e) {
			//Siempre que trabajemos con acceso a datos debemos incluir control de errores
			try {
				//Establecer la cadena de conexión
				//La cadena de conexión no se suele cambiar dinamicamente
				//this.cn.ConnectionString = this.cadenaConexion;
				//Comprobar el estado de la conexión con State
				if (this.cn.State == ConnectionState.Closed) {
					//Abrimos la conexión
					this.cn.Open();
				}
			} catch (SqlException ex) {
				MessageBox.Show("Error: " + ex.Message);
			}
		}
		private void Cn_StateChange(object sender, StateChangeEventArgs e) {
			//En este evento entra cada vez que cambiamos el estado de open a close y viceversa
			this.lblEstado.Text = "Conexión pasando de " + e.OriginalState + " a " + e.CurrentState;
		}
		private void btnDesconectar_Click(object sender, EventArgs e) {
			cn.Close();
		}
		private void btnLeerRegistros_Click(object sender, EventArgs e) {
			//Incicamos al comando conexión a utilizar
			this.com.Connection = this.cn;
			//Indicamos el tipo de consulta a realizar
			this.com.CommandType = CommandType.Text;
			//Creamos la consulta a realizar
			String sql = "Select * from EMP";
			//Indicamos al comando la consulta
			this.com.CommandText = sql;
			//Ejecutamos el comando
			//Al ser una consulta select, devuelve registros (Cursor)
			this.reader = this.com.ExecuteReader();
			//Pintamos la primera columna de la consulta
			//Pintamos todas las columnas 
			//Las columnas tienen un indice inicio (0) y un final que es FieldCount
			for(var i = 0; i<this.reader.FieldCount; i++){
				this.listComandos.Items.Add(this.reader.GetName(i));
			}
			//Para recuperar datos, necesitamos decirle que lea registros
			//las filas se leen con Read() que Bool debemos leer todos los registros con while
			while (this.reader.Read()) {
				String apellido = this.reader.GetString(1);
				this.listApellido.Items.Add(apellido);
				//Recuperamos el salario (Columna 5)
				String salario = this.reader["SALARIO"].ToString();
				this.listSalarios.Items.Add(salario);
			}
			//Siempre debemos liberar el el lector una vez finalizado
			this.reader.Close();
		}
	}
}

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
namespace ProyectoADO.Conectado{
	public partial class Form07MensajeServidor : Form {
		String cadenaConexion;
		SqlConnection cn;
		SqlCommand com;
		SqlDataReader reader;
		List<int> deptNum;
		public Form07MensajeServidor() {
			InitializeComponent();
			this.cadenaConexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password='MCSD2018'";
			this.cn = new SqlConnection(this.cadenaConexion);
			this.cn.InfoMessage += CapturarMensajesServidor;
			this.com = new SqlCommand();
			this.deptNum = new List<int>();
			this.cargarDepartamentos();
		}
		private void CapturarMensajesServidor(object sender, SqlInfoMessageEventArgs e) {
			this.lblMensajes.Text = e.Message;
		}
		private void cargarDepartamentos()
		{
			this.deptNum.Clear();
			this.listDepartamento.Items.Clear();
			String sql = "mostrarDepartamentos";
			this.com.Connection = this.cn;
			this.com.CommandType = CommandType.StoredProcedure;
			this.com.CommandText = sql;
			this.cn.Open();
			this.reader = this.com.ExecuteReader();
			while (this.reader.Read())
			{
				this.listDepartamento.Items.Add(this.reader["dept_no"] + " - " + this.reader["dnombre"] + " - " + this.reader["loc"]);
				int dept_no = int.Parse(this.reader["dept_no"].ToString());
				this.deptNum.Add(dept_no);
			}
			this.reader.Close();
			this.cn.Close();
		}

		private void btnInsertar_Click(object sender, EventArgs e)
		{
			this.lblMensajes.Text = "";
			int num = int.Parse(this.textNumero.Text);
			String nom = this.textNombre.Text;
			String loc = this.textLocalidad.Text;
			String sql = "insertarDept";
			SqlParameter pamnum = new SqlParameter("@num", num);
			SqlParameter pamnom = new SqlParameter("@nom", nom);
			SqlParameter pamloc = new SqlParameter("@loc", loc);
			this.com.Parameters.Add(pamnum);
			this.com.Parameters.Add(pamnom);
			this.com.Parameters.Add(pamloc);
			this.com.Connection = this.cn;
			this.com.CommandType = CommandType.StoredProcedure;
			this.com.CommandText = sql;
			this.cn.Open();
			int af = this.com.ExecuteNonQuery();
			this.lblRegistros.Text = af.ToString();
			//this.reader = this.com.ExecuteReader();
			this.com.Parameters.Clear();
			this.cn.Close();
			this.cargarDepartamentos();
			this.textNumero.Text = "";
			this.textNombre.Text = "";
			this.textLocalidad.Text = "";
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			int indice = this.listDepartamento.SelectedIndex;
			int num = this.deptNum[indice];
			String sql = "eliminarDept";
			SqlParameter pamnum = new SqlParameter("@num", num);
			this.com.Parameters.Add(pamnum);
			this.com.Connection = this.cn;
			this.com.CommandType = CommandType.StoredProcedure;
			this.com.CommandText = sql;
			this.cn.Open();
			int af = this.com.ExecuteNonQuery();
			this.lblRegistros.Text = af.ToString();
			MessageBox.Show("Los departamentos eliminados son " + af);
			this.com.Parameters.Clear();
			this.cn.Close();
			this.cargarDepartamentos();
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			int indice = this.listDepartamento.SelectedIndex;
			int num = this.deptNum[indice];
			String nom = this.textNombre.Text;
			String loc = this.textLocalidad.Text;
			String sql = "modificarDept";
			SqlParameter pamnum = new SqlParameter("@num", num);
			SqlParameter pamnom = new SqlParameter("@nom", nom);
			SqlParameter pamloc = new SqlParameter("@loc", loc);
			this.com.Parameters.Add(pamnum);
			this.com.Parameters.Add(pamnom);
			this.com.Parameters.Add(pamloc);
			this.com.Connection = this.cn;
			this.com.CommandType = CommandType.StoredProcedure;
			this.com.CommandText = sql;
			this.cn.Open();
			int afectados = this.com.ExecuteNonQuery();
			MessageBox.Show("Se han modificado " + afectados.ToString() + " departamentos.", "Información");
			this.com.Parameters.Clear();
			this.cn.Close();
			this.cargarDepartamentos();
			this.textNumero.Text = "";
			this.textNombre.Text = "";
			this.textLocalidad.Text = "";
		}

		private void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.listDepartamento.SelectedIndex != -1)
			{
				int indice = this.listDepartamento.SelectedIndex;
				int num = this.deptNum[indice];
				String sql = "buscarDept";
				SqlParameter pamnum = new SqlParameter("@num", num);
				this.com.Parameters.Add(pamnum);
				this.com.CommandType = CommandType.StoredProcedure;
				this.com.CommandText = sql;
				this.cn.Open();
				int af = this.com.ExecuteNonQuery();
				this.lblRegistros.Text = af.ToString();
				this.reader = this.com.ExecuteReader();
				this.reader.Read();
				this.textNumero.Text = this.reader["dept_no"].ToString();
				this.textNombre.Text = this.reader["dnombre"].ToString();
				this.textLocalidad.Text = this.reader["loc"].ToString();
				this.com.Parameters.Clear();
				this.reader.Close();
				this.cn.Close();
			}
		}
	}
}
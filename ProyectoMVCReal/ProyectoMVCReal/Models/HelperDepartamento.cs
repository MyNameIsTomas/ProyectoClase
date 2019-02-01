using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
//Espacio de nombre para la configuración (Web.Config)
using System.Configuration;

namespace ProyectoMVCReal.Models {
    public class HelperDepartamento {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public HelperDepartamento() {
            String cadena = ConfigurationManager.ConnectionStrings["cadenaHospital"].ConnectionString;
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }
        public Departamento BuscarDepartamento(int deptno) {
            String sql = "Select * from Dept where dept_no = @DEPTNO";
            SqlParameter pamdept = new SqlParameter("@DEPTNO", deptno);
            this.com.Parameters.Add(pamdept);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            Departamento dept = null;
            if (this.reader.HasRows) {
                this.reader.Read();
                dept = new Departamento();
                dept.Numero = int.Parse(this.reader["DEPT_NO"].ToString());
                dept.Nombre = this.reader["DNOMBRE"].ToString();
                dept.Localidad = this.reader["LOC"].ToString();
            }
            this.reader.Close();
            this.com.Parameters.Clear();
            this.cn.Close();
            return dept;
        }
        public List<Departamento> GetDepartamentos() {
            List<Departamento> lista = null;
            String sql = "Select * from dept";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            if (this.reader.HasRows) {
                lista = new List<Departamento>();
                while (this.reader.Read()){
                    Departamento dept = new Departamento();
                    dept.Numero = int.Parse(this.reader["DEPT_NO"].ToString());
                    dept.Nombre = this.reader["DNOMBRE"].ToString();
                    dept.Localidad = this.reader["LOC"].ToString();
                    lista.Add(dept);
                }
            }
            this.reader.Close();
            this.cn.Close();

            return lista;
        }
    }
}
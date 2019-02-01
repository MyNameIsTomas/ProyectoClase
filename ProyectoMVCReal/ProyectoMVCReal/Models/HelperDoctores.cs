using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
//Espacio de nombre para la configuración (Web.Config)
using System.Configuration;

namespace ProyectoMVCReal.Models {
    public class HelperDoctores {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public HelperDoctores() {
            String cadena = ConfigurationManager.ConnectionStrings["cadenaHospital"].ConnectionString;
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }
        public List<Doctores> GetDoctores() {
            List<Doctores> lista = null;
            String sql = "Select * from Doctor";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            if (this.reader.HasRows) {
                lista = new List<Doctores>();
                while (this.reader.Read()) {
                    Doctores doc = new Doctores();
                    doc.Apellido = this.reader["APELLIDO"].ToString();
                    doc.Especialidad = this.reader["ESPECIALIDAD"].ToString();
                    doc.Salario = int.Parse(this.reader["SALARIO"].ToString());
                    doc.CodDoc = int.Parse(this.reader["DOCTOR_NO"].ToString());
                    lista.Add(doc);
                }
            }
            this.reader.Close();
            this.cn.Close();
            return lista;
        }
        public Doctores BuscarDoctor(int codDoc) {
            String sql = "select * from DOCTOR where DOCTOR_NO = @CODDOC";
            SqlParameter pamcod = new SqlParameter("@CODDOC", codDoc);
            this.com.Parameters.Add(pamcod);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            Doctores doc = null;
            if (this.reader.HasRows) {
                this.reader.Read();
                doc = new Doctores();
                doc.Apellido = this.reader["APELLIDO"].ToString();
                doc.Especialidad = this.reader["ESPECIALIDAD"].ToString();
                doc.Salario = int.Parse(this.reader["SALARIO"].ToString());
            }
            this.reader.Close();
            this.com.Parameters.Clear();
            this.cn.Close();
            return doc;
        }
        public void EliminarDoctor(int codDoc) {
            String sql = "delete from DOCTOR where DOCTOR_NO = @CODDOC";
            SqlParameter pamcod = new SqlParameter("@CODDOC", codDoc);
            this.com.Parameters.Add(pamcod);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.com.Parameters.Clear();
            this.cn.Close();
        }
    }
}
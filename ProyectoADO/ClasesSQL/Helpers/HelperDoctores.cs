using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClasesSQL.Models;

namespace ClasesSQL.Helpers
{
    public class HelperDoctores
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public HelperDoctores(String cadenaConexion)
        {
            this.cn = new SqlConnection(cadenaConexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }
        public List<String> GetEspecialidades()
        {
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "MostrarEspecialidad";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<String> especialidades = new List<string>();
            while (this.reader.Read())
            {
                String esp = this.reader["ESPECIALIDAD"].ToString();
                especialidades.Add(esp);
            }
            this.reader.Close();
            this.cn.Close();
            return especialidades;
        }
        public List<String> GetHospitales()
        {
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "MostrarHospital";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<String> hospitales = new List<string>();
            while (this.reader.Read())
            {
                String nom = this.reader["NOMBRE"].ToString();
                hospitales.Add(nom);
            }
            this.reader.Close();
            this.cn.Close();
            return hospitales;
        }
        public Hospitales BuscarDoctores(String espe)
        {
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "BuscarDoctores";
            SqlParameter pamesp = new SqlParameter("@ESPE", espe);
            this.com.Parameters.Add(pamesp);
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            Hospitales hos = new Hospitales();
            if (this.reader.HasRows)
            {
                hos.Doctor = new List<Doctor>();
                while (this.reader.Read())
                {
                    Doctor doc = new Doctor();
                    doc.Apellido = this.reader["APELLIDO"].ToString();
                    doc.NumeroDoctor = int.Parse(this.reader["DOCTOR_NO"].ToString());
                    hos.Doctor.Add(doc);
                }
                this.reader.Close();
                this.com.Parameters.Clear();
                this.cn.Close();
                return hos;
            }
            else
            {
                this.cn.Close();
                this.com.Parameters.Clear();
                return null;
            }
        }
        public Doctor BuscarDoctor(int docno)
        {
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "BuscarDoctor";
            this.cn.Open();
            SqlParameter pamdocno = new SqlParameter("@numDoc", docno);
            this.com.Parameters.Add(pamdocno);
            this.reader = this.com.ExecuteReader();
            Doctor doc = new Doctor();
            this.reader.Read();
            doc.Apellido = this.reader["APELLIDO"].ToString();
            doc.NomHospital = this.reader["NOMBRE"].ToString();
            doc.Salario = int.Parse(this.reader["SALARIO"].ToString());
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return doc;
        }
        public void modificaDoctor(String nomHosp, int docno, int salario, String apellido, String especialidad)
        {
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "modificarDoctor";
            SqlParameter pamnomHosp = new SqlParameter("@hospnom", nomHosp);
            this.com.Parameters.Add(pamnomHosp);
            SqlParameter pamdocNo = new SqlParameter("@docno", docno);
            this.com.Parameters.Add(pamdocNo);
            SqlParameter pamSal = new SqlParameter("@salario", salario);
            this.com.Parameters.Add(pamSal);
            SqlParameter pamEspe = new SqlParameter("@especialidad", especialidad);
            this.com.Parameters.Add(pamEspe);
            SqlParameter pamApe = new SqlParameter("@apellido", apellido);
            this.com.Parameters.Add(pamApe);
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
        public void insertarDoctor(String nomHosp, String apellido, String especialidad, int salario)
        {
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "insertarDoctor";
            SqlParameter pamnomHosp = new SqlParameter("@hospnom", nomHosp);
            this.com.Parameters.Add(pamnomHosp);
            SqlParameter pamSal = new SqlParameter("@salario", salario);
            this.com.Parameters.Add(pamSal);
            SqlParameter pamEspe = new SqlParameter("@especialidad", especialidad);
            this.com.Parameters.Add(pamEspe);
            SqlParameter pamApe = new SqlParameter("@apellido", apellido);
            this.com.Parameters.Add(pamApe);
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}


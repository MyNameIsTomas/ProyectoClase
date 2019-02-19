using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClasesSQL.Models;

#region Procedimientos
/*
 Create procedure MostrarOficios
as
	select distinct OFICIO from EMP;
go
Create procedure MostrarDepartamentos
as
	select DNOMBRE, DEPT_NO from DEPT;
go
Create procedure BuscarDepartamento (@DEPTNO int, @PERSONAS int out, @SUMA int out)
as
	select APELLIDO, EMP_NO from EMP where DEPT_NO = @DEPTNO;
	select @PERSONAS = COUNT(EMP_NO), @SUMA = SUM(SALARIO) from EMP where DEPT_NO = @DEPTNO;
go
 */
#endregion

namespace ClasesSQL.Helpers { 
    public class HelperDepartamentos {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public HelperDepartamentos(String cadenaConexion) {
            this.cn = new SqlConnection(cadenaConexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }
        public List<String> GetOficios() {
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "MostrarOficios";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<String> oficios = new List<string>();
            while (this.reader.Read()) {
                String ofi = this.reader["OFICIO"].ToString();
                oficios.Add(ofi);
            }
            this.reader.Close();
            this.cn.Close();
            return oficios;
        }
        public List<Departamento> GetDepartamentos() {
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "MostrarDepartamentos";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<Departamento> departamentos = new List<Departamento>();
            while (this.reader.Read()) {
                Departamento d = new Departamento();
                int deptno = int.Parse(this.reader["DEPT_NO"].ToString());
                String nombre = this.reader["DNOMBRE"].ToString();
                d.NumeroDepartamento = deptno;
                d.Nombre = nombre;
                departamentos.Add(d);
            }
            this.reader.Close();
            this.cn.Close();
            return departamentos;
        }
        public Departamento BuscarDepartamento(int deptno) {
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "BuscarDepartamento";
            SqlParameter pamdept = new SqlParameter("@DEPTNO", deptno);
            this.com.Parameters.Add(pamdept);
            SqlParameter pamperson = new SqlParameter("@PERSONAS", 0);
            //Parametro de salida
            pamperson.Direction = System.Data.ParameterDirection.Output;
            this.com.Parameters.Add(pamperson);
            SqlParameter pamsum = new SqlParameter("@SUMA", 0);
            //Parametro de salida
            pamsum.Direction = System.Data.ParameterDirection.Output;
            this.com.Parameters.Add(pamsum);
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            Departamento dept = new Departamento();
            if (this.reader.HasRows){
                dept.Empleados = new List<Empleado>();
                while (this.reader.Read()) {
                    Empleado emp = new Empleado();
                    emp.NumeroEmpleado = int.Parse(this.reader["EMP_NO"].ToString());
                    emp.Apellido = this.reader["APELLIDO"].ToString();
                    dept.Empleados.Add(emp);
                }
                this.reader.Close();
                dept.Personas = int.Parse(pamperson.Value.ToString());
                dept.SumaSalarial = int.Parse(pamsum.Value.ToString());

                this.com.Parameters.Clear();
                this.cn.Close();
                return dept;
            } else {
                this.cn.Close();
                this.com.Parameters.Clear();
                return null;
            }
        }
        public Empleado BuscarEmpleado(int empno) {
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "BuscarEmpleado";
            this.cn.Open();
            SqlParameter pamempo = new SqlParameter("@EMPNO", empno);
            this.com.Parameters.Add(pamempo);
            this.reader = this.com.ExecuteReader();
            Empleado emp = new Empleado();
            this.reader.Read();
            emp.Salario = int.Parse(this.reader["SALARIO"].ToString());
            emp.Oficio = this.reader["OFICIO"].ToString();
            emp.Departamento = int.Parse(this.reader["DEPT_NO"].ToString());
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return emp;
        }
        public void modificarEmpleado(int empno, int salario, String oficio, int deptno) {
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "modificarEmpleado";
            SqlParameter pamEmpno = new SqlParameter("@empno", empno);
            this.com.Parameters.Add(pamEmpno);
            SqlParameter pamSal = new SqlParameter("@salario", salario);
            this.com.Parameters.Add(pamSal);
            SqlParameter pamOficio = new SqlParameter("@oficio", oficio);
            this.com.Parameters.Add(pamOficio);
            SqlParameter pamDeptno = new SqlParameter("@deptno", deptno);
            this.com.Parameters.Add(pamDeptno);
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
        public void EliminarEmpleado(int empno) {
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "EliminarEmpleado";
            SqlParameter pamempno = new SqlParameter("@EMPNO", empno);
            this.com.Parameters.Add(pamempno);
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}

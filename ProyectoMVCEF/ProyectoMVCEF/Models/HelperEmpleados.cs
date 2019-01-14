using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

#region Procedimientos
/*
 alter procedure informacionempleado
(@posicion int)
as
	select * from 
	(select ROW_NUMBER() over (order by apellido) as posicion, 
	EMP.*, DEPT.DNOMBRE, DEPT.LOC
	from EMP inner join DEPT 
	on EMP.DEPT_NO = DEPT.DEPT_NO) 
	consulta where posicion = @posicion
go
exec informacionempleado 3
************************************************************************************************************************
create procedure datosdepartamento
(@deptno int, @personas int out, @suma int out, @media int out)
as
	select @personas = COUNT(EMP_NO), @suma = SUM(SALARIO), @media = AVG(SALARIO) 
	from EMP where DEPT_NO = @deptno
go
************************************************************************************************************************
alter procedure paginarEmpleadosGrupo
(@posicion int, @totalregistro int out)
as
	select @totalregistro = COUNT(EMP_NO) from emp;
	select * from (select ROW_NUMBER() over (order by apellido) 
	as posicion, APELLIDO, SALARIO, OFICIO from EMP) empleados
	where posicion >= @posicion and posicion < (@posicion + 3);
go
************************************************************************************************************************
alter procedure paginarTrabajadores
(@posicion int, @salario int, @totalregistro int out)
as
	select @totalregistro = COUNT(APELLIDO) from informacionTrabajadores where salario > @salario;

	select * from (select ROW_NUMBER() over (order by apellido) 
	as POSICION, APELLIDO, SALARIO, CARGO from informacionTrabajadores where SALARIO > @salario) trabajadores
	where posicion >= @posicion and posicion < (@posicion + 6);
go
************************************************************************************************************************
alter view informacionTrabajadores
as
	select ISNULL(IDEMPLEADO, 0) as IDEMPLEADO, APELLIDO, CARGO, SALARIO FROM
	(select DOCTOR_NO as IDEMPLEADO, UPPER(APELLIDO) as APELLIDO, UPPER(ESPECIALIDAD) as CARGO, SALARIO from DOCTOR union all
	select EMPLEADO_NO as IDEMPLEADO, UPPER(APELLIDO) as APELLIDO, UPPER(FUNCION) as CARGO, SALARIO from PLANTILLA union all
	select EMP_NO as IDEMPLEADO, UPPER(APELLIDO) as APELLIDO, UPPER(OFICIO) as CARGO, SALARIO from EMP) CONSULTA
go
*/
#endregion
namespace ProyectoMVCEF.Models {
    public class HelperEmpleados {
        //context, entity
        EntidadHospital entidad;
        public HelperEmpleados() {
            this.entidad = new EntidadHospital();
        }
        public List<String> GetOficios() {
            //Where no podemos utilizar Parse
            var consulta = (from datos in entidad.EMP select datos.OFICIO).Distinct();
            return consulta.ToList();
        }
        public List<EMP> GetEmpleadosOficio(String oficio) {
            var consulta = from datos in entidad.EMP where datos.OFICIO == oficio select datos;
            return consulta.ToList();
        }
        public ResumenEmpleados GetResumenEmpleados(String oficio) {
            List<EMP> empleados = this.GetEmpleadosOficio(oficio);
            int personas = empleados.Count;
            int? maximo = empleados.Max(x => x.SALARIO);
            System.Nullable<int> suma = empleados.Sum(z => z.SALARIO);
            double? media = empleados.Average(z => z.SALARIO);
            ResumenEmpleados resumen = new ResumenEmpleados();
            resumen.Personas = personas;
            resumen.SumaSalarial = suma.GetValueOrDefault();
            resumen.MaximoSalarial = maximo.GetValueOrDefault();
            resumen.MediaSalarial = media.GetValueOrDefault();
            return resumen;
        }
        /*-------------*/
        public List<DEPT> GetDepartamentos() {
            var consulta = from datos in entidad.DEPT select datos;
            return consulta.ToList();
        }
        public List<EMP> GetEmpleadosDepartamento(int deptno) {
            var consulta = from datos in entidad.EMP where datos.DEPT_NO == deptno select datos;
            return consulta.ToList();
        }
        public ResumenEmpleados GetResumenEmpleadosDepartamento(int deptno) {
            List<EMP> empleados = this.GetEmpleadosDepartamento(deptno);
            int personas = empleados.Count;
            int? maximo = empleados.Max(x => x.SALARIO);
            System.Nullable<int> suma = empleados.Sum(z => z.SALARIO);
            double? media = empleados.Average(z => z.SALARIO);
            ResumenEmpleados resumen = new ResumenEmpleados();
            resumen.Personas = personas;
            resumen.SumaSalarial = suma.GetValueOrDefault();
            resumen.MaximoSalarial = maximo.GetValueOrDefault();
            resumen.MediaSalarial = media.GetValueOrDefault();
            return resumen;
        }
        /*-------------*/
        public List<EMP> GetEmpleados() {
            var consulta = from datos in entidad.EMP orderby datos.APELLIDO select datos;            
            return consulta.ToList();
        }
        /*-------------*/
        public informacionempleado_Result GetInformacionEmpleados(int posicion){
            var consulta = this.entidad.informacionempleado(posicion);
            informacionempleado_Result empleado = consulta.FirstOrDefault();
            return empleado;
        }
        public int GetNumeroEmpleados() {
            int datos = this.entidad.EMP.Count();
            return datos;
        }
        /*-------------*/
        public informaciondoctor_Result GetInformacionDoctor(int posicion) {
            var consulta = this.entidad.informaciondoctor(posicion);
            informaciondoctor_Result doctor = consulta.FirstOrDefault();
            return doctor;
        }
        public int GetNumeroDoctores() {
            int datos = this.entidad.DOCTOR.Count();
            return datos;
        }
        /*-------------*/
        public ResumenEmpleados GetResumenParametrosSalida(int numdep) {
            //Los parametros de salida con entity framework se llaman con objetos de la clase ObjectParameter
            //Debemos indicar el nombre del parametro (sin @) y su tipo de dato
            ObjectParameter pampersonas = new ObjectParameter("PERSONAS", typeof(int));
            ObjectParameter pammedia = new ObjectParameter("MEDIA", typeof(int));
            ObjectParameter pamsuma = new ObjectParameter("SUMA", typeof(int));
            this.entidad.datosdepartamento(numdep, pampersonas, pamsuma, pammedia);
            //Comprobar si devuelve valor en los parametros 
            if(pamsuma.Value == System.DBNull.Value) {
                return null;
            }
            ResumenEmpleados resumen = new ResumenEmpleados();
            resumen.Personas = (int)pampersonas.Value;
            resumen.MaximoSalarial = (int)pammedia.Value;
            resumen.SumaSalarial = (int)pamsuma.Value;
            return resumen;
        }
        /*-------------*/
        //Devolvemos una colección de EMP (Comple Type)
        public List<paginarEmpleadosGrupo_Result> GetEmpleadosGrupo (int posicion, ref int totalregistros) {
            ObjectParameter pamregistros = new ObjectParameter("totalregistro", typeof(int));
            //Deberiamos extraer los datos de los procedimientos en dos pasos 
            var datos = this.entidad.paginarEmpleadosGrupo(posicion, pamregistros);
            //Convertimos los datos a su tipo (List<>)
            List<paginarEmpleadosGrupo_Result> empleados = datos.ToList();
            totalregistros = (int)pamregistros.Value;
            return empleados;
        }
        /*-------------*/
        public List<paginarTrabajadores_Result> GetTrabajadoresGrupo(int posicion, int salario, ref int totalregistros) {
            ObjectParameter pamregistros = new ObjectParameter("totalregistro", typeof(int));
            //Deberiamos extraer los datos de los procedimientos en dos pasos 
            var datos = this.entidad.paginarTrabajadores(posicion, salario, pamregistros);
            //Convertimos los datos a su tipo (List<>)
            List<paginarTrabajadores_Result> trabajadores = datos.ToList();
            totalregistros = (int)pamregistros.Value;
            return trabajadores;
        }
        /*-------------*/
        public List<informacionTrabajadores> GetPaginarLINQ(int posicion, ref int totalregistros) {
            totalregistros = this.entidad.informacionTrabajadores.Count();
            var consulta = (from datos in entidad.informacionTrabajadores select datos).OrderBy(z => z.APELLIDO).Skip(posicion).Take(3).ToList();
            List <informacionTrabajadores> trabajadores = consulta;
            return trabajadores;
        }
        /*-------------*/
        public List<EMP> GetEmpleadosDepartamentoMultiple(int[] departamentos) {
            //Para buscar multiple (conjunto) se tuiliza .Contains
            var consulta = from datos in entidad.EMP where departamentos.Contains((int)datos.DEPT_NO) select datos;
            return consulta.ToList();
        }
        //GetDepartamentos
        //GetEmpleadosDepartamentos
    }
}
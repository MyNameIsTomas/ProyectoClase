using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoLinq.Models {
    public class HelperEmpleados {
        ContextoHospitalDataContext contexto;
        public HelperEmpleados() {
            this.contexto = new ContextoHospitalDataContext();
        }
        public List<String> GetOficios() {
            var consulta = (from datos in contexto.EMPs select datos.OFICIO).Distinct();
            return consulta.ToList();
        }
        public List<EMP> GetEmpleados() {
            var consulta = from datos in contexto.EMPs select datos;
            return consulta.ToList();
        }
        public int ModificarSalario(String oficios, int incremento) {
            var consulta = from datos in contexto.EMPs where datos.OFICIO == oficios select datos;
            foreach (EMP emp in consulta) {
                emp.SALARIO += incremento;
            }
            int cambios = consulta.Count();
            contexto.SubmitChanges();
            return cambios;
        }
        /**********************************************************/
        public List<String> GetDepartamentos() {
            var consulta = (from datos in contexto.DEPTs select datos.DNOMBRE).Distinct();
            return consulta.ToList();
        }
        public List<EMP> GetEmpleadosDepartamento(String departamento) {
            int numero = (from datos in contexto.DEPTs where datos.DNOMBRE == departamento select datos.DEPT_NO).FirstOrDefault();
            var consulta = from datos in contexto.EMPs where datos.DEPT_NO == numero select datos;
            return consulta.ToList();
        }
    }
}
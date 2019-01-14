using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoMVCEF.Models {
    public class HelperHospitales {
        EntidadHospital entidad;
        public HelperHospitales() {
            this.entidad = new EntidadHospital();
        }
        public List<HOSPITAL> GetHospitales() {
            var consulta = from datos in entidad.HOSPITAL select datos;
            return consulta.ToList();
        }
        public List<PLANTILLA> GetPlantillaHospitalMultiple(String[] hospitales) {
            var consulta = from datos in entidad.PLANTILLA where hospitales.Contains((String)datos.HOSPITAL_COD) select datos;
            return consulta.ToList();
        }

        /*
         public List<EMP> GetEmpleadosDepartamento(int deptno) {
            var consulta = from datos in entidad.EMP where datos.DEPT_NO == deptno select datos;
            return consulta.ToList();
        }
         */

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoMVCReal.Models {
    public class HelperLinqDepartamentos {
        //El contexto sera el objeto de acceso a datos siempre se llamara NOMBRE_CONTEXTODataContex
        ContextoHospitalDataContext contexto;
        //Necesitamos todos los departamentos
        public HelperLinqDepartamentos() {
            this.contexto = new ContextoHospitalDataContext();
        }
        public List<DEPT> GetDepartamentos() {
            var consulta = from datos in contexto.DEPTs select datos;
            return consulta.ToList();
        }
        public DEPT GetDepartamentoLocalidad(String localidad) {
            var consulta = from datos in contexto.DEPTs where datos.LOC == localidad select datos;
            if (consulta.Count() == 0) {
                return null;
            } else {
                //.First() devuelve el primer elemento de la colección
                return consulta.First();
            }
        }
        public void InsertarDepartamento(int numero, String nombre, String localidad) {
            DEPT dept = new DEPT();
            dept.DNOMBRE = nombre;
            dept.DEPT_NO = numero;
            dept.LOC = localidad;
            //Recuperamos los datos del contexto si deseamos insertar, debemos agregar la nueva clase al contexto
            contexto.DEPTs.InsertOnSubmit(dept);
            //Si deseamos almacenar el dato en BBDD
            contexto.SubmitChanges();
        }
        public int EliminarDepartamento(int numero) {
            //Solamente una fila, buscamos el departamento por su numero
            DEPT dept = (from datos in contexto.DEPTs where datos.DEPT_NO == numero select datos).FirstOrDefault();
            if (dept == null) {
                return 0;
            } else {
                contexto.DEPTs.DeleteOnSubmit(dept);
                contexto.SubmitChanges();
                return 1;
            }
        }
        public int ModificarDepartamento(String newLoc, String oldLoc) {
            //Consulta para bucar todos los departamentos por localidad
            var consulta = from datos in contexto.DEPTs where datos.LOC == oldLoc select datos;
            if (consulta.Count() == 0) {
                return 0;
            } else {
                //Recorremos todos los departamentos de la consulta
                foreach (DEPT dept in consulta) {
                    //Modificamos Dato/Datos de cada departamento
                    dept.LOC = newLoc;
                }
                contexto.SubmitChanges();
                return consulta.Count();
            }
        }
        public List<String> GetLocalidades() {
            var consulta = (from datos in contexto.DEPTs select datos.LOC).Distinct();
            return consulta.ToList();
        }
    }
}
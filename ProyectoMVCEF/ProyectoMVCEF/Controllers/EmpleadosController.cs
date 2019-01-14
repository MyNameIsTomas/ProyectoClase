using ProyectoMVCEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMVCEF.Controllers {
    public class EmpleadosController : Controller {
        HelperEmpleados helper;
        public EmpleadosController() {
            this.helper = new HelperEmpleados();
        }
        // GET: EmpleadosOficio
        public ActionResult EmpleadosOficio() {
            List<String> oficios = helper.GetOficios();
            ViewBag.Oficios = oficios;
            return View();
        }
        // POST: EmpleadosOficio
        [HttpPost]
        public ActionResult EmpleadosOficio(string oficio) {
            List<String> oficios = this.helper.GetOficios();
            List<EMP> empleados = this.helper.GetEmpleadosOficio(oficio);
            ResumenEmpleados resumen = this.helper.GetResumenEmpleados(oficio);
            ViewBag.Oficios = oficios;
            ViewBag.Resumen = resumen;
            return View(empleados);
        }
        /*_________________________________________________________________*/
        // GET: EmpleadosDepartamento
        public ActionResult EmpleadosDepartamento() {
            List<DEPT> departamentos = helper.GetDepartamentos();
            ViewBag.Departamentos = departamentos;
            return View();
        }
         [HttpPost]
        public ActionResult EmpleadosDepartamento(int departamentos) {
            List<DEPT> departamento = helper.GetDepartamentos();
            List<EMP> empleados = this.helper.GetEmpleadosDepartamento(departamentos);
            ResumenEmpleados resumen = this.helper.GetResumenEmpleadosDepartamento(departamentos);
            ViewBag.Departamentos = departamento;
            ViewBag.Resumen = resumen;
            return View(empleados);
        }

        /*_________________________________________________________________*/
        // GET: OrdenarEmpleados
        public ActionResult OrdenarEmpleados(String orden) {
            List<EMP> empleados = helper.GetEmpleados();
            ViewBag.Orden = "DESC";
            if (orden != null) {
                if(orden.ToLower() == "asc") {
                    empleados = empleados.OrderBy(z => z.APELLIDO).ToList();
                    ViewBag.Orden = "DESC";
                } else {
                    empleados = empleados.OrderByDescending(z => z.APELLIDO).ToList();
                    ViewBag.Orden = "ASC";
                }
            }
            
            return View(empleados);
        }
        /*_________________________________________________________________*/
        // GET: PaginarEmpleadosSimple
        public ActionResult PaginarEmpleadosSimple(int? posicion) {
            if (posicion == null) {
                posicion = 1;
            }
            int siguiente = posicion.GetValueOrDefault() + 1;
            int anterior = posicion.GetValueOrDefault() - 1;
            int ultimo = this.helper.GetNumeroEmpleados();
            //Comprobamos los valores de las posiciones
            if (anterior < 1) {
                anterior = 1;
            }
            if (siguiente > ultimo) {
                siguiente = ultimo;
            }
            ViewBag.Anterior = anterior;
            ViewBag.Siguiente = siguiente;
            ViewBag.Ultimo = ultimo;
            ViewBag.Mensaje = "Registro " + posicion + " de " + ultimo;
            informacionempleado_Result empleado = this.helper.GetInformacionEmpleados(posicion.GetValueOrDefault());
            return View(empleado);
        }
        /*_________________________________________________________________*/
        // GET: PaginarDoctorSimple
        public ActionResult PaginarDoctorSimple(int? posicion) {
            if (posicion == null) {
                posicion = 1;
            }
            int siguiente = posicion.GetValueOrDefault() + 1;
            int anterior = posicion.GetValueOrDefault() - 1;
            int ultimo = this.helper.GetNumeroDoctores();
            //Comprobamos los valores de las posiciones
            if (anterior < 1) {
                anterior = 1;
            }
            if (siguiente > ultimo){
                siguiente = ultimo;
            }
            ViewBag.Anterior = anterior;
            ViewBag.Siguiente = siguiente;
            ViewBag.Ultimo = ultimo;
            ViewBag.Mensaje = "Registro " + posicion + " de " + ultimo;
            informaciondoctor_Result doctor = this.helper.GetInformacionDoctor(posicion.GetValueOrDefault());
            return View(doctor);
        }
        /*_________________________________________________________________*/
        public ActionResult ParametroSalida() {
            return View();
        }

        [HttpPost]
        public ActionResult ParametroSalida(int departamento) {
            ResumenEmpleados resumen = this.helper.GetResumenParametrosSalida(departamento);
            return View(resumen);
        }
        /*_________________________________________________________________*/
        // GET: PaginarGrupo
        public ActionResult PaginarGrupo(int? posicion) {
            if (posicion == null) {
                posicion = 1;
            }
            int totalregistros = 0;
            List<paginarEmpleadosGrupo_Result> empleados = this.helper.GetEmpleadosGrupo(posicion.GetValueOrDefault(), ref totalregistros);
            //int numeropagina = 1;
            //1, 2, 3 posición de 3 en 3 hasta que haya registros
            //Numero de pagina 1-1
            ViewBag.TotalRegistros = totalregistros;
            //String html = "";
            //for (int i = 1; i <= totalregistros; i+=3) {
            //    html += "<a href = 'paginarGrupo?posicion=" + i + "'>" + numeropagina + "</a>   |  ";
            //    numeropagina += 1;
            //}
            //ViewBag.Paginacion = html;
            return View(empleados);
        }

        /*_________________________________________________________________*/
        // GET: PaginarTrabajadores
        public ActionResult PaginarTrabajadroes(int? posicion, int? salario) {
            if (posicion == null) {
                posicion = 1;
            }
            if (salario == null) { 
                salario = 0;
            }
            int totalregistros = 0;
            List<paginarTrabajadores_Result> empleados = this.helper.GetTrabajadoresGrupo(posicion.GetValueOrDefault(), salario.GetValueOrDefault(), ref totalregistros);
            ViewBag.TotalRegistros = totalregistros;
            ViewBag.Salario = salario.GetValueOrDefault();
            return View(empleados);
        }
        // POST: PaginarTrabajadores
        [HttpPost]
        public ActionResult PaginarTrabajadroes(int? posicion, int salario) {
            posicion = 1;
            int totalregistros = 0;
            List<paginarTrabajadores_Result> empleados = this.helper.GetTrabajadoresGrupo(posicion.GetValueOrDefault(), salario, ref totalregistros);
            ViewBag.TotalRegistros = totalregistros;
            ViewBag.Salario = salario;
            return View(empleados);
        }
        /*_________________________________________________________________*/
        // GET: PaginarLinq
        public ActionResult PaginarLinq(int? posicion) {
            if (posicion == null) {
                posicion = 1;
            }
            int totalregistros = 0;
            List<informacionTrabajadores> trabajadores = helper.GetPaginarLINQ(posicion.GetValueOrDefault(), ref totalregistros);
            ViewBag.TotalRegistros = totalregistros;
            return View(trabajadores);
        }
        /*_________________________________________________________________*/
        // GET: SeleccionMultiple
        public ActionResult SeleccionMultiple() {
            List<DEPT> departamentos = this.helper.GetDepartamentos();
            ViewBag.Departamentos = departamentos;
            return View();
        }
        // POST: SeleccionMultiple
        [HttpPost]
        public ActionResult SeleccionMultiple(int[] departamento) {
            List<DEPT> departamentos = this.helper.GetDepartamentos();
            ViewBag.Departamentos = departamentos;
            List<EMP> empleados = this.helper.GetEmpleadosDepartamentoMultiple(departamento);
            return View(empleados);
        }
        /*_________________________________________________________________*/
        // GET: Empleados
        public ActionResult Index() {
            return View();
        }
        
    }
}
using ProyectoMVCReal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMVCReal.Controllers {
    public class DeptLinqController : Controller {
        HelperLinqDepartamentos helper;
        public DeptLinqController() {
            this.helper = new HelperLinqDepartamentos();
        }
        // GET: Index
        public ActionResult Index() {
            List<DEPT> lista = this.helper.GetDepartamentos();
            return View(lista);
        }
        // GET: BuscarLocalidad
        public ActionResult BuscarLocalidad() {
            ViewBag.Lis = this.helper.GetDepartamentos();
            return View();
        }
        // POST: BuscarLocalidad
        [HttpPost]
        public ActionResult BuscarLocalidad(String localidad) {
            DEPT depar = this.helper.GetDepartamentoLocalidad(localidad);
            ViewBag.Lis = this.helper.GetDepartamentos();
            return View(depar);
        }
        // GET: InsertarDepartamento
        public ActionResult InsertarDepartamento() {
            return View();
        }
        // POST: InsertarDepartamento
        [HttpPost]
        public ActionResult InsertarDepartamento(int numero, String nombre, String localidad) {
            this.helper.InsertarDepartamento(numero, nombre, localidad);
            ViewBag.Mensaje = "Departamento insertado";
            return View();
        }
        // GET: EliminarDepartamento
        public ActionResult EliminarDepartamento() {
            return View();
        }
        // POST: EliminarDepartamento
        [HttpPost]
        public ActionResult EliminarDepartamento(int deptno) {
            int afectados = this.helper.EliminarDepartamento(deptno);
            if (afectados == 0) {
                ViewBag.Mensaje = "No existe el departamento " + deptno;
            } else {
                ViewBag.Mensaje = "Departamento eliminado";
            }
            return View();
        }
        // GET: ModificarDepartamento
        public ActionResult ModificarDepartamento() {
            List<String> localidades = this.helper.GetLocalidades();
            return View(localidades);
        }
        // POST: ModificarDepartamento
        [HttpPost]
        public ActionResult ModificarDepartamento(String newloc, String oldloc) {
            int afectados = this.helper.ModificarDepartamento(newloc, oldloc);
            ViewBag.Mensaje = "Se han modificado " + afectados + " departamentos";
            List<String> localidades = this.helper.GetLocalidades();
            return View(localidades);
        }
    }
}
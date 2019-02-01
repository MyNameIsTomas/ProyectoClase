using ProyectoLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoLinq.Controllers {
    public class EmpleadoController : Controller {
        HelperEmpleados helper;
        public EmpleadoController() {
            this.helper = new HelperEmpleados();
        }
        // GET: Empleado
        public ActionResult Index() {
            ViewBag.Lis = this.helper.GetOficios();
            List<EMP> lista = this.helper.GetEmpleados();
            return View(lista);
        }
        // POST: Empleado
        [HttpPost]
        public ActionResult Index(String oficio, int incremento) {
            ViewBag.Lis = this.helper.GetOficios();
            List<EMP> lista = this.helper.GetEmpleados();
            int cambios = this.helper.ModificarSalario(oficio, incremento);
            return View(lista);
        }
        //GET: EmpleadoDepartamento
        public ActionResult EmpleadoDepartamento() {
            ViewBag.Lista = this.helper.GetDepartamentos();
            return View();
        }
        // POST: EmpleadoDepartamento
        
        [HttpPost]
        public ActionResult EmpleadoDepartamento(String departamento) {
            ViewBag.Lista = this.helper.GetDepartamentos();
            List<EMP> lista = this.helper.GetEmpleadosDepartamento(departamento);
            return View(lista);
        }
        
    }
}
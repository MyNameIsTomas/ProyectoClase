using ProyectoMVCReal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMVCReal.Controllers {
    public class DepartamentoController : Controller {
        HelperDepartamento helper;
        public DepartamentoController() {
            this.helper = new HelperDepartamento();
        }
        // GET: Index
        public ActionResult Index() {
            List<Departamento> lista = this.helper.GetDepartamentos();
            return View(lista);
        }

        public ActionResult DetalleDepartamento(int numero) {
            Departamento dept = this.helper.BuscarDepartamento(numero);
            return View(dept);
        }

        // GET: BuscarDepartamento
        public ActionResult BuscarDepartamento() {
            return View();
        }
        //POST: BuscarDepartamento
        [HttpPost]
        public ActionResult BuscarDepartamento(int numero) {
            this.helper = new HelperDepartamento();
            Departamento dept = helper.BuscarDepartamento(numero);
            if (dept == null) {
                ViewBag.Mensaje = "No se han econtrado departamentos con el numero " + numero;
            }
            return View(dept);
        }
    }
}
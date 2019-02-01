using ProyectoMVCReal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMVCReal.Controllers {
    public class DoctoresController : Controller {
        HelperDoctores helper;
        public DoctoresController() {
            this.helper = new HelperDoctores();
        }
        // GET: Index
        public ActionResult Index() {
            List<Doctores> lista = this.helper.GetDoctores();
            return View(lista);
        }
        // POST: Index
        [HttpPost]
        public ActionResult Index(int numero) {
            this.helper.EliminarDoctor(numero);
            List<Doctores> lista = this.helper.GetDoctores();
            return View(lista);
        }

        // GET: DetalleDoctores
        public ActionResult DetalleDoctores(int numero) {
            Doctores doc = this.helper.BuscarDoctor(numero);
            return View(doc);
        }

    }
}
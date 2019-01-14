using ProyectoMVCEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMVCEF.Controllers {
    public class ValidacionesController : Controller {
        // GET: Correcto
        public ActionResult Correcto() {
            return View();
        }
        /*___________________________________________*/
        // GET: InsertarPersona
        public ActionResult InsertarPersona() {
            return View();
        }
        // POST: InsertarPersona
        [HttpPost]
        public ActionResult InsertarPersona(Persona persona) {
            if (ModelState.IsValid) {
                //Enviamos la información a Correcto
                return View("Correcto");
            }
            return View(persona);
        }
        /*___________________________________________*/
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimerMVC.Controllers {
    public class InicioController : Controller {
        // GET: Inicio
        public ActionResult Index() {
            return View();
        }
        public ActionResult Home() {
            ViewData["MENSAJE"] = "Quedan diez días para las vacaciones de Navidad";
            return View();
        }
    }
}
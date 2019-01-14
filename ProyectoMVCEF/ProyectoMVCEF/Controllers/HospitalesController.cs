using ProyectoMVCEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMVCEF.Controllers {
    public class HospitalesController : Controller {
        HelperHospitales helper;
        public HospitalesController() {
            this.helper = new HelperHospitales();
        }
        /*_____________________________________________________________*/
        //GET: PaginarEmpleados
        public ActionResult PaginarEmpleados() {
            List<HOSPITAL> hospitales = this.helper.GetHospitales();
            ViewBag.Hospitales = hospitales;
            return View();
        }
        //POST: PaginarEmpleados
        [HttpPost]
        public ActionResult PaginarEmpleados(String[] hospital, String orden) {
            List<HOSPITAL> hospitales = this.helper.GetHospitales();
            ViewBag.Hospitales = hospitales;
            List<PLANTILLA> plantilla = this.helper.GetPlantillaHospitalMultiple(hospital);
            ViewBag.Orden = "DESC";
            if (orden != null) {
                if (orden.ToLower() == "asc") {
                    plantilla = plantilla.OrderBy(z => z.APELLIDO).ToList();
                    ViewBag.Orden = "DESC";
                } else {
                    plantilla = plantilla.OrderByDescending(z => z.APELLIDO).ToList();
                    ViewBag.Orden = "ASC";
                }
            }
            return View(plantilla);
        }
        /*_____________________________________________________________*/
        // GET: Hospitales
        public ActionResult Index() {
            return View();
        }
    }
}
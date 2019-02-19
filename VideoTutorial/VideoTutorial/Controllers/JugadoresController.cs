using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoTutorial.Models;

namespace VideoTutorial.Controllers {
    public class JugadoresController : Controller {
        HelperJugadores helper;
        public JugadoresController() {
            this.helper = new HelperJugadores();
        }
        /*__________________________________________________*/
        // GET: PaginarJugadores
        public ActionResult PaginarJugadores(int? posicion, String [] equipo) {
            if (posicion == null) {
                posicion = 0;
            }
            int totalregistros = 0;
            ViewBag.Equipos = equipo;
            //Preguntar si el equipo recibido es null o no
            List<InformacionJugadores> trabajadores = helper.GetPaginarJugadores(equipo, posicion.GetValueOrDefault(), ref totalregistros);
            ViewBag.TotalRegistros = totalregistros;
            ViewBag.Equipo = helper.GetEquipos();
            
            return View(trabajadores);
        }
        //POST: PaginarJugadores
        [HttpPost]
        public ActionResult PaginarJugadores(String[] equipo, int? posicion) {
            if (posicion == null) {
                posicion = 0;
            }
            int totalregistros = 0;
            List<InformacionJugadores> trabajadores = helper.GetPaginarJugadores(equipo, posicion.GetValueOrDefault(), ref totalregistros);
            ViewBag.TotalRegistros = totalregistros;
            ViewBag.Equipo = helper.GetEquipos();
            ViewBag.Equipos = equipo;
            return View(trabajadores);
        }
        /*__________________________________________________*/
        //Insertar equipo   Enlace
        //GET: InsertarEquipo
        public ActionResult InsertarEquipo() {

            return View();
        }
        /*__________________________________________________*/
        //GET: InsertarJugadro
        public ActionResult InsertarJugador() {

            return View();
        }
        /*__________________________________________________*/
        // GET: Index
        public ActionResult Index() {
            return View();
        }

    }
}
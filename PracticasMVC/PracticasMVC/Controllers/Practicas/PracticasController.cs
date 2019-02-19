using PracticasMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticasMVC.Controllers.Practicas {
    public class PracticasController : Controller {
        // GET: Practicas
        public ActionResult Index() {
            return View();
        }
        /*************************************************/
        //Get: SumarNumeros
        public ActionResult SumarNumeros() {
            return View();
        }
        //Post: SumarNumeros
        [HttpPost]
        public ActionResult SumarNumeros(int? Num1, int? Num2) {
            ViewBag.Operacion = (Num1 + Num2);
            return View();
        }
        /*************************************************/
        //Get: NumeroDoble
        public ActionResult NumeroDoble(int? numero) {
            ViewBag.Doble = (numero * 2);
            return View();
        }
        //Post: NumeroDoble
        [HttpPost]
        public ActionResult NumeroDoble() {
            return View();
        }
        /*************************************************/
        //Get: TablaMultiplicar
        public ActionResult TablaMultiplicar() {
            return View();
        }
        //Post: TablaMultiplicar
        [HttpPost]
        public ActionResult TablaMultiplicar(int Numero){
            //Se debería realizar aquí las operaciones
            int[] tabla = new int[10];
            for (var i = 0; i < 10; i++) {
                tabla[i] = (Numero * (i + 1));
            }
            ViewBag.Valores = tabla;
            return View();
        }
        /*************************************************/
        //Get: TablaMultiplicarObjeto
        public ActionResult TablaMultiplicarObjeto() {
            return View();
        }
        //Post: TablaMultiplicarObjeto
        [HttpPost]
        public ActionResult TablaMultiplicarObjeto(int numero) {
            List<Numero> tabla = new List<Numero>();
            for (var i = 1; i <= 10; i++) {
                Numero obj = new Numero();
                obj.Operacion = numero + " * " + i;
                obj.Resultado = numero * i;
                tabla.Add(obj);
            }
            return View(tabla);
        }
        /*************************************************/
        //Get: TablaMultiplicarHTML
        public ActionResult TablaMultiplicarHTML() {
            return View();
        }
        //Post: TablaMultiplicarHTML
        [HttpPost]
        public ActionResult TablaMultiplicarHTML(int numero) {
            String html = "<table class='table table-bordered'>";
            for (var i = 1; i<=10; i++) {
                html += "<tr>";
                html += "<td>" + numero + " * " + i + "</td>";
                html += "<td>" + numero * i + "</td>";
                html += "</tr>";
            }
            html += "</table>";
            ViewBag.HTML = html;
            return View();
        }

        /*************************************************/
        //Get: VideosYouTube
        public ActionResult VideosYouTube() {
            return View();
        }
        //Post: VideosYouTube
        [HttpPost]
        public ActionResult VideosYouTube(String video) {
            String html = "<iframe width='560' height='315' src='https://www.youtube.com/embed/"+ video + "' frameborder='0' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>'";
            ViewBag.HTML = html;
            return View();
        }
        /*************************************************/
        HelperVimeo helper = new HelperVimeo();
        //Get: ListaVideosYouTube
        public ActionResult ListaVideosYouTube(){
            return View(helper.GetVideos());
        }
        //Post: ListaVideosYouTube
        [HttpPost]
        public ActionResult ListaVideosYouTube(String codigo) {
            ViewBag.HTML = helper.GetCodigoHTML(codigo);
            return View(helper.GetVideos());
        }
        /*************************************************/
    }
}
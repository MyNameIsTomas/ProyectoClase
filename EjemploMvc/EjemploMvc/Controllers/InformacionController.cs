using EjemploMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjemploMvc.Controllers {
    public class InformacionController : Controller {
        // GET: Informacion
        public ActionResult Index() {
            return View();
        }
        //Get: ControladorVista
        public ActionResult ControladorVista() {
            //Para enviar información a la vista, podemos hacerlo de dos forma
            //ViewData
            //ViewBag
            //Los dos objetos apuntan al mismo espacio de memoria, es decir, son el mismo objeto
            //No son casesensitive, permiten crear propiedades dinamicas 
            //Cualquier tipo de dato (object)
            //ViewData["PROPIEDAD"] = VALOR
            //ViewBag.Propiedad = VALOR
            ViewData["MENSAJE"] = "Mensaje desde el servidor";
            ViewBag.Informacion = "Mensaje desde ViewBag";
            ViewBag.Fecha = "14/12/2018";
            //Vamos a enviar a la vista un objeto persona. Pero primero en ViewBag
            Persona person = new Persona();
            person.Nombre = "Manolo";
            person.Apellido = "Ramos";
            person.Edad = 18;
            ViewBag.Persona = person;
            return View();
        }
        //Get: ControladorVistaModel
        public ActionResult ControladorVistaModel() {
            Persona persona = new Persona();
            persona.Nombre = "Tomás";
            persona.Apellido = "Serrano";
            persona.Edad = 22;
            //Una vista solamente recibe un modelo, el modelo estara tipado en al vista
            //Se envia al devolver la vista
            // @model Declarar
            // @model Utilizar
            return View(persona);
        }
        //Get: VistaControladorGet
        //La información se recibe como parametros
        //El nombre de los parametros debe ser igual al valor que nos envian
        public ActionResult VistaControladorGet
            (String nombre, int? edad)
            //(System.Nullable<int> nombre)
        {
            ViewBag.Nombre = nombre + ", " + edad;
            return View();
        }
        //Get: VistaControladorPost
        public ActionResult VistaControladorPost(){
            return View();
        }
        //Post: VistaControladorPost
        /*
        [HttpPost]
        public ActionResult VistaControladorPost(String cajamarca, String cajamodelo) {
            ViewBag.Descripcion = "Marca: " + cajamarca + ", Modelo: " + cajamodelo;
            return View();
        }
        */
        //Metodo post recibiendo un objeto de la vista
        [HttpPost]
        public ActionResult VistaControladorPost(Coche car) {
            ViewBag.Descripcion = "Has recibido un coche!!!";
            return View(car);
        }
    }
}
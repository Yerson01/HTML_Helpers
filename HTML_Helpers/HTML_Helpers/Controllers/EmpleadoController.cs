using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTML_Helpers.Models;

namespace HTML_Helpers.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Formulario()
        {
            return View();
        }


        [HttpPost]
        public ActionResult ProcesarFormulario(Empleado emp)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Datos", emp);
            }
            else
            {
                return View("Formulario");
            }
        }

        public ActionResult Datos(Empleado obj)
        {
            return View(obj);

            //Estudiante datos = new Estudiante();

            //datos.Nombre = Request.Form["nombre"].ToString();
            //datos.Edad = int.Parse(Request.Form["edad"]);
            //datos.Carrera = Request.Form["carrera"].ToString();
            //datos.Cuatrimestre = int.Parse(Request.Form["cuatrimestre"]);


        }
    }
}
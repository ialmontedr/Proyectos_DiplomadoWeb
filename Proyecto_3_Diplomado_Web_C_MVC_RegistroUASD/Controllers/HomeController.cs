using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_3_Diplomado_Web_C_MVC_RegistroUASD.Models;
using System.Xml.Linq;

namespace Proyecto_3_Diplomado_Web_C_MVC_RegistroUASD.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()

        {
            var coches = new List<Persona>
            {
                new Persona {Cedula = "01800011222", Nombres="Anthony Almonte", Direccion="X1", Telefono="8098676146"},
                new Persona {Cedula = "01800011223", Nombres="Persio Perez", Direccion="X2", Telefono="8292680866"},
                new Persona {Cedula = "01800011224", Nombres="Elizabeth Escalante", Direccion="X3", Telefono="8294384185"},
                new Persona {Cedula = "01800011225", Nombres="Magnolia Matos", Direccion="X4", Telefono="8493304280"}
            };
            return View(coches);

        }
        public ActionResult CargaDatos()
        {

            return View();
        }
    }     

}
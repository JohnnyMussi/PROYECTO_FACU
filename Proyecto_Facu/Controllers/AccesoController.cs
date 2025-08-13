using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_Facu.Models;

namespace Proyecto_Facu.Controllers
{
    public class AccesoController : Controller
    {

        static string cadena = "\"Data Source=MSI\\SQLEXPRESS;Initial Catalog=DB_ACCESO;Integrated Security=True";

        // GET: Acceso
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Registrar()
        {
            return View();
        }
        
        public ActionResult Registrar()
        {
            return View();
        }



    }
}
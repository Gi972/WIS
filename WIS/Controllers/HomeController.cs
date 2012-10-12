using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WIS.DAL.Repository.Dotnet;
using WIS.Models.Entity.Dotnet;

namespace WIS.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Page = "Accueil";
            
            return View("Index");
        }

        
    }
}

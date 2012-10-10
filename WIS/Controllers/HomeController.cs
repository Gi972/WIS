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
        //
        // GET: /Home/
        RepoSnippetDotnet repo = new RepoSnippetDotnet(); 

        public ActionResult Index()
        {
            ViewBag.Page = "Accueil";
            
            return View("Index");
        }

        public ActionResult List()
        {
              
            return View(repo.List());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(SnippetDotnet snippet)
        {
            repo.Add(snippet);
            return RedirectToAction("List");
        }


        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityFramework_App.Models;

namespace EntityFramework_App.Controllers
{
    public class BrandsController : Controller
    {
        // GET: Brands/Index
        public ActionResult Index()
        {
            amarDBEntities amar_db = new amarDBEntities();
            List<Brand> brands = amar_db.Brands.ToList();
            return View(brands);
        }
    }
}
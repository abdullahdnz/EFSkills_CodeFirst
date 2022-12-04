using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using EFSkills_CodeFirst.Models.Class;

namespace EFSkills_CodeFirst.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Context c = new Context();
            var values = c.Yeteneks.ToList();
            return View(values);
        }
    }
}
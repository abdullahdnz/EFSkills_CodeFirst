using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using EFSkills_CodeFirst.Models.Class;

namespace EFSkills_CodeFirst.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {            
            var values = c.Yeteneks.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniYetenek(Yetenek y)
        {
            c.Yeteneks.Add(y);
            c.SaveChanges();
            return View();
        }
    }
}
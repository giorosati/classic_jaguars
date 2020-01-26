using Classic_Jaguar_MVC_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Classic_Jaguar_MVC_App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<car> JagModels;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                JagModels = db.JagModels.ToList();
            }
            return View(JagModels);
        }

        //[HttpGet]
        //public ActionResult SearchResults()
        //{
        //    List<car> SearchList = new List<car>();
        //    using (ApplicationDbContext db = new ApplicationDbContext())
        //    {
        //    }
        //}

        //add create funciton here
        //then create a view from this name
        //then edit the html page, createstudent

        public ActionResult CreateModel()
        {
            return View(new car());
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult CreateModel(car model)
        {
            if (ModelState.IsValid)
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    model.DateCreated = DateTime.Now;
                    model.DateDeleted = null;
                    db.JagModels.Add(model);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult DeleteModel(int id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                car model = db.JagModels.FirstOrDefault(x => x.ModelId == id);
                model.DateDeleted = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult EditModel(int id)
        {
            car model;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                model = db.JagModels.FirstOrDefault(x => x.ModelId == id);
            }
            return View("CreateModel", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditModel(car model)
        {
            if (ModelState.IsValid)
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    car tempModel = db.JagModels.FirstOrDefault(x => x.ModelId == model.ModelId);
                    tempModel.ModelName = model.ModelName;
                    tempModel.FirstYear = model.FirstYear;
                    tempModel.LastYear = model.LastYear;
                    tempModel.UnitsProduced = model.UnitsProduced;
                    tempModel.Description = model.Description;
                    tempModel.Synopsis = model.Synopsis;
                    tempModel.ImgUrl = model.ImgUrl;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            return View("CreateModel", model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
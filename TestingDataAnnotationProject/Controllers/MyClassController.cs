using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestingDataAnnotationProject.Models;

namespace TestingDataAnnotationProject.Controllers
{
    public class MyClassController : Controller
    {
        //
        // GET: /MyClass/
        public ActionResult Index()
        {
            return View(new List<MyClass>());
        }

        //
        // GET: /MyClass/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MyClass/Create
        [HttpPost]
        public ActionResult Create(MyClass myClass)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();

            }
        }

        //
        // GET: /MyClass/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /MyClass/Edit/5
        [HttpPost]
        public ActionResult Edit(MyClass myClass)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


    }
}

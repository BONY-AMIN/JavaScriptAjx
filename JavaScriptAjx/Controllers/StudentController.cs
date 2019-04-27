using JavaScriptAjx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JavaScriptAjx.Controllers
{
    public class StudentController : Controller
    {
        private AjaxContext std=new AjaxContext();
        // GET: Student
        public ActionResult Index()
        {
            return View();

        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create

        public JsonResult Create(Student st)
        {
            std.Students.Add(st);
            if (std.SaveChanges() > 0)
            {
                return Json(new { success = true, result = std });
            }
            else
            {
                return Json(new { success = false });
            }
        }
        public JsonResult show()
        {
            List<Student> st = std.Students.ToList();
            return Json(st, JsonRequestBehavior.AllowGet);
        }

        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Student/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

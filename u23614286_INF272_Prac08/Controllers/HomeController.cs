using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u23614286_INF272_Prac08.Models;

namespace u23614286_INF272_Prac08.Controllers
{
    public class HomeController : Controller
    {
        // Use the correct base class
        public static List<Shape> shapes = new List<Shape>();

        public ActionResult Index()
        {
            return View(shapes); // View to display all added shapes
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        // View for selecting shape type to add
        public ActionResult AddShape()
        {
            return View(); // Should have links/buttons to: Rectangle, Triangle, Ellipse, Square
        }

        // ---------------- Rectangle ----------------
        public ActionResult Rectangle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddRectangle(Rectangle r)
        {
            shapes.Add(r);
            return RedirectToAction("Index");
        }

        // ---------------- Ellipse ----------------
        public ActionResult Ellipse()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEllipse(Ellipse e)
        {
            shapes.Add(e);
            return RedirectToAction("Index");
        }

        // ---------------- Triangle ----------------
        public ActionResult Triangle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTriangle(Triangle t)
        {
            shapes.Add(t);
            return RedirectToAction("Index");
        }

        // GET: Show the Circle creation form
        public ActionResult Circle()
        {
            return View();
        }

        // POST: Handle Circle form submission
        [HttpPost]
        public ActionResult AddCircle(Circle c)
        {
            shapes.Add(c);
            return RedirectToAction("Index");
        }



        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }

}
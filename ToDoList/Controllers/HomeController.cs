using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.Models;
using ToDoList.Models.ToDoClass;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ModelBase modelBase = new ModelBase(new ToDoBase());
            return View(modelBase.GetToDoList());
        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult Delete(int Id)
        {
            ToDoBase toDoBase = new ToDoBase();
            toDoBase.Delete(Id);
            return RedirectToAction("Index");
        }
        public ActionResult ChangeStatus(int Id)
        {
            ToDoBase toDoBase = new ToDoBase();
            toDoBase.ChangeStatus(Id);
            return RedirectToAction("Index");
        }

        [OutputCache(Duration = 21600)]
        public ActionResult About()
        {

            ViewBag.Message = "hasancanguler@gmail.com";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



    }
}
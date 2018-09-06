using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.Models.ToDoClass;

namespace ToDoList.Controllers
{
    public class InsertController : Controller
    {
        // GET: Insert
        public ActionResult PartialIndex()
        {
            return PartialView("_Insert");
        }

        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Insert(ToDoList.Models.ToDoList ToDoList)
        {
            if (ModelState.IsValid)
            {
                ToDoBase toDoBase = new ToDoBase();
                toDoBase.Insert(ToDoList);
                return RedirectToAction("Index", "Home");
            }
            return View("Index");

        }

    }
}
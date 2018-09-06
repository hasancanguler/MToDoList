using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToDoList.Controllers
{
    public class DeleteController : Controller
    {
        // GET: Delete
        public ActionResult Index(int Id)
        {
            return View();
        }
    }
}
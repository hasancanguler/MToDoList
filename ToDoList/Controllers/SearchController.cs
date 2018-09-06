using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.Models;
using ToDoList.Models.ToDoClass;

namespace ToDoList.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            return PartialView("_Search");
        }

        public ActionResult Search(string Keyword)
        {
            SearchBase searchBase = new SearchBase(new SearchToDoList());
            return View(searchBase.Search(Keyword));
        }
    }
}
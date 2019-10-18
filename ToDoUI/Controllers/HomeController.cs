using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDo.MODEL.Context;

namespace ToDoUI.Controllers
{
    public class HomeController : Controller
    {
        ToDoAppContext db = new ToDoAppContext();
        public ActionResult Index()
        {
            return View();

        }

        public ActionResult Login()
        {
           

            return View();
        }

        
      
        public ActionResult Register()
        {
            

            return View();
        }
    }
}
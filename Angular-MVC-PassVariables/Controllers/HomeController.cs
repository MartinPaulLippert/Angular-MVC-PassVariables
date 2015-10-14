using Angular_MVC_PassVariables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Angular_MVC_PassVariables.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new MyModel {
                Id = Guid.NewGuid(),
                Name = "My Name",
                Value = 42
            });
        }
        
    }
}
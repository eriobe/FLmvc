using FLmvc.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FLmvc.Controllers
{
    public class PersonController : Controller
    {
        private PersonOperations po = new PersonOperations();
        // GET: Person
        public ActionResult Index()
        {
            var model = po.GetPersons();  
            return View(model);
        }

        public ActionResult ShowPerson()
        {
            return View();
        }
       
    }
}
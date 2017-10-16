using FLmvc.Data;
using FLmvc.Models;
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

        public ActionResult ShowPerson(int id=1)
        {
            var model = po.GetPersonById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult ShowPerson(Person model)
        {
            return View();
        }


    }
}
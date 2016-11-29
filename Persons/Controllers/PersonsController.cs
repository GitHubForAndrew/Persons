using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Persons.Abstract;
using Persons.Concrete;
using Persons.Models;
using System.Threading.Tasks;

namespace Persons.Controllers
{
    public class PersonsController : Controller
    {
        private PersonsRepository repo;

        public PersonsController()
        {
            repo = new PersonsRepository();
        }

        public async Task<ActionResult> Index()
        {
            ViewBag.Title = "Persons";
            var items = await repo.GetListAsync();
            return View(items);
        }
        
        //[AcceptVerbs(HttpVerbs.Get)]
        public async Task<PartialViewResult> GetMorePersons()
        {
            var list = await repo.GetMorePersosns();
            return PartialView("PersonsPartial", list);
        }
    }
}
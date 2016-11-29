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
        private IRepository<Person> repo;

        public PersonsController(IRepository<Person> repository)
        {
            repo = repository;
        }

        public async Task<ActionResult> Index()
        {
            ViewBag.Title = "Persons";
            var items = await repo.GetListAsync();
            return View(items);
        }
        
        public async Task<PartialViewResult> GetMorePersons()
        {
            var list = await repo.GetListAsync();
            return PartialView("PersonsPartial", list);
        }
    }
}